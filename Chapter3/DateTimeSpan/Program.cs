UseDatesAndTimes();

static void UseDatesAndTimes()
{
    Console.WriteLine("***** Dates and Times *****\n");

    // DateTime dt = new(2024, 6, 1, 7, 30, 0);
    DateTime dt = DateTime.Parse("2024-06-01 07:30:00");
    Console.WriteLine($"The date/time is: {dt}");
    Console.WriteLine($"The day of the week is: {dt.DayOfWeek}");
    Console.WriteLine($"The day of the year is: {dt.DayOfYear}");
    Console.WriteLine();

    DateTime dt2 = dt.AddMonths(6);
    Console.WriteLine($"dt2 (dt + six months) is: {dt2.ToLongDateString()}");
    Console.WriteLine($"Daylight saving time? {dt2.IsDaylightSavingTime()}");
    Console.WriteLine();

    TimeSpan ts = new(4, 30, 0);
    Console.WriteLine($"Time span: {ts}");
    Console.WriteLine($"Minus 15 minutes: {ts.Subtract(new TimeSpan(0, 15, 0))}");
    Console.WriteLine();

    DateOnly do1 = DateOnly.FromDateTime(DateTime.Today);
    Console.WriteLine($"DateOnly instance: {do1}");

    TimeOnly to1 = TimeOnly.FromDateTime(DateTime.Now);
    Console.WriteLine($"TimeOnly instance: {to1}");

    // Another factory method -- Parse
    DateOnly do2 = DateOnly.Parse("2024-01-15");
    Console.WriteLine($"Parsed DateOnly: {do2}");

}
