namespace FordBell
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.start = new System.Windows.Forms.ComboBox();
            this.end = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pb = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lưuẢnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaDữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lienthong = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.dt = new System.Windows.Forms.DataGridView();
            this.tb = new System.Windows.Forms.Label();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "Nhập từ File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // start
            // 
            this.start.Enabled = false;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.FormattingEnabled = true;
            this.start.Location = new System.Drawing.Point(1047, 16);
            this.start.Margin = new System.Windows.Forms.Padding(4);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(67, 33);
            this.start.TabIndex = 6;
            // 
            // end
            // 
            this.end.Enabled = false;
            this.end.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end.FormattingEnabled = true;
            this.end.Location = new System.Drawing.Point(1175, 17);
            this.end.Margin = new System.Windows.Forms.Padding(4);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(67, 33);
            this.end.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1004, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Từ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1119, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Đến";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(803, 14);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 37);
            this.button2.TabIndex = 10;
            this.button2.Text = "Tìm Đường đi ngắn nhất";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pb
            // 
            this.pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb.ContextMenuStrip = this.contextMenuStrip1;
            this.pb.Location = new System.Drawing.Point(1, 65);
            this.pb.Margin = new System.Windows.Forms.Padding(4);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(1246, 539);
            this.pb.TabIndex = 2;
            this.pb.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lưuẢnhToolStripMenuItem,
            this.sửaDữLiệuToolStripMenuItem,
            this.cậpNhậtToolStripMenuItem,
            this.thôngTinTácGiảToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(191, 100);
            // 
            // lưuẢnhToolStripMenuItem
            // 
            this.lưuẢnhToolStripMenuItem.Name = "lưuẢnhToolStripMenuItem";
            this.lưuẢnhToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.lưuẢnhToolStripMenuItem.Text = "Lưu Ảnh Đồ Thị";
            this.lưuẢnhToolStripMenuItem.Click += new System.EventHandler(this.lưuẢnhToolStripMenuItem_Click);
            // 
            // sửaDữLiệuToolStripMenuItem
            // 
            this.sửaDữLiệuToolStripMenuItem.Name = "sửaDữLiệuToolStripMenuItem";
            this.sửaDữLiệuToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.sửaDữLiệuToolStripMenuItem.Text = "Sửa dữ liệu";
            this.sửaDữLiệuToolStripMenuItem.Click += new System.EventHandler(this.sửaDữLiệuToolStripMenuItem_Click);
            // 
            // cậpNhậtToolStripMenuItem
            // 
            this.cậpNhậtToolStripMenuItem.Name = "cậpNhậtToolStripMenuItem";
            this.cậpNhậtToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.cậpNhậtToolStripMenuItem.Text = "Cập nhật";
            this.cậpNhậtToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtToolStripMenuItem_Click);
            // 
            // thôngTinTácGiảToolStripMenuItem
            // 
            this.thôngTinTácGiảToolStripMenuItem.Name = "thôngTinTácGiảToolStripMenuItem";
            this.thôngTinTácGiảToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.thôngTinTácGiảToolStripMenuItem.Text = "Thông tin tác giả";
            this.thôngTinTácGiảToolStripMenuItem.Click += new System.EventHandler(this.thôngTinTácGiảToolStripMenuItem_Click);
            // 
            // lienthong
            // 
            this.lienthong.AutoSize = true;
            this.lienthong.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lienthong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lienthong.Location = new System.Drawing.Point(357, 11);
            this.lienthong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lienthong.Name = "lienthong";
            this.lienthong.Size = new System.Drawing.Size(0, 39);
            this.lienthong.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(123, 15);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 43);
            this.button3.TabIndex = 13;
            this.button3.Text = "Nhập bằng tay";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dt
            // 
            this.dt.AllowUserToAddRows = false;
            this.dt.AllowUserToDeleteRows = false;
            this.dt.AllowUserToResizeColumns = false;
            this.dt.AllowUserToResizeRows = false;
            this.dt.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dt.DefaultCellStyle = dataGridViewCellStyle1;
            this.dt.GridColor = System.Drawing.SystemColors.Control;
            this.dt.Location = new System.Drawing.Point(1055, 231);
            this.dt.Margin = new System.Windows.Forms.Padding(4);
            this.dt.Name = "dt";
            this.dt.ReadOnly = true;
            this.dt.RowHeadersVisible = false;
            this.dt.RowHeadersWidth = 51;
            this.dt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dt.Size = new System.Drawing.Size(188, 25);
            this.dt.TabIndex = 14;
            this.dt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_CellClick);
            // 
            // tb
            // 
            this.tb.AutoSize = true;
            this.tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb.Location = new System.Drawing.Point(21, 619);
            this.tb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(0, 31);
            this.tb.TabIndex = 15;
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhat.Location = new System.Drawing.Point(236, 15);
            this.btn_CapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(109, 43);
            this.btn_CapNhat.TabIndex = 16;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.UseVisualStyleBackColor = true;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(348, 15);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(109, 43);
            this.btn_Exit.TabIndex = 18;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 490);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.ControlBox = false;
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.lienthong);
            this.Controls.Add(this.btn_CapNhat);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.end);
            this.Controls.Add(this.start);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Tìm đường đi ngắn nhất bằng Ford Bellman ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox start;
        private System.Windows.Forms.ComboBox end;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Label lienthong;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lưuẢnhToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dt;
        private System.Windows.Forms.Label tb;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.ToolStripMenuItem sửaDữLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTácGiảToolStripMenuItem;
        private System.Windows.Forms.Button btn_Exit;
    }
}

