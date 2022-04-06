using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_6___Random_Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int maxStore;
        int minStore;
        Random generator = new Random();
        int rand1;
        int rand2;
        public void RandStore()
        {
            int = generator.Next(minStore, maxStore);
        }
        private void btnGo_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtMaximum.Text, out maxStore))
            {
                maxStore = maxStore + 1;
                if (Int32.TryParse(txtMinimum.Text, out minStore))
                {

                }
            }
        }
    }
}
