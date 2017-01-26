namespace Sporting_Gym_Check
{
    partial class Checador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checador));
            this.nombre_label = new System.Windows.Forms.Label();
            this.Foto_videoSourcePlayer = new AForge.Controls.VideoSourcePlayer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fecha_checar_label = new System.Windows.Forms.Label();
            this.hora_checar_label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.salir_button = new System.Windows.Forms.Button();
            this.color_pictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.mensaje_label = new System.Windows.Forms.Label();
            this.Fecha_Vencimiento_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Recargar_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.color_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre_label
            // 
            this.nombre_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_label.Location = new System.Drawing.Point(273, 434);
            this.nombre_label.Name = "nombre_label";
            this.nombre_label.Size = new System.Drawing.Size(250, 25);
            this.nombre_label.TabIndex = 1;
            this.nombre_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Foto_videoSourcePlayer
            // 
            this.Foto_videoSourcePlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Foto_videoSourcePlayer.Location = new System.Drawing.Point(273, 180);
            this.Foto_videoSourcePlayer.Name = "Foto_videoSourcePlayer";
            this.Foto_videoSourcePlayer.Size = new System.Drawing.Size(250, 250);
            this.Foto_videoSourcePlayer.TabIndex = 3;
            this.Foto_videoSourcePlayer.Text = "videoSourcePlayer1";
            this.Foto_videoSourcePlayer.VideoSource = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(438, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hora:";
            // 
            // fecha_checar_label
            // 
            this.fecha_checar_label.AutoSize = true;
            this.fecha_checar_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_checar_label.Location = new System.Drawing.Point(269, 98);
            this.fecha_checar_label.Name = "fecha_checar_label";
            this.fecha_checar_label.Size = new System.Drawing.Size(91, 20);
            this.fecha_checar_label.TabIndex = 7;
            this.fecha_checar_label.Text = "00-00-0000";
            // 
            // hora_checar_label
            // 
            this.hora_checar_label.AutoSize = true;
            this.hora_checar_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora_checar_label.Location = new System.Drawing.Point(418, 98);
            this.hora_checar_label.Name = "hora_checar_label";
            this.hora_checar_label.Size = new System.Drawing.Size(105, 20);
            this.hora_checar_label.TabIndex = 8;
            this.hora_checar_label.Text = "00:00:00 a.m.";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(328, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 40;
            this.label3.Text = "CHECADOR";
            // 
            // salir_button
            // 
            this.salir_button.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.salir_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("salir_button.BackgroundImage")));
            this.salir_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.salir_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.salir_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir_button.Location = new System.Drawing.Point(743, 475);
            this.salir_button.Name = "salir_button";
            this.salir_button.Size = new System.Drawing.Size(35, 35);
            this.salir_button.TabIndex = 39;
            this.salir_button.UseVisualStyleBackColor = false;
            this.salir_button.Click += new System.EventHandler(this.salir_button_Click);
            // 
            // color_pictureBox
            // 
            this.color_pictureBox.BackColor = System.Drawing.Color.White;
            this.color_pictureBox.ImageLocation = "";
            this.color_pictureBox.Location = new System.Drawing.Point(-5, 516);
            this.color_pictureBox.Name = "color_pictureBox";
            this.color_pictureBox.Size = new System.Drawing.Size(816, 71);
            this.color_pictureBox.TabIndex = 38;
            this.color_pictureBox.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(9, 20);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 40);
            this.pictureBox4.TabIndex = 35;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.Location = new System.Drawing.Point(0, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(800, 71);
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // Picture
            // 
            this.Picture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Picture.Location = new System.Drawing.Point(276, 371);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(62, 56);
            this.Picture.TabIndex = 4;
            this.Picture.TabStop = false;
            // 
            // mensaje_label
            // 
            this.mensaje_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensaje_label.Location = new System.Drawing.Point(273, 152);
            this.mensaje_label.Name = "mensaje_label";
            this.mensaje_label.Size = new System.Drawing.Size(250, 25);
            this.mensaje_label.TabIndex = 37;
            this.mensaje_label.Text = "Bienvenido";
            this.mensaje_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Fecha_Vencimiento_label
            // 
            this.Fecha_Vencimiento_label.AutoSize = true;
            this.Fecha_Vencimiento_label.BackColor = System.Drawing.Color.White;
            this.Fecha_Vencimiento_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha_Vencimiento_label.Location = new System.Drawing.Point(365, 524);
            this.Fecha_Vencimiento_label.Name = "Fecha_Vencimiento_label";
            this.Fecha_Vencimiento_label.Size = new System.Drawing.Size(122, 25);
            this.Fecha_Vencimiento_label.TabIndex = 41;
            this.Fecha_Vencimiento_label.Text = "13/05/1990";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(340, 493);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Fecha de vencimiento:";
            // 
            // Recargar_button
            // 
            this.Recargar_button.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Recargar_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Recargar_button.BackgroundImage")));
            this.Recargar_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Recargar_button.FlatAppearance.BorderSize = 0;
            this.Recargar_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Recargar_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Recargar_button.Location = new System.Drawing.Point(9, 486);
            this.Recargar_button.Name = "Recargar_button";
            this.Recargar_button.Size = new System.Drawing.Size(20, 25);
            this.Recargar_button.TabIndex = 43;
            this.Recargar_button.UseVisualStyleBackColor = false;
            this.Recargar_button.Click += new System.EventHandler(this.Recargar_button_Click);
            // 
            // Checador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(784, 584);
            this.Controls.Add(this.Recargar_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Fecha_Vencimiento_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.salir_button);
            this.Controls.Add(this.color_pictureBox);
            this.Controls.Add(this.mensaje_label);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.hora_checar_label);
            this.Controls.Add(this.fecha_checar_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Picture);
            this.Controls.Add(this.Foto_videoSourcePlayer);
            this.Controls.Add(this.nombre_label);
            this.Name = "Checador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Checador_FormClosed);
            this.Load += new System.EventHandler(this.Checador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.color_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nombre_label;
        private AForge.Controls.VideoSourcePlayer Foto_videoSourcePlayer;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label fecha_checar_label;
        private System.Windows.Forms.Label hora_checar_label;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox color_pictureBox;
        private System.Windows.Forms.Button salir_button;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label mensaje_label;
        private System.Windows.Forms.Label Fecha_Vencimiento_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Recargar_button;
    }
}

