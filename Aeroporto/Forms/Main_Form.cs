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
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();

            Aero.lbx_fila = this.lbx_fila;
            Aero.lbx_voos = this.lbx_voos;

            this.FormClosing += new FormClosingEventHandler(Main_Form_FormClosing);
            lbx_fila.MouseDoubleClick += new MouseEventHandler(listBox1_MouseDoubleClick);
            lbx_voos.MouseDoubleClick += new MouseEventHandler(listBox2_MouseDoubleClick);
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
           
        }

        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Todos os dados serão perdidos!\nDeseja realmente sair?", "AVISO!!!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    System.Windows.Forms.Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void listBox1_MouseDoubleClick(object sender, EventArgs e)
        {
            if (lbx_fila.SelectedItem != null && lbx_fila.SelectedItem is Passageiro)
            {
                if (Application.OpenForms.OfType<ShowPassageiro_Form>().Count() > 0)
                {
                    Application.OpenForms.OfType<ShowPassageiro_Form>().First().Focus();
                }
                else
                {
                    ShowPassageiro_Form sp = new ShowPassageiro_Form((Passageiro)lbx_fila.SelectedItem);
                    sp.Show();
                }
            }
        }

        private void listBox2_MouseDoubleClick(object sender, EventArgs e)
        {
            if (lbx_voos.SelectedItem != null && lbx_voos.SelectedItem is Voo)
            {
                if (Application.OpenForms.OfType<ShowVoo_Form>().Count() > 0)
                {
                    Application.OpenForms.OfType<ShowVoo_Form>().First().Focus();
                }
                else
                {
                    ShowVoo_Form sv = new ShowVoo_Form(((Voo)lbx_voos.SelectedItem).getNumero());
                    sv.Show();
                }
            }
        }

        private void btn_createPassageiro_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<CreatePassageiro_Form>().Count() > 0)
            {
                Application.OpenForms.OfType<CreatePassageiro_Form>().First().Focus();
            }
            else
            {
                CreatePassageiro_Form cp = new CreatePassageiro_Form();
                cp.Show();
            }
        }

        private void btn_criarvoo_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<CreateVoo_Form>().Count() > 0)
            {
                Application.OpenForms.OfType<CreateVoo_Form>().First().Focus();
            }
            else
            {
                CreateVoo_Form cv = new CreateVoo_Form();
                cv.Show();
            }
        }
    }
}
