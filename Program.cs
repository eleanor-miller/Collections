using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

// LISTS

            // Must declare what type of list within < >, if error, use lightbulb to choose proper system
            var names = new List<string>() { "Mark", "Paula", "Sandy", "Bill" };

            var firstName = names[0];
            var secondName = names[1];
            var finalName = names[3];

            Console.WriteLine(firstName);
            Console.WriteLine(names.Count);

            names.Add("George");
            Console.WriteLine(names.Count);

            var scores = new List<int>();
            scores.Add(12);
            scores.Add(100);
            scores.Add(55);
            scores.Add(44);
            scores.Add(12);

            // listOfScores.Clear();

            var lastIndex = scores.Count - 1;
            var lastScore = scores[lastIndex];

            var indexOfFiftyFive = scores.IndexOf(55);
            Console.WriteLine($"Found 55 at index {indexOfFiftyFive}");

            // if multiples it will pull the first found can also use "LastIndexOf"
            var indexOfTwelve = scores.IndexOf(12);
            Console.WriteLine($"Found 12 at index {indexOfTwelve}");

            // Insert the number `42` so it is placed at index 2
            scores.Insert(2, 42);
            var indexOfFortyTwo = scores.IndexOf(42);
            Console.WriteLine($"Found 42 at index {indexOfFortyTwo}");

            // Remove the data - in this case number `44` only removes the first occurrence of the number
            Console.WriteLine($"Our list has {scores.Count} values");
            scores.Remove(44);
            Console.WriteLine($"Our list has {scores.Count} values");
            // .RemoveAt will remove the data at the specified index
            // .Reverse will reverse the list in place 
            // .Sort numbers < to >, names alphabetical, upper/lower case puts in sorting order

// DICTIONARIES

            var playerScores = new Dictionary<string, int>();
            // Underscores takes place of a seperator like a comma
            playerScores.Add("Naomi Osaka", 1_234_567);
            // Look up Naomi Osaka and CHANGE her score
            playerScores["Naomi Osaka"] = 3;

            playerScores["Eleanor Miller"] = 521_600;

            var naomiPlayerScore = playerScores["Naomi Osaka"];
            Console.WriteLine(naomiPlayerScore);

            var eleanorScore = playerScores["Eleanor Miller"];
            Console.WriteLine($"Eleanor's score is {eleanorScore}");

            // Ask Dictionary if it has a key.

            var hasKey = playerScores.ContainsKey("Billy Mitchell");
            if (hasKey == true)
            {
              var billyScore = playerScores["Billy Mitchell"];
              Console.Write(billyScore);
            }

// QUEUES

            //FIFO first in, first out

          var students = new Queue<string>();
          students.Enqueue("Mary");
          students.Enqueue("Bill");
          students.Enqueue("Paul");
          students.Enqueue("Sandra");
          students.Enqueue("Thomas");

          var peekStudent = students.Peek();

          var firstStudent = students.Dequeue();
          Console.WriteLine(firstStudent);

// Other collections: SortedList, Stack, HashSet, LinkedList etc. 
/*
          switch (name)
            {
              case "Paul":
              case "Peter":
              case "Mary":
                Console.WriteLine("Here");
                break;
              case "Dorothy":
                Console.WriteLine("Also Here");
                break;
              case "Sam":
                Console.WriteLine("Here Again");
                  break;
              default:
                Console.WriteLine("Didn't find anything");
                break;
            }
*/
          var score = 95;

          switch (score)
          {
            case < 65:
              Console.WriteLine("F");
              break;
            case < 70:
              Console.WriteLine("D");
              break;
            case < 80:
              Console.WriteLine("C");
              break;
            case < 90:
              Console.WriteLine("B");
              break;
            case > 90:
              Console.WriteLine("A");
              break;
            default:
              Console.WriteLine("Hmmm, I don't recognize this score");
              break;
          }
          
          // When we write this:
          //
          // var name = Console.ReadLine();
          //
          // C# is _REALLY_ doing this for us:
          string name;
          name = Console.ReadLine()  ;

          while (name != "quit")
          {
            Console.WriteLine($"Hello {name}");

            Console.Write("What is your name? ");
            name = Console.ReadLine();
          }


        }
    }
}
