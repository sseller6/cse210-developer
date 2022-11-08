using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit03
{
    internal class Jumper
    {
        private List<string> character;

        public bool isDead;

        public Jumper()
        {
            isDead = false;

            character = new List<string>();
            character.Add(@"__");
            character.Add(@"/___\");
            character.Add(@"\.../");
            character.Add(@".\./.");
            character.Add(@"..o..");
            character.Add(@"./|\.");
            character.Add(@"./.\.");
        }

        public void DisplayJumper()
        {
            // make a for loop here to print jumper.
            foreach(string line in character) {
                Console.WriteLine(line);
            }
            //Console.WriteLine($"{character}");
            Console.WriteLine();
            Console.WriteLine("^^^^^^^");

        }
        private void CutLine()
        {
            character.RemoveAt(0);
        }


        // make new method if the length of the character is less than 5, then make dead.
        public bool CheckAlive()
        {
            return false;
            // this is a stub function ^
        }
        public void MakeDead()
        {
            isDead=true;
        }
    }
}
