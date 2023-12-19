namespace ArquitecturaPresentacion
{
    partial class Form_Docente
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
            this.comboBox_Facultad = new System.Windows.Forms.ComboBox();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Apellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Cedula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_FechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.dataGridView_Docentes = new System.Windows.Forms.DataGridView();
            this.button_Agregar = new System.Windows.Forms.Button();
            this.button_Eliminar = new System.Windows.Forms.Button();
            this.button_Nuevo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Docentes)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Facultad
            // 
            this.comboBox_Facultad.FormattingEnabled = true;
            this.comboBox_Facultad.Location = new System.Drawing.Point(145, 333);
            this.comboBox_Facultad.Name = "comboBox_Facultad";
            this.comboBox_Facultad.Size = new System.Drawing.Size(170, 24);
            this.comboBox_Facultad.TabIndex = 34;
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(150, 37);
            this.textBox_Id.Multiline = true;
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(176, 25);
            this.textBox_Id.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 25);
            this.label9.TabIndex = 31;
            this.label9.Text = "Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 30;
            this.label5.Text = "id_facultad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "Fecha Nac";
            // 
            // textBox_Apellido
            // 
            this.textBox_Apellido.Location = new System.Drawing.Point(144, 137);
            this.textBox_Apellido.Multiline = true;
            this.textBox_Apellido.Name = "textBox_Apellido";
            this.textBox_Apellido.Size = new System.Drawing.Size(176, 25);
            this.textBox_Apellido.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Apellido:";
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(144, 203);
            this.textBox_Nombre.Multiline = true;
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(176, 25);
            this.textBox_Nombre.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nombre:";
            // 
            // textBox_Cedula
            // 
            this.textBox_Cedula.Location = new System.Drawing.Point(145, 81);
            this.textBox_Cedula.Multiline = true;
            this.textBox_Cedula.Name = "textBox_Cedula";
            this.textBox_Cedula.Size = new System.Drawing.Size(176, 25);
            this.textBox_Cedula.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Cedula:";
            // 
            // dateTimePicker_FechaNacimiento
            // 
            this.dateTimePicker_FechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_FechaNacimiento.Location = new System.Drawing.Point(141, 271);
            this.dateTimePicker_FechaNacimiento.Name = "dateTimePicker_FechaNacimiento";
            this.dateTimePicker_FechaNacimiento.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_FechaNacimiento.TabIndex = 35;
            // 
            // dataGridView_Docentes
            // 
            this.dataGridView_Docentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Docentes.Location = new System.Drawing.Point(431, 25);
            this.dataGridView_Docentes.Name = "dataGridView_Docentes";
            this.dataGridView_Docentes.RowHeadersWidth = 51;
            this.dataGridView_Docentes.RowTemplate.Height = 24;
            this.dataGridView_Docentes.Size = new System.Drawing.Size(953, 447);
            this.dataGridView_Docentes.TabIndex = 36;
            this.dataGridView_Docentes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Docentes_CellClick);
            // 
            // button_Agregar
            // 
            this.button_Agregar.Location = new System.Drawing.Point(33, 438);
            this.button_Agregar.Name = "button_Agregar";
            this.button_Agregar.Size = new System.Drawing.Size(133, 34);
            this.button_Agregar.TabIndex = 37;
            this.button_Agregar.Text = "Agregar";
            this.button_Agregar.UseVisualStyleBackColor = true;
            this.button_Agregar.Click += new System.EventHandler(this.button_Agregar_Click);
            // 
            // button_Eliminar
            // 
            this.button_Eliminar.Location = new System.Drawing.Point(208, 438);
            this.button_Eliminar.Name = "button_Eliminar";
            this.button_Eliminar.Size = new System.Drawing.Size(133, 34);
            this.button_Eliminar.TabIndex = 38;
            this.button_Eliminar.Text = "Eliminar";
            this.button_Eliminar.UseVisualStyleBackColor = true;
            this.button_Eliminar.Click += new System.EventHandler(this.button_Eliminar_Click);
            // 
            // button_Nuevo
            // 
            this.button_Nuevo.Location = new System.Drawing.Point(110, 517);
            this.button_Nuevo.Name = "button_Nuevo";
            this.button_Nuevo.Size = new System.Drawing.Size(133, 34);
            this.button_Nuevo.TabIndex = 39;
            this.button_Nuevo.Text = "Nuevo";
            this.button_Nuevo.UseVisualStyleBackColor = true;
            this.button_Nuevo.Click += new System.EventHandler(this.button_Nuevo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1261, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 34);
            this.button1.TabIndex = 40;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Docente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 629);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_Nuevo);
            this.Controls.Add(this.button_Eliminar);
            this.Controls.Add(this.button_Agregar);
            this.Controls.Add(this.dataGridView_Docentes);
            this.Controls.Add(this.dateTimePicker_FechaNacimiento);
            this.Controls.Add(this.comboBox_Facultad);
            this.Controls.Add(this.textBox_Id);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Apellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Cedula);
            this.Controls.Add(this.label1);
            this.Name = "Form_Docente";
            this.Text = "Form_Docente";
            this.Load += new System.EventHandler(this.Form_Docente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Docentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Facultad;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Apellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Cedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_FechaNacimiento;
        private System.Windows.Forms.DataGridView dataGridView_Docentes;
        private System.Windows.Forms.Button button_Agregar;
        private System.Windows.Forms.Button button_Eliminar;
        private System.Windows.Forms.Button button_Nuevo;
        private System.Windows.Forms.Button button1;
    }
}