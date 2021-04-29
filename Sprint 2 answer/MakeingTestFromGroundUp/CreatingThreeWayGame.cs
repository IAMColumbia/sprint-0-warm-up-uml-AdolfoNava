using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace MakeingTestFromGroundUp
{
    class CreatingThreeWayGame
    {
        public void Play()
        {
            Kyle K = new Kyle();
            NotTony T = new NotTony();

            WriteLine(K.Statz());
            WriteLine(T.Statz());

            while (K.Health > 0 && T.Health > 0)
            {
                WriteLine(K.Name + " and " + T.Name + "have clashed");

                K.AtckLifePoints(T.Attack());
                T.AtckLifePoints(K.Attack());
                WriteLine(K.Name + " used " + K.AttackType + " damage to " + T.Name + " with only " + T.Health + " Health left");
                WriteLine(T.Name + " used " + T.AttackType + " damage to " + K.Name + " with only " + K.Health + " Health left");
                WriteLine(ReadKey());
               Clear();
            }

            if(T.Health <= 0)
            {
                WriteLine(K.Name + " is victor");
            }
            else
            {
                WriteLine(T.Name + " has cause a fatailty");
            }

            

        }
    }
}
