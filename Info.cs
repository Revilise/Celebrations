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
    public partial class Info : Form
    {
        Home form1;
        string cel;
        DateTime dt;
        DateTime dtnow;
        int year;
        TimeSpan dif;

        public Info(Home f1, string cele)
        {
            InitializeComponent();
            form1 = f1;
            cel = cele;
        }

        private void Info_Load(object sender, EventArgs e)
        {
            datewilllable.Text = cel;
            year = DateTime.Now.Year;

            switch (cel)
            {
                case "День программиста":
                    dt = new DateTime(year,7,13);
                    break;
                case "Междунарожный день без интернета":
                    dt = new DateTime(year+1, 1,26);
                    break;
                case "День тестировщика":
                    dt = new DateTime(year, 7, 1);
                    break;
                case "День рождения интернета":
                    dt = new DateTime(year, 5, 17);
                    break;
            }
            datewill.Text = dt.ToString("D");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dtnow = DateTime.Now;
            dif = dt - dtnow;
            datelost.Text = dif.Days.ToString() + " дней " + dif.Hours.ToString() + " часов " + dif.Minutes + " минут " + dif.Seconds + " секунд ";
        }
    }
}
