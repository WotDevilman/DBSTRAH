using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DBSTRAH.UC;

namespace DBSTRAH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ucStrahovatel uc = new ucStrahovatel();

            addControll(uc);
        }
        private void addControll(UserControl uc)
        {
            panel3.Controls.Clear();
            //uc.Dock = DockStyle.Fill;
            panel3.Controls.Add(uc);
            uc.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
