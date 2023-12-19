namespace ArquitecturaPresentacion
{
    partial class Form_Facultad
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
            this.textBox_IdFacultad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Eliminar = new System.Windows.Forms.Button();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.textBox_Facultad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView_Facultades = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Facultades)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_IdFacultad
            // 
            this.textBox_IdFacultad.Location = new System.Drawing.Point(200, 68);
            this.textBox_IdFacultad.Multiline = true;
            this.textBox_IdFacultad.Name = "textBox_IdFacultad";
            this.textBox_IdFacultad.Size = new System.Drawing.Size(176, 25);
            this.textBox_IdFacultad.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Id";
            // 
            // button_Eliminar
            // 
            this.button_Eliminar.Location = new System.Drawing.Point(218, 313);
            this.button_Eliminar.Name = "button_Eliminar";
            this.button_Eliminar.Size = new System.Drawing.Size(121, 60);
            this.button_Eliminar.TabIndex = 22;
            this.button_Eliminar.Text = "Eliminar";
            this.button_Eliminar.UseVisualStyleBackColor = true;
            this.button_Eliminar.Click += new System.EventHandler(this.button_Eliminar_Click);
            // 
            // button_Guardar
            // 
            this.button_Guardar.Location = new System.Drawing.Point(54, 313);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(121, 60);
            this.button_Guardar.TabIndex = 21;
            this.button_Guardar.Text = "Agregar ";
            this.button_Guardar.UseVisualStyleBackColor = true;
            this.button_Guardar.Click += new System.EventHandler(this.button_Guardar_Click);
            // 
            // textBox_Facultad
            // 
            this.textBox_Facultad.Location = new System.Drawing.Point(200, 123);
            this.textBox_Facultad.Multiline = true;
            this.textBox_Facultad.Name = "textBox_Facultad";
            this.textBox_Facultad.Size = new System.Drawing.Size(176, 25);
            this.textBox_Facultad.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nombre Facultad";
            // 
            // dataGridView_Facultades
            // 
            this.dataGridView_Facultades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Facultades.Location = new System.Drawing.Point(447, 35);
            this.dataGridView_Facultades.Name = "dataGridView_Facultades";
            this.dataGridView_Facultades.RowHeadersWidth = 51;
            this.dataGridView_Facultades.RowTemplate.Height = 24;
            this.dataGridView_Facultades.Size = new System.Drawing.Size(652, 393);
            this.dataGridView_Facultades.TabIndex = 25;
            this.dataGridView_Facultades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Facultades_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 60);
            this.button1.TabIndex = 26;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(37, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 60);
            this.button2.TabIndex = 27;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form_Facultad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView_Facultades);
            this.Controls.Add(this.textBox_IdFacultad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Eliminar);
            this.Controls.Add(this.button_Guardar);
            this.Controls.Add(this.textBox_Facultad);
            this.Controls.Add(this.label3);
            this.Name = "Form_Facultad";
            this.Text = "Form_Facultad";
            this.Load += new System.EventHandler(this.Form_Facultad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Facultades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_IdFacultad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Eliminar;
        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.TextBox textBox_Facultad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_Facultades;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}