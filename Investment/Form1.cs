using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Investment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Short");
            comboBox1.Items.Add("Long");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            float exit;
            float profitMul = float.Parse(profitBox.Text);
            float leverageMul = float.Parse(leverageBox.Text);
            float entryPrice = float.Parse(entryBox.Text);

            if (comboBox1.Text == "Long"){
                    exit = (entryPrice * (profitMul / leverageMul))/100 + entryPrice;
                }
                else if (comboBox1.Text == "Short")
                {
                    exit = entryPrice - (entryPrice * (profitMul / leverageMul))/100;
                }
                else
                {
                    exit = 0;
                }
                exitBox.Text = exit.ToString();

            }
            catch
            {
                MessageBox.Show("error");
            }
        }
    }
}
