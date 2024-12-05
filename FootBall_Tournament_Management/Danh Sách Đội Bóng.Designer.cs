namespace FootBall_Tournament_Management
{
    partial class Danh_Sách_Đội_Bóng
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(577, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(366, 322);
            this.button1.TabIndex = 0;
            this.button1.Text = "test";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(290, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "test";
            // 
            // Danh_Sách_Đội_Bóng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Danh_Sách_Đội_Bóng";
            this.Size = new System.Drawing.Size(1400, 950);
            this.Load += new System.EventHandler(this.Danh_Sách_Đội_Bóng_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}
