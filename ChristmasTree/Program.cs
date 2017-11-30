using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            ChristmasTree tree = new ChristmasTree();
            tree.Create();
        }
    }
    
    // Class of the Tree
    public class ChristmasTree
    {
        public char[,] Snow = new char[12, 40];
        
        public ChristmasTree()
        {
            for(int j=0; j < 40; j++)
            {
                Snow[0, j] = ' ';
            }
            for (int j = 10; j < 12; j++)
            {
                for(int i=0; i<40; i++)
                {
                    Snow[j, i] = ' ';
                }
            }

            for (int j=1; j<10; j++)
            {
                for(int i=15; i>=j; i--)
                { 
                    Snow[j, i-j] = ' ';
                }

                for(int i=17-j; i<16+j; i++)
                {
                    Snow[j, i] = '*';
                }
            }
            for (int j = 10; j < 12; j++)
            {
                for(int i=14; i<=16;i++)
                {
                    Snow[j, i] = '|';
                    i++;
                }
            }
        }

        // Print tree and snow on monitor
        public void Create()
        {
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    Console.Write(Snow[i, j]);
                }
                Console.Write('\n');
            }
        }
        
    }
}
