//find the first non repeted char in a sentence


string str1 = Console.ReadLine();
string str=str1.ToLower();
foreach(char c in str)
{
    if (str.IndexOf(c) == str.LastIndexOf(c))
    {
        Console.WriteLine(c);
        return;
    }
}
Console.WriteLine("no non-repeted character");