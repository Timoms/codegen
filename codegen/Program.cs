using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codegen
{
    class Program
    {

        private static readonly String input = "p:=3";

        static void Main(string[] args)
        {
            StreamReader wFile = new StreamReader("z.dat");
            String line;

            

            Helper help = new Helper();
            
            StringBuilder stringBuilder = new StringBuilder();


            Register[] reg = new Register[5];
            for (int i = 0; i < reg.Length; i++)
                reg[i] = new Register("$t" + i.ToString(), null);

            reg[4].setValue(null);

            while ((line = wFile.ReadLine()) != null)
            {
                char[] c = line.ToCharArray();
                if (c.Length == 4)
                {
                    Console.WriteLine("input: " + line + " is: notation");
                    if (help.GetFreeRegister(reg) == null)
                        Console.WriteLine("Free Register Available: null");
                    else
                    {
                        if (!(help.GetRegisterFromName(reg, c[0].ToString()) == null))
                        {
                            Console.WriteLine("Variable existing, skipping...");
                            continue;
                        }


                        Register r = help.GetFreeRegister(reg);
                        Console.WriteLine(r.getName() + " is free for further usage.");

                        r.setValue(int.Parse(c[3].ToString()));
                        r.setVariable(c[0].ToString());
                        Console.WriteLine("Setting Register " + r.getName() + " to value (" + c[0].ToString() + ") " + c[3].ToString());

                        stringBuilder.AppendLine(string.Format("li {0}, {1}", r.getName(), r.getValue()));
                    }

                }
                else if (c.Length == 6)
                {
                    // p:=p+2
                    // 012345
                    Console.WriteLine("input is: arithmetic op");
                    int first = 0;
                    bool first_is_num = int.TryParse(c[3].ToString(), out first);

                    if (!first_is_num)
                        first = (int)help.GetRegisterFromName(reg, c[0].ToString()).getValue();

                    int last = 0;
                    bool last_is_num = int.TryParse(c[5].ToString(), out last);

                    if (!last_is_num)
                        last = (int)help.GetRegisterFromName(reg, c[5].ToString()).getValue();

                    Console.WriteLine(String.Format("First: {0}, Last: {1}", first, last));

                    String returnVal = "";

                    switch (c[4].ToString())
                    {
                        case "+":
                            returnVal = String.Format("add {0}, {1}, {2}", help.GetFreeRegister(reg).getName(), first, last);
                            break;
                    }

                    Console.WriteLine(returnVal);

                }
            }



            Console.WriteLine("\n");
            Console.Write(stringBuilder);

            Console.WriteLine("\n--------------------------------");
            Console.Write("| ");
            for (int i = 0; i < reg.Length; i++)
            {
                if (reg[i].getValue() == null)
                    Console.Write(reg[i].getName() + ":empty" + " | ");
                else
                    Console.Write(reg[i].getName() + ":" + reg[i].getValue() + " | ");

            }
                
            

        }
    }
}
