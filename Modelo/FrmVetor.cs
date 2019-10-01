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
    public partial class FrmVetor : Form
    {
        int[] vet;
        public FrmVetor()
        {
            InitializeComponent();
        }



        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtEntrada.Text);
            vet = new int[n];
            Random r = new Random();
            txtResultado.Clear();
            txtEntrada.Clear();
            for(int i = 0; i < n; i++)
            {
                vet[i] = r.Next(100);
                txtResultado.Text += vet[i] + "| ";
            }// fim for

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmVetor_Load(object sender, EventArgs e)
        {

        }

        private void BtnOrdenar_Click(object sender, EventArgs e)
        {
            Array.Sort(vet);
            txtResultado.Clear();
            foreach(int num in vet)
            {
                txtResultado.Text += num + "| ";
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            int valor =Convert.ToInt32(txtEntrada.Text);
            int r = Array.IndexOf(vet, valor);
            if (r >= 0)
                MessageBox.Show("Encontrado :) indice:" + r);
            else
                MessageBox.Show("Não encontrado :( "+r);
            txtEntrada.Clear();
            txtEntrada.Focus();
        }

        private void BtnBuscaBinaria_Click(object sender, EventArgs e)
        {
            int valor =Convert.ToInt32(txtEntrada.Text);
            int r = Array.BinarySearch(vet, valor);
            if (r >= 0)
                MessageBox.Show("Encontrado :) indice:" + r);
            else
                MessageBox.Show("Não encontrado :( " + r);
        }
    }
}
