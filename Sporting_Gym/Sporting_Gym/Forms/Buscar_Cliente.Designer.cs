namespace Sporting_Gym.Forms
{
    partial class Buscar_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buscar_Cliente));
            this.titulo_label = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Clientes_dataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.buscar_cliente_button = new System.Windows.Forms.Button();
            this.nombre_cliente_buscar_textBox = new System.Windows.Forms.TextBox();
            this.cargar_clientes_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Clientes_dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titulo_label
            // 
            this.titulo_label.AutoSize = true;
            this.titulo_label.BackColor = System.Drawing.Color.Transparent;
            this.titulo_label.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.titulo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_label.ForeColor = System.Drawing.Color.Black;
            this.titulo_label.Location = new System.Drawing.Point(276, 22);
            this.titulo_label.Name = "titulo_label";
            this.titulo_label.Size = new System.Drawing.Size(162, 20);
            this.titulo_label.TabIndex = 7;
            this.titulo_label.Text = "BUSCAR CLIENTE";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(12, 8);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(111, 40);
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.Location = new System.Drawing.Point(-1, -8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(638, 66);
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(547, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Clientes_dataGridView
            // 
            this.Clientes_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Clientes_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Clientes_dataGridView.Location = new System.Drawing.Point(6, 51);
            this.Clientes_dataGridView.Name = "Clientes_dataGridView";
            this.Clientes_dataGridView.Size = new System.Drawing.Size(593, 249);
            this.Clientes_dataGridView.TabIndex = 0;
            this.Clientes_dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Clientes_dataGridView_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // buscar_cliente_button
            // 
            this.buscar_cliente_button.Location = new System.Drawing.Point(456, 22);
            this.buscar_cliente_button.Name = "buscar_cliente_button";
            this.buscar_cliente_button.Size = new System.Drawing.Size(75, 23);
            this.buscar_cliente_button.TabIndex = 3;
            this.buscar_cliente_button.Text = "Buscar";
            this.buscar_cliente_button.UseVisualStyleBackColor = true;
            this.buscar_cliente_button.Click += new System.EventHandler(this.buscar_cliente_button_Click);
            // 
            // nombre_cliente_buscar_textBox
            // 
            this.nombre_cliente_buscar_textBox.Location = new System.Drawing.Point(166, 23);
            this.nombre_cliente_buscar_textBox.Name = "nombre_cliente_buscar_textBox";
            this.nombre_cliente_buscar_textBox.Size = new System.Drawing.Size(183, 20);
            this.nombre_cliente_buscar_textBox.TabIndex = 1;
            this.nombre_cliente_buscar_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nombre_cliente_buscar_textBox_KeyDown);
            // 
            // cargar_clientes_button
            // 
            this.cargar_clientes_button.BackColor = System.Drawing.Color.Transparent;
            this.cargar_clientes_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cargar_clientes_button.BackgroundImage")));
            this.cargar_clientes_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cargar_clientes_button.FlatAppearance.BorderSize = 0;
            this.cargar_clientes_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cargar_clientes_button.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.cargar_clientes_button.Location = new System.Drawing.Point(540, 22);
            this.cargar_clientes_button.Name = "cargar_clientes_button";
            this.cargar_clientes_button.Size = new System.Drawing.Size(27, 22);
            this.cargar_clientes_button.TabIndex = 4;
            this.cargar_clientes_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cargar_clientes_button.UseVisualStyleBackColor = false;
            this.cargar_clientes_button.Click += new System.EventHandler(this.cargar_clientes_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cargar_clientes_button);
            this.groupBox1.Controls.Add(this.nombre_cliente_buscar_textBox);
            this.groupBox1.Controls.Add(this.buscar_cliente_button);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Clientes_dataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 306);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listados de clientes:";
            // 
            // Buscar_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(633, 420);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.titulo_label);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Buscar_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.Buscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Clientes_dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titulo_label;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Clientes_dataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buscar_cliente_button;
        private System.Windows.Forms.TextBox nombre_cliente_buscar_textBox;
        private System.Windows.Forms.Button cargar_clientes_button;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}