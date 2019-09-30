using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSobre_Click(object sender, EventArgs e)
        {
           
        }


        private void vetor_Click(object sender, EventArgs e)
        {
            FrmVetor  formvetor = new FrmVetor();
            formvetor.Show();
        }
    }
}
