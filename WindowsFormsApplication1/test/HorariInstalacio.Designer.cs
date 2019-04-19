namespace COMPLETE_FLAT_UI
{
    partial class HorariInstalacio
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
            this.comboBoxInstalacion = new System.Windows.Forms.ComboBox();
            this.bindingSourceInstalaciones = new System.Windows.Forms.BindingSource(this.components);
            this.materialLabelInstalacio = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelHoraInici = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelDiaSemana = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelHoraFinal = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePickerHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerHoraFin = new System.Windows.Forms.DateTimePicker();
            this.comboBoxDias = new System.Windows.Forms.ComboBox();
            this.bindingSourceDiasSemana = new System.Windows.Forms.BindingSource(this.components);
            this.materialRaisedButtonAceptar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourcehorainicio = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourcefin = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInstalaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDiasSemana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcehorainicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcefin)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxInstalacion
            // 
            this.comboBoxInstalacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxInstalacion.DataSource = this.bindingSourceInstalaciones;
            this.comboBoxInstalacion.DisplayMember = "nombre";
            this.comboBoxInstalacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInstalacion.FormattingEnabled = true;
            this.comboBoxInstalacion.Location = new System.Drawing.Point(186, 83);
            this.comboBoxInstalacion.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxInstalacion.Name = "comboBoxInstalacion";
            this.comboBoxInstalacion.Size = new System.Drawing.Size(375, 21);
            this.comboBoxInstalacion.TabIndex = 30;
            this.comboBoxInstalacion.ValueMember = "id";
            // 
            // bindingSourceInstalaciones
            // 
            this.bindingSourceInstalaciones.DataSource = typeof(COMPLETE_FLAT_UI.Instalacion);
            // 
            // materialLabelInstalacio
            // 
            this.materialLabelInstalacio.AutoSize = true;
            this.materialLabelInstalacio.Depth = 0;
            this.materialLabelInstalacio.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelInstalacio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabelInstalacio.Location = new System.Drawing.Point(37, 83);
            this.materialLabelInstalacio.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelInstalacio.Name = "materialLabelInstalacio";
            this.materialLabelInstalacio.Size = new System.Drawing.Size(83, 19);
            this.materialLabelInstalacio.TabIndex = 31;
            this.materialLabelInstalacio.Text = "Instal·lació";
            // 
            // materialLabelHoraInici
            // 
            this.materialLabelHoraInici.AutoSize = true;
            this.materialLabelHoraInici.Depth = 0;
            this.materialLabelHoraInici.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelHoraInici.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabelHoraInici.Location = new System.Drawing.Point(37, 191);
            this.materialLabelHoraInici.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelHoraInici.Name = "materialLabelHoraInici";
            this.materialLabelHoraInici.Size = new System.Drawing.Size(89, 19);
            this.materialLabelHoraInici.TabIndex = 32;
            this.materialLabelHoraInici.Text = "Hora d\' inici";
            // 
            // materialLabelDiaSemana
            // 
            this.materialLabelDiaSemana.AutoSize = true;
            this.materialLabelDiaSemana.Depth = 0;
            this.materialLabelDiaSemana.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelDiaSemana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabelDiaSemana.Location = new System.Drawing.Point(37, 139);
            this.materialLabelDiaSemana.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelDiaSemana.Name = "materialLabelDiaSemana";
            this.materialLabelDiaSemana.Size = new System.Drawing.Size(130, 19);
            this.materialLabelDiaSemana.TabIndex = 33;
            this.materialLabelDiaSemana.Text = "Dia de la Setmana";
            // 
            // materialLabelHoraFinal
            // 
            this.materialLabelHoraFinal.AutoSize = true;
            this.materialLabelHoraFinal.Depth = 0;
            this.materialLabelHoraFinal.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelHoraFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabelHoraFinal.Location = new System.Drawing.Point(254, 191);
            this.materialLabelHoraFinal.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelHoraFinal.Name = "materialLabelHoraFinal";
            this.materialLabelHoraFinal.Size = new System.Drawing.Size(75, 19);
            this.materialLabelHoraFinal.TabIndex = 34;
            this.materialLabelHoraFinal.Text = "Hora final";
            // 
            // dateTimePickerHoraInicio
            // 
            this.dateTimePickerHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerHoraInicio.Location = new System.Drawing.Point(132, 190);
            this.dateTimePickerHoraInicio.Name = "dateTimePickerHoraInicio";
            this.dateTimePickerHoraInicio.ShowUpDown = true;
            this.dateTimePickerHoraInicio.Size = new System.Drawing.Size(105, 20);
            this.dateTimePickerHoraInicio.TabIndex = 35;
            this.dateTimePickerHoraInicio.ValueChanged += new System.EventHandler(this.dateTimePickerHoraInicio_ValueChanged);
            // 
            // dateTimePickerHoraFin
            // 
            this.dateTimePickerHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerHoraFin.Location = new System.Drawing.Point(335, 189);
            this.dateTimePickerHoraFin.Name = "dateTimePickerHoraFin";
            this.dateTimePickerHoraFin.ShowUpDown = true;
            this.dateTimePickerHoraFin.Size = new System.Drawing.Size(105, 20);
            this.dateTimePickerHoraFin.TabIndex = 36;
            this.dateTimePickerHoraFin.ValueChanged += new System.EventHandler(this.dateTimePickerHoraFin_ValueChanged);
            // 
            // comboBoxDias
            // 
            this.comboBoxDias.DataSource = this.bindingSourceDiasSemana;
            this.comboBoxDias.DisplayMember = "nombre";
            this.comboBoxDias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDias.FormattingEnabled = true;
            this.comboBoxDias.Location = new System.Drawing.Point(186, 136);
            this.comboBoxDias.Name = "comboBoxDias";
            this.comboBoxDias.Size = new System.Drawing.Size(216, 21);
            this.comboBoxDias.TabIndex = 37;
            this.comboBoxDias.ValueMember = "id";
            // 
            // bindingSourceDiasSemana
            // 
            this.bindingSourceDiasSemana.DataSource = typeof(COMPLETE_FLAT_UI.Dias_Semana);
            // 
            // materialRaisedButtonAceptar
            // 
            this.materialRaisedButtonAceptar.AutoSize = true;
            this.materialRaisedButtonAceptar.Depth = 0;
            this.materialRaisedButtonAceptar.Location = new System.Drawing.Point(411, 304);
            this.materialRaisedButtonAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonAceptar.Name = "materialRaisedButtonAceptar";
            this.materialRaisedButtonAceptar.Primary = true;
            this.materialRaisedButtonAceptar.Size = new System.Drawing.Size(127, 36);
            this.materialRaisedButtonAceptar.TabIndex = 38;
            this.materialRaisedButtonAceptar.Text = "Gardar canvis";
            this.materialRaisedButtonAceptar.UseVisualStyleBackColor = true;
            this.materialRaisedButtonAceptar.Click += new System.EventHandler(this.materialRaisedButtonAceptar_Click);
            // 
            // bindingSourcehorainicio
            // 
            this.bindingSourcehorainicio.DataSource = typeof(COMPLETE_FLAT_UI.Instalacion_Horario);
            // 
            // bindingSourcefin
            // 
            this.bindingSourcefin.DataSource = typeof(COMPLETE_FLAT_UI.Instalacion_Horario);
            // 
            // HorariInstalacio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 352);
            this.Controls.Add(this.materialRaisedButtonAceptar);
            this.Controls.Add(this.comboBoxDias);
            this.Controls.Add(this.dateTimePickerHoraFin);
            this.Controls.Add(this.dateTimePickerHoraInicio);
            this.Controls.Add(this.materialLabelHoraFinal);
            this.Controls.Add(this.materialLabelDiaSemana);
            this.Controls.Add(this.materialLabelHoraInici);
            this.Controls.Add(this.materialLabelInstalacio);
            this.Controls.Add(this.comboBoxInstalacion);
            this.Name = "HorariInstalacio";
            this.Text = "HorariInstalacio";
            this.Load += new System.EventHandler(this.HorariInstalacio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInstalaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDiasSemana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcehorainicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcefin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxInstalacion;
        private MaterialSkin.Controls.MaterialLabel materialLabelInstalacio;
        private MaterialSkin.Controls.MaterialLabel materialLabelHoraInici;
        private MaterialSkin.Controls.MaterialLabel materialLabelDiaSemana;
        private MaterialSkin.Controls.MaterialLabel materialLabelHoraFinal;
        private System.Windows.Forms.DateTimePicker dateTimePickerHoraInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerHoraFin;
        private System.Windows.Forms.ComboBox comboBoxDias;
        private System.Windows.Forms.BindingSource bindingSourceDiasSemana;
        private System.Windows.Forms.BindingSource bindingSourceInstalaciones;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonAceptar;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSourcehorainicio;
        private System.Windows.Forms.BindingSource bindingSourcefin;
    }
}