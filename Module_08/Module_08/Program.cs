using System.Text;
using Module_08;
using Module_08.Accounting;
using Module_08.HR;

StringBuilder s =  new StringBuilder();
s.AppendLine("Shivam");
s.AppendLine("Agarwal");
string s_string = s.ToString();
Console.WriteLine(s_string);
Console.WriteLine(s);

List<string> list =  new List<string>();

WorkTask work;
work.Name = "Shivam";
work.Id = 1;
WorkTask work1 = work;
work.Work();
work1.Work();

work1.Id = 10;

work.Work();
work1.Work();

Employee employee = new Employee("Shivam", "Agarwal", "@gmail.com", new DateTime(1999, 12, 30));


Employee emp1 = new Employee("Shivam", "Agarwal", "@gmail.com", new DateTime(1999, 12, 30));
emp1.PerformWork();
//emp1 = null;
//emp1.PerformWork();

int? a = null;
int b = 10;

int? c = a ?? 10;
int d = c.Value;

GC.Collect();

string s1 = "123";
string s2 = "123";
string s3 = new string("123");
Console.WriteLine(s1 == s2);
Console.WriteLine(s1 == s3);

String s4 = "123";
String s5 = "123";
String s6 = new String(s1);
Console.WriteLine(s4 == s5);
Console.WriteLine(s4 == s6);


Account acc = new Account("123123123");
//acc.accountNumber = "!@3";
Console.WriteLine(acc.accountNumber);

int[] arr = new int[3];
int[] arr1 = { 1, 2, 4};

Console.WriteLine(arr1);

foreach(int i in arr1)
{
    Console.WriteLine(i);
}

Array.Reverse(arr1);
foreach (int i in arr1)
{
    Console.WriteLine(i);
}
Array.Sort(arr1);
foreach (int i in arr1)
{
    Console.WriteLine(i);
}

arr1.CopyTo(arr, 0);
foreach (int i in arr)
{
    Console.WriteLine(i);
}
Array.Reverse(arr1);
foreach (int i in arr1)
{
    Console.WriteLine(i);
}
foreach (int i in arr)
{
    Console.WriteLine(i);
}
List<int> list1  = new List<int>();
list1.Add(1);
list1.Add(2);
list1.Add(3);
list1.Remove(3);
Console.WriteLine(list1[1]);

int[] arr2 = list1.ToArray();

