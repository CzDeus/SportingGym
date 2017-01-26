namespace Sporting_Gym.Forms
{
    partial class Ficha_Historial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ficha_Historial));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.observacion_textBox = new System.Windows.Forms.TextBox();
            this.justificacion_textBox = new System.Windows.Forms.TextBox();
            this.volver_button = new System.Windows.Forms.Button();
            this.fecha_pago_textBox = new System.Windows.Forms.TextBox();
            this.metodo_pago_textBox = new System.Windows.Forms.TextBox();
            this.periodo_textBox = new System.Windows.Forms.TextBox();
            this.tipo_cliente_textBox = new System.Windows.Forms.TextBox();
            this.impore_pagar_textBox = new System.Windows.Forms.TextBox();
            this.importe_pagado_textBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nombre_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.reporte_reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fecha de pago:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Método de pago:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Periodo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tipo Cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Importe a Pagar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(474, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Importe Pagado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Justificación";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(292, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Observaciones:";
            // 
            // observacion_textBox
            // 
            this.observacion_textBox.Location = new System.Drawing.Point(295, 154);
            this.observacion_textBox.Multiline = true;
            this.observacion_textBox.Name = "observacion_textBox";
            this.observacion_textBox.ReadOnly = true;
            this.observacion_textBox.Size = new System.Drawing.Size(279, 76);
            this.observacion_textBox.TabIndex = 0;
            // 
            // justificacion_textBox
            // 
            this.justificacion_textBox.Location = new System.Drawing.Point(12, 154);
            this.justificacion_textBox.Multiline = true;
            this.justificacion_textBox.Name = "justificacion_textBox";
            this.justificacion_textBox.ReadOnly = true;
            this.justificacion_textBox.Size = new System.Drawing.Size(277, 76);
            this.justificacion_textBox.TabIndex = 0;
            // 
            // volver_button
            // 
            this.volver_button.ForeColor = System.Drawing.Color.Red;
            this.volver_button.Location = new System.Drawing.Point(487, 235);
            this.volver_button.Name = "volver_button";
            this.volver_button.Size = new System.Drawing.Size(75, 23);
            this.volver_button.TabIndex = 1;
            this.volver_button.Text = "Salir";
            this.volver_button.UseVisualStyleBackColor = true;
            this.volver_button.Click += new System.EventHandler(this.volver_button_Click);
            // 
            // fecha_pago_textBox
            // 
            this.fecha_pago_textBox.Location = new System.Drawing.Point(97, 58);
            this.fecha_pago_textBox.Name = "fecha_pago_textBox";
            this.fecha_pago_textBox.ReadOnly = true;
            this.fecha_pago_textBox.Size = new System.Drawing.Size(100, 20);
            this.fecha_pago_textBox.TabIndex = 0;
            // 
            // metodo_pago_textBox
            // 
            this.metodo_pago_textBox.Location = new System.Drawing.Point(9, 108);
            this.metodo_pago_textBox.Name = "metodo_pago_textBox";
            this.metodo_pago_textBox.ReadOnly = true;
            this.metodo_pago_textBox.Size = new System.Drawing.Size(100, 20);
            this.metodo_pago_textBox.TabIndex = 0;
            // 
            // periodo_textBox
            // 
            this.periodo_textBox.Location = new System.Drawing.Point(125, 108);
            this.periodo_textBox.Name = "periodo_textBox";
            this.periodo_textBox.ReadOnly = true;
            this.periodo_textBox.Size = new System.Drawing.Size(100, 20);
            this.periodo_textBox.TabIndex = 0;
            // 
            // tipo_cliente_textBox
            // 
            this.tipo_cliente_textBox.Location = new System.Drawing.Point(241, 108);
            this.tipo_cliente_textBox.Name = "tipo_cliente_textBox";
            this.tipo_cliente_textBox.ReadOnly = true;
            this.tipo_cliente_textBox.Size = new System.Drawing.Size(100, 20);
            this.tipo_cliente_textBox.TabIndex = 0;
            // 
            // impore_pagar_textBox
            // 
            this.impore_pagar_textBox.Location = new System.Drawing.Point(357, 108);
            this.impore_pagar_textBox.Name = "impore_pagar_textBox";
            this.impore_pagar_textBox.ReadOnly = true;
            this.impore_pagar_textBox.Size = new System.Drawing.Size(100, 20);
            this.impore_pagar_textBox.TabIndex = 0;
            // 
            // importe_pagado_textBox
            // 
            this.importe_pagado_textBox.Location = new System.Drawing.Point(473, 108);
            this.importe_pagado_textBox.Name = "importe_pagado_textBox";
            this.importe_pagado_textBox.ReadOnly = true;
            this.importe_pagado_textBox.Size = new System.Drawing.Size(100, 20);
            this.importe_pagado_textBox.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.Location = new System.Drawing.Point(-5, -9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(600, 60);
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
            this.pictureBox4.Size = new System.Drawing.Size(114, 40);
            this.pictureBox4.TabIndex = 35;
            this.pictureBox4.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(227, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "FICHA DE PAGO";
            // 
            // nombre_label
            // 
            this.nombre_label.AutoSize = true;
            this.nombre_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_label.Location = new System.Drawing.Point(299, 60);
            this.nombre_label.Name = "nombre_label";
            this.nombre_label.Size = new System.Drawing.Size(50, 13);
            this.nombre_label.TabIndex = 37;
            this.nombre_label.Text = "Nombre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "Reimprimir ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reporte_reportViewer
            // 
            this.reporte_reportViewer.DocumentMapWidth = 25;
            this.reporte_reportViewer.LocalReport.ReportEmbeddedResource = "Sporting_Gym.Reportes.Recibo_Cliente.rdlc";
            this.reporte_reportViewer.Location = new System.Drawing.Point(337, 236);
            this.reporte_reportViewer.Name = "reporte_reportViewer";
            this.reporte_reportViewer.Size = new System.Drawing.Size(102, 23);
            this.reporte_reportViewer.TabIndex = 39;
            this.reporte_reportViewer.Visible = false;
            // 
            // Ficha_Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(582, 262);
            this.ControlBox = false;
            this.Controls.Add(this.reporte_reportViewer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nombre_label);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.importe_pagado_textBox);
            this.Controls.Add(this.impore_pagar_textBox);
            this.Controls.Add(this.tipo_cliente_textBox);
            this.Controls.Add(this.periodo_textBox);
            this.Controls.Add(this.metodo_pago_textBox);
            this.Controls.Add(this.fecha_pago_textBox);
            this.Controls.Add(this.volver_button);
            this.Controls.Add(this.justificacion_textBox);
            this.Controls.Add(this.observacion_textBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Ficha_Historial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.Historial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox observacion_textBox;
        private System.Windows.Forms.TextBox justificacion_textBox;
        private System.Windows.Forms.Button volver_button;
        private System.Windows.Forms.TextBox fecha_pago_textBox;
        private System.Windows.Forms.TextBox metodo_pago_textBox;
        private System.Windows.Forms.TextBox periodo_textBox;
        private System.Windows.Forms.TextBox tipo_cliente_textBox;
        private System.Windows.Forms.TextBox impore_pagar_textBox;
        private System.Windows.Forms.TextBox importe_pagado_textBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label nombre_label;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reporte_reportViewer;
    }
}