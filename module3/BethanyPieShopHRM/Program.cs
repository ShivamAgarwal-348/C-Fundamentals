
Console.WriteLine("Welcome to Bethany's Pie Shop HRM");
Console.WriteLine("Please enter your name");

//string name = Console.ReadLine();
int c = 2;
bool isActive = false;
double rating = 22.343;
byte numberOfEmployees = 125;
const double interestRate = 0.07;
//c = true;
//string name2 = Console.ReadLine();

string firstName = "Bethany";
string lastName = "Smith";
string emptyString = string.Empty;

Console.WriteLine(rating);
char mychar = 'a';
Console.WriteLine(char.ToUpper(mychar));

DateTime hireDate = new DateTime(2024, 6, 7, 23, 35, 0);
Console.WriteLine(hireDate);

DateTime exitDate = new DateTime(2025, 5, 12);
DateTime startDate = hireDate.AddDays(15);

DateTime startHour = DateTime.Now;
TimeSpan workTime = new TimeSpan(8, 35, 0);
DateTime endHour = startHour.Add(workTime);
Console.WriteLine(endHour);

double d = 34534.345;
int d_int = (int)d;
Console.WriteLine(d_int);

var a = Console.ReadLine();
Console.WriteLine(a.GetType());