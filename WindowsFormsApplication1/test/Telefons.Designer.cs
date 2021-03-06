﻿namespace COMPLETE_FLAT_UI
{
    partial class Telefons
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
            this.materialLabelNom = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelTelefon = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelEntitat = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextFieldTelefon = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextFieldRao = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.comboBoxEntitats = new System.Windows.Forms.ComboBox();
            this.bindingSourceEntitats = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTelefons = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_entidad = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bindingSourceTelefons = new System.Windows.Forms.BindingSource(this.components);
            this.materialRaisedButtonAfegirTelefon = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButtonEsborrarTelefon = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButtonTancar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButtonModificarTelefon = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButtonNetejarCamps = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEntitats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTelefons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTelefons)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabelNom
            // 
            this.materialLabelNom.AutoSize = true;
            this.materialLabelNom.Depth = 0;
            this.materialLabelNom.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabelNom.Location = new System.Drawing.Point(33, 151);
            this.materialLabelNom.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelNom.Name = "materialLabelNom";
            this.materialLabelNom.Size = new System.Drawing.Size(74, 19);
            this.materialLabelNom.TabIndex = 5;
            this.materialLabelNom.Text = "Nom/Raó";
            // 
            // materialLabelTelefon
            // 
            this.materialLabelTelefon.AutoSize = true;
            this.materialLabelTelefon.Depth = 0;
            this.materialLabelTelefon.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelTelefon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabelTelefon.Location = new System.Drawing.Point(32, 112);
            this.materialLabelTelefon.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelTelefon.Name = "materialLabelTelefon";
            this.materialLabelTelefon.Size = new System.Drawing.Size(60, 19);
            this.materialLabelTelefon.TabIndex = 6;
            this.materialLabelTelefon.Text = "Telèfon";
            // 
            // materialLabelEntitat
            // 
            this.materialLabelEntitat.AutoSize = true;
            this.materialLabelEntitat.Depth = 0;
            this.materialLabelEntitat.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelEntitat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabelEntitat.Location = new System.Drawing.Point(33, 195);
            this.materialLabelEntitat.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelEntitat.Name = "materialLabelEntitat";
            this.materialLabelEntitat.Size = new System.Drawing.Size(53, 19);
            this.materialLabelEntitat.TabIndex = 7;
            this.materialLabelEntitat.Text = "Entitat";
            // 
            // materialSingleLineTextFieldTelefon
            // 
            this.materialSingleLineTextFieldTelefon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialSingleLineTextFieldTelefon.Depth = 0;
            this.materialSingleLineTextFieldTelefon.Hint = "";
            this.materialSingleLineTextFieldTelefon.Location = new System.Drawing.Point(125, 108);
            this.materialSingleLineTextFieldTelefon.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldTelefon.Name = "materialSingleLineTextFieldTelefon";
            this.materialSingleLineTextFieldTelefon.PasswordChar = '\0';
            this.materialSingleLineTextFieldTelefon.SelectedText = "";
            this.materialSingleLineTextFieldTelefon.SelectionLength = 0;
            this.materialSingleLineTextFieldTelefon.SelectionStart = 0;
            this.materialSingleLineTextFieldTelefon.Size = new System.Drawing.Size(211, 23);
            this.materialSingleLineTextFieldTelefon.TabIndex = 1;
            this.materialSingleLineTextFieldTelefon.TabStop = false;
            this.materialSingleLineTextFieldTelefon.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextFieldRao
            // 
            this.materialSingleLineTextFieldRao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialSingleLineTextFieldRao.Depth = 0;
            this.materialSingleLineTextFieldRao.Hint = "";
            this.materialSingleLineTextFieldRao.Location = new System.Drawing.Point(125, 147);
            this.materialSingleLineTextFieldRao.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldRao.Name = "materialSingleLineTextFieldRao";
            this.materialSingleLineTextFieldRao.PasswordChar = '\0';
            this.materialSingleLineTextFieldRao.SelectedText = "";
            this.materialSingleLineTextFieldRao.SelectionLength = 0;
            this.materialSingleLineTextFieldRao.SelectionStart = 0;
            this.materialSingleLineTextFieldRao.Size = new System.Drawing.Size(211, 23);
            this.materialSingleLineTextFieldRao.TabIndex = 2;
            this.materialSingleLineTextFieldRao.TabStop = false;
            this.materialSingleLineTextFieldRao.UseSystemPasswordChar = false;
            // 
            // comboBoxEntitats
            // 
            this.comboBoxEntitats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEntitats.DataSource = this.bindingSourceEntitats;
            this.comboBoxEntitats.DisplayMember = "nombre";
            this.comboBoxEntitats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEntitats.FormattingEnabled = true;
            this.comboBoxEntitats.Location = new System.Drawing.Point(125, 196);
            this.comboBoxEntitats.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxEntitats.Name = "comboBoxEntitats";
            this.comboBoxEntitats.Size = new System.Drawing.Size(211, 21);
            this.comboBoxEntitats.TabIndex = 3;
            this.comboBoxEntitats.ValueMember = "id";
            // 
            // bindingSourceEntitats
            // 
            this.bindingSourceEntitats.DataSource = typeof(COMPLETE_FLAT_UI.Entidad);
            // 
            // dataGridViewTelefons
            // 
            this.dataGridViewTelefons.AllowUserToAddRows = false;
            this.dataGridViewTelefons.AllowUserToDeleteRows = false;
            this.dataGridViewTelefons.AutoGenerateColumns = false;
            this.dataGridViewTelefons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTelefons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.razonDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.id_entidad});
            this.dataGridViewTelefons.DataSource = this.bindingSourceTelefons;
            this.dataGridViewTelefons.Location = new System.Drawing.Point(36, 296);
            this.dataGridViewTelefons.Name = "dataGridViewTelefons";
            this.dataGridViewTelefons.ReadOnly = true;
            this.dataGridViewTelefons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTelefons.Size = new System.Drawing.Size(377, 150);
            this.dataGridViewTelefons.TabIndex = 7;
            this.dataGridViewTelefons.SelectionChanged += new System.EventHandler(this.dataGridViewTelefons_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // razonDataGridViewTextBoxColumn
            // 
            this.razonDataGridViewTextBoxColumn.DataPropertyName = "razon";
            this.razonDataGridViewTextBoxColumn.HeaderText = "Raó";
            this.razonDataGridViewTextBoxColumn.Name = "razonDataGridViewTextBoxColumn";
            this.razonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telèfon";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // id_entidad
            // 
            this.id_entidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_entidad.DataPropertyName = "id_entidad";
            this.id_entidad.DataSource = this.bindingSourceEntitats;
            this.id_entidad.DisplayMember = "nombre";
            this.id_entidad.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.id_entidad.HeaderText = "Entitat";
            this.id_entidad.Name = "id_entidad";
            this.id_entidad.ReadOnly = true;
            this.id_entidad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id_entidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.id_entidad.ValueMember = "id";
            // 
            // bindingSourceTelefons
            // 
            this.bindingSourceTelefons.DataSource = typeof(COMPLETE_FLAT_UI.Telefonos);
            // 
            // materialRaisedButtonAfegirTelefon
            // 
            this.materialRaisedButtonAfegirTelefon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButtonAfegirTelefon.AutoSize = true;
            this.materialRaisedButtonAfegirTelefon.Depth = 0;
            this.materialRaisedButtonAfegirTelefon.Location = new System.Drawing.Point(96, 245);
            this.materialRaisedButtonAfegirTelefon.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonAfegirTelefon.Name = "materialRaisedButtonAfegirTelefon";
            this.materialRaisedButtonAfegirTelefon.Primary = true;
            this.materialRaisedButtonAfegirTelefon.Size = new System.Drawing.Size(67, 36);
            this.materialRaisedButtonAfegirTelefon.TabIndex = 4;
            this.materialRaisedButtonAfegirTelefon.Text = "Afegir";
            this.materialRaisedButtonAfegirTelefon.UseVisualStyleBackColor = true;
            this.materialRaisedButtonAfegirTelefon.Click += new System.EventHandler(this.materialRaisedButtonAfegirTelefon_Click);
            // 
            // materialRaisedButtonEsborrarTelefon
            // 
            this.materialRaisedButtonEsborrarTelefon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButtonEsborrarTelefon.AutoSize = true;
            this.materialRaisedButtonEsborrarTelefon.Depth = 0;
            this.materialRaisedButtonEsborrarTelefon.Location = new System.Drawing.Point(295, 245);
            this.materialRaisedButtonEsborrarTelefon.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonEsborrarTelefon.Name = "materialRaisedButtonEsborrarTelefon";
            this.materialRaisedButtonEsborrarTelefon.Primary = true;
            this.materialRaisedButtonEsborrarTelefon.Size = new System.Drawing.Size(90, 36);
            this.materialRaisedButtonEsborrarTelefon.TabIndex = 6;
            this.materialRaisedButtonEsborrarTelefon.Text = "Esborrar";
            this.materialRaisedButtonEsborrarTelefon.UseVisualStyleBackColor = true;
            this.materialRaisedButtonEsborrarTelefon.Click += new System.EventHandler(this.materialRaisedButtonEsborrarTelefon_Click);
            // 
            // materialRaisedButtonTancar
            // 
            this.materialRaisedButtonTancar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButtonTancar.Depth = 0;
            this.materialRaisedButtonTancar.Location = new System.Drawing.Point(343, 452);
            this.materialRaisedButtonTancar.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonTancar.Name = "materialRaisedButtonTancar";
            this.materialRaisedButtonTancar.Primary = true;
            this.materialRaisedButtonTancar.Size = new System.Drawing.Size(65, 37);
            this.materialRaisedButtonTancar.TabIndex = 8;
            this.materialRaisedButtonTancar.Text = "Tancar";
            this.materialRaisedButtonTancar.UseVisualStyleBackColor = true;
            this.materialRaisedButtonTancar.Click += new System.EventHandler(this.materialRaisedButtonTancar_Click);
            // 
            // materialRaisedButtonModificarTelefon
            // 
            this.materialRaisedButtonModificarTelefon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButtonModificarTelefon.AutoSize = true;
            this.materialRaisedButtonModificarTelefon.Depth = 0;
            this.materialRaisedButtonModificarTelefon.Location = new System.Drawing.Point(182, 245);
            this.materialRaisedButtonModificarTelefon.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonModificarTelefon.Name = "materialRaisedButtonModificarTelefon";
            this.materialRaisedButtonModificarTelefon.Primary = true;
            this.materialRaisedButtonModificarTelefon.Size = new System.Drawing.Size(93, 36);
            this.materialRaisedButtonModificarTelefon.TabIndex = 5;
            this.materialRaisedButtonModificarTelefon.Text = "Modificar";
            this.materialRaisedButtonModificarTelefon.UseVisualStyleBackColor = true;
            this.materialRaisedButtonModificarTelefon.Click += new System.EventHandler(this.materialRaisedButtonModificarTelefon_Click);
            // 
            // materialRaisedButtonNetejarCamps
            // 
            this.materialRaisedButtonNetejarCamps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButtonNetejarCamps.AutoSize = true;
            this.materialRaisedButtonNetejarCamps.Depth = 0;
            this.materialRaisedButtonNetejarCamps.Location = new System.Drawing.Point(353, 143);
            this.materialRaisedButtonNetejarCamps.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonNetejarCamps.Name = "materialRaisedButtonNetejarCamps";
            this.materialRaisedButtonNetejarCamps.Primary = true;
            this.materialRaisedButtonNetejarCamps.Size = new System.Drawing.Size(80, 36);
            this.materialRaisedButtonNetejarCamps.TabIndex = 12;
            this.materialRaisedButtonNetejarCamps.Text = "Netejar";
            this.materialRaisedButtonNetejarCamps.UseVisualStyleBackColor = true;
            this.materialRaisedButtonNetejarCamps.Click += new System.EventHandler(this.materialRaisedButtonNetejarCamps_Click);
            // 
            // Telefons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 501);
            this.Controls.Add(this.materialRaisedButtonNetejarCamps);
            this.Controls.Add(this.materialRaisedButtonModificarTelefon);
            this.Controls.Add(this.materialRaisedButtonTancar);
            this.Controls.Add(this.materialRaisedButtonEsborrarTelefon);
            this.Controls.Add(this.materialRaisedButtonAfegirTelefon);
            this.Controls.Add(this.dataGridViewTelefons);
            this.Controls.Add(this.comboBoxEntitats);
            this.Controls.Add(this.materialSingleLineTextFieldRao);
            this.Controls.Add(this.materialSingleLineTextFieldTelefon);
            this.Controls.Add(this.materialLabelEntitat);
            this.Controls.Add(this.materialLabelTelefon);
            this.Controls.Add(this.materialLabelNom);
            this.Name = "Telefons";
            this.Text = "Telèfons";
            this.Load += new System.EventHandler(this.Telefons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEntitats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTelefons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTelefons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabelNom;
        private MaterialSkin.Controls.MaterialLabel materialLabelTelefon;
        private MaterialSkin.Controls.MaterialLabel materialLabelEntitat;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldTelefon;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldRao;
        private System.Windows.Forms.ComboBox comboBoxEntitats;
        private System.Windows.Forms.DataGridView dataGridViewTelefons;
        private System.Windows.Forms.BindingSource bindingSourceTelefons;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonAfegirTelefon;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonEsborrarTelefon;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonTancar;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonModificarTelefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn entidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn identidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSourceEntitats;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonNetejarCamps;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn id_entidad;
    }
}