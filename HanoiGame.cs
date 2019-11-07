using System;

namespace Honai
{
    public class HanoiGame
    {
        public void Setup()
        {
            {
                //輸入高度
                Console.WriteLine("請輸入河內塔的高度：");
                string input = Console.ReadLine();
                int disk = int.Parse(input);
          

                Console.WriteLine("起始地的柱子:(1,2,3)");
                input = Console.ReadLine();
                int from = int.Parse(input);

                Console.WriteLine("目的地的柱子：(1,2,3)");
                input = Console.ReadLine();
                int to = int.Parse(input);

                int aux = 0;
                int[] temp = { 1, 2, 3 };
                foreach (int item in temp)
                {
                    if (item != from && item != to)
                    {
                        aux = item;
                        break;
                    }
                }


                Hanoi(disk, from, to, aux);
                Console.ReadKey();
            }
        }

        public void Play() { }
        public static void Hanoi(int Disk, int Src, int Dest, int Aux)

        {
            if (Disk == 1)
            {
                Console.WriteLine($"將第{Disk}個圓盤由{Src}移到{Dest} ");
            }
            else
            {
                Hanoi(Disk - 1, Src, Aux, Dest);
                Console.WriteLine($"將第{Disk}個圓盤由{Src}移到{Dest} ");
                Hanoi(Disk - 1, Aux, Dest, Src);
            }
        }
    }
}