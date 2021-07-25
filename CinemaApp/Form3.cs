using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CinemaApp
{
    public partial class Form3 : Form
    {
        public bool IsRemoved { get; set; }
        Customer infoCust = new Customer();
        public Form3()
        {
            InitializeComponent();
        }

        public void SetCustomer(int seatno)
        {
            foreach (var item in Form1.customersReserved)
                if (item.TakenSeatNo == seatno)
                    infoCust = item;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Text = infoCust.Name;
            textBox2.Text = infoCust.Tcno;
            textBox3.Text = Convert.ToString(infoCust.TakenSeatNo);
            textBox4.Text = infoCust.Gender;
            IsRemoved = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.customersReserved.Remove(infoCust);
            IsRemoved = true;
            MessageBox.Show(infoCust.Name + " İsimli kullanıcının bileti iptal edildi.");
            Close();
        }
    }
}
