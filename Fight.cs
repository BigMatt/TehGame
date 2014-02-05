using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_Game_1
{
    class Fight
    {
        //public int result;
        public int roll;
        public Character attacker;
        public Character defender;
        public string attackSkill;
        private Random randr;
        public int toHit;
        public int damage;
        public string damagetype;

        public Fight(Character Attacker, string attackSkill, Character Defender)
        {

            this.attacker = Attacker;
            this.defender = Defender;
            
            this.attackSkill = attackSkill;


            this.roll = Dice.roll(100);
            this.toHit = attacker.Useskill(attackSkill) - Defender.defense + 90;
            int overhit = roll + toHit - 100;

            this.damage = Convert.ToInt32((overhit + 3) / 5);
            if (overhit > 50)
            {
                damage += 3;
                damagetype = "Hard";
            }
            else
                damagetype = "Normal";



            if (this.roll > 100 - this.toHit)
                defender.hits -= this.damage;

        }

        public override string ToString()
        {
            return "ATK: +" + attacker.Useskill(attackSkill) + " - DEF: +" + defender.defense + " + Roll: " + this.roll + " = " + this.toHit + "% chance to hit";
        }

    }
}
