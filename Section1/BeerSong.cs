using System;
 namespace Section1{
     
 }
  class BeerSong
{
    static void main (string[] args)
    {
        for (int song = 99; song > -1; song--)
        {
            if (song == 0)
            {
                Console.WriteLine("No more bottles of beer on the wall, no more bottles of beer.");
                Console.WriteLine("Go to the store and buy some more, 99 bottles of beer on the wall.");
                
            }
            if (song == 1)
            {
                Console.WriteLine("1 bottle of beer on the wall, 1 bottle of beer.");
                Console.WriteLine("Take one down and pass it around, no more bottles of beer on the wall.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("{0} bottles of beer on the wall, {0} bottles of beer.", song);
                Console.WriteLine("Take one down and pass it around, {0} bottles of beer on the wall.", song - 1);
                Console.WriteLine();
            }
        }
    }
}