using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;


namespace Test_Game_1
{
    class Character
    {

        public int strength=0;
        public int dexterity = 0;
        public int wisdom = 0;
        public int charisma = 0;
        public int intelligence = 0;
        public int hits = 0;
        public int defense = 0;
        //public string stuff;
        //private static Random randr = new Random();

        public Hashtable skills;
       
        public Character(string type)
        {


            skills = new Hashtable();
            XElement root = XElement.Load("monsters.xml");

            IEnumerable<XElement> mobs =
                from el in root.Elements("monster")
                where (string)el.Element("Name") == type
                select el;

            //mobs.First();
            XElement mob = mobs.First();


            IEnumerable<XElement> skls = mob.Elements("skills");

            foreach (XElement skill in skls.Nodes())
            {
                this.skills[skill.Name.LocalName] = Convert.ToInt32(skill.Value);

                //Console.WriteLine("Skill {0}: {1}", skill.Name, this.skills[skill.Name]);



            }


    

            IEnumerable<XElement> stats= mob.Elements("stats");

            foreach (XElement attr in stats.Nodes())
            {
                switch (attr.Name.ToString())
                {
                    case "Strength":
                        strength = Convert.ToInt32(attr.Value);
                       
                        break;
                    case "Dexterity":
                        dexterity = Convert.ToInt32(attr.Value);
                      
                        break;
                    case "Wisdom":
                        wisdom = Convert.ToInt32(attr.Value);
                      
                        break;
                    case "Charisma":
                        charisma = Convert.ToInt32(attr.Value);
                     
                        break;
                    case "Intelligence":
                        intelligence = Convert.ToInt32(attr.Value);
                      
                        break;
                    case "Hits":
                        hits = Convert.ToInt32(attr.Value);
                       
                        break;
                }
             
            }
        }


        public int Useskill(string skill)
        {
            //Console.WriteLine("Using Skill: {0} with a value of {1}", skill, this.skills[skill]);
            return Convert.ToInt32(this.skills[skill]);
        }
    }
}
