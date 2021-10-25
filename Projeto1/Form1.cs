using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] NomeEFotosCarros = Directory.GetFiles(@"C:\Users\gabri\Desktop\ProjetoC#\carros");
            foreach(string imagem in NomeEFotosCarros)
            {
                string[] separador = imagem.Split('\\');
                string[] nomeSelecionado = separador[6].Split('.');
               
                if (comboBox2.Text == nomeSelecionado[0])
                {
                    pictureBox2.ImageLocation = @"C:\Users\gabri\Desktop\ProjetoC#\carros\" + comboBox2.Text + ".jpg";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
                
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = string.Empty;

            if(comboBox1.Text == "Hyundai")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("SantaFe");
                comboBox2.Items.Add("Creta");
            }
            else if(comboBox1.Text == "Honda")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("City");
                comboBox2.Items.Add("Civic");
            }
            else if(comboBox1.Text == "Fiat")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("uno");
                comboBox2.Items.Add("Toro");
            }
            else if (comboBox1.Text == "Chevrolet")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("S10");
                comboBox2.Items.Add("Cruze");
            }
            else if(comboBox1.Text == "Toyota")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Etios");
                comboBox2.Items.Add("Corolla");
            }
        }
    }
}
