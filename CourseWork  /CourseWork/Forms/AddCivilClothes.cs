using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork.Forms
{
    public partial class AddCivilClothes : AddingClothes
    {
        public AddCivilClothes()
        {
            InitializeComponent();
            this.Size = new Size(760, 525);
            MissionComboBox.Location=new Point(24, 155);
        }

        protected override void AddingClothes_Load(object sender, EventArgs e)
        {
            NameLable.Text = ("Створення цивільного одягу");

            MissionComboBox.Items.Add(" Повсякденний одяг");
            MissionComboBox.Items.Add(" Домашній одяг");
            MissionComboBox.Items.Add(" Спортивний одяг");
            MissionComboBox.Items.Add(" Святковий одяг");
            MissionComboBox.Items.Add("Білизна");

            TypeComboBox.Items.Add("Джинси");
            TypeComboBox.Items.Add("Брюки");
            TypeComboBox.Items.Add("Юбка");
            TypeComboBox.Items.Add("Шорти");
            TypeComboBox.Items.Add("Футболка");
            TypeComboBox.Items.Add("Рубашка");
            TypeComboBox.Items.Add("Майка");
            TypeComboBox.Items.Add("Светер");
            TypeComboBox.Items.Add("Футболка з довгими рукавами");
            TypeComboBox.Items.Add("Кофта");
            TypeComboBox.Items.Add("Плаття");
            TypeComboBox.Items.Add("Піджак");
            TypeComboBox.Items.Add("Куртка");
            TypeComboBox.Items.Add("Пальто");
            TypeComboBox.Items.Add("Шуба");
        }

        protected override void MissionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MissionComboBox.SelectedIndex == 1)
            {
                TypeComboBox.Items.Remove("Пальто");
                TypeComboBox.Items.Remove("Шуба");
                TypeComboBox.Items.Remove("Куртка");
                TypeComboBox.Items.Remove("Джинси");
                TypeComboBox.Items.Remove("Плаття");
            }
            else if (MissionComboBox.SelectedIndex == 2)
            {
                TypeComboBox.Items.Remove("Пальто");
                TypeComboBox.Items.Remove("Шуба");
                TypeComboBox.Items.Remove("Куртка");
                TypeComboBox.Items.Remove("Джинси");
                TypeComboBox.Items.Remove("Плаття");
                TypeComboBox.Items.Remove("Юбка");
                TypeComboBox.Items.Remove("Рубашка");
                TypeComboBox.Items.Remove("Светер");

            }
            else if (MissionComboBox.SelectedIndex == 4)
            {
                TypeComboBox.Items.Clear();
                TypeComboBox.Items.Add("Білизна");
                TypeComboBox.Items.Add("Бюстгалтер");

            }
            MissionComboBox.Enabled = false;
        }
        protected override void SeasonComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SeasonComboBox.SelectedIndex == 0)
            {
                TypeComboBox.Items.Remove("Пальто");
                TypeComboBox.Items.Remove("Шуба");
                TypeComboBox.Items.Remove("Куртка");
                TypeComboBox.Items.Remove("Светер");
            }
            else if (SeasonComboBox.SelectedIndex == 1)
            {
                TypeComboBox.Items.Remove("Плаття");
                TypeComboBox.Items.Remove("Юбка");
                TypeComboBox.Items.Remove("Майка");
                TypeComboBox.Items.Remove("Футболка");
                TypeComboBox.Items.Remove("Шорти");

            }
            else if (SeasonComboBox.SelectedIndex == 2)
            {
                TypeComboBox.Items.Remove("Шуба");
            }
            SeasonComboBox.Enabled = false;
        }
        protected override void SexComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SexComboBox.SelectedIndex == 1)
            {
                TypeComboBox.Items.Remove("Юбка");
                TypeComboBox.Items.Remove("Плаття");
            }
            if (MissionComboBox.SelectedIndex == 4 && SexComboBox.SelectedIndex == 1)
            {
                TypeComboBox.Items.Remove("Бюстгалтер");

            }
            SexComboBox.Enabled = false;
        }

        protected override void btnNewCivClothe_Click(object sender, EventArgs e)
        {
            if (MissionComboBox.SelectedIndex == -1 || TypeComboBox.SelectedIndex == -1 || SexComboBox.SelectedIndex == -1 || SeasonComboBox.SelectedIndex == -1 || SizeComboBox.SelectedIndex == -1 || Convert.ToString(tbNumber.Text) == "" || Convert.ToString(tbName.Text) == "")
            {
                MessageBox.Show("Заповніть всі поля!");
            }
            else
            {
                string name = Convert.ToString(tbName.Text);
                int quanity = Convert.ToInt32(tbNumber.Text);
                string mission = MissionComboBox.SelectedItem.ToString();
                string sex = SexComboBox.SelectedItem.ToString();
                string season = SeasonComboBox.SelectedItem.ToString();
                string type = TypeComboBox.SelectedItem.ToString();
                string size = SizeComboBox.SelectedItem.ToString();
                Clothes civilClothes = new CivilClothes(name, season, quanity, mission, type, sex, size);

                civilClothes.WriteFile();

                this.Close();
                Viewing viewing = new Viewing();
                viewing.Show();
            }
        }
        protected override void pictureBox_BackColorChanged(object sender, EventArgs e)
        {
            pictureBox.Image = Properties.Resources.Civil;
        }

    }
}
