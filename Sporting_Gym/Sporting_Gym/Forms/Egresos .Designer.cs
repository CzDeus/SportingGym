namespace Sporting_Gym.Forms
{
    partial class Egresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Egresos));
            this.label1 = new System.Windows.Forms.Label();
            this.tipo_egreso_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cantidad_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.justificacion_textBox = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guardar_button = new System.Windows.Forms.Button();
            this.salir_button = new System.Windows.Forms.Button();
            this.fecha_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de egreso:";
            // 
            // tipo_egreso_comboBox
            // 
            this.tipo_egreso_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipo_egreso_comboBox.FormattingEnabled = true;
            this.tipo_egreso_comboBox.Location = new System.Drawing.Point(12, 85);
            this.tipo_egreso_comboBox.Name = "tipo_egreso_comboBox";
            this.tipo_egreso_comboBox.Size = new System.Drawing.Size(121, 21);
            this.tipo_egreso_comboBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad:";
            // 
            // cantidad_textBox
            // 
            this.cantidad_textBox.Location = new System.Drawing.Point(151, 86);
            this.cantidad_textBox.Name = "cantidad_textBox";
            this.cantidad_textBox.Size = new System.Drawing.Size(98, 20);
            this.cantidad_textBox.TabIndex = 1;
            this.cantidad_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cantidad_textBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Justificación:";
            // 
            // justificacion_textBox
            // 
            this.justificacion_textBox.Location = new System.Drawing.Point(17, 133);
            this.justificacion_textBox.Multiline = true;
            this.justificacion_textBox.Name = "justificacion_textBox";
            this.justificacion_textBox.Size = new System.Drawing.Size(355, 60);
            this.justificacion_textBox.TabIndex = 2;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(7, 7);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(111, 40);
            this.pictureBox4.TabIndex = 37;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.Location = new System.Drawing.Point(-5, -4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(432, 60);
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(175, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Registro Egreso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Fecha:";
            // 
            // guardar_button
            // 
            this.guardar_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.guardar_button.Location = new System.Drawing.Point(216, 199);
            this.guardar_button.Name = "guardar_button";
            this.guardar_button.Size = new System.Drawing.Size(75, 23);
            this.guardar_button.TabIndex = 3;
            this.guardar_button.Text = "Guardar";
            this.guardar_button.UseVisualStyleBackColor = true;
            this.guardar_button.Click += new System.EventHandler(this.guardar_button_Click);
            // 
            // salir_button
            // 
            this.salir_button.ForeColor = System.Drawing.Color.Red;
            this.salir_button.Location = new System.Drawing.Point(297, 199);
            this.salir_button.Name = "salir_button";
            this.salir_button.Size = new System.Drawing.Size(75, 23);
            this.salir_button.TabIndex = 4;
            this.salir_button.Text = "Salir";
            this.salir_button.UseVisualStyleBackColor = true;
            this.salir_button.Click += new System.EventHandler(this.salir_button_Click);
            // 
            // fecha_dateTimePicker
            // 
            this.fecha_dateTimePicker.Location = new System.Drawing.Point(272, 86);
            this.fecha_dateTimePicker.Name = "fecha_dateTimePicker";
            this.fecha_dateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.fecha_dateTimePicker.TabIndex = 40;
            // 
            // Egresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(389, 227);
            this.ControlBox = false;
            this.Controls.Add(this.fecha_dateTimePicker);
            this.Controls.Add(this.salir_button);
            this.Controls.Add(this.guardar_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.justificacion_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cantidad_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tipo_egreso_comboBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Egresos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.Egresos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tipo_egreso_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cantidad_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox justificacion_textBox;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button guardar_button;
        private System.Windows.Forms.Button salir_button;
        private System.Windows.Forms.DateTimePicker fecha_dateTimePicker;
    }
}