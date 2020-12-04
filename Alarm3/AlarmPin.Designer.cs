namespace Alarm3
{
    partial class AlarmPin
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
            this.textBoxPIN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxPIN
            // 
            this.textBoxPIN.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPIN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxPIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPIN.Location = new System.Drawing.Point(12, 12);
            this.textBoxPIN.MaxLength = 4;
            this.textBoxPIN.Name = "textBoxPIN";
            this.textBoxPIN.Size = new System.Drawing.Size(223, 62);
            this.textBoxPIN.TabIndex = 16;
            this.textBoxPIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPIN.UseSystemPasswordChar = true;
            this.textBoxPIN.TextChanged += new System.EventHandler(this.textBoxPIN_TextChanged);
            // 
            // AlarmPin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 85);
            this.Controls.Add(this.textBoxPIN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlarmPin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PIN Code";
            this.Load += new System.EventHandler(this.AlarmPin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.TextBox textBoxPIN;
    }
}