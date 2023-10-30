using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace monthCalendarKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeSpan ts = monthCalendar1.SelectionEnd -monthCalendar1.SelectionStart;

            if (ts.Days < 1)
            {

                MessageBox.Show("Korištenjem tipke SHIFT odaberite opseg datuma."); 
                return;

            }

            MessageBox.Show("Rezervirali ste usluge u trajanju od " + ts.Days.ToString() + "dana.", "Rezervacija");
            MessageBox.Show("Vasa rezervacija počinje " + monthCalendar1.SelectionStart.ToShortDateString() + " a završava se " + monthCalendar1.SelectionEnd.ToShortDateString());

        }
    }
}
