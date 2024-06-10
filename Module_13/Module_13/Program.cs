using System.IO;
//string directory = @"D:\Learning to Code\PluralSight - UKG\C# Fundamentals\Module_13\Module_13\";
//string file = "file.txt";


//Console.WriteLine(Directory.Exists(directory));
//if (!File.Exists(directory + file))
//{
//    File.Create(directory + file);
//}

//string[] lines = File.ReadAllLines(directory + file);
//File.WriteAllLines(directory + file, lines);

string s = Console.ReadLine();
//int b = int.Parse(s);
try
{
    int a = int.Parse(s);
}
catch (FormatException e)
{
    Console.WriteLine(e);
    return;
}
finally { Console.WriteLine("Finally"); }