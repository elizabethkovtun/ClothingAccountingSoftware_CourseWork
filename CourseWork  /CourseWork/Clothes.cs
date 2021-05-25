using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Xml;

namespace CourseWork
{
    abstract class Clothes
    {
        protected string name { get; set; }
        protected string season { get; set; }
        protected int quantity { get; set; }
        protected string mission { get; set; }
        protected string type { get; set; }
        protected string sex { get; set; }
        protected string size { get; set; }

        public string PathToFile= @"\\Mac\Home\Documents\Study\Курсовая\Курсовая\CourseWork \CourseWork\Clothes.txt";


        public Clothes(string name, string season, int quantity, string mission, string type, string sex, string size)
        {
            this.name = name;
            this.season = season;
            this.quantity = quantity;
            this.mission = mission;
            this.type = type;
            this.sex = sex;
            this.size = size;
        }


        abstract protected void WriteToFile();

        public void WriteFile()
        {
            WriteToFile();
        }


    }
}
