using System;
using System.Collections;

namespace LevelAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Level Algorithm With C#");
            Console.WriteLine("This project when you press some key will be earn the xp");
            Console.WriteLine("Let's start.");
            //string value = Console.ReadLine();
            int level = 0, xp = 0;
            ArrayList levelsForXp = new ArrayList { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            //if (value != null)
            //{
            for (int i = 0; i < 10; i++)
            {
                string text = Console.ReadLine();
                //char[] charArray = text.ToCharArray();
                if (text != null)
                {
                    Console.Clear();
                    xp = text.Length;
                    //here check the levelsForXp count cause if dont have any level you finished the all levels
                    if (levelsForXp.Count==0)
                    {
                        Console.WriteLine("Cong you reach the max level");
                        break;
                    }
                    else
                    {
                        //here you check all levels and if your xp is more your level is up
                        for (int j = 0; j < levelsForXp.Count; j++)
                        {
                            if (xp >= Convert.ToInt32(levelsForXp[j]))
                            {
                                //level is up
                                level++;
                                //and your current level is removed from arrayList
                                levelsForXp.Remove(levelsForXp[j]);
                            }
                            else
                            {
                                //if your level is not more the arrayList level you have to more write random char so go ahead
                                break;
                            }
                        }
                    }
                    //here check level or contiune 
                    Console.WriteLine("İf you want check your level write 'check level' or write 'contiune' or press enter");
                    var status = Console.ReadLine();
                    if (status != "contiune" && status != "check level" && status!="")
                    {
                        while (true)
                        {
                            Console.WriteLine("İf you want check your level write 'check level' or write 'contiune'");
                            var status2 = Console.ReadLine();
                            if (status2 == "check level")
                            {
                                Console.WriteLine(level);
                                break;
                            }
                            else if (status2 == "contiune")
                            {
                                Console.WriteLine("Write Some More Random Character");
                                break;
                            }
                        }
                    }
                    if (status == "check level")
                    {
                        Console.WriteLine(level);
                    }
                    Console.WriteLine("Write Some More Random Character");
                }
            }
        }
    }
}
