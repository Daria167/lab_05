using Lab_MVC_App.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_MVC_App
{
    public partial class Form1 : Form
    {
        private MainController controller = new MainController();

        public Form1()
        {
            InitializeComponent();

            btnAdd.Click += btnAdd_Click;
            btnSub.Click += btnSub_Click;
            btnMul.Click += btnMul_Click;
            btnDiv.Click += btnDiv_Click;
            btnCheckAge.Click += btnCheckAge_Click;
            btnGenerate.Click += btnGenerate_Click;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtNum1.Text);
            double b = double.Parse(txtNum2.Text);
            lblResult.Text = "Результат:" + controller.Calculate("+", a, b);   
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtNum1.Text);
            double b = double.Parse(txtNum2.Text);
            lblResult.Text = "Результат:" + controller.Calculate("-", a, b);
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtNum1.Text);
            double b = double.Parse(txtNum2.Text);
            lblResult.Text = "Результат:" + controller.Calculate("*", a, b);
        }
        private void btnDiv_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtNum1.Text);
            double b = double.Parse(txtNum2.Text);
            lblResult.Text = "Результат:" + controller.Calculate("/", a, b);
        }

        private void btnCheckAge_Click(object sender, EventArgs e)
        {
            int age = int.Parse(txtAge.Text);
            lblCategory.Text = "Категорія: " + controller.CheckAgeCategory(age);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int number  = int.Parse(txtNumber.Text);
            txtTable.Text = controller.GenerateTable(number);
        }

        
    }
}
