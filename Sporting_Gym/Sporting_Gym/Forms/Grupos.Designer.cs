namespace Sporting_Gym.Forms
{
    partial class Grupos
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
            System.Windows.Forms.Button cancelar_button;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grupos));
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.guardar_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nombre_grupo_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tipo_cliente_comboBox = new System.Windows.Forms.ComboBox();
            cancelar_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelar_button
            // 
            cancelar_button.ForeColor = System.Drawing.Color.Red;
            cancelar_button.Location = new System.Drawing.Point(146, 137);
            cancelar_button.Name = "cancelar_button";
            cancelar_button.Size = new System.Drawing.Size(75, 23);
            cancelar_button.TabIndex = 3;
            cancelar_button.Text = "Cancelar";
            cancelar_button.UseVisualStyleBackColor = true;
            cancelar_button.Click += new System.EventHandler(this.cancelar_button_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(5, 9);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(86, 30);
            this.pictureBox4.TabIndex = 41;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "CREAR GRUPO";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.Location = new System.Drawing.Point(-5, -3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(282, 50);
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // guardar_button
            // 
            this.guardar_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.guardar_button.Location = new System.Drawing.Point(54, 137);
            this.guardar_button.Name = "guardar_button";
            this.guardar_button.Size = new System.Drawing.Size(75, 23);
            this.guardar_button.TabIndex = 2;
            this.guardar_button.Text = "Guardar";
            this.guardar_button.UseVisualStyleBackColor = true;
            this.guardar_button.Click += new System.EventHandler(this.guardar_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Nombre Grupo:";
            // 
            // nombre_grupo_textBox
            // 
            this.nombre_grupo_textBox.Location = new System.Drawing.Point(78, 69);
            this.nombre_grupo_textBox.Name = "nombre_grupo_textBox";
            this.nombre_grupo_textBox.Size = new System.Drawing.Size(124, 20);
            this.nombre_grupo_textBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Seleccione tipo cliente grupo:";
            // 
            // tipo_cliente_comboBox
            // 
            this.tipo_cliente_comboBox.FormattingEnabled = true;
            this.tipo_cliente_comboBox.Location = new System.Drawing.Point(78, 110);
            this.tipo_cliente_comboBox.Name = "tipo_cliente_comboBox";
            this.tipo_cliente_comboBox.Size = new System.Drawing.Size(125, 21);
            this.tipo_cliente_comboBox.TabIndex = 48;
            // 
            // Grupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(271, 166);
            this.ControlBox = false;
            this.Controls.Add(this.tipo_cliente_comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nombre_grupo_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(cancelar_button);
            this.Controls.Add(this.guardar_button);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Grupos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.Grupos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button guardar_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombre_grupo_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox tipo_cliente_comboBox;
    }
}