using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        List<Animal> animals = new List<Animal>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dog d = new Dog("Flox", 5, "kopros");
            animals.Add(d);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBConnection d = new DBConnection();
            DateTime entrance = d.GetFromDatabase(listBox1.Text);
            int result = (int)(DateTime.Now - entrance).TotalDays;
            int amountMoney = result * 5;

            listBox1.Items.Remove(listBox1.Text);
        }
    }
}
