using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace SmartCalculator
{
    public class Result
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Formula { get; set; }
        public string NameValue1 { get; set; }
        public string Value1 { get; set; }
        public string NameValue2 { get; set; }
        public string Value2 { get; set; }
        public string ResultValue { get; set; }
        public DateTime DateOfCreate { get; set; }
        public string Favourite { get; set; }

        public Result()
        {
        }

        public override string ToString()
        {
            return "ID" + ID + " Name " + Name + " Type " + Type + " Formula " + Formula + " First " + NameValue1 + " " + Value1 + " Second " + NameValue2 + " " + Value2 + " Vysledek " + ResultValue;
        }
    }
}
