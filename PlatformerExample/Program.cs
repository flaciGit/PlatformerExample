using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformerExample
{
    
    public class Platformer
    {
        static List<int> platforms;
        int currentPosition;
        int jumpDistance = 2;

        public Platformer(int numberOfTiles, int position)
        {
            platforms = new List<int>();

            for (int i = 0; i< numberOfTiles; i++) {
                platforms.Add(i+1);
            }

            currentPosition = position;

            Console.WriteLine("Platform size: " + numberOfTiles);
        }

        public void JumpLeft()
        {
            
            if (platforms.IndexOf(currentPosition) - jumpDistance >= 0)
            {
                int oldPosition = currentPosition;
                currentPosition = platforms.ElementAt(platforms.IndexOf(currentPosition) - jumpDistance);
                
                platforms.Remove(oldPosition);

                Console.WriteLine("Did a left jump!");
                Console.WriteLine("Removed: " + oldPosition);

            }
            else
            {
                Console.WriteLine("Can not do left jump!");
            }
        }

        public void JumpRight()
        {
            
            if (platforms.IndexOf(currentPosition) + jumpDistance < platforms.Count)
            {
                int oldPosition = currentPosition;
                currentPosition = platforms.ElementAt(platforms.IndexOf(currentPosition) + jumpDistance);

                platforms.Remove(oldPosition);

                Console.WriteLine("Did a right jump!");
                Console.WriteLine("Removed: " + oldPosition);

            }
            else
            {
                Console.WriteLine("Can not do right jump!");
            }
        }

        public int Position()
        {
            return currentPosition;
        }

        public static void printList() {
            Console.WriteLine("\n  Current list: ");
            Console.Write(" ");
            foreach (int i in platforms)
            {
                Console.Write(" "+i);
            }
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            Platformer platformer = new Platformer(6, 3);
            
            Console.WriteLine("Current position: "+ platformer.Position()); // should print 3
            printList();

            platformer.JumpLeft();
            Console.WriteLine("Current position: " + platformer.Position()); // should print 1
            printList();

            platformer.JumpRight();
            Console.WriteLine("Current position: " + platformer.Position()); // should print 4
            printList();

            platformer.JumpRight();
            Console.WriteLine("Current position: " + platformer.Position());
            printList();

            platformer.JumpRight();
            Console.WriteLine("Current position: " + platformer.Position());
            printList();

            platformer.JumpLeft();
            Console.WriteLine("Current position: " + platformer.Position());
            printList();

            platformer.JumpLeft();
            Console.WriteLine("Current position: " + platformer.Position());
            printList();


            Console.ReadKey();
        }
    }
}
