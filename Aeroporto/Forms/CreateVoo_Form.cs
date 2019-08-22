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
    public partial class CreateVoo_Form : Form
    {
        public CreateVoo_Form()
        {
            InitializeComponent();
            Load_Settings();
            txtb_num.KeyPress += new KeyPressEventHandler(txtb_KeyPress);
        }

        private void txtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
                e.Handled = true;
        }

        private void Load_Settings()
        {
            for (int i = 1; i < 1000; i++)
                cmb_capc.Items.Add(i);

            txtb_num.MaxLength = 4;
        }

        private void Clear()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            Load_Settings();
        }

        private void btn_criar_Click(object sender, EventArgs e)
        {
            if (txtb_nome.Text == "" || txtb_origem.Text == "" || txtb_destino.Text == "" || txtb_num.Text == "" || cmb_capc.Text == "")
            {
                MessageBox.Show("Preecha todos os campos!", "AVISO!!!");
                return;
            }

            Voo vv = new Voo();

            vv.setNome(txtb_nome.Text);
            vv.setDestino(txtb_destino.Text);
            vv.setOrigem(txtb_origem.Text);
            vv.setNumero(Convert.ToInt32(txtb_num.Text));
            vv.setCapacidade(Convert.ToInt32(cmb_capc.Text));
            vv.setAssentos(Convert.ToInt32(cmb_capc.Text));

            foreach (var item in Aero.pVoo.Keys)
            {
                if (item == vv.getNumero())
                {
                    MessageBox.Show("Voo já cadastrado!", "AVISO!!!");
                    Clear();
                    return;
                }
            }

            MessageBox.Show("Voo do Nome: [" + vv.getNome() + "] de Numero: [" + vv.getNumero() + "] criado com sucesso!");
            Aero.pVoo.Add(vv.getNumero(), vv);
            Aero.SyncListBox(Aero.lbx_voos, 1);
            this.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
