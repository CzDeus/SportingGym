namespace Sporting_Gym.Forms
{
    partial class Historial_Pagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historial_Pagos));
            this.clientes_dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cerrar_button = new System.Windows.Forms.Button();
            this.nombre_textBox = new System.Windows.Forms.TextBox();
            this.buscar_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.historial_dataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.clientes_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historial_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // clientes_dataGridView
            // 
            this.clientes_dataGridView.AllowUserToDeleteRows = false;
            this.clientes_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clientes_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientes_dataGridView.Location = new System.Drawing.Point(12, 122);
            this.clientes_dataGridView.Name = "clientes_dataGridView";
            this.clientes_dataGridView.Size = new System.Drawing.Size(322, 208);
            this.clientes_dataGridView.TabIndex = 3;
            this.clientes_dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientes_dataGridView_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "HISTORIAL DE PAGOS";
            // 
            // cerrar_button
            // 
            this.cerrar_button.ForeColor = System.Drawing.Color.Red;
            this.cerrar_button.Location = new System.Drawing.Point(607, 336);
            this.cerrar_button.Name = "cerrar_button";
            this.cerrar_button.Size = new System.Drawing.Size(67, 23);
            this.cerrar_button.TabIndex = 5;
            this.cerrar_button.Text = "Cerrar";
            this.cerrar_button.UseVisualStyleBackColor = true;
            this.cerrar_button.Click += new System.EventHandler(this.cerrar_button_Click);
            // 
            // nombre_textBox
            // 
            this.nombre_textBox.Location = new System.Drawing.Point(232, 68);
            this.nombre_textBox.Name = "nombre_textBox";
            this.nombre_textBox.Size = new System.Drawing.Size(154, 20);
            this.nombre_textBox.TabIndex = 1;
            this.nombre_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nombre_textBox_KeyDown);
            // 
            // buscar_button
            // 
            this.buscar_button.Location = new System.Drawing.Point(403, 66);
            this.buscar_button.Name = "buscar_button";
            this.buscar_button.Size = new System.Drawing.Size(75, 23);
            this.buscar_button.TabIndex = 2;
            this.buscar_button.Text = "Buscar";
            this.buscar_button.UseVisualStyleBackColor = true;
            this.buscar_button.Click += new System.EventHandler(this.buscar_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre Cliente:";
            // 
            // historial_dataGridView
            // 
            this.historial_dataGridView.AllowUserToDeleteRows = false;
            this.historial_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.historial_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historial_dataGridView.Location = new System.Drawing.Point(352, 122);
            this.historial_dataGridView.Name = "historial_dataGridView";
            this.historial_dataGridView.Size = new System.Drawing.Size(322, 208);
            this.historial_dataGridView.TabIndex = 4;
            this.historial_dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.historial_dataGridView_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(142, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "CLIENTES ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(481, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "HISTORIAL";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(6, 9);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(113, 40);
            this.pictureBox4.TabIndex = 40;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.Location = new System.Drawing.Point(-4, -3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(689, 60);
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // Historial_Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(684, 365);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.historial_dataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buscar_button);
            this.Controls.Add(this.nombre_textBox);
            this.Controls.Add(this.cerrar_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clientes_dataGridView);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Historial_Pagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.Historial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientes_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historial_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView clientes_dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cerrar_button;
        private System.Windows.Forms.TextBox nombre_textBox;
        private System.Windows.Forms.Button buscar_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView historial_dataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}