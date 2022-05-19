double centuryNum = 0;
Console.Write("Please enter an integer number of century: ");
centuryNum = Math.Truncate(Convert.ToDouble(Console.ReadLine()));
double yearNum = centuryNum * 100;
double dayNum = Math.Truncate(yearNum * 365.242199);
double hourNum = Math.Truncate(dayNum * 24);
double minNum = Math.Truncate(hourNum * 60);
double secNum = Math.Truncate(minNum * 60);
double millisecNum = Math.Truncate(secNum * 1000);
double microsecNum = Math.Truncate(millisecNum * 1000);
double nanosecNum = Math.Truncate(microsecNum * 1000);

Console.WriteLine($"{centuryNum} centuries = {yearNum} years = {dayNum} days = {hourNum} hours " +
    $"= {minNum} minutes = {secNum} seconds = {millisecNum} milliseconds = {microsecNum} microseconds " +
    $"= {nanosecNum} nanoseconds");