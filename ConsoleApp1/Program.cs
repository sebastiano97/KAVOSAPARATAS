using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal k = 3, v = 5, suma = 0;
            string dydis = "x", papildyti = "y";
            while (true)
            {

                if (k < 1m)
                {
                    Console.WriteLine("############  Baigesi kava! Norit papildyti iveskite KAVA");

                    while (papildyti != "KAVA")
                    {
                        papildyti = Console.ReadLine();
                        if (papildyti == "KAVA")
                        {
                            Console.WriteLine("############  Kava pasipilde!");
                            k = 3;
                        }
                        else
                            Console.WriteLine("############  Blogai suvesta komanda!");
                    }
                    papildyti = "y";
                }
                else if (v < 0.75m)
                {
                    Console.WriteLine("############  Baigesi vanduo! Norit papildyti iveskite VANDUO");

                    while (papildyti != "VANDUO")
                    {
                        papildyti = Console.ReadLine();
                        if (papildyti == "VANDUO")
                        {
                            Console.WriteLine("############  Vanduo pasipilde!");
                            v = 5;
                        }

                        else
                            Console.WriteLine("############  Blogai suvesta komanda!");

                    }
                    papildyti = "y";
                }
                else
                {
                    //Console.WriteLine("Kavos liko {0}, Vandens liko {1}", k, v);
                    Console.WriteLine();
                    Console.WriteLine("############  Kavos Aparatas  ");
                    Console.WriteLine("############  Pasirinkite kavos dydi ");
                    Console.WriteLine("############  Galimi puodeliai ");
                    Console.WriteLine("############  Dydis         Kaina");
                    Console.WriteLine("############  S             1eur ");
                    Console.WriteLine("############  M             3eur   ");
                    Console.WriteLine("############  L             5eur    ");



                    dydis = Console.ReadLine();
                    if (dydis == "s" || dydis == "S")
                    {
                        decimal kaina = 1;
                        Console.WriteLine("############  Pasirinktas S dydis!");
                        Console.WriteLine("############  Idekite pinigus: " + kaina + "Eur");
                        k = k - 0.5m;
                        v = v - 0.25m;
                        while (suma < kaina)
                        {
                            suma = decimal.Parse(Console.ReadLine());
                            Console.WriteLine("############  Idejote " + suma + "Eur");
                            if (suma < kaina)
                            {

                                decimal skrt = kaina - suma;
                                Console.WriteLine("############  Idejote nepakankamai! Liko ideti " + skrt);

                            }

                            else if (suma == kaina)
                            {
                                Console.WriteLine("############  Aciu! S dydzio kava paruošta!");
                            }
                            else if (suma > kaina)
                            {
                                decimal graza = suma - kaina;
                                Console.WriteLine("############  Aciu! S dydzio kava paruošta!");
                                Console.WriteLine("############  Jusu graza " + graza + "Eur");
                            }
                            else
                            {
                                Console.WriteLine("############  Blogai ideti pinigai bandykite dar karta!");

                            }
                            kaina = kaina - suma;
                            suma = 0;
                        }
                    } // uzdarom S if.
                    else if (dydis == "m" || dydis == "M")
                    {
                        decimal kaina = 3;
                        Console.WriteLine("############  Pasirinktas M dydis!");
                        Console.WriteLine("############  Idekite pinigus: " + kaina + "Eur");
                        k = k - 0.75m;
                        v = v - 0.5m;
                        while (suma < kaina)
                        {
                            suma = decimal.Parse(Console.ReadLine());
                            Console.WriteLine("############  Idejote " + suma + "Eur");
                            if (suma < kaina)
                            {

                                decimal skrt = kaina - suma;
                                Console.WriteLine("############  Idejote nepakankamai! Liko ideti " + skrt);

                            }

                            else if (suma == kaina)
                            {
                                Console.WriteLine("############  Aciu! M dydzio kava paruošta!");
                            }
                            else if (suma > kaina)
                            {
                                decimal graza = suma - kaina;
                                Console.WriteLine("############  Aciu! M dydzio kava paruošta!");
                                Console.WriteLine("############  Jusu graza " + graza + "Eur");
                            }
                            else
                            {
                                Console.WriteLine("############  Blogai ideti pinigai bandykite dar karta!");

                            }
                            kaina = kaina - suma;
                            suma = 0;
                        }
                    } // uzdarom M if.
                    else if (dydis == "l" || dydis == "L")
                    {
                        decimal kaina = 5;
                        Console.WriteLine("############  Pasirinktas L dydis!");
                        Console.WriteLine("############  Idekite pinigus: " + kaina + "Eur");
                        k = k - 1m;
                        v = v - 0.75m;
                        while (suma < kaina)
                        {
                            suma = decimal.Parse(Console.ReadLine());
                            Console.WriteLine("############  Idejote " + suma + "Eur");
                            if (suma < kaina)
                            {

                                decimal skrt = kaina - suma;
                                Console.WriteLine("############  Idejote nepakankamai! Liko ideti " + skrt);

                            }

                            else if (suma == kaina)
                            {
                                Console.WriteLine("############  Aciu! L dydzio kava paruošta!");
                            }
                            else if (suma > kaina)
                            {
                                decimal graza = suma - kaina;
                                Console.WriteLine("############  Aciu! L dydzio kava paruošta!");
                                Console.WriteLine("############  Jusu graza " + graza + "Eur");
                            }
                            else
                            {
                                Console.WriteLine("############  Blogai ideti pinigai bandykite dar karta!");

                            }
                            kaina = kaina - suma;
                            suma = 0;
                        }
                    } // uzdarom L if.
                    else Console.WriteLine("############  Tokio pasirinkimo nera!!");
                }
            }
            Console.ReadLine();
        }

    }
}

