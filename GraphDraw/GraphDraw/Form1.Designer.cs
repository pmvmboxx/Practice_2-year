namespace GraphDrawSpace
{
    partial class GraphDraw
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphDraw));
            this.pictureBoxCanvas = new System.Windows.Forms.PictureBox();
            this.toolPanel = new System.Windows.Forms.Panel();
            this.pictureBoxMoveGraph = new System.Windows.Forms.PictureBox();
            this.pictureBoxClear = new System.Windows.Forms.PictureBox();
            this.pictureBoxBuildgraph = new System.Windows.Forms.PictureBox();
            this.pictureBoxPalette = new System.Windows.Forms.PictureBox();
            this.comboBoxBuiltGraphs = new System.Windows.Forms.ComboBox();
            this.pictureBoxOpenNewFile = new System.Windows.Forms.PictureBox();
            this.buttonMoveGraph = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.BuildGraphButton = new System.Windows.Forms.Button();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.buttonSaveNameGraph = new System.Windows.Forms.Button();
            this.labelMoveY = new System.Windows.Forms.Label();
            this.labelMoveX = new System.Windows.Forms.Label();
            this.labelGraphForMove = new System.Windows.Forms.Label();
            this.textBoxMoveOY = new System.Windows.Forms.TextBox();
            this.textBoxMoveOX = new System.Windows.Forms.TextBox();
            this.NameOfGraph = new System.Windows.Forms.TextBox();
            this.labelGraphColor = new System.Windows.Forms.Label();
            this.buttonColorLime = new System.Windows.Forms.Button();
            this.buttonColorRoyalBlue = new System.Windows.Forms.Button();
            this.buttonColorOrange = new System.Windows.Forms.Button();
            this.buttonColorViolet = new System.Windows.Forms.Button();
            this.buttonColorCrimson = new System.Windows.Forms.Button();
            this.buttonColorBlue = new System.Windows.Forms.Button();
            this.groupOfDepictedGraphs = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).BeginInit();
            this.toolPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoveGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuildgraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPalette)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpenNewFile)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCanvas
            // 
            this.pictureBoxCanvas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBoxCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCanvas.Location = new System.Drawing.Point(4, 150);
            this.pictureBoxCanvas.Name = "pictureBoxCanvas";
            this.pictureBoxCanvas.Size = new System.Drawing.Size(947, 607);
            this.pictureBoxCanvas.TabIndex = 0;
            this.pictureBoxCanvas.TabStop = false;
            this.pictureBoxCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxCanvas_Paint);
            // 
            // toolPanel
            // 
            this.toolPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.toolPanel.Controls.Add(this.pictureBoxMoveGraph);
            this.toolPanel.Controls.Add(this.pictureBoxClear);
            this.toolPanel.Controls.Add(this.pictureBoxBuildgraph);
            this.toolPanel.Controls.Add(this.pictureBoxPalette);
            this.toolPanel.Controls.Add(this.comboBoxBuiltGraphs);
            this.toolPanel.Controls.Add(this.pictureBoxOpenNewFile);
            this.toolPanel.Controls.Add(this.buttonMoveGraph);
            this.toolPanel.Controls.Add(this.buttonClear);
            this.toolPanel.Controls.Add(this.BuildGraphButton);
            this.toolPanel.Controls.Add(this.OpenFileButton);
            this.toolPanel.Controls.Add(this.buttonSaveNameGraph);
            this.toolPanel.Controls.Add(this.labelMoveY);
            this.toolPanel.Controls.Add(this.labelMoveX);
            this.toolPanel.Controls.Add(this.labelGraphForMove);
            this.toolPanel.Controls.Add(this.textBoxMoveOY);
            this.toolPanel.Controls.Add(this.textBoxMoveOX);
            this.toolPanel.Controls.Add(this.NameOfGraph);
            this.toolPanel.Controls.Add(this.labelGraphColor);
            this.toolPanel.Controls.Add(this.buttonColorLime);
            this.toolPanel.Controls.Add(this.buttonColorRoyalBlue);
            this.toolPanel.Controls.Add(this.buttonColorOrange);
            this.toolPanel.Controls.Add(this.buttonColorViolet);
            this.toolPanel.Controls.Add(this.buttonColorCrimson);
            this.toolPanel.Controls.Add(this.buttonColorBlue);
            this.toolPanel.Location = new System.Drawing.Point(958, 3);
            this.toolPanel.Name = "toolPanel";
            this.toolPanel.Size = new System.Drawing.Size(279, 765);
            this.toolPanel.TabIndex = 2;
            // 
            // pictureBoxMoveGraph
            // 
            this.pictureBoxMoveGraph.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMoveGraph.Image")));
            this.pictureBoxMoveGraph.Location = new System.Drawing.Point(202, 661);
            this.pictureBoxMoveGraph.Name = "pictureBoxMoveGraph";
            this.pictureBoxMoveGraph.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxMoveGraph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxMoveGraph.TabIndex = 24;
            this.pictureBoxMoveGraph.TabStop = false;
            // 
            // pictureBoxClear
            // 
            this.pictureBoxClear.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClear.Image")));
            this.pictureBoxClear.Location = new System.Drawing.Point(168, 356);
            this.pictureBoxClear.Name = "pictureBoxClear";
            this.pictureBoxClear.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxClear.TabIndex = 23;
            this.pictureBoxClear.TabStop = false;
            // 
            // pictureBoxBuildgraph
            // 
            this.pictureBoxBuildgraph.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBuildgraph.Image")));
            this.pictureBoxBuildgraph.Location = new System.Drawing.Point(195, 295);
            this.pictureBoxBuildgraph.Name = "pictureBoxBuildgraph";
            this.pictureBoxBuildgraph.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxBuildgraph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxBuildgraph.TabIndex = 22;
            this.pictureBoxBuildgraph.TabStop = false;
            // 
            // pictureBoxPalette
            // 
            this.pictureBoxPalette.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPalette.Image")));
            this.pictureBoxPalette.Location = new System.Drawing.Point(71, 127);
            this.pictureBoxPalette.Name = "pictureBoxPalette";
            this.pictureBoxPalette.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxPalette.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxPalette.TabIndex = 21;
            this.pictureBoxPalette.TabStop = false;
            // 
            // comboBoxBuiltGraphs
            // 
            this.comboBoxBuiltGraphs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.comboBoxBuiltGraphs.FormattingEnabled = true;
            this.comboBoxBuiltGraphs.Location = new System.Drawing.Point(85, 525);
            this.comboBoxBuiltGraphs.Name = "comboBoxBuiltGraphs";
            this.comboBoxBuiltGraphs.Size = new System.Drawing.Size(121, 26);
            this.comboBoxBuiltGraphs.TabIndex = 20;
            // 
            // pictureBoxOpenNewFile
            // 
            this.pictureBoxOpenNewFile.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOpenNewFile.Image")));
            this.pictureBoxOpenNewFile.Location = new System.Drawing.Point(242, 17);
            this.pictureBoxOpenNewFile.Name = "pictureBoxOpenNewFile";
            this.pictureBoxOpenNewFile.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxOpenNewFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxOpenNewFile.TabIndex = 19;
            this.pictureBoxOpenNewFile.TabStop = false;
            // 
            // buttonMoveGraph
            // 
            this.buttonMoveGraph.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.buttonMoveGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMoveGraph.Font = new System.Drawing.Font("Microsoft YaHei Light", 11.25F, System.Drawing.FontStyle.Italic);
            this.buttonMoveGraph.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonMoveGraph.Location = new System.Drawing.Point(-1, 646);
            this.buttonMoveGraph.Name = "buttonMoveGraph";
            this.buttonMoveGraph.Size = new System.Drawing.Size(279, 54);
            this.buttonMoveGraph.TabIndex = 18;
            this.buttonMoveGraph.Text = "Move the graph";
            this.buttonMoveGraph.UseVisualStyleBackColor = true;
            this.buttonMoveGraph.Click += new System.EventHandler(this.buttonMoveGraph_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft YaHei Light", 11.25F, System.Drawing.FontStyle.Italic);
            this.buttonClear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonClear.Location = new System.Drawing.Point(3, 341);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(279, 54);
            this.buttonClear.TabIndex = 17;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // BuildGraphButton
            // 
            this.BuildGraphButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.BuildGraphButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuildGraphButton.Font = new System.Drawing.Font("Microsoft YaHei Light", 11.25F, System.Drawing.FontStyle.Italic);
            this.BuildGraphButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BuildGraphButton.Location = new System.Drawing.Point(0, 281);
            this.BuildGraphButton.Name = "BuildGraphButton";
            this.BuildGraphButton.Size = new System.Drawing.Size(279, 54);
            this.BuildGraphButton.TabIndex = 8;
            this.BuildGraphButton.Text = "Build the graph";
            this.BuildGraphButton.UseVisualStyleBackColor = true;
            this.BuildGraphButton.Click += new System.EventHandler(this.BuildGraphButton_Click);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.OpenFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFileButton.Font = new System.Drawing.Font("Microsoft YaHei Light", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenFileButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.OpenFileButton.Location = new System.Drawing.Point(1, 3);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(275, 54);
            this.OpenFileButton.TabIndex = 0;
            this.OpenFileButton.Text = "Open new file";
            this.OpenFileButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // buttonSaveNameGraph
            // 
            this.buttonSaveNameGraph.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.buttonSaveNameGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveNameGraph.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveNameGraph.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSaveNameGraph.Location = new System.Drawing.Point(189, 63);
            this.buttonSaveNameGraph.Name = "buttonSaveNameGraph";
            this.buttonSaveNameGraph.Size = new System.Drawing.Size(87, 43);
            this.buttonSaveNameGraph.TabIndex = 14;
            this.buttonSaveNameGraph.Text = "Save";
            this.buttonSaveNameGraph.UseVisualStyleBackColor = true;
            this.buttonSaveNameGraph.Click += new System.EventHandler(this.buttonSaveNameGraph_Click);
            // 
            // labelMoveY
            // 
            this.labelMoveY.AutoSize = true;
            this.labelMoveY.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelMoveY.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelMoveY.Location = new System.Drawing.Point(202, 567);
            this.labelMoveY.Name = "labelMoveY";
            this.labelMoveY.Size = new System.Drawing.Size(35, 19);
            this.labelMoveY.TabIndex = 13;
            this.labelMoveY.Text = "OY:";
            // 
            // labelMoveX
            // 
            this.labelMoveX.AutoSize = true;
            this.labelMoveX.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelMoveX.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelMoveX.Location = new System.Drawing.Point(43, 567);
            this.labelMoveX.Name = "labelMoveX";
            this.labelMoveX.Size = new System.Drawing.Size(36, 19);
            this.labelMoveX.TabIndex = 12;
            this.labelMoveX.Text = "OX:";
            // 
            // labelGraphForMove
            // 
            this.labelGraphForMove.AutoSize = true;
            this.labelGraphForMove.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelGraphForMove.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelGraphForMove.Location = new System.Drawing.Point(40, 490);
            this.labelGraphForMove.Name = "labelGraphForMove";
            this.labelGraphForMove.Size = new System.Drawing.Size(216, 19);
            this.labelGraphForMove.TabIndex = 11;
            this.labelGraphForMove.Text = "Choose the graph for move";
            // 
            // textBoxMoveOY
            // 
            this.textBoxMoveOY.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxMoveOY.Location = new System.Drawing.Point(166, 598);
            this.textBoxMoveOY.Name = "textBoxMoveOY";
            this.textBoxMoveOY.Size = new System.Drawing.Size(100, 24);
            this.textBoxMoveOY.TabIndex = 10;
            // 
            // textBoxMoveOX
            // 
            this.textBoxMoveOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxMoveOX.Location = new System.Drawing.Point(11, 598);
            this.textBoxMoveOX.Name = "textBoxMoveOX";
            this.textBoxMoveOX.Size = new System.Drawing.Size(100, 24);
            this.textBoxMoveOX.TabIndex = 9;
            // 
            // NameOfGraph
            // 
            this.NameOfGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameOfGraph.Location = new System.Drawing.Point(11, 74);
            this.NameOfGraph.Name = "NameOfGraph";
            this.NameOfGraph.Size = new System.Drawing.Size(172, 24);
            this.NameOfGraph.TabIndex = 7;
            this.NameOfGraph.Text = "Name of the graph";
            // 
            // labelGraphColor
            // 
            this.labelGraphColor.AutoSize = true;
            this.labelGraphColor.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGraphColor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelGraphColor.Location = new System.Drawing.Point(101, 132);
            this.labelGraphColor.Name = "labelGraphColor";
            this.labelGraphColor.Size = new System.Drawing.Size(107, 19);
            this.labelGraphColor.TabIndex = 6;
            this.labelGraphColor.Text = "Choose color";
            // 
            // buttonColorLime
            // 
            this.buttonColorLime.BackColor = System.Drawing.Color.Lime;
            this.buttonColorLime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonColorLime.Location = new System.Drawing.Point(225, 168);
            this.buttonColorLime.Name = "buttonColorLime";
            this.buttonColorLime.Size = new System.Drawing.Size(33, 92);
            this.buttonColorLime.TabIndex = 5;
            this.buttonColorLime.UseVisualStyleBackColor = false;
            // 
            // buttonColorRoyalBlue
            // 
            this.buttonColorRoyalBlue.BackColor = System.Drawing.Color.MediumBlue;
            this.buttonColorRoyalBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonColorRoyalBlue.Location = new System.Drawing.Point(146, 168);
            this.buttonColorRoyalBlue.Name = "buttonColorRoyalBlue";
            this.buttonColorRoyalBlue.Size = new System.Drawing.Size(34, 92);
            this.buttonColorRoyalBlue.TabIndex = 4;
            this.buttonColorRoyalBlue.UseVisualStyleBackColor = false;
            // 
            // buttonColorOrange
            // 
            this.buttonColorOrange.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonColorOrange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonColorOrange.Location = new System.Drawing.Point(66, 168);
            this.buttonColorOrange.Name = "buttonColorOrange";
            this.buttonColorOrange.Size = new System.Drawing.Size(34, 92);
            this.buttonColorOrange.TabIndex = 3;
            this.buttonColorOrange.UseVisualStyleBackColor = false;
            // 
            // buttonColorViolet
            // 
            this.buttonColorViolet.BackColor = System.Drawing.Color.MediumVioletRed;
            this.buttonColorViolet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonColorViolet.Location = new System.Drawing.Point(186, 168);
            this.buttonColorViolet.Name = "buttonColorViolet";
            this.buttonColorViolet.Size = new System.Drawing.Size(33, 92);
            this.buttonColorViolet.TabIndex = 2;
            this.buttonColorViolet.UseVisualStyleBackColor = false;
            // 
            // buttonColorCrimson
            // 
            this.buttonColorCrimson.BackColor = System.Drawing.Color.Crimson;
            this.buttonColorCrimson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonColorCrimson.Location = new System.Drawing.Point(106, 168);
            this.buttonColorCrimson.Name = "buttonColorCrimson";
            this.buttonColorCrimson.Size = new System.Drawing.Size(34, 92);
            this.buttonColorCrimson.TabIndex = 1;
            this.buttonColorCrimson.UseVisualStyleBackColor = false;
            // 
            // buttonColorBlue
            // 
            this.buttonColorBlue.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonColorBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonColorBlue.Location = new System.Drawing.Point(26, 168);
            this.buttonColorBlue.Name = "buttonColorBlue";
            this.buttonColorBlue.Size = new System.Drawing.Size(34, 92);
            this.buttonColorBlue.TabIndex = 0;
            this.buttonColorBlue.UseVisualStyleBackColor = false;
            // 
            // groupOfDepictedGraphs
            // 
            this.groupOfDepictedGraphs.BackColor = System.Drawing.Color.MintCream;
            this.groupOfDepictedGraphs.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupOfDepictedGraphs.Location = new System.Drawing.Point(4, 12);
            this.groupOfDepictedGraphs.Name = "groupOfDepictedGraphs";
            this.groupOfDepictedGraphs.Size = new System.Drawing.Size(948, 122);
            this.groupOfDepictedGraphs.TabIndex = 3;
            this.groupOfDepictedGraphs.TabStop = false;
            this.groupOfDepictedGraphs.Text = "Depicted graphs";
            // 
            // GraphDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1239, 769);
            this.Controls.Add(this.groupOfDepictedGraphs);
            this.Controls.Add(this.toolPanel);
            this.Controls.Add(this.pictureBoxCanvas);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GraphDraw";
            this.Text = "GraphDraw";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).EndInit();
            this.toolPanel.ResumeLayout(false);
            this.toolPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoveGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuildgraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPalette)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpenNewFile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCanvas;
        private System.Windows.Forms.Panel toolPanel;
        private System.Windows.Forms.GroupBox groupOfDepictedGraphs;
        private System.Windows.Forms.Button buttonColorBlue;
        private System.Windows.Forms.Label labelGraphColor;
        private System.Windows.Forms.Button buttonColorLime;
        private System.Windows.Forms.Button buttonColorRoyalBlue;
        private System.Windows.Forms.Button buttonColorOrange;
        private System.Windows.Forms.Button buttonColorViolet;
        private System.Windows.Forms.Button buttonColorCrimson;
        private System.Windows.Forms.PictureBox pictureBoxOpenNewFile;
        private System.Windows.Forms.Button buttonMoveGraph;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button BuildGraphButton;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Button buttonSaveNameGraph;
        private System.Windows.Forms.Label labelMoveY;
        private System.Windows.Forms.Label labelMoveX;
        private System.Windows.Forms.Label labelGraphForMove;
        private System.Windows.Forms.TextBox textBoxMoveOY;
        private System.Windows.Forms.TextBox textBoxMoveOX;
        private System.Windows.Forms.TextBox NameOfGraph;
        private System.Windows.Forms.ComboBox comboBoxBuiltGraphs;
        private System.Windows.Forms.PictureBox pictureBoxMoveGraph;
        private System.Windows.Forms.PictureBox pictureBoxClear;
        private System.Windows.Forms.PictureBox pictureBoxBuildgraph;
        private System.Windows.Forms.PictureBox pictureBoxPalette;
    }
}

