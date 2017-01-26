namespace Sporting_Gym.Forms
{
    partial class Actualizar_Tipo_Egreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actualizar_Tipo_Egreso));
            this.nombre_tipo_egreso_textBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cancelar_button = new System.Windows.Forms.Button();
            this.guardar_button = new System.Windows.Forms.Button();
            this.eliminar_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre_tipo_egreso_textBox
            // 
            this.nombre_tipo_egreso_textBox.Location = new System.Drawing.Point(41, 77);
            this.nombre_tipo_egreso_textBox.Name = "nombre_tipo_egreso_textBox";
            this.nombre_tipo_egreso_textBox.Size = new System.Drawing.Size(206, 20);
            this.nombre_tipo_egreso_textBox.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Nombre Egreso:";
            // 
            // cancelar_button
            // 
            this.cancelar_button.Location = new System.Drawing.Point(199, 116);
            this.cancelar_button.Name = "cancelar_button";
            this.cancelar_button.Size = new System.Drawing.Size(75, 23);
            this.cancelar_button.TabIndex = 4;
            this.cancelar_button.Text = "Cancelar";
            this.cancelar_button.UseVisualStyleBackColor = true;
            this.cancelar_button.Click += new System.EventHandler(this.cancelar_button_Click);
            // 
            // guardar_button
            // 
            this.guardar_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.guardar_button.Location = new System.Drawing.Point(14, 116);
            this.guardar_button.Name = "guardar_button";
            this.guardar_button.Size = new System.Drawing.Size(75, 23);
            this.guardar_button.TabIndex = 2;
            this.guardar_button.Text = "Guardar";
            this.guardar_button.UseVisualStyleBackColor = true;
            this.guardar_button.Click += new System.EventHandler(this.guardar_button_Click);
            // 
            // eliminar_button
            // 
            this.eliminar_button.ForeColor = System.Drawing.Color.Red;
            this.eliminar_button.Location = new System.Drawing.Point(107, 116);
            this.eliminar_button.Name = "eliminar_button";
            this.eliminar_button.Size = new System.Drawing.Size(75, 23);
            this.eliminar_button.TabIndex = 3;
            this.eliminar_button.Text = "Eliminar";
            this.eliminar_button.UseVisualStyleBackColor = true;
            this.eliminar_button.Click += new System.EventHandler(this.eliminar_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Tipo Egreso";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(6, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(85, 32);
            this.pictureBox4.TabIndex = 38;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.Location = new System.Drawing.Point(-2, -4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(290, 50);
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // Actualizar_Tipo_Egreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(284, 150);
            this.ControlBox = false;
            this.Controls.Add(this.nombre_tipo_egreso_textBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.eliminar_button);
            this.Controls.Add(this.cancelar_button);
            this.Controls.Add(this.guardar_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Actualizar_Tipo_Egreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.Actualizar_Tipo_Egreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nombre_tipo_egreso_textBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button cancelar_button;
        private System.Windows.Forms.Button guardar_button;
        private System.Windows.Forms.Button eliminar_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}