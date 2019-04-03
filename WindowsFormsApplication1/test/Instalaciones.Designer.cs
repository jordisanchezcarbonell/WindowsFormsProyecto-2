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
            this.dataGridViewInstalaciones = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_tipo_gestion = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bindingSourceTipoGestion = new System.Windows.Forms.BindingSource(this.components);
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceInstalaciones = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxEsport = new System.Windows.Forms.ComboBox();
            this.materialRaisedButtonBorrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButtonModificar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButtonAgregar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialSingleLineTextFieldAdreca = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextFieldNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabelTipusGestio = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelAdreca = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelNom = new MaterialSkin.Controls.MaterialLabel();
            this.bindingSourceDiasSemana = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInstalaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipoGestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInstalaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDiasSemana)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInstalaciones
            // 
            this.dataGridViewInstalaciones.AllowUserToAddRows = false;
            this.dataGridViewInstalaciones.AllowUserToDeleteRows = false;
            this.dataGridViewInstalaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewInstalaciones.AutoGenerateColumns = false;
            this.dataGridViewInstalaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInstalaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.id_tipo_gestion,
            this.direccion});
            this.dataGridViewInstalaciones.DataSource = this.bindingSourceInstalaciones;
            this.dataGridViewInstalaciones.Location = new System.Drawing.Point(54, 265);
            this.dataGridViewInstalaciones.Name = "dataGridViewInstalaciones";
            this.dataGridViewInstalaciones.Size = new System.Drawing.Size(706, 209);
            this.dataGridViewInstalaciones.TabIndex = 12;
            this.dataGridViewInstalaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridViewInstalaciones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInstalaciones_CellDoubleClick);
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
            this.id_tipo_gestion.DataSource = this.bindingSourceTipoGestion;
            this.id_tipo_gestion.DisplayMember = "nombre";
            this.id_tipo_gestion.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.id_tipo_gestion.HeaderText = "id_tipo_gestion";
            this.id_tipo_gestion.Name = "id_tipo_gestion";
            this.id_tipo_gestion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id_tipo_gestion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.id_tipo_gestion.ValueMember = "id";
            // 
            // bindingSourceTipoGestion
            // 
            this.bindingSourceTipoGestion.DataSource = typeof(Tipo_gestion);
            this.bindingSourceTipoGestion.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "direccion";
            this.direccion.Name = "direccion";
            // 
            // bindingSourceInstalaciones
            // 
            this.bindingSourceInstalaciones.DataSource = typeof(Instalacion);
            // 
            // comboBoxEsport
            // 
            this.comboBoxEsport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEsport.DataSource = this.bindingSourceTipoGestion;
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
            // materialRaisedButtonBorrar
            // 
            this.materialRaisedButtonBorrar.AutoSize = true;
            this.materialRaisedButtonBorrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButtonBorrar.Depth = 0;
            this.materialRaisedButtonBorrar.Icon = null;
            this.materialRaisedButtonBorrar.Location = new System.Drawing.Point(626, 211);
            this.materialRaisedButtonBorrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonBorrar.Name = "materialRaisedButtonBorrar";
            this.materialRaisedButtonBorrar.Primary = true;
            this.materialRaisedButtonBorrar.Size = new System.Drawing.Size(65, 36);
            this.materialRaisedButtonBorrar.TabIndex = 28;
            this.materialRaisedButtonBorrar.Text = "Borra";
            this.materialRaisedButtonBorrar.UseVisualStyleBackColor = true;
            this.materialRaisedButtonBorrar.Click += new System.EventHandler(this.materialRaisedButtonBorrar_Click);
            // 
            // materialRaisedButtonModificar
            // 
            this.materialRaisedButtonModificar.AutoSize = true;
            this.materialRaisedButtonModificar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButtonModificar.Depth = 0;
            this.materialRaisedButtonModificar.Icon = null;
            this.materialRaisedButtonModificar.Location = new System.Drawing.Point(626, 155);
            this.materialRaisedButtonModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonModificar.Name = "materialRaisedButtonModificar";
            this.materialRaisedButtonModificar.Primary = true;
            this.materialRaisedButtonModificar.Size = new System.Drawing.Size(85, 36);
            this.materialRaisedButtonModificar.TabIndex = 27;
            this.materialRaisedButtonModificar.Text = "Modifica";
            this.materialRaisedButtonModificar.UseVisualStyleBackColor = true;
            this.materialRaisedButtonModificar.Click += new System.EventHandler(this.materialRaisedButtonModificar_Click);
            // 
            // materialRaisedButtonAgregar
            // 
            this.materialRaisedButtonAgregar.AutoSize = true;
            this.materialRaisedButtonAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButtonAgregar.Depth = 0;
            this.materialRaisedButtonAgregar.Icon = null;
            this.materialRaisedButtonAgregar.Location = new System.Drawing.Point(628, 103);
            this.materialRaisedButtonAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonAgregar.Name = "materialRaisedButtonAgregar";
            this.materialRaisedButtonAgregar.Primary = true;
            this.materialRaisedButtonAgregar.Size = new System.Drawing.Size(83, 36);
            this.materialRaisedButtonAgregar.TabIndex = 26;
            this.materialRaisedButtonAgregar.Text = "Agregar";
            this.materialRaisedButtonAgregar.UseVisualStyleBackColor = true;
            this.materialRaisedButtonAgregar.Click += new System.EventHandler(this.materialRaisedButtonAgregar_Click);
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
            // materialSingleLineTextFieldNombre
            // 
            this.materialSingleLineTextFieldNombre.Depth = 0;
            this.materialSingleLineTextFieldNombre.Hint = "";
            this.materialSingleLineTextFieldNombre.Location = new System.Drawing.Point(206, 100);
            this.materialSingleLineTextFieldNombre.MaxLength = 32767;
            this.materialSingleLineTextFieldNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldNombre.Name = "materialSingleLineTextFieldNombre";
            this.materialSingleLineTextFieldNombre.PasswordChar = '\0';
            this.materialSingleLineTextFieldNombre.SelectedText = "";
            this.materialSingleLineTextFieldNombre.SelectionLength = 0;
            this.materialSingleLineTextFieldNombre.SelectionStart = 0;
            this.materialSingleLineTextFieldNombre.Size = new System.Drawing.Size(200, 23);
            this.materialSingleLineTextFieldNombre.TabIndex = 23;
            this.materialSingleLineTextFieldNombre.TabStop = false;
            this.materialSingleLineTextFieldNombre.UseSystemPasswordChar = false;
            this.materialSingleLineTextFieldNombre.Click += new System.EventHandler(this.materialSingleLineTextFieldTitulo_Click);
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
            // bindingSourceDiasSemana
            // 
            this.bindingSourceDiasSemana.DataSource = typeof(COMPLETE_FLAT_UI.Dias_Semana);
            // 
            // Instalaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.comboBoxEsport);
            this.Controls.Add(this.materialRaisedButtonBorrar);
            this.Controls.Add(this.materialRaisedButtonModificar);
            this.Controls.Add(this.materialRaisedButtonAgregar);
            this.Controls.Add(this.materialSingleLineTextFieldAdreca);
            this.Controls.Add(this.materialSingleLineTextFieldNombre);
            this.Controls.Add(this.materialLabelTipusGestio);
            this.Controls.Add(this.materialLabelAdreca);
            this.Controls.Add(this.materialLabelNom);
            this.Controls.Add(this.dataGridViewInstalaciones);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Instalaciones";
            this.Text = "Instalacions";
            this.Activated += new System.EventHandler(this.Instalaciones_Activated);
            this.Load += new System.EventHandler(this.Instalaciones_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInstalaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipoGestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInstalaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDiasSemana)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewInstalaciones;
        private System.Windows.Forms.ComboBox comboBoxEsport;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonBorrar;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonModificar;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonAgregar;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldAdreca;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldNombre;
        private MaterialSkin.Controls.MaterialLabel materialLabelTipusGestio;
        private MaterialSkin.Controls.MaterialLabel materialLabelAdreca;
        private MaterialSkin.Controls.MaterialLabel materialLabelNom;
        private System.Windows.Forms.BindingSource bindingSourceTipoGestion;
        private System.Windows.Forms.BindingSource bindingSourceInstalaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn id_tipo_gestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.BindingSource bindingSourceDiasSemana;
    }
}
