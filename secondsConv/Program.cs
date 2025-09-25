// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter amount of seconds");
Console.WriteLine();
int secondsInput = int.Parse(Console.ReadLine());
double dseconds = Convert.ToDouble(secondsInput);
int restSeconds = secondsInput % 60;
int minutes = secondsInput / 60;

int restMinutes = minutes % 60;
int hours = minutes / 60;

int restHours = hours % 24;
int days = hours / 24;
double ddays = dseconds / 86400;
Console.WriteLine($"seconds: {restSeconds}");
Console.WriteLine($"Minutes: {restMinutes}");
Console.WriteLine($"Hours: {restHours}");
Console.WriteLine($"Days: {days}");
Console.WriteLine($"D{days}.H{restHours}:M{restMinutes}:S{restSeconds}");
Console.WriteLine($"That is {ddays} days in total");