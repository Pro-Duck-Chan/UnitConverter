using System.Collections.Generic;
using static UnitBase;

public class Converter
{
    public static List<UnitStore> Validate(string[] values)
    {
        List<UnitStore> units = new List<UnitStore>();

        int a = 0;
        //for loop is king in the proformance world
        for (int i = 0; i < values.Length / 3; i++)
        {
            Unit unit = new Unit();
            Unit convertToUnit = new Unit();
            double value = 0;
            bool useShortName = false;

            if (double.TryParse(values[a], out double result))
                value = result;

            if (IsShortName(ref values[a + 1]))
                unit = GetUnitByShortName(values[a + 1]);
            else
                unit = GetUnitByLongName(values[a + 1]);

            if(IsShortName(ref values[a + 2]))
            {
                convertToUnit = GetUnitByShortName(values[a + 2]);
                useShortName = true;
            }
            else
                convertToUnit = GetUnitByLongName(values[a + 2]);

            if (!unit.Equals(default(Unit)) && value != 0 && !convertToUnit.Equals(default(Unit)))
                units.Add(new UnitStore(unit, value, convertToUnit, useShortName));
            else
                ErrorHandler.RaportError("Incorrect format or incorrect unit", i + 1);

            a += 3;
        }

        return units;
    }

    public static void Convert(ref List<UnitStore> unitStore)
    {
        for (int i = 0; i < unitStore.Count; i++)
        {
            unitStore[i].Convert();
        }
    }
}