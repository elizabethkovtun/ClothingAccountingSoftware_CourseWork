using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class ChoiceOfCategory : Form
    {
        public ChoiceOfCategory()
        {
            InitializeComponent();
        }

        private void btnNewClothes_Click(object sender, EventArgs e)
        {
            if (chbCivilClothes.Checked == false && chbMilitaryClothes.Checked == false && chbOveralls.Checked == false)
            {
                MessageBox.Show("Оберіть категорію!");
            }
            else if ((chbCivilClothes.Checked == true && chbMilitaryClothes.Checked == true) || (chbMilitaryClothes.Checked == true && chbOveralls.Checked == true) || (chbCivilClothes.Checked == true && chbOveralls.Checked == true) || (chbCivilClothes.Checked == true && chbMilitaryClothes.Checked == true && chbOveralls.Checked == true))
            {
                MessageBox.Show("Оберіть лише одну категорію!");
            }
            else if (chbCivilClothes.Checked == true)
            {
                Forms.AddCivilClothes civilClothes = new Forms.AddCivilClothes();
                civilClothes.Show();
                this.Close();
            }
            else if (chbMilitaryClothes.Checked == true)
            {
                Forms.AddMilitaryClothes militaryClothes = new Forms.AddMilitaryClothes();
                militaryClothes.Show();
                this.Close();

            }
            else if (chbOveralls.Checked == true)
            {
                Forms.AddOveralls overalls = new Forms.AddOveralls();
                overalls.Show();
                this.Close();
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chbMilitaryClothes_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
