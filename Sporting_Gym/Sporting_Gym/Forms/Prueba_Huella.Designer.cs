namespace Sporting_Gym.Forms
{
    partial class Prueba_Huella
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
            this.huella_pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.huella_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // huella_pictureBox
            // 
            this.huella_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.huella_pictureBox.Location = new System.Drawing.Point(12, 12);
            this.huella_pictureBox.Name = "huella_pictureBox";
            this.huella_pictureBox.Size = new System.Drawing.Size(216, 170);
            this.huella_pictureBox.TabIndex = 17;
            this.huella_pictureBox.TabStop = false;
            // 
            // Prueba_Huella
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 411);
            this.Controls.Add(this.huella_pictureBox);
            this.Name = "Prueba_Huella";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Prueba_Huella";
            this.Load += new System.EventHandler(this.Prueba_Huella_Load);
            ((System.ComponentModel.ISupportInitialize)(this.huella_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox huella_pictureBox;
    }
}