namespace Sporting_Gym.Forms
{
    partial class Actualizar_Costos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actualizar_Costos));
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.costos_tipos_periodos_dataGridView = new System.Windows.Forms.DataGridView();
            this.nombre_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tipo_cliente_comboBox = new System.Windows.Forms.ComboBox();
            this.volver_button = new System.Windows.Forms.Button();
            this.costo_textBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costos_tipos_periodos_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(10, 9);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(115, 40);
            this.pictureBox4.TabIndex = 34;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.Location = new System.Drawing.Point(-3, -3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(477, 62);
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // costos_tipos_periodos_dataGridView
            // 
            this.costos_tipos_periodos_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.costos_tipos_periodos_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.costos_tipos_periodos_dataGridView.Location = new System.Drawing.Point(10, 94);
            this.costos_tipos_periodos_dataGridView.Name = "costos_tipos_periodos_dataGridView";
            this.costos_tipos_periodos_dataGridView.Size = new System.Drawing.Size(444, 195);
            this.costos_tipos_periodos_dataGridView.TabIndex = 2;
            this.costos_tipos_periodos_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.costos_tipos_periodos_dataGridView_CellClick);
            this.costos_tipos_periodos_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.costos_tipos_periodos_dataGridView_CellClick);
            this.costos_tipos_periodos_dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.costos_tipos_periodos_dataGridView_CellDoubleClick);
            this.costos_tipos_periodos_dataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.costos_tipos_periodos_dataGridView_CellValidating);
            // 
            // nombre_label
            // 
            this.nombre_label.AutoSize = true;
            this.nombre_label.Location = new System.Drawing.Point(16, 72);
            this.nombre_label.Name = "nombre_label";
            this.nombre_label.Size = new System.Drawing.Size(65, 13);
            this.nombre_label.TabIndex = 39;
            this.nombre_label.Text = "Tipo cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "COSTOS";
            // 
            // tipo_cliente_comboBox
            // 
            this.tipo_cliente_comboBox.FormattingEnabled = true;
            this.tipo_cliente_comboBox.Location = new System.Drawing.Point(87, 68);
            this.tipo_cliente_comboBox.Name = "tipo_cliente_comboBox";
            this.tipo_cliente_comboBox.Size = new System.Drawing.Size(121, 21);
            this.tipo_cliente_comboBox.TabIndex = 0;
            this.tipo_cliente_comboBox.SelectedIndexChanged += new System.EventHandler(this.Cambiar_Valores_Gridview);
            // 
            // volver_button
            // 
            this.volver_button.ForeColor = System.Drawing.Color.DarkGreen;
            this.volver_button.Location = new System.Drawing.Point(379, 295);
            this.volver_button.Name = "volver_button";
            this.volver_button.Size = new System.Drawing.Size(75, 23);
            this.volver_button.TabIndex = 3;
            this.volver_button.Text = "Volver";
            this.volver_button.UseVisualStyleBackColor = true;
            this.volver_button.Click += new System.EventHandler(this.volver_button_Click);
            // 
            // costo_textBox
            // 
            this.costo_textBox.Location = new System.Drawing.Point(346, 68);
            this.costo_textBox.MaxLength = 5;
            this.costo_textBox.Name = "costo_textBox";
            this.costo_textBox.Size = new System.Drawing.Size(100, 20);
            this.costo_textBox.TabIndex = 1;
            this.costo_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.costo_textBox_KeyPress);
            this.costo_textBox.Leave += new System.EventHandler(this.costo_textBox_Leave);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(262, 72);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(78, 13);
            this.label.TabIndex = 45;
            this.label.Text = "Cambiar Costo:";
            // 
            // Actualizar_Costos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(464, 323);
            this.ControlBox = false;
            this.Controls.Add(this.label);
            this.Controls.Add(this.costo_textBox);
            this.Controls.Add(this.volver_button);
            this.Controls.Add(this.tipo_cliente_comboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombre_label);
            this.Controls.Add(this.costos_tipos_periodos_dataGridView);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Actualizar_Costos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.Actualizar_Costos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costos_tipos_periodos_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView costos_tipos_periodos_dataGridView;
        private System.Windows.Forms.Label nombre_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox tipo_cliente_comboBox;
        private System.Windows.Forms.Button volver_button;
        private System.Windows.Forms.TextBox costo_textBox;
        private System.Windows.Forms.Label label;
    }
}