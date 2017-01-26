namespace Sporting_Gym.Forms
{
    partial class Actualizar_Colonias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actualizar_Colonias));
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.nombre_colonia_textBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.eliminar_button = new System.Windows.Forms.Button();
            this.cancelar_button = new System.Windows.Forms.Button();
            this.guardar_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "COLONIAS";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(10, 9);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(115, 40);
            this.pictureBox4.TabIndex = 41;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.Location = new System.Drawing.Point(-3, -3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(415, 62);
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // nombre_colonia_textBox
            // 
            this.nombre_colonia_textBox.Location = new System.Drawing.Point(36, 85);
            this.nombre_colonia_textBox.Name = "nombre_colonia_textBox";
            this.nombre_colonia_textBox.Size = new System.Drawing.Size(206, 20);
            this.nombre_colonia_textBox.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Nombre colonia:";
            // 
            // eliminar_button
            // 
            this.eliminar_button.ForeColor = System.Drawing.Color.Red;
            this.eliminar_button.Location = new System.Drawing.Point(102, 124);
            this.eliminar_button.Name = "eliminar_button";
            this.eliminar_button.Size = new System.Drawing.Size(75, 23);
            this.eliminar_button.TabIndex = 47;
            this.eliminar_button.Text = "Eliminar";
            this.eliminar_button.UseVisualStyleBackColor = true;
            this.eliminar_button.Click += new System.EventHandler(this.eliminar_button_Click);
            // 
            // cancelar_button
            // 
            this.cancelar_button.Location = new System.Drawing.Point(194, 124);
            this.cancelar_button.Name = "cancelar_button";
            this.cancelar_button.Size = new System.Drawing.Size(75, 23);
            this.cancelar_button.TabIndex = 48;
            this.cancelar_button.Text = "Cancelar";
            this.cancelar_button.UseVisualStyleBackColor = true;
            this.cancelar_button.Click += new System.EventHandler(this.cancelar_button_Click);
            // 
            // guardar_button
            // 
            this.guardar_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.guardar_button.Location = new System.Drawing.Point(9, 124);
            this.guardar_button.Name = "guardar_button";
            this.guardar_button.Size = new System.Drawing.Size(75, 23);
            this.guardar_button.TabIndex = 46;
            this.guardar_button.Text = "Guardar";
            this.guardar_button.UseVisualStyleBackColor = true;
            this.guardar_button.Click += new System.EventHandler(this.guardar_button_Click);
            // 
            // Actualizar_Colonias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(278, 153);
            this.ControlBox = false;
            this.Controls.Add(this.nombre_colonia_textBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.eliminar_button);
            this.Controls.Add(this.cancelar_button);
            this.Controls.Add(this.guardar_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Actualizar_Colonias";
            this.Load += new System.EventHandler(this.Actualizar_Colonias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox nombre_colonia_textBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button eliminar_button;
        private System.Windows.Forms.Button cancelar_button;
        private System.Windows.Forms.Button guardar_button;
    }
}