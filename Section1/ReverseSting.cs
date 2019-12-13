using System;

namespace Section1
{
    class Reverse
    {
    static void Main(string[] args)
    {

string str = "", reverse = "";
int Lenght = 0;
Console.WriteLine("Enter a Word");

str = Console.ReadLine();

Lenght = str.Length - 1;
while(Lenght>=0)

{
    reverse = reverse + str[Lenght];
    Lenght--;
}
Console.WriteLine("Reverse word is {0}", reverse);
Console.ReadLine();


}

}
}
