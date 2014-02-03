using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_Game_1
{
    class Result
    {
        public int roll;
        public int result;
        public string skill;
        public int mods;
        public int skillVal;


        public Result(int Roll, int Result, string Skill, int SkillVal, int Mods)
        {
            roll = Roll;
            result = Result;
            skill = Skill;
            mods = Mods;
            skillVal = SkillVal;
            
        }

        public override string ToString()
        {
            string ret = "";
            ret +="Skill: " + skill;
            ret += " Skill Value: " + skillVal;
            ret += " Roll: " + roll;
            ret += " Result: " + result;
            ret += " Mods: " + mods;
            


            return ret;
        }
    }
}
