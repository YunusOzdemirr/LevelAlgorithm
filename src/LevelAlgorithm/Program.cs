﻿using System;
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
            string value = Console.ReadLine();
            int level = 0, xp = 0, totalXp=0, cacheXp=0;
            ArrayList levelsForXp = new ArrayList { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            if (value != null)
            {
                Console.Clear();
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("if you want to see your total xp write xp");
                    Console.WriteLine("Write Some More Random Character");
                    string text = Console.ReadLine();
                    var textLength=text.Length + cacheXp;
                    //char[] charArray = text.ToCharArray();
                    if (level==10)
                    {
                        Console.WriteLine("Cong you reach the max level");
                    }
                    if (text=="xp")
                    {
                        Console.WriteLine(totalXp);
                        Console.Clear();
                    }
                    else if (levelsForXp.Count==0||Convert.ToInt32(levelsForXp[0])<=textLength)
                    {

                        Console.Clear();
                        xp = text.Length+cacheXp;
                        totalXp += xp;
                        //here check the levelsForXp count cause if dont have any level you finished the all levels
                        if (levelsForXp.Count == 0)
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
                        Console.WriteLine("İf you want check your level write 'check level' or 'c' write for keep going 'contiune' or  press enter");
                        var status = Console.ReadLine();
                        if (status != "contiune" && status != "check level" && status != "" && status!="c")
                        {
                            while (true)
                            {
                                Console.WriteLine("İf you want check your level write 'check level' or 'c' write for keep going 'contiune' or  press enter");
                                var status2 = Console.ReadLine();
                                if (status2 == "check level" || status2=="c")
                                {
                                    Console.WriteLine("Your level is " + level);
                                    if (level==10)
                                    {
                                        Console.WriteLine("Cong you reach the max level");
                                    }
                                    break;
                                }
                                else if (status2 == "contiune" || status2=="")
                                {
                                    break;
                                }
                            }
                        }
                        if (status == "check level" || status=="c")
                        {
                            Console.WriteLine("Your level is "+ level);
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Pls some more write character");
                        Console.WriteLine("Your current xp is " + textLength);
                        cacheXp += text.Length;
                    }
                }
            }
        }
    }
}
