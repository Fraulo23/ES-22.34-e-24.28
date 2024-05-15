using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ES_22._34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double R=double.Parse(txtR.Text);
            lstR.Items.Add(R);
            txtR.Clear();
            Resistenza Rtot = Resistenza.Parse(lstR.Items[0].ToString());
            for(int i=1;i<lstR.Items.Count;i++)
            {
                Resistenza r = Resistenza.Parse(lstR.Items[i].ToString());
                Rtot = Rtot|r;
            }
            lblR.Text = Rtot.ToString();
           
        }
    }
}
