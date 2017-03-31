using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class AI : Player
    {
        public AI()
        {
            name = "HAL";
        }
        public override string GetInput()
        {
            Random random = new Random();
            int input = random.Next(1, 5);
            return input.ToString();
        }
    }
}
