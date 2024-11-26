string s1 = "hight";
string s2 = "gustion";
string s3 = "rad";
int result = string.Compare(s1, s2);
if (result < 0)
{
    Console.WriteLine("Строка s1 перед строкой s2");
}
else if (result > 0)
{
    Console.WriteLine("Строка s1 стоит после строки s2");
}
else
{
    Console.WriteLine("Строки s1 и s2 идентичны");
}
char ch ='g';
int g =s1.IndexOf(ch);
Console.WriteLine(g);
Console.WriteLine( s1.Equals(ch));
Console.WriteLine(s2.Equals(ch));
Console.WriteLine(s1.Contains(s3));
Console.WriteLine(string.CompareOrdinal(s2,s1));
 if (s1 == s2)
{
    Console.WriteLine("Строки одинаковые");
}
 else if(s1 != s2)
{
    Console.WriteLine("Строки разные");   
}

