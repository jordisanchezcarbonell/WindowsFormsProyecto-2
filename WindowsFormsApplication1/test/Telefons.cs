using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPLETE_FLAT_UI
{
    public partial class Telefons : Estilo
    {
        public Telefons()
        {
            InitializeComponent();
        }


        private void Telefons_Load(object sender, EventArgs e)
        {
            carregarDadesGrid();
            netejarCamps();
        }


        private void carregarDadesGrid()
        {
            //Creo una list de telèfons, que ompliré passant-la per referència:
            List<Telefonos> llistaTelefons = new List<Telefonos>();

            string missatgeRetornat = BD.TelefonsORM.SelectAllTelefons(ref llistaTelefons);

            //En funció del missatge retornat, ho adjudico al binding source:
            if (missatgeRetornat.Equals(""))
            {
                bindingSourceTelefons.DataSource = llistaTelefons;
            }
            else
            {
                MessageBox.Show(missatgeRetornat, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            //Faig el bindingSource de les entitats:
            List<Entidad> llistaEntitats = new List<Entidad>();
            string missatge = BD.EntitatsORM.SelectAllEntitats(ref llistaEntitats);

            //En funció del missatge retornat, ho adjudico al binding source:
            if (missatge.Equals(""))
            {
                bindingSourceEntitats.DataSource = llistaEntitats;
            }
            else
            {
                MessageBox.Show(missatge, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void materialRaisedButtonAfegirTelefon_Click(object sender, EventArgs e)
        {
            //Si els camps estan plens, faig un insert:
            if (materialSingleLineTextFieldTelefon.Text.Length != 0 && materialSingleLineTextFieldRao.Text.Length != 0
                && comboBoxEntitats.SelectedValue != null)
            {
                string missatge = BD.TelefonsORM.InsertTelefon(materialSingleLineTextFieldTelefon.Text,
                    materialSingleLineTextFieldRao.Text, int.Parse(comboBoxEntitats.SelectedValue.ToString()));

                //Si no ha retornat res, recarrego la grid. Sinó mostro un missatge d'error:
                if (missatge.Equals(""))
                {
                    carregarDadesGrid();
                    netejarCamps();
                }
                else
                {
                    MessageBox.Show(missatge, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void materialRaisedButtonModificarTelefon_Click(object sender, EventArgs e)
        {
            //recupero l'objecte i li setejo els valors que hi ha als camps:
            Telefonos telefonModificar = (Telefonos)dataGridViewTelefons.CurrentRow.DataBoundItem;
            telefonModificar.telefono = materialSingleLineTextFieldTelefon.Text;
            telefonModificar.razon = materialSingleLineTextFieldRao.Text;
            telefonModificar.id_entidad = int.Parse(comboBoxEntitats.SelectedValue.ToString());

            //Faig l'update i recarrego la grid o mostro un missatge d'error en funció del resultat del update:
            string missatge = BD.TelefonsORM.UpdateTelefon(telefonModificar.id, telefonModificar.telefono,
                telefonModificar.razon, telefonModificar.id_entidad);

            if (missatge.Equals(""))
            {
                carregarDadesGrid();
            }
            else
            {
                MessageBox.Show(missatge, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void materialRaisedButtonEsborrarTelefon_Click(object sender, EventArgs e)
        {
            //Recupero l'objecte Telefonos seleccionat a la base de dades i l'esborro:
            Telefonos telefonEsborrar = (Telefonos)dataGridViewTelefons.CurrentRow.DataBoundItem;
            string missatge = BD.TelefonsORM.deleteTelefon(telefonEsborrar.id);

            //En funció del missatge retornat pel mètode delete, recarrego la grid o mostro un missatge
            if (missatge.Equals(""))
            {
                carregarDadesGrid();
            }
            else
            {
                MessageBox.Show(missatge, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void materialRaisedButtonTancar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void netejarCamps()
        {
            //Primero desselecciono la gridView,i després netejo els camps. Si ho faig al revés, queda text als camps
            dataGridViewTelefons.ClearSelection();
            dataGridViewTelefons.CurrentCell = null;
            comboBoxEntitats.SelectedIndex = -1;

            materialSingleLineTextFieldTelefon.Clear();
            materialSingleLineTextFieldRao.Clear();
        }

        private void dataGridViewTelefons_SelectionChanged(object sender, EventArgs e)
        {
            Telefonos telefonModificar = (Telefonos)dataGridViewTelefons.CurrentRow.DataBoundItem;
            materialSingleLineTextFieldTelefon.Text = telefonModificar.telefono;
            materialSingleLineTextFieldRao.Text = telefonModificar.razon;

            //Utilitzo el .SelectedValue perquè és el que està vinculat amb el DisplayMember
            comboBoxEntitats.SelectedValue = telefonModificar.id_entidad;
        }

        private void materialRaisedButtonNetejarCamps_Click(object sender, EventArgs e)
        {
            netejarCamps();
        }
    }
}
