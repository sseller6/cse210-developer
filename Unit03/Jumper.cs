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

        public void CutLine()
        {
            character.RemoveAt(0);
        }

        public void MakeDead()
        {
            isDead=true;
        }
    }
}
