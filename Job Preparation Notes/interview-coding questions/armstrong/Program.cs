int x=int.Parse(Console.ReadLine());
int temp = x;
int sum = 0;

while (x > 0) { 
int mod = x % 10;
 sum=sum+ mod*mod*mod;
x=x/10;}
//Console.WriteLine(sum);
if (temp == sum)
{
    Console.WriteLine("The Number is an armstrong number" );
}
else { Console.WriteLine("The Number is not an armstrong number"); }
