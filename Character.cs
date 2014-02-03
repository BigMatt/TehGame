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
        private Random randr = null;



        public Hashtable skills;
       
       
        


        public Character(Random Randr, string type)
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
            

            //Console.WriteLine(mob);
            
            //foreach (XElement el in mobs)
                //Console.WriteLine(el.Value);


            /*


                        /*
                        XDocument xdoc = XDocument.Load("monsters.xml");

                        IEnumerable<XElement> mobs = xdoc.Root.Elements();

                        foreach (var mob in mobs)
                            Console.WriteLine(mob.Element("Name"));
                        /*
                        IEnumerable<XElement> stats = mob.Elements();

                        foreach (var stat in stats)
                            Console.WriteLine(stat);

                        /*
                         * 
                         * 
                         * 
                         * 
                        XElement xelement = XElement.Load("monsters.xml");
                        IEnumerable<XElement> employees = xelement.Elements();


           






                        foreach (var employee in employees)
                        {
                            Console.WriteLine(employee.Element("Name").Value);
                        }
    
                        */








            
            /*
            hits = 100; 
            strength = 10;
            dexterity = 10;
            wisdom = 10;
            charisma = 10;
            intellegence = 10;
            defense = 10;
            skills = new Hashtable();
            randr = Randr;

            skills.Add("swords", 15);
             * */
        }


        public int Useskill(string skill)
        {
            /*int result = 0;

            if (skill == "swords")
                return (int)skills["swords"] + strength;



            return result;
             * */
            return 10;
        }
    }
}
