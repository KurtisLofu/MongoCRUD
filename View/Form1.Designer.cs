namespace View
{
    partial class Form1
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Persones = new System.Windows.Forms.TabPage();
            this.cbDirector = new System.Windows.Forms.CheckBox();
            this.cbActor = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDataN = new System.Windows.Forms.DateTimePicker();
            this.btnModificarPersona = new System.Windows.Forms.Button();
            this.tbNomPersona = new System.Windows.Forms.TextBox();
            this.tbLlocN = new System.Windows.Forms.TextBox();
            this.btnAfegirPersona = new System.Windows.Forms.Button();
            this.btnClearFiltrePersones = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFiltroPersonas = new System.Windows.Forms.TextBox();
            this.dgvPersones = new System.Windows.Forms.DataGridView();
            this.Borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.dgvPelicules = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbNom = new System.Windows.Forms.RadioButton();
            this.rbDirector = new System.Windows.Forms.RadioButton();
            this.rbAny = new System.Windows.Forms.RadioButton();
            this.rbActor = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.tbBuscarPelicula = new System.Windows.Forms.TextBox();
            this.btnBuscarPelicula = new System.Windows.Forms.Button();
            this.dgvActors = new System.Windows.Forms.DataGridView();
            this.dgvDirectors = new System.Windows.Forms.DataGridView();
            this.dgvOscars = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage2.SuspendLayout();
            this.Persones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersones)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPelicules)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirectors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOscars)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.dgvOscars);
            this.tabPage2.Controls.Add(this.dgvDirectors);
            this.tabPage2.Controls.Add(this.dgvActors);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.dgvPelicules);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1089, 459);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pel·lícules";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Persones
            // 
            this.Persones.Controls.Add(this.cbDirector);
            this.Persones.Controls.Add(this.cbActor);
            this.Persones.Controls.Add(this.label4);
            this.Persones.Controls.Add(this.label3);
            this.Persones.Controls.Add(this.label2);
            this.Persones.Controls.Add(this.dtpDataN);
            this.Persones.Controls.Add(this.btnModificarPersona);
            this.Persones.Controls.Add(this.tbNomPersona);
            this.Persones.Controls.Add(this.tbLlocN);
            this.Persones.Controls.Add(this.btnAfegirPersona);
            this.Persones.Controls.Add(this.btnClearFiltrePersones);
            this.Persones.Controls.Add(this.label1);
            this.Persones.Controls.Add(this.tbFiltroPersonas);
            this.Persones.Controls.Add(this.dgvPersones);
            this.Persones.Location = new System.Drawing.Point(4, 22);
            this.Persones.Name = "Persones";
            this.Persones.Padding = new System.Windows.Forms.Padding(3);
            this.Persones.Size = new System.Drawing.Size(1089, 459);
            this.Persones.TabIndex = 0;
            this.Persones.Text = "Persones";
            this.Persones.UseVisualStyleBackColor = true;
            // 
            // cbDirector
            // 
            this.cbDirector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDirector.AutoSize = true;
            this.cbDirector.Location = new System.Drawing.Point(398, 411);
            this.cbDirector.Name = "cbDirector";
            this.cbDirector.Size = new System.Drawing.Size(67, 17);
            this.cbDirector.TabIndex = 16;
            this.cbDirector.Text = "Ha dirigit";
            this.cbDirector.UseVisualStyleBackColor = true;
            // 
            // cbActor
            // 
            this.cbActor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbActor.AutoSize = true;
            this.cbActor.Location = new System.Drawing.Point(398, 368);
            this.cbActor.Name = "cbActor";
            this.cbActor.Size = new System.Drawing.Size(73, 17);
            this.cbActor.TabIndex = 15;
            this.cbActor.Text = "Ha actuat";
            this.cbActor.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Data de naixement";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Lloc de naixement";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nom";
            // 
            // dtpDataN
            // 
            this.dtpDataN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpDataN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataN.Location = new System.Drawing.Point(156, 417);
            this.dtpDataN.Name = "dtpDataN";
            this.dtpDataN.Size = new System.Drawing.Size(195, 20);
            this.dtpDataN.TabIndex = 11;
            // 
            // btnModificarPersona
            // 
            this.btnModificarPersona.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarPersona.Location = new System.Drawing.Point(918, 399);
            this.btnModificarPersona.Name = "btnModificarPersona";
            this.btnModificarPersona.Size = new System.Drawing.Size(148, 38);
            this.btnModificarPersona.TabIndex = 10;
            this.btnModificarPersona.Text = "Modificar seleccionada";
            this.btnModificarPersona.UseVisualStyleBackColor = true;
            // 
            // tbNomPersona
            // 
            this.tbNomPersona.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbNomPersona.Location = new System.Drawing.Point(156, 347);
            this.tbNomPersona.Name = "tbNomPersona";
            this.tbNomPersona.Size = new System.Drawing.Size(195, 20);
            this.tbNomPersona.TabIndex = 8;
            // 
            // tbLlocN
            // 
            this.tbLlocN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbLlocN.Location = new System.Drawing.Point(156, 384);
            this.tbLlocN.Name = "tbLlocN";
            this.tbLlocN.Size = new System.Drawing.Size(195, 20);
            this.tbLlocN.TabIndex = 7;
            // 
            // btnAfegirPersona
            // 
            this.btnAfegirPersona.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAfegirPersona.Location = new System.Drawing.Point(918, 347);
            this.btnAfegirPersona.Name = "btnAfegirPersona";
            this.btnAfegirPersona.Size = new System.Drawing.Size(148, 38);
            this.btnAfegirPersona.TabIndex = 6;
            this.btnAfegirPersona.Text = "Afegir nova persona";
            this.btnAfegirPersona.UseVisualStyleBackColor = true;
            // 
            // btnClearFiltrePersones
            // 
            this.btnClearFiltrePersones.Location = new System.Drawing.Point(207, 17);
            this.btnClearFiltrePersones.Name = "btnClearFiltrePersones";
            this.btnClearFiltrePersones.Size = new System.Drawing.Size(75, 35);
            this.btnClearFiltrePersones.TabIndex = 3;
            this.btnClearFiltrePersones.Text = "Netejar";
            this.btnClearFiltrePersones.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cerca (case-sensitive, mínim 3 caràcters)";
            // 
            // tbFiltroPersonas
            // 
            this.tbFiltroPersonas.Location = new System.Drawing.Point(3, 32);
            this.tbFiltroPersonas.Name = "tbFiltroPersonas";
            this.tbFiltroPersonas.Size = new System.Drawing.Size(198, 20);
            this.tbFiltroPersonas.TabIndex = 1;
            // 
            // dgvPersones
            // 
            this.dgvPersones.AllowUserToAddRows = false;
            this.dgvPersones.AllowUserToDeleteRows = false;
            this.dgvPersones.AllowUserToResizeRows = false;
            this.dgvPersones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPersones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Borrar});
            this.dgvPersones.Location = new System.Drawing.Point(6, 58);
            this.dgvPersones.MultiSelect = false;
            this.dgvPersones.Name = "dgvPersones";
            this.dgvPersones.ReadOnly = true;
            this.dgvPersones.RowHeadersVisible = false;
            this.dgvPersones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersones.Size = new System.Drawing.Size(1074, 275);
            this.dgvPersones.TabIndex = 0;
            // 
            // Borrar
            // 
            this.Borrar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Borrar.HeaderText = "";
            this.Borrar.Name = "Borrar";
            this.Borrar.ReadOnly = true;
            this.Borrar.Text = "Esborrar";
            this.Borrar.ToolTipText = "Esborrar";
            this.Borrar.UseColumnTextForButtonValue = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.Persones);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1097, 485);
            this.tabControl1.TabIndex = 0;
            // 
            // dgvPelicules
            // 
            this.dgvPelicules.AllowUserToAddRows = false;
            this.dgvPelicules.AllowUserToDeleteRows = false;
            this.dgvPelicules.AllowUserToResizeRows = false;
            this.dgvPelicules.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvPelicules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPelicules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPelicules.Location = new System.Drawing.Point(3, 100);
            this.dgvPelicules.Name = "dgvPelicules";
            this.dgvPelicules.RowHeadersVisible = false;
            this.dgvPelicules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPelicules.Size = new System.Drawing.Size(468, 353);
            this.dgvPelicules.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBuscarPelicula);
            this.panel1.Controls.Add(this.tbBuscarPelicula);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.rbActor);
            this.panel1.Controls.Add(this.rbAny);
            this.panel1.Controls.Add(this.rbDirector);
            this.panel1.Controls.Add(this.rbNom);
            this.panel1.Location = new System.Drawing.Point(6, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 91);
            this.panel1.TabIndex = 1;
            // 
            // rbNom
            // 
            this.rbNom.AutoSize = true;
            this.rbNom.Location = new System.Drawing.Point(3, 23);
            this.rbNom.Name = "rbNom";
            this.rbNom.Size = new System.Drawing.Size(47, 17);
            this.rbNom.TabIndex = 0;
            this.rbNom.TabStop = true;
            this.rbNom.Text = "Nom";
            this.rbNom.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.rbNom.UseVisualStyleBackColor = true;
            // 
            // rbDirector
            // 
            this.rbDirector.AutoSize = true;
            this.rbDirector.Location = new System.Drawing.Point(105, 23);
            this.rbDirector.Name = "rbDirector";
            this.rbDirector.Size = new System.Drawing.Size(62, 17);
            this.rbDirector.TabIndex = 1;
            this.rbDirector.TabStop = true;
            this.rbDirector.Text = "Director";
            this.rbDirector.UseVisualStyleBackColor = true;
            // 
            // rbAny
            // 
            this.rbAny.AutoSize = true;
            this.rbAny.Location = new System.Drawing.Point(56, 23);
            this.rbAny.Name = "rbAny";
            this.rbAny.Size = new System.Drawing.Size(43, 17);
            this.rbAny.TabIndex = 2;
            this.rbAny.TabStop = true;
            this.rbAny.Text = "Any";
            this.rbAny.UseVisualStyleBackColor = true;
            // 
            // rbActor
            // 
            this.rbActor.AutoSize = true;
            this.rbActor.Location = new System.Drawing.Point(173, 23);
            this.rbActor.Name = "rbActor";
            this.rbActor.Size = new System.Drawing.Size(50, 17);
            this.rbActor.TabIndex = 3;
            this.rbActor.TabStop = true;
            this.rbActor.Text = "Actor";
            this.rbActor.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Filtre ( > 3 caràcters):";
            // 
            // tbBuscarPelicula
            // 
            this.tbBuscarPelicula.Location = new System.Drawing.Point(3, 56);
            this.tbBuscarPelicula.Name = "tbBuscarPelicula";
            this.tbBuscarPelicula.Size = new System.Drawing.Size(209, 20);
            this.tbBuscarPelicula.TabIndex = 5;
            // 
            // btnBuscarPelicula
            // 
            this.btnBuscarPelicula.Location = new System.Drawing.Point(218, 54);
            this.btnBuscarPelicula.Name = "btnBuscarPelicula";
            this.btnBuscarPelicula.Size = new System.Drawing.Size(49, 23);
            this.btnBuscarPelicula.TabIndex = 6;
            this.btnBuscarPelicula.Text = "Cercar";
            this.btnBuscarPelicula.UseVisualStyleBackColor = true;
            // 
            // dgvActors
            // 
            this.dgvActors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvActors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActors.Location = new System.Drawing.Point(505, 26);
            this.dgvActors.Name = "dgvActors";
            this.dgvActors.Size = new System.Drawing.Size(576, 146);
            this.dgvActors.TabIndex = 2;
            // 
            // dgvDirectors
            // 
            this.dgvDirectors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDirectors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDirectors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDirectors.Location = new System.Drawing.Point(505, 191);
            this.dgvDirectors.Name = "dgvDirectors";
            this.dgvDirectors.Size = new System.Drawing.Size(576, 151);
            this.dgvDirectors.TabIndex = 3;
            // 
            // dgvOscars
            // 
            this.dgvOscars.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOscars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOscars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOscars.Location = new System.Drawing.Point(505, 361);
            this.dgvOscars.Name = "dgvOscars";
            this.dgvOscars.Size = new System.Drawing.Size(576, 92);
            this.dgvOscars.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(502, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Actors";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(502, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Directors";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(502, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Oscars";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 498);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.Persones.ResumeLayout(false);
            this.Persones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersones)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPelicules)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirectors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOscars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage Persones;
        public System.Windows.Forms.DataGridView dgvPersones;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TextBox tbFiltroPersonas;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnClearFiltrePersones;
        private System.Windows.Forms.DataGridViewButtonColumn Borrar;
        public System.Windows.Forms.Button btnAfegirPersona;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnModificarPersona;
        public System.Windows.Forms.CheckBox cbDirector;
        public System.Windows.Forms.CheckBox cbActor;
        public System.Windows.Forms.DateTimePicker dtpDataN;
        public System.Windows.Forms.TextBox tbNomPersona;
        public System.Windows.Forms.TextBox tbLlocN;
        public System.Windows.Forms.Button btnBuscarPelicula;
        public System.Windows.Forms.TextBox tbBuscarPelicula;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.RadioButton rbActor;
        public System.Windows.Forms.RadioButton rbAny;
        public System.Windows.Forms.RadioButton rbDirector;
        public System.Windows.Forms.RadioButton rbNom;
        public System.Windows.Forms.DataGridView dgvPelicules;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DataGridView dgvOscars;
        public System.Windows.Forms.DataGridView dgvDirectors;
        public System.Windows.Forms.DataGridView dgvActors;
    }
}

