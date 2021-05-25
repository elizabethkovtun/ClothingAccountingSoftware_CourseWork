using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork.Forms
{
    public partial class Viewing : Form
    {
        public Viewing()
        {
            InitializeComponent();
        }
        public string PathToFile = @"\\Mac\Home\Documents\Study\Курсовая\Курсовая\CourseWork \CourseWork\Clothes.txt";

        private void ViewingNotes_Load(object sender, EventArgs e)
        { 
            string[] data = File.ReadAllLines(PathToFile);
            this.lbClothes.DataSource = data;
            lbClothes.HorizontalScrollbar = true;
            lbClothes.ScrollAlwaysVisible= true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ChoiceOfCategory choiceOfCategory = new ChoiceOfCategory();
            choiceOfCategory.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = this.lbClothes.SelectedIndex;
            string cl = lbClothes.SelectedItem.ToString();
            if (MessageBox.Show("Ви точно хочете видалити " + cl + "?", "Info", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var lines = File.ReadAllLines(PathToFile).ToList();
                lines.RemoveAt(number);
                File.WriteAllLines(PathToFile, lines);
                this.Close();
                Viewing viewing = new Viewing();
                viewing.Show();
            }
        }
    }
}
