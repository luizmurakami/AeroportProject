using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aeroporto
{
    public partial class ShowPassageiro_Form : Form
    {
        Passageiro Passenger;
        private string CPF_Convert(string cpf)
        {
            return Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
        }

        public static string RG_Convert(string texto)
        {
            return texto.Substring(0, 2) + "." + texto.Substring(2, 3) + "." + texto.Substring(5, 3) + "-" + texto.Substring(8, 1).ToUpper();
        }

        private string Data_Convert(string data)
        {
            return Convert.ToUInt64(data).ToString(@"00\/00\/0000");
        }

        public ShowPassageiro_Form(Passageiro p)
        {
            InitializeComponent();

            Passenger = p;

            txtb_nome.Text = p.getNome();
            txtb_datnasc.Text = Data_Convert(p.getDataNascimento());
            txtb_cpf.Text = CPF_Convert(p.getCPF());
            txtb_rg.Text = RG_Convert(p.getRG());
            txtb_end.Text = p.getEndereco();
            cmb_estcivil.Text = p.getEstadoCivil();
            cmb_idade.Text = p.getIdade().ToString();

            if (p.getEmbarque() != 0)
            {
                txtb_embarcado.Text = Aero.pVoo[p.getEmbarque()].getNome() + " - " + Aero.pVoo[p.getEmbarque()].getNumero();
                btn_embarcar.Enabled = false;
            }
            else
            {
                txtb_embarcado.Text = "Nenhum";
                btn_desembarcar.Enabled = false;
            }

            if (p.getSexo() == "Masculino")
                rbtn_masc.Checked = true;
            else
                rbtn_fem.Checked = true;
        }

        private void ShowPassageiro_Form_Load(object sender, EventArgs e)
        {

        }

        private void RefreshAssentos(Form F, int Value)
        {
            if (F is ShowVoo_Form)
                ((ShowVoo_Form)F).txtb_assentos.Text = Value.ToString();

            F.Refresh();
        }

        private void btn_embarcar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Embarcar_Form>().Count() > 0)
            {
                Application.OpenForms.OfType<Embarcar_Form>().First().Focus();
            }
            else
            {
                Embarcar_Form ec = new Embarcar_Form(Passenger, this);
                ec.Show();
            }
        }
        private void btn_desembarcar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja desembarcar?", "AVISO!!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (Passenger.getEmbarque() != 0)
                {
                    foreach (var item in Aero.pVoo.Keys)
                    {
                        if (Passenger.getEmbarque() == item)
                        {
                            Passenger.setEmbarque(0);
                            Aero.pUser.Add(Passenger);

                            bool Success = Aero.pVoo[item].removePassengerQueue(Passenger);

                            if (Success == false)
                            {
                                Aero.pVoo[item].removePassenger(Passenger);

                                if (Aero.pVoo[item].getPassengerQueue().Count > 0 && Aero.pVoo[item].getAssentos() > 0)
                                    Aero.pVoo[item].addPassenger(Aero.pVoo[item].getPassengerQueue().Dequeue());
                            }

                            Aero.SyncListBox(Aero.lbx_fila, 0);

                            Aero.lbx_voos_lista.DataSource = null;
                            Aero.lbx_voos_lista.DataSource = Aero.pVoo[item].getPassengerList();
                            Aero.lbx_voos_lista.Refresh();
                            Aero.lbx_voos_lista.Update();

                            Aero.lbx_voos_fila.DataSource = null;
                            Aero.lbx_voos_fila.DataSource = Aero.pVoo[item].getPassengerQueue().ToList();
                            Aero.lbx_voos_fila.Refresh();
                            Aero.lbx_voos_fila.Update();

                            MessageBox.Show("Passageiro: [" + Passenger.getNome() + "] desembarcou do Voo: [" + Aero.pVoo[item].getNome() + "] de Numero: [" + Aero.pVoo[item].getNumero() + "] !!!");
                            RefreshAssentos(Aero.form_showvoo, Aero.pVoo[item].getAssentos());
                            this.Close();
                            break;
                        }
                    }
                }
            }
        }
    }
}
