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
            this.comboBoxEsport = new System.Windows.Forms.ComboBox();
            this.materialLabelInstalacio = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelHoraInici = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelDiaSemana = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelHoraFinal = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bindingSourceDiasSemana = new System.Windows.Forms.BindingSource(this.components);
            this.materialRaisedButtonAceptar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.bindingSourceInstalaciones = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDiasSemana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInstalaciones)).BeginInit();
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
            this.comboBoxEsport.Location = new System.Drawing.Point(186, 83);
            this.comboBoxEsport.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxEsport.Name = "comboBoxEsport";
            this.comboBoxEsport.Size = new System.Drawing.Size(216, 21);
            this.comboBoxEsport.TabIndex = 30;
            this.comboBoxEsport.ValueMember = "id";
            // 
            // materialLabelInstalacio
            // 
            this.materialLabelInstalacio.AutoSize = true;
            this.materialLabelInstalacio.Depth = 0;
            this.materialLabelInstalacio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabelInstalacio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelInstalacio.Location = new System.Drawing.Point(37, 83);
            this.materialLabelInstalacio.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelInstalacio.Name = "materialLabelInstalacio";
            this.materialLabelInstalacio.Size = new System.Drawing.Size(70, 18);
            this.materialLabelInstalacio.TabIndex = 31;
            this.materialLabelInstalacio.Text = "Instalació";
            // 
            // materialLabelHoraInici
            // 
            this.materialLabelHoraInici.AutoSize = true;
            this.materialLabelHoraInici.Depth = 0;
            this.materialLabelHoraInici.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabelHoraInici.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelHoraInici.Location = new System.Drawing.Point(37, 191);
            this.materialLabelHoraInici.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelHoraInici.Name = "materialLabelHoraInici";
            this.materialLabelHoraInici.Size = new System.Drawing.Size(85, 18);
            this.materialLabelHoraInici.TabIndex = 32;
            this.materialLabelHoraInici.Text = "Hora d\' inici";
            // 
            // materialLabelDiaSemana
            // 
            this.materialLabelDiaSemana.AutoSize = true;
            this.materialLabelDiaSemana.Depth = 0;
            this.materialLabelDiaSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabelDiaSemana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelDiaSemana.Location = new System.Drawing.Point(37, 139);
            this.materialLabelDiaSemana.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelDiaSemana.Name = "materialLabelDiaSemana";
            this.materialLabelDiaSemana.Size = new System.Drawing.Size(128, 18);
            this.materialLabelDiaSemana.TabIndex = 33;
            this.materialLabelDiaSemana.Text = "Dia de la Setmana";
            // 
            // materialLabelHoraFinal
            // 
            this.materialLabelHoraFinal.AutoSize = true;
            this.materialLabelHoraFinal.Depth = 0;
            this.materialLabelHoraFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabelHoraFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelHoraFinal.Location = new System.Drawing.Point(254, 191);
            this.materialLabelHoraFinal.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelHoraFinal.Name = "materialLabelHoraFinal";
            this.materialLabelHoraFinal.Size = new System.Drawing.Size(71, 18);
            this.materialLabelHoraFinal.TabIndex = 34;
            this.materialLabelHoraFinal.Text = "Hora final";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(132, 190);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(105, 20);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(335, 189);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(105, 20);
            this.dateTimePicker2.TabIndex = 36;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.bindingSourceDiasSemana;
            this.comboBox1.DisplayMember = "nombre";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(186, 136);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(216, 21);
            this.comboBox1.TabIndex = 37;
            this.comboBox1.ValueMember = "id";
            // 
            // bindingSourceDiasSemana
            // 
            this.bindingSourceDiasSemana.DataSource = typeof(COMPLETE_FLAT_UI.Dias_Semana);
            // 
            // materialRaisedButtonAceptar
            // 
            this.materialRaisedButtonAceptar.AutoSize = true;
            this.materialRaisedButtonAceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButtonAceptar.Depth = 0;
            this.materialRaisedButtonAceptar.Icon = null;
            this.materialRaisedButtonAceptar.Location = new System.Drawing.Point(299, 242);
            this.materialRaisedButtonAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonAceptar.Name = "materialRaisedButtonAceptar";
            this.materialRaisedButtonAceptar.Primary = true;
            this.materialRaisedButtonAceptar.Size = new System.Drawing.Size(127, 36);
            this.materialRaisedButtonAceptar.TabIndex = 38;
            this.materialRaisedButtonAceptar.Text = "Gardar canvis";
            this.materialRaisedButtonAceptar.UseVisualStyleBackColor = true;
            // 
            // bindingSourceInstalaciones
            // 
            this.bindingSourceInstalaciones.DataSource = typeof(COMPLETE_FLAT_UI.Instalacion);
            // 
            // HorariInstalacio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 290);
            this.Controls.Add(this.materialRaisedButtonAceptar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.materialLabelHoraFinal);
            this.Controls.Add(this.materialLabelDiaSemana);
            this.Controls.Add(this.materialLabelHoraInici);
            this.Controls.Add(this.materialLabelInstalacio);
            this.Controls.Add(this.comboBoxEsport);
            this.Name = "HorariInstalacio";
            this.Text = "HorariInstalacio";
            this.Load += new System.EventHandler(this.HorariInstalacio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDiasSemana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInstalaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxEsport;
        private MaterialSkin.Controls.MaterialLabel materialLabelInstalacio;
        private MaterialSkin.Controls.MaterialLabel materialLabelHoraInici;
        private MaterialSkin.Controls.MaterialLabel materialLabelDiaSemana;
        private MaterialSkin.Controls.MaterialLabel materialLabelHoraFinal;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource bindingSourceDiasSemana;
        private System.Windows.Forms.BindingSource bindingSourceInstalaciones;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonAceptar;
    }
}