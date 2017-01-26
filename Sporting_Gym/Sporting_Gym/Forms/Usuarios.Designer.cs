namespace Sporting_Gym.Forms
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.Agregar_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nombre_textBox = new System.Windows.Forms.TextBox();
            this.nom_usuario_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.correo_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.treeView = new System.Windows.Forms.TreeView();
            this.usuarios_comboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.eliminar_button = new System.Windows.Forms.Button();
            this.Ver_checkBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.editar_button = new System.Windows.Forms.Button();
            this.cancelar_button = new System.Windows.Forms.Button();
            this.guardar_button = new System.Windows.Forms.Button();
            this.salir_button = new System.Windows.Forms.Button();
            this.Activo_radioButton = new System.Windows.Forms.RadioButton();
            this.Inactivo_radioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Agregar_button
            // 
            this.Agregar_button.Location = new System.Drawing.Point(25, 351);
            this.Agregar_button.Name = "Agregar_button";
            this.Agregar_button.Size = new System.Drawing.Size(75, 23);
            this.Agregar_button.TabIndex = 6;
            this.Agregar_button.Text = "Nuevo";
            this.Agregar_button.UseVisualStyleBackColor = true;
            this.Agregar_button.Click += new System.EventHandler(this.Agregar_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // nombre_textBox
            // 
            this.nombre_textBox.Location = new System.Drawing.Point(25, 104);
            this.nombre_textBox.Name = "nombre_textBox";
            this.nombre_textBox.ReadOnly = true;
            this.nombre_textBox.Size = new System.Drawing.Size(156, 20);
            this.nombre_textBox.TabIndex = 2;
            // 
            // nom_usuario_textBox
            // 
            this.nom_usuario_textBox.Location = new System.Drawing.Point(25, 206);
            this.nom_usuario_textBox.Name = "nom_usuario_textBox";
            this.nom_usuario_textBox.ReadOnly = true;
            this.nom_usuario_textBox.Size = new System.Drawing.Size(156, 20);
            this.nom_usuario_textBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre Usuario:";
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(25, 257);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.PasswordChar = '*';
            this.password_textBox.ReadOnly = true;
            this.password_textBox.Size = new System.Drawing.Size(135, 20);
            this.password_textBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password:";
            // 
            // correo_textBox
            // 
            this.correo_textBox.Location = new System.Drawing.Point(25, 155);
            this.correo_textBox.Name = "correo_textBox";
            this.correo_textBox.ReadOnly = true;
            this.correo_textBox.Size = new System.Drawing.Size(156, 20);
            this.correo_textBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Correo:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(6, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(97, 39);
            this.pictureBox4.TabIndex = 47;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(579, 47);
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            // 
            // treeView
            // 
            this.treeView.CheckBoxes = true;
            this.treeView.Enabled = false;
            this.treeView.Location = new System.Drawing.Point(222, 82);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(323, 255);
            this.treeView.TabIndex = 11;
            // 
            // usuarios_comboBox
            // 
            this.usuarios_comboBox.FormattingEnabled = true;
            this.usuarios_comboBox.Location = new System.Drawing.Point(263, 55);
            this.usuarios_comboBox.Name = "usuarios_comboBox";
            this.usuarios_comboBox.Size = new System.Drawing.Size(150, 21);
            this.usuarios_comboBox.TabIndex = 1;
            this.usuarios_comboBox.SelectedIndexChanged += new System.EventHandler(this.usuarios_comboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Seleccione Usuarios:";
            // 
            // eliminar_button
            // 
            this.eliminar_button.BackColor = System.Drawing.Color.Red;
            this.eliminar_button.Location = new System.Drawing.Point(470, 351);
            this.eliminar_button.Name = "eliminar_button";
            this.eliminar_button.Size = new System.Drawing.Size(75, 23);
            this.eliminar_button.TabIndex = 9;
            this.eliminar_button.Text = "Eliminar";
            this.eliminar_button.UseVisualStyleBackColor = false;
            this.eliminar_button.Click += new System.EventHandler(this.eliminar_button_Click);
            // 
            // Ver_checkBox
            // 
            this.Ver_checkBox.AutoSize = true;
            this.Ver_checkBox.Enabled = false;
            this.Ver_checkBox.Location = new System.Drawing.Point(166, 260);
            this.Ver_checkBox.Name = "Ver_checkBox";
            this.Ver_checkBox.Size = new System.Drawing.Size(15, 14);
            this.Ver_checkBox.TabIndex = 52;
            this.Ver_checkBox.UseVisualStyleBackColor = true;
            this.Ver_checkBox.CheckedChanged += new System.EventHandler(this.Ver_checkBox_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(247, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 53;
            this.label6.Text = "USUARIOS";
            // 
            // editar_button
            // 
            this.editar_button.Location = new System.Drawing.Point(106, 351);
            this.editar_button.Name = "editar_button";
            this.editar_button.Size = new System.Drawing.Size(75, 23);
            this.editar_button.TabIndex = 7;
            this.editar_button.Text = "Editar";
            this.editar_button.UseVisualStyleBackColor = true;
            this.editar_button.Click += new System.EventHandler(this.editar_button_Click);
            // 
            // cancelar_button
            // 
            this.cancelar_button.Location = new System.Drawing.Point(338, 351);
            this.cancelar_button.Name = "cancelar_button";
            this.cancelar_button.Size = new System.Drawing.Size(75, 23);
            this.cancelar_button.TabIndex = 8;
            this.cancelar_button.Text = "Cancelar";
            this.cancelar_button.UseVisualStyleBackColor = true;
            this.cancelar_button.Visible = false;
            this.cancelar_button.Click += new System.EventHandler(this.cancelar_button_Click);
            // 
            // guardar_button
            // 
            this.guardar_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.guardar_button.Location = new System.Drawing.Point(257, 351);
            this.guardar_button.Name = "guardar_button";
            this.guardar_button.Size = new System.Drawing.Size(75, 23);
            this.guardar_button.TabIndex = 8;
            this.guardar_button.Text = "Guardar";
            this.guardar_button.UseVisualStyleBackColor = true;
            this.guardar_button.Visible = false;
            this.guardar_button.Click += new System.EventHandler(this.guardar_button_Click);
            // 
            // salir_button
            // 
            this.salir_button.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.salir_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("salir_button.BackgroundImage")));
            this.salir_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.salir_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.salir_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir_button.Location = new System.Drawing.Point(523, 51);
            this.salir_button.Name = "salir_button";
            this.salir_button.Size = new System.Drawing.Size(22, 21);
            this.salir_button.TabIndex = 10;
            this.salir_button.UseVisualStyleBackColor = false;
            this.salir_button.Click += new System.EventHandler(this.salir_button_Click);
            // 
            // Activo_radioButton
            // 
            this.Activo_radioButton.AutoSize = true;
            this.Activo_radioButton.Location = new System.Drawing.Point(14, 19);
            this.Activo_radioButton.Name = "Activo_radioButton";
            this.Activo_radioButton.Size = new System.Drawing.Size(55, 17);
            this.Activo_radioButton.TabIndex = 54;
            this.Activo_radioButton.TabStop = true;
            this.Activo_radioButton.Text = "Activo";
            this.Activo_radioButton.UseVisualStyleBackColor = true;
            // 
            // Inactivo_radioButton
            // 
            this.Inactivo_radioButton.AutoSize = true;
            this.Inactivo_radioButton.Location = new System.Drawing.Point(85, 19);
            this.Inactivo_radioButton.Name = "Inactivo_radioButton";
            this.Inactivo_radioButton.Size = new System.Drawing.Size(63, 17);
            this.Inactivo_radioButton.TabIndex = 55;
            this.Inactivo_radioButton.TabStop = true;
            this.Inactivo_radioButton.Text = "Inactivo";
            this.Inactivo_radioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Inactivo_radioButton);
            this.groupBox1.Controls.Add(this.Activo_radioButton);
            this.groupBox1.Location = new System.Drawing.Point(25, 289);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 48);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estatus";
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(557, 386);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.salir_button);
            this.Controls.Add(this.guardar_button);
            this.Controls.Add(this.cancelar_button);
            this.Controls.Add(this.editar_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Ver_checkBox);
            this.Controls.Add(this.eliminar_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.usuarios_comboBox);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.correo_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nom_usuario_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombre_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Agregar_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Agregar_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombre_textBox;
        private System.Windows.Forms.TextBox nom_usuario_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox correo_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ComboBox usuarios_comboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button eliminar_button;
        private System.Windows.Forms.CheckBox Ver_checkBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button editar_button;
        private System.Windows.Forms.Button cancelar_button;
        private System.Windows.Forms.Button guardar_button;
        private System.Windows.Forms.Button salir_button;
        private System.Windows.Forms.RadioButton Activo_radioButton;
        private System.Windows.Forms.RadioButton Inactivo_radioButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}