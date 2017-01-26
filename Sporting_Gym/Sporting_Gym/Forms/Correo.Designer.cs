namespace Sporting_Gym.Forms
{
    partial class Correo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Correo));
            this.enviar_correo_button = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.todos_radioButton = new System.Windows.Forms.RadioButton();
            this.vencidos_radioButton = new System.Windows.Forms.RadioButton();
            this.vigentes_radioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.direccion_archivo_textBox = new System.Windows.Forms.TextBox();
            this.adjuntar_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.mensaje_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.correo_emisor_textBox = new System.Windows.Forms.TextBox();
            this.asunto_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cancelar_button = new System.Windows.Forms.Button();
            this.contraseña_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // enviar_correo_button
            // 
            this.enviar_correo_button.ForeColor = System.Drawing.Color.Blue;
            this.enviar_correo_button.Location = new System.Drawing.Point(87, 405);
            this.enviar_correo_button.Name = "enviar_correo_button";
            this.enviar_correo_button.Size = new System.Drawing.Size(75, 23);
            this.enviar_correo_button.TabIndex = 10;
            this.enviar_correo_button.Text = "Enviar Correo";
            this.enviar_correo_button.UseVisualStyleBackColor = true;
            this.enviar_correo_button.Click += new System.EventHandler(this.enviar_correo_button_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(5, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(97, 39);
            this.pictureBox4.TabIndex = 57;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.ImageLocation = "";
            this.pictureBox3.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(333, 62);
            this.pictureBox3.TabIndex = 58;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 59;
            this.label1.Text = "Enviar Correo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.todos_radioButton);
            this.groupBox1.Controls.Add(this.vencidos_radioButton);
            this.groupBox1.Controls.Add(this.vigentes_radioButton);
            this.groupBox1.Location = new System.Drawing.Point(89, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 89);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enviar a:";
            // 
            // todos_radioButton
            // 
            this.todos_radioButton.AutoSize = true;
            this.todos_radioButton.Checked = true;
            this.todos_radioButton.Location = new System.Drawing.Point(30, 65);
            this.todos_radioButton.Name = "todos_radioButton";
            this.todos_radioButton.Size = new System.Drawing.Size(55, 17);
            this.todos_radioButton.TabIndex = 3;
            this.todos_radioButton.TabStop = true;
            this.todos_radioButton.Text = "Todos";
            this.todos_radioButton.UseVisualStyleBackColor = true;
            // 
            // vencidos_radioButton
            // 
            this.vencidos_radioButton.AutoSize = true;
            this.vencidos_radioButton.Location = new System.Drawing.Point(30, 42);
            this.vencidos_radioButton.Name = "vencidos_radioButton";
            this.vencidos_radioButton.Size = new System.Drawing.Size(109, 17);
            this.vencidos_radioButton.TabIndex = 2;
            this.vencidos_radioButton.TabStop = true;
            this.vencidos_radioButton.Text = "Clientes Vencidos";
            this.vencidos_radioButton.UseVisualStyleBackColor = true;
            // 
            // vigentes_radioButton
            // 
            this.vigentes_radioButton.AutoSize = true;
            this.vigentes_radioButton.Location = new System.Drawing.Point(30, 19);
            this.vigentes_radioButton.Name = "vigentes_radioButton";
            this.vigentes_radioButton.Size = new System.Drawing.Size(106, 17);
            this.vigentes_radioButton.TabIndex = 1;
            this.vigentes_radioButton.TabStop = true;
            this.vigentes_radioButton.Text = "Clientes Vigentes";
            this.vigentes_radioButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Adjuntar Archivo:";
            // 
            // direccion_archivo_textBox
            // 
            this.direccion_archivo_textBox.Location = new System.Drawing.Point(97, 377);
            this.direccion_archivo_textBox.Name = "direccion_archivo_textBox";
            this.direccion_archivo_textBox.Size = new System.Drawing.Size(129, 20);
            this.direccion_archivo_textBox.TabIndex = 8;
            // 
            // adjuntar_button
            // 
            this.adjuntar_button.Location = new System.Drawing.Point(232, 376);
            this.adjuntar_button.Name = "adjuntar_button";
            this.adjuntar_button.Size = new System.Drawing.Size(75, 23);
            this.adjuntar_button.TabIndex = 9;
            this.adjuntar_button.Text = "Adjuntar";
            this.adjuntar_button.UseVisualStyleBackColor = true;
            this.adjuntar_button.Click += new System.EventHandler(this.adjuntar_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "Texto/Mensaje:";
            // 
            // mensaje_textBox
            // 
            this.mensaje_textBox.Location = new System.Drawing.Point(17, 270);
            this.mensaje_textBox.Multiline = true;
            this.mensaje_textBox.Name = "mensaje_textBox";
            this.mensaje_textBox.Size = new System.Drawing.Size(279, 100);
            this.mensaje_textBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "Correo Emisor:";
            // 
            // correo_emisor_textBox
            // 
            this.correo_emisor_textBox.Location = new System.Drawing.Point(113, 169);
            this.correo_emisor_textBox.Name = "correo_emisor_textBox";
            this.correo_emisor_textBox.Size = new System.Drawing.Size(169, 20);
            this.correo_emisor_textBox.TabIndex = 4;
            // 
            // asunto_textBox
            // 
            this.asunto_textBox.Location = new System.Drawing.Point(113, 229);
            this.asunto_textBox.Name = "asunto_textBox";
            this.asunto_textBox.Size = new System.Drawing.Size(169, 20);
            this.asunto_textBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 68;
            this.label5.Text = "Asunto:";
            // 
            // cancelar_button
            // 
            this.cancelar_button.ForeColor = System.Drawing.Color.Red;
            this.cancelar_button.Location = new System.Drawing.Point(177, 405);
            this.cancelar_button.Name = "cancelar_button";
            this.cancelar_button.Size = new System.Drawing.Size(75, 23);
            this.cancelar_button.TabIndex = 11;
            this.cancelar_button.Text = "Cancelar";
            this.cancelar_button.UseVisualStyleBackColor = true;
            this.cancelar_button.Click += new System.EventHandler(this.cancelar_button_Click);
            // 
            // contraseña_textBox
            // 
            this.contraseña_textBox.Location = new System.Drawing.Point(113, 199);
            this.contraseña_textBox.Name = "contraseña_textBox";
            this.contraseña_textBox.PasswordChar = '*';
            this.contraseña_textBox.Size = new System.Drawing.Size(169, 20);
            this.contraseña_textBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 70;
            this.label6.Text = "Contraseña:";
            // 
            // Correo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(314, 435);
            this.ControlBox = false;
            this.Controls.Add(this.contraseña_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cancelar_button);
            this.Controls.Add(this.asunto_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.correo_emisor_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mensaje_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adjuntar_button);
            this.Controls.Add(this.direccion_archivo_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.enviar_correo_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Correo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.Correo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enviar_correo_button;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton todos_radioButton;
        private System.Windows.Forms.RadioButton vencidos_radioButton;
        private System.Windows.Forms.RadioButton vigentes_radioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox direccion_archivo_textBox;
        private System.Windows.Forms.Button adjuntar_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mensaje_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox correo_emisor_textBox;
        private System.Windows.Forms.TextBox asunto_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cancelar_button;
        private System.Windows.Forms.TextBox contraseña_textBox;
        private System.Windows.Forms.Label label6;
    }
}