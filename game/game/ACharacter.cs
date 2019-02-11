using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    abstract class ACharacter
    {
        public string Name { get; set; }
        public int Position { get; set; }
        public int HP { get; set; }
        public int SpecialBar { get; set; }
        public virtual void UseAbility1(ACharacter target)
        {

        }
        public virtual void UseAbility2()
        {

        }
        public virtual void UseAbility3()
        {

        }
        public virtual void UseAbility4()
        {

        }
    }
}
