namespace Sporting_Gym.Forms
{
    partial class Captura_Archivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Captura_Archivo));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.encender_button = new System.Windows.Forms.Button();
            this.dispositivos_comboBox = new System.Windows.Forms.ComboBox();
            this.tomar_foto_button = new System.Windows.Forms.Button();
            this.guardar_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nombre_archivo_textBox = new System.Windows.Forms.TextBox();
            this.salir_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(6, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 30);
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.Location = new System.Drawing.Point(-4, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(334, 60);
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "CAPTURAR ARCHIVO";
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.videoSourcePlayer1.Location = new System.Drawing.Point(27, 65);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(269, 250);
            this.videoSourcePlayer1.TabIndex = 0;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // encender_button
            // 
            this.encender_button.Image = ((System.Drawing.Image)(resources.GetObject("encender_button.Image")));
            this.encender_button.Location = new System.Drawing.Point(152, 20);
            this.encender_button.Name = "encender_button";
            this.encender_button.Size = new System.Drawing.Size(27, 23);
            this.encender_button.TabIndex = 2;
            this.encender_button.UseVisualStyleBackColor = true;
            this.encender_button.Click += new System.EventHandler(this.encender_button_Click);
            // 
            // dispositivos_comboBox
            // 
            this.dispositivos_comboBox.FormattingEnabled = true;
            this.dispositivos_comboBox.Location = new System.Drawing.Point(13, 20);
            this.dispositivos_comboBox.Name = "dispositivos_comboBox";
            this.dispositivos_comboBox.Size = new System.Drawing.Size(129, 21);
            this.dispositivos_comboBox.TabIndex = 1;
            // 
            // tomar_foto_button
            // 
            this.tomar_foto_button.Location = new System.Drawing.Point(188, 20);
            this.tomar_foto_button.Name = "tomar_foto_button";
            this.tomar_foto_button.Size = new System.Drawing.Size(75, 23);
            this.tomar_foto_button.TabIndex = 3;
            this.tomar_foto_button.Text = "Tomar Foto";
            this.tomar_foto_button.UseVisualStyleBackColor = true;
            this.tomar_foto_button.Click += new System.EventHandler(this.tomar_foto_button_Click);
            // 
            // guardar_button
            // 
            this.guardar_button.Location = new System.Drawing.Point(95, 46);
            this.guardar_button.Name = "guardar_button";
            this.guardar_button.Size = new System.Drawing.Size(75, 23);
            this.guardar_button.TabIndex = 5;
            this.guardar_button.Text = "Guardar";
            this.guardar_button.UseVisualStyleBackColor = true;
            this.guardar_button.Click += new System.EventHandler(this.guardar_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tomar_foto_button);
            this.groupBox1.Controls.Add(this.dispositivos_comboBox);
            this.groupBox1.Controls.Add(this.encender_button);
            this.groupBox1.Location = new System.Drawing.Point(27, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 50);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cámara";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nombre_archivo_textBox);
            this.groupBox2.Controls.Add(this.guardar_button);
            this.groupBox2.Location = new System.Drawing.Point(27, 377);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 79);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Archivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Nombre Archivo:";
            // 
            // nombre_archivo_textBox
            // 
            this.nombre_archivo_textBox.Location = new System.Drawing.Point(131, 19);
            this.nombre_archivo_textBox.Name = "nombre_archivo_textBox";
            this.nombre_archivo_textBox.Size = new System.Drawing.Size(100, 20);
            this.nombre_archivo_textBox.TabIndex = 4;
            // 
            // salir_button
            // 
            this.salir_button.ForeColor = System.Drawing.Color.Red;
            this.salir_button.Location = new System.Drawing.Point(221, 462);
            this.salir_button.Name = "salir_button";
            this.salir_button.Size = new System.Drawing.Size(75, 23);
            this.salir_button.TabIndex = 60;
            this.salir_button.Text = "Salir";
            this.salir_button.UseVisualStyleBackColor = true;
            this.salir_button.Click += new System.EventHandler(this.salir_button_Click);
            // 
            // Captura_Archivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(322, 488);
            this.ControlBox = false;
            this.Controls.Add(this.salir_button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.videoSourcePlayer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Captura_Archivo";
            this.Load += new System.EventHandler(this.Captura_Archivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.Button encender_button;
        private System.Windows.Forms.ComboBox dispositivos_comboBox;
        private System.Windows.Forms.Button tomar_foto_button;
        private System.Windows.Forms.Button guardar_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombre_archivo_textBox;
        private System.Windows.Forms.Button salir_button;
    }
}