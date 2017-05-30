using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitsNet.Units;

namespace SmartCalculator.Units
{
    public class MyUnit
    {
        /// Vyber jednotek ///
        
        // Delka
        public LengthUnit GetLengthUnit(string unit)
        {
            LengthUnit lengthUnit = new LengthUnit();
            if (unit.Equals("mm"))
            {
                lengthUnit = LengthUnit.Millimeter;
            }
            else if (unit.Equals("cm"))
            {
                lengthUnit = LengthUnit.Centimeter;
            }
            else if (unit.Equals("dm"))
            {
                lengthUnit = LengthUnit.Decimeter;
            }
            else if (unit.Equals("m"))
            {
                lengthUnit = LengthUnit.Meter;
            }
            else if (unit.Equals("km"))
            {
                lengthUnit = LengthUnit.Kilometer;
            }
            return lengthUnit;
        }

        // Hmotnost
        public MassUnit GetWeightUnit(string unit)
        {
            MassUnit weightUnit = new MassUnit();
            if (unit.Equals("mg"))
            {
                weightUnit = MassUnit.Milligram;
            }
            else if (unit.Equals("g"))
            {
                weightUnit = MassUnit.Gram;
            }
            else if (unit.Equals("dkg"))
            {
                weightUnit = MassUnit.Decagram;
            }
            else if (unit.Equals("kg"))
            {
                weightUnit = MassUnit.Kilogram;
            }
            else if (unit.Equals("t"))
            {
                weightUnit = MassUnit.Tonne;
            }
            return weightUnit;
        }

        // Teplota
        public TemperatureUnit GetTemperatureUnit(string unit)
        {
            TemperatureUnit temperaturelengthUnit = new TemperatureUnit();
            if (unit.Equals("°C"))
            {
                temperaturelengthUnit = TemperatureUnit.DegreeCelsius;
            }
            else if (unit.Equals("°F"))
            {
                temperaturelengthUnit = TemperatureUnit.DegreeFahrenheit;
            }
            else if (unit.Equals("K"))
            {
                temperaturelengthUnit = TemperatureUnit.Kelvin;
            }
            return temperaturelengthUnit;
        }

        // Rychlost
        public SpeedUnit GetSpeedUnit(string unit)
        {
            SpeedUnit speedUnit = new SpeedUnit();
            if (unit.Equals("m/s"))
            {
                speedUnit = SpeedUnit.MeterPerSecond;
            }
            else if (unit.Equals("km/h"))
            {
                speedUnit = SpeedUnit.KilometerPerHour;
            }
            else if (unit.Equals("MPH"))
            {
                speedUnit = SpeedUnit.MilePerHour;
            }
            return speedUnit;
        }

        // Delka
        public AreaUnit GetAreaUnit(string unit)
        {
            AreaUnit areaUnit = new AreaUnit();
            if (unit.Equals("mm²"))
            {
                areaUnit = AreaUnit.SquareMillimeter;
            }
            else if (unit.Equals("cm²"))
            {
                areaUnit = AreaUnit.SquareCentimeter;
            }
            else if (unit.Equals("dm²"))
            {
                areaUnit = AreaUnit.SquareDecimeter;
            }
            else if (unit.Equals("m²"))
            {
                areaUnit = AreaUnit.SquareMeter;
            }
            else if (unit.Equals("km²"))
            {
                areaUnit = AreaUnit.SquareKilometer;
            }
            return areaUnit;
        }

        // Delka
        public DurationUnit GetTimeUnit(string unit)
        {
            DurationUnit areaUnit = new DurationUnit();
            if (unit.Equals("s"))
            {
                areaUnit = DurationUnit.Second;
            }
            else if (unit.Equals("m"))
            {
                areaUnit = DurationUnit.Minute;
            }
            else if (unit.Equals("h"))
            {
                areaUnit = DurationUnit.Hour;
            }
            else if (unit.Equals("den"))
            {
                areaUnit = DurationUnit.Day;
            }
            else if (unit.Equals("týden"))
            {
                areaUnit = DurationUnit.Week;
            }
            return areaUnit;
        }
    }
}
