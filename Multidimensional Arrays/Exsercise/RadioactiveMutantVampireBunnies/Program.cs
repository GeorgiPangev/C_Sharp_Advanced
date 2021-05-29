using System;
using System.Collections.Generic;
using System.Linq;

namespace RadioactiveMutantVampireBunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dim = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            char[,] copi = new char[dim[0], dim[1]];

            char[,] nest = new char[dim[0], dim[1]];

            int pRow = -1;
            int pCol = -1;
            bool isOut = false;
            bool isDeat = false;

            

            for (int row = 0; row < nest.GetLength(0); row++)
            {
                char[] input = Console.ReadLine()
                    .ToCharArray();
                for (int col = 0; col < nest.GetLength(1); col++)
                {
                    nest[row, col] = input[col];
                    copi[row, col] = input[col];
                    if (nest[row, col] == 'P')
                    {
                        pCol = col;
                        pRow = row;
                        nest[row, col] = '.';
                        copi[row, col] = '.';


                    }
                }
            }
            //copi = nest;
            string comand = Console.ReadLine();
            for (int i = 0; i < comand.Length; i++)
            {
                bool isMoved = false;
                
                char comCh = comand[i];


                if (comCh == 'L' && Isin(nest, pRow, pCol - 1))
                {
                    pCol -=1;
                    isMoved = true;

                    if (nest[pRow, pCol] == 'B')
                    {
                        isDeat = true;
                    }
                    //else if (nest[pRow, pCol] == '.')
                    //{
                    //    nest[pRow, pCol] = 'P';
                    //    nest[pRow, pCol + 1] = '.';
                        
                    //}
                }
                else if (!Isin(nest, pRow, pCol - 1)&&!isMoved)
                {
                    isOut = true;
                    isMoved = true;
                }
                if (comCh == 'R' && Isin(nest, pRow, pCol + 1))
                {
                    pCol += 1;
                    isMoved = true;

                    if (nest[pRow, pCol] == 'B')
                    {
                        isDeat = true;
                    }
                    //else
                    //{
                    //    nest[pRow, pCol] = 'P';
                    //    nest[pRow, pCol - 1] = '.';
                       
                    //}
                }
                else if (!Isin(nest, pRow, pCol + 1) && !isMoved)
                {
                    isOut = true;
                    isMoved = true;
                }
                if (comCh == 'U' && Isin(nest, pRow - 1, pCol))
                {
                    
                    pRow -= 1;
                    isMoved = true;
                    if (nest[pRow, pCol] == 'B')
                    {
                        isDeat = true;
                       
                    }
                    //else
                    //{
                    //    nest[pRow, pCol] = 'P';
                    //    nest[pRow + 1, pCol] = '.';
                       
                    //}
                }
                else if (!Isin(nest, pRow - 1, pCol) && !isMoved)
                {
                    isOut = true;
                    isMoved = true;
                }
                if (comCh == 'D' && Isin(nest, pRow + 1, pCol))
                {  
                    pRow += 1;
                    isMoved = true;
                    if (nest[pRow, pCol] == 'B')
                    {
                        isDeat = true;
                    }
                    //else
                    //{
                    //    nest[pRow, pCol] = 'P';
                    //    nest[pRow - 1, pCol] = '.';

                    //}
                }
                else if (!Isin(nest, pRow + 1, pCol) && !isMoved)
                {
                    isOut = true;
                }


               // copi = nest;



                for (int row = 0; row < nest.GetLength(0); row++)
                {
                    for (int col = 0; col < nest.GetLength(1); col++)
                    {
                        char position = nest[row, col];

                        if (position=='B')
                        {
                            copi = MultiplaedNest(copi, row, col);
                            
                        }
                       
                    }
                }
                nest = CopiMatrix(nest, copi);
                //nest = copi;
                if (!isOut&& !isDeat)
                {
                    if (copi[pRow, pCol] == 'B')
                    {
                        isDeat = true;
                    }
                }
               
                if (isDeat)
                {
                    
                    
                    break;
                }
                else if (isOut&&!isDeat)
                {
                    
                    
                    break;
                }
               // nest = copi;
            }

            for (int row = 0; row < nest.GetLength(0); row++)
            {
                for (int col = 0; col < nest.GetLength(1); col++)
                {
                    Console.Write(nest[row, col]);
                }
                Console.WriteLine();
            }
            if (isDeat)
            {
                Console.WriteLine($"dead: {pRow} {pCol}");

                
            }
            else if (isOut && !isDeat)
            {
                Console.WriteLine($"won: {pRow} {pCol}");

              
            }
        }

        private static char[,] CopiMatrix(char[,] nest, char[,] copi)
        {
            for (int row = 0; row < nest.GetLength(0); row++)
            {
                for (int col = 0; col < nest.GetLength(1); col++)
                {
                    nest[row, col] = copi[row, col];
                  
                }
            }
            return nest;
        }

        private static char[,] MultiplaedNest(char[,] c, int row, int col)
        {
            char[,] copi = c;
            copi[row, col] = 'B';
            if (Isin(copi, row, col - 1))
            {
                copi[row, col - 1] = 'B';
            }
            if (Isin(copi, row, col + 1))
            {
                copi[row, col + 1] = 'B';
            }
            if (Isin(copi, row - 1, col))
            {
                copi[row - 1, col] = 'B';
            }
            if (Isin(copi, row + 1, col))
            {
                copi[row + 1, col] = 'B';
            }
            return copi;
            
        }

        private static bool Isin(char[,] nest, int r, int c)
        {
            return r >= 0 && r < nest.GetLength(0) 
                && c >= 0 && c < nest.GetLength(1);
        }
    }
}
