using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SmartCalculator.Model
{
    public class FormulasModel
    {
        public string Name { get; set; }          
        public string Type { get; set; }
        public string Unit { get; set; }
        public string Formula { get; set; }
        public string FirstValue { get; set; }
        public string FirstValueUnit { get; set; }
        public string SecondValue { get; set; }
        public string SecondValueUnit { get; set; }
    }
}
