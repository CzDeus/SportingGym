namespace Sporting_Gym_Check.Forms
{
    partial class Usuario
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
            this.button1 = new System.Windows.Forms.Button();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.Clientes_comboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Picture
            // 
            this.Picture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Picture.BackColor = System.Drawing.SystemColors.Window;
            this.Picture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Picture.Location = new System.Drawing.Point(20, 68);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(248, 281);
            this.Picture.TabIndex = 2;
            this.Picture.TabStop = false;
            // 
            // Clientes_comboBox
            // 
            this.Clientes_comboBox.FormattingEnabled = true;
            this.Clientes_comboBox.Location = new System.Drawing.Point(12, 22);
            this.Clientes_comboBox.Name = "Clientes_comboBox";
            this.Clientes_comboBox.Size = new System.Drawing.Size(264, 21);
            this.Clientes_comboBox.TabIndex = 3;
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 418);
            this.Controls.Add(this.Clientes_comboBox);
            this.Controls.Add(this.Picture);
            this.Controls.Add(this.button1);
            this.Name = "Usuario";
            this.Text = "Usuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Usuario_FormClosing);
            this.Load += new System.EventHandler(this.Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.ComboBox Clientes_comboBox;
    }
}