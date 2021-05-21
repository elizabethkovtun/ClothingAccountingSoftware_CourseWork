using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace CourseWork
{
    class MilitaryClothes : Clothes
    {
        protected string comouflage { get; set; }

        public MilitaryClothes(string name, string season, int quantity, string mission, string type, string sex, string size, string comouflage) : base(name, season, quantity, mission, type, sex, size)
        {
            this.comouflage = comouflage;
        }
        public override string ToString() => $"Військовий одяг: Назва: {name}, Кількість: {quantity}, Сезон: {season}, Призначення: {mission}, Вид одягу: {type}, Cтать: {sex}, Розмір: {size}, Маскування: {comouflage}";

        protected override void WriteToFile()
        {
            string text = ToString();
            string appendText = text + Environment.NewLine;
            File.AppendAllText(PathToFile, appendText);
        }

    }
}
