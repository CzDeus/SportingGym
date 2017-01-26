namespace Sporting_Gym.Forms
{
    partial class Actualizar_Periodo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actualizar_Periodo));
            this.dias_periodo_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nombre_periodo_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelar_button = new System.Windows.Forms.Button();
            this.guardar_button = new System.Windows.Forms.Button();
            this.Eliminar_button = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // dias_periodo_textBox
            // 
            this.dias_periodo_textBox.Location = new System.Drawing.Point(45, 115);
            this.dias_periodo_textBox.MaxLength = 3;
            this.dias_periodo_textBox.Name = "dias_periodo_textBox";
            this.dias_periodo_textBox.Size = new System.Drawing.Size(206, 20);
            this.dias_periodo_textBox.TabIndex = 2;
            this.dias_periodo_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dias_periodo_textBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Días:";
            // 
            // nombre_periodo_textBox
            // 
            this.nombre_periodo_textBox.Location = new System.Drawing.Point(45, 72);
            this.nombre_periodo_textBox.Name = "nombre_periodo_textBox";
            this.nombre_periodo_textBox.Size = new System.Drawing.Size(206, 20);
            this.nombre_periodo_textBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Periodo:";
            // 
            // cancelar_button
            // 
            this.cancelar_button.Location = new System.Drawing.Point(200, 152);
            this.cancelar_button.Name = "cancelar_button";
            this.cancelar_button.Size = new System.Drawing.Size(75, 23);
            this.cancelar_button.TabIndex = 5;
            this.cancelar_button.Text = "Cancelar";
            this.cancelar_button.UseVisualStyleBackColor = true;
            this.cancelar_button.Click += new System.EventHandler(this.cancelar_button_Click);
            // 
            // guardar_button
            // 
            this.guardar_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.guardar_button.Location = new System.Drawing.Point(16, 152);
            this.guardar_button.Name = "guardar_button";
            this.guardar_button.Size = new System.Drawing.Size(75, 23);
            this.guardar_button.TabIndex = 3;
            this.guardar_button.Text = "Guardar";
            this.guardar_button.UseVisualStyleBackColor = true;
            this.guardar_button.Click += new System.EventHandler(this.guardar_button_Click);
            // 
            // Eliminar_button
            // 
            this.Eliminar_button.ForeColor = System.Drawing.Color.Red;
            this.Eliminar_button.Location = new System.Drawing.Point(108, 152);
            this.Eliminar_button.Name = "Eliminar_button";
            this.Eliminar_button.Size = new System.Drawing.Size(75, 23);
            this.Eliminar_button.TabIndex = 4;
            this.Eliminar_button.Text = "Eliminar";
            this.Eliminar_button.UseVisualStyleBackColor = true;
            this.Eliminar_button.Click += new System.EventHandler(this.Eliminar_button_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.Location = new System.Drawing.Point(-3, -4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(292, 50);
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(5, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(87, 32);
            this.pictureBox4.TabIndex = 35;
            this.pictureBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Periodo";
            // 
            // Actualizar_Periodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(284, 183);
            this.ControlBox = false;
            this.Controls.Add(this.dias_periodo_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.nombre_periodo_textBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Eliminar_button);
            this.Controls.Add(this.cancelar_button);
            this.Controls.Add(this.guardar_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Actualizar_Periodo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.Actualizar_Periodo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox dias_periodo_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombre_periodo_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelar_button;
        private System.Windows.Forms.Button guardar_button;
        private System.Windows.Forms.Button Eliminar_button;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
    }
}