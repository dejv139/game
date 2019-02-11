using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    class Warrior : ACharacter, ICharacter
    {
        public override void UseAbility1(ACharacter target)
        {
            target.HP = target.HP - 30;
            this.SpecialBar = this.SpecialBar + 15;
        }
        
        public void UseAbility2(ACharacter target)
        {
            target.HP = target.HP - 30;
        }

        public void UseAbility3(ACharacter target)
        {
            target.HP = target.HP - 30;
        }

        public void UseAbility4(ACharacter target)
        {
            target.HP = target.HP - 30;
        }
    }
}
