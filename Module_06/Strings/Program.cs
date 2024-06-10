string myString = "Shivam";

int length = myString.Length;
string upper = myString.ToUpper();
string lower = myString.ToLower();

bool b = myString.Contains("Shi");

string s = myString.Replace("a", "b");
string sub = myString.Substring(1, 3);
//Console.WriteLine(sub);
//Console.WriteLine(String.Concat(s, sub));
string filepath = @"C:\demo\demo\file.txt";

bool.TryParse("true", out bool a);
if(int.TryParse("12.3", out int c))
{
    Console.WriteLine("Parse success");
}
else
{
    Console.WriteLine("Parse Failed");
}

