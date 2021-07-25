using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaApp
{
    public partial class Form1 : Form
    {
        internal static List<Customer> customersReserved = new List<Customer>();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    Button button = new Button
                    {
                        Name = Convert.ToString(i * 12 + j),
                        Size = new Size(45, 45),
                        Location = new Point(100 + (j * 50), 100 + (i * 50)),
                        Image = Properties.Resources.sofaBlue,
                    };
                    
                    this.Controls.Add(button);
                    button.Click += btn_Click;
                }
            }

            
        }

        void btn_Click(object sender, EventArgs e)
        {
            bool isTaken = false;
            foreach (var item in customersReserved)
            {
                if (item.TakenSeatNo == Convert.ToInt32((sender as Button).Name))
                {
                    isTaken = true;
                }
            }

            if (isTaken)
            {
                Form3 form3 = new Form3();
                form3.SetCustomer(Convert.ToInt32((sender as Button).Name));
                form3.ShowDialog();
                if (form3.IsRemoved)
                    (sender as Button).Image = Properties.Resources.sofaBlue;
            }
            else
            {
                Form2 form2 = new Form2();
                form2.chooseSeat(sender as Button);
                form2.ShowDialog();
                foreach (var item in customersReserved)
                {
                    if (item.TakenSeatNo == Convert.ToInt32((sender as Button).Name)){
                        (sender as Button).Image = Properties.Resources.sofaRed;
                    }
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int maleCount = 0, femaleCount = 0;

            foreach (var item in customersReserved)
            {
                if (item.Gender == "Erkek")
                    maleCount++;
                else
                    femaleCount++;
            }

            MessageBox.Show("Toplam Film İzleyen Sayısı: " + customersReserved.Count + "\n\n" + "İzleyenlerin " + maleCount + " tanesi erkek, " + 
                femaleCount + " tanesi kadın izleyicidir." );
        }
    }
}
