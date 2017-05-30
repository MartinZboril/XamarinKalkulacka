using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartCalculator.Model;
using org.mariuszgromada.math.mxparser;
using System.Collections.ObjectModel;
using System.Collections;
using SmartCalculator.Math;

namespace SmartCalculator.ViewModels
{
    public class FormulasViewModel
    {
        MathOperation mymath = new MathOperation();
        public FormulasViewModel()
        {

        }

        public double GetResult(FormulasModel formula, double number1, double number2)
        {
            double result = 0;

            /// Vyber vzorce dle nazvu /// 

            if (formula.Name.Equals("Výkon"))
            {
                result = GetPerformanceResult(formula, number1, number2);
            } else if(formula.Name.Equals("Rychlost"))
            {
                result = GetSpeedResult(formula, number1, number2);
            }
            else if (formula.Name.Equals("Tlak"))
            {
                result = GetSpeedResult(formula, number1, number2);
            }
            else if (formula.Name.Equals("Práce"))
            {
                result = GetWorkResult(formula, number1, number2);
            }
            else if (formula.Name.Equals("Proud"))
            {
                result = GetCurrentResult(formula, number1, number2);
            }
            else if (formula.Name.Equals("Odpor"))
            {
                result = GetResistanceResult(formula, number1, number2);
            }
            else if (formula.Name.Equals("Napětí"))
            {
                result = GetTensionResult(formula, number1, number2);
            }
            else if (formula.Name.Equals("Kmitočet"))
            {
                result = GetResistanceResult(formula, number1, number2);
            }
            else if (formula.Name.Equals("Energie"))
            {
                result = GetEnergyResult(formula, number1, number2);
            }

            return result;
        }
        
        /// Metody ke spocitani vzorce ///

        public double GetPerformanceResult(FormulasModel formula, double number1, double number2)
        {

            double result = mymath.Division(formula, number1, number2); 
            return result;
        }

        public double GetSpeedResult(FormulasModel formula, double number1, double number2)
        {
            double result = mymath.Division(formula, number1, number2);
            return result;
        }

        public double GetPressureResult(FormulasModel formula, double number1, double number2)
        {
            double result = mymath.Division(formula, number1, number2);
            return result;
        }

        public double GetWorkResult(FormulasModel formula, double number1, double number2)
        {
            double result = mymath.Multiplication(formula, number1, number2);
            return result;
        }

        public double GetCurrentResult(FormulasModel formula, double number1, double number2)
        {
            double result = mymath.Division(formula, number1, number2);
            return result;
        }

        public double GetResistanceResult(FormulasModel formula, double number1, double number2)
        {
            double result = mymath.Division(formula, number1, number2);
            return result;
        }

        public double GetTensionResult(FormulasModel formula, double number1, double number2)
        {
            double result = mymath.Multiplication(formula, number1, number2);
            return result;
        }

        public double GetFrequenceResult(FormulasModel formula, double number1, double number2)
        {
            double result = mymath.Division(formula, number1, number2);
            return result;
        }

        public double GetEnergyResult(FormulasModel formula, double number1, double number2)
        {
            double result = mymath.SpecialMultiplication(formula, number1, number2);
            return result;
        }
    }
}
