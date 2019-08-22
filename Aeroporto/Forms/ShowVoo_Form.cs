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
    public partial class ShowVoo_Form : Form
    {
        public ShowVoo_Form(int ID_Voo)
        {
            InitializeComponent();

            Aero.form_showvoo = this;

            Aero.lbx_voos_lista = lbx_voos_lista;
            Aero.lbx_voos_fila = lbx_voos_fila;

            Aero.lbx_voos_lista.DataSource = null;
            Aero.lbx_voos_lista.DataSource = Aero.pVoo[ID_Voo].getPassengerList();
            Aero.lbx_voos_lista.Refresh();
            Aero.lbx_voos_lista.Update();

            Aero.lbx_voos_fila.DataSource = null;
            Aero.lbx_voos_fila.DataSource = Aero.pVoo[ID_Voo].getPassengerQueue().ToList();
            Aero.lbx_voos_fila.Refresh();
            Aero.lbx_voos_fila.Update();

            lbx_voos_lista.MouseDoubleClick += new MouseEventHandler(lbx_voos_lista_MouseDoubleClick);
            lbx_voos_fila.MouseDoubleClick += new MouseEventHandler(lbx_voos_fila_MouseDoubleClick);

            txtb_nome.Text = Aero.pVoo[ID_Voo].getNome();
            txtb_origem.Text = Aero.pVoo[ID_Voo].getOrigem();
            txtb_destino.Text = Aero.pVoo[ID_Voo].getDestino();
            txtb_num.Text = Aero.pVoo[ID_Voo].getNumero().ToString();
            txtb_assentos.Text = Aero.pVoo[ID_Voo].getAssentos().ToString();
            txtb_capc.Text = Aero.pVoo[ID_Voo].getCapacidade().ToString();
        }

        private void lbx_voos_lista_MouseDoubleClick(object sender, EventArgs e)
        {
            if (lbx_voos_lista.SelectedItem != null && lbx_voos_lista.SelectedItem is Passageiro)
            {
                if (Application.OpenForms.OfType<ShowPassageiro_Form>().Count() > 0)
                {
                    Application.OpenForms.OfType<ShowPassageiro_Form>().First().Focus();
                }
                else
                {
                    ShowPassageiro_Form sp = new ShowPassageiro_Form((Passageiro)lbx_voos_lista.SelectedItem);
                    sp.Show();
                }
            }
        }

        private void lbx_voos_fila_MouseDoubleClick(object sender, EventArgs e)
        {
            if (lbx_voos_fila.SelectedItem != null && lbx_voos_fila.SelectedItem is Passageiro)
            {
                if (Application.OpenForms.OfType<ShowPassageiro_Form>().Count() > 0)
                {
                    Application.OpenForms.OfType<ShowPassageiro_Form>().First().Focus();
                }
                else
                {
                    ShowPassageiro_Form sp = new ShowPassageiro_Form((Passageiro)lbx_voos_fila.SelectedItem);
                    sp.Show();
                }
            }
        }
    }
}
