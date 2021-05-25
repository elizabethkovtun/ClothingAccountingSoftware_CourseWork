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
    class CivilClothes : Clothes
    {
        public CivilClothes(string name, string season, int quantity, string mission, string type, string sex, string size) : base(name, season, quantity, mission, type, sex, size)
        { }
        public override string ToString() => $"Цивільний одяг: Назва: {name}, Кількість: {quantity}, Сезон: {season}, Призначення: {mission}, Вид одягу: {type}, Cтать: {sex}, Розмір: {size}";

        protected override void WriteToFile()
        {
            string text = ToString();
            string appendText = text + Environment.NewLine;
            File.AppendAllText(PathToFile, appendText);
        }

    }
 }
