namespace Prims_Algorithm
{
    partial class FrmMaxVertexNumber
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
            this.tbMaxVertexNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbMaxVertexNumber
            // 
            this.tbMaxVertexNumber.Location = new System.Drawing.Point(159, 94);
            this.tbMaxVertexNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMaxVertexNumber.MaxLength = 2;
            this.tbMaxVertexNumber.Name = "tbMaxVertexNumber";
            this.tbMaxVertexNumber.Size = new System.Drawing.Size(45, 22);
            this.tbMaxVertexNumber.TabIndex = 1;
            this.tbMaxVertexNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbMaxVertexNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMaxVertexNumber_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Max Vertex Number";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(213, 91);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FrmMaxVertexNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 145);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMaxVertexNumber);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMaxVertexNumber";
            this.Text = "Max Vertex Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbMaxVertexNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
    }
}