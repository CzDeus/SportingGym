namespace Sporting_Gym
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.prueba_label = new System.Windows.Forms.Label();
            this.registro_button = new System.Windows.Forms.Button();
            this.Salir_Button = new System.Windows.Forms.Button();
            this.Pagos_Button = new System.Windows.Forms.Button();
            this.Reportes_Button = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.submenu_clientes_panel = new System.Windows.Forms.Panel();
            this.correos_label = new System.Windows.Forms.Label();
            this.buscar_cliente_label = new System.Windows.Forms.Label();
            this.nuevo_cliente_label = new System.Windows.Forms.Label();
            this.submenu_pagos_panel = new System.Windows.Forms.Panel();
            this.egresos_label = new System.Windows.Forms.Label();
            this.cancelar_pago_label = new System.Windows.Forms.Label();
            this.historial_pagos_label = new System.Windows.Forms.Label();
            this.cobrar_label = new System.Windows.Forms.Label();
            this.submenu_reportes_panel = new System.Windows.Forms.Panel();
            this.Reporte_Balance_label = new System.Windows.Forms.Label();
            this.Reporte_Egresos_label = new System.Windows.Forms.Label();
            this.Clientes_Generales_label = new System.Windows.Forms.Label();
            this.clientes_sin_renovar = new System.Windows.Forms.Label();
            this.proyeccion_ingresos_label = new System.Windows.Forms.Label();
            this.acceso_no_vigentes_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.corte_caja_label = new System.Windows.Forms.Label();
            this.Catalogo_Button = new System.Windows.Forms.Button();
            this.usuarios_button = new System.Windows.Forms.Button();
            this.fondo_submenu_panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.submenu_clientes_panel.SuspendLayout();
            this.submenu_pagos_panel.SuspendLayout();
            this.submenu_reportes_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // prueba_label
            // 
            this.prueba_label.AutoSize = true;
            this.prueba_label.Location = new System.Drawing.Point(555, 19);
            this.prueba_label.Name = "prueba_label";
            this.prueba_label.Size = new System.Drawing.Size(13, 13);
            this.prueba_label.TabIndex = 19;
            this.prueba_label.Text = "0";
            this.prueba_label.Visible = false;
            // 
            // registro_button
            // 
            this.registro_button.BackColor = System.Drawing.Color.Transparent;
            this.registro_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("registro_button.BackgroundImage")));
            this.registro_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.registro_button.FlatAppearance.BorderSize = 0;
            this.registro_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registro_button.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.registro_button.Location = new System.Drawing.Point(12, 12);
            this.registro_button.Name = "registro_button";
            this.registro_button.Size = new System.Drawing.Size(121, 25);
            this.registro_button.TabIndex = 1;
            this.registro_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.registro_button.UseVisualStyleBackColor = false;
            this.registro_button.Click += new System.EventHandler(this.registro_button_Click);
            // 
            // Salir_Button
            // 
            this.Salir_Button.BackColor = System.Drawing.Color.Transparent;
            this.Salir_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Salir_Button.BackgroundImage")));
            this.Salir_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Salir_Button.FlatAppearance.BorderSize = 0;
            this.Salir_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salir_Button.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Salir_Button.Location = new System.Drawing.Point(700, 557);
            this.Salir_Button.Name = "Salir_Button";
            this.Salir_Button.Size = new System.Drawing.Size(82, 25);
            this.Salir_Button.TabIndex = 6;
            this.Salir_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Salir_Button.UseVisualStyleBackColor = false;
            this.Salir_Button.Click += new System.EventHandler(this.Salir_Button_Click);
            // 
            // Pagos_Button
            // 
            this.Pagos_Button.BackColor = System.Drawing.Color.Transparent;
            this.Pagos_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pagos_Button.BackgroundImage")));
            this.Pagos_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pagos_Button.FlatAppearance.BorderSize = 0;
            this.Pagos_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pagos_Button.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Pagos_Button.Location = new System.Drawing.Point(139, 12);
            this.Pagos_Button.Name = "Pagos_Button";
            this.Pagos_Button.Size = new System.Drawing.Size(121, 25);
            this.Pagos_Button.TabIndex = 2;
            this.Pagos_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Pagos_Button.UseVisualStyleBackColor = false;
            this.Pagos_Button.Click += new System.EventHandler(this.Pagos_Button_Click);
            // 
            // Reportes_Button
            // 
            this.Reportes_Button.BackColor = System.Drawing.Color.Transparent;
            this.Reportes_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Reportes_Button.BackgroundImage")));
            this.Reportes_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Reportes_Button.FlatAppearance.BorderSize = 0;
            this.Reportes_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reportes_Button.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Reportes_Button.Location = new System.Drawing.Point(396, 12);
            this.Reportes_Button.Name = "Reportes_Button";
            this.Reportes_Button.Size = new System.Drawing.Size(121, 25);
            this.Reportes_Button.TabIndex = 4;
            this.Reportes_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Reportes_Button.UseVisualStyleBackColor = false;
            this.Reportes_Button.Click += new System.EventHandler(this.Reportes_Button_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(225, 217);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(333, 127);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.ImageLocation = "";
            this.pictureBox3.Location = new System.Drawing.Point(-5, -12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1033, 60);
            this.pictureBox3.TabIndex = 50;
            this.pictureBox3.TabStop = false;
            // 
            // submenu_clientes_panel
            // 
            this.submenu_clientes_panel.BackColor = System.Drawing.Color.White;
            this.submenu_clientes_panel.Controls.Add(this.correos_label);
            this.submenu_clientes_panel.Controls.Add(this.buscar_cliente_label);
            this.submenu_clientes_panel.Controls.Add(this.nuevo_cliente_label);
            this.submenu_clientes_panel.Location = new System.Drawing.Point(-5, 79);
            this.submenu_clientes_panel.Name = "submenu_clientes_panel";
            this.submenu_clientes_panel.Size = new System.Drawing.Size(1033, 25);
            this.submenu_clientes_panel.TabIndex = 53;
            // 
            // correos_label
            // 
            this.correos_label.AutoSize = true;
            this.correos_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correos_label.ForeColor = System.Drawing.Color.Red;
            this.correos_label.Location = new System.Drawing.Point(214, 5);
            this.correos_label.Name = "correos_label";
            this.correos_label.Size = new System.Drawing.Size(50, 15);
            this.correos_label.TabIndex = 9;
            this.correos_label.Text = "Correo";
            this.correos_label.Click += new System.EventHandler(this.Submenus);
            // 
            // buscar_cliente_label
            // 
            this.buscar_cliente_label.AutoSize = true;
            this.buscar_cliente_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar_cliente_label.ForeColor = System.Drawing.Color.Red;
            this.buscar_cliente_label.Location = new System.Drawing.Point(137, 5);
            this.buscar_cliente_label.Name = "buscar_cliente_label";
            this.buscar_cliente_label.Size = new System.Drawing.Size(51, 15);
            this.buscar_cliente_label.TabIndex = 8;
            this.buscar_cliente_label.Text = "Buscar";
            this.buscar_cliente_label.Click += new System.EventHandler(this.Submenus);
            // 
            // nuevo_cliente_label
            // 
            this.nuevo_cliente_label.AutoSize = true;
            this.nuevo_cliente_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevo_cliente_label.ForeColor = System.Drawing.Color.Red;
            this.nuevo_cliente_label.Location = new System.Drawing.Point(66, 5);
            this.nuevo_cliente_label.Name = "nuevo_cliente_label";
            this.nuevo_cliente_label.Size = new System.Drawing.Size(47, 15);
            this.nuevo_cliente_label.TabIndex = 7;
            this.nuevo_cliente_label.Text = "Nuevo";
            this.nuevo_cliente_label.Click += new System.EventHandler(this.Submenus);
            // 
            // submenu_pagos_panel
            // 
            this.submenu_pagos_panel.BackColor = System.Drawing.Color.White;
            this.submenu_pagos_panel.Controls.Add(this.egresos_label);
            this.submenu_pagos_panel.Controls.Add(this.cancelar_pago_label);
            this.submenu_pagos_panel.Controls.Add(this.historial_pagos_label);
            this.submenu_pagos_panel.Controls.Add(this.cobrar_label);
            this.submenu_pagos_panel.Location = new System.Drawing.Point(-5, 110);
            this.submenu_pagos_panel.Name = "submenu_pagos_panel";
            this.submenu_pagos_panel.Size = new System.Drawing.Size(1033, 25);
            this.submenu_pagos_panel.TabIndex = 55;
            // 
            // egresos_label
            // 
            this.egresos_label.AutoSize = true;
            this.egresos_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.egresos_label.ForeColor = System.Drawing.Color.Red;
            this.egresos_label.Location = new System.Drawing.Point(271, 5);
            this.egresos_label.Name = "egresos_label";
            this.egresos_label.Size = new System.Drawing.Size(59, 15);
            this.egresos_label.TabIndex = 12;
            this.egresos_label.Text = "Egresos";
            this.egresos_label.Click += new System.EventHandler(this.Submenus);
            // 
            // cancelar_pago_label
            // 
            this.cancelar_pago_label.AutoSize = true;
            this.cancelar_pago_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar_pago_label.ForeColor = System.Drawing.Color.Red;
            this.cancelar_pago_label.Location = new System.Drawing.Point(345, 5);
            this.cancelar_pago_label.Name = "cancelar_pago_label";
            this.cancelar_pago_label.Size = new System.Drawing.Size(101, 15);
            this.cancelar_pago_label.TabIndex = 13;
            this.cancelar_pago_label.Text = "Cancelar Pago";
            this.cancelar_pago_label.Click += new System.EventHandler(this.Submenus);
            // 
            // historial_pagos_label
            // 
            this.historial_pagos_label.AutoSize = true;
            this.historial_pagos_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historial_pagos_label.ForeColor = System.Drawing.Color.Red;
            this.historial_pagos_label.Location = new System.Drawing.Point(141, 5);
            this.historial_pagos_label.Name = "historial_pagos_label";
            this.historial_pagos_label.Size = new System.Drawing.Size(110, 15);
            this.historial_pagos_label.TabIndex = 11;
            this.historial_pagos_label.Text = "Historial Cobros";
            this.historial_pagos_label.Click += new System.EventHandler(this.Submenus);
            // 
            // cobrar_label
            // 
            this.cobrar_label.AutoSize = true;
            this.cobrar_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobrar_label.ForeColor = System.Drawing.Color.Red;
            this.cobrar_label.Location = new System.Drawing.Point(67, 5);
            this.cobrar_label.Name = "cobrar_label";
            this.cobrar_label.Size = new System.Drawing.Size(50, 15);
            this.cobrar_label.TabIndex = 10;
            this.cobrar_label.Text = "Cobrar";
            this.cobrar_label.Click += new System.EventHandler(this.Submenus);
            // 
            // submenu_reportes_panel
            // 
            this.submenu_reportes_panel.BackColor = System.Drawing.Color.White;
            this.submenu_reportes_panel.Controls.Add(this.Reporte_Balance_label);
            this.submenu_reportes_panel.Controls.Add(this.Reporte_Egresos_label);
            this.submenu_reportes_panel.Controls.Add(this.Clientes_Generales_label);
            this.submenu_reportes_panel.Controls.Add(this.clientes_sin_renovar);
            this.submenu_reportes_panel.Controls.Add(this.proyeccion_ingresos_label);
            this.submenu_reportes_panel.Controls.Add(this.acceso_no_vigentes_label);
            this.submenu_reportes_panel.Controls.Add(this.label2);
            this.submenu_reportes_panel.Controls.Add(this.corte_caja_label);
            this.submenu_reportes_panel.Location = new System.Drawing.Point(-5, 141);
            this.submenu_reportes_panel.Name = "submenu_reportes_panel";
            this.submenu_reportes_panel.Size = new System.Drawing.Size(810, 56);
            this.submenu_reportes_panel.TabIndex = 56;
            // 
            // Reporte_Balance_label
            // 
            this.Reporte_Balance_label.AutoSize = true;
            this.Reporte_Balance_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reporte_Balance_label.ForeColor = System.Drawing.Color.Red;
            this.Reporte_Balance_label.Location = new System.Drawing.Point(192, 28);
            this.Reporte_Balance_label.Name = "Reporte_Balance_label";
            this.Reporte_Balance_label.Size = new System.Drawing.Size(59, 15);
            this.Reporte_Balance_label.TabIndex = 73;
            this.Reporte_Balance_label.Text = "Balance";
            this.Reporte_Balance_label.Click += new System.EventHandler(this.Submenus);
            // 
            // Reporte_Egresos_label
            // 
            this.Reporte_Egresos_label.AutoSize = true;
            this.Reporte_Egresos_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reporte_Egresos_label.ForeColor = System.Drawing.Color.Red;
            this.Reporte_Egresos_label.Location = new System.Drawing.Point(95, 28);
            this.Reporte_Egresos_label.Name = "Reporte_Egresos_label";
            this.Reporte_Egresos_label.Size = new System.Drawing.Size(59, 15);
            this.Reporte_Egresos_label.TabIndex = 72;
            this.Reporte_Egresos_label.Text = "Egresos";
            this.Reporte_Egresos_label.Click += new System.EventHandler(this.Submenus);
            // 
            // Clientes_Generales_label
            // 
            this.Clientes_Generales_label.AutoSize = true;
            this.Clientes_Generales_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clientes_Generales_label.ForeColor = System.Drawing.Color.Red;
            this.Clientes_Generales_label.Location = new System.Drawing.Point(614, 5);
            this.Clientes_Generales_label.Name = "Clientes_Generales_label";
            this.Clientes_Generales_label.Size = new System.Drawing.Size(133, 15);
            this.Clientes_Generales_label.TabIndex = 71;
            this.Clientes_Generales_label.Text = " Clientes Generales";
            this.Clientes_Generales_label.Click += new System.EventHandler(this.Submenus);
            // 
            // clientes_sin_renovar
            // 
            this.clientes_sin_renovar.AutoSize = true;
            this.clientes_sin_renovar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientes_sin_renovar.ForeColor = System.Drawing.Color.Red;
            this.clientes_sin_renovar.Location = new System.Drawing.Point(465, 4);
            this.clientes_sin_renovar.Name = "clientes_sin_renovar";
            this.clientes_sin_renovar.Size = new System.Drawing.Size(143, 15);
            this.clientes_sin_renovar.TabIndex = 17;
            this.clientes_sin_renovar.Text = " Clientes sin Renovar";
            this.clientes_sin_renovar.Click += new System.EventHandler(this.Submenus);
            // 
            // proyeccion_ingresos_label
            // 
            this.proyeccion_ingresos_label.AutoSize = true;
            this.proyeccion_ingresos_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proyeccion_ingresos_label.ForeColor = System.Drawing.Color.Red;
            this.proyeccion_ingresos_label.Location = new System.Drawing.Point(302, 4);
            this.proyeccion_ingresos_label.Name = "proyeccion_ingresos_label";
            this.proyeccion_ingresos_label.Size = new System.Drawing.Size(156, 15);
            this.proyeccion_ingresos_label.TabIndex = 16;
            this.proyeccion_ingresos_label.Text = "Proyección de Ingresos";
            this.proyeccion_ingresos_label.Click += new System.EventHandler(this.Submenus);
            // 
            // acceso_no_vigentes_label
            // 
            this.acceso_no_vigentes_label.AutoSize = true;
            this.acceso_no_vigentes_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceso_no_vigentes_label.ForeColor = System.Drawing.Color.Red;
            this.acceso_no_vigentes_label.Location = new System.Drawing.Point(151, 4);
            this.acceso_no_vigentes_label.Name = "acceso_no_vigentes_label";
            this.acceso_no_vigentes_label.Size = new System.Drawing.Size(138, 15);
            this.acceso_no_vigentes_label.TabIndex = 15;
            this.acceso_no_vigentes_label.Text = "Accesos no Vigentes";
            this.acceso_no_vigentes_label.Click += new System.EventHandler(this.Submenus);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(143, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 70;
            // 
            // corte_caja_label
            // 
            this.corte_caja_label.AutoSize = true;
            this.corte_caja_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.corte_caja_label.ForeColor = System.Drawing.Color.Red;
            this.corte_caja_label.Location = new System.Drawing.Point(63, 4);
            this.corte_caja_label.Name = "corte_caja_label";
            this.corte_caja_label.Size = new System.Drawing.Size(74, 15);
            this.corte_caja_label.TabIndex = 14;
            this.corte_caja_label.Text = "Corte Caja";
            this.corte_caja_label.Click += new System.EventHandler(this.Submenus);
            // 
            // Catalogo_Button
            // 
            this.Catalogo_Button.BackColor = System.Drawing.Color.Transparent;
            this.Catalogo_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Catalogo_Button.BackgroundImage")));
            this.Catalogo_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Catalogo_Button.FlatAppearance.BorderSize = 0;
            this.Catalogo_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Catalogo_Button.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Catalogo_Button.Location = new System.Drawing.Point(269, 12);
            this.Catalogo_Button.Name = "Catalogo_Button";
            this.Catalogo_Button.Size = new System.Drawing.Size(121, 25);
            this.Catalogo_Button.TabIndex = 3;
            this.Catalogo_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Catalogo_Button.UseVisualStyleBackColor = false;
            this.Catalogo_Button.Click += new System.EventHandler(this.Catalogo_Button_Click);
            // 
            // usuarios_button
            // 
            this.usuarios_button.BackColor = System.Drawing.Color.Transparent;
            this.usuarios_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("usuarios_button.BackgroundImage")));
            this.usuarios_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.usuarios_button.FlatAppearance.BorderSize = 0;
            this.usuarios_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usuarios_button.Location = new System.Drawing.Point(700, 12);
            this.usuarios_button.Name = "usuarios_button";
            this.usuarios_button.Size = new System.Drawing.Size(86, 25);
            this.usuarios_button.TabIndex = 5;
            this.usuarios_button.UseVisualStyleBackColor = false;
            this.usuarios_button.Click += new System.EventHandler(this.usuarios_button_Click);
            // 
            // fondo_submenu_panel
            // 
            this.fondo_submenu_panel.BackColor = System.Drawing.Color.White;
            this.fondo_submenu_panel.Location = new System.Drawing.Point(-5, 47);
            this.fondo_submenu_panel.Name = "fondo_submenu_panel";
            this.fondo_submenu_panel.Size = new System.Drawing.Size(1033, 25);
            this.fondo_submenu_panel.TabIndex = 54;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(794, 594);
            this.ControlBox = false;
            this.Controls.Add(this.usuarios_button);
            this.Controls.Add(this.submenu_reportes_panel);
            this.Controls.Add(this.submenu_pagos_panel);
            this.Controls.Add(this.fondo_submenu_panel);
            this.Controls.Add(this.submenu_clientes_panel);
            this.Controls.Add(this.prueba_label);
            this.Controls.Add(this.registro_button);
            this.Controls.Add(this.Salir_Button);
            this.Controls.Add(this.Pagos_Button);
            this.Controls.Add(this.Reportes_Button);
            this.Controls.Add(this.Catalogo_Button);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.submenu_clientes_panel.ResumeLayout(false);
            this.submenu_clientes_panel.PerformLayout();
            this.submenu_pagos_panel.ResumeLayout(false);
            this.submenu_pagos_panel.PerformLayout();
            this.submenu_reportes_panel.ResumeLayout(false);
            this.submenu_reportes_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Reportes_Button;
        private System.Windows.Forms.Button Pagos_Button;
        private System.Windows.Forms.Button Salir_Button;
        private System.Windows.Forms.Button registro_button;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label prueba_label;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel submenu_clientes_panel;
        private System.Windows.Forms.Label nuevo_cliente_label;
        private System.Windows.Forms.Label buscar_cliente_label;
        private System.Windows.Forms.Panel submenu_pagos_panel;
        private System.Windows.Forms.Panel submenu_reportes_panel;
        private System.Windows.Forms.Label egresos_label;
        private System.Windows.Forms.Label cancelar_pago_label;
        private System.Windows.Forms.Label historial_pagos_label;
        private System.Windows.Forms.Label cobrar_label;
        private System.Windows.Forms.Label clientes_sin_renovar;
        private System.Windows.Forms.Label proyeccion_ingresos_label;
        private System.Windows.Forms.Label acceso_no_vigentes_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label corte_caja_label;
        private System.Windows.Forms.Button Catalogo_Button;
        private System.Windows.Forms.Button usuarios_button;
        private System.Windows.Forms.Panel fondo_submenu_panel;
        private System.Windows.Forms.Label correos_label;
        private System.Windows.Forms.Label Clientes_Generales_label;
        private System.Windows.Forms.Label Reporte_Egresos_label;
        private System.Windows.Forms.Label Reporte_Balance_label;
    }
}