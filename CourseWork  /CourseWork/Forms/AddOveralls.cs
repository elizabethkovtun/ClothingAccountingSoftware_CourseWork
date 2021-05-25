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
    public partial class AddOveralls : AddingClothes
    {
        public ComboBox TypeOfProtectedComboBox = new ComboBox()
        {
            Location = new Point(24, 416),
            Size = new Size(255, 29),
            Font = new Font("Yu Gothic UI",12, FontStyle.Regular)
        };
        public ComboBox LevelOfProtectedComboBox = new ComboBox()
        {
            Location = new Point(158, 480),
            Size = new Size(120, 29),
            Font = new Font("Yu Gothic UI", 12, FontStyle.Regular)
        };
        public Label labelTypeProt = new Label()
        {
            Font = new Font("Yu Gothic UI",12, FontStyle.Regular),
            Location = new Point(24, 391)
        };
        public Label labellevelProt = new Label()
        {
            Font = new Font("Yu Gothic UI", 12, FontStyle.Regular),
            Location = new Point(155, 456)
        };

        public AddOveralls()
        {
            InitializeComponent();
            this.Size = new Size(730, 600);
            MissionComboBox.Location = new Point(24, 155);

            Controls.Add(TypeOfProtectedComboBox);
            Controls.Add(labelTypeProt);
            Controls.Add(labellevelProt);
            Controls.Add(LevelOfProtectedComboBox);


            SizeComboBox.Location = new Point(24, 480);
            SizeComboBox.Size = new Size(120,29);

            label5.Location = new Point(24, 456);
            labelTypeProt.Text = "Тип захисту";
            labellevelProt.Text="Рівень захисту";

        }

        private void AddOveralls_Load(object sender, EventArgs e)
        {
            

        }
        protected override void MissionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MissionComboBox.SelectedIndex == 0)
            {
                TypeComboBox.Items.Add("Напівкомбінезон");


            }
            else if (MissionComboBox.SelectedIndex == 1)
            {
                
                TypeComboBox.Items.Add("Хірургічний костюм");
                TypeComboBox.Items.Remove("Жилет");
                TypeComboBox.Items.Remove("Куртка");
                TypeOfProtectedComboBox.SelectedIndex = 2;
                TypeOfProtectedComboBox.Enabled = false;
                LevelOfProtectedComboBox.SelectedIndex = 0;
                LevelOfProtectedComboBox.Enabled = false;
            }
            else if(MissionComboBox.SelectedIndex==2)
            {
                TypeComboBox.Items.Remove("Футболка");

            }
            MissionComboBox.Enabled = false;
        }
        private void TypeOfProtectedComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected override void AddingClothes_Load(object sender, EventArgs e)
        {
            NameLable.Text = ("Створення спеціалізованого одягу");

            MissionComboBox.Items.Add("Робочий одяг");
            MissionComboBox.Items.Add("Медичний одяг");
            MissionComboBox.Items.Add("Захисний одяг");


            TypeComboBox.Items.Add("Брюки");
            TypeComboBox.Items.Add("Футболка");
            TypeComboBox.Items.Add("Халат");
            TypeComboBox.Items.Add("Костюм");
            TypeComboBox.Items.Add("Жилет");
            TypeComboBox.Items.Add("Плащ");
            TypeComboBox.Items.Add("Фартух");
            TypeComboBox.Items.Add("Куртка");

            SexComboBox.Items.Add("Унісекс");

            TypeOfProtectedComboBox.Items.Add("Термічний");
            TypeOfProtectedComboBox.Items.Add("Хімічний");
            TypeOfProtectedComboBox.Items.Add("Біологічний");
            TypeOfProtectedComboBox.Items.Add("Eлектричний");

            LevelOfProtectedComboBox.Items.Add("0");
            LevelOfProtectedComboBox.Items.Add("1");
            LevelOfProtectedComboBox.Items.Add("2");
            LevelOfProtectedComboBox.Items.Add("3");
            LevelOfProtectedComboBox.Items.Add("4");

        }
        protected override void pictureBox_BackColorChanged(object sender, EventArgs e)
        {
            pictureBox.Image = Properties.Resources.Overalls;
        }

        protected override void SeasonComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SeasonComboBox.SelectedIndex==2&&MissionComboBox.SelectedIndex!=1)
            {
                TypeComboBox.Items.Remove("Футболка");
            }
            SeasonComboBox.Enabled = false;
        }

        protected override void SexComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SexComboBox.Enabled = false;
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
               || TypeOfProtectedComboBox.SelectedIndex == -1
               || LevelOfProtectedComboBox.SelectedIndex == -1)
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
                string typeOfProtected = TypeOfProtectedComboBox.SelectedItem.ToString();
                int levelOfProtected = Convert.ToInt32(LevelOfProtectedComboBox.SelectedIndex);
                Clothes overalls = new Overalls(name, season, quanity, mission, type, sex, size, typeOfProtected, levelOfProtected);
                overalls.WriteFile();
                this.Close();
                Viewing viewing = new Viewing();
                viewing.Show();
            }
        }
    }
}
