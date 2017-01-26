namespace Sporting_Gym
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Acceder_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.usuario_textBox = new System.Windows.Forms.TextBox();
            this.pasword_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.salir_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Acceder_button
            // 
            this.Acceder_button.ForeColor = System.Drawing.Color.MediumBlue;
            this.Acceder_button.Location = new System.Drawing.Point(111, 150);
            this.Acceder_button.Name = "Acceder_button";
            this.Acceder_button.Size = new System.Drawing.Size(75, 23);
            this.Acceder_button.TabIndex = 3;
            this.Acceder_button.Text = "Acceder";
            this.Acceder_button.UseVisualStyleBackColor = true;
            this.Acceder_button.Click += new System.EventHandler(this.Acceder_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // usuario_textBox
            // 
            this.usuario_textBox.Location = new System.Drawing.Point(62, 76);
            this.usuario_textBox.Name = "usuario_textBox";
            this.usuario_textBox.Size = new System.Drawing.Size(172, 20);
            this.usuario_textBox.TabIndex = 1;
            this.usuario_textBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.usuario_textBox_KeyUp);
            // 
            // pasword_textBox
            // 
            this.pasword_textBox.Location = new System.Drawing.Point(62, 123);
            this.pasword_textBox.Name = "pasword_textBox";
            this.pasword_textBox.PasswordChar = '*';
            this.pasword_textBox.Size = new System.Drawing.Size(172, 20);
            this.pasword_textBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(5, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(81, 32);
            this.pictureBox4.TabIndex = 45;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.Location = new System.Drawing.Point(-3, -4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(313, 47);
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 46;
            this.label3.Text = "LOGIN";
            // 
            // salir_button
            // 
            this.salir_button.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.salir_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("salir_button.BackgroundImage")));
            this.salir_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.salir_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.salir_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir_button.Location = new System.Drawing.Point(281, 159);
            this.salir_button.Name = "salir_button";
            this.salir_button.Size = new System.Drawing.Size(20, 20);
            this.salir_button.TabIndex = 4;
            this.salir_button.UseVisualStyleBackColor = false;
            this.salir_button.Click += new System.EventHandler(this.salir_button_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(306, 184);
            this.ControlBox = false;
            this.Controls.Add(this.salir_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pasword_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usuario_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Acceder_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Acceder_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usuario_textBox;
        private System.Windows.Forms.TextBox pasword_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button salir_button;
    }
}

