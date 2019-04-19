namespace COMPLETE_FLAT_UI
{
    partial class Exportacion_Resumen
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
            this.bindingSourceEq = new System.Windows.Forms.BindingSource(this.components);
            this.Entidad = new System.Windows.Forms.CheckBox();
            this.tipuscompeticio = new System.Windows.Forms.CheckBox();
            this.dataGridViewEquips = new System.Windows.Forms.DataGridView();
            this.Act_concedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Act_demandadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria_edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Competicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deportes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contrasenyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temporadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourcetest = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceEntitat = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceEquips = new System.Windows.Forms.BindingSource(this.components);
            this.materialRaisedButtonTesT = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Equips = new System.Windows.Forms.CheckBox();
            this.bindingSourceTipusCompeticio = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceCatXedat = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquips)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcetest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEntitat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEquips)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipusCompeticio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCatXedat)).BeginInit();
            this.SuspendLayout();
            // 
            // Entidad
            // 
            this.Entidad.AutoSize = true;
            this.Entidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entidad.ForeColor = System.Drawing.SystemColors.Window;
            this.Entidad.Location = new System.Drawing.Point(307, 160);
            this.Entidad.Name = "Entidad";
            this.Entidad.Size = new System.Drawing.Size(90, 26);
            this.Entidad.TabIndex = 29;
            this.Entidad.Text = "Entidad";
            this.Entidad.UseVisualStyleBackColor = true;
            this.Entidad.CheckedChanged += new System.EventHandler(this.Entidad_CheckedChanged);
            // 
            // tipuscompeticio
            // 
            this.tipuscompeticio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipuscompeticio.ForeColor = System.Drawing.Color.White;
            this.tipuscompeticio.Location = new System.Drawing.Point(555, 143);
            this.tipuscompeticio.Name = "tipuscompeticio";
            this.tipuscompeticio.Size = new System.Drawing.Size(136, 51);
            this.tipuscompeticio.TabIndex = 28;
            this.tipuscompeticio.Text = " Entitats";
            this.tipuscompeticio.UseVisualStyleBackColor = true;
            this.tipuscompeticio.CheckedChanged += new System.EventHandler(this.tipuscompeticio_CheckedChanged);
            // 
            // dataGridViewEquips
            // 
            this.dataGridViewEquips.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEquips.AutoGenerateColumns = false;
            this.dataGridViewEquips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEquips.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Act_concedida,
            this.Act_demandadas,
            this.Categoria,
            this.Categoria_edad,
            this.Competicion,
            this.Deportes,
            this.Sexo,
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.contrasenyaDataGridViewTextBoxColumn,
            this.temporadaDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.nifDataGridViewTextBoxColumn,
            this.equipoDataGridViewTextBoxColumn,
            this.telefonosDataGridViewTextBoxColumn});
            this.dataGridViewEquips.DataSource = this.bindingSourcetest;
            this.dataGridViewEquips.Location = new System.Drawing.Point(54, 270);
            this.dataGridViewEquips.Name = "dataGridViewEquips";
            this.dataGridViewEquips.Size = new System.Drawing.Size(622, 187);
            this.dataGridViewEquips.TabIndex = 26;
            // 
            // Act_concedida
            // 
            this.Act_concedida.DataPropertyName = "Act_concedida";
            this.Act_concedida.HeaderText = "Act_concedida";
            this.Act_concedida.Name = "Act_concedida";
            // 
            // Act_demandadas
            // 
            this.Act_demandadas.DataPropertyName = "Act_demandadas";
            this.Act_demandadas.HeaderText = "Act_demandadas";
            this.Act_demandadas.Name = "Act_demandadas";
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "Categoria";
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            // 
            // Categoria_edad
            // 
            this.Categoria_edad.DataPropertyName = "Categoria_edad";
            this.Categoria_edad.HeaderText = "Categoria_edad";
            this.Categoria_edad.Name = "Categoria_edad";
            // 
            // Competicion
            // 
            this.Competicion.DataPropertyName = "Competicion";
            this.Competicion.HeaderText = "Competicion";
            this.Competicion.Name = "Competicion";
            // 
            // Deportes
            // 
            this.Deportes.DataPropertyName = "Deportes";
            this.Deportes.HeaderText = "Deportes";
            this.Deportes.Name = "Deportes";
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "Sexo";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "correo";
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            // 
            // contrasenyaDataGridViewTextBoxColumn
            // 
            this.contrasenyaDataGridViewTextBoxColumn.DataPropertyName = "contrasenya";
            this.contrasenyaDataGridViewTextBoxColumn.HeaderText = "contrasenya";
            this.contrasenyaDataGridViewTextBoxColumn.Name = "contrasenyaDataGridViewTextBoxColumn";
            // 
            // temporadaDataGridViewTextBoxColumn
            // 
            this.temporadaDataGridViewTextBoxColumn.DataPropertyName = "temporada";
            this.temporadaDataGridViewTextBoxColumn.HeaderText = "temporada";
            this.temporadaDataGridViewTextBoxColumn.Name = "temporadaDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // nifDataGridViewTextBoxColumn
            // 
            this.nifDataGridViewTextBoxColumn.DataPropertyName = "nif";
            this.nifDataGridViewTextBoxColumn.HeaderText = "nif";
            this.nifDataGridViewTextBoxColumn.Name = "nifDataGridViewTextBoxColumn";
            // 
            // equipoDataGridViewTextBoxColumn
            // 
            this.equipoDataGridViewTextBoxColumn.DataPropertyName = "Equipo";
            this.equipoDataGridViewTextBoxColumn.HeaderText = "Equipo";
            this.equipoDataGridViewTextBoxColumn.Name = "equipoDataGridViewTextBoxColumn";
            // 
            // telefonosDataGridViewTextBoxColumn
            // 
            this.telefonosDataGridViewTextBoxColumn.DataPropertyName = "Telefonos";
            this.telefonosDataGridViewTextBoxColumn.HeaderText = "Telefonos";
            this.telefonosDataGridViewTextBoxColumn.Name = "telefonosDataGridViewTextBoxColumn";
            // 
            // bindingSourcetest
            // 
            this.bindingSourcetest.DataSource = typeof(COMPLETE_FLAT_UI.Entidad);
            // 
            // bindingSourceEntitat
            // 
            this.bindingSourceEntitat.DataSource = typeof(COMPLETE_FLAT_UI.Entidad);
            // 
            // bindingSourceEquips
            // 
            this.bindingSourceEquips.DataSource = typeof(COMPLETE_FLAT_UI.Equipo);
            // 
            // materialRaisedButtonTesT
            // 
            this.materialRaisedButtonTesT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButtonTesT.Depth = 0;
            this.materialRaisedButtonTesT.Location = new System.Drawing.Point(703, 339);
            this.materialRaisedButtonTesT.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonTesT.Name = "materialRaisedButtonTesT";
            this.materialRaisedButtonTesT.Primary = true;
            this.materialRaisedButtonTesT.Size = new System.Drawing.Size(87, 36);
            this.materialRaisedButtonTesT.TabIndex = 25;
            this.materialRaisedButtonTesT.Text = "Exportar";
            this.materialRaisedButtonTesT.UseVisualStyleBackColor = true;
            this.materialRaisedButtonTesT.Click += new System.EventHandler(this.materialRaisedButtonTesT_Click);
            // 
            // Equips
            // 
            this.Equips.AutoSize = true;
            this.Equips.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equips.ForeColor = System.Drawing.Color.White;
            this.Equips.Location = new System.Drawing.Point(100, 160);
            this.Equips.Name = "Equips";
            this.Equips.Size = new System.Drawing.Size(84, 26);
            this.Equips.TabIndex = 27;
            this.Equips.Text = "Equips";
            this.Equips.UseVisualStyleBackColor = true;
            this.Equips.CheckedChanged += new System.EventHandler(this.Equips_CheckedChanged);
            // 
            // bindingSourceTipusCompeticio
            // 
            this.bindingSourceTipusCompeticio.DataSource = typeof(COMPLETE_FLAT_UI.Tipo_gestion);
            // 
            // bindingSourceCatXedat
            // 
            this.bindingSourceCatXedat.DataSource = typeof(COMPLETE_FLAT_UI.Categoria_Edat);
            // 
            // Exportacion_Resumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.Entidad);
            this.Controls.Add(this.tipuscompeticio);
            this.Controls.Add(this.Equips);
            this.Controls.Add(this.dataGridViewEquips);
            this.Controls.Add(this.materialRaisedButtonTesT);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Exportacion_Resumen";
            this.Text = "Exportacion_Resumen";
            this.Activated += new System.EventHandler(this.Exportacion_Resumen_Activated);
            this.Load += new System.EventHandler(this.Exportacion_Resumen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquips)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcetest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEntitat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEquips)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipusCompeticio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCatXedat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonTesT;
        private System.Windows.Forms.DataGridView dataGridViewEquips;
        private System.Windows.Forms.BindingSource bindingSourceEquips;
        private System.Windows.Forms.BindingSource bindingSourceEq;
        private System.Windows.Forms.BindingSource bindingSourceTipusCompeticio;
        private System.Windows.Forms.BindingSource bindingSourceCatXedat;
        private System.Windows.Forms.CheckBox tipuscompeticio;
        private System.Windows.Forms.CheckBox Entidad;
        private System.Windows.Forms.BindingSource bindingSourceEntitat;
        private System.Windows.Forms.CheckBox Equips;
        private System.Windows.Forms.BindingSource bindingSourcetest;
        private System.Windows.Forms.DataGridViewTextBoxColumn Act_concedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Act_demandadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria_edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Competicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deportes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contrasenyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temporadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonosDataGridViewTextBoxColumn;
    }
}