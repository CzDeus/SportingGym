namespace Sporting_Gym.Forms
{
    partial class Leer_Huella
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Leer_Huella));
            this.Picture = new System.Windows.Forms.PictureBox();
            this.mensaje_label = new System.Windows.Forms.Label();
            this.intentos_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.salir_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Picture
            // 
            this.Picture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Picture.BackColor = System.Drawing.SystemColors.Window;
            this.Picture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Picture.Location = new System.Drawing.Point(43, 75);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(200, 200);
            this.Picture.TabIndex = 5;
            this.Picture.TabStop = false;
            // 
            // mensaje_label
            // 
            this.mensaje_label.AutoSize = true;
            this.mensaje_label.Location = new System.Drawing.Point(78, 59);
            this.mensaje_label.Name = "mensaje_label";
            this.mensaje_label.Size = new System.Drawing.Size(121, 13);
            this.mensaje_label.TabIndex = 6;
            this.mensaje_label.Text = "Capture la misma huella.";
            // 
            // intentos_label
            // 
            this.intentos_label.AutoSize = true;
            this.intentos_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intentos_label.Location = new System.Drawing.Point(134, 288);
            this.intentos_label.Name = "intentos_label";
            this.intentos_label.Size = new System.Drawing.Size(19, 20);
            this.intentos_label.TabIndex = 7;
            this.intentos_label.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(5, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 30);
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(293, 50);
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "LECTOR DE HUELLA";
            // 
            // salir_button
            // 
            this.salir_button.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.salir_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("salir_button.BackgroundImage")));
            this.salir_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.salir_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.salir_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir_button.Location = new System.Drawing.Point(256, 289);
            this.salir_button.Name = "salir_button";
            this.salir_button.Size = new System.Drawing.Size(20, 20);
            this.salir_button.TabIndex = 54;
            this.salir_button.UseVisualStyleBackColor = false;
            this.salir_button.Click += new System.EventHandler(this.salir_button_Click);
            // 
            // Leer_Huella
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(283, 319);
            this.ControlBox = false;
            this.Controls.Add(this.salir_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.intentos_label);
            this.Controls.Add(this.mensaje_label);
            this.Controls.Add(this.Picture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Leer_Huella";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Leer_Huella_FormClosing);
            this.Load += new System.EventHandler(this.Leer_Huella_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.Label mensaje_label;
        private System.Windows.Forms.Label intentos_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button salir_button;
    }
}