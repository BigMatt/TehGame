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
        private static Random randr;

        public Hashtable skills;
       
        public Character(string type)
        {
            XElement root = XElement.Load("monsters.xml");

            IEnumerable<XElement> mobs =
                from el in root.Elements("monster")
                where (string)el.Element("Name") == type
                select el;

            //mobs.First();
            XElement mob = mobs.First();

            IEnumerable<XElement> stats= mob.Elements("stats");


            foreach (XElement attr in stats.Nodes())
            {
                switch (attr.Name.ToString())
                {
                    case "Strength":
                        strength = Convert.ToInt32(attr.Value);
                        Console.WriteLine(attr.Name + ": " + attr.Value);
                        break;
                    case "Dexterity":
                        dexterity = Convert.ToInt32(attr.Value);
                        Console.WriteLine(attr.Name + ": " + attr.Value);
                        break;
                    case "Wisdom":
                        wisdom = Convert.ToInt32(attr.Value);
                        Console.WriteLine(attr.Name + ": " + attr.Value);
                        break;
                    case "Charisma":
                        charisma = Convert.ToInt32(attr.Value);
                        Console.WriteLine(attr.Name + ": " + attr.Value);
                        break;
                    case "Intelligence":
                        intelligence = Convert.ToInt32(attr.Value);
                        Console.WriteLine(attr.Name + ": " + attr.Value);
                        break;
                    case "Hits":
                        hits = Convert.ToInt32(attr.Value);
                        Console.WriteLine(attr.Name + ": " + attr.Value);
                        break;
                }
             
            }
        }


        public int Useskill(string skill)
        {
            return 10;
        }
    }
}
