namespace ArmstrongNumbers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public sealed class Program
    {
        public static void Main(String[] args)
        {
            using (StreamReader reader = File.OpenText(args[0]))
            {
                while (!reader.EndOfStream)
                {
                    String line = reader.ReadLine();
                    if (null == line)
                    {
                        continue;
                    }
                    else
                    {
                        var length = line.Length;
                        var numberToMatch = Convert.ToInt32(line);
                        List<Int32> numbers = new List<Int32>();
                        var total = 0;

                        for (int i = 0; i < length; i++)
                        {
                            numbers.Add(Convert.ToInt32(line.Substring(i,1)));
                            var temp = 1;

                            for (int j = 0; j < length; j++)
			                {
			                    temp *= numbers[i];
			                }

                            total += temp;
                        }

                        if(numberToMatch == total)
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                    }
                }
            }             
        }
    }
}
