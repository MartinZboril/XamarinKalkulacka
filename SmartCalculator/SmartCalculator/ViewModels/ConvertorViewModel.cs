using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartCalculator.Model;
using UnitsNet.Units;
using UnitsNet;
using SmartCalculator.Units;
using org.mariuszgromada.math.mxparser.parsertokens;

namespace SmartCalculator.ViewModels
{
    public class ConvertorViewModel
    {
        MyUnit myunit = new MyUnit();
        public double GetResult(ConvertorModel convertor, string prevUnit, string example, string newUnit)
        {
            double result = 0;
            double prevValue = double.Parse(example);

            // Vyber co se bude prevadet dle nazvu
            if (convertor.Name.Equals("Délka"))
            {
                result = GetLengthResult(prevUnit, prevValue, newUnit);
            } else if(convertor.Name.Equals("Hmotnost"))
            {
                result = GetWeightResult(prevUnit, prevValue, newUnit);
            } else if(convertor.Name.Equals("Teplota"))
            {
                result = GetTemperatureResult(prevUnit, prevValue, newUnit);
            } else if (convertor.Name.Equals("Rychlost"))
            {
                result = GetSpeedResult(prevUnit, prevValue, newUnit);
            }
            else if (convertor.Name.Equals("Plocha"))
            {
                result = GetAreaResult(prevUnit, prevValue, newUnit);
            }
            else if (convertor.Name.Equals("Čas"))
            {
                result = GetTimeResult(prevUnit, prevValue, newUnit);
            }

            return result;
        }

        /// Prevedeni /// 

        public double GetLengthResult(string prevUnit, double prevValue, string newUnit)
        {
            // Urceni co se bude prevadet
            var prevHeight = Length.From(prevValue, GetLengthUnit(prevUnit));

            // Prevedeni na novou jednotku
            double newHeightValue = prevHeight.As(GetLengthUnit(newUnit));
            double result = newHeightValue;
            return result;
        }

        public double GetWeightResult(string prevUnit, double prevValue, string newUnit)
        {
            var prevWeight = Mass.From(prevValue, GetWeightUnit(prevUnit));
            double newWeightValue = prevWeight.As(GetWeightUnit(newUnit));
            double result = newWeightValue;
            return result;
        }

        public double GetTemperatureResult(string prevUnit, double prevValue, string newUnit)
        {
            var prevTemperature = Temperature.From(prevValue, GetTemperatureUnit(prevUnit));
            double newTemperatureValue = prevTemperature.As(GetTemperatureUnit(newUnit));
            double result = newTemperatureValue;
            return result;
        }

        public double GetSpeedResult(string prevUnit, double prevValue, string newUnit)
        {
            var prevSpeed = Speed.From(prevValue, GetSpeedUnit(prevUnit));
            double newSpeedValue = prevSpeed.As(GetSpeedUnit(newUnit));
            double result = newSpeedValue;
            return result;
        }

        public double GetAreaResult(string prevUnit, double prevValue, string newUnit)
        {
            var prevArea = Area.From(prevValue, GetAreaUnit(prevUnit));
            double newAreaValue = prevArea.As(GetAreaUnit(newUnit));
            double result = newAreaValue;
            return result;
        }

        public double GetTimeResult(string prevUnit, double prevValue, string newUnit)
        {
            var prevTime = Duration.From(prevValue, GetTimeUnit(prevUnit));
            double newTimeValue = prevTime.As(GetTimeUnit(newUnit));
            double result = newTimeValue;
            return result;
        }

        /// Metody pro ziskani jednotek k naslednemu prevedeni ///

        public LengthUnit GetLengthUnit(string unit)
        {
            LengthUnit lengthUnit = myunit.GetLengthUnit(unit);
            return lengthUnit;
        }

        public MassUnit GetWeightUnit(string unit)
        {
            MassUnit weightUnit = myunit.GetWeightUnit(unit);
            return weightUnit;
        }

        public TemperatureUnit GetTemperatureUnit(string unit)
        {
            TemperatureUnit temperaturelengthUnit = myunit.GetTemperatureUnit(unit);
            return temperaturelengthUnit;
        }

        public SpeedUnit GetSpeedUnit(string unit)
        {
            SpeedUnit speedUnit = myunit.GetSpeedUnit(unit);
            return speedUnit;
        }

        public AreaUnit GetAreaUnit(string unit)
        {
            AreaUnit areaUnit = myunit.GetAreaUnit(unit);
            return areaUnit;
        }

        public DurationUnit GetTimeUnit(string unit)
        {
            DurationUnit areaUnit = myunit.GetTimeUnit(unit);
            return areaUnit;
        }
    }
}