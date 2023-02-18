using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            AirConditioner ac = new AirConditioner(15, 8);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Intensity {0} ", ac.GetIntensity());
                Console.WriteLine("Temperature {0} ", ac.GetTemperature());
                Console.WriteLine();

                Console.WriteLine("Commands:\n" +
                                    "1) Intensity+\n" +
                                    "2) Intensity-\n" +
                                    "3) Set Temperature\n" +
                                    "4) Temperature+\n" +
                                    "5) Temperature-\n");

                int.TryParse(Console.ReadLine(), out int command);

                switch (command)
                {
                    case 1:
                        ac.nextIntensityButton();
                        break;

                    case 2:
                        ac.prevIntensityButton();
                        break;

                    case 3:
                        if (int.TryParse(Console.ReadLine(), out int temerature))
                            ac.SetTemperature(temerature);
                        else
                        {
                            Console.WriteLine("Something wrong");
                            Console.WriteLine("Press any button for continue");
                            Console.ReadKey();
                        }
                        break;

                    case 4:
                        ac.nextTemperatureButton();
                        break;

                    case 5:
                        ac.prevTemperatureButton();
                        break;

                    default:
                        Console.WriteLine("Something wrong");
                        Console.WriteLine("Press any button for continue");
                        Console.ReadKey();
                        break;
                } 
            }
        }
    }
}
