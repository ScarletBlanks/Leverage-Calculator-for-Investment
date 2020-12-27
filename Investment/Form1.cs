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
            comboBox1.Items.Add("Long");
            comboBox1.Items.Add("Short");
            

            comboBox2.Items.Add("Long");
            comboBox2.Items.Add("Short");
            

            comboBox3.Items.Add("Long");
            comboBox3.Items.Add("Short");
            
            comboBox4.Items.Add("Long");
            comboBox4.Items.Add("Short");

            comboBox5.Items.Add("Long");
            comboBox5.Items.Add("Short");

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {


                float exitPrice = float.Parse(pExitBox.Text);
                float leverageMul = float.Parse(pLevBox.Text);
                float entryPrice = float.Parse(pEntryBox.Text);
                if (comboBox2.Text == "Long")
                {
                    pProfitBox.Text = (((exitPrice - entryPrice) / entryPrice) * leverageMul * 100).ToString() + "%";
                }
                else if (comboBox2.Text == "Short")
                {
                    pProfitBox.Text = (((entryPrice - exitPrice) / entryPrice) * leverageMul * 100).ToString() + "%";
                }
                else
                {

                }

            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                float Line = float.Parse(bLineBox.Text);
                float Margin = float.Parse(bBreakoutMarginBox.Text);



                if (comboBox3.Text == "Long")
                {
                    bBreakoutValBox.Text = (Line * (1 + (Margin / 100))).ToString();
                }
                else if (comboBox3.Text == "Short")
                {
                    bBreakoutValBox.Text = (Line * (1 - (Margin / 100))).ToString();
                }
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                float entry = float.Parse(lEntryBox.Text);
                float lev = float.Parse(lLeverageBox.Text);



                if (comboBox4.Text == "Long")
                {
                    lLiqBox.Text = ((1-((100/lev)/100)) * entry).ToString();
                }
                else if (comboBox4.Text == "Short")
                {
                    lLiqBox.Text = ((1 + ((100 / lev) / 100)) * entry).ToString();
                }
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                float profitMul = float.Parse(profitBox.Text);
                float leverageMul = float.Parse(leverageBox.Text);
                float entryPrice = float.Parse(entryBox.Text);

                if (comboBox1.Text == "Long")
                {
                    exitBox.Text = ((entryPrice * (profitMul / leverageMul)) / 100 + entryPrice).ToString();
                }
                else if (comboBox1.Text == "Short")
                {
                    exitBox.Text = (entryPrice - (entryPrice * (profitMul / leverageMul)) / 100).ToString();
                }
                else
                {
                }

            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                float acceptableLoss = float.Parse(sAcceptLossBox.Text);
                float leverage = float.Parse(sLevBox.Text);
                float entry = float.Parse(sEntryBox.Text);


                if (comboBox5.Text == "Long")
                {
                    sSLBox.Text = ((1-((acceptableLoss / leverage)/100))*entry).ToString();
                }
                else if (comboBox5.Text == "Short")
                {
                    sSLBox.Text = ((1 + ((acceptableLoss / leverage)/100)) * entry).ToString();
                }
                else
                {
                }

            }
            catch
            {
                MessageBox.Show("error");
            }
        }
    }
}
