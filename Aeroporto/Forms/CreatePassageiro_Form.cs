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
    public partial class CreatePassageiro_Form : Form
    {
        public CreatePassageiro_Form()
        {
            InitializeComponent();

            Load_Settings();

            txtb_cpf.KeyPress += new KeyPressEventHandler(txtb_KeyPress);
            txtb_rg.KeyPress += new KeyPressEventHandler(txtb_rg_KeyPress);
            txtb_datnasc.KeyPress += new KeyPressEventHandler(txtb_KeyPress);
        }

        private void txtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
                e.Handled = true;
        }

        private void txtb_rg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
                if (txtb_rg.Text.Length < 8 && e.KeyChar != 'X' || e.KeyChar != 'x')
                    e.Handled = true;
        }

        private void Load_Settings()
        {
            cmb_estcivil.Items.Add("Solteiro(a)");
            cmb_estcivil.Items.Add("Casado(a)");
            cmb_estcivil.Items.Add("Divociado(a)");
            cmb_estcivil.Items.Add("Viúvo(a)");

            for (int i = 12; i < 100; i++)
                cmb_idade.Items.Add(i);

            txtb_cpf.MaxLength = 11;
            txtb_rg.MaxLength = 9;
            txtb_datnasc.MaxLength = 8;
            cmb_idade.MaxLength = 3;
        }

        private void Clear()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            Load_Settings();
        }

        private void CreatePassageiro_Form_Load(object sender, EventArgs e)
        {

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_criar_Click(object sender, EventArgs e)
        {
            if (txtb_nome.Text == "" || txtb_cpf.Text == "" || txtb_datnasc.Text == "" || txtb_end.Text == "" ||
                cmb_idade.Text == "" || cmb_estcivil.Text == "" || txtb_rg.Text == "" ||
                (rbtn_fem.Checked == false && rbtn_masc.Checked == false))
            {
                MessageBox.Show("Preecha todos os campos!", "AVISO!!!");
                return;
            }

            if (txtb_cpf.Text.Length != 11)
            {
                MessageBox.Show("Preecha o CPF corretamente!", "AVISO!!!");
                return;
            }

            if (txtb_rg.Text.Length != 9)
            {
                MessageBox.Show("Preecha o RG corretamente!", "AVISO!!!");
                return;
            }

            if (txtb_datnasc.Text.Length != 8)
            {
                MessageBox.Show("Preecha a Data de Nascimento corretamente!", "AVISO!!!");
                return;
            }

            Passageiro Psg = new Passageiro();

            Psg.setNome(txtb_nome.Text);
            Psg.setCPF(txtb_cpf.Text);
            Psg.setDataNascimento(txtb_datnasc.Text);
            Psg.setEndereco(txtb_end.Text);
            Psg.setIdade(Convert.ToInt32(cmb_idade.Text));
            Psg.setEstadoCivil(cmb_estcivil.Text);
            Psg.setRG(txtb_rg.Text = txtb_rg.Text.ToUpper());
            Psg.setEmbarque(0);

            if (rbtn_fem.Checked == true)
                Psg.setSexo("Feminino");
            else if (rbtn_masc.Checked == true)
                Psg.setSexo("Masculino");

            foreach (var item in Aero.pUser)
            {
                if (Psg.Equals(item))
                {
                    MessageBox.Show("Usuario já cadastrado!", "AVISO!!!");
                    Clear();
                    return;
                }
            }

            Aero.pUser.Add(Psg);

            Aero.SyncListBox(Aero.lbx_fila, 0);

            MessageBox.Show("Passageiro do Nome: [" + Psg.getNome() + "] e Idade: [" + Psg.getIdade() + "] criado com sucesso!");
            this.Close();
        }
    }
}
