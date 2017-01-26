namespace Sporting_Gym.Forms
{
    partial class Registro_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_Cliente));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.colonia_textBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numero_textBox = new System.Windows.Forms.TextBox();
            this.telefono_celular_textBox = new System.Windows.Forms.MaskedTextBox();
            this.calle_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.alergias_comboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.correo_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tipo_sangre_textBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tipo_sangre_label = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.fecha_limite_label = new System.Windows.Forms.Label();
            this.historial_button = new System.Windows.Forms.Button();
            this.fecha_label = new System.Windows.Forms.Label();
            this.encender_button = new System.Windows.Forms.Button();
            this.dispositivos_comboBox = new System.Windows.Forms.ComboBox();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.sexo_comboBox = new System.Windows.Forms.ComboBox();
            this.capturar_huella_button = new System.Windows.Forms.Button();
            this.tomar_foto_button = new System.Windows.Forms.Button();
            this.fecha_nacimiento_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nombre_textBox = new System.Windows.Forms.TextBox();
            this.apellido_materno_textBox = new System.Windows.Forms.TextBox();
            this.apellido_paterno_textBox = new System.Windows.Forms.TextBox();
            this.fondo_fecha_label = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.registrar_button = new System.Windows.Forms.Button();
            this.cancelar_button = new System.Windows.Forms.Button();
            this.encabezado_label = new System.Windows.Forms.Label();
            this.limpiar_button = new System.Windows.Forms.Button();
            this.buscar_cliente_button = new System.Windows.Forms.Button();
            this.cobrar_button = new System.Windows.Forms.Button();
            this.Historial_Pagos_groupBox = new System.Windows.Forms.GroupBox();
            this.historial_pagos_dataGridView = new System.Windows.Forms.DataGridView();
            this.Archivos_groupBox = new System.Windows.Forms.GroupBox();
            this.archivos_dataGridView = new System.Windows.Forms.DataGridView();
            this.adjuntar_button = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.eliminar_cliente_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fondo_fecha_label)).BeginInit();
            this.Historial_Pagos_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historial_pagos_dataGridView)).BeginInit();
            this.Archivos_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archivos_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apellido Paterno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Apellido Materno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre(s):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fecha de nacimiento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sexo:\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.colonia_textBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.numero_textBox);
            this.groupBox1.Controls.Add(this.telefono_celular_textBox);
            this.groupBox1.Controls.Add(this.calle_textBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.alergias_comboBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.correo_textBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tipo_sangre_textBox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tipo_sangre_label);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.fecha_limite_label);
            this.groupBox1.Controls.Add(this.historial_button);
            this.groupBox1.Controls.Add(this.fecha_label);
            this.groupBox1.Controls.Add(this.encender_button);
            this.groupBox1.Controls.Add(this.dispositivos_comboBox);
            this.groupBox1.Controls.Add(this.videoSourcePlayer1);
            this.groupBox1.Controls.Add(this.sexo_comboBox);
            this.groupBox1.Controls.Add(this.capturar_huella_button);
            this.groupBox1.Controls.Add(this.tomar_foto_button);
            this.groupBox1.Controls.Add(this.fecha_nacimiento_dateTimePicker);
            this.groupBox1.Controls.Add(this.nombre_textBox);
            this.groupBox1.Controls.Add(this.apellido_materno_textBox);
            this.groupBox1.Controls.Add(this.apellido_paterno_textBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.fondo_fecha_label);
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 320);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Cliente";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(28, 193);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(553, 13);
            this.label14.TabIndex = 53;
            this.label14.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "---------------------";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(464, 208);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 52;
            this.label13.Text = "Dirección:";
            // 
            // colonia_textBox
            // 
            this.colonia_textBox.Location = new System.Drawing.Point(404, 288);
            this.colonia_textBox.Name = "colonia_textBox";
            this.colonia_textBox.Size = new System.Drawing.Size(164, 20);
            this.colonia_textBox.TabIndex = 15;
            this.colonia_textBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.colonia_textBox_KeyUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(142, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "Información de contacto:";
            // 
            // numero_textBox
            // 
            this.numero_textBox.Location = new System.Drawing.Point(404, 258);
            this.numero_textBox.Name = "numero_textBox";
            this.numero_textBox.Size = new System.Drawing.Size(164, 20);
            this.numero_textBox.TabIndex = 14;
            // 
            // telefono_celular_textBox
            // 
            this.telefono_celular_textBox.Location = new System.Drawing.Point(115, 259);
            this.telefono_celular_textBox.Mask = "0000-00-00-00";
            this.telefono_celular_textBox.Name = "telefono_celular_textBox";
            this.telefono_celular_textBox.Size = new System.Drawing.Size(164, 20);
            this.telefono_celular_textBox.TabIndex = 12;
            // 
            // calle_textBox
            // 
            this.calle_textBox.Location = new System.Drawing.Point(404, 230);
            this.calle_textBox.Name = "calle_textBox";
            this.calle_textBox.Size = new System.Drawing.Size(164, 20);
            this.calle_textBox.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(347, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Colonia:";
            // 
            // alergias_comboBox
            // 
            this.alergias_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.alergias_comboBox.FormattingEnabled = true;
            this.alergias_comboBox.Items.AddRange(new object[] {
            "No",
            "Si"});
            this.alergias_comboBox.Location = new System.Drawing.Point(396, 90);
            this.alergias_comboBox.Name = "alergias_comboBox";
            this.alergias_comboBox.Size = new System.Drawing.Size(46, 21);
            this.alergias_comboBox.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(347, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Número:";
            // 
            // correo_textBox
            // 
            this.correo_textBox.Location = new System.Drawing.Point(115, 227);
            this.correo_textBox.Name = "correo_textBox";
            this.correo_textBox.Size = new System.Drawing.Size(164, 20);
            this.correo_textBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(347, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Calle:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Correo:";
            // 
            // tipo_sangre_textBox
            // 
            this.tipo_sangre_textBox.Location = new System.Drawing.Point(314, 90);
            this.tipo_sangre_textBox.Name = "tipo_sangre_textBox";
            this.tipo_sangre_textBox.Size = new System.Drawing.Size(50, 20);
            this.tipo_sangre_textBox.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Teléfono celular:";
            // 
            // tipo_sangre_label
            // 
            this.tipo_sangre_label.AutoSize = true;
            this.tipo_sangre_label.Location = new System.Drawing.Point(313, 72);
            this.tipo_sangre_label.Name = "tipo_sangre_label";
            this.tipo_sangre_label.Size = new System.Drawing.Size(68, 13);
            this.tipo_sangre_label.TabIndex = 0;
            this.tipo_sangre_label.Text = "Tipo Sangre:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(396, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Alergias:";
            // 
            // fecha_limite_label
            // 
            this.fecha_limite_label.AutoSize = true;
            this.fecha_limite_label.Location = new System.Drawing.Point(112, 172);
            this.fecha_limite_label.Name = "fecha_limite_label";
            this.fecha_limite_label.Size = new System.Drawing.Size(126, 13);
            this.fecha_limite_label.TabIndex = 0;
            this.fecha_limite_label.Text = "Fecha Limite de Servicio:";
            // 
            // historial_button
            // 
            this.historial_button.Location = new System.Drawing.Point(258, 132);
            this.historial_button.Name = "historial_button";
            this.historial_button.Size = new System.Drawing.Size(112, 23);
            this.historial_button.TabIndex = 0;
            this.historial_button.Text = "Historial Asistencias";
            this.historial_button.UseVisualStyleBackColor = true;
            this.historial_button.Click += new System.EventHandler(this.historial_button_Click);
            // 
            // fecha_label
            // 
            this.fecha_label.AutoSize = true;
            this.fecha_label.BackColor = System.Drawing.Color.White;
            this.fecha_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_label.ForeColor = System.Drawing.Color.Red;
            this.fecha_label.Location = new System.Drawing.Point(273, 172);
            this.fecha_label.Name = "fecha_label";
            this.fecha_label.Size = new System.Drawing.Size(48, 13);
            this.fecha_label.TabIndex = 0;
            this.fecha_label.Text = "label13";
            // 
            // encender_button
            // 
            this.encender_button.Image = ((System.Drawing.Image)(resources.GetObject("encender_button.Image")));
            this.encender_button.Location = new System.Drawing.Point(465, 167);
            this.encender_button.Name = "encender_button";
            this.encender_button.Size = new System.Drawing.Size(27, 23);
            this.encender_button.TabIndex = 9;
            this.encender_button.UseVisualStyleBackColor = true;
            this.encender_button.Click += new System.EventHandler(this.encender_button_Click);
            // 
            // dispositivos_comboBox
            // 
            this.dispositivos_comboBox.FormattingEnabled = true;
            this.dispositivos_comboBox.Location = new System.Drawing.Point(457, 140);
            this.dispositivos_comboBox.Name = "dispositivos_comboBox";
            this.dispositivos_comboBox.Size = new System.Drawing.Size(129, 21);
            this.dispositivos_comboBox.TabIndex = 8;
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.videoSourcePlayer1.Location = new System.Drawing.Point(457, 19);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(129, 115);
            this.videoSourcePlayer1.TabIndex = 0;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // sexo_comboBox
            // 
            this.sexo_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexo_comboBox.FormattingEnabled = true;
            this.sexo_comboBox.Items.AddRange(new object[] {
            "Seleccione el sexo",
            "Masculino\t",
            "Femenino"});
            this.sexo_comboBox.Location = new System.Drawing.Point(161, 90);
            this.sexo_comboBox.Name = "sexo_comboBox";
            this.sexo_comboBox.Size = new System.Drawing.Size(138, 21);
            this.sexo_comboBox.TabIndex = 5;
            // 
            // capturar_huella_button
            // 
            this.capturar_huella_button.Location = new System.Drawing.Point(126, 132);
            this.capturar_huella_button.Name = "capturar_huella_button";
            this.capturar_huella_button.Size = new System.Drawing.Size(94, 23);
            this.capturar_huella_button.TabIndex = 0;
            this.capturar_huella_button.Text = "Nueva Huella";
            this.capturar_huella_button.UseVisualStyleBackColor = true;
            this.capturar_huella_button.Click += new System.EventHandler(this.capturar_huella_button_Click);
            // 
            // tomar_foto_button
            // 
            this.tomar_foto_button.Location = new System.Drawing.Point(501, 167);
            this.tomar_foto_button.Name = "tomar_foto_button";
            this.tomar_foto_button.Size = new System.Drawing.Size(75, 23);
            this.tomar_foto_button.TabIndex = 10;
            this.tomar_foto_button.Text = "Tomar Foto";
            this.tomar_foto_button.UseVisualStyleBackColor = true;
            this.tomar_foto_button.Click += new System.EventHandler(this.tomar_foto_button_Click);
            // 
            // fecha_nacimiento_dateTimePicker
            // 
            this.fecha_nacimiento_dateTimePicker.Location = new System.Drawing.Point(9, 90);
            this.fecha_nacimiento_dateTimePicker.Name = "fecha_nacimiento_dateTimePicker";
            this.fecha_nacimiento_dateTimePicker.Size = new System.Drawing.Size(140, 20);
            this.fecha_nacimiento_dateTimePicker.TabIndex = 4;
            // 
            // nombre_textBox
            // 
            this.nombre_textBox.Location = new System.Drawing.Point(9, 43);
            this.nombre_textBox.Name = "nombre_textBox";
            this.nombre_textBox.Size = new System.Drawing.Size(140, 20);
            this.nombre_textBox.TabIndex = 1;
            // 
            // apellido_materno_textBox
            // 
            this.apellido_materno_textBox.Location = new System.Drawing.Point(311, 43);
            this.apellido_materno_textBox.Name = "apellido_materno_textBox";
            this.apellido_materno_textBox.Size = new System.Drawing.Size(140, 20);
            this.apellido_materno_textBox.TabIndex = 3;
            // 
            // apellido_paterno_textBox
            // 
            this.apellido_paterno_textBox.Location = new System.Drawing.Point(161, 43);
            this.apellido_paterno_textBox.Name = "apellido_paterno_textBox";
            this.apellido_paterno_textBox.Size = new System.Drawing.Size(140, 20);
            this.apellido_paterno_textBox.TabIndex = 2;
            // 
            // fondo_fecha_label
            // 
            this.fondo_fecha_label.BackColor = System.Drawing.Color.White;
            this.fondo_fecha_label.ImageLocation = "";
            this.fondo_fecha_label.Location = new System.Drawing.Point(241, 167);
            this.fondo_fecha_label.Name = "fondo_fecha_label";
            this.fondo_fecha_label.Size = new System.Drawing.Size(126, 23);
            this.fondo_fecha_label.TabIndex = 50;
            this.fondo_fecha_label.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(465, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // registrar_button
            // 
            this.registrar_button.Location = new System.Drawing.Point(18, 536);
            this.registrar_button.Name = "registrar_button";
            this.registrar_button.Size = new System.Drawing.Size(76, 23);
            this.registrar_button.TabIndex = 14;
            this.registrar_button.Text = "Registrar";
            this.registrar_button.UseVisualStyleBackColor = true;
            this.registrar_button.Click += new System.EventHandler(this.registrar_button_Click);
            // 
            // cancelar_button
            // 
            this.cancelar_button.Location = new System.Drawing.Point(537, 536);
            this.cancelar_button.Name = "cancelar_button";
            this.cancelar_button.Size = new System.Drawing.Size(75, 23);
            this.cancelar_button.TabIndex = 18;
            this.cancelar_button.Text = "Cancelar";
            this.cancelar_button.UseVisualStyleBackColor = true;
            this.cancelar_button.Click += new System.EventHandler(this.cancelar_button_Click);
            // 
            // encabezado_label
            // 
            this.encabezado_label.AutoSize = true;
            this.encabezado_label.BackColor = System.Drawing.Color.White;
            this.encabezado_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encabezado_label.Location = new System.Drawing.Point(180, 17);
            this.encabezado_label.Name = "encabezado_label";
            this.encabezado_label.Size = new System.Drawing.Size(279, 25);
            this.encabezado_label.TabIndex = 12;
            this.encabezado_label.Text = "REGISTRO NUEVO CLIENTE";
            // 
            // limpiar_button
            // 
            this.limpiar_button.Location = new System.Drawing.Point(275, 536);
            this.limpiar_button.Name = "limpiar_button";
            this.limpiar_button.Size = new System.Drawing.Size(75, 23);
            this.limpiar_button.TabIndex = 16;
            this.limpiar_button.Text = "Limpiar";
            this.limpiar_button.UseVisualStyleBackColor = true;
            this.limpiar_button.Click += new System.EventHandler(this.limpiar_button_Click);
            // 
            // buscar_cliente_button
            // 
            this.buscar_cliente_button.Location = new System.Drawing.Point(531, 21);
            this.buscar_cliente_button.Name = "buscar_cliente_button";
            this.buscar_cliente_button.Size = new System.Drawing.Size(75, 23);
            this.buscar_cliente_button.TabIndex = 23;
            this.buscar_cliente_button.Text = "Buscar";
            this.buscar_cliente_button.UseVisualStyleBackColor = true;
            this.buscar_cliente_button.Click += new System.EventHandler(this.buscar_cliente_button_Click);
            // 
            // cobrar_button
            // 
            this.cobrar_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cobrar_button.Location = new System.Drawing.Point(194, 536);
            this.cobrar_button.Name = "cobrar_button";
            this.cobrar_button.Size = new System.Drawing.Size(75, 23);
            this.cobrar_button.TabIndex = 15;
            this.cobrar_button.Text = "Cobrar";
            this.cobrar_button.UseVisualStyleBackColor = true;
            this.cobrar_button.Click += new System.EventHandler(this.cobrar_button_Click);
            // 
            // Historial_Pagos_groupBox
            // 
            this.Historial_Pagos_groupBox.BackColor = System.Drawing.Color.Transparent;
            this.Historial_Pagos_groupBox.Controls.Add(this.historial_pagos_dataGridView);
            this.Historial_Pagos_groupBox.Location = new System.Drawing.Point(12, 383);
            this.Historial_Pagos_groupBox.Name = "Historial_Pagos_groupBox";
            this.Historial_Pagos_groupBox.Size = new System.Drawing.Size(394, 144);
            this.Historial_Pagos_groupBox.TabIndex = 0;
            this.Historial_Pagos_groupBox.TabStop = false;
            this.Historial_Pagos_groupBox.Text = "Historial de Pagos";
            // 
            // historial_pagos_dataGridView
            // 
            this.historial_pagos_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.historial_pagos_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historial_pagos_dataGridView.Location = new System.Drawing.Point(6, 19);
            this.historial_pagos_dataGridView.Name = "historial_pagos_dataGridView";
            this.historial_pagos_dataGridView.ReadOnly = true;
            this.historial_pagos_dataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.historial_pagos_dataGridView.Size = new System.Drawing.Size(380, 119);
            this.historial_pagos_dataGridView.TabIndex = 0;
            this.historial_pagos_dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.historial_pagos_dataGridView_CellDoubleClick);
            // 
            // Archivos_groupBox
            // 
            this.Archivos_groupBox.BackColor = System.Drawing.Color.Transparent;
            this.Archivos_groupBox.Controls.Add(this.archivos_dataGridView);
            this.Archivos_groupBox.Controls.Add(this.adjuntar_button);
            this.Archivos_groupBox.Location = new System.Drawing.Point(415, 383);
            this.Archivos_groupBox.Name = "Archivos_groupBox";
            this.Archivos_groupBox.Size = new System.Drawing.Size(197, 144);
            this.Archivos_groupBox.TabIndex = 0;
            this.Archivos_groupBox.TabStop = false;
            this.Archivos_groupBox.Text = "Archivos";
            // 
            // archivos_dataGridView
            // 
            this.archivos_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.archivos_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.archivos_dataGridView.Location = new System.Drawing.Point(6, 42);
            this.archivos_dataGridView.Name = "archivos_dataGridView";
            this.archivos_dataGridView.ReadOnly = true;
            this.archivos_dataGridView.Size = new System.Drawing.Size(185, 96);
            this.archivos_dataGridView.TabIndex = 0;
            this.archivos_dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.archivos_dataGridView_CellDoubleClick);
            // 
            // adjuntar_button
            // 
            this.adjuntar_button.Location = new System.Drawing.Point(62, 13);
            this.adjuntar_button.Name = "adjuntar_button";
            this.adjuntar_button.Size = new System.Drawing.Size(75, 23);
            this.adjuntar_button.TabIndex = 0;
            this.adjuntar_button.Text = "Adjuntar";
            this.adjuntar_button.UseVisualStyleBackColor = true;
            this.adjuntar_button.Click += new System.EventHandler(this.adjuntar_button_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // eliminar_cliente_button
            // 
            this.eliminar_cliente_button.ForeColor = System.Drawing.Color.Red;
            this.eliminar_cliente_button.Location = new System.Drawing.Point(352, 536);
            this.eliminar_cliente_button.Name = "eliminar_cliente_button";
            this.eliminar_cliente_button.Size = new System.Drawing.Size(75, 23);
            this.eliminar_cliente_button.TabIndex = 17;
            this.eliminar_cliente_button.Text = "Eliminar";
            this.eliminar_cliente_button.UseVisualStyleBackColor = true;
            this.eliminar_cliente_button.Click += new System.EventHandler(this.eliminar_cliente_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(5, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 40);
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.Location = new System.Drawing.Point(-5, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(804, 60);
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // Registro_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(624, 565);
            this.ControlBox = false;
            this.Controls.Add(this.eliminar_cliente_button);
            this.Controls.Add(this.Historial_Pagos_groupBox);
            this.Controls.Add(this.Archivos_groupBox);
            this.Controls.Add(this.cobrar_button);
            this.Controls.Add(this.buscar_cliente_button);
            this.Controls.Add(this.limpiar_button);
            this.Controls.Add(this.encabezado_label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cancelar_button);
            this.Controls.Add(this.registrar_button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Registro_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registro_Cliente_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registro_Cliente_FormClosed);
            this.Load += new System.EventHandler(this.Registro_Cliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fondo_fecha_label)).EndInit();
            this.Historial_Pagos_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.historial_pagos_dataGridView)).EndInit();
            this.Archivos_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.archivos_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nombre_textBox;
        private System.Windows.Forms.TextBox apellido_materno_textBox;
        private System.Windows.Forms.TextBox apellido_paterno_textBox;
        private System.Windows.Forms.Button registrar_button;
        private System.Windows.Forms.Button tomar_foto_button;
        private System.Windows.Forms.Button cancelar_button;
        private System.Windows.Forms.DateTimePicker fecha_nacimiento_dateTimePicker;
        private System.Windows.Forms.Button capturar_huella_button;
        private System.Windows.Forms.TextBox colonia_textBox;
        private System.Windows.Forms.TextBox numero_textBox;
        private System.Windows.Forms.TextBox calle_textBox;
        private System.Windows.Forms.TextBox correo_textBox;
        private System.Windows.Forms.Label encabezado_label;
        private System.Windows.Forms.ComboBox sexo_comboBox;
        private System.Windows.Forms.Button limpiar_button;
        private System.Windows.Forms.Button buscar_cliente_button;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.ComboBox dispositivos_comboBox;
        private System.Windows.Forms.Button encender_button;
        private System.Windows.Forms.Button cobrar_button;
        private System.Windows.Forms.MaskedTextBox telefono_celular_textBox;
        private System.Windows.Forms.GroupBox Historial_Pagos_groupBox;
        private System.Windows.Forms.DataGridView historial_pagos_dataGridView;
        private System.Windows.Forms.GroupBox Archivos_groupBox;
        private System.Windows.Forms.DataGridView archivos_dataGridView;
        private System.Windows.Forms.Button adjuntar_button;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label fecha_label;
        private System.Windows.Forms.Label tipo_sangre_label;
        private System.Windows.Forms.Button eliminar_cliente_button;
        private System.Windows.Forms.Button historial_button;
        private System.Windows.Forms.Label fecha_limite_label;
        private System.Windows.Forms.TextBox tipo_sangre_textBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox alergias_comboBox;
        private System.Windows.Forms.PictureBox fondo_fecha_label;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
    }
}