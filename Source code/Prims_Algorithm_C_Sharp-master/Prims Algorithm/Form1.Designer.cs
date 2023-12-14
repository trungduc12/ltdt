namespace Prims_Algorithm
{
    partial class Form1
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
            this.btnThemDinh = new System.Windows.Forms.Button();
            this.tbVertexName = new System.Windows.Forms.TextBox();
            this.panelDrawing = new System.Windows.Forms.Panel();
            this.tbDistance = new System.Windows.Forms.TextBox();
            this.btnAddEdge = new System.Windows.Forms.Button();
            this.cbFromVertex = new System.Windows.Forms.ComboBox();
            this.cbToVertex = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalculatePrims = new System.Windows.Forms.Button();
            this.lbEdges = new System.Windows.Forms.ListBox();
            this.panelResult = new System.Windows.Forms.Panel();
            this.btnDeleteEdge = new System.Windows.Forms.Button();
            this.lbVertex = new System.Windows.Forms.ListBox();
            this.btnDeleteVertex = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveVertexAndEdgesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maxVertexNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cbRootVertex = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThemDinh
            // 
            this.btnThemDinh.Location = new System.Drawing.Point(15, 86);
            this.btnThemDinh.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemDinh.Name = "btnThemDinh";
            this.btnThemDinh.Size = new System.Drawing.Size(101, 28);
            this.btnThemDinh.TabIndex = 0;
            this.btnThemDinh.Text = "Add Vertex";
            this.btnThemDinh.UseVisualStyleBackColor = true;
            this.btnThemDinh.Click += new System.EventHandler(this.btnThemDinh_Click);
            // 
            // tbVertexName
            // 
            this.tbVertexName.Location = new System.Drawing.Point(69, 54);
            this.tbVertexName.Margin = new System.Windows.Forms.Padding(4);
            this.tbVertexName.Name = "tbVertexName";
            this.tbVertexName.Size = new System.Drawing.Size(45, 22);
            this.tbVertexName.TabIndex = 1;
            this.tbVertexName.Text = "A";
            // 
            // panelDrawing
            // 
            this.panelDrawing.AutoScroll = true;
            this.panelDrawing.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelDrawing.Location = new System.Drawing.Point(345, 50);
            this.panelDrawing.Margin = new System.Windows.Forms.Padding(4);
            this.panelDrawing.Name = "panelDrawing";
            this.panelDrawing.Size = new System.Drawing.Size(567, 522);
            this.panelDrawing.TabIndex = 2;
            this.panelDrawing.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDrawing_Paint);
            // 
            // tbDistance
            // 
            this.tbDistance.Location = new System.Drawing.Point(264, 50);
            this.tbDistance.Margin = new System.Windows.Forms.Padding(4);
            this.tbDistance.Name = "tbDistance";
            this.tbDistance.Size = new System.Drawing.Size(60, 22);
            this.tbDistance.TabIndex = 3;
            this.tbDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbDistance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDistance_KeyPress);
            // 
            // btnAddEdge
            // 
            this.btnAddEdge.Location = new System.Drawing.Point(195, 149);
            this.btnAddEdge.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddEdge.Name = "btnAddEdge";
            this.btnAddEdge.Size = new System.Drawing.Size(131, 28);
            this.btnAddEdge.TabIndex = 4;
            this.btnAddEdge.Text = "Add Edge";
            this.btnAddEdge.UseVisualStyleBackColor = true;
            this.btnAddEdge.Click += new System.EventHandler(this.btnAddEdge_Click);
            // 
            // cbFromVertex
            // 
            this.cbFromVertex.FormattingEnabled = true;
            this.cbFromVertex.Location = new System.Drawing.Point(264, 82);
            this.cbFromVertex.Margin = new System.Windows.Forms.Padding(4);
            this.cbFromVertex.Name = "cbFromVertex";
            this.cbFromVertex.Size = new System.Drawing.Size(60, 24);
            this.cbFromVertex.TabIndex = 5;
            this.cbFromVertex.SelectedValueChanged += new System.EventHandler(this.cbFromVertex_SelectedValueChanged);
            // 
            // cbToVertex
            // 
            this.cbToVertex.FormattingEnabled = true;
            this.cbToVertex.Location = new System.Drawing.Point(264, 116);
            this.cbToVertex.Margin = new System.Windows.Forms.Padding(4);
            this.cbToVertex.Name = "cbToVertex";
            this.cbToVertex.Size = new System.Drawing.Size(60, 24);
            this.cbToVertex.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Distance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "To";
            // 
            // btnCalculatePrims
            // 
            this.btnCalculatePrims.Location = new System.Drawing.Point(19, 501);
            this.btnCalculatePrims.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculatePrims.Name = "btnCalculatePrims";
            this.btnCalculatePrims.Size = new System.Drawing.Size(311, 71);
            this.btnCalculatePrims.TabIndex = 11;
            this.btnCalculatePrims.Text = "Calculate Prim\'s";
            this.btnCalculatePrims.UseVisualStyleBackColor = true;
            this.btnCalculatePrims.Click += new System.EventHandler(this.btnCalculatePrims_Click);
            // 
            // lbEdges
            // 
            this.lbEdges.FormattingEnabled = true;
            this.lbEdges.ItemHeight = 16;
            this.lbEdges.Location = new System.Drawing.Point(195, 185);
            this.lbEdges.Margin = new System.Windows.Forms.Padding(4);
            this.lbEdges.Name = "lbEdges";
            this.lbEdges.Size = new System.Drawing.Size(129, 212);
            this.lbEdges.TabIndex = 12;
            // 
            // panelResult
            // 
            this.panelResult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelResult.Location = new System.Drawing.Point(920, 50);
            this.panelResult.Margin = new System.Windows.Forms.Padding(4);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(567, 522);
            this.panelResult.TabIndex = 13;
            this.panelResult.Paint += new System.Windows.Forms.PaintEventHandler(this.panelResult_Paint);
            // 
            // btnDeleteEdge
            // 
            this.btnDeleteEdge.Location = new System.Drawing.Point(195, 405);
            this.btnDeleteEdge.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteEdge.Name = "btnDeleteEdge";
            this.btnDeleteEdge.Size = new System.Drawing.Size(131, 28);
            this.btnDeleteEdge.TabIndex = 15;
            this.btnDeleteEdge.Text = "Delete";
            this.btnDeleteEdge.UseVisualStyleBackColor = true;
            this.btnDeleteEdge.Click += new System.EventHandler(this.btnDeleteEdge_Click);
            // 
            // lbVertex
            // 
            this.lbVertex.FormattingEnabled = true;
            this.lbVertex.ItemHeight = 16;
            this.lbVertex.Location = new System.Drawing.Point(19, 186);
            this.lbVertex.Margin = new System.Windows.Forms.Padding(4);
            this.lbVertex.Name = "lbVertex";
            this.lbVertex.Size = new System.Drawing.Size(129, 212);
            this.lbVertex.TabIndex = 16;
            // 
            // btnDeleteVertex
            // 
            this.btnDeleteVertex.Location = new System.Drawing.Point(19, 406);
            this.btnDeleteVertex.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteVertex.Name = "btnDeleteVertex";
            this.btnDeleteVertex.Size = new System.Drawing.Size(131, 28);
            this.btnDeleteVertex.TabIndex = 18;
            this.btnDeleteVertex.Text = "Delete";
            this.btnDeleteVertex.UseVisualStyleBackColor = true;
            this.btnDeleteVertex.Click += new System.EventHandler(this.btnDeleteVertex_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1500, 28);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFromFileToolStripMenuItem,
            this.saveVertexAndEdgesToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadFromFileToolStripMenuItem
            // 
            this.loadFromFileToolStripMenuItem.Name = "loadFromFileToolStripMenuItem";
            this.loadFromFileToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.loadFromFileToolStripMenuItem.Text = "Load From File";
            this.loadFromFileToolStripMenuItem.Click += new System.EventHandler(this.loadFromFileToolStripMenuItem_Click);
            // 
            // saveVertexAndEdgesToolStripMenuItem
            // 
            this.saveVertexAndEdgesToolStripMenuItem.Name = "saveVertexAndEdgesToolStripMenuItem";
            this.saveVertexAndEdgesToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.saveVertexAndEdgesToolStripMenuItem.Text = "Save Into File";
            this.saveVertexAndEdgesToolStripMenuItem.Click += new System.EventHandler(this.saveVertexAndEdgesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maxVertexNumberToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // maxVertexNumberToolStripMenuItem
            // 
            this.maxVertexNumberToolStripMenuItem.Name = "maxVertexNumberToolStripMenuItem";
            this.maxVertexNumberToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.maxVertexNumberToolStripMenuItem.Text = "Max Vertex Number";
            this.maxVertexNumberToolStripMenuItem.Click += new System.EventHandler(this.maxVertexNumberToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supportToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // supportToolStripMenuItem
            // 
            this.supportToolStripMenuItem.Name = "supportToolStripMenuItem";
            this.supportToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.supportToolStripMenuItem.Text = "Support";
            this.supportToolStripMenuItem.Click += new System.EventHandler(this.supportToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cbRootVertex
            // 
            this.cbRootVertex.FormattingEnabled = true;
            this.cbRootVertex.Location = new System.Drawing.Point(108, 468);
            this.cbRootVertex.Margin = new System.Windows.Forms.Padding(4);
            this.cbRootVertex.Name = "cbRootVertex";
            this.cbRootVertex.Size = new System.Drawing.Size(60, 24);
            this.cbRootVertex.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 471);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Root Vertex";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 622);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbRootVertex);
            this.Controls.Add(this.btnDeleteVertex);
            this.Controls.Add(this.lbVertex);
            this.Controls.Add(this.btnDeleteEdge);
            this.Controls.Add(this.panelResult);
            this.Controls.Add(this.lbEdges);
            this.Controls.Add(this.btnCalculatePrims);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbToVertex);
            this.Controls.Add(this.cbFromVertex);
            this.Controls.Add(this.btnAddEdge);
            this.Controls.Add(this.tbDistance);
            this.Controls.Add(this.panelDrawing);
            this.Controls.Add(this.tbVertexName);
            this.Controls.Add(this.btnThemDinh);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Prim\'s Algorithm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThemDinh;
        private System.Windows.Forms.TextBox tbVertexName;
        private System.Windows.Forms.Panel panelDrawing;
        private System.Windows.Forms.TextBox tbDistance;
        private System.Windows.Forms.Button btnAddEdge;
        private System.Windows.Forms.ComboBox cbFromVertex;
        private System.Windows.Forms.ComboBox cbToVertex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalculatePrims;
        private System.Windows.Forms.ListBox lbEdges;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.Button btnDeleteEdge;
        private System.Windows.Forms.ListBox lbVertex;
        private System.Windows.Forms.Button btnDeleteVertex;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem supportToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbRootVertex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maxVertexNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveVertexAndEdgesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;

    }
}

