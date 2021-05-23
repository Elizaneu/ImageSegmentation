namespace Graphs
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_selectImage = new System.Windows.Forms.Button();
            this.pctrbx_SelectedImage = new System.Windows.Forms.PictureBox();
            this.btn_buildGraph = new System.Windows.Forms.Button();
            this.btn_calculateMaxFlow = new System.Windows.Forms.Button();
            this.btn_printGraph = new System.Windows.Forms.Button();
            this.btn_segment = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pctrbx_backgroundImage = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pctrbx_objectImage = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbx_SelectedImage)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbx_backgroundImage)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbx_objectImage)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_selectImage
            // 
            this.btn_selectImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_selectImage.Location = new System.Drawing.Point(765, 1);
            this.btn_selectImage.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btn_selectImage.Name = "btn_selectImage";
            this.btn_selectImage.Size = new System.Drawing.Size(107, 27);
            this.btn_selectImage.TabIndex = 0;
            this.btn_selectImage.Text = "Select image...";
            this.btn_selectImage.UseVisualStyleBackColor = true;
            this.btn_selectImage.Click += new System.EventHandler(this.btn_selectImage_Click);
            // 
            // pctrbx_SelectedImage
            // 
            this.pctrbx_SelectedImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctrbx_SelectedImage.ImageLocation = "C:\\Users\\eliza\\Desktop\\pixil-frame-0.png";
            this.pctrbx_SelectedImage.Location = new System.Drawing.Point(3, 16);
            this.pctrbx_SelectedImage.Margin = new System.Windows.Forms.Padding(0);
            this.pctrbx_SelectedImage.Name = "pctrbx_SelectedImage";
            this.pctrbx_SelectedImage.Size = new System.Drawing.Size(278, 346);
            this.pctrbx_SelectedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrbx_SelectedImage.TabIndex = 1;
            this.pctrbx_SelectedImage.TabStop = false;
            // 
            // btn_buildGraph
            // 
            this.btn_buildGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_buildGraph.Location = new System.Drawing.Point(546, 1);
            this.btn_buildGraph.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btn_buildGraph.Name = "btn_buildGraph";
            this.btn_buildGraph.Size = new System.Drawing.Size(104, 27);
            this.btn_buildGraph.TabIndex = 3;
            this.btn_buildGraph.Text = "Build graph";
            this.btn_buildGraph.UseVisualStyleBackColor = true;
            this.btn_buildGraph.Click += new System.EventHandler(this.btn_buildGraph_Click);
            // 
            // btn_calculateMaxFlow
            // 
            this.btn_calculateMaxFlow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_calculateMaxFlow.Location = new System.Drawing.Point(652, 0);
            this.btn_calculateMaxFlow.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btn_calculateMaxFlow.Name = "btn_calculateMaxFlow";
            this.btn_calculateMaxFlow.Size = new System.Drawing.Size(111, 28);
            this.btn_calculateMaxFlow.TabIndex = 4;
            this.btn_calculateMaxFlow.Text = "Calculate max flow";
            this.btn_calculateMaxFlow.UseVisualStyleBackColor = true;
            this.btn_calculateMaxFlow.Click += new System.EventHandler(this.btn_calculateMaxFlow_Click);
            // 
            // btn_printGraph
            // 
            this.btn_printGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_printGraph.Location = new System.Drawing.Point(469, 0);
            this.btn_printGraph.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btn_printGraph.Name = "btn_printGraph";
            this.btn_printGraph.Size = new System.Drawing.Size(75, 28);
            this.btn_printGraph.TabIndex = 5;
            this.btn_printGraph.Text = "Print graph";
            this.btn_printGraph.UseVisualStyleBackColor = true;
            this.btn_printGraph.Click += new System.EventHandler(this.btn_printGraph_Click);
            // 
            // btn_segment
            // 
            this.btn_segment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_segment.Location = new System.Drawing.Point(397, 0);
            this.btn_segment.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btn_segment.Name = "btn_segment";
            this.btn_segment.Size = new System.Drawing.Size(70, 28);
            this.btn_segment.TabIndex = 6;
            this.btn_segment.Text = "Segment";
            this.btn_segment.UseVisualStyleBackColor = true;
            this.btn_segment.Click += new System.EventHandler(this.btn_segment_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_selectImage);
            this.flowLayoutPanel1.Controls.Add(this.btn_calculateMaxFlow);
            this.flowLayoutPanel1.Controls.Add(this.btn_buildGraph);
            this.flowLayoutPanel1.Controls.Add(this.btn_printGraph);
            this.flowLayoutPanel1.Controls.Add(this.btn_segment);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 427);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(872, 29);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pctrbx_SelectedImage);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 365);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected image";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pctrbx_backgroundImage);
            this.groupBox2.Location = new System.Drawing.Point(293, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 365);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Background";
            // 
            // pctrbx_backgroundImage
            // 
            this.pctrbx_backgroundImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctrbx_backgroundImage.ImageLocation = "";
            this.pctrbx_backgroundImage.Location = new System.Drawing.Point(3, 16);
            this.pctrbx_backgroundImage.Margin = new System.Windows.Forms.Padding(0);
            this.pctrbx_backgroundImage.Name = "pctrbx_backgroundImage";
            this.pctrbx_backgroundImage.Size = new System.Drawing.Size(278, 346);
            this.pctrbx_backgroundImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrbx_backgroundImage.TabIndex = 1;
            this.pctrbx_backgroundImage.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pctrbx_objectImage);
            this.groupBox3.Location = new System.Drawing.Point(583, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(286, 365);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Object";
            // 
            // pctrbx_objectImage
            // 
            this.pctrbx_objectImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctrbx_objectImage.ImageLocation = "";
            this.pctrbx_objectImage.Location = new System.Drawing.Point(3, 16);
            this.pctrbx_objectImage.Margin = new System.Windows.Forms.Padding(0);
            this.pctrbx_objectImage.Name = "pctrbx_objectImage";
            this.pctrbx_objectImage.Size = new System.Drawing.Size(280, 346);
            this.pctrbx_objectImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrbx_objectImage.TabIndex = 1;
            this.pctrbx_objectImage.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(872, 415);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 468);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.Text = "CutPro2000";
            ((System.ComponentModel.ISupportInitialize)(this.pctrbx_SelectedImage)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctrbx_backgroundImage)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctrbx_objectImage)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_selectImage;
        private System.Windows.Forms.PictureBox pctrbx_SelectedImage;
        private System.Windows.Forms.Button btn_buildGraph;
        private System.Windows.Forms.Button btn_calculateMaxFlow;
        private System.Windows.Forms.Button btn_printGraph;
        private System.Windows.Forms.Button btn_segment;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pctrbx_backgroundImage;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pctrbx_objectImage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

