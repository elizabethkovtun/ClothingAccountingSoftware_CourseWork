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
    class Overalls : Clothes
    {

        protected  string type_protection { get; set; }
        protected int level_of_protection { get; set; }

        public Overalls(string name, string season, int quantity, string mission, string type, string sex, string size, string type_protection,int level_of_protection) : base(name, season, quantity, mission, type, sex, size)
        {
            this.type_protection = type_protection;
            this.level_of_protection = level_of_protection;
        }

        public override string ToString() => $"Спец.одяг Назва: {name}, Кількість: {quantity}, Сезон: {season}, Призначення: {mission}, Вид одягу: {type}, Cтать: {sex}, Розмір: {size}, Тип захисту: {type_protection}, Рівень захисту: {level_of_protection}";

        protected override void WriteToFile()
        {
            string text = ToString();
            string appendText = text + Environment.NewLine;
            File.AppendAllText(PathToFile, appendText);
        }
    }
}
