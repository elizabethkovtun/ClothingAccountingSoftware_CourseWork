
namespace CourseWork
{
    partial class ChoiceOfCategory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoiceOfCategory));
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnNewClothes = new System.Windows.Forms.Button();
            this.chbCivilClothes = new System.Windows.Forms.CheckBox();
            this.chbOveralls = new System.Windows.Forms.CheckBox();
            this.chbMilitaryClothes = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGoBack.BackgroundImage")));
            this.btnGoBack.FlatAppearance.BorderSize = 0;
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGoBack.Location = new System.Drawing.Point(328, 312);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(182, 24);
            this.btnGoBack.TabIndex = 14;
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // btnNewClothes
            // 
            this.btnNewClothes.BackColor = System.Drawing.Color.SlateBlue;
            this.btnNewClothes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnNewClothes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewClothes.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewClothes.ForeColor = System.Drawing.Color.White;
            this.btnNewClothes.Location = new System.Drawing.Point(532, 306);
            this.btnNewClothes.Name = "btnNewClothes";
            this.btnNewClothes.Size = new System.Drawing.Size(159, 36);
            this.btnNewClothes.TabIndex = 15;
            this.btnNewClothes.Text = "Створити";
            this.btnNewClothes.UseVisualStyleBackColor = false;
            this.btnNewClothes.Click += new System.EventHandler(this.btnNewClothes_Click);
            // 
            // chbCivilClothes
            // 
            this.chbCivilClothes.AutoSize = true;
            this.chbCivilClothes.Cursor = System.Windows.Forms.Cursors.Default;
            this.chbCivilClothes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbCivilClothes.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chbCivilClothes.Location = new System.Drawing.Point(119, 99);
            this.chbCivilClothes.Name = "chbCivilClothes";
            this.chbCivilClothes.Size = new System.Drawing.Size(138, 25);
            this.chbCivilClothes.TabIndex = 16;
            this.chbCivilClothes.Text = "Цивільний одяг";
            this.chbCivilClothes.UseVisualStyleBackColor = true;
            // 
            // chbOveralls
            // 
            this.chbOveralls.AutoSize = true;
            this.chbOveralls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbOveralls.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chbOveralls.Location = new System.Drawing.Point(119, 139);
            this.chbOveralls.Name = "chbOveralls";
            this.chbOveralls.Size = new System.Drawing.Size(182, 25);
            this.chbOveralls.TabIndex = 17;
            this.chbOveralls.Text = "Спеціалізований одяг";
            this.chbOveralls.UseVisualStyleBackColor = true;
            // 
            // chbMilitaryClothes
            // 
            this.chbMilitaryClothes.AutoSize = true;
            this.chbMilitaryClothes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbMilitaryClothes.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chbMilitaryClothes.Location = new System.Drawing.Point(119, 180);
            this.chbMilitaryClothes.Name = "chbMilitaryClothes";
            this.chbMilitaryClothes.Size = new System.Drawing.Size(142, 25);
            this.chbMilitaryClothes.TabIndex = 18;
            this.chbMilitaryClothes.Text = "Військовий одяг";
            this.chbMilitaryClothes.UseVisualStyleBackColor = true;
            this.chbMilitaryClothes.CheckedChanged += new System.EventHandler(this.chbMilitaryClothes_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(93, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "Оберіть категорію";
            // 
            // ChoiceOfCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chbMilitaryClothes);
            this.Controls.Add(this.chbOveralls);
            this.Controls.Add(this.chbCivilClothes);
            this.Controls.Add(this.btnNewClothes);
            this.Controls.Add(this.btnGoBack);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "ChoiceOfCategory";
            this.Text = "YFCloset";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnNewClothes;
        private System.Windows.Forms.CheckBox chbCivilClothes;
        private System.Windows.Forms.CheckBox chbOveralls;
        private System.Windows.Forms.CheckBox chbMilitaryClothes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGoBack;
    }
}