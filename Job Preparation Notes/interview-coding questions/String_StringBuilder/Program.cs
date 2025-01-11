//String
using System.Text;

string str = "Riyad ";
str = str + "Hossain";
Console.WriteLine(str);

//Stringbuilder
StringBuilder sb =new StringBuilder("Riyad ");
sb.Append("Hossain");
sb.Insert(0, "Md "); 
Console.WriteLine(sb.ToString());