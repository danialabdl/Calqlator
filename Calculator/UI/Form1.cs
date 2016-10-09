using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace UI
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtShow.Text = "0";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            operations.num += btn7.Text;
            txtShow.Text = operations.num;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            operations.num += btn8.Text;
            txtShow.Text = operations.num;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            operations.num += btn9.Text;
            txtShow.Text = operations.num;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            operations.num += btn4.Text;
            txtShow.Text = operations.num;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            operations.num += btn5.Text;
            txtShow.Text = operations.num;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            operations.num += btn6.Text;
            txtShow.Text = operations.num;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            operations.num += btn1.Text;
            txtShow.Text = operations.num;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            operations.num += btn2.Text;
            txtShow.Text = operations.num;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            operations.num += btn3.Text;
            txtShow.Text = operations.num;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                String temp = "";
                switch (operations.selector)
                {
                   
                    case "add":  temp = operations.add(operations.numKeeper, operations.num).ToString();
                        
                        break;
                    case "sub":  temp = operations.sub(operations.numKeeper, operations.num).ToString();
                        break;
                    case "mul":  temp = operations.mul(operations.numKeeper, operations.num).ToString();
                        break;
                    case "div":  temp = operations.div(operations.numKeeper, operations.num).ToString();
                        break;
                    default:
                        break;
                }
            
            txtShow.Text = operations.product.ToString();
            //operations.num = operations.numKeeper = "";
            operations.num = temp;
            
            }
            catch (Exception h)
            {
                txtShow.Text = operations.product.ToString();
            }
            
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            operations.numKeeper = operations.num;
            operations.num = "";
            operations.selector = "add";

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            operations.numKeeper = operations.num;
            operations.num = "";
            operations.selector = "sub";
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            operations.numKeeper = operations.num;
            operations.num = "";
            operations.selector = "mul";
        }

        private void btnDvide_Click(object sender, EventArgs e)
        {
            operations.numKeeper = operations.num;
            operations.num = "";
            operations.selector = "div";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            operations.num = operations.numKeeper = "";
            txtShow.Text = "0";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            operations.num += btn0.Text;
            txtShow.Text = operations.num;
        }
    }
}
