using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celebrations
{

    public partial class Home : Form
    {
        string cel;
        public Home()
        {
            InitializeComponent();
            comboBox1.SelectedItem = comboBox1.Items[0];
        }

        private void opener_Click(object sender, EventArgs e)
        {
            cel = comboBox1.SelectedItem.ToString();
            Info form = new Info(this, cel) ;
            form.Show();
        }
    }
}
