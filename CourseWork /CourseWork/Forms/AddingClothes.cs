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
    public abstract partial class AddingClothes : Form
    {
        public AddingClothes()
        {
            InitializeComponent();
            
        }


        protected void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else  e.Handled = true;
        }

        private void tbNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else e.Handled = true;
        }

        protected abstract void SexComboBox_SelectedIndexChanged(object sender, EventArgs e);

        protected abstract void SeasonComboBox_SelectedIndexChanged(object sender, EventArgs e);

        protected void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e) => TypeComboBox.Enabled = false;

        protected void SizeComboBox_SelectedIndexChanged(object sender, EventArgs e)=>SizeComboBox.Enabled = false;

        protected abstract void pictureBox_BackColorChanged(object sender, EventArgs e);

        protected abstract void AddingClothes_Load(object sender, EventArgs e);

        protected abstract void MissionComboBox_SelectedIndexChanged(object sender, EventArgs e);

        protected abstract void btnNewCivClothe_Click(object sender, EventArgs e);

        private void btnBackToPreviousForm_Click(object sender, EventArgs e)
        {
            DialogResult vibor = MessageBox.Show("Данні які ви заповнили не зберіжуться. \nБажаєте закрити дане вікно?","Закрити дане вікно" , MessageBoxButtons.YesNo);
            if (vibor == DialogResult.Yes)
            {
                this.Close();
                ChoiceOfCategory choice = new ChoiceOfCategory();
                choice.Show();
            }
        }
    }
}
