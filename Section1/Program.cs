using System;
using System.Threading.Tasks;
using DadJokesLibrary;

namespace DadJokesApp
{
    class Program
    {
       static async Task Main(string[] args)
        {
            //  JokeGenerator jokeGenerator = new JokeGenerator()
            string jokeString = await JokeGenerator.GetRandomJokeAsync();
            Console.WriteLine(jokeString);

        }
    }
}

