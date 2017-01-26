namespace Sporting_Gym.Forms
{
    partial class Nuevo_Grupo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nuevo_Grupo));
            this.label1 = new System.Windows.Forms.Label();
            this.nombre_grupo_textBox = new System.Windows.Forms.TextBox();
            this.crear_grupo_button = new System.Windows.Forms.Button();
            this.cancelar_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.eliminar_button = new System.Windows.Forms.Button();
            this.responsable_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Clientes_Grupos_groupBox = new System.Windows.Forms.GroupBox();
            this.Clientes_Grupos_dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ape_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nombre_textBox = new System.Windows.Forms.TextBox();
            this.cargar_clientes_button = new System.Windows.Forms.Button();
            this.clientes_dataGridView = new System.Windows.Forms.DataGridView();
            this.responsable_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Clientes_Grupos_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Clientes_Grupos_dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientes_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Grupo:";
            // 
            // nombre_grupo_textBox
            // 
            this.nombre_grupo_textBox.Location = new System.Drawing.Point(86, 72);
            this.nombre_grupo_textBox.Name = "nombre_grupo_textBox";
            this.nombre_grupo_textBox.Size = new System.Drawing.Size(154, 20);
            this.nombre_grupo_textBox.TabIndex = 1;
            this.nombre_grupo_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // crear_grupo_button
            // 
            this.crear_grupo_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.crear_grupo_button.Location = new System.Drawing.Point(238, 340);
            this.crear_grupo_button.Name = "crear_grupo_button";
            this.crear_grupo_button.Size = new System.Drawing.Size(75, 25);
            this.crear_grupo_button.TabIndex = 7;
            this.crear_grupo_button.Text = "Guardar";
            this.crear_grupo_button.UseVisualStyleBackColor = true;
            this.crear_grupo_button.Click += new System.EventHandler(this.crear_grupo_button_Click);
            // 
            // cancelar_button
            // 
            this.cancelar_button.ForeColor = System.Drawing.Color.Black;
            this.cancelar_button.Location = new System.Drawing.Point(573, 341);
            this.cancelar_button.Name = "cancelar_button";
            this.cancelar_button.Size = new System.Drawing.Size(75, 25);
            this.cancelar_button.TabIndex = 9;
            this.cancelar_button.Text = "Salir";
            this.cancelar_button.UseVisualStyleBackColor = true;
            this.cancelar_button.Click += new System.EventHandler(this.cancelar_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(256, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "CREAR GRUPO";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(7, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(115, 42);
            this.pictureBox4.TabIndex = 43;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.Location = new System.Drawing.Point(-4, -8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(690, 61);
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // eliminar_button
            // 
            this.eliminar_button.ForeColor = System.Drawing.Color.Red;
            this.eliminar_button.Location = new System.Drawing.Point(319, 340);
            this.eliminar_button.Name = "eliminar_button";
            this.eliminar_button.Size = new System.Drawing.Size(75, 25);
            this.eliminar_button.TabIndex = 8;
            this.eliminar_button.Text = "Eliminar";
            this.eliminar_button.UseVisualStyleBackColor = true;
            this.eliminar_button.Click += new System.EventHandler(this.eliminar_button_Click);
            // 
            // responsable_textBox
            // 
            this.responsable_textBox.Location = new System.Drawing.Point(420, 72);
            this.responsable_textBox.Name = "responsable_textBox";
            this.responsable_textBox.ReadOnly = true;
            this.responsable_textBox.Size = new System.Drawing.Size(167, 20);
            this.responsable_textBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(463, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Responsable:";
            // 
            // Clientes_Grupos_groupBox
            // 
            this.Clientes_Grupos_groupBox.Controls.Add(this.Clientes_Grupos_dataGridView);
            this.Clientes_Grupos_groupBox.Location = new System.Drawing.Point(7, 97);
            this.Clientes_Grupos_groupBox.Name = "Clientes_Grupos_groupBox";
            this.Clientes_Grupos_groupBox.Size = new System.Drawing.Size(301, 238);
            this.Clientes_Grupos_groupBox.TabIndex = 51;
            this.Clientes_Grupos_groupBox.TabStop = false;
            this.Clientes_Grupos_groupBox.Text = "Clientes Grupos";
            // 
            // Clientes_Grupos_dataGridView
            // 
            this.Clientes_Grupos_dataGridView.AllowUserToAddRows = false;
            this.Clientes_Grupos_dataGridView.AllowUserToDeleteRows = false;
            this.Clientes_Grupos_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Clientes_Grupos_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Clientes_Grupos_dataGridView.Location = new System.Drawing.Point(6, 19);
            this.Clientes_Grupos_dataGridView.Name = "Clientes_Grupos_dataGridView";
            this.Clientes_Grupos_dataGridView.ReadOnly = true;
            this.Clientes_Grupos_dataGridView.Size = new System.Drawing.Size(289, 197);
            this.Clientes_Grupos_dataGridView.TabIndex = 2;
            this.Clientes_Grupos_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Clientes_Grupos_dataGridView_CellClick);
            this.Clientes_Grupos_dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Clientes_Grupos_dataGridView_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ape_textBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nombre_textBox);
            this.groupBox1.Controls.Add(this.cargar_clientes_button);
            this.groupBox1.Controls.Add(this.clientes_dataGridView);
            this.groupBox1.Location = new System.Drawing.Point(323, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 238);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clientes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Apellido:";
            // 
            // ape_textBox
            // 
            this.ape_textBox.Location = new System.Drawing.Point(207, 15);
            this.ape_textBox.Name = "ape_textBox";
            this.ape_textBox.Size = new System.Drawing.Size(91, 20);
            this.ape_textBox.TabIndex = 56;
            this.ape_textBox.TextChanged += new System.EventHandler(this.nombre_textBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Nombre:";
            // 
            // nombre_textBox
            // 
            this.nombre_textBox.Location = new System.Drawing.Point(58, 15);
            this.nombre_textBox.Name = "nombre_textBox";
            this.nombre_textBox.Size = new System.Drawing.Size(90, 20);
            this.nombre_textBox.TabIndex = 3;
            this.nombre_textBox.TextChanged += new System.EventHandler(this.nombre_textBox_TextChanged);
            // 
            // cargar_clientes_button
            // 
            this.cargar_clientes_button.BackColor = System.Drawing.Color.Transparent;
            this.cargar_clientes_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cargar_clientes_button.BackgroundImage")));
            this.cargar_clientes_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cargar_clientes_button.FlatAppearance.BorderSize = 0;
            this.cargar_clientes_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cargar_clientes_button.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.cargar_clientes_button.Location = new System.Drawing.Point(310, 14);
            this.cargar_clientes_button.Name = "cargar_clientes_button";
            this.cargar_clientes_button.Size = new System.Drawing.Size(27, 22);
            this.cargar_clientes_button.TabIndex = 4;
            this.cargar_clientes_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cargar_clientes_button.UseVisualStyleBackColor = false;
            this.cargar_clientes_button.Click += new System.EventHandler(this.cargar_clientes_button_Click);
            // 
            // clientes_dataGridView
            // 
            this.clientes_dataGridView.AllowUserToAddRows = false;
            this.clientes_dataGridView.AllowUserToDeleteRows = false;
            this.clientes_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clientes_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientes_dataGridView.Location = new System.Drawing.Point(6, 41);
            this.clientes_dataGridView.Name = "clientes_dataGridView";
            this.clientes_dataGridView.ReadOnly = true;
            this.clientes_dataGridView.Size = new System.Drawing.Size(331, 175);
            this.clientes_dataGridView.TabIndex = 5;
            this.clientes_dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientes_dataGridView_CellDoubleClick);
            // 
            // responsable_button
            // 
            this.responsable_button.Location = new System.Drawing.Point(25, 341);
            this.responsable_button.Name = "responsable_button";
            this.responsable_button.Size = new System.Drawing.Size(79, 23);
            this.responsable_button.TabIndex = 6;
            this.responsable_button.Text = "Responsable";
            this.responsable_button.UseVisualStyleBackColor = true;
            this.responsable_button.Click += new System.EventHandler(this.responsable_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(59, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "*Doble clic para agregar/quitar cliente al grupo";
            // 
            // Nuevo_Grupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(679, 370);
            this.ControlBox = false;
            this.Controls.Add(this.responsable_button);
            this.Controls.Add(this.responsable_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Clientes_Grupos_groupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.eliminar_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cancelar_button);
            this.Controls.Add(this.crear_grupo_button);
            this.Controls.Add(this.nombre_grupo_textBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Nuevo_Grupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.Nuevo_Grupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Clientes_Grupos_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Clientes_Grupos_dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientes_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombre_grupo_textBox;
        private System.Windows.Forms.Button crear_grupo_button;
        private System.Windows.Forms.Button cancelar_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button eliminar_button;
        private System.Windows.Forms.TextBox responsable_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Clientes_Grupos_groupBox;
        private System.Windows.Forms.DataGridView Clientes_Grupos_dataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView clientes_dataGridView;
        private System.Windows.Forms.Button responsable_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nombre_textBox;
        private System.Windows.Forms.Button cargar_clientes_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ape_textBox;
        private System.Windows.Forms.Label label6;
    }
}