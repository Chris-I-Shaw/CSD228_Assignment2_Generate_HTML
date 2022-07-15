using System;
using System.Text;

namespace Homework
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if(args.Length == 2)
            {
                int number;
                
                int.TryParse(args[1], out number);
                string rowColor = args[0];

                if(number > 0)
                    GenerateTable(rowColor, number);
                else
                   Console.WriteLine("Wrong input"); 
            }
            else
                Console.WriteLine("Wrong input");        
        }

        public static void GenerateTable(string rowColor, int number) 
        {
            if(number > 0)
            {
                Console.Write("<table>\r\n");
                for(int i = 1; i < number + 1; i++)
                {
                    if(rowColor == "odd")
                    {
                        if(i % 2 != 0)
                            {
                                Console.Write("  <tr style=\"background:gray\">\r\n");
                                Console.Write("    <td>");
                                Console.Write($"Row {i}");
                                Console.Write("</td>\r\n");
                                Console.Write("  </tr>\r\n");
                            }
                            else
                            {
                                Console.Write("  <tr>\r\n");
                                Console.Write("    <td>");
                                Console.Write($"Row {i}");
                                Console.Write("</td>\r\n");
                                Console.Write("  </tr>\r\n");
                            }
                    } 
                    if(rowColor == "even") 
                    {
                        if(i % 2 == 0)
                        {
                                Console.Write("  <tr style=\"background:gray\">\r\n");
                                Console.Write("    <td>");
                                Console.Write($"Row {i}");
                                Console.Write("</td>\r\n");
                                Console.Write("  </tr>\r\n");
                        } 
                        else
                        {
                                Console.Write("  <tr>\r\n");
                                Console.Write("    <td>");
                                Console.Write($"Row {i}");
                                Console.Write("</td>\r\n");
                                Console.Write("  </tr>\r\n");
                        }
                    }
                }
                Console.Write("</table>\r\n");
            }
        } 
    }
}
