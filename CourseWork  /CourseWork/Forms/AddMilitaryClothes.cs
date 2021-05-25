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
    public partial class AddMilitaryClothes : AddingClothes
    {
        public ComboBox ComouflageComboBox = new ComboBox()
        {
            Location = new Point(24, 481),
            Size = new Size(255, 29),
            Font = new Font("Yu Gothic UI", 12, FontStyle.Regular)

        };
        public Label Comouflagelabel = new Label()
        {
            Font = new Font("Yu Gothic UI", 12, FontStyle.Regular),
            Location = new Point(24, 456)
        };

        public AddMilitaryClothes()
        {
            InitializeComponent();
            this.Size = new Size(720, 570);
            MissionComboBox.Location = new Point(24, 155);
            Controls.Add(ComouflageComboBox);
            Controls.Add(Comouflagelabel);
            Comouflagelabel.Text = "Маскування";
        }



        protected override void AddingClothes_Load(object sender, EventArgs e)
        {
            NameLable.Text = ("Створення військового одягу");

            MissionComboBox.Items.Add("Парадний одяг");
            MissionComboBox.Items.Add("Польовий одяг");
            MissionComboBox.Items.Add("Повсякденний одяг");

            TypeComboBox.Items.Add("Шинель");
            TypeComboBox.Items.Add("Костюм");
            TypeComboBox.Items.Add("Брюки");
            TypeComboBox.Items.Add("Футболка");
            TypeComboBox.Items.Add("Бронижилет");
            TypeComboBox.Items.Add("Куртка");
            TypeComboBox.Items.Add("Юбка");

            ComouflageComboBox.Items.Add("Хакі");
            ComouflageComboBox.Items.Add("Білий");
            ComouflageComboBox.Items.Add("Зелеений");
            ComouflageComboBox.Items.Add("Відсутнє");




        }

        protected override void btnNewCivClothe_Click(object sender, EventArgs e)
        {
            if (MissionComboBox.SelectedIndex == -1
              || TypeComboBox.SelectedIndex == -1
              || SexComboBox.SelectedIndex == -1
              || SeasonComboBox.SelectedIndex == -1
              || SizeComboBox.SelectedIndex == -1
              || Convert.ToString(tbNumber.Text) == ""
              || Convert.ToString(tbName.Text) == ""
              || ComouflageComboBox.SelectedIndex==-1)
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
                string comouflage = ComouflageComboBox.SelectedIndex.ToString();
                Clothes militaryClothes = new MilitaryClothes(name, season, quanity, mission, type, sex, size, comouflage);
                militaryClothes.WriteFile();
                this.Close();
                Viewing viewing = new Viewing();
                viewing.Show();
            }
        }

        protected override void MissionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(MissionComboBox.SelectedIndex==0)
            {
                TypeComboBox.Items.Remove("Бронижилет");
                TypeComboBox.Items.Remove("Брюки");
                TypeComboBox.Items.Remove("Футболка");
                TypeComboBox.Items.Remove("Куртка");
                TypeComboBox.Items.Remove("Юбка");
                ComouflageComboBox.SelectedIndex = 3;
                ComouflageComboBox.Enabled = false;

            }
            else if(MissionComboBox.SelectedIndex==1||MissionComboBox.SelectedIndex==2)
           {
                TypeComboBox.Items.Remove("Шинель");
                TypeComboBox.Items.Remove("Костюм");
                TypeComboBox.Items.Remove("Юбка");

            }
            MissionComboBox.Enabled = false;
        }

        protected override void pictureBox_BackColorChanged(object sender, EventArgs e)
        {
            pictureBox.Image = Properties.Resources.Military;
        }

        protected override void SeasonComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SeasonComboBox.SelectedIndex==0)
            {
                TypeComboBox.Items.Remove("Шинель");
                TypeComboBox.Items.Remove("Куртка");

            }
            else if(SeasonComboBox.SelectedIndex==1)
            {
                TypeComboBox.Items.Remove("Футболка");
                TypeComboBox.Items.Remove("Юбка");

            }
            SeasonComboBox.Enabled = false;
        }

        protected override void SexComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SexComboBox.SelectedIndex==0)
            {
                TypeComboBox.Items.Remove("Юбка");
            }
            SexComboBox.Enabled = false;

        }

        private void AddMilitaryClothes_Load(object sender, EventArgs e)
        {

        }
    }
}
