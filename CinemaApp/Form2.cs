using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CinemaApp
{
    public partial class Form2 : Form
    {
        Button chosenSeat;
        Customer tempCust = new Customer();

        public Form2()
        {
            InitializeComponent();

        }

        public void chooseSeat(Button button)
        {
            chosenSeat = button;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label3.Text += chosenSeat.Name;
            radioButton1.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            tempCust.Name = textBox1.Text;
            tempCust.Tcno = textBox2.Text;
            if (tempCust.Name == "" || tempCust.Tcno == "")
            {
                MessageBox.Show("Eksik bilgi girdiniz. Lütfen tekrar girin.");
            }
            else
            {
                if (radioButton1.Checked)
                {
                    tempCust.Gender = "Erkek";
                }
                if (radioButton2.Checked)
                {
                    tempCust.Gender = "Kadın";
                }
                tempCust.TakenSeatNo = Convert.ToInt32(chosenSeat.Name);

                Form1.customersReserved.Add(tempCust);
                Close();
            }  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }



    }
}
