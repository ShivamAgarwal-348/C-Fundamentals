int age = 23;

bool ageValid = (age >= 18) && (age <= 65);
Console.WriteLine(ageValid);

if (ageValid == true)
{
    Console.WriteLine(ageValid);
}
else
{
    Console.WriteLine(ageValid);
}

switch (ageValid)
{
    default:
        Console.WriteLine("default");
        break;
    case true:
        Console.WriteLine(ageValid);
        break;
    case false:
        Console.WriteLine(ageValid);
        break;
}

int max = int.Parse(Console.ReadLine());
int i = 0;

while (i < max)
{
    Console.WriteLine(i++);
}
i = 0;
int j = 0;

while (i < 10)
{
    while (j < 10)
    {
        Console.WriteLine(i + " " + j++);
    }
    j = 0;
    i++;
}

for (i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}