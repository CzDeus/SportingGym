namespace Sporting_Gym.Forms
{
    partial class Cancelar_Pago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cancelar_Pago));
            this.pagos_dataGridView = new System.Windows.Forms.DataGridView();
            this.cancelar_button = new System.Windows.Forms.Button();
            this.justificacion_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.salir_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pagos_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pagos_dataGridView
            // 
            this.pagos_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pagos_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pagos_dataGridView.Location = new System.Drawing.Point(12, 75);
            this.pagos_dataGridView.Name = "pagos_dataGridView";
            this.pagos_dataGridView.Size = new System.Drawing.Size(485, 130);
            this.pagos_dataGridView.TabIndex = 0;
            this.pagos_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pagos_dataGridView_CellClick);
            this.pagos_dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pagos_dataGridView_CellDoubleClick);
            // 
            // cancelar_button
            // 
            this.cancelar_button.Location = new System.Drawing.Point(185, 386);
            this.cancelar_button.Name = "cancelar_button";
            this.cancelar_button.Size = new System.Drawing.Size(107, 23);
            this.cancelar_button.TabIndex = 2;
            this.cancelar_button.Text = "Cancelar Pago";
            this.cancelar_button.UseVisualStyleBackColor = true;
            this.cancelar_button.Click += new System.EventHandler(this.cancelar_button_Click);
            // 
            // justificacion_textBox
            // 
            this.justificacion_textBox.Location = new System.Drawing.Point(80, 231);
            this.justificacion_textBox.Multiline = true;
            this.justificacion_textBox.Name = "justificacion_textBox";
            this.justificacion_textBox.Size = new System.Drawing.Size(356, 149);
            this.justificacion_textBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Justificación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pagos Realizados";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(9, 7);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(110, 40);
            this.pictureBox4.TabIndex = 52;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.ImageLocation = "";
            this.pictureBox3.Location = new System.Drawing.Point(-2, -6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(518, 60);
            this.pictureBox3.TabIndex = 53;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(181, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 20);
            this.label3.TabIndex = 54;
            this.label3.Text = "Cancelación de Pagos";
            // 
            // salir_button
            // 
            this.salir_button.ForeColor = System.Drawing.Color.Red;
            this.salir_button.Location = new System.Drawing.Point(422, 386);
            this.salir_button.Name = "salir_button";
            this.salir_button.Size = new System.Drawing.Size(75, 23);
            this.salir_button.TabIndex = 3;
            this.salir_button.Text = "Salir";
            this.salir_button.UseVisualStyleBackColor = true;
            this.salir_button.Click += new System.EventHandler(this.salir_button_Click);
            // 
            // Cancelar_Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(509, 415);
            this.ControlBox = false;
            this.Controls.Add(this.salir_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.justificacion_textBox);
            this.Controls.Add(this.cancelar_button);
            this.Controls.Add(this.pagos_dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Cancelar_Pago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.Cancelar_Pago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pagos_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView pagos_dataGridView;
        private System.Windows.Forms.Button cancelar_button;
        private System.Windows.Forms.TextBox justificacion_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button salir_button;
    }
}