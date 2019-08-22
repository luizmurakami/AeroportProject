using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Aeroporto
{
    public partial class Embarcar_Form : Form
    {
        Passageiro Passenger;
        Form ShowPassageiro;

        public Embarcar_Form(Passageiro p, Form f)
        {
            InitializeComponent();

            Passenger = p;
            ShowPassageiro = f;

            Load_Settings();
        }

        private void Load_Settings()
        {
            cmb_voos.DataSource = null;
            cmb_voos.DataSource = Aero.pVoo.Values.ToList();
            cmb_voos.Refresh();
            cmb_voos.Update();
        }

        private void Clear()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            Load_Settings();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_embarque_Click(object sender, EventArgs e)
        {
            if (cmb_voos.Text == "")
            {
                MessageBox.Show("Preecha todos os campos!", "AVISO!!!");
                return;
            }
            
            if (cmb_voos.SelectedItem != null && cmb_voos.SelectedItem is Voo)
            {
                if (((Voo)cmb_voos.SelectedItem).getAssentos() <= 0)
                    ((Voo)cmb_voos.SelectedItem).getPassengerQueue().Enqueue(Passenger);
                else
                    ((Voo)cmb_voos.SelectedItem).addPassenger(Passenger);

                Passenger.setEmbarque(((Voo)cmb_voos.SelectedItem).getNumero());

                Aero.pUser.Remove(Passenger);

                Aero.SyncListBox(Aero.lbx_fila, 0);

                MessageBox.Show("Passageiro: [" + Passenger.getNome() + "] foi embarcado no Voo: [" + ((Voo)cmb_voos.SelectedItem).getNome() + "] de Numero: [" + ((Voo)cmb_voos.SelectedItem).getNumero() + "] !!!");
            }

            this.Close();
            ShowPassageiro.Close();
        }
    }
}