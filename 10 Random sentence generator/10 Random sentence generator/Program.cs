using System;
using System.Collections.Generic;
using System.Linq;

namespace _10_Random_sentence_generator
{
    class Program
    {
        static List<string> zaimki = new List<string>() { "the", "my", "your", "our", "that", "this", "every", "one", "the only", "his", "her" };
        static List<string> rzeczowniki = new List<string>() {"forest", "tree", "flower", "sky", "grass", "mountain", "car", "computer", "man", "woman", "dog",
  "elephant", "ant", "road", "butterfly", "phone", "computer program", "grandma", "school", "bed", "mouse",
  "keyboard", "bicycle", "spaghetti", "drink", "cat", "t-shirt", "carpet", "wall", "poster",
  "airport", "bridge", "road", "river", "beach", "sculpture", "piano", "guitar", "fruit",
  "banana", "apple", "strawberry", "rubber band", "saxophone", "window", "linux computer",
  "skate board", "piece of paper", "photograph", "painting", "hat", "space", "fork",
  "mission", "goal", "project", "tax", "wind mill", "light bulb", "microphone",
  "cpu", "hard drive", "screwdriver" };
        static List<string> czasowniki = new List<string>() { "sings", "dances", "was dancing", "runs", "will run", "walks",
  "flies", "moves", "moved", "will move", "glows", "glowed", "spins", "promised",
  "hugs", "cheated", "waits", "is waiting", "is studying", "swims",
  "travels", "traveled", "plays", "played", "enjoys", "will enjoy",
  "illuminates", "arises", "eats", "drinks", "calculates", "kissed", "faded", "listens",
  "navigated", "responds", "smiles", "will smile", "will succeed",
  "is wondering", "is thinking", "is", "was", "will be", "might be", "was never" };
        static List<string> przyimki = new List<string>() {  "under", "in front of", "above", "behind", "near", "following", "inside", "besides",
  "unlike", "like", "beneath", "against", "into", "beyond", "considering", "without",
  "with", "towards" };
        static List<string> przymiotniki = new List<string>() {"happy", "rotating", "red", "fast", "elastic", "smily", "unbelievable", "infinte", "surprising",
  "mysterious", "glowing", "green", "blue", "tired", "hard", "soft", "transparent", "long", "short",
  "excellent", "noisy", "silent", "rare", "normal", "typical", "living", "clean", "glamorous",
  "fancy", "handsome", "lazy", "scary", "helpless", "skinny", "melodic", "silly",
  "kind", "brave", "nice", "ancient", "modern", "young", "sweet", "wet", "cold",
  "dry", "heavy", "industrial", "complex", "accurate", "awesome", "shiny", "cool", "glittering",
  "fake", "unreal", "naked", "intelligent", "smart", "curious", "strange", "unique", "empty",
  "gray", "saturated", "blurry" };

        static void Main(string[] args)
        {
            while(true)
            {
                int wybor = 0;
                Console.WriteLine("1. Generate random sentence\n2. Quit");
                wybor = Convert.ToInt32(Console.ReadLine());
                if (wybor == 2)
                {
                    break;
                }
                switch (wybor)
                {
                    case 1:
                        {
                            Random r = new Random();
                            string zaimek = zaimki[r.Next(0, zaimki.Count)];
                            zaimek = zaimek.First().ToString().ToUpper() + String.Join("", zaimek.Skip(1));
                            string rzeczownik = rzeczowniki[r.Next(0, rzeczowniki.Count)];
                            string czasownik = czasowniki[r.Next(0, czasowniki.Count)];
                            string przyimek = przyimki[r.Next(0, przyimki.Count)];
                            string przymiotnik = przymiotniki[r.Next(0, przymiotniki.Count)];
                            string rzeczownik2 = rzeczowniki[r.Next(0, rzeczowniki.Count)];
                            string przymiotnik2 = przymiotniki[r.Next(0, przymiotniki.Count)];
                            Console.Clear();
                            Console.Write($"{zaimek} {przymiotnik} {rzeczownik} {czasownik} {przyimek} {przymiotnik2} {rzeczownik2}");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                }
               

            }
        }
    }
}
