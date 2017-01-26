namespace Sporting_Gym.Forms
{
    partial class Cobro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cobro));
            this.label2 = new System.Windows.Forms.Label();
            this.tipo_pago_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.importe_pagar_textBox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cantidad_descuento_textBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.justificacion_textBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.no_descuento_radioButton = new System.Windows.Forms.RadioButton();
            this.si_descuento_radioButton = new System.Windows.Forms.RadioButton();
            this.total_textBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cobrar_button = new System.Windows.Forms.Button();
            this.regresar_button = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tipo_cliente_comboBox = new System.Windows.Forms.ComboBox();
            this.periodo_comboBox = new System.Windows.Forms.ComboBox();
            this.observaciones_textBox = new System.Windows.Forms.TextBox();
            this.buscar_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nombre_textBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.info_grupo_button = new System.Windows.Forms.Button();
            this.dbsportinggymDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Recibido_textBox = new System.Windows.Forms.TextBox();
            this.Cambio_textBox = new System.Windows.Forms.TextBox();
            this.reporte_reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.reporte_gym_reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbsportinggymDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(27, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Método de Pago:";
            // 
            // tipo_pago_comboBox
            // 
            this.tipo_pago_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipo_pago_comboBox.FormattingEnabled = true;
            this.tipo_pago_comboBox.Location = new System.Drawing.Point(124, 71);
            this.tipo_pago_comboBox.Name = "tipo_pago_comboBox";
            this.tipo_pago_comboBox.Size = new System.Drawing.Size(125, 21);
            this.tipo_pago_comboBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Importe a pagar";
            // 
            // importe_pagar_textBox
            // 
            this.importe_pagar_textBox.BackColor = System.Drawing.Color.Red;
            this.importe_pagar_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importe_pagar_textBox.ForeColor = System.Drawing.SystemColors.Window;
            this.importe_pagar_textBox.Location = new System.Drawing.Point(89, 121);
            this.importe_pagar_textBox.Name = "importe_pagar_textBox";
            this.importe_pagar_textBox.ReadOnly = true;
            this.importe_pagar_textBox.Size = new System.Drawing.Size(125, 38);
            this.importe_pagar_textBox.TabIndex = 4;
            this.importe_pagar_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.cantidad_descuento_textBox);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.justificacion_textBox);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.no_descuento_radioButton);
            this.groupBox5.Controls.Add(this.si_descuento_radioButton);
            this.groupBox5.Location = new System.Drawing.Point(7, 253);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(338, 133);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Descuento Adicional";
            // 
            // cantidad_descuento_textBox
            // 
            this.cantidad_descuento_textBox.Enabled = false;
            this.cantidad_descuento_textBox.Location = new System.Drawing.Point(240, 20);
            this.cantidad_descuento_textBox.Name = "cantidad_descuento_textBox";
            this.cantidad_descuento_textBox.Size = new System.Drawing.Size(81, 20);
            this.cantidad_descuento_textBox.TabIndex = 6;
            this.cantidad_descuento_textBox.TextChanged += new System.EventHandler(this.calcularImportePagar);
            this.cantidad_descuento_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cantidad_descuento_textBox_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(134, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "Importe Descuento:";
            // 
            // justificacion_textBox
            // 
            this.justificacion_textBox.Location = new System.Drawing.Point(12, 57);
            this.justificacion_textBox.Multiline = true;
            this.justificacion_textBox.Name = "justificacion_textBox";
            this.justificacion_textBox.ReadOnly = true;
            this.justificacion_textBox.Size = new System.Drawing.Size(320, 68);
            this.justificacion_textBox.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 40);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Justificación";
            // 
            // no_descuento_radioButton
            // 
            this.no_descuento_radioButton.AutoSize = true;
            this.no_descuento_radioButton.Checked = true;
            this.no_descuento_radioButton.Location = new System.Drawing.Point(12, 21);
            this.no_descuento_radioButton.Name = "no_descuento_radioButton";
            this.no_descuento_radioButton.Size = new System.Drawing.Size(39, 17);
            this.no_descuento_radioButton.TabIndex = 4;
            this.no_descuento_radioButton.TabStop = true;
            this.no_descuento_radioButton.Text = "No";
            this.no_descuento_radioButton.UseVisualStyleBackColor = true;
            this.no_descuento_radioButton.CheckedChanged += new System.EventHandler(this.no_descuento_radioButton_CheckedChanged);
            // 
            // si_descuento_radioButton
            // 
            this.si_descuento_radioButton.AutoSize = true;
            this.si_descuento_radioButton.Location = new System.Drawing.Point(64, 21);
            this.si_descuento_radioButton.Name = "si_descuento_radioButton";
            this.si_descuento_radioButton.Size = new System.Drawing.Size(34, 17);
            this.si_descuento_radioButton.TabIndex = 5;
            this.si_descuento_radioButton.Text = "Si";
            this.si_descuento_radioButton.UseVisualStyleBackColor = true;
            this.si_descuento_radioButton.CheckedChanged += new System.EventHandler(this.si_descuento_radioButton_CheckedChanged);
            // 
            // total_textBox
            // 
            this.total_textBox.BackColor = System.Drawing.Color.Red;
            this.total_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_textBox.ForeColor = System.Drawing.SystemColors.Window;
            this.total_textBox.Location = new System.Drawing.Point(124, 480);
            this.total_textBox.Name = "total_textBox";
            this.total_textBox.ReadOnly = true;
            this.total_textBox.Size = new System.Drawing.Size(125, 38);
            this.total_textBox.TabIndex = 25;
            this.total_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(64, 489);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 20);
            this.label14.TabIndex = 24;
            this.label14.Text = "Total:";
            // 
            // cobrar_button
            // 
            this.cobrar_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cobrar_button.Location = new System.Drawing.Point(99, 551);
            this.cobrar_button.Name = "cobrar_button";
            this.cobrar_button.Size = new System.Drawing.Size(75, 23);
            this.cobrar_button.TabIndex = 8;
            this.cobrar_button.Text = "Cobrar";
            this.cobrar_button.UseVisualStyleBackColor = true;
            this.cobrar_button.Click += new System.EventHandler(this.cobrar_button_Click);
            // 
            // regresar_button
            // 
            this.regresar_button.ForeColor = System.Drawing.Color.Red;
            this.regresar_button.Location = new System.Drawing.Point(180, 551);
            this.regresar_button.Name = "regresar_button";
            this.regresar_button.Size = new System.Drawing.Size(75, 23);
            this.regresar_button.TabIndex = 9;
            this.regresar_button.Text = "Cancelar";
            this.regresar_button.UseVisualStyleBackColor = true;
            this.regresar_button.Click += new System.EventHandler(this.regresar_button_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(5, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(130, 40);
            this.pictureBox4.TabIndex = 28;
            this.pictureBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(24, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(50, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Tipo Cliente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(70, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Periodo:";
            // 
            // tipo_cliente_comboBox
            // 
            this.tipo_cliente_comboBox.BackColor = System.Drawing.SystemColors.Window;
            this.tipo_cliente_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipo_cliente_comboBox.FormattingEnabled = true;
            this.tipo_cliente_comboBox.Location = new System.Drawing.Point(124, 17);
            this.tipo_cliente_comboBox.Name = "tipo_cliente_comboBox";
            this.tipo_cliente_comboBox.Size = new System.Drawing.Size(125, 21);
            this.tipo_cliente_comboBox.TabIndex = 1;
            this.tipo_cliente_comboBox.SelectedIndexChanged += new System.EventHandler(this.calcularImportePagar);
            this.tipo_cliente_comboBox.Click += new System.EventHandler(this.tipo_cliente_comboBox_Click);
            // 
            // periodo_comboBox
            // 
            this.periodo_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.periodo_comboBox.FormattingEnabled = true;
            this.periodo_comboBox.Location = new System.Drawing.Point(124, 44);
            this.periodo_comboBox.Name = "periodo_comboBox";
            this.periodo_comboBox.Size = new System.Drawing.Size(125, 21);
            this.periodo_comboBox.TabIndex = 2;
            this.periodo_comboBox.SelectedIndexChanged += new System.EventHandler(this.calcularImportePagar);
            // 
            // observaciones_textBox
            // 
            this.observaciones_textBox.Location = new System.Drawing.Point(12, 19);
            this.observaciones_textBox.Multiline = true;
            this.observaciones_textBox.Name = "observaciones_textBox";
            this.observaciones_textBox.Size = new System.Drawing.Size(320, 60);
            this.observaciones_textBox.TabIndex = 8;
            // 
            // buscar_button
            // 
            this.buscar_button.BackgroundImage = global::Sporting_Gym.Properties.Resources.search_icon_png_21;
            this.buscar_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buscar_button.Location = new System.Drawing.Point(286, 55);
            this.buscar_button.Name = "buscar_button";
            this.buscar_button.Size = new System.Drawing.Size(30, 30);
            this.buscar_button.TabIndex = 10;
            this.buscar_button.UseVisualStyleBackColor = true;
            this.buscar_button.Click += new System.EventHandler(this.buscar_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.observaciones_textBox);
            this.groupBox1.Location = new System.Drawing.Point(7, 387);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 88);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Observaciones";
            // 
            // nombre_textBox
            // 
            this.nombre_textBox.Enabled = false;
            this.nombre_textBox.Location = new System.Drawing.Point(72, 61);
            this.nombre_textBox.Name = "nombre_textBox";
            this.nombre_textBox.ReadOnly = true;
            this.nombre_textBox.Size = new System.Drawing.Size(208, 20);
            this.nombre_textBox.TabIndex = 38;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.info_grupo_button);
            this.groupBox2.Controls.Add(this.tipo_cliente_comboBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tipo_pago_comboBox);
            this.groupBox2.Controls.Add(this.periodo_comboBox);
            this.groupBox2.Controls.Add(this.importe_pagar_textBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(34, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 165);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información del pago";
            // 
            // info_grupo_button
            // 
            this.info_grupo_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("info_grupo_button.BackgroundImage")));
            this.info_grupo_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.info_grupo_button.Location = new System.Drawing.Point(252, 17);
            this.info_grupo_button.Name = "info_grupo_button";
            this.info_grupo_button.Size = new System.Drawing.Size(23, 23);
            this.info_grupo_button.TabIndex = 36;
            this.info_grupo_button.UseVisualStyleBackColor = true;
            this.info_grupo_button.Visible = false;
            this.info_grupo_button.Click += new System.EventHandler(this.info_grupo_button_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.ImageLocation = "";
            this.pictureBox3.Location = new System.Drawing.Point(-3, -7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(366, 60);
            this.pictureBox3.TabIndex = 51;
            this.pictureBox3.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(178, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 52;
            this.label8.Text = "COBRAR";
            // 
            // Recibido_textBox
            // 
            this.Recibido_textBox.Location = new System.Drawing.Point(67, 524);
            this.Recibido_textBox.Name = "Recibido_textBox";
            this.Recibido_textBox.Size = new System.Drawing.Size(100, 20);
            this.Recibido_textBox.TabIndex = 53;
            this.Recibido_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Recibido_textBox_KeyDown);
            this.Recibido_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cantidad_descuento_textBox_KeyPress);
            this.Recibido_textBox.Leave += new System.EventHandler(this.Recibido_textBox_Leave);
            // 
            // Cambio_textBox
            // 
            this.Cambio_textBox.Location = new System.Drawing.Point(235, 524);
            this.Cambio_textBox.Name = "Cambio_textBox";
            this.Cambio_textBox.ReadOnly = true;
            this.Cambio_textBox.Size = new System.Drawing.Size(100, 20);
            this.Cambio_textBox.TabIndex = 54;
            this.Cambio_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cantidad_descuento_textBox_KeyPress);
            // 
            // reporte_reportViewer
            // 
            this.reporte_reportViewer.DocumentMapWidth = 29;
            this.reporte_reportViewer.LocalReport.ReportEmbeddedResource = "Sporting_Gym.Reportes.Recibo_Cliente.rdlc";
            this.reporte_reportViewer.Location = new System.Drawing.Point(5, 476);
            this.reporte_reportViewer.Name = "reporte_reportViewer";
            this.reporte_reportViewer.Size = new System.Drawing.Size(31, 33);
            this.reporte_reportViewer.TabIndex = 8;
            this.reporte_reportViewer.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 528);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Recibido:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 528);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "Cambio:";
            // 
            // reporte_gym_reportViewer
            // 
            this.reporte_gym_reportViewer.DocumentMapWidth = 29;
            this.reporte_gym_reportViewer.LocalReport.ReportEmbeddedResource = "Sporting_Gym.Reportes.Recibo_Gimnasio.rdlc";
            this.reporte_gym_reportViewer.Location = new System.Drawing.Point(314, 480);
            this.reporte_gym_reportViewer.Name = "reporte_gym_reportViewer";
            this.reporte_gym_reportViewer.Size = new System.Drawing.Size(31, 33);
            this.reporte_gym_reportViewer.TabIndex = 57;
            this.reporte_gym_reportViewer.Visible = false;
            // 
            // Cobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(352, 577);
            this.ControlBox = false;
            this.Controls.Add(this.reporte_gym_reportViewer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reporte_reportViewer);
            this.Controls.Add(this.Cambio_textBox);
            this.Controls.Add(this.Recibido_textBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.nombre_textBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buscar_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.regresar_button);
            this.Controls.Add(this.cobrar_button);
            this.Controls.Add(this.total_textBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Cobro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.Cobro_Load);
            this.Enter += new System.EventHandler(this.Cobro_Enter);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbsportinggymDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox tipo_pago_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox importe_pagar_textBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox cantidad_descuento_textBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox justificacion_textBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RadioButton no_descuento_radioButton;
        private System.Windows.Forms.RadioButton si_descuento_radioButton;
        private System.Windows.Forms.TextBox total_textBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button cobrar_button;
        private System.Windows.Forms.Button regresar_button;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox tipo_cliente_comboBox;
        private System.Windows.Forms.ComboBox periodo_comboBox;
        private System.Windows.Forms.TextBox observaciones_textBox;
        private System.Windows.Forms.Button buscar_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nombre_textBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource dbsportinggymDataSetBindingSource;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button info_grupo_button;
        private System.Windows.Forms.TextBox Recibido_textBox;
        private System.Windows.Forms.TextBox Cambio_textBox;
        private Microsoft.Reporting.WinForms.ReportViewer reporte_reportViewer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private Microsoft.Reporting.WinForms.ReportViewer reporte_gym_reportViewer;
    }
}