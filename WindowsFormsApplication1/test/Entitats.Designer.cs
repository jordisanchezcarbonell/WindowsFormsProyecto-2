namespace COMPLETE_FLAT_UI
{
    partial class Entitats
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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.materialLabelNom = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelTemporada = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelAdreca = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelNif = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelCorreo = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridViewDadesEntitats = new System.Windows.Forms.DataGridView();
            this.materialSingleLineTextFieldNom = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextFieldTemporada = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextFieldAdreca = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextFieldNif = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextFieldCorreo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButtonAfegir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButtonModificar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButtonEsborrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButtonVeureEquips = new MaterialSkin.Controls.MaterialRaisedButton();
            this.bindingSourceEntitats = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temporadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDadesEntitats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEntitats)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabelNom
            // 
            this.materialLabelNom.AutoSize = true;
            this.materialLabelNom.Depth = 0;
            this.materialLabelNom.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabelNom.Location = new System.Drawing.Point(99, 102);
            this.materialLabelNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabelNom.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelNom.Name = "materialLabelNom";
            this.materialLabelNom.Size = new System.Drawing.Size(52, 24);
            this.materialLabelNom.TabIndex = 0;
            this.materialLabelNom.Text = "Nom";
            // 
            // materialLabelTemporada
            // 
            this.materialLabelTemporada.AutoSize = true;
            this.materialLabelTemporada.Depth = 0;
            this.materialLabelTemporada.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelTemporada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabelTemporada.Location = new System.Drawing.Point(99, 139);
            this.materialLabelTemporada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabelTemporada.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelTemporada.Name = "materialLabelTemporada";
            this.materialLabelTemporada.Size = new System.Drawing.Size(107, 24);
            this.materialLabelTemporada.TabIndex = 1;
            this.materialLabelTemporada.Text = "Temporada";
            // 
            // materialLabelAdreca
            // 
            this.materialLabelAdreca.AutoSize = true;
            this.materialLabelAdreca.Depth = 0;
            this.materialLabelAdreca.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelAdreca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabelAdreca.Location = new System.Drawing.Point(99, 181);
            this.materialLabelAdreca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabelAdreca.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelAdreca.Name = "materialLabelAdreca";
            this.materialLabelAdreca.Size = new System.Drawing.Size(69, 24);
            this.materialLabelAdreca.TabIndex = 2;
            this.materialLabelAdreca.Text = "Adreça";
            // 
            // materialLabelNif
            // 
            this.materialLabelNif.AutoSize = true;
            this.materialLabelNif.Depth = 0;
            this.materialLabelNif.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelNif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabelNif.Location = new System.Drawing.Point(99, 223);
            this.materialLabelNif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabelNif.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelNif.Name = "materialLabelNif";
            this.materialLabelNif.Size = new System.Drawing.Size(36, 24);
            this.materialLabelNif.TabIndex = 3;
            this.materialLabelNif.Text = "Nif";
            // 
            // materialLabelCorreo
            // 
            this.materialLabelCorreo.AutoSize = true;
            this.materialLabelCorreo.Depth = 0;
            this.materialLabelCorreo.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabelCorreo.Location = new System.Drawing.Point(104, 262);
            this.materialLabelCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabelCorreo.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelCorreo.Name = "materialLabelCorreo";
            this.materialLabelCorreo.Size = new System.Drawing.Size(66, 24);
            this.materialLabelCorreo.TabIndex = 4;
            this.materialLabelCorreo.Text = "Correo";
            // 
            // dataGridViewDadesEntitats
            // 
            this.dataGridViewDadesEntitats.AllowUserToAddRows = false;
            this.dataGridViewDadesEntitats.AllowUserToDeleteRows = false;
            this.dataGridViewDadesEntitats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDadesEntitats.AutoGenerateColumns = false;
            this.dataGridViewDadesEntitats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDadesEntitats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.temporadaDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.nifDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn});
            this.dataGridViewDadesEntitats.DataSource = this.bindingSourceEntitats;
            this.dataGridViewDadesEntitats.Location = new System.Drawing.Point(108, 312);
            this.dataGridViewDadesEntitats.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewDadesEntitats.Name = "dataGridViewDadesEntitats";
            this.dataGridViewDadesEntitats.ReadOnly = true;
            this.dataGridViewDadesEntitats.Size = new System.Drawing.Size(861, 217);
            this.dataGridViewDadesEntitats.TabIndex = 5;
            // 
            // materialSingleLineTextFieldNom
            // 
            this.materialSingleLineTextFieldNom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialSingleLineTextFieldNom.Depth = 0;
            this.materialSingleLineTextFieldNom.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.materialSingleLineTextFieldNom.Hint = "";
            this.materialSingleLineTextFieldNom.Location = new System.Drawing.Point(267, 96);
            this.materialSingleLineTextFieldNom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.materialSingleLineTextFieldNom.MaxLength = 32767;
            this.materialSingleLineTextFieldNom.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldNom.Name = "materialSingleLineTextFieldNom";
            this.materialSingleLineTextFieldNom.PasswordChar = '\0';
            this.materialSingleLineTextFieldNom.SelectedText = "";
            this.materialSingleLineTextFieldNom.SelectionLength = 0;
            this.materialSingleLineTextFieldNom.SelectionStart = 0;
            this.materialSingleLineTextFieldNom.Size = new System.Drawing.Size(437, 28);
            this.materialSingleLineTextFieldNom.TabIndex = 6;
            this.materialSingleLineTextFieldNom.TabStop = false;
            this.materialSingleLineTextFieldNom.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextFieldTemporada
            // 
            this.materialSingleLineTextFieldTemporada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialSingleLineTextFieldTemporada.Depth = 0;
            this.materialSingleLineTextFieldTemporada.Hint = "";
            this.materialSingleLineTextFieldTemporada.Location = new System.Drawing.Point(267, 133);
            this.materialSingleLineTextFieldTemporada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.materialSingleLineTextFieldTemporada.MaxLength = 32767;
            this.materialSingleLineTextFieldTemporada.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldTemporada.Name = "materialSingleLineTextFieldTemporada";
            this.materialSingleLineTextFieldTemporada.PasswordChar = '\0';
            this.materialSingleLineTextFieldTemporada.SelectedText = "";
            this.materialSingleLineTextFieldTemporada.SelectionLength = 0;
            this.materialSingleLineTextFieldTemporada.SelectionStart = 0;
            this.materialSingleLineTextFieldTemporada.Size = new System.Drawing.Size(437, 28);
            this.materialSingleLineTextFieldTemporada.TabIndex = 7;
            this.materialSingleLineTextFieldTemporada.TabStop = false;
            this.materialSingleLineTextFieldTemporada.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextFieldAdreca
            // 
            this.materialSingleLineTextFieldAdreca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialSingleLineTextFieldAdreca.Depth = 0;
            this.materialSingleLineTextFieldAdreca.Hint = "";
            this.materialSingleLineTextFieldAdreca.Location = new System.Drawing.Point(267, 181);
            this.materialSingleLineTextFieldAdreca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.materialSingleLineTextFieldAdreca.MaxLength = 32767;
            this.materialSingleLineTextFieldAdreca.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldAdreca.Name = "materialSingleLineTextFieldAdreca";
            this.materialSingleLineTextFieldAdreca.PasswordChar = '\0';
            this.materialSingleLineTextFieldAdreca.SelectedText = "";
            this.materialSingleLineTextFieldAdreca.SelectionLength = 0;
            this.materialSingleLineTextFieldAdreca.SelectionStart = 0;
            this.materialSingleLineTextFieldAdreca.Size = new System.Drawing.Size(437, 28);
            this.materialSingleLineTextFieldAdreca.TabIndex = 8;
            this.materialSingleLineTextFieldAdreca.TabStop = false;
            this.materialSingleLineTextFieldAdreca.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextFieldNif
            // 
            this.materialSingleLineTextFieldNif.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialSingleLineTextFieldNif.Depth = 0;
            this.materialSingleLineTextFieldNif.Hint = "";
            this.materialSingleLineTextFieldNif.Location = new System.Drawing.Point(267, 217);
            this.materialSingleLineTextFieldNif.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.materialSingleLineTextFieldNif.MaxLength = 32767;
            this.materialSingleLineTextFieldNif.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldNif.Name = "materialSingleLineTextFieldNif";
            this.materialSingleLineTextFieldNif.PasswordChar = '\0';
            this.materialSingleLineTextFieldNif.SelectedText = "";
            this.materialSingleLineTextFieldNif.SelectionLength = 0;
            this.materialSingleLineTextFieldNif.SelectionStart = 0;
            this.materialSingleLineTextFieldNif.Size = new System.Drawing.Size(437, 28);
            this.materialSingleLineTextFieldNif.TabIndex = 9;
            this.materialSingleLineTextFieldNif.TabStop = false;
            this.materialSingleLineTextFieldNif.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextFieldCorreo
            // 
            this.materialSingleLineTextFieldCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialSingleLineTextFieldCorreo.Depth = 0;
            this.materialSingleLineTextFieldCorreo.Hint = "";
            this.materialSingleLineTextFieldCorreo.Location = new System.Drawing.Point(267, 262);
            this.materialSingleLineTextFieldCorreo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.materialSingleLineTextFieldCorreo.MaxLength = 32767;
            this.materialSingleLineTextFieldCorreo.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldCorreo.Name = "materialSingleLineTextFieldCorreo";
            this.materialSingleLineTextFieldCorreo.PasswordChar = '\0';
            this.materialSingleLineTextFieldCorreo.SelectedText = "";
            this.materialSingleLineTextFieldCorreo.SelectionLength = 0;
            this.materialSingleLineTextFieldCorreo.SelectionStart = 0;
            this.materialSingleLineTextFieldCorreo.Size = new System.Drawing.Size(437, 28);
            this.materialSingleLineTextFieldCorreo.TabIndex = 10;
            this.materialSingleLineTextFieldCorreo.TabStop = false;
            this.materialSingleLineTextFieldCorreo.UseSystemPasswordChar = false;
            // 
            // materialRaisedButtonAfegir
            // 
            this.materialRaisedButtonAfegir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButtonAfegir.AutoSize = true;
            this.materialRaisedButtonAfegir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButtonAfegir.Depth = 0;
            this.materialRaisedButtonAfegir.Icon = null;
            this.materialRaisedButtonAfegir.Location = new System.Drawing.Point(804, 102);
            this.materialRaisedButtonAfegir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.materialRaisedButtonAfegir.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonAfegir.Name = "materialRaisedButtonAfegir";
            this.materialRaisedButtonAfegir.Primary = true;
            this.materialRaisedButtonAfegir.Size = new System.Drawing.Size(80, 36);
            this.materialRaisedButtonAfegir.TabIndex = 11;
            this.materialRaisedButtonAfegir.Text = "Afegir";
            this.materialRaisedButtonAfegir.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButtonModificar
            // 
            this.materialRaisedButtonModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButtonModificar.AutoSize = true;
            this.materialRaisedButtonModificar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButtonModificar.Depth = 0;
            this.materialRaisedButtonModificar.Icon = null;
            this.materialRaisedButtonModificar.Location = new System.Drawing.Point(815, 158);
            this.materialRaisedButtonModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.materialRaisedButtonModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonModificar.Name = "materialRaisedButtonModificar";
            this.materialRaisedButtonModificar.Primary = true;
            this.materialRaisedButtonModificar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialRaisedButtonModificar.Size = new System.Drawing.Size(113, 36);
            this.materialRaisedButtonModificar.TabIndex = 12;
            this.materialRaisedButtonModificar.Text = "Modificar";
            this.materialRaisedButtonModificar.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButtonEsborrar
            // 
            this.materialRaisedButtonEsborrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButtonEsborrar.AutoSize = true;
            this.materialRaisedButtonEsborrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButtonEsborrar.Depth = 0;
            this.materialRaisedButtonEsborrar.Icon = null;
            this.materialRaisedButtonEsborrar.Location = new System.Drawing.Point(813, 217);
            this.materialRaisedButtonEsborrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.materialRaisedButtonEsborrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonEsborrar.Name = "materialRaisedButtonEsborrar";
            this.materialRaisedButtonEsborrar.Primary = true;
            this.materialRaisedButtonEsborrar.Size = new System.Drawing.Size(108, 36);
            this.materialRaisedButtonEsborrar.TabIndex = 13;
            this.materialRaisedButtonEsborrar.Text = "Esborrar";
            this.materialRaisedButtonEsborrar.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButtonVeureEquips
            // 
            this.materialRaisedButtonVeureEquips.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButtonVeureEquips.AutoSize = true;
            this.materialRaisedButtonVeureEquips.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButtonVeureEquips.Depth = 0;
            this.materialRaisedButtonVeureEquips.Icon = null;
            this.materialRaisedButtonVeureEquips.Location = new System.Drawing.Point(823, 556);
            this.materialRaisedButtonVeureEquips.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.materialRaisedButtonVeureEquips.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonVeureEquips.Name = "materialRaisedButtonVeureEquips";
            this.materialRaisedButtonVeureEquips.Primary = true;
            this.materialRaisedButtonVeureEquips.Size = new System.Drawing.Size(138, 36);
            this.materialRaisedButtonVeureEquips.TabIndex = 14;
            this.materialRaisedButtonVeureEquips.Text = "Veure equips";
            this.materialRaisedButtonVeureEquips.UseVisualStyleBackColor = true;
            // 
            // bindingSourceEntitats
            // 
            this.bindingSourceEntitats.DataSource = typeof(COMPLETE_FLAT_UI.Entidad);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // temporadaDataGridViewTextBoxColumn
            // 
            this.temporadaDataGridViewTextBoxColumn.DataPropertyName = "temporada";
            this.temporadaDataGridViewTextBoxColumn.HeaderText = "temporada";
            this.temporadaDataGridViewTextBoxColumn.Name = "temporadaDataGridViewTextBoxColumn";
            this.temporadaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nifDataGridViewTextBoxColumn
            // 
            this.nifDataGridViewTextBoxColumn.DataPropertyName = "nif";
            this.nifDataGridViewTextBoxColumn.HeaderText = "nif";
            this.nifDataGridViewTextBoxColumn.Name = "nifDataGridViewTextBoxColumn";
            this.nifDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "correo";
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            this.correoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Entitats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 598);
            this.Controls.Add(this.materialRaisedButtonVeureEquips);
            this.Controls.Add(this.materialRaisedButtonEsborrar);
            this.Controls.Add(this.materialRaisedButtonModificar);
            this.Controls.Add(this.materialRaisedButtonAfegir);
            this.Controls.Add(this.materialSingleLineTextFieldCorreo);
            this.Controls.Add(this.materialSingleLineTextFieldNif);
            this.Controls.Add(this.materialSingleLineTextFieldAdreca);
            this.Controls.Add(this.materialSingleLineTextFieldTemporada);
            this.Controls.Add(this.materialSingleLineTextFieldNom);
            this.Controls.Add(this.dataGridViewDadesEntitats);
            this.Controls.Add(this.materialLabelCorreo);
            this.Controls.Add(this.materialLabelNif);
            this.Controls.Add(this.materialLabelAdreca);
            this.Controls.Add(this.materialLabelTemporada);
            this.Controls.Add(this.materialLabelNom);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Entitats";
            this.Text = "Entitats";
            this.Load += new System.EventHandler(this.Entitats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDadesEntitats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEntitats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabelNom;
        private MaterialSkin.Controls.MaterialLabel materialLabelTemporada;
        private MaterialSkin.Controls.MaterialLabel materialLabelAdreca;
        private MaterialSkin.Controls.MaterialLabel materialLabelNif;
        private MaterialSkin.Controls.MaterialLabel materialLabelCorreo;
        private System.Windows.Forms.DataGridView dataGridViewDadesEntitats;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldNom;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldTemporada;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldAdreca;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldNif;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldCorreo;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonAfegir;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonModificar;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonEsborrar;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonVeureEquips;
        private System.Windows.Forms.BindingSource bindingSourceEntitats;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temporadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
    }

}

