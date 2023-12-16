namespace ArquitecturaPresentacion
{
    partial class Form_Carrera
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
            this.textBox_Carrera = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.button_Eliminar = new System.Windows.Forms.Button();
            this.dataGridView_Carreras = new System.Windows.Forms.DataGridView();
            this.textBox_IdCarrera = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Facultad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Carreras)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Carrera
            // 
            this.textBox_Carrera.Location = new System.Drawing.Point(202, 90);
            this.textBox_Carrera.Multiline = true;
            this.textBox_Carrera.Name = "textBox_Carrera";
            this.textBox_Carrera.Size = new System.Drawing.Size(176, 25);
            this.textBox_Carrera.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre Carrera:";
            // 
            // button_Guardar
            // 
            this.button_Guardar.Location = new System.Drawing.Point(57, 312);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(121, 60);
            this.button_Guardar.TabIndex = 8;
            this.button_Guardar.Text = "Agregar Carrera";
            this.button_Guardar.UseVisualStyleBackColor = true;
            this.button_Guardar.Click += new System.EventHandler(this.button_Guardar_Click);
            // 
            // button_Eliminar
            // 
            this.button_Eliminar.Location = new System.Drawing.Point(202, 312);
            this.button_Eliminar.Name = "button_Eliminar";
            this.button_Eliminar.Size = new System.Drawing.Size(121, 60);
            this.button_Eliminar.TabIndex = 9;
            this.button_Eliminar.Text = "Eliminar";
            this.button_Eliminar.UseVisualStyleBackColor = true;
            this.button_Eliminar.Click += new System.EventHandler(this.button_Eliminar_Click);
            // 
            // dataGridView_Carreras
            // 
            this.dataGridView_Carreras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Carreras.Location = new System.Drawing.Point(459, 64);
            this.dataGridView_Carreras.Name = "dataGridView_Carreras";
            this.dataGridView_Carreras.RowHeadersWidth = 51;
            this.dataGridView_Carreras.RowTemplate.Height = 24;
            this.dataGridView_Carreras.Size = new System.Drawing.Size(755, 295);
            this.dataGridView_Carreras.TabIndex = 10;
            this.dataGridView_Carreras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Carreras_CellContentClick);
            // 
            // textBox_IdCarrera
            // 
            this.textBox_IdCarrera.Location = new System.Drawing.Point(202, 35);
            this.textBox_IdCarrera.Multiline = true;
            this.textBox_IdCarrera.Name = "textBox_IdCarrera";
            this.textBox_IdCarrera.Size = new System.Drawing.Size(176, 25);
            this.textBox_IdCarrera.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Id";
            // 
            // comboBox_Facultad
            // 
            this.comboBox_Facultad.FormattingEnabled = true;
            this.comboBox_Facultad.Location = new System.Drawing.Point(145, 193);
            this.comboBox_Facultad.Name = "comboBox_Facultad";
            this.comboBox_Facultad.Size = new System.Drawing.Size(152, 24);
            this.comboBox_Facultad.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Facultad";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1162, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 35);
            this.button1.TabIndex = 15;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Carrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_Facultad);
            this.Controls.Add(this.textBox_IdCarrera);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_Carreras);
            this.Controls.Add(this.button_Eliminar);
            this.Controls.Add(this.button_Guardar);
            this.Controls.Add(this.textBox_Carrera);
            this.Controls.Add(this.label3);
            this.Name = "Form_Carrera";
            this.Text = "Form_Carrera";
            this.Load += new System.EventHandler(this.Form_Carrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Carreras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Carrera;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.Button button_Eliminar;
        private System.Windows.Forms.DataGridView dataGridView_Carreras;
        private System.Windows.Forms.TextBox textBox_IdCarrera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Facultad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}