using System;
using static UnitBase;

public class UnitBase
{
    public enum UnitType
    {
        Length,
        Weight
    }

    public enum UnitSystem
    {
        Imperal,
        Metric
    }

    public enum ShortName
    {
        //meteric in size order
        Qm,
        Rm,
        Ym,
        Zm,
        Em,
        Pm,
        Tm,
        Gm,
        Mm,
        km,
        hm,
        dam,
        m,
        dm,
        cm,
        mm,
        µm,
        nm,
        pm,
        fm,
        am,
        zm,
        ym,
        rm,
        qm,
        //imperial in size order
        nmi,
        cbl,
        mi,
        fur,
        ch,
        ftm,
        yd,
        ft,
        hh,
        @in,
        b,
        th
    }

    public enum LongName
    {
        //meteric in size order
        Quettameter,
        Ronnameter,
        Yottameter,
        Zettameter,
        Exameter,
        Petameter,
        Terameter,
        Gigameter,
        Megameter,
        Kilometer,
        Hectometer,
        Dekameter,
        Meter,
        Decimeter,
        Centimeter,
        Milimeter,
        Micrometer,
        Nanometer,
        Picometer,
        Femtometer,
        Attometer,
        Zeptometer,
        Yoktometer,
        Rontometer,
        Quectometer,
        //imperial in size order
        Nauticalmile,
        Cable,
        Mile,
        Furlong,
        Chain,
        Fathom,
        Yard,
        Foot,
        Hand,
        Inch,
        Barleycorn,
        Thou
    }

    public struct Unit
    {
        public UnitSystem unitSystem;
        public UnitType unitType;
        public double unitFactor;
        public ShortName shortName;
        public LongName longName;

        public Unit(UnitSystem unitSystem, UnitType unitType, double unitFactor, ShortName shortName, LongName longName)
        {
            this.unitSystem = unitSystem;
            this.unitType = unitType;
            this.unitFactor = unitFactor;
            this.shortName = shortName;
            this.longName = longName;
        }
    }

    //Ain't no way to make this look prettier besides loading it from some file or db or cloud or brainwaves
    public readonly static Unit[] units =
    {
        //this is why metric is nice
        //metric in size order
        new Unit(UnitSystem.Metric, UnitType.Length, 1e-30d, ShortName.Qm, LongName.Quettameter),
        new Unit(UnitSystem.Metric, UnitType.Length, 1e-27d, ShortName.Rm, LongName.Ronnameter),
        new Unit(UnitSystem.Metric, UnitType.Length, 1e-24d, ShortName.Ym, LongName.Yottameter),
        new Unit(UnitSystem.Metric, UnitType.Length, 1e-12d, ShortName.Zm, LongName.Zettameter),
        new Unit(UnitSystem.Metric, UnitType.Length, 1e-18d, ShortName.Em, LongName.Exameter),
        new Unit(UnitSystem.Metric, UnitType.Length, 1e-15d, ShortName.Pm, LongName.Petameter),
        new Unit(UnitSystem.Metric, UnitType.Length, 1e-12d, ShortName.Tm, LongName.Terameter),
        new Unit(UnitSystem.Metric, UnitType.Length, 1e-9d, ShortName.Gm, LongName.Gigameter),
        new Unit(UnitSystem.Metric, UnitType.Length, 1e-6d, ShortName.Mm, LongName.Megameter),
        new Unit(UnitSystem.Metric, UnitType.Length, 0.001d, ShortName.km, LongName.Kilometer),
        new Unit(UnitSystem.Metric, UnitType.Length, 0.01d, ShortName.hm, LongName.Hectometer),
        new Unit(UnitSystem.Metric, UnitType.Length, 0.1d, ShortName.dam, LongName.Dekameter),
        new Unit(UnitSystem.Metric, UnitType.Length, 1d, ShortName.m, LongName.Meter), //Base
        new Unit(UnitSystem.Metric, UnitType.Length, 10d, ShortName.dm, LongName.Decimeter),
        new Unit(UnitSystem.Metric, UnitType.Length, 100d, ShortName.cm, LongName.Centimeter),
        new Unit(UnitSystem.Metric, UnitType.Length, 1000d, ShortName.mm, LongName.Milimeter),
        new Unit(UnitSystem.Metric, UnitType.Length, 1000000d, ShortName.µm, LongName.Micrometer),
        new Unit(UnitSystem.Metric, UnitType.Length, 1000000000d, ShortName.nm, LongName.Nanometer),
        new Unit(UnitSystem.Metric, UnitType.Length, 1000000000000d, ShortName.pm, LongName.Picometer),
        new Unit(UnitSystem.Metric, UnitType.Length, 1e+15d, ShortName.fm, LongName.Femtometer),
        new Unit(UnitSystem.Metric, UnitType.Length, 1e+18d, ShortName.am, LongName.Attometer),
        new Unit(UnitSystem.Metric, UnitType.Length, 1e+21d, ShortName.zm, LongName.Zeptometer),
        new Unit(UnitSystem.Metric, UnitType.Length, 1e+24d, ShortName.ym, LongName.Yoktometer),
        new Unit(UnitSystem.Metric, UnitType.Length, 1e+27d, ShortName.rm, LongName.Rontometer),
        new Unit(UnitSystem.Metric, UnitType.Length, 1e+30d, ShortName.qm, LongName.Quectometer),
        //imperial is a fever dream if you ask me
        //imperial in size order
        new Unit(UnitSystem.Imperal, UnitType.Length, 0.000493736501d, ShortName.nmi, LongName.Nauticalmile),
        new Unit(UnitSystem.Imperal, UnitType.Length, 0.000568181818d, ShortName.mi, LongName.Mile),
        new Unit(UnitSystem.Imperal, UnitType.Length, 0.004934210526d, ShortName.cbl, LongName.Cable),
        new Unit(UnitSystem.Imperal, UnitType.Length, 0.00454545455d, ShortName.fur, LongName.Furlong),
        new Unit(UnitSystem.Imperal, UnitType.Length, 0.0454545455d, ShortName.ch, LongName.Chain),
        new Unit(UnitSystem.Imperal, UnitType.Length, 0.5d, ShortName.ftm, LongName.Fathom),
        new Unit(UnitSystem.Imperal, UnitType.Length, 1d, ShortName.yd, LongName.Yard), //Base
        new Unit(UnitSystem.Imperal, UnitType.Length, 3d, ShortName.ft, LongName.Foot),
        new Unit(UnitSystem.Imperal, UnitType.Length, 9d, ShortName.hh, LongName.Hand),
        new Unit(UnitSystem.Imperal, UnitType.Length, 36d, ShortName.@in, LongName.Inch),
        new Unit(UnitSystem.Imperal, UnitType.Length, 108d, ShortName.b, LongName.Barleycorn),
        new Unit(UnitSystem.Imperal, UnitType.Length, 36000d, ShortName.th, LongName.Thou)
    };

