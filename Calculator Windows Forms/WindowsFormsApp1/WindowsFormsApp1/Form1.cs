using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            var currentButton = sender as System.Windows.Forms.Button;
            results.Text += currentButton.Text;
        }

        private void btn_equals_Click(object sender, EventArgs e)
        {
            try
            {
                oldresults.Text = results.Text + "=";
                var Results = new DataTable().Compute(results.Text.Replace("%", "/100"), null);
                results.Text = Results.ToString();
            }
            catch
            {
                results.Text = "Ошибка";
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            results.Text = "";
            oldresults.Text = "";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (results.Text.Length > 0)
            {
                oldresults.Text = "";
                results.Text = results.Text.Remove(results.Text.Length - 1);
            }
        }
    }
}
