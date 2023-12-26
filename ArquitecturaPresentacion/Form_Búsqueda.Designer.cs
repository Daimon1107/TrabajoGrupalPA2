namespace ArquitecturaPresentacion
{
    partial class Form_Búsqueda
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_Estudiante = new System.Windows.Forms.DataGridView();
            this.dataGridView_Informes = new System.Windows.Forms.DataGridView();
            this.combo_Carrera = new System.Windows.Forms.ComboBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.combo_Género = new System.Windows.Forms.ComboBox();
            this.txt_Cédula = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_MesAP = new System.Windows.Forms.Label();
            this.lbl_AñoAP = new System.Windows.Forms.Label();
            this.lbl_Género = new System.Windows.Forms.Label();
            this.lbl_Carrera = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.lbl_Cédula = new System.Windows.Forms.Label();
            this.btn_QuitarF = new System.Windows.Forms.Button();
            this.txt_MesAP = new System.Windows.Forms.TextBox();
            this.txt_AñoAP = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Estudiante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Informes)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Estudiante
            // 
            this.dataGridView_Estudiante.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView_Estudiante.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_Estudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Estudiante.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView_Estudiante.Location = new System.Drawing.Point(43, 62);
            this.dataGridView_Estudiante.Margin = new System.Windows.Forms.Padding(8, 8, 3, 3);
            this.dataGridView_Estudiante.Name = "dataGridView_Estudiante";
            this.dataGridView_Estudiante.RowHeadersWidth = 51;
            this.dataGridView_Estudiante.Size = new System.Drawing.Size(759, 281);
            this.dataGridView_Estudiante.TabIndex = 1;
            this.dataGridView_Estudiante.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Estudiante_CellClick);
            // 
            // dataGridView_Informes
            // 
            this.dataGridView_Informes.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView_Informes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_Informes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Informes.Location = new System.Drawing.Point(43, 36);
            this.dataGridView_Informes.Name = "dataGridView_Informes";
            this.dataGridView_Informes.RowHeadersWidth = 51;
            this.dataGridView_Informes.Size = new System.Drawing.Size(746, 125);
            this.dataGridView_Informes.TabIndex = 0;
            // 
            // combo_Carrera
            // 
            this.combo_Carrera.FormattingEnabled = true;
            this.combo_Carrera.Location = new System.Drawing.Point(35, 273);
            this.combo_Carrera.Name = "combo_Carrera";
            this.combo_Carrera.Size = new System.Drawing.Size(134, 21);
            this.combo_Carrera.TabIndex = 8;
            this.combo_Carrera.Text = "Seleccione una carrera";
            this.combo_Carrera.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(35, 206);
            this.txt_Nombre.MaxLength = 20;
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(121, 20);
            this.txt_Nombre.TabIndex = 6;
            this.txt_Nombre.TextChanged += new System.EventHandler(this.txt_Nombre_TextChanged);
            this.txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombre_KeyPress);
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(35, 140);
            this.txt_Apellido.MaxLength = 20;
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(121, 20);
            this.txt_Apellido.TabIndex = 4;
            this.txt_Apellido.TextChanged += new System.EventHandler(this.txt_Apellido_TextChanged);
            this.txt_Apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Apellido_KeyPress);
            // 
            // combo_Género
            // 
            this.combo_Género.FormattingEnabled = true;
            this.combo_Género.Location = new System.Drawing.Point(35, 337);
            this.combo_Género.Name = "combo_Género";
            this.combo_Género.Size = new System.Drawing.Size(134, 21);
            this.combo_Género.TabIndex = 12;
            this.combo_Género.Text = "Seleccione un género";
            // 
            // txt_Cédula
            // 
            this.txt_Cédula.Location = new System.Drawing.Point(37, 84);
            this.txt_Cédula.MaxLength = 10;
            this.txt_Cédula.Name = "txt_Cédula";
            this.txt_Cédula.Size = new System.Drawing.Size(120, 20);
            this.txt_Cédula.TabIndex = 2;
            this.txt_Cédula.TextChanged += new System.EventHandler(this.txt_Cédula_TextChanged);
            this.txt_Cédula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cédula_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Crimson;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(56, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 26);
            this.label10.TabIndex = 1;
            this.label10.Text = "FILTROS";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Crimson;
            this.groupBox3.Controls.Add(this.lbl_MesAP);
            this.groupBox3.Controls.Add(this.lbl_AñoAP);
            this.groupBox3.Controls.Add(this.lbl_Género);
            this.groupBox3.Controls.Add(this.lbl_Carrera);
            this.groupBox3.Controls.Add(this.lbl_Nombre);
            this.groupBox3.Controls.Add(this.lbl_Apellido);
            this.groupBox3.Controls.Add(this.lbl_Cédula);
            this.groupBox3.Controls.Add(this.btn_QuitarF);
            this.groupBox3.Controls.Add(this.txt_MesAP);
            this.groupBox3.Controls.Add(this.txt_AñoAP);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txt_Cédula);
            this.groupBox3.Controls.Add(this.combo_Género);
            this.groupBox3.Controls.Add(this.txt_Apellido);
            this.groupBox3.Controls.Add(this.txt_Nombre);
            this.groupBox3.Controls.Add(this.combo_Carrera);
            this.groupBox3.Location = new System.Drawing.Point(18, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 590);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // lbl_MesAP
            // 
            this.lbl_MesAP.AutoSize = true;
            this.lbl_MesAP.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.lbl_MesAP.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_MesAP.Location = new System.Drawing.Point(30, 456);
            this.lbl_MesAP.Name = "lbl_MesAP";
            this.lbl_MesAP.Size = new System.Drawing.Size(154, 19);
            this.lbl_MesAP.TabIndex = 34;
            this.lbl_MesAP.Text = "MES DE APROBACIÓN";
            // 
            // lbl_AñoAP
            // 
            this.lbl_AñoAP.AutoSize = true;
            this.lbl_AñoAP.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.lbl_AñoAP.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_AñoAP.Location = new System.Drawing.Point(30, 383);
            this.lbl_AñoAP.Name = "lbl_AñoAP";
            this.lbl_AñoAP.Size = new System.Drawing.Size(157, 19);
            this.lbl_AñoAP.TabIndex = 33;
            this.lbl_AñoAP.Text = "AÑO DE APROBACIÓN";
            // 
            // lbl_Género
            // 
            this.lbl_Género.AutoSize = true;
            this.lbl_Género.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.lbl_Género.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_Género.Location = new System.Drawing.Point(68, 312);
            this.lbl_Género.Name = "lbl_Género";
            this.lbl_Género.Size = new System.Drawing.Size(68, 19);
            this.lbl_Género.TabIndex = 32;
            this.lbl_Género.Text = "GÉNERO";
            // 
            // lbl_Carrera
            // 
            this.lbl_Carrera.AutoSize = true;
            this.lbl_Carrera.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.lbl_Carrera.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_Carrera.Location = new System.Drawing.Point(69, 251);
            this.lbl_Carrera.Name = "lbl_Carrera";
            this.lbl_Carrera.Size = new System.Drawing.Size(73, 19);
            this.lbl_Carrera.TabIndex = 31;
            this.lbl_Carrera.Text = "CARRERA";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.lbl_Nombre.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_Nombre.Location = new System.Drawing.Point(72, 184);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(69, 19);
            this.lbl_Nombre.TabIndex = 30;
            this.lbl_Nombre.Text = "NOMBRE";
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.lbl_Apellido.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_Apellido.Location = new System.Drawing.Point(72, 118);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(71, 19);
            this.lbl_Apellido.TabIndex = 29;
            this.lbl_Apellido.Text = "APELLIDO";
            // 
            // lbl_Cédula
            // 
            this.lbl_Cédula.AutoSize = true;
            this.lbl_Cédula.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.lbl_Cédula.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_Cédula.Location = new System.Drawing.Point(75, 62);
            this.lbl_Cédula.Name = "lbl_Cédula";
            this.lbl_Cédula.Size = new System.Drawing.Size(62, 19);
            this.lbl_Cédula.TabIndex = 28;
            this.lbl_Cédula.Text = "CÉDULA";
            // 
            // btn_QuitarF
            // 
            this.btn_QuitarF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_QuitarF.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuitarF.ForeColor = System.Drawing.Color.White;
            this.btn_QuitarF.Location = new System.Drawing.Point(47, 521);
            this.btn_QuitarF.Name = "btn_QuitarF";
            this.btn_QuitarF.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.btn_QuitarF.Size = new System.Drawing.Size(96, 57);
            this.btn_QuitarF.TabIndex = 27;
            this.btn_QuitarF.Text = "LIMPIAR FILTROS";
            this.btn_QuitarF.UseVisualStyleBackColor = false;
            this.btn_QuitarF.Click += new System.EventHandler(this.btn_QuitarF_Click);
            // 
            // txt_MesAP
            // 
            this.txt_MesAP.Location = new System.Drawing.Point(35, 478);
            this.txt_MesAP.MaxLength = 2;
            this.txt_MesAP.Name = "txt_MesAP";
            this.txt_MesAP.Size = new System.Drawing.Size(121, 20);
            this.txt_MesAP.TabIndex = 24;
            this.txt_MesAP.TextChanged += new System.EventHandler(this.txt_MesAP_TextChanged);
            this.txt_MesAP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MesAP_KeyPress);
            // 
            // txt_AñoAP
            // 
            this.txt_AñoAP.Location = new System.Drawing.Point(35, 405);
            this.txt_AñoAP.MaxLength = 4;
            this.txt_AñoAP.Name = "txt_AñoAP";
            this.txt_AñoAP.Size = new System.Drawing.Size(121, 20);
            this.txt_AñoAP.TabIndex = 22;
            this.txt_AñoAP.TextChanged += new System.EventHandler(this.txt_AñoAP_TextChanged);
            this.txt_AñoAP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_AñoAP_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 602);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(76, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "--- Lista de Estudiantes ---";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView_Estudiante);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(251, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(814, 369);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.dataGridView_Informes);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(251, 374);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(814, 228);
            this.panel3.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(76, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "--- Informes ---";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form_Búsqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1065, 602);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form_Búsqueda";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Estudiante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Informes)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_Informes;
        private System.Windows.Forms.ComboBox combo_Carrera;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.ComboBox combo_Género;
        private System.Windows.Forms.TextBox txt_Cédula;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_MesAP;
        private System.Windows.Forms.TextBox txt_AñoAP;
        private System.Windows.Forms.Button btn_QuitarF;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_Estudiante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Cédula;
        private System.Windows.Forms.Label lbl_Carrera;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.Label lbl_MesAP;
        private System.Windows.Forms.Label lbl_AñoAP;
        private System.Windows.Forms.Label lbl_Género;
    }
}

