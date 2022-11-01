using System;
using System.Collections.Generic;
using System.Linq;
namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songInput = Console.ReadLine().Split(", ");
            Queue<string> songPlaylist = new Queue<string>(songInput);

            while (true)
            {
                if (songPlaylist.Count <= 0)
                {
                    Console.WriteLine("No more songs!");
                    break;
                }
                string command = Console.ReadLine();
                string[] tokens = command.Split(' ');
                if (tokens[0] == "Play")
                {
                    songPlaylist.Dequeue();
                }
                else if (tokens[0] == "Add")
                {
                    string songToBeAdded = command.Substring(4);
                    if (songPlaylist.Contains(songToBeAdded))
                    {
                        Console.WriteLine($"{songToBeAdded} is already contained!");
                        continue;
                    }
                    songPlaylist.Enqueue(songToBeAdded);
                }
                else if (tokens[0] == "Show")
                {
                    string[] songPlaylistToArray = songPlaylist.ToArray();
                    Console.WriteLine(string.Join(", ",songPlaylistToArray));
                }
            }
        }
    }
}
