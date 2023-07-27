using SubjectManager.Shared.ValueObjects;

namespace SubjectManager.Domain.ValueObjects;

public class Period : ValueObject
{
    public Period(string tittle)
    {
        var model = tittle.Split(".");
        Year = int.Parse(model[0]);
        YearSection = int.Parse(model[1]);
    }

    public Period(int year, int yearSection)
    {
        Year = year;
        YearSection = yearSection;
    }

    public int Year { get; private set; }
    public int YearSection { get; private set; }

    public override string ToString()
    {
        return $"{Year}.{YearSection}";
    }

    public bool Equals(Period period)
    {
        return Year == period.Year && YearSection == period.YearSection;
    }
}