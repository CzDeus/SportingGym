namespace Sporting_Gym.Forms
{
    partial class Egresos_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Egresos_Principal));
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Egresos_dataGridView = new System.Windows.Forms.DataGridView();
            this.Eliminar_button = new System.Windows.Forms.Button();
            this.Nuevo_Egreso_button = new System.Windows.Forms.Button();
            this.Salir_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Egresos_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(167, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Egresos";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(4, 7);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(87, 32);
            this.pictureBox4.TabIndex = 38;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.Location = new System.Drawing.Point(-4, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(382, 50);
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // Egresos_dataGridView
            // 
            this.Egresos_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Egresos_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Egresos_dataGridView.Location = new System.Drawing.Point(12, 54);
            this.Egresos_dataGridView.Name = "Egresos_dataGridView";
            this.Egresos_dataGridView.Size = new System.Drawing.Size(349, 150);
            this.Egresos_dataGridView.TabIndex = 40;
            this.Egresos_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Egresos_dataGridView_CellClick);
            // 
            // Eliminar_button
            // 
            this.Eliminar_button.ForeColor = System.Drawing.Color.Red;
            this.Eliminar_button.Location = new System.Drawing.Point(12, 210);
            this.Eliminar_button.Name = "Eliminar_button";
            this.Eliminar_button.Size = new System.Drawing.Size(75, 23);
            this.Eliminar_button.TabIndex = 41;
            this.Eliminar_button.Text = "Eliminar";
            this.Eliminar_button.UseVisualStyleBackColor = true;
            this.Eliminar_button.Click += new System.EventHandler(this.Eliminar_button_Click);
            // 
            // Nuevo_Egreso_button
            // 
            this.Nuevo_Egreso_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Nuevo_Egreso_button.Location = new System.Drawing.Point(143, 210);
            this.Nuevo_Egreso_button.Name = "Nuevo_Egreso_button";
            this.Nuevo_Egreso_button.Size = new System.Drawing.Size(89, 23);
            this.Nuevo_Egreso_button.TabIndex = 42;
            this.Nuevo_Egreso_button.Text = "Nuevo Egreso";
            this.Nuevo_Egreso_button.UseVisualStyleBackColor = true;
            this.Nuevo_Egreso_button.Click += new System.EventHandler(this.Nuevo_Egreso_button_Click);
            // 
            // Salir_button
            // 
            this.Salir_button.Location = new System.Drawing.Point(286, 210);
            this.Salir_button.Name = "Salir_button";
            this.Salir_button.Size = new System.Drawing.Size(75, 23);
            this.Salir_button.TabIndex = 43;
            this.Salir_button.Text = "Salir";
            this.Salir_button.UseVisualStyleBackColor = true;
            this.Salir_button.Click += new System.EventHandler(this.Salir_button_Click);
            // 
            // Egresos_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(373, 237);
            this.ControlBox = false;
            this.Controls.Add(this.Salir_button);
            this.Controls.Add(this.Nuevo_Egreso_button);
            this.Controls.Add(this.Eliminar_button);
            this.Controls.Add(this.Egresos_dataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Egresos_Principal";
            this.Load += new System.EventHandler(this.Egresos_Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Egresos_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView Egresos_dataGridView;
        private System.Windows.Forms.Button Eliminar_button;
        private System.Windows.Forms.Button Nuevo_Egreso_button;
        private System.Windows.Forms.Button Salir_button;
    }
}