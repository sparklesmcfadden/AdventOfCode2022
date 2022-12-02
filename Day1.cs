namespace AdventOfCode2022;

public class Day1
{
    private static List<int> GetTotals()
    {
        var file = Utilities.LoadFile("data/day1_part1.txt");

        return file.Split("\n\n")
            .Select(m => m.Split("\n").Select(i => Int32.Parse(i)).Sum())
            .ToList();
    }

    public static int Part1()
    {
        return GetTotals().Max();
    }

    public static int Part2()
    {
        var totals = GetTotals();

        totals.Sort();
        return totals.TakeLast(3).Sum();
    }
}