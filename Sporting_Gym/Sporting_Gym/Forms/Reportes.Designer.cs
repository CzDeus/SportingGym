namespace Sporting_Gym.Forms
{
    partial class Reportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportes));
            this.Inicial_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Final_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Imprimir_button = new System.Windows.Forms.Button();
            this.Fecha_Final_label = new System.Windows.Forms.Label();
            this.Fecha_Inicial_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cancelar_button = new System.Windows.Forms.Button();
            this.fechas_groupBox = new System.Windows.Forms.GroupBox();
            this.corte_caja_reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Egresos_reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Balance_reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.accesos_no_vigentes_reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.clientes_sin_renovar_reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.proyeccion_ingresos_reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reporte_Generales_reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.fechas_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Inicial_dateTimePicker
            // 
            this.Inicial_dateTimePicker.Location = new System.Drawing.Point(86, 19);
            this.Inicial_dateTimePicker.Name = "Inicial_dateTimePicker";
            this.Inicial_dateTimePicker.Size = new System.Drawing.Size(180, 20);
            this.Inicial_dateTimePicker.TabIndex = 1;
            // 
            // Final_dateTimePicker
            // 
            this.Final_dateTimePicker.Location = new System.Drawing.Point(349, 19);
            this.Final_dateTimePicker.Name = "Final_dateTimePicker";
            this.Final_dateTimePicker.Size = new System.Drawing.Size(180, 20);
            this.Final_dateTimePicker.TabIndex = 2;
            // 
            // Imprimir_button
            // 
            this.Imprimir_button.Location = new System.Drawing.Point(545, 18);
            this.Imprimir_button.Name = "Imprimir_button";
            this.Imprimir_button.Size = new System.Drawing.Size(75, 23);
            this.Imprimir_button.TabIndex = 3;
            this.Imprimir_button.Text = "Visualizar";
            this.Imprimir_button.UseVisualStyleBackColor = true;
            this.Imprimir_button.Click += new System.EventHandler(this.Imprimir_button_Click);
            // 
            // Fecha_Final_label
            // 
            this.Fecha_Final_label.AutoSize = true;
            this.Fecha_Final_label.Location = new System.Drawing.Point(278, 23);
            this.Fecha_Final_label.Name = "Fecha_Final_label";
            this.Fecha_Final_label.Size = new System.Drawing.Size(65, 13);
            this.Fecha_Final_label.TabIndex = 3;
            this.Fecha_Final_label.Text = "Fecha Final:";
            // 
            // Fecha_Inicial_label
            // 
            this.Fecha_Inicial_label.AutoSize = true;
            this.Fecha_Inicial_label.Location = new System.Drawing.Point(10, 23);
            this.Fecha_Inicial_label.Name = "Fecha_Inicial_label";
            this.Fecha_Inicial_label.Size = new System.Drawing.Size(70, 13);
            this.Fecha_Inicial_label.TabIndex = 4;
            this.Fecha_Inicial_label.Text = "Fecha Inicial:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "REPORTES";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(12, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(113, 40);
            this.pictureBox4.TabIndex = 43;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(660, 60);
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // cancelar_button
            // 
            this.cancelar_button.ForeColor = System.Drawing.Color.Red;
            this.cancelar_button.Location = new System.Drawing.Point(570, 470);
            this.cancelar_button.Name = "cancelar_button";
            this.cancelar_button.Size = new System.Drawing.Size(75, 25);
            this.cancelar_button.TabIndex = 4;
            this.cancelar_button.Text = "Salir";
            this.cancelar_button.UseVisualStyleBackColor = true;
            this.cancelar_button.Click += new System.EventHandler(this.cancelar_button_Click);
            // 
            // fechas_groupBox
            // 
            this.fechas_groupBox.Controls.Add(this.Fecha_Final_label);
            this.fechas_groupBox.Controls.Add(this.Inicial_dateTimePicker);
            this.fechas_groupBox.Controls.Add(this.Final_dateTimePicker);
            this.fechas_groupBox.Controls.Add(this.Fecha_Inicial_label);
            this.fechas_groupBox.Controls.Add(this.Imprimir_button);
            this.fechas_groupBox.Location = new System.Drawing.Point(11, 67);
            this.fechas_groupBox.Name = "fechas_groupBox";
            this.fechas_groupBox.Size = new System.Drawing.Size(634, 51);
            this.fechas_groupBox.TabIndex = 0;
            this.fechas_groupBox.TabStop = false;
            // 
            // corte_caja_reportViewer
            // 
            this.corte_caja_reportViewer.LocalReport.ReportEmbeddedResource = "Sporting_Gym.Reportes.Corte_Caja.rdlc";
            this.corte_caja_reportViewer.Location = new System.Drawing.Point(11, 124);
            this.corte_caja_reportViewer.Name = "corte_caja_reportViewer";
            this.corte_caja_reportViewer.Size = new System.Drawing.Size(634, 340);
            this.corte_caja_reportViewer.TabIndex = 44;
            this.corte_caja_reportViewer.Visible = false;
            // 
            // Egresos_reportViewer
            // 
            this.Egresos_reportViewer.LocalReport.ReportEmbeddedResource = "Sporting_Gym.Reportes.Egresos.rdlc";
            this.Egresos_reportViewer.Location = new System.Drawing.Point(12, 124);
            this.Egresos_reportViewer.Name = "Egresos_reportViewer";
            this.Egresos_reportViewer.Size = new System.Drawing.Size(633, 340);
            this.Egresos_reportViewer.TabIndex = 45;
            this.Egresos_reportViewer.Visible = false;
            // 
            // Balance_reportViewer
            // 
            this.Balance_reportViewer.LocalReport.ReportEmbeddedResource = "Sporting_Gym.Reportes.Balance.rdlc";
            this.Balance_reportViewer.Location = new System.Drawing.Point(12, 124);
            this.Balance_reportViewer.Name = "Balance_reportViewer";
            this.Balance_reportViewer.Size = new System.Drawing.Size(633, 340);
            this.Balance_reportViewer.TabIndex = 46;
            this.Balance_reportViewer.Visible = false;
            // 
            // accesos_no_vigentes_reportViewer
            // 
            this.accesos_no_vigentes_reportViewer.LocalReport.ReportEmbeddedResource = "Sporting_Gym.Reportes.AccesoSinPago.rdlc";
            this.accesos_no_vigentes_reportViewer.Location = new System.Drawing.Point(11, 124);
            this.accesos_no_vigentes_reportViewer.Name = "accesos_no_vigentes_reportViewer";
            this.accesos_no_vigentes_reportViewer.Size = new System.Drawing.Size(634, 340);
            this.accesos_no_vigentes_reportViewer.TabIndex = 47;
            this.accesos_no_vigentes_reportViewer.Visible = false;
            // 
            // clientes_sin_renovar_reportViewer
            // 
            this.clientes_sin_renovar_reportViewer.LocalReport.ReportEmbeddedResource = "Sporting_Gym.Reportes.Clientes_Sin_Renovar.rdlc";
            this.clientes_sin_renovar_reportViewer.Location = new System.Drawing.Point(11, 124);
            this.clientes_sin_renovar_reportViewer.Name = "clientes_sin_renovar_reportViewer";
            this.clientes_sin_renovar_reportViewer.Size = new System.Drawing.Size(634, 340);
            this.clientes_sin_renovar_reportViewer.TabIndex = 48;
            this.clientes_sin_renovar_reportViewer.Visible = false;
            // 
            // proyeccion_ingresos_reportViewer
            // 
            this.proyeccion_ingresos_reportViewer.LocalReport.ReportEmbeddedResource = "Sporting_Gym.Reportes.Proyeccion_Ingresos.rdlc";
            this.proyeccion_ingresos_reportViewer.Location = new System.Drawing.Point(11, 124);
            this.proyeccion_ingresos_reportViewer.Name = "proyeccion_ingresos_reportViewer";
            this.proyeccion_ingresos_reportViewer.Size = new System.Drawing.Size(634, 340);
            this.proyeccion_ingresos_reportViewer.TabIndex = 49;
            this.proyeccion_ingresos_reportViewer.Visible = false;
            // 
            // reporte_Generales_reportViewer
            // 
            this.reporte_Generales_reportViewer.DocumentMapWidth = 87;
            this.reporte_Generales_reportViewer.LocalReport.ReportEmbeddedResource = "Sporting_Gym.Reportes.Clientes_generales.rdlc";
            this.reporte_Generales_reportViewer.Location = new System.Drawing.Point(12, 124);
            this.reporte_Generales_reportViewer.Name = "reporte_Generales_reportViewer";
            this.reporte_Generales_reportViewer.Size = new System.Drawing.Size(633, 340);
            this.reporte_Generales_reportViewer.TabIndex = 50;
            this.reporte_Generales_reportViewer.Visible = false;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(652, 498);
            this.ControlBox = false;
            this.Controls.Add(this.reporte_Generales_reportViewer);
            this.Controls.Add(this.proyeccion_ingresos_reportViewer);
            this.Controls.Add(this.clientes_sin_renovar_reportViewer);
            this.Controls.Add(this.accesos_no_vigentes_reportViewer);
            this.Controls.Add(this.Balance_reportViewer);
            this.Controls.Add(this.Egresos_reportViewer);
            this.Controls.Add(this.corte_caja_reportViewer);
            this.Controls.Add(this.fechas_groupBox);
            this.Controls.Add(this.cancelar_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Reportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.Reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.fechas_groupBox.ResumeLayout(false);
            this.fechas_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Inicial_dateTimePicker;
        private System.Windows.Forms.DateTimePicker Final_dateTimePicker;
        private System.Windows.Forms.Button Imprimir_button;
        private System.Windows.Forms.Label Fecha_Final_label;
        private System.Windows.Forms.Label Fecha_Inicial_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button cancelar_button;
        private System.Windows.Forms.GroupBox fechas_groupBox;
        private Microsoft.Reporting.WinForms.ReportViewer corte_caja_reportViewer;
        private Microsoft.Reporting.WinForms.ReportViewer Egresos_reportViewer;
        private Microsoft.Reporting.WinForms.ReportViewer Balance_reportViewer;
        private Microsoft.Reporting.WinForms.ReportViewer accesos_no_vigentes_reportViewer;
        private Microsoft.Reporting.WinForms.ReportViewer clientes_sin_renovar_reportViewer;
        private Microsoft.Reporting.WinForms.ReportViewer proyeccion_ingresos_reportViewer;
        private Microsoft.Reporting.WinForms.ReportViewer reporte_Generales_reportViewer;
    }
}