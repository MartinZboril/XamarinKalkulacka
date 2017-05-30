using org.mariuszgromada.math.mxparser;
using SmartCalculator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCalculator.Math
{
    public class MathOperation
    {
        /// <summary>
        /// Metoda pro deleni
        /// </summary>
        /// <param name="formula">Vzorec</param>
        /// <param name="number1">Prvni cislo vzorce ktere uzivatel zada</param>
        /// <param name="number2">Druhe cislo vzorce ktere uzivatel zada</param>
        /// <returns>Vysledek po vypoctu</returns>
        public double Division(FormulasModel formula, double number1, double number2)
        {
            String example = number1 + "/" + number2;
            double result = new Expression(example).calculate();
            return result;
        }

        /// <summary>
        /// Metoda pro nasobeni
        /// </summary>
        /// <param name="formula">Vzorec</param>
        /// <param name="number1">Prvni cislo vzorce ktere uzivatel zada</param>
        /// <param name="number2">Druhe cislo vzorce ktere uzivatel zada</param>
        /// <returns>Vysledek po vypoctu</returns>
        public double Multiplication(FormulasModel formula, double number1, double number2)
        {
            String example = number1 + "*" + number2;
            double result = new Expression(example).calculate();
            return result;
        }

        /// <summary>
        /// Metoda pro upravene nasobeni
        /// </summary>
        /// <param name="formula">Vzorec</param>
        /// <param name="number1">Prvni cislo vzorce ktere uzivatel zada</param>
        /// <param name="number2">Druhe cislo vzorce ktere uzivatel zada</param>
        /// <returns>Vysledek po vypoctu</returns>
        public double SpecialMultiplication(FormulasModel formula, double number1, double number2)
        {
            String example = number1 + "*" + number2 + "*" + number2;
            double result = new Expression(example).calculate();
            return result;
        }
    }
}
