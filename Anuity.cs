using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anuitas
{
    class Anuity
    {
        float num;

        public float FaktorPengkali(float flower, float periode)
        {
            // this is the (1 + b)^n

            Anuity factor = new Anuity();

            factor.num = (float)Math.Pow((1 + flower), periode);

            return factor.num;
        }

        static void Main()
        {
            Anuity fp = new Anuity();

            float angsuran, bunga, sisahutang, anuitas, hutang;
            float flower, periode;
            int pil;
            char exit = 'p';

        bp:
            Console.Clear();
            Console.Write("Bunga (dalam desimal) = ");
            flower = float.Parse(Console.ReadLine());
            Console.Write("Periode = ");
            periode = float.Parse(Console.ReadLine());

        menu:
            Console.WriteLine();
            Console.WriteLine("\t\tMENU");
            Console.WriteLine("1. Angsuran");
            Console.WriteLine("2. Bunga");
            Console.WriteLine("3. Sisa Hutang");
            Console.WriteLine("4. Anuitas");
            Console.WriteLine("5. Ganti nilai bunga dan periode");
            Console.Write("Pilihan = ");
            pil = int.Parse(Console.ReadLine());

            switch (pil)
            {
                case 1:
                    Console.WriteLine();
                    Console.Write("Anuitas = ");
                    anuitas = float.Parse(Console.ReadLine());
                    Console.Write("Hutang = ");
                    hutang = float.Parse(Console.ReadLine());

                    angsuran = (fp.FaktorPengkali(flower, periode - 1)) * (anuitas - flower * hutang);
                    Console.WriteLine("Angsuran = " + angsuran);

                    Console.Write("tekan x dan enter untuk mengubah nilai bunga dan periode ");
                    exit = char.Parse(Console.ReadLine());

                    if (exit == 'x')
                    {
                        goto bp;
                    }
                    else
                    {
                        goto menu;
                    }
                    break;

                case 2:
                    Console.WriteLine();
                    Console.Write("Anuitas = ");
                    anuitas = float.Parse(Console.ReadLine());
                    Console.Write("Hutang = ");
                    hutang = float.Parse(Console.ReadLine());

                    bunga = (fp.FaktorPengkali(flower, periode - 1)) * (flower * hutang - anuitas) + anuitas;
                    Console.WriteLine("Bunga per periode = " + bunga);

                    Console.Write("tekan x dan enter untuk mengubah nilai bunga dan periode ");
                    exit = char.Parse(Console.ReadLine());

                    if (exit == 'x')
                    {
                        goto bp;
                    }
                    else
                    {
                        goto menu;
                    }
                    break;

                case 3:

                    Console.WriteLine();
                    Console.Write("Anuitas = ");
                    anuitas = float.Parse(Console.ReadLine());
                    Console.Write("Hutang = ");
                    hutang = float.Parse(Console.ReadLine());

                    sisahutang = (fp.FaktorPengkali(flower, periode)) * (hutang - anuitas / flower) + anuitas / flower;
                    Console.WriteLine("Sisa Hutang = " + sisahutang);

                    Console.Write("tekan x dan enter untuk mengubah nilai bunga dan periode ");
                    exit = char.Parse(Console.ReadLine());

                    if (exit == 'x')
                    {
                        goto bp;
                    }
                    else
                    {
                        goto menu;
                    }
                    break;

                case 4:
                    Console.WriteLine();
                    Console.Write("Hutang = ");
                    hutang = float.Parse(Console.ReadLine());

                    anuitas = ((fp.FaktorPengkali(flower, periode)) * flower * hutang) / ((fp.FaktorPengkali(flower, periode)) - 1);
                    Console.WriteLine("Anuitas = " + anuitas);

                    Console.Write("tekan x dan enter untuk mengubah nilai bunga dan periode ");
                    exit = char.Parse(Console.ReadLine());

                    if (exit == 'x')
                    {
                        goto bp;
                    }
                    else
                    {
                        goto menu;
                    }
                    break;

                case 5:
                    goto bp;
                    break;

                default:
                    goto menu;
                    break;
            }
        }
    }
}
