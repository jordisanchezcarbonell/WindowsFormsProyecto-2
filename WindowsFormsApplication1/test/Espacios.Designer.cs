namespace COMPLETE_FLAT_UI
{
    partial class Espacios
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
            this.comboBoxEsport = new System.Windows.Forms.ComboBox();
            this.bindingSourceInstalaciones = new System.Windows.Forms.BindingSource(this.components);
            this.materialSingleLineTextFieldAdreca = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.materialLabelExterior = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelPreu = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exteriorDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idinstalacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actconcedidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actdemandadasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instalacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.materialLabelInstalacion = new MaterialSkin.Controls.MaterialLabel();
            this.bindingSourceEspacios = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInstalaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEspacios)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxEsport
            // 
            this.comboBoxEsport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEsport.DataSource = this.bindingSourceInstalaciones;
            this.comboBoxEsport.DisplayMember = "nombre";
            this.comboBoxEsport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEsport.FormattingEnabled = true;
            this.comboBoxEsport.Location = new System.Drawing.Point(169, 84);
            this.comboBoxEsport.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxEsport.Name = "comboBoxEsport";
            this.comboBoxEsport.Size = new System.Drawing.Size(202, 21);
            this.comboBoxEsport.TabIndex = 30;
            this.comboBoxEsport.ValueMember = "id";
            this.comboBoxEsport.SelectedIndexChanged += new System.EventHandler(this.comboBoxEsport_SelectedIndexChanged);
            // 
            // bindingSourceInstalaciones
            // 
            this.bindingSourceInstalaciones.DataSource = typeof(COMPLETE_FLAT_UI.Instalacion);
            // 
            // materialSingleLineTextFieldAdreca
            // 
            this.materialSingleLineTextFieldAdreca.Depth = 0;
            this.materialSingleLineTextFieldAdreca.Hint = "";
            this.materialSingleLineTextFieldAdreca.Location = new System.Drawing.Point(169, 175);
            this.materialSingleLineTextFieldAdreca.MaxLength = 32767;
            this.materialSingleLineTextFieldAdreca.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldAdreca.Name = "materialSingleLineTextFieldAdreca";
            this.materialSingleLineTextFieldAdreca.PasswordChar = '\0';
            this.materialSingleLineTextFieldAdreca.SelectedText = "";
            this.materialSingleLineTextFieldAdreca.SelectionLength = 0;
            this.materialSingleLineTextFieldAdreca.SelectionStart = 0;
            this.materialSingleLineTextFieldAdreca.Size = new System.Drawing.Size(98, 23);
            this.materialSingleLineTextFieldAdreca.TabIndex = 31;
            this.materialSingleLineTextFieldAdreca.TabStop = false;
            this.materialSingleLineTextFieldAdreca.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(169, 128);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(202, 23);
            this.materialSingleLineTextField1.TabIndex = 32;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DisplayMember = "nombre";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(169, 230);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(202, 21);
            this.comboBox1.TabIndex = 33;
            this.comboBox1.ValueMember = "id";
            // 
            // materialLabelExterior
            // 
            this.materialLabelExterior.AutoSize = true;
            this.materialLabelExterior.Depth = 0;
            this.materialLabelExterior.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelExterior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabelExterior.Location = new System.Drawing.Point(70, 232);
            this.materialLabelExterior.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelExterior.Name = "materialLabelExterior";
            this.materialLabelExterior.Size = new System.Drawing.Size(68, 19);
            this.materialLabelExterior.TabIndex = 34;
            this.materialLabelExterior.Text = "Exterior?";
            // 
            // materialLabelPreu
            // 
            this.materialLabelPreu.AutoSize = true;
            this.materialLabelPreu.Depth = 0;
            this.materialLabelPreu.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelPreu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabelPreu.Location = new System.Drawing.Point(70, 179);
            this.materialLabelPreu.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelPreu.Name = "materialLabelPreu";
            this.materialLabelPreu.Size = new System.Drawing.Size(39, 19);
            this.materialLabelPreu.TabIndex = 35;
            this.materialLabelPreu.Text = "Preu";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel2.Location = new System.Drawing.Point(70, 132);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(42, 19);
            this.materialLabel2.TabIndex = 36;
            this.materialLabel2.Text = "Nom";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.exteriorDataGridViewCheckBoxColumn,
            this.idinstalacionDataGridViewTextBoxColumn,
            this.actconcedidaDataGridViewTextBoxColumn,
            this.actdemandadasDataGridViewTextBoxColumn,
            this.instalacionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSourceEspacios;
            this.dataGridView1.Location = new System.Drawing.Point(74, 270);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 275);
            this.dataGridView1.TabIndex = 37;
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
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // exteriorDataGridViewCheckBoxColumn
            // 
            this.exteriorDataGridViewCheckBoxColumn.DataPropertyName = "exterior";
            this.exteriorDataGridViewCheckBoxColumn.HeaderText = "exterior";
            this.exteriorDataGridViewCheckBoxColumn.Name = "exteriorDataGridViewCheckBoxColumn";
            // 
            // idinstalacionDataGridViewTextBoxColumn
            // 
            this.idinstalacionDataGridViewTextBoxColumn.DataPropertyName = "id_instalacion";
            this.idinstalacionDataGridViewTextBoxColumn.HeaderText = "id_instalacion";
            this.idinstalacionDataGridViewTextBoxColumn.Name = "idinstalacionDataGridViewTextBoxColumn";
            // 
            // actconcedidaDataGridViewTextBoxColumn
            // 
            this.actconcedidaDataGridViewTextBoxColumn.DataPropertyName = "Act_concedida";
            this.actconcedidaDataGridViewTextBoxColumn.HeaderText = "Act_concedida";
            this.actconcedidaDataGridViewTextBoxColumn.Name = "actconcedidaDataGridViewTextBoxColumn";
            // 
            // actdemandadasDataGridViewTextBoxColumn
            // 
            this.actdemandadasDataGridViewTextBoxColumn.DataPropertyName = "Act_demandadas";
            this.actdemandadasDataGridViewTextBoxColumn.HeaderText = "Act_demandadas";
            this.actdemandadasDataGridViewTextBoxColumn.Name = "actdemandadasDataGridViewTextBoxColumn";
            // 
            // instalacionDataGridViewTextBoxColumn
            // 
            this.instalacionDataGridViewTextBoxColumn.DataPropertyName = "Instalacion";
            this.instalacionDataGridViewTextBoxColumn.HeaderText = "Instalacion";
            this.instalacionDataGridViewTextBoxColumn.Name = "instalacionDataGridViewTextBoxColumn";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(COMPLETE_FLAT_UI.Espacio);
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // materialLabelInstalacion
            // 
            this.materialLabelInstalacion.AutoSize = true;
            this.materialLabelInstalacion.Depth = 0;
            this.materialLabelInstalacion.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelInstalacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabelInstalacion.Location = new System.Drawing.Point(70, 86);
            this.materialLabelInstalacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelInstalacion.Name = "materialLabelInstalacion";
            this.materialLabelInstalacion.Size = new System.Drawing.Size(83, 19);
            this.materialLabelInstalacion.TabIndex = 38;
            this.materialLabelInstalacion.Text = "Instalacion";
            // 
            // bindingSourceEspacios
            // 
            this.bindingSourceEspacios.DataSource = typeof(COMPLETE_FLAT_UI.Espacio);
            // 
            // Espacios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 557);
            this.Controls.Add(this.materialLabelInstalacion);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabelPreu);
            this.Controls.Add(this.materialLabelExterior);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Controls.Add(this.materialSingleLineTextFieldAdreca);
            this.Controls.Add(this.comboBoxEsport);
            this.Name = "Espacios";
            this.Text = "Espacios";
            this.Load += new System.EventHandler(this.Espacios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInstalaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEspacios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxEsport;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldAdreca;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private System.Windows.Forms.ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabelExterior;
        private MaterialSkin.Controls.MaterialLabel materialLabelPreu;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialLabel materialLabelInstalacion;
        private System.Windows.Forms.BindingSource bindingSourceInstalaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn exteriorDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idinstalacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actconcedidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actdemandadasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instalacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSourceEspacios;
    }
}