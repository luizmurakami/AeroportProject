using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
public class Aero
{
    public static List<Passageiro> pUser = new List<Passageiro>();
    public static Dictionary<int, Voo> pVoo = new Dictionary<int, Voo>();

    public static ListBox lbx_fila, lbx_voos, lbx_voos_lista, lbx_voos_fila;

    public static Form form_showvoo;

    public static void SyncListBox(ListBox listBox, int flag)
    {
        listBox.DataSource = null;

        if (flag == 0)
            listBox.DataSource = pUser;
        else if (flag == 1)
            listBox.DataSource = pVoo.Values.ToList();

        listBox.SelectedItem = null;

        listBox.Refresh();
        listBox.Update();
    }
}