using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace SokobanConsola
{
    class Program
    {
        public static int movimientos = 0;
        public static int puntaje = 0;
        public static int puntajetotal = 0;
        public static string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
        
        public static int[,] M = new int[20, 20];
        //public static int[,] N = new int[11, 11];

        static void PintarTablero()
        {
            Console.Clear();
            Console.WriteLine("Bienvenido al juego de Sokoban");
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (M[i, j] == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write("█");
                    }
                    if (M[i, j] == 1)
                    {
                        Console.Write(" ");
                    }
                    if (M[i, j] == 9)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("?");
                    }
                    if (M[i, j] == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("☺");
                    }
                    if (M[i, j] == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("$");
                    }
                }
               
                Console.WriteLine("");

            }

            //int counter = 0;
            //string line;
            //string user;

            // Read the file and display it line by line.
            //System.IO.StreamReader file =
            //new System.IO.StreamReader("C:\\Users\\jbrenesjimene\\Documents\\Visual Studio 2015\\Projects\\SokobanConsola\\SokobanConsola\\Usuario.txt");

                string text = System.IO.File.ReadAllText(@"C:\\Users\\jbrenesjimene\\Documents\\Visual Studio 2015\\Projects\\SokobanConsola\\SokobanConsola\\Usuario.txt");
 

            //while ((line = file.ReadLine()) != null)
            //{
            //    //Console.WriteLine(line);
            //    user = line;
            //    counter++;
            //}

            //file.Close();

            // Suspend the screen.
            //Console.ReadLine();


            //string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            //Console.WriteLine(currentPath + @"\Usuario.txt");
            //StreamWriter sw = new StreamWriter(currentPath + @"\Usuario.txt");
            //sw.ReadLine(usuario);
            //sw.Close();
            Console.WriteLine("Jugador Actual : " + text);
            Console.WriteLine("Numero de Movimientos : " + movimientos);
            Console.WriteLine("Puntaje en el nivel Actual : " + puntaje + " Puntaje Total : " + puntajetotal );


        }
        //*******************************************************************************************

        static void limpiarcontadores()

        {
            puntaje = 0;
            movimientos = 0;

        }

        //static void PintarTableroDos()
        //{

        //    Console.Clear();
        //    for (int i = 0; i < 11; i++)
        //    {
        //        for (int j = 0; j < 11; j++)
        //        {
        //            if (N[i, j] == 0)
        //            {
        //                Console.ForegroundColor = ConsoleColor.DarkCyan;
        //                Console.Write("█");
        //            }
        //            if (N[i, j] == 1)
        //            {
        //                Console.Write(" ");
        //            }
        //            if (N[i, j] == 9)
        //            {
        //                Console.ForegroundColor = ConsoleColor.Cyan;
        //                Console.Write("?");
        //            }
        //            if (N[i, j] == 3)
        //            {
        //                Console.ForegroundColor = ConsoleColor.Yellow;
        //                Console.Write(":)");
        //            }
        //            if (N[i, j] == 2)
        //            {
        //                Console.ForegroundColor = ConsoleColor.Red;
        //                Console.Write("$");
        //            }
        //        }
        //        Console.WriteLine("");

        //    }

        //}
        //************************************************************************************


        static void Main(string[] args)
        {
            int op = 0;
            //inicio();
            do
            {
                Console.Clear();
                menu();
                string cad = Console.ReadLine();
                op = int.Parse(cad);


                switch (op)
                {
                    case 1:
                        RegistrarUsuario();
                        break;
                    case 2:
                        Basico(); 
                        break;
                    case 3:
                        //ConsultarUsuarios();
                        break;
                    case 4:
                        System.Environment.Exit(0);
                        break;
                    default:
                        {
                            Console.WriteLine("Opcion No Valida..!");
                            //Console.ReadKey;
                            break;
                        }
                }
                Console.WriteLine("Presione Cualquier tecla para continuar: ");
            } while (op != 4);
            //Console.ReadKey;


        }

        static void menu()
        {
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" *****************************************");
            Console.WriteLine(" *           1: Registrar Usuario        *");
            Console.WriteLine(" *           2: Jugar                    *");
            Console.WriteLine(" *           3: Consultar Puntuaciones   *");
            Console.WriteLine(" *           4: Salir                    *");
            Console.WriteLine(" *****************************************");
            Console.WriteLine();
            Console.WriteLine(" Elige una opcion: ");
              

        }

        //************************************************************************************


        static void RegistrarUsuario()
        {
            string nombre;
            string usuario;
            int guardar=0;


            Console.Clear();
            Console.WriteLine("*************************************************");
            Console.WriteLine("*                                                *");
            Console.WriteLine("*       Bienvenido al Juego Sokoban              *");
            Console.WriteLine("*                                                * ");
            Console.WriteLine("*************************************************");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.Write("Digite su Nombre : ");
            nombre = Console.ReadLine();
            Console.Write("Digite el Usuario con que desea registrarse : ");
            usuario = Console.ReadLine();
            Console.Write("Desea Guardar los datos 1-Si o 2-No : ");
            guardar = int.Parse(Console.ReadLine());
            if (guardar == 1)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Los datos se almacenaron exitosamente");
                Console.WriteLine(" ");
                Console.WriteLine("Disfruta tu juego");
                Console.WriteLine(" ");
                Console.WriteLine("             ☺ $ -> ?             ");
                Console.ReadKey();

                Console.WriteLine(currentPath + @"\Usuario.txt");
                StreamWriter sw = new StreamWriter(currentPath + @"\Usuario.txt");
                sw.Write(usuario);
                sw.Close();
            }
            else
            {
                Console.WriteLine("Se saldra del programa)");
                Console.ReadKey();
                System.Environment.Exit(0);
                

            }



        }
        static void Basico() //0 es paredes. 1 es camino
        {
            limpiarcontadores();

            Console.WriteLine("Nivel # 1 ");
            int fv = 18, cv = 1;

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {

                    if (i == 0)
                        M[i, j] = 0;

                    else
                    {
                        if (i == 1 && j < 8)
                            M[i, j] = 0;

                        else
                        {
                            if (i == 1 && j < 20)
                                M[i, j] = 1;
                            if (i == 1 && j == 19)
                                M[i, j] = 0;

                            if (i == 2 && j < 5)
                                M[i, j] = 0;
                            if (i == 2 && j < 18)
                                M[i, j] = 1;
                            if (i == 2 && j == 19)
                                M[i, j] = 0;

                            if (j == 0 || j == 19)
                                M[i, j] = 0;
                            if (j != 0 && j != 19)
                                M[i, j] = 1;
                            if (i == 19 && j < 20)
                                M[i, j] = 0;
                        }

                    }
                }

            }
            M[1, 19] = 0;
            M[1, 17] = 2; //primera caja

            M[2, 18] = 0;
            M[1, 18] = 9; //objetivo
            M[18, 1] = 3; //jugador

            M[15, 16] = 0;
            M[15, 15] = 0;
            M[15, 14] = 0;
            M[16, 16] = 0;
            M[16, 15] = 9; // objetivo

            M[17, 15] = 2; // tercer caja
            M[16, 14] = 0;
            M[6, 6] = 0;
            M[8, 10] = 0;
            M[8, 11] = 0;
            M[9, 11] = 0;
            M[10, 11] = 0;

            M[9, 9] = 2;  // 2da caja
            M[9, 10] = 9; // objetivo
            M[10, 10] = 0;
            M[18, 18] = 0;
            ConsoleKeyInfo tecla = new ConsoleKeyInfo();

            int b = 0; //flag
            do
            {
                PintarTablero();
                tecla = Console.ReadKey(true);
                //arriba
                if (tecla.Key == ConsoleKey.UpArrow)
                {
                    if (M[fv - 1, cv] != 0)
                    {
                        M[fv - 1, cv] = 3;
                        M[fv, cv] = 1;
                        fv--;
                        movimientos = movimientos + 1;
                    }
                    if (M[1, 17] == 3) //1er caja
                    {
                        M[1, 18] = 2; // objetivo
                        puntaje = puntaje + 10;
                    }
                    if (M[17, 15] == 3) //3er caja
                    {
                        M[16, 15] = 2; //igualar objetivo
                        puntaje = puntaje + 10;
                    }
                    if (M[9, 9] == 3) //2da caja
                    {
                        M[9, 10] = 2; // igualar objetivo
                        puntaje = puntaje + 10;
                    }
                }

                //abajo
                if (tecla.Key == ConsoleKey.DownArrow)
                {
                    if (M[fv + 1, cv] != 0)
                    {
                        M[fv + 1, cv] = 3;
                        M[fv, cv] = 1;
                        fv++;
                        movimientos = movimientos + 1;
                    }
                    if (M[1, 17] == 3)
                    {
                        M[1, 18] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[17, 15] == 3)
                    {
                        M[16, 15] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[9, 9] == 3)
                    {
                        M[9, 10] = 2;
                        puntaje = puntaje + 10;
                    }
                }
                //izquierda
                if (tecla.Key == ConsoleKey.LeftArrow)
                {
                    if (M[fv, cv - 1] != 0)
                    {
                        M[fv, cv - 1] = 3;
                        M[fv, cv] = 1;
                        cv--;
                        movimientos = movimientos + 1;
                    }
                    if (M[1, 17] == 3)
                    {
                        M[1, 18] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[17, 15] == 3)
                    {
                        M[16, 15] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[9, 9] == 3)
                    {
                        M[9, 10] = 2;
                        puntaje = puntaje + 10;
                    }
                }
                // derecha
                if (tecla.Key == ConsoleKey.RightArrow)
                {
                    if (M[fv, cv + 1] != 0)
                    {
                        M[fv, cv + 1] = 3;
                        M[fv, cv] = 1;
                        cv++;
                        movimientos = movimientos + 1;
                    }
                    if (M[1, 17] == 3)
                    {
                        M[1, 18] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[17, 15] == 3)
                    {
                        M[16, 15] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[9, 9] == 3)
                    {
                        M[9, 10] = 2;
                        puntaje = puntaje + 10;
                    }
                }
                if (M[1, 18] == 2 && M[16, 15] == 2 && M[9, 10] == 2)
                {
                    PintarTablero();
                    Console.WriteLine("Felicidades Presione una tecla para avanzar al nivel 2");
                    puntajetotal = puntajetotal + puntaje;
                    tecla = Console.ReadKey(false);
                    Dos();
                    tecla = Console.ReadKey(false);
                    b = 1;
                }
            } while (b == 0);

        }


        //************************************************************************************

        static void Dos() //0 es paredes. 1 es camino
        {
            limpiarcontadores();
            int fv = 18, cv = 1;

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {

                    if (i == 0)
                        M[i, j] = 0;

                    else
                    {
                        if (i == 1 && j < 8)
                            M[i, j] = 0;

                        else
                        {
                            if (i == 6 && j < 14)
                                M[i, j] = 1;
                            if (i == 1 && j == 19)
                                M[i, j] = 0;

                            if (i == 2 && j < 5)
                                M[i, j] = 0;
                            if (i == 8 && j < 5)
                                M[i, j] = 1;
                            if (i == 2 && j == 19)
                                M[i, j] = 0;

                            if (j == 0 || j == 19)
                                M[i, j] = 0;
                            if (j != 0 && j != 19)
                                M[i, j] = 1;
                            if (i == 19 && j < 20)
                                M[i, j] = 0;
                        }

                    }
                }

            }
            M[1, 12] = 0;
            M[6, 13] = 2; //primera caja

            M[2, 18] = 0;
            M[6, 14] = 9; //1er objetivo

            M[18, 1] = 3; // jugador
            M[15, 16] = 0;
            M[15, 15] = 0;
            M[15, 14] = 0;
            M[16, 16] = 0;
            M[8, 5] = 9; //3er objetivo

            M[8, 4] = 2; //3er caja

            M[16, 14] = 0;
            M[6, 6] = 0;
            M[8, 10] = 0;
            M[8, 11] = 0;
            M[9, 11] = 0;
            M[10, 11] = 0;

            M[15, 4] = 2; // segunda caja
            M[15, 5] = 9; //2do objetivo
            M[10, 10] = 0;
            M[18, 18] = 0;

            ConsoleKeyInfo tecla = new ConsoleKeyInfo();

            int b = 0; //flag
            do
            {
                PintarTablero();
                tecla = Console.ReadKey(true);
                //arriba
                if (tecla.Key == ConsoleKey.UpArrow)
                {
                    if (M[fv - 1, cv] != 0)
                    {
                        M[fv - 1, cv] = 3;
                        M[fv, cv] = 1;
                        fv--;
                        movimientos = movimientos + 1;
                    }
                    if (M[6, 13] == 3)
                    {
                        M[6, 14] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[8, 4] == 3)
                    {
                        M[8, 5] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[15, 4] == 3)
                    {
                        M[15, 5] = 2;
                        puntaje = puntaje + 10;
                    }
                }

                //abajo
                if (tecla.Key == ConsoleKey.DownArrow)
                {
                    if (M[fv + 1, cv] != 0)
                    {
                        M[fv + 1, cv] = 3;
                        M[fv, cv] = 1;
                        fv++;
                        movimientos = movimientos + 1;
                    }
                    if (M[6, 13] == 3)
                    {
                        M[6, 14] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[8, 4] == 3)
                    {
                        M[8, 5] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[15, 4] == 3)
                    {
                        M[15, 5] = 2;
                        puntaje = puntaje + 10;
                    }
                }
                //izquierda
                if (tecla.Key == ConsoleKey.LeftArrow)
                {
                    if (M[fv, cv - 1] != 0)
                    {
                        M[fv, cv - 1] = 3;
                        M[fv, cv] = 1;
                        cv--;
                        movimientos = movimientos + 1;
                    }
                    if (M[6, 13] == 3)
                    {
                        M[6, 14] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[8, 4] == 3)
                    {
                        M[8, 5] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[15, 4] == 3)
                    {
                        M[15, 5] = 2;
                        puntaje = puntaje + 10;
                    }
                }
                // derecha
                if (tecla.Key == ConsoleKey.RightArrow)
                {
                    if (M[fv, cv + 1] != 0)
                    {
                        M[fv, cv + 1] = 3;
                        M[fv, cv] = 1;
                        cv++;
                        movimientos = movimientos + 1;
                    }
                    if (M[6, 13] == 3)
                    {
                        M[6, 14] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[8, 4] == 3)
                    {
                        M[8, 5] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[15, 4] == 3)
                    {
                        M[15, 5] = 2;
                        puntaje = puntaje + 10;
                    }
                }
                if (M[6, 14] == 2 && M[8, 5] == 2 && M[15, 5] == 2)
                {
                    PintarTablero();
                    Console.WriteLine("Felicidades Presione una tecla para avanzar al nivel 3");
                    puntajetotal = puntajetotal + puntaje;
                    tecla = Console.ReadKey(false);
                    Tres();
                    tecla = Console.ReadKey(false);
                    b = 1;
                }
            } while (b == 0);

        }

        static void Tres() //0 es paredes. 1 es camino
        {
            limpiarcontadores();
            int fv = 18, cv = 1;

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {

                    if (i == 0)
                        M[i, j] = 0;

                    else
                    {
                        if (i == 1 && j < 8)
                            M[i, j] = 0;

                        else
                        {
                            if (i == 1 && j < 20)
                                M[i, j] = 1;
                            if (i == 1 && j == 19)
                                M[i, j] = 0;

                            if (i == 2 && j < 5)
                                M[i, j] = 0;
                            if (i == 2 && j < 18)
                                M[i, j] = 1;
                            if (i == 2 && j == 19)
                                M[i, j] = 0;

                            if (j == 0 || j == 19)
                                M[i, j] = 0;
                            if (j != 0 && j != 19)
                                M[i, j] = 1;
                            if (i == 19 && j < 20)
                                M[i, j] = 0;
                        }

                    }
                }

            }
            //f  c
            M[1, 19] = 0;
            M[4, 13] = 2; //1er caja

            M[2, 18] = 0;
            M[4, 14] = 9; // 1er objetivo
            M[18, 1] = 3;
            M[15, 16] = 0;
            M[15, 15] = 0;
            M[15, 14] = 0;
            M[16, 16] = 0;

            M[9, 15] = 9; //3er objeetivop
            M[9, 14] = 2; //3er caja

            M[16, 14] = 0;
            M[6, 6] = 0;
            M[8, 10] = 0;
            M[8, 11] = 0;
            M[9, 11] = 0;
            M[10, 11] = 0;

            M[14, 9] = 2; //2da caja
            M[14, 10] = 9; // 2do objetivo
            M[10, 10] = 0;
            M[18, 18] = 0;
            ConsoleKeyInfo tecla = new ConsoleKeyInfo();

            int b = 0;
            do
            {
                PintarTablero();
                tecla = Console.ReadKey(true);
                //arriba
                if (tecla.Key == ConsoleKey.UpArrow)
                {
                    if (M[fv - 1, cv] != 0)
                    {
                        M[fv - 1, cv] = 3;
                        M[fv, cv] = 1;
                        fv--;
                        movimientos++;
                    }
                    if (M[4, 13] == 3)  //1er caja
                    { 
                        M[4, 14] = 2; //1er objetivo
                        puntaje = puntaje + 10;
                    }
                    if (M[9, 14] == 3) //3er caja
                    {
                        M[9, 15] = 2; //3er objetivo
                        puntaje = puntaje + 10;
                    }
                    if (M[14, 9] == 3) //2da caja
                    {
                        M[14, 10] = 2;  //2do objetivo
                        puntaje = puntaje + 10;

                    }
                }

                //abajo
                if (tecla.Key == ConsoleKey.DownArrow)
                {
                    if (M[fv + 1, cv] != 0)
                    {
                        M[fv + 1, cv] = 3;
                        M[fv, cv] = 1;
                        fv++;
                        movimientos++;
                    }
                    if (M[4, 13] == 3)  //1er caja
                    {
                        M[4, 14] = 2; //1er objetivo
                        puntaje = puntaje + 10;
                    }
                    if (M[9, 14] == 3) //3er caja
                    {
                        M[9, 15] = 2; //3er objetivo
                        puntaje = puntaje + 10;
                    }
                    if (M[14, 9] == 3) //2da caja
                    {
                        M[14, 10] = 2;  //2do objetivo
                        puntaje = puntaje + 10;

                    }
                }
                //izquierda
                if (tecla.Key == ConsoleKey.LeftArrow)
                {
                    if (M[fv, cv - 1] != 0)
                    {
                        M[fv, cv - 1] = 3;
                        M[fv, cv] = 1;
                        cv--;
                        movimientos++;
                    }
                    if (M[4, 13] == 3)  //1er caja
                    {
                        M[4, 14] = 2; //1er objetivo
                        puntaje = puntaje + 10;
                    }
                    if (M[9, 14] == 3) //3er caja
                    {
                        M[9, 15] = 2; //3er objetivo
                        puntaje = puntaje + 10;
                    }
                    if (M[14, 9] == 3) //2da caja
                    {
                        M[14, 10] = 2;  //2do objetivo
                        puntaje = puntaje + 10;

                    }
                }
                // derecha
                if (tecla.Key == ConsoleKey.RightArrow)
                {
                    if (M[fv, cv + 1] != 0)
                    {
                        M[fv, cv + 1] = 3;
                        M[fv, cv] = 1;
                        cv++;
                        movimientos++;
                    }
                    if (M[4, 13] == 3)  //1er caja
                    {
                        M[4, 14] = 2; //1er objetivo
                        puntaje = puntaje + 10;
                    }
                    if (M[9, 14] == 3) //3er caja
                    {
                        M[9, 15] = 2; //3er objetivo
                        puntaje = puntaje + 10;
                    }
                    if (M[14, 9] == 3) //2da caja
                    {
                        M[14, 10] = 2;  //2do objetivo
                        puntaje = puntaje + 10;

                    }
                }  //1er obj           3er objetivo    2do objetivo 
                if (M[4, 14] == 2 && M[9, 15] == 2 && M[14, 10] == 2)
                {
                    PintarTablero();
                    Console.WriteLine("Felicidades Presione una tecla para avanzar al nivel 4");
                    puntajetotal = puntajetotal + puntaje;
                    tecla = Console.ReadKey(false);
                    Cuatro();
                    tecla = Console.ReadKey(false);
                    b = 1;
                }
            } while (b == 0);

        }

        static void Cuatro() //0 es paredes. 1 es camino
        {
            limpiarcontadores();
            int fv = 18, cv = 1;

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {

                    if (i == 0)
                        M[i, j] = 0;

                    else
                    {
                        if (i == 1 && j < 8)
                            M[i, j] = 0;

                        else
                        {
                            if (i == 1 && j < 20)
                                M[i, j] = 1;
                            if (i == 1 && j == 19)
                                M[i, j] = 0;

                            if (i == 2 && j < 5)
                                M[i, j] = 0;
                            if (i == 2 && j < 18)
                                M[i, j] = 1;
                            if (i == 2 && j == 19)
                                M[i, j] = 0;

                            if (j == 0 || j == 19)
                                M[i, j] = 0;
                            if (j != 0 && j != 19)
                                M[i, j] = 1;
                            if (i == 19 && j < 20)
                                M[i, j] = 0;
                        }

                    }
                }

            }
            M[1, 19] = 0;
            M[8, 14] = 2; //caja1

            M[2, 18] = 0;
            M[8, 15] = 9; //obj1
            M[18, 1] = 3;
            M[15, 16] = 0;
            M[15, 15] = 0;
            M[15, 14] = 0;
            M[16, 16] = 0;

            M[14, 16] = 9; // obj 3
            M[14, 15] = 2; //caja3
 
            M[16, 14] = 0;
            M[6, 6] = 0;
            M[8, 10] = 0;
            M[8, 11] = 0;
            M[9, 11] = 0;
            M[10, 11] = 0;

            M[11, 11] = 2; //caja2
            M[11, 12] = 9; //obj2
            M[10, 10] = 0;
            M[18, 18] = 0;
            ConsoleKeyInfo tecla = new ConsoleKeyInfo();

            int b = 0;
            do
            {
                PintarTablero();
                tecla = Console.ReadKey(true);
                //arriba
                if (tecla.Key == ConsoleKey.UpArrow)
                {
                    if (M[fv - 1, cv] != 0)
                    {
                        M[fv - 1, cv] = 3;
                        M[fv, cv] = 1;
                        fv--;
                        movimientos++;
                    }
                    if (M[8, 14] == 3) //caja1
                    {
                        M[8, 15] = 2; //obj1
                        puntaje = puntaje + 10;
                    }
                    if (M[14, 15] == 3) //caja3
                    {
                        M[14, 16] = 2; //obj3
                        puntaje = puntaje + 10;
                    }
                    if (M[11, 11] == 3) //caja2
                    {
                        M[11, 12] = 2; //obj2
                        puntaje = puntaje + 10;
                    }
                }

                //abajo
                if (tecla.Key == ConsoleKey.DownArrow)
                {
                    if (M[fv + 1, cv] != 0)
                    {
                        M[fv + 1, cv] = 3;
                        M[fv, cv] = 1;
                        fv++;
                        movimientos++;
                    }
                    if (M[8, 14] == 3) //caja1
                    {
                        M[8, 15] = 2; //obj1
                        puntaje = puntaje + 10;
                    }
                    if (M[14, 15] == 3) //caja3
                    {
                        M[14, 16] = 2; //obj3
                        puntaje = puntaje + 10;
                    }
                    if (M[11, 11] == 3) //caja2
                    {
                        M[11, 12] = 2; //obj2
                        puntaje = puntaje + 10;
                    }
                }
                //izquierda
                if (tecla.Key == ConsoleKey.LeftArrow)
                {
                    if (M[fv, cv - 1] != 0)
                    {
                        M[fv, cv - 1] = 3;
                        M[fv, cv] = 1;
                        cv--;
                        movimientos++;
                    }
                    if (M[8, 14] == 3) //caja1
                    {
                        M[8, 15] = 2; //obj1
                        puntaje = puntaje + 10;
                    }
                    if (M[14, 15] == 3) //caja3
                    {
                        M[14, 16] = 2; //obj3
                        puntaje = puntaje + 10;
                    }
                    if (M[11, 11] == 3) //caja2
                    {
                        M[11, 12] = 2; //obj2
                        puntaje = puntaje + 10;
                    }
                }
                // derecha
                if (tecla.Key == ConsoleKey.RightArrow)
                {
                    if (M[fv, cv + 1] != 0)
                    {
                        M[fv, cv + 1] = 3;
                        M[fv, cv] = 1;
                        cv++;
                        movimientos++;
                    }
                    if (M[8, 14] == 3) //caja1
                    {
                        M[8, 15] = 2; //obj1
                        puntaje = puntaje + 10;
                    }
                    if (M[14, 15] == 3) //caja3
                    {
                        M[14, 16] = 2; //obj3
                        puntaje = puntaje + 10;
                    }
                    if (M[11, 11] == 3) //caja2
                    {
                        M[11, 12] = 2; //obj2
                        puntaje = puntaje + 10;
                    }
                }
                if (M[8, 15] == 2 && M[14, 16] == 2 && M[11, 12] == 2)
                {
                    PintarTablero();
                    Console.WriteLine("Felicidades Presione una tecla para avanzar al nivel 5");
                    puntajetotal = puntajetotal + puntaje;
                    tecla = Console.ReadKey(false);
                    Cinco();
                    tecla = Console.ReadKey(false);
                    b = 1;
                }
            } while (b == 0);

        }


        static void Cinco() //0 es paredes. 1 es camino
        {
            limpiarcontadores();
            int fv = 18, cv = 1;

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {

                    if (i == 0)
                        M[i, j] = 0;

                    else
                    {
                        if (i == 1 && j < 8)
                            M[i, j] = 0;

                        else
                        {
                            if (i == 1 && j < 20)
                                M[i, j] = 1;
                            if (i == 1 && j == 19)
                                M[i, j] = 0;

                            if (i == 2 && j < 5)
                                M[i, j] = 0;
                            if (i == 2 && j < 18)
                                M[i, j] = 1;
                            if (i == 2 && j == 19)
                                M[i, j] = 0;

                            if (j == 0 || j == 19)
                                M[i, j] = 0;
                            if (j != 0 && j != 19)
                                M[i, j] = 1;
                            if (i == 19 && j < 20)
                                M[i, j] = 0;
                        }

                    }
                }

            }
            M[1, 19] = 0;
            M[6, 15] = 2; //caja1

            M[2, 18] = 0;
            M[6, 16] = 9;//obj1
            M[18, 1] = 3;
            M[15, 16] = 0;
            M[15, 15] = 0;
            M[15, 14] = 0;
            M[16, 16] = 0;

            M[9, 14] = 9;//obj3
            M[9, 13] = 2;//caja3

            M[16, 14] = 0;
            M[6, 6] = 0;
            M[8, 10] = 0;
            M[8, 11] = 0;
            M[9, 11] = 0;
            M[10, 11] = 0;

            M[18, 10] = 2;//caja2
            M[18, 11] = 9;//obj2
            M[10, 10] = 0;
            M[18, 18] = 0;
            ConsoleKeyInfo tecla = new ConsoleKeyInfo();

            int b = 0;
            do
            {
                PintarTablero();
                tecla = Console.ReadKey(true);
                //arriba
                if (tecla.Key == ConsoleKey.UpArrow)
                {
                    if (M[fv - 1, cv] != 0)
                    {
                        M[fv - 1, cv] = 3;
                        M[fv, cv] = 1;
                        fv--;
                        movimientos++;
                    }
                    if (M[6, 15] == 3)
                    {
                        M[6, 16] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[9, 13] == 3)
                    {
                        M[9, 14] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[18, 10] == 3)
                    {
                        M[18, 11] = 2;
                        puntaje = puntaje + 10;
                    }
                }

                //abajo
                if (tecla.Key == ConsoleKey.DownArrow)
                {
                    if (M[fv + 1, cv] != 0)
                    {
                        M[fv + 1, cv] = 3;
                        M[fv, cv] = 1;
                        fv++;
                        movimientos++;
                    }
                    if (M[6, 15] == 3)
                    {
                        M[6, 16] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[9, 13] == 3)
                    {
                        M[9, 14] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[18, 10] == 3)
                    {
                        M[18, 11] = 2;
                        puntaje = puntaje + 10;
                    }
                }
                //izquierda
                if (tecla.Key == ConsoleKey.LeftArrow)
                {
                    if (M[fv, cv - 1] != 0)
                    {
                        M[fv, cv - 1] = 3;
                        M[fv, cv] = 1;
                        cv--;
                        movimientos++;
                    }
                    if (M[6, 15] == 3)
                    {
                        M[6, 16] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[9, 13] == 3)
                    {
                        M[9, 14] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[18, 10] == 3)
                    {
                        M[18, 11] = 2;
                        puntaje = puntaje + 10;
                    }
                }
                // derecha
                if (tecla.Key == ConsoleKey.RightArrow)
                {
                    if (M[fv, cv + 1] != 0)
                    {
                        M[fv, cv + 1] = 3;
                        M[fv, cv] = 1;
                        cv++;
                        movimientos++;

                    }
                    if (M[6, 15] == 3)
                    {
                        M[6, 16] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[9, 13] == 3)
                    {
                        M[9, 14] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[18, 10] == 3)
                    {
                        M[18, 11] = 2;
                        puntaje = puntaje + 10;
                    }
                }
                if (M[6, 16] == 2 && M[9, 14] == 2 && M[18, 11] == 2)
                {
                    PintarTablero();
                    Console.WriteLine("Felicidades Presione una tecla para avanzar al nivel 6");
                    puntajetotal = puntajetotal + puntaje;
                    tecla = Console.ReadKey(false);
                    Seis();
                    tecla = Console.ReadKey(false);
                    b = 1;
                }
            } while (b == 0);

        }

        static void Seis() //0 es paredes. 1 es camino
        {
            limpiarcontadores();
            int fv = 18, cv = 1;

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {

                    if (i == 0)
                        M[i, j] = 0;

                    else
                    {
                        if (i == 1 && j < 8)
                            M[i, j] = 0;

                        else
                        {
                            if (i == 1 && j < 20)
                                M[i, j] = 1;
                            if (i == 1 && j == 19)
                                M[i, j] = 0;

                            if (i == 2 && j < 5)
                                M[i, j] = 0;
                            if (i == 2 && j < 18)
                                M[i, j] = 1;
                            if (i == 2 && j == 19)
                                M[i, j] = 0;

                            if (j == 0 || j == 19)
                                M[i, j] = 0;
                            if (j != 0 && j != 19)
                                M[i, j] = 1;
                            if (i == 19 && j < 20)
                                M[i, j] = 0;
                        }

                    }
                }

            }
            M[1, 19] = 0;
            M[1, 15] = 2;

            M[2, 18] = 0;
            M[1, 16] = 9;
            M[18, 1] = 3;
            M[15, 16] = 0;
            M[15, 15] = 0;
            M[15, 14] = 0;
            M[16, 16] = 0;

            M[8, 16] = 9;
            M[8, 15] = 2;

            M[16, 14] = 0;
            M[6, 6] = 0;
            M[8, 10] = 0;
            M[8, 11] = 0;
            M[9, 11] = 0;
            M[10, 11] = 0;

            M[6, 14] = 2;
            M[6, 15] = 9;
            M[10, 10] = 0;
            M[18, 18] = 0;
            ConsoleKeyInfo tecla = new ConsoleKeyInfo();

            int b = 0;
            do
            {
                PintarTablero();
                tecla = Console.ReadKey(true);
                //arriba
                if (tecla.Key == ConsoleKey.UpArrow)
                {
                    if (M[fv - 1, cv] != 0)
                    {
                        M[fv - 1, cv] = 3;
                        M[fv, cv] = 1;
                        fv--;
                        movimientos++;
                    }
                    if (M[1, 15] == 3)
                    {
                        M[1, 16] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[8, 15] == 3)
                    {
                        M[8, 16] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[6, 14] == 3)
                    {
                        M[6, 15] = 2;
                        puntaje = puntaje + 10;
                    }
                }

                //abajo
                if (tecla.Key == ConsoleKey.DownArrow)
                {
                    if (M[fv + 1, cv] != 0)
                    {
                        M[fv + 1, cv] = 3;
                        M[fv, cv] = 1;
                        fv++;
                        movimientos++;
                    }
                    if (M[1, 15] == 3)
                    {
                        M[1, 16] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[8, 15] == 3)
                    {
                        M[8, 16] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[6, 14] == 3)
                    {
                        M[6, 15] = 2;
                        puntaje = puntaje + 10;
                    }
                }
                //izquierda
                if (tecla.Key == ConsoleKey.LeftArrow)
                {
                    if (M[fv, cv - 1] != 0)
                    {
                        M[fv, cv - 1] = 3;
                        M[fv, cv] = 1;
                        cv--;
                        movimientos++;
                    }
                    if (M[1, 15] == 3)
                    {
                        M[1, 16] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[8, 15] == 3)
                    {
                        M[8, 16] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[6, 14] == 3)
                    {
                        M[6, 15] = 2;
                        puntaje = puntaje + 10;
                    }
                }
                // derecha
                if (tecla.Key == ConsoleKey.RightArrow)
                {
                    if (M[fv, cv + 1] != 0)
                    {
                        M[fv, cv + 1] = 3;
                        M[fv, cv] = 1;
                        cv++;
                        movimientos++;
                    }
                    if (M[1, 15] == 3)
                    {
                        M[1, 16] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[8, 15] == 3)
                    {
                        M[8, 16] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[6, 14] == 3)
                    {
                        M[6, 15] = 2;
                        puntaje = puntaje + 10;
                    }
                }
                if (M[1, 16] == 2 && M[8, 16] == 2 && M[6, 15] == 2)
                {
                    PintarTablero();
                    Console.WriteLine("Felicidades Presione una tecla para avanzar al nivel 7");
                    puntajetotal = puntajetotal + puntaje;
                    tecla = Console.ReadKey(false);
                    Siete();
                    tecla = Console.ReadKey(false);
                    b = 1;
                }
            } while (b == 0);

        }

        static void Siete() //0 es paredes. 1 es camino
        {
            limpiarcontadores();
            int fv = 18, cv = 1;

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {

                    if (i == 0)
                        M[i, j] = 0;

                    else
                    {
                        if (i == 1 && j < 8)
                            M[i, j] = 0;

                        else
                        {
                            if (i == 1 && j < 20)
                                M[i, j] = 1;
                            if (i == 1 && j == 19)
                                M[i, j] = 0;

                            if (i == 2 && j < 5)
                                M[i, j] = 0;
                            if (i == 2 && j < 18)
                                M[i, j] = 1;
                            if (i == 2 && j == 19)
                                M[i, j] = 0;

                            if (j == 0 || j == 19)
                                M[i, j] = 0;
                            if (j != 0 && j != 19)
                                M[i, j] = 1;
                            if (i == 19 && j < 20)
                                M[i, j] = 0;
                        }

                    }
                }

            }
            M[1, 19] = 0;
            M[1, 17] = 2;

            M[2, 18] = 0;
            M[1, 18] = 9;
            M[18, 1] = 3;
            M[15, 16] = 0;
            M[15, 15] = 0;
            M[15, 14] = 0;
            M[16, 16] = 0;

            M[16, 15] = 9;
            M[17, 15] = 2;

            M[16, 14] = 0;
            M[6, 6] = 0;
            M[8, 10] = 0;
            M[8, 11] = 0;
            M[9, 11] = 0;
            M[10, 11] = 0;

            M[9, 9] = 2;
            M[9, 10] = 9;
            M[10, 10] = 0;
            M[18, 18] = 0;
            ConsoleKeyInfo tecla = new ConsoleKeyInfo();

            int b = 0;
            do
            {
                PintarTablero();
                tecla = Console.ReadKey(true);
                //arriba
                if (tecla.Key == ConsoleKey.UpArrow)
                {
                    if (M[fv - 1, cv] != 0)
                    {
                        M[fv - 1, cv] = 3;
                        M[fv, cv] = 1;
                        fv--;
                        movimientos++;
                    }
                    if (M[1, 17] == 3)
                    {
                        M[1, 18] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[17, 15] == 3)
                    {
                        M[16, 15] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[9, 9] == 3)
                    {
                        M[9, 10] = 2;
                        puntaje = puntaje + 10;
                    }
                }

                //abajo
                if (tecla.Key == ConsoleKey.DownArrow)
                {
                    if (M[fv + 1, cv] != 0)
                    {
                        M[fv + 1, cv] = 3;
                        M[fv, cv] = 1;
                        fv++;
                        movimientos++;
                    }
                    if (M[1, 17] == 3)
                    {
                        M[1, 18] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[17, 15] == 3)
                    {
                        M[16, 15] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[9, 9] == 3)
                    {
                        M[9, 10] = 2;
                        puntaje = puntaje + 10;
                    }
                }
                //izquierda
                if (tecla.Key == ConsoleKey.LeftArrow)
                {
                    if (M[fv, cv - 1] != 0)
                    {
                        M[fv, cv - 1] = 3;
                        M[fv, cv] = 1;
                        cv--;
                        movimientos++;
                    }
                    if (M[1, 17] == 3)
                    {
                        M[1, 18] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[17, 15] == 3)
                    {
                        M[16, 15] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[9, 9] == 3)
                    {
                        M[9, 10] = 2;
                        puntaje = puntaje + 10;
                    }
                }
                // derecha
                if (tecla.Key == ConsoleKey.RightArrow)
                {
                    if (M[fv, cv + 1] != 0)
                    {
                        M[fv, cv + 1] = 3;
                        M[fv, cv] = 1;
                        cv++;
                        movimientos++;
                    }
                    if (M[1, 17] == 3)
                    {
                        M[1, 18] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[17, 15] == 3)
                    {
                        M[16, 15] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[9, 9] == 3)
                    {
                        M[9, 10] = 2;
                        puntaje = puntaje + 10;
                    }
                }
                if (M[1, 18] == 2 && M[16, 15] == 2 && M[9, 10] == 2)
                {
                    PintarTablero();
                    Console.WriteLine("Felicidades Presione una tecla para avanzar al nivel 8");
                    puntajetotal = puntajetotal + puntaje;
                    tecla = Console.ReadKey(false);
                    Ocho();
                    tecla = Console.ReadKey(false);
                    b = 1;
                }
            } while (b == 0);

        }

        static void Ocho() //0 es paredes. 1 es camino
        {
            limpiarcontadores();
            int fv = 18, cv = 1;

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {

                    if (i == 0)
                        M[i, j] = 0;

                    else
                    {
                        if (i == 1 && j < 8)
                            M[i, j] = 0;

                        else
                        {
                            if (i == 1 && j < 20)
                                M[i, j] = 1;
                            if (i == 1 && j == 19)
                                M[i, j] = 0;

                            if (i == 2 && j < 5)
                                M[i, j] = 0;
                            if (i == 2 && j < 18)
                                M[i, j] = 1;
                            if (i == 2 && j == 19)
                                M[i, j] = 0;

                            if (j == 0 || j == 19)
                                M[i, j] = 0;
                            if (j != 0 && j != 19)
                                M[i, j] = 1;
                            if (i == 19 && j < 20)
                                M[i, j] = 0;
                        }

                    }
                }

            }
            M[1, 19] = 0;
            M[5, 14] = 2; //caja1

            M[2, 18] = 0;
            M[5, 15] = 9; //obj1
            M[18, 1] = 3;
            M[15, 16] = 0;
            M[15, 15] = 0;
            M[15, 14] = 0;
            M[16, 16] = 0;

            M[12, 16] = 9; //obj3
            M[12, 15] = 2; //caja3

            M[16, 14] = 0;
            M[6, 6] = 0;
            M[8, 10] = 0;
            M[8, 11] = 0;
            M[9, 11] = 0;
            M[10, 11] = 0;

            M[6, 14] = 2; //caja2
            M[6, 15] = 9; //obj2
            M[10, 10] = 0;
            M[18, 18] = 0;
            ConsoleKeyInfo tecla = new ConsoleKeyInfo();

            int b = 0;
            do
            {
                PintarTablero();
                tecla = Console.ReadKey(true);
                //arriba
                if (tecla.Key == ConsoleKey.UpArrow)
                {
                    if (M[fv - 1, cv] != 0)
                    {
                        M[fv - 1, cv] = 3;
                        M[fv, cv] = 1;
                        fv--;
                        movimientos++;
                    }
                    if (M[5, 14] == 3)
                    {
                        M[5, 15] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[12, 15] == 3)
                    {
                        M[12, 16] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[6, 14] == 3)
                    {
                        M[6, 15] = 2;
                        puntaje = puntaje + 10;
                    }
                }

                //abajo
                if (tecla.Key == ConsoleKey.DownArrow)
                {
                    if (M[fv + 1, cv] != 0)
                    {
                        M[fv + 1, cv] = 3;
                        M[fv, cv] = 1;
                        fv++;
                        movimientos++;
                    }
                    if (M[5, 14] == 3)
                    {
                        M[5, 15] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[12, 15] == 3)
                    {
                        M[12, 16] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[6, 14] == 3)
                    {
                        M[6, 15] = 2;
                        puntaje = puntaje + 10;
                    }
                }
                //izquierda
                if (tecla.Key == ConsoleKey.LeftArrow)
                {
                    if (M[fv, cv - 1] != 0)
                    {
                        M[fv, cv - 1] = 3;
                        M[fv, cv] = 1;
                        cv--;
                        movimientos++;
                    }
                    if (M[5, 14] == 3)
                    {
                        M[5, 15] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[12, 15] == 3)
                    {
                        M[12, 16] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[6, 14] == 3)
                    {
                        M[6, 15] = 2;
                        puntaje = puntaje + 10;
                    }
                }
                // derecha
                if (tecla.Key == ConsoleKey.RightArrow)
                {
                    if (M[fv, cv + 1] != 0)
                    {
                        M[fv, cv + 1] = 3;
                        M[fv, cv] = 1;
                        cv++;
                        movimientos++;
                    }
                    if (M[5, 14] == 3)
                    {
                        M[5, 15] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[12, 15] == 3)
                    {
                        M[12, 16] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[6, 14] == 3)
                    {
                        M[6, 15] = 2;
                        puntaje = puntaje + 10;
                    }
                }
                if (M[5, 15] == 2 && M[12, 16] == 2 && M[6, 15] == 2)
                {
                    PintarTablero();
                    Console.WriteLine("Felicidades Presione una tecla para avanzar al nivel 9");
                    puntajetotal = puntajetotal + puntaje;
                    tecla = Console.ReadKey(false);
                    Nueve();
                    tecla = Console.ReadKey(false);
                    b = 1;
                }
            } while (b == 0);

        }

        static void Nueve() //0 es paredes. 1 es camino
        {
            limpiarcontadores();
            int fv = 18, cv = 1;

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {

                    if (i == 0)
                        M[i, j] = 0;

                    else
                    {
                        if (i == 1 && j < 8)
                            M[i, j] = 0;

                        else
                        {
                            if (i == 1 && j < 20)
                                M[i, j] = 1;
                            if (i == 1 && j == 19)
                                M[i, j] = 0;

                            if (i == 2 && j < 5)
                                M[i, j] = 0;
                            if (i == 2 && j < 18)
                                M[i, j] = 1;
                            if (i == 2 && j == 19)
                                M[i, j] = 0;

                            if (j == 0 || j == 19)
                                M[i, j] = 0;
                            if (j != 0 && j != 19)
                                M[i, j] = 1;
                            if (i == 19 && j < 20)
                                M[i, j] = 0;
                        }

                    }
                }

            }
            M[1, 19] = 0;
            M[1, 17] = 2;

            M[2, 18] = 0;
            M[1, 18] = 9;
            M[18, 1] = 3;
            M[15, 16] = 0;
            M[15, 15] = 0;
            M[15, 14] = 0;
            M[16, 16] = 0;

            M[16, 15] = 9;
            M[17, 15] = 2;

            M[16, 14] = 0;
            M[6, 6] = 0;
            M[8, 10] = 0;
            M[8, 11] = 0;
            M[9, 11] = 0;
            M[10, 11] = 0;

            M[9, 9] = 2;
            M[9, 10] = 9;
            M[10, 10] = 0;
            M[18, 18] = 0;
            ConsoleKeyInfo tecla = new ConsoleKeyInfo();

            int b = 0;
            do
            {
                PintarTablero();
                tecla = Console.ReadKey(true);
                //arriba
                if (tecla.Key == ConsoleKey.UpArrow)
                {
                    if (M[fv - 1, cv] != 0)
                    {
                        M[fv - 1, cv] = 3;
                        M[fv, cv] = 1;
                        fv--;
                        movimientos++;
                    }
                    if (M[1, 17] == 3)
                    {
                        M[1, 18] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[17, 15] == 3)
                    {
                        M[16, 15] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[9, 9] == 3)
                    {
                        M[9, 10] = 2;
                        puntaje = puntaje + 10;
                    }
                }

                //abajo
                if (tecla.Key == ConsoleKey.DownArrow)
                {
                    if (M[fv + 1, cv] != 0)
                    {
                        M[fv + 1, cv] = 3;
                        M[fv, cv] = 1;
                        fv++;
                        movimientos++;
                    }
                    if (M[1, 17] == 3)
                    {
                        M[1, 18] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[17, 15] == 3)
                    {
                        M[16, 15] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[9, 9] == 3)
                    {
                        M[9, 10] = 2;
                        puntaje = puntaje + 10;
                    }
                }
                //izquierda
                if (tecla.Key == ConsoleKey.LeftArrow)
                {
                    if (M[fv, cv - 1] != 0)
                    {
                        M[fv, cv - 1] = 3;
                        M[fv, cv] = 1;
                        cv--;
                        movimientos++;
                    }
                    if (M[1, 17] == 3)
                    {
                        M[1, 18] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[17, 15] == 3)
                    {
                        M[16, 15] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[9, 9] == 3)
                    {
                        M[9, 10] = 2;
                        puntaje = puntaje + 10;
                    }
                }
                // derecha
                if (tecla.Key == ConsoleKey.RightArrow)
                {
                    if (M[fv, cv + 1] != 0)
                    {
                        M[fv, cv + 1] = 3;
                        M[fv, cv] = 1;
                        cv++;
                        movimientos++;
                    }
                    if (M[1, 17] == 3)
                    {
                        M[1, 18] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[17, 15] == 3)
                    {
                        M[16, 15] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[9, 9] == 3)
                    {
                        M[9, 10] = 2;
                        puntaje = puntaje + 10;
                    }
                }
                if (M[1, 18] == 2 && M[16, 15] == 2 && M[9, 10] == 2)
                {
                    PintarTablero();
                    Console.WriteLine("Felicidades Presione una tecla para avanzar al nivel 10");
                    puntajetotal = puntajetotal + puntaje;
                    tecla = Console.ReadKey(false);
                    Diez();
                    tecla = Console.ReadKey(false);
                    b = 1;
                }
            } while (b == 0);

        }

        static void Diez() //0 es paredes. 1 es camino
        {
            limpiarcontadores();
            int fv = 18, cv = 1;

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {

                    if (i == 0)
                        M[i, j] = 0;

                    else
                    {
                        if (i == 1 && j < 8)
                            M[i, j] = 0;

                        else
                        {
                            if (i == 1 && j < 20)
                                M[i, j] = 1;
                            if (i == 1 && j == 19)
                                M[i, j] = 0;

                            if (i == 2 && j < 5)
                                M[i, j] = 0;
                            if (i == 2 && j < 18)
                                M[i, j] = 1;
                            if (i == 2 && j == 19)
                                M[i, j] = 0;

                            if (j == 0 || j == 19)
                                M[i, j] = 0;
                            if (j != 0 && j != 19)
                                M[i, j] = 1;
                            if (i == 19 && j < 20)
                                M[i, j] = 0;
                        }

                    }
                }

            }
            M[1, 19] = 0;
            M[1, 17] = 2;

            M[2, 18] = 0;
            M[1, 18] = 9;
            M[18, 1] = 3;
            M[15, 16] = 0;
            M[15, 15] = 0;
            M[15, 14] = 0;
            M[16, 16] = 0;

            M[16, 15] = 9;
            M[17, 15] = 2;

            M[16, 14] = 0;
            M[6, 6] = 0;
            M[8, 10] = 0;
            M[8, 11] = 0;
            M[9, 11] = 0;
            M[10, 11] = 0;

            M[9, 9] = 2;
            M[9, 10] = 9;
            M[10, 10] = 0;
            M[18, 18] = 0;
            ConsoleKeyInfo tecla = new ConsoleKeyInfo();

            int b = 0;
            do
            {
                PintarTablero();
                tecla = Console.ReadKey(true);
                //arriba
                if (tecla.Key == ConsoleKey.UpArrow)
                {
                    if (M[fv - 1, cv] != 0)
                    {
                        M[fv - 1, cv] = 3;
                        M[fv, cv] = 1;
                        fv--;
                        movimientos++;
                    }
                    if (M[1, 17] == 3)
                    {
                        M[1, 18] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[17, 15] == 3)
                    {
                        M[16, 15] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[9, 9] == 3)
                    {
                        M[9, 10] = 2;
                        puntaje = puntaje + 10;
                    }
                }

                //abajo
                if (tecla.Key == ConsoleKey.DownArrow)
                {
                    if (M[fv + 1, cv] != 0)
                    {
                        M[fv + 1, cv] = 3;
                        M[fv, cv] = 1;
                        fv++;
                        movimientos++;
                    }
                    if (M[1, 17] == 3)
                    {
                        M[1, 18] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[17, 15] == 3)
                    {
                        M[16, 15] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[9, 9] == 3)
                    {
                        M[9, 10] = 2;
                        puntaje = puntaje + 10;
                    }
                }
                //izquierda
                if (tecla.Key == ConsoleKey.LeftArrow)
                {
                    if (M[fv, cv - 1] != 0)
                    {
                        M[fv, cv - 1] = 3;
                        M[fv, cv] = 1;
                        cv--;
                        movimientos++;
                    }
                    if (M[1, 17] == 3)
                    {
                        M[1, 18] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[17, 15] == 3)
                    {
                        M[16, 15] = 2;
                        puntaje = puntaje + 10;

                    }
                    if (M[9, 9] == 3)
                    {
                        M[9, 10] = 2;
                        puntaje = puntaje + 10;

                    }
                }
                // derecha
                if (tecla.Key == ConsoleKey.RightArrow)
                {
                    if (M[fv, cv + 1] != 0)
                    {
                        M[fv, cv + 1] = 3;
                        M[fv, cv] = 1;
                        cv++;
                        movimientos++;
                    }
                    if (M[1, 17] == 3)
                    {
                        M[1, 18] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[17, 15] == 3)
                    {
                        M[16, 15] = 2;
                        puntaje = puntaje + 10;
                    }
                    if (M[9, 9] == 3)
                    {
                        M[9, 10] = 2;
                        puntaje = puntaje + 10;
                    }
                }
                if (M[1, 18] == 2 && M[16, 15] == 2 && M[9, 10] == 2)
                {
                    //PintarTablero();
                    Console.WriteLine("Felicidades Eres un genio, ");
                    puntajetotal = puntajetotal + puntaje;
                    //tecla = Console.ReadKey(false);
                    //b = 1;
                    //int regresar = 0;
                    //Console.WriteLine("Digita 0 para regresar al menu");
                    //regresar = int.Parse(Console.ReadLine());

                    Console.WriteLine("Tu puntaje se almacenarara ahora");
                    Console.WriteLine("Haz llegado al final del Programa");
                    Console.WriteLine("Digita una tecla para salir ahora");
                    Console.ReadKey();
                    System.Environment.Exit(0);


                }
            } while (b == 0);

        }
    }
}
