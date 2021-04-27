using System;

namespace Proyecto_final
{
    class SISTEMA_CALCULADORA_DE_PRÉSTAMOS
    {
        public float Pago, Interes_pagado, Capital_pagado, Monto_del_prestamo, Tasa_A, Tasa_M;
        public int F_1, Plazo, i;

        public void Menu()
        {
            Console.WriteLine("            ----- Sea Bienvenido(a) -----");
            Console.WriteLine("");



            Console.WriteLine("        Introduzca el monto que desea calcular");
            float.TryParse(Console.ReadLine(), out Monto_del_prestamo);

            Console.WriteLine();

            Console.WriteLine("        Igrese la tasa de interes anual");
            float.TryParse(Console.ReadLine(), out Tasa_A);

            Console.WriteLine();

            Console.WriteLine("         En cuantos meses paragra el prestamo");
            int.TryParse(Console.ReadLine(), out Plazo);

            Console.WriteLine("---------------------------------------------");


        }

        public void Calculos()
        {
            //Interes mensual
            Tasa_M = (Tasa_A / 100) / 12;

            //Cuota mensual
            Pago = Tasa_M + 1;
            Pago = (float)Math.Pow(Pago, Plazo);
            Pago = Pago - 1;
            Pago = Tasa_M / Pago;
            Pago = Tasa_M + Pago;
            Pago = Monto_del_prestamo * Pago;
        }
        public void Tabla_A()
        {
            Console.WriteLine();
            F_1 = 1;
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(" Numero de pago \t ");
            Console.Write("Pago \t\t");
            Console.Write("Intereses \t\t ");
            Console.Write("Capital \t\t ");
            Console.Write(" Monto del Prestamo \t");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("\t0");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t{0}", Monto_del_prestamo);


            for (i = 1; i <= Plazo; i++)
            {


                Console.Write("\t{0}\t\t", F_1);


                Console.Write("{0}\t", Pago);


                Interes_pagado = Tasa_M * Monto_del_prestamo;
                Console.Write("{0}\t\t", Interes_pagado);


                Capital_pagado = Pago - Interes_pagado;
                Console.Write("\t{0}\t", Capital_pagado);


                Monto_del_prestamo = Monto_del_prestamo - Capital_pagado;
                Console.Write("\t{0}\t", Monto_del_prestamo);

                F_1 = F_1 + 1;
                Console.WriteLine();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SISTEMA_CALCULADORA_DE_PRÉSTAMOS SCP = new SISTEMA_CALCULADORA_DE_PRÉSTAMOS();
            SCP.Menu();
            SCP.Calculos();
            SCP.Tabla_A();
        }
    }
}