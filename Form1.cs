using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuradeDatosClase1
{
    public partial class Form1 : Form
    { public List<libro> libro2 { get; set; }
        public Form1()
        {
            InitializeComponent();

            libro2 = new List<libro>();


            comboBox3.Items.Add("*");
            comboBox3.Items.Add("**");
            comboBox3.Items.Add("***");
            comboBox3.Items.Add("****");
            comboBox3.Items.Add("*****");
        }

       


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var libro3 = new libro();

            libro3.titulo = textBox1.Text;
            libro3.autor = textBox2.Text;
            libro3.editorial = textBox3.Text;
            libro3.anioedicion = Convert.ToInt32(textBox4.Text);
            libro3.categoria = comboBox3.Text;

            libro2.Add(libro3);

            listBox1.Items.Add(libro3.titulo);
            listBox1.Items.Add(libro3.autor);
            listBox1.Items.Add(libro3.editorial);
            listBox1.Items.Add(libro3.anioedicion);
            listBox1.Items.Add(libro3.categoria);



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();
            textBox2.Clear(); 
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
