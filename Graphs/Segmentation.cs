using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Graphs
{
    class Segmentation
    {
        public enum NeighbourCount
        {
            Four = 4,
            Eight = 8,
        }
        public enum Terminal
        {
            None = -1,
            S = 0,
            T = 1,
        }

        public class Edge
        {
            public double weight;
        }

        public class Node
        {
            public int index;
            public int x;
            public int y;
            public double intensity;

            public double error;
            public int height;

            public List<int> neighbours;

            public bool isTerminal;
            public Terminal terminal;
        }

        // Common
        public bool isDebugLogEndabled;
        private Bitmap bitmap;
        // Graph
        private List<Node> nodes;
        private Dictionary<string, Edge> edges;
        private int lambda;
        private double sigma;
        // Segmentation
        private IntensityHistogram intensityHistogram;
        private double epsilon = 0.0000000001;

        public Segmentation(Bitmap bitmap, NeighbourCount neighbourCount = NeighbourCount.Eight, int lambda = 40, double sigma = 0.5)
        {
            this.bitmap = bitmap;
            this.lambda = lambda;
            this.sigma = sigma;
            intensityHistogram = new IntensityHistogram(bitmap);   

            CreateGraph(neighbourCount);
        }

        public void CreateGraph(NeighbourCount neighbourCount)
        {
            nodes = new List<Node>();
            edges = new Dictionary<string, Edge>();

            // Creating nodes
            var sTerminal = new Node
            {
                index = nodes.Count,
                x = -1,
                y = -1,
                intensity = intensityHistogram.AverageObjectIntensityReferece, // object intensity reference value
                error = Int32.MaxValue,
                isTerminal = true,
                terminal = Terminal.S,
                neighbours = new List<int>(),
            };

            nodes.Add(sTerminal);

            for (var i = 0; i < bitmap.Width; i++)
            {
                for (var j = 0; j < bitmap.Height; j++)
                {
                    var node = new Node
                    {
                        index = nodes.Count,
                        x = i,
                        y = j,
                        intensity = (int)(bitmap.GetPixel(i, j).GetBrightness() * 255),
                        error = 0,
                        height = 0,
                        isTerminal = false,
                        terminal = Terminal.None,
                        neighbours = new List<int>(),
                    };

                    nodes.Add(node);
                }
            }

            sTerminal.height = nodes.Count;

            var tTerminal = new Node
            {
                index = nodes.Count,
                x = -1,
                y = -1,
                intensity = intensityHistogram.AverageBackgroundIntensityReference, // background intensity reference value
                error = 0,
                height = 0,
                isTerminal = true,
                terminal = Terminal.T,
                neighbours = new List<int>(),
            };

            nodes.Add(tTerminal);

            for (var index = 1; index < nodes.Count - 1; index++)
            {
                var node = nodes[index];

                for (var i = -1; i < 2; i++)
                {
                    for (var j = -1; j < 2; j++)
                    {
                        if (neighbourCount == NeighbourCount.Four && Math.Abs(i) + Math.Abs(j) == 2 || i == 0 && j == 0)
                        {
                            continue;
                        }

                        var neighbour = GetNodeNeighbour(index, i, j);

                        if (neighbour != null)
                        {
                            var neighbourIndex = (int)neighbour?.index;

                            node.neighbours.Add(neighbourIndex);

                            edges.Add(GetEdgeKey(node.index, neighbourIndex), new Edge
                            {
                                weight = GetEdgeWeight(node, nodes[neighbourIndex]),
                            });
                        }
                    }
                }

                node.neighbours.Add(nodes.Count - 1);
                node.neighbours.Add(0);
                nodes[0].neighbours.Add(node.index);
                nodes[nodes.Count - 1].neighbours.Add(node.index);

                edges.Add(GetEdgeKey(node.index, 0), new Edge
                {
                    weight = 0,
                });
                edges.Add(GetEdgeKey(0, node.index), new Edge
                {
                    weight = GetEdgeWeight(nodes[0], node),
                });

                edges.Add(GetEdgeKey(node.index, nodes.Count - 1), new Edge
                {
                    weight = GetEdgeWeight(node, nodes[nodes.Count - 1]),
                });

                edges.Add(GetEdgeKey(nodes.Count - 1, node.index), new Edge
                {
                    weight = 0,
                });
            }
        }

        public string GetStringifiedGraph()
        {
            var log = nodes.Count + " " + edges.Keys.Count + "\n";
            var kek = 0;

            foreach (var pair in edges)
            {
                kek += 1;
                log += pair.Key + " " + pair.Value.weight + "\n";
            }

            return log;
        }

        public double GetMaxFlow()
        {
            Queue<Node> queue = new Queue<Node>();
            Node start = nodes[nodes.Count - 1];

            for (var i = 0; i < start.neighbours.Count; i++)
            {
                PushFlow(queue, start, nodes[start.neighbours[i]]);
            }
            start.error = 0;

            while (queue.Count != 0)
            {
                Node node = queue.Dequeue();

                if (!node.isTerminal)
                {
                    Discharge(queue, node);
                }
            }

            double maxFlow = 0;
 
            for (var i = 0; i < nodes.Count; i++)
            {
                Edge edge;
                bool isEdgeExist = edges.TryGetValue(GetEdgeKey(nodes.Count - 1, i), out edge);

                if (isEdgeExist)
                {
                    maxFlow += edge.weight;
                }
            }

            return maxFlow;
        }

        public Bitmap Cut()
        {
            GetMaxFlow();

            List<Node> cut = new List<Node>();
            Queue<Node> queue = new Queue<Node>();
            bool[] isVisited = new bool[nodes.Count];

            queue.Enqueue(nodes[0]);

            while (queue.Count != 0)
            {
                var node = queue.Dequeue();

                if (!isVisited[node.index])
                {
                    isVisited[node.index] = true;

                    for (var i = 0; i < node.neighbours.Count; i++)
                    {
                        if (!isVisited[node.neighbours[i]])
                        {
                            Edge edge;
                            bool isEdgeExist = edges.TryGetValue(GetEdgeKey(node.index, node.neighbours[i]), out edge);

                            if (isEdgeExist && edge.weight > epsilon)
                            {
                                queue.Enqueue(nodes[node.neighbours[i]]);
                                cut.Add(nodes[node.neighbours[i]]);
                            } 
                        }
                    }
                }
            }

            Bitmap segmentatedImageBitmap = new Bitmap(bitmap);

            for (var i = 0; i < cut.Count; i++)
            {
                var node = cut[i];

                if (!node.isTerminal)
                {
                    var pixel = bitmap.GetPixel(node.x, node.y);

                    segmentatedImageBitmap.SetPixel(node.x, node.y, Color.FromArgb(100, 100, 200));
                }
            }

            return segmentatedImageBitmap;
        }

        private void PushFlow(Queue<Node> queue, Node from, Node to)
        {
            if (isDebugLogEndabled)
                Console.WriteLine("PushFlow" + " " + from.index + " " + to.index);

            Edge edge;
            bool isEdgeExist = edges.TryGetValue(GetEdgeKey(from.index, to.index), out edge);

            if (isEdgeExist)
            {
                double flow = Math.Min(from.error, edge.weight);


                Edge reverseEdge;
                edges.TryGetValue(GetEdgeKey(to.index, from.index), out reverseEdge);

                reverseEdge.weight += flow;
                edge.weight -= flow;
                from.error -= flow;
                to.error += flow;

                if (flow > epsilon && Math.Abs(to.error - flow) <= epsilon && !queue.Contains(to))
                {
                    queue.Enqueue(to);
                }
            }
        }

        private void Discharge(Queue<Node> queue, Node node)
        {
            if (isDebugLogEndabled)
                Console.WriteLine("Discharge" + " " + node.index + " " + node.error);

            while (node.error > 0)
            {                
                for (var i = 0; i < node.neighbours.Count; i++)
                {
                    Edge edge;
                    bool isEdgeExist = edges.TryGetValue(GetEdgeKey(node.index, node.neighbours[i]), out edge);
                    var neighbour = nodes[node.neighbours[i]];

                    if (Math.Round(edge.weight, 10) > 0 && node.height > neighbour.height)
                    {
                        PushFlow(queue, node, neighbour);
                    }
                }

                if (node.error > 0)
                {
                    Relabel(node);
                }
            }
        }

        private void Relabel(Node node)
        {
            int minHeight = Int32.MaxValue;

            for (var i = 0; i < node.neighbours.Count; i++)
            {
                Edge edge;
                bool isEdgeExist = edges.TryGetValue(GetEdgeKey(node.index, node.neighbours[i]), out edge);

                if (isEdgeExist)
                {
                    if (edge.weight > epsilon)
                    {
                        minHeight = Math.Min(minHeight, nodes[node.neighbours[i]].height);
                    }
                }
            }

            if (isDebugLogEndabled)
                Console.WriteLine("Relabel" + " " + node.index + " " + node.height + " -> " + (minHeight + 1));

            node.height = minHeight + 1;
        }

        private double GetEdgeWeight(Node from, Node to)
        {
            int multiplier = 100;
            
            // n-links weight
            if (!to.isTerminal && !from.isTerminal)
            {
                var delta = Math.Pow(from.intensity - to.intensity, 2);
                var weight = Math.Exp(-1 * delta / (2 * Math.Pow(sigma, 2)));

                return (int)(weight * multiplier);
            }
            // t-links weight
            else
            {
                var delta = Math.Pow(from.intensity - to.intensity, 2);
                var weight = lambda * Math.Exp(-1 * delta / 2);

                return (int)(weight * multiplier);
            }
        }

        private Node GetNodeNeighbour(int nodeIndex, int offsetI, int offsetJ)
        {
            int neighbourI = (nodeIndex - 1) / bitmap.Height + offsetI;
            int neighbourJ = (nodeIndex - 1) % bitmap.Height + offsetJ;

            if (neighbourJ < 0 || neighbourJ > bitmap.Height - 1)
            {
                return null;
            }

            if (neighbourI < 0 || neighbourI > bitmap.Width - 1)
            {
                return null;
            }

            int neighbourIndex = neighbourI * bitmap.Height + neighbourJ + 1; 

            return nodes[neighbourIndex];
        }

        private string GetEdgeKey(int from, int to)
        {
            return from + " " + to;
        }
    }
}