    public static Unit GetUnitByShortName(string shortName)
    {
        return Array.Find(units, item => item.shortName.ToString() == shortName);
    }

    public static Unit GetUnitByLongName(string longName)
    {
        return Array.Find(units, item => item.longName.ToString().ToLower() == longName.ToLower());
    }

    //no need to copy I am only reading
    public static bool IsShortName(ref string name)
    {
        if(name.Length <= 3)
            return true;

        return false;
    }
}

public class UnitStore
{
    public Unit unit;
    public double value;
    public Unit convertToUnit;
    public bool useShortName;

    public UnitStore(Unit unit, double value, Unit convertToUnit, bool useShortName)
    {
        this.unit = unit;
        this.value = value;
        this.convertToUnit = convertToUnit;
        this.useShortName = useShortName;
    }

    public string Print()
    {
        if(useShortName)
            return value.ToString() + " " + unit.shortName;
        else
            return value.ToString() + " " + unit.longName;
    }

    public void Convert()
    {
        switch(unit.unitSystem)
        {
            case UnitSystem.Imperal:

                switch(convertToUnit.unitSystem)
                {
                    case UnitSystem.Imperal:
                        ToBase();
                        ToUnit();
                        break;

                    case UnitSystem.Metric:
                        ToBase();
                        ToMetric();
                        ToUnit();
                        break;
                }
                break; 

            case UnitSystem.Metric:

                switch(convertToUnit.unitSystem)
                {
                    case UnitSystem.Imperal:
                        ToBase();
                        ToImperial();
                        ToUnit();
                        break;

                    case UnitSystem.Metric:
                        ToBase();
                        ToUnit();
                        break;
                }
                break;
        }

        unit = convertToUnit;
    }

    void ToBase()
    {
        if(unit.unitFactor < convertToUnit.unitFactor)
            value *= unit.unitFactor;
        else
            value /= unit.unitFactor;
    }

    void ToMetric()
    {
        value *= 0.9144;
    }

    void ToImperial()
    {
        value *= 1.09361;
    }

    void ToUnit()
    {
        if(unit.unitFactor < convertToUnit.unitFactor)
            value = convertToUnit.unitFactor / value;
        else
            value *= convertToUnit.unitFactor;
    }

}



