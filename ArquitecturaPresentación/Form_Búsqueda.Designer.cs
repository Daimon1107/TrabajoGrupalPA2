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
            this.checkBox_Cédula = new System.Windows.Forms.CheckBox();
            this.checkBox_Apellido = new System.Windows.Forms.CheckBox();
            this.checkBox_Nombre = new System.Windows.Forms.CheckBox();
            this.checkBox_Carrera = new System.Windows.Forms.CheckBox();
            this.checkBox_Género = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_QuitarF = new System.Windows.Forms.Button();
            this.btn_Filtrar = new System.Windows.Forms.Button();
            this.checkBox_MesAP = new System.Windows.Forms.CheckBox();
            this.txt_MesAP = new System.Windows.Forms.TextBox();
            this.checkBox_AñoAP = new System.Windows.Forms.CheckBox();
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
            this.dataGridView_Estudiante.Location = new System.Drawing.Point(107, 76);
            this.dataGridView_Estudiante.Margin = new System.Windows.Forms.Padding(10, 10, 4, 4);
            this.dataGridView_Estudiante.Name = "dataGridView_Estudiante";
            this.dataGridView_Estudiante.RowHeadersWidth = 51;
            this.dataGridView_Estudiante.Size = new System.Drawing.Size(1012, 346);
            this.dataGridView_Estudiante.TabIndex = 1;
            this.dataGridView_Estudiante.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Estudiante_CellClick);
            // 
            // dataGridView_Informes
            // 
            this.dataGridView_Informes.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView_Informes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_Informes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Informes.Location = new System.Drawing.Point(107, 51);
            this.dataGridView_Informes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_Informes.Name = "dataGridView_Informes";
            this.dataGridView_Informes.RowHeadersWidth = 51;
            this.dataGridView_Informes.Size = new System.Drawing.Size(994, 154);
            this.dataGridView_Informes.TabIndex = 0;
            // 
            // combo_Carrera
            // 
            this.combo_Carrera.FormattingEnabled = true;
            this.combo_Carrera.Location = new System.Drawing.Point(47, 336);
            this.combo_Carrera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combo_Carrera.Name = "combo_Carrera";
            this.combo_Carrera.Size = new System.Drawing.Size(160, 24);
            this.combo_Carrera.TabIndex = 8;
            this.combo_Carrera.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(47, 253);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Nombre.MaxLength = 20;
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.ReadOnly = true;
            this.txt_Nombre.Size = new System.Drawing.Size(160, 22);
            this.txt_Nombre.TabIndex = 6;
            this.txt_Nombre.TextChanged += new System.EventHandler(this.txt_Nombre_TextChanged);
            this.txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombre_KeyPress);
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(47, 172);
            this.txt_Apellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Apellido.MaxLength = 20;
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.ReadOnly = true;
            this.txt_Apellido.Size = new System.Drawing.Size(160, 22);
            this.txt_Apellido.TabIndex = 4;
            this.txt_Apellido.TextChanged += new System.EventHandler(this.txt_Apellido_TextChanged);
            this.txt_Apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Apellido_KeyPress);
            // 
            // combo_Género
            // 
            this.combo_Género.FormattingEnabled = true;
            this.combo_Género.Location = new System.Drawing.Point(47, 415);
            this.combo_Género.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combo_Género.Name = "combo_Género";
            this.combo_Género.Size = new System.Drawing.Size(160, 24);
            this.combo_Género.TabIndex = 12;
            // 
            // txt_Cédula
            // 
            this.txt_Cédula.Location = new System.Drawing.Point(49, 103);
            this.txt_Cédula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Cédula.MaxLength = 10;
            this.txt_Cédula.Name = "txt_Cédula";
            this.txt_Cédula.ReadOnly = true;
            this.txt_Cédula.Size = new System.Drawing.Size(158, 22);
            this.txt_Cédula.TabIndex = 2;
            this.txt_Cédula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cédula_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Crimson;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(75, 19);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 34);
            this.label10.TabIndex = 1;
            this.label10.Text = "FILTROS";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // checkBox_Cédula
            // 
            this.checkBox_Cédula.AutoSize = true;
            this.checkBox_Cédula.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Cédula.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBox_Cédula.Location = new System.Drawing.Point(81, 68);
            this.checkBox_Cédula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_Cédula.Name = "checkBox_Cédula";
            this.checkBox_Cédula.Size = new System.Drawing.Size(101, 25);
            this.checkBox_Cédula.TabIndex = 17;
            this.checkBox_Cédula.Text = "CEDULA";
            this.checkBox_Cédula.UseVisualStyleBackColor = true;
            this.checkBox_Cédula.CheckedChanged += new System.EventHandler(this.checkBox_Cédula_CheckedChanged);
            // 
            // checkBox_Apellido
            // 
            this.checkBox_Apellido.AutoSize = true;
            this.checkBox_Apellido.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Apellido.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBox_Apellido.Location = new System.Drawing.Point(70, 139);
            this.checkBox_Apellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_Apellido.Name = "checkBox_Apellido";
            this.checkBox_Apellido.Size = new System.Drawing.Size(113, 25);
            this.checkBox_Apellido.TabIndex = 18;
            this.checkBox_Apellido.Text = "APELLIDO";
            this.checkBox_Apellido.UseVisualStyleBackColor = true;
            this.checkBox_Apellido.CheckedChanged += new System.EventHandler(this.checkBox_Apellido_CheckedChanged);
            // 
            // checkBox_Nombre
            // 
            this.checkBox_Nombre.AutoSize = true;
            this.checkBox_Nombre.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Nombre.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBox_Nombre.Location = new System.Drawing.Point(70, 220);
            this.checkBox_Nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_Nombre.Name = "checkBox_Nombre";
            this.checkBox_Nombre.Size = new System.Drawing.Size(106, 25);
            this.checkBox_Nombre.TabIndex = 19;
            this.checkBox_Nombre.Text = "NOMBRE";
            this.checkBox_Nombre.UseVisualStyleBackColor = true;
            this.checkBox_Nombre.CheckedChanged += new System.EventHandler(this.checkBox_Nombre_CheckedChanged);
            // 
            // checkBox_Carrera
            // 
            this.checkBox_Carrera.AutoSize = true;
            this.checkBox_Carrera.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Carrera.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBox_Carrera.Location = new System.Drawing.Point(68, 303);
            this.checkBox_Carrera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_Carrera.Name = "checkBox_Carrera";
            this.checkBox_Carrera.Size = new System.Drawing.Size(111, 25);
            this.checkBox_Carrera.TabIndex = 20;
            this.checkBox_Carrera.Text = "CARRERA";
            this.checkBox_Carrera.UseVisualStyleBackColor = true;
            this.checkBox_Carrera.CheckedChanged += new System.EventHandler(this.checkBox_Carrera_CheckedChanged);
            // 
            // checkBox_Género
            // 
            this.checkBox_Género.AutoSize = true;
            this.checkBox_Género.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Género.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBox_Género.Location = new System.Drawing.Point(68, 382);
            this.checkBox_Género.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_Género.Name = "checkBox_Género";
            this.checkBox_Género.Size = new System.Drawing.Size(103, 25);
            this.checkBox_Género.TabIndex = 21;
            this.checkBox_Género.Text = "GÉNERO";
            this.checkBox_Género.UseVisualStyleBackColor = true;
            this.checkBox_Género.CheckedChanged += new System.EventHandler(this.checkBox_Género_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Crimson;
            this.groupBox3.Controls.Add(this.btn_QuitarF);
            this.groupBox3.Controls.Add(this.btn_Filtrar);
            this.groupBox3.Controls.Add(this.checkBox_MesAP);
            this.groupBox3.Controls.Add(this.txt_MesAP);
            this.groupBox3.Controls.Add(this.checkBox_AñoAP);
            this.groupBox3.Controls.Add(this.txt_AñoAP);
            this.groupBox3.Controls.Add(this.checkBox_Género);
            this.groupBox3.Controls.Add(this.checkBox_Carrera);
            this.groupBox3.Controls.Add(this.checkBox_Nombre);
            this.groupBox3.Controls.Add(this.checkBox_Apellido);
            this.groupBox3.Controls.Add(this.checkBox_Cédula);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txt_Cédula);
            this.groupBox3.Controls.Add(this.combo_Género);
            this.groupBox3.Controls.Add(this.txt_Apellido);
            this.groupBox3.Controls.Add(this.txt_Nombre);
            this.groupBox3.Controls.Add(this.combo_Carrera);
            this.groupBox3.Location = new System.Drawing.Point(24, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(287, 726);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btn_QuitarF
            // 
            this.btn_QuitarF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_QuitarF.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuitarF.ForeColor = System.Drawing.Color.White;
            this.btn_QuitarF.Location = new System.Drawing.Point(138, 641);
            this.btn_QuitarF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_QuitarF.Name = "btn_QuitarF";
            this.btn_QuitarF.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.btn_QuitarF.Size = new System.Drawing.Size(128, 70);
            this.btn_QuitarF.TabIndex = 27;
            this.btn_QuitarF.Text = "QUITAR FILTROS";
            this.btn_QuitarF.UseVisualStyleBackColor = false;
            this.btn_QuitarF.Click += new System.EventHandler(this.btn_QuitarF_Click);
            // 
            // btn_Filtrar
            // 
            this.btn_Filtrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_Filtrar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Filtrar.ForeColor = System.Drawing.Color.White;
            this.btn_Filtrar.Location = new System.Drawing.Point(18, 641);
            this.btn_Filtrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Filtrar.Name = "btn_Filtrar";
            this.btn_Filtrar.Size = new System.Drawing.Size(103, 70);
            this.btn_Filtrar.TabIndex = 26;
            this.btn_Filtrar.Text = "FILTRAR";
            this.btn_Filtrar.UseVisualStyleBackColor = false;
            this.btn_Filtrar.Click += new System.EventHandler(this.btn_Filtrar_Click);
            // 
            // checkBox_MesAP
            // 
            this.checkBox_MesAP.AutoSize = true;
            this.checkBox_MesAP.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_MesAP.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBox_MesAP.Location = new System.Drawing.Point(18, 541);
            this.checkBox_MesAP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_MesAP.Name = "checkBox_MesAP";
            this.checkBox_MesAP.Size = new System.Drawing.Size(216, 25);
            this.checkBox_MesAP.TabIndex = 25;
            this.checkBox_MesAP.Text = "MES DE APROBACIÓN";
            this.checkBox_MesAP.UseVisualStyleBackColor = true;
            this.checkBox_MesAP.CheckedChanged += new System.EventHandler(this.checkBox_MesAP_CheckedChanged);
            // 
            // txt_MesAP
            // 
            this.txt_MesAP.Location = new System.Drawing.Point(47, 588);
            this.txt_MesAP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_MesAP.MaxLength = 2;
            this.txt_MesAP.Name = "txt_MesAP";
            this.txt_MesAP.ReadOnly = true;
            this.txt_MesAP.Size = new System.Drawing.Size(160, 22);
            this.txt_MesAP.TabIndex = 24;
            this.txt_MesAP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MesAP_KeyPress);
            // 
            // checkBox_AñoAP
            // 
            this.checkBox_AñoAP.AutoSize = true;
            this.checkBox_AñoAP.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_AñoAP.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBox_AñoAP.Location = new System.Drawing.Point(18, 459);
            this.checkBox_AñoAP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_AñoAP.Name = "checkBox_AñoAP";
            this.checkBox_AñoAP.Size = new System.Drawing.Size(223, 25);
            this.checkBox_AñoAP.TabIndex = 23;
            this.checkBox_AñoAP.Text = "AÑO DE APROBACIÓN";
            this.checkBox_AñoAP.UseVisualStyleBackColor = true;
            this.checkBox_AñoAP.CheckedChanged += new System.EventHandler(this.checkBox_AP_CheckedChanged);
            // 
            // txt_AñoAP
            // 
            this.txt_AñoAP.Location = new System.Drawing.Point(47, 499);
            this.txt_AñoAP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_AñoAP.MaxLength = 4;
            this.txt_AñoAP.Name = "txt_AñoAP";
            this.txt_AñoAP.ReadOnly = true;
            this.txt_AñoAP.Size = new System.Drawing.Size(160, 22);
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 741);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(101, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 34);
            this.label1.TabIndex = 9;
            this.label1.Text = "--- Lista de Estudiantes ---";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView_Estudiante);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(335, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1418, 454);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.dataGridView_Informes);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(335, 460);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1418, 281);
            this.panel3.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(101, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 34);
            this.label2.TabIndex = 10;
            this.label2.Text = "--- Informes ---";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form_Búsqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1753, 741);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.CheckBox checkBox_Cédula;
        private System.Windows.Forms.CheckBox checkBox_Apellido;
        private System.Windows.Forms.CheckBox checkBox_Nombre;
        private System.Windows.Forms.CheckBox checkBox_Carrera;
        private System.Windows.Forms.CheckBox checkBox_Género;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox_MesAP;
        private System.Windows.Forms.TextBox txt_MesAP;
        private System.Windows.Forms.CheckBox checkBox_AñoAP;
        private System.Windows.Forms.TextBox txt_AñoAP;
        private System.Windows.Forms.Button btn_QuitarF;
        private System.Windows.Forms.Button btn_Filtrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_Estudiante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
    }
}

