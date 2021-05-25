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
            this.pctrbx_selectedImage = new System.Windows.Forms.PictureBox();
            this.btn_segmentBackground = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_segmentObject = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_selectBackgroundBrush = new System.Windows.Forms.Button();
            this.btn_selectObjectBrush = new System.Windows.Forms.Button();
            this.inpt_backgroundBrushSize = new System.Windows.Forms.NumericUpDown();
            this.inpt_objectBrushSize = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pctrbx_backgroundImage = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pctrbx_objectImage = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbx_selectedImage)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inpt_backgroundBrushSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpt_objectBrushSize)).BeginInit();
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
            this.btn_selectImage.Location = new System.Drawing.Point(718, 2);
            this.btn_selectImage.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btn_selectImage.Name = "btn_selectImage";
            this.btn_selectImage.Size = new System.Drawing.Size(107, 27);
            this.btn_selectImage.TabIndex = 0;
            this.btn_selectImage.Text = "Select image...";
            this.btn_selectImage.UseVisualStyleBackColor = true;
            this.btn_selectImage.Click += new System.EventHandler(this.btn_selectImage_Click);
            // 
            // pctrbx_selectedImage
            // 
            this.pctrbx_selectedImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctrbx_selectedImage.ImageLocation = "C:\\Users\\eliza\\Desktop\\images-320\\fullmoon-gr-320.jpg";
            this.pctrbx_selectedImage.Location = new System.Drawing.Point(3, 16);
            this.pctrbx_selectedImage.Margin = new System.Windows.Forms.Padding(0);
            this.pctrbx_selectedImage.Name = "pctrbx_selectedImage";
            this.pctrbx_selectedImage.Size = new System.Drawing.Size(263, 255);
            this.pctrbx_selectedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrbx_selectedImage.TabIndex = 1;
            this.pctrbx_selectedImage.TabStop = false;
            this.pctrbx_selectedImage.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pctrbx_selectedImage_LoadCompleted);
            this.pctrbx_selectedImage.Paint += new System.Windows.Forms.PaintEventHandler(this.pctrbx_selectedImage_Paint);
            this.pctrbx_selectedImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pctrbx_selectedImage_MouseDown);
            this.pctrbx_selectedImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pctrbx_selectedImage_MouseMove);
            this.pctrbx_selectedImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pctrbx_selectedImage_MouseUp);
            // 
            // btn_segmentBackground
            // 
            this.btn_segmentBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_segmentBackground.Location = new System.Drawing.Point(599, 1);
            this.btn_segmentBackground.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btn_segmentBackground.Name = "btn_segmentBackground";
            this.btn_segmentBackground.Size = new System.Drawing.Size(117, 28);
            this.btn_segmentBackground.TabIndex = 6;
            this.btn_segmentBackground.Text = "Show background";
            this.btn_segmentBackground.UseVisualStyleBackColor = true;
            this.btn_segmentBackground.Click += new System.EventHandler(this.btn_segmentBackground_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_selectImage);
            this.flowLayoutPanel1.Controls.Add(this.btn_segmentBackground);
            this.flowLayoutPanel1.Controls.Add(this.btn_segmentObject);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 392);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(825, 29);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // btn_segmentObject
            // 
            this.btn_segmentObject.Location = new System.Drawing.Point(522, 0);
            this.btn_segmentObject.Margin = new System.Windows.Forms.Padding(0);
            this.btn_segmentObject.Name = "btn_segmentObject";
            this.btn_segmentObject.Size = new System.Drawing.Size(75, 29);
            this.btn_segmentObject.TabIndex = 7;
            this.btn_segmentObject.Text = "Show object";
            this.btn_segmentObject.UseVisualStyleBackColor = true;
            this.btn_segmentObject.Click += new System.EventHandler(this.btn_segmentObject_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pctrbx_selectedImage);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 374);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected image";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel2);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(3, 271);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(263, 100);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Brush settings";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btn_selectBackgroundBrush, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_selectObjectBrush, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.inpt_backgroundBrushSize, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.inpt_objectBrushSize, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(257, 81);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btn_selectBackgroundBrush
            // 
            this.btn_selectBackgroundBrush.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_selectBackgroundBrush.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_selectBackgroundBrush.Location = new System.Drawing.Point(3, 3);
            this.btn_selectBackgroundBrush.Name = "btn_selectBackgroundBrush";
            this.btn_selectBackgroundBrush.Size = new System.Drawing.Size(79, 34);
            this.btn_selectBackgroundBrush.TabIndex = 0;
            this.btn_selectBackgroundBrush.Text = "Select T";
            this.btn_selectBackgroundBrush.UseVisualStyleBackColor = false;
            this.btn_selectBackgroundBrush.Click += new System.EventHandler(this.btn_selectBackgroundBrush_Click);
            // 
            // btn_selectObjectBrush
            // 
            this.btn_selectObjectBrush.BackColor = System.Drawing.Color.MistyRose;
            this.btn_selectObjectBrush.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_selectObjectBrush.Location = new System.Drawing.Point(3, 43);
            this.btn_selectObjectBrush.Name = "btn_selectObjectBrush";
            this.btn_selectObjectBrush.Size = new System.Drawing.Size(79, 35);
            this.btn_selectObjectBrush.TabIndex = 1;
            this.btn_selectObjectBrush.Text = "Select S";
            this.btn_selectObjectBrush.UseVisualStyleBackColor = false;
            this.btn_selectObjectBrush.Click += new System.EventHandler(this.btn_selectObjectBrush_Click);
            // 
            // inpt_backgroundBrushSize
            // 
            this.inpt_backgroundBrushSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inpt_backgroundBrushSize.Location = new System.Drawing.Point(172, 2);
            this.inpt_backgroundBrushSize.Margin = new System.Windows.Forms.Padding(2);
            this.inpt_backgroundBrushSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inpt_backgroundBrushSize.Name = "inpt_backgroundBrushSize";
            this.inpt_backgroundBrushSize.Size = new System.Drawing.Size(83, 20);
            this.inpt_backgroundBrushSize.TabIndex = 2;
            this.inpt_backgroundBrushSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inpt_backgroundBrushSize.ValueChanged += new System.EventHandler(this.inpt_backgroundBrushSize_ValueChanged);
            // 
            // inpt_objectBrushSize
            // 
            this.inpt_objectBrushSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inpt_objectBrushSize.Location = new System.Drawing.Point(172, 42);
            this.inpt_objectBrushSize.Margin = new System.Windows.Forms.Padding(2);
            this.inpt_objectBrushSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inpt_objectBrushSize.Name = "inpt_objectBrushSize";
            this.inpt_objectBrushSize.Size = new System.Drawing.Size(83, 20);
            this.inpt_objectBrushSize.TabIndex = 3;
            this.inpt_objectBrushSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inpt_objectBrushSize.ValueChanged += new System.EventHandler(this.inpt_objectBrushSize_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pctrbx_backgroundImage);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(278, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 374);
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
            this.pctrbx_backgroundImage.Size = new System.Drawing.Size(263, 355);
            this.pctrbx_backgroundImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrbx_backgroundImage.TabIndex = 1;
            this.pctrbx_backgroundImage.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pctrbx_objectImage);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(553, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(269, 374);
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
            this.pctrbx_objectImage.Size = new System.Drawing.Size(263, 355);
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
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(825, 380);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 433);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Text = "CutPro2000";
            ((System.ComponentModel.ISupportInitialize)(this.pctrbx_selectedImage)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inpt_backgroundBrushSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpt_objectBrushSize)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctrbx_backgroundImage)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctrbx_objectImage)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_selectImage;
        private System.Windows.Forms.PictureBox pctrbx_selectedImage;
        private System.Windows.Forms.Button btn_segmentBackground;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pctrbx_backgroundImage;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pctrbx_objectImage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_segmentObject;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_selectBackgroundBrush;
        private System.Windows.Forms.Button btn_selectObjectBrush;
        private System.Windows.Forms.NumericUpDown inpt_backgroundBrushSize;
        private System.Windows.Forms.NumericUpDown inpt_objectBrushSize;
    }
}

