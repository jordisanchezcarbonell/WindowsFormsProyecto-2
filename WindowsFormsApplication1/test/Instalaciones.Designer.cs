namespace COMPLETE_FLAT_UI
{
    partial class Instalaciones
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_tipo_gestion = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceInstalaciones = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxEsport = new System.Windows.Forms.ComboBox();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialSingleLineTextFieldAdreca = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextFieldTitulo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabelHorari = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelTipusGestio = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelAdreca = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelNom = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.comboBoxDia = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInstalaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.id_tipo_gestion,
            this.direccion});
            this.dataGridView1.DataSource = this.bindingSourceInstalaciones;
            this.dataGridView1.Location = new System.Drawing.Point(54, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(706, 209);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // id_tipo_gestion
            // 
            this.id_tipo_gestion.DataPropertyName = "id_tipo_gestion";
            this.id_tipo_gestion.DataSource = this.bindingSource1;
            this.id_tipo_gestion.DisplayMember = "nombre";
            this.id_tipo_gestion.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.id_tipo_gestion.HeaderText = "id_tipo_gestion";
            this.id_tipo_gestion.Name = "id_tipo_gestion";
            this.id_tipo_gestion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id_tipo_gestion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.id_tipo_gestion.ValueMember = "id";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(COMPLETE_FLAT_UI.Tipo_gestion);
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "direccion";
            this.direccion.Name = "direccion";
            // 
            // bindingSourceInstalaciones
            // 
            this.bindingSourceInstalaciones.DataSource = typeof(COMPLETE_FLAT_UI.Instalacion);
            // 
            // comboBoxEsport
            // 
            this.comboBoxEsport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEsport.DataSource = this.bindingSource1;
            this.comboBoxEsport.DisplayMember = "nombre";
            this.comboBoxEsport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEsport.FormattingEnabled = true;
            this.comboBoxEsport.Location = new System.Drawing.Point(206, 173);
            this.comboBoxEsport.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxEsport.Name = "comboBoxEsport";
            this.comboBoxEsport.Size = new System.Drawing.Size(202, 21);
            this.comboBoxEsport.TabIndex = 29;
            this.comboBoxEsport.ValueMember = "id";
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.AutoSize = true;
            this.materialRaisedButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Icon = null;
            this.materialRaisedButton3.Location = new System.Drawing.Point(491, 191);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(65, 36);
            this.materialRaisedButton3.TabIndex = 28;
            this.materialRaisedButton3.Text = "Borra";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            this.materialRaisedButton3.Click += new System.EventHandler(this.materialRaisedButton3_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.AutoSize = true;
            this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Icon = null;
            this.materialRaisedButton2.Location = new System.Drawing.Point(491, 135);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(85, 36);
            this.materialRaisedButton2.TabIndex = 27;
            this.materialRaisedButton2.Text = "Modifica";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(493, 83);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(83, 36);
            this.materialRaisedButton1.TabIndex = 26;
            this.materialRaisedButton1.Text = "Agregar";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialSingleLineTextFieldAdreca
            // 
            this.materialSingleLineTextFieldAdreca.Depth = 0;
            this.materialSingleLineTextFieldAdreca.Hint = "";
            this.materialSingleLineTextFieldAdreca.Location = new System.Drawing.Point(206, 135);
            this.materialSingleLineTextFieldAdreca.MaxLength = 32767;
            this.materialSingleLineTextFieldAdreca.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldAdreca.Name = "materialSingleLineTextFieldAdreca";
            this.materialSingleLineTextFieldAdreca.PasswordChar = '\0';
            this.materialSingleLineTextFieldAdreca.SelectedText = "";
            this.materialSingleLineTextFieldAdreca.SelectionLength = 0;
            this.materialSingleLineTextFieldAdreca.SelectionStart = 0;
            this.materialSingleLineTextFieldAdreca.Size = new System.Drawing.Size(200, 23);
            this.materialSingleLineTextFieldAdreca.TabIndex = 24;
            this.materialSingleLineTextFieldAdreca.TabStop = false;
            this.materialSingleLineTextFieldAdreca.UseSystemPasswordChar = false;
            this.materialSingleLineTextFieldAdreca.Click += new System.EventHandler(this.materialSingleLineTextFieldAdreca_Click);
            // 
            // materialSingleLineTextFieldTitulo
            // 
            this.materialSingleLineTextFieldTitulo.Depth = 0;
            this.materialSingleLineTextFieldTitulo.Hint = "";
            this.materialSingleLineTextFieldTitulo.Location = new System.Drawing.Point(206, 100);
            this.materialSingleLineTextFieldTitulo.MaxLength = 32767;
            this.materialSingleLineTextFieldTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldTitulo.Name = "materialSingleLineTextFieldTitulo";
            this.materialSingleLineTextFieldTitulo.PasswordChar = '\0';
            this.materialSingleLineTextFieldTitulo.SelectedText = "";
            this.materialSingleLineTextFieldTitulo.SelectionLength = 0;
            this.materialSingleLineTextFieldTitulo.SelectionStart = 0;
            this.materialSingleLineTextFieldTitulo.Size = new System.Drawing.Size(200, 23);
            this.materialSingleLineTextFieldTitulo.TabIndex = 23;
            this.materialSingleLineTextFieldTitulo.TabStop = false;
            this.materialSingleLineTextFieldTitulo.UseSystemPasswordChar = false;
            this.materialSingleLineTextFieldTitulo.Click += new System.EventHandler(this.materialSingleLineTextFieldTitulo_Click);
            // 
            // materialLabelHorari
            // 
            this.materialLabelHorari.AutoSize = true;
            this.materialLabelHorari.Depth = 0;
            this.materialLabelHorari.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelHorari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabelHorari.Location = new System.Drawing.Point(57, 208);
            this.materialLabelHorari.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelHorari.Name = "materialLabelHorari";
            this.materialLabelHorari.Size = new System.Drawing.Size(83, 19);
            this.materialLabelHorari.TabIndex = 22;
            this.materialLabelHorari.Text = "Horari Inici";
            // 
            // materialLabelTipusGestio
            // 
            this.materialLabelTipusGestio.AutoSize = true;
            this.materialLabelTipusGestio.Depth = 0;
            this.materialLabelTipusGestio.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelTipusGestio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabelTipusGestio.Location = new System.Drawing.Point(57, 172);
            this.materialLabelTipusGestio.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelTipusGestio.Name = "materialLabelTipusGestio";
            this.materialLabelTipusGestio.Size = new System.Drawing.Size(112, 19);
            this.materialLabelTipusGestio.TabIndex = 21;
            this.materialLabelTipusGestio.Text = "Tipus de gestió";
            // 
            // materialLabelAdreca
            // 
            this.materialLabelAdreca.AutoSize = true;
            this.materialLabelAdreca.Depth = 0;
            this.materialLabelAdreca.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelAdreca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabelAdreca.Location = new System.Drawing.Point(57, 135);
            this.materialLabelAdreca.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelAdreca.Name = "materialLabelAdreca";
            this.materialLabelAdreca.Size = new System.Drawing.Size(56, 19);
            this.materialLabelAdreca.TabIndex = 20;
            this.materialLabelAdreca.Text = "Adreça";
            // 
            // materialLabelNom
            // 
            this.materialLabelNom.AutoSize = true;
            this.materialLabelNom.Depth = 0;
            this.materialLabelNom.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabelNom.Location = new System.Drawing.Point(57, 100);
            this.materialLabelNom.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelNom.Name = "materialLabelNom";
            this.materialLabelNom.Size = new System.Drawing.Size(42, 19);
            this.materialLabelNom.TabIndex = 19;
            this.materialLabelNom.Text = "Nom";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(206, 208);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(96, 20);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel1.Location = new System.Drawing.Point(57, 243);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(87, 19);
            this.materialLabel1.TabIndex = 31;
            this.materialLabel1.Text = "Horari Final";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(206, 243);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(96, 20);
            this.dateTimePicker2.TabIndex = 32;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel2.Location = new System.Drawing.Point(326, 210);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(31, 19);
            this.materialLabel2.TabIndex = 33;
            this.materialLabel2.Text = "Dia";
            // 
            // comboBoxDia
            // 
            this.comboBoxDia.FormattingEnabled = true;
            this.comboBoxDia.Location = new System.Drawing.Point(364, 207);
            this.comboBoxDia.Name = "comboBoxDia";
            this.comboBoxDia.Size = new System.Drawing.Size(103, 21);
            this.comboBoxDia.TabIndex = 34;
            // 
            // Instalaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.comboBoxDia);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxEsport);
            this.Controls.Add(this.materialRaisedButton3);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.materialSingleLineTextFieldAdreca);
            this.Controls.Add(this.materialSingleLineTextFieldTitulo);
            this.Controls.Add(this.materialLabelHorari);
            this.Controls.Add(this.materialLabelTipusGestio);
            this.Controls.Add(this.materialLabelAdreca);
            this.Controls.Add(this.materialLabelNom);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Instalaciones";
            this.Text = "Instalacions";
            this.Activated += new System.EventHandler(this.Instalaciones_Activated);
            this.Load += new System.EventHandler(this.Instalaciones_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInstalaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxEsport;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldAdreca;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldTitulo;
        private MaterialSkin.Controls.MaterialLabel materialLabelHorari;
        private MaterialSkin.Controls.MaterialLabel materialLabelTipusGestio;
        private MaterialSkin.Controls.MaterialLabel materialLabelAdreca;
        private MaterialSkin.Controls.MaterialLabel materialLabelNom;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSourceInstalaciones;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ComboBox comboBoxDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn id_tipo_gestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
    }
}
