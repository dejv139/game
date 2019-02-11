using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    interface ICharacter
    {
        void UseAbility1(ACharacter target);
        void UseAbility2(ACharacter target);
        void UseAbility3(ACharacter target);
        void UseAbility4(ACharacter target);
    }
}
