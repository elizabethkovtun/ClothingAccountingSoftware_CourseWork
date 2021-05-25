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
    public partial class StartWindow : Form
    {
        public StartWindow()
        {
            InitializeComponent();
        }

        private void btnNewClothes_Click(object sender, EventArgs e)
        {
            ChoiceOfCategory choiceOfCategory = new ChoiceOfCategory();
            choiceOfCategory.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Forms.Viewing viewing = new Forms.Viewing();
            viewing.Show();
        }
    }
}
