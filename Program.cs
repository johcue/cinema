using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace taller2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, a, b, x, y, s, opcion, terminar = 0, costo = 0, caja = 0, localidad;
            Console.Write("ingrese la cantidad de filas de la sala:\n");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("ingrese la cantidad de columnas de la sala:\n");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("ingrese el valor de las sillas en localidad normal\n");
            costo = Convert.ToInt32(Console.ReadLine());

            string[] ultimafila = new string[8];
            string[,] sala = new string[a, b];
            //inicializada
            for (i = 0; i < a; i++)
            {
                for (j = 0; j < b; j++)
                {
                    sala[i, j] = "*";
                }
            }
            for (int q = 0; q < ultimafila.Length; q++)
                ultimafila[q] = "*";
            //menu
            while (terminar == 0)
            {
                Console.Write("ingrese la opcion que decea ejecutar:\n");
                Console.Write("Mostrar sala =1 \n");
                Console.Write("Asignar asiento =2 \n");
                Console.Write("Caja =3 \n");
                Console.Write("Terminar =4 \n");
                Console.Write("desocupar asiento =5 \n");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        {

                            //for (i = 0; i < a; i++)
                            //{
                            //    for (j = 0; j < b; j++)
                            //    {
                            //        sala[i, j] = "*";
                            //    }
                            //}
                            for (i = 0; i < a; i++)
                            {
                                for (j = 0; j < b; j++)
                                {
                                    Console.Write("\t" + sala[i, j] + " ");
                                }
                                Console.Write("\n");
                            }
                            for (int q = 0; q < ultimafila.Length; q++)
                            {
                                //ultimafila[q] = "*";
                                Console.Write("\t" + ultimafila[q]);
                            }
                            Console.Write("\n");
                        }
                        break;
                    case 2:
                        {
                            Console.Write("en que localidad se decea sentar:\n");
                            Console.Write("normal =1 \n");
                            Console.Write("especial =2 \n");
                            localidad = Convert.ToInt32(Console.ReadLine());
                            switch (localidad)
                            {
                                case 1:
                                    Console.Write("ingrese la fila en la que se decea sentar:\n");
                                    x = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("ingrese la columna en la que quiere estar:\n");
                                    y = Convert.ToInt32(Console.ReadLine());
                                    if (sala[x - 1, y - 1] == "*")
                                    {
                                        sala[x - 1, y - 1] = "o";
                                        caja = caja + costo;
                                    }
                                    else
                                    {
                                        Console.Write("el asiento esta ocupado \n");
                                    }
                                    break;

                                case 2:
                                    Console.Write("ingrese la silla en la que quiere estar:\n");
                                    s = Convert.ToInt32(Console.ReadLine());
                                    if (ultimafila[s - 1] == "*")
                                    {
                                        ultimafila[s - 1] = "o";
                                        caja = caja + costo + 4000;
                                    }
                                    else
                                    {
                                        Console.Write("el asiento esta ocupado \n");
                                    }
                                    break;


                            }
                            break;

                        }
                    case 3:
                        {
                            Console.Write("\n el dinero total es: \n" + caja);
                        }
                        Console.Write("\n");
                        break;
                    case 4:
                        {
                            terminar = 1;
                        }
                        break;
                    case 5:
                        {
                            Console.Write("ingrese la fila en la que se decea liberar:\n");
                            x = Convert.ToInt32(Console.ReadLine());
                            Console.Write("ingrese la columna en la que quiere liberar:\n");
                            y = Convert.ToInt32(Console.ReadLine());
                            if (sala[x - 1, y - 1] == "o")
                            {
                                sala[x - 1, y - 1] = "*";
                                caja = caja - costo;
                            }
                            else
                            {
                                Console.Write("el asiento esta libre \n");
                            }
                            break;

                        }


                }

                Console.ReadKey();
            }
        }
    }
}

