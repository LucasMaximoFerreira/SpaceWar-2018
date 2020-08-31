using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {

            
            int op;
            telaInicial();
            Thread.Sleep(6000);


            do
            {

                telaMenu();
                Console.SetCursorPosition(34, 41);
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        telaPlay();

                        break;
                    case 2:
                        telaCreditos();
                        break;
                    case 3:
                        telaInstrucoes();
                        break;

                }



            } while (op != 20);
            Console.ReadKey();

        }


        static public void telaInicial()


        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.DarkGray;

            Console.Clear();
            Console.WriteLine("┌────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
            Console.WriteLine("│                                                                                                                     ");
            Console.WriteLine("│                                                                                                                     ");
            Console.WriteLine("│                                                                                                                     ");
            Console.WriteLine("│                                                                                                                     ");
            Console.WriteLine("│                                                                                                                     ");
            Console.WriteLine("│                                                                                                                     ");
            Console.WriteLine("│                                                                                                                     ");
            Console.WriteLine("│                                                                                                                     ");
            Console.WriteLine("│                     *                                                                                    *          ");
            Console.WriteLine("│                                                                                                                     ");
            Console.WriteLine("│                                                                                                                     ");
            Console.WriteLine("│                                                                                                                     ");
            Console.WriteLine("│                                                                                                                     ");
            Console.WriteLine("│                                                                                                                     ");
            Console.WriteLine("│                                                                                                                     ");
            Console.WriteLine("│                                                                                                                     ");
            Console.WriteLine("│                                                                                                                     ");
            Console.WriteLine("│                                                                                                                     ");
            Console.WriteLine("│                                                                                                                     ");
            Console.WriteLine("│                                                                                                                     ");
            Console.WriteLine("│                                                                                                                     ");
            Console.WriteLine("│                                                                                                                     ");
            Console.WriteLine("│                                                                                                                     ");
            Console.WriteLine("│                                                                                                                     ");
            Console.WriteLine("│                                                                                                                     ");
            Console.WriteLine("│                                                                                                                     ");
            Console.WriteLine("│                                                                                                                     ");
            Console.WriteLine("│                                                                                                                     ");
            Console.WriteLine("│                                                                                                                     ");
            Console.WriteLine("│                                                                                                                     ");
            Console.WriteLine("│                                                                                                                     ");
            Console.WriteLine("│                                                                                                                     ");
            Console.WriteLine("│                                                                                                                     ");
            Console.WriteLine("│                                                                                                                     ");
            Console.WriteLine("│                                                                                                                     ");
            Console.WriteLine("│                                                                   *                                                 ");
            Console.WriteLine("│                                                                                                                     ");
            Console.WriteLine("│                                                                                                    *                ");
            Console.WriteLine("│                                                                                                                     ");
            Console.WriteLine("│                                                                                                                     ");
            Console.WriteLine("|────────────────────────────────────────────────────────────────────────────────────────────────────────────────────|");

            Console.ForegroundColor = ConsoleColor.Black
                ;
            Console.SetCursorPosition(12, 1);
            Console.WriteLine(" .");
            Console.SetCursorPosition(12, 5);
            Console.WriteLine("  ███████████ ████████████ ██           ████████████   ████████████     ██        ██  ███████████ ");
            Console.SetCursorPosition(12, 6);                                                                                     
            Console.WriteLine("  ██          ██        ██ ██           ██        ██   ██        ██     ██        ██  ██          ");
            Console.SetCursorPosition(12, 7);                                                                                     
            Console.WriteLine("  ██          ██        ██ ██           ██        ██   ██        ██     ██        ██  ███████████ ");
            Console.SetCursorPosition(12, 8);                                                                                     
            Console.WriteLine("  ██          ██        ██ ██           ██        ██   ██        ██     ██        ██  ██          ");
            Console.SetCursorPosition(12, 9);                                                                                     
            Console.WriteLine("  ███████████ ████████████ ████████████ ████████████   ███████████████  ████████████  ████████████");
            Console.SetCursorPosition(12, 12);
            Console.WriteLine(" ███████████    ██          ██         ███████████  ███████████    ██               ████████████");
            Console.SetCursorPosition(12, 13);
            Console.WriteLine(" ██             ████      ████             ██       ██             ██               ██        ██");
            Console.SetCursorPosition(12, 14);
            Console.WriteLine(" ███████████    ██  ██  ██  ██             ██       ███████████    ██               ████████████");
            Console.SetCursorPosition(12, 15);
            Console.WriteLine(" ██             ██    ██    ██             ██       ██             ██               ██        ██");
            Console.SetCursorPosition(12, 16);
            Console.WriteLine(" ████████████   ██          ██             ██       ████████████   ████████████     ██        ██    ");
            Console.SetCursorPosition(12, 19);
            Console.WriteLine("                  ███████████   ██        ██  ███████████   ██   ████████████");
            Console.SetCursorPosition(12, 20);                                                                                     
            Console.WriteLine("                  ██            ██        ██  ██            ██   ██        ██");
            Console.SetCursorPosition(12, 21);                                                                                     
            Console.WriteLine("                  ██            ████████████  ███████████   ██   ████████████");
            Console.SetCursorPosition(12, 22);                                                                                     
            Console.WriteLine("                  ██            ██        ██  ██            ██   ██        ██");
            Console.SetCursorPosition(12, 23);                                                                                     
            Console.WriteLine("                  ███████████   ██        ██  ████████████  ██   ██        ██ ");


                                                                                                                                                    
        }                                                                                                                                           
                                                                                                                                                    
        static public void telaMenu()                                                                                                               
        {                                                                                                                                           
                                                                                                                                                    
            Console.ForegroundColor = ConsoleColor.DarkGreen;                                                                                                   
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("                           ┌────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
            Console.WriteLine("                           │                                                                                                                    │");
            Console.WriteLine("                           │                                                                                                                    │");
            Console.WriteLine("                           │                                                                                                                    │");
            Console.WriteLine("                           │                                                                                                                    │");
            Console.WriteLine("                           │                                                                                                                    │");
            Console.WriteLine("                           │                                                                                                                    │");
            Console.WriteLine("                           │                                                                                                                    │");
            Console.WriteLine("                           │                                                                                                                    │");
            Console.WriteLine("                           │                                                                                                                    │");
            Console.WriteLine("                           │                                                                                                                    │");
            Console.WriteLine("                           │                                                                                                                    │");
            Console.WriteLine("                           │                                                                                                                    │");
            Console.WriteLine("                           │                                                                                                                    │");
            Console.WriteLine("                           │                                                                                                                    │");
            Console.WriteLine("                           │                                                                                                                    │");
            Console.WriteLine("                           │                                                                                                                    │");
            Console.WriteLine("                           │                                                                                                                    │");
            Console.WriteLine("                           │                                                                                                                    │");
            Console.WriteLine("                           │                                                                                                                    │");
            Console.WriteLine("                           │                                                                                                                    │");
            Console.WriteLine("                           │                                                                                                                    │");
            Console.WriteLine("                           │                                                                                                                    │");
            Console.WriteLine("                           │                                                                                                                    │");
            Console.WriteLine("                           │                                                                                                                    │");
            Console.WriteLine("                           │                                                                                                                    │");
            Console.WriteLine("                           │                                                                                                                    │");
            Console.WriteLine("                           │                                                                                                                    │");
            Console.WriteLine("                           │                                                                                                                    │");
            Console.WriteLine("                           │                                                                                                                    │");
            Console.WriteLine("                           │                                                                                                                    │");
            Console.WriteLine("                           │                                                                                                                    │");
            Console.WriteLine("                           │                                                                                                                    │");
            Console.WriteLine("                           │                                                                                                                    │");
            Console.WriteLine("                           │                                                                                                                    │");
            Console.WriteLine("                           │                                                                                                                    │");
            Console.WriteLine("                           │                                                                                                                    │");
            Console.WriteLine("                           │                                                                                                                    │");
            Console.WriteLine("                           │                                                                                                                    │");
            Console.WriteLine("                           │                                                                                   JOGAR = pressione 1 + ENTER      │");
            Console.WriteLine("                           │      _                                                                            CREDITOS = pressione 2 + ENTER   │");
            Console.WriteLine("                           │OPÇÃO|_|                                                                           INSTRUCOES = pressione 3 + ENTER │");
            Console.WriteLine("                           |────────────────────────────────────────────────────────────────────────────────────────────────────────────────────|");



            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(61, 12);
            Console.WriteLine("┌────────────────────────────────────────────────────┐");
            Console.SetCursorPosition(61, 13);
            Console.WriteLine("|    ████    ██████    ███████   ███████   ████████  |");
            Console.SetCursorPosition(61, 14);
            Console.WriteLine("|      ██   ██    ██  ██        ██     ██  ██     ██ │");
            Console.SetCursorPosition(61, 15);
            Console.WriteLine("|      ██   ██    ██  ██  ████  ██     ██  ██     ██ │");
            Console.SetCursorPosition(61, 16);
            Console.WriteLine("|  ██  ██   ██    ██  ██    ██  █████████  ███████   │");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(61, 17);
            Console.WriteLine("|   ████     ██████    ██████   ██     ██  ██    ██  │");
            Console.SetCursorPosition(61, 18);
            Console.WriteLine("└────────────────────────────────────────────────────┘");

            Console.SetCursorPosition(44, 20);
            Console.WriteLine("┌────────────────────────────────────────────────────────────────────────────────────┐");
            Console.SetCursorPosition(44, 21);
            Console.WriteLine("|   ██████   ███████     ████████  ████████    ██  ██████████   ███████    ████████  |");
            Console.SetCursorPosition(44, 22);
            Console.WriteLine("|  ██    ██  ██     ██  ██         ██      ██  ██      ██      ██     ██  ██         |");
            Console.SetCursorPosition(44, 23);
            Console.WriteLine("|  ██        ██     ██  ██████     ██      ██  ██      ██      ██     ██  █████████  |");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(44, 24);
            Console.WriteLine("|  ██    ██  ███████    ██         ██      ██  ██      ██      ██     ██         ██  |");
            Console.SetCursorPosition(44, 25);
            Console.WriteLine("|   ██████   ██     ██   ████████  ████████    ██      ██       ███████   ████████   |");
            Console.SetCursorPosition(44, 26);
            Console.WriteLine("└────────────────────────────────────────────────────────────────────────────────────┘");

            Console.SetCursorPosition(33, 28);
            Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
            Console.SetCursorPosition(33, 29);
            Console.WriteLine("|  ██   ███████    ████████  ██████████  ████████    ██    ██   ██████     ███████     ███████   ████████  |");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(33, 30);
            Console.WriteLine("|  ██   ██    ██  ██             ██      ██      ██  ██    ██  ██    ██   ██     ██  ██         ██         |");
            Console.SetCursorPosition(33, 31);
            Console.WriteLine("|  ██   ██    ██  █████████      ██      ██      ██  ██    ██  ██         ██     ██  ███████    █████████  |");
            Console.SetCursorPosition(33, 32);
            Console.WriteLine("|  ██   ██    ██         ██      ██      ████████    ██    ██  ██    ██   ██     ██  ██                ██  |");
            Console.SetCursorPosition(33, 33);
            Console.WriteLine("|  ██   ██    ██  ████████       ██      ██      ██   ██████    ██████     ███████     ███████  ████████   |");
            Console.SetCursorPosition(33, 34);
            Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────────────────────┘");


            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(34, 2);
            Console.WriteLine("  ███████████ ████████████ ████████████ ████████████ ████████████     ██   ██   ██ ████████████ ██████████   ");
            Console.SetCursorPosition(34, 3);
            Console.WriteLine(" ██           ██        ██ ██        ██ ██           ██               ██   ██   ██ ██        ██ ██       ██  ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(34, 4);
            Console.WriteLine(" ████████████ ██████████   ██        ██ ██           ███████          ██   ██   ██ ██        ██ ██       ██  ");
            Console.SetCursorPosition(34, 5);
            Console.WriteLine("           ██ ██           ████████████ ██           ██               ██   ██   ██ ████████████ ██████████   ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(34, 6);
            Console.WriteLine(" ███████████  ██           ██        ██ ████████████ ████████████       ████████   ██        ██ ██       ██  ");

        }
        static public void telaCreditos()

        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            ConsoleKeyInfo tecla;

            do
            {
                Console.Clear();
                Console.WriteLine("                           ┌────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");// 1
                Console.WriteLine("                           │                                                                                                                    │");// 2
                Console.WriteLine("                           │                                                                                                                    │");// 3
                Console.WriteLine("                           │              *                                                                                                     │");// 4
                Console.WriteLine("                           │                                                                                                                    │");// 5
                Console.WriteLine("                           │      *                                                                                                             │");// 6
                Console.WriteLine("                           │                                                                                                                    │");// 7
                Console.WriteLine("                           │                                                                                                                    │");// 8
                Console.WriteLine("                           │                                                              *                                                     │");// 9
                Console.WriteLine("                           │                                                                                               *                    │");// 10
                Console.WriteLine("                           │                *                             - COORDENADORES DO PROJETO -                                          │");// 11
                Console.WriteLine("                           │                                                                                                                    │");// 12
                Console.WriteLine("                           │                                                   -ANA PAULA.                                                      │");// 13
                Console.WriteLine("                           │                                                   -FABIANA.                                                        │");// 14
                Console.WriteLine("                           │                                                   -RONALDO VAQUELI.                                                │");// 15
                Console.WriteLine("                           │                                                                                                                    │");// 16
                Console.WriteLine("                           │                                                   - DESENVOLVEDORES -                                              │");// 17
                Console.WriteLine("                           │                                                                                                                    │");// 18
                Console.WriteLine("                           │                                                   -LUCAS MÁXIMO.                                                   │");// 19
                Console.WriteLine("                           │                                                   -AMAURY JR.                                                      │");// 20
                Console.WriteLine("                           │                                                   -MATHEUS PRADO.                                                  │");// 21
                Console.WriteLine("                           │                                                   -GUILHERME BIANCHINI                                             │");// 22
                Console.WriteLine("                           │                                                   -MAURÍCIO MAIA                                                   │");// 23
                Console.WriteLine("                           │                                                   -FABRÍCIO CRUZ                                                   │");// 24
                Console.WriteLine("                           │                                                                                                                    │");// 25
                Console.WriteLine("                           │                                                    - PRGRAMADORES -                                                │");// 26
                Console.WriteLine("                           │                                                                                                                    │");// 27
                Console.WriteLine("                           │                                                   -LUCAS MÁXIMO                                                    │");// 28
                Console.WriteLine("                           │                                                   -MAURÍCIO MAIA                                                   │");// 29
                Console.WriteLine("                           │                                                                                                                    │");// 30
                Console.WriteLine("                           │                                                                                                                    │");// 31
                Console.WriteLine("                           │                                                     - DESIGNERS -                                                  │");// 32
                Console.WriteLine("                           │                                                                                                                    │");// 33
                Console.WriteLine("                           │                                                   -AMAURY JR.                                                      │");// 34
                Console.WriteLine("                           │      *                                            -GUILHERME BIANCHINI.                                         *  │");// 35
                Console.WriteLine("                           │                                                   -MATHEUS PRADO.                                                  │");// 36
                Console.WriteLine("                           │                        *                                                                                           │");// 37
                Console.WriteLine("                           │                                                                                                                    │");// 38
                Console.WriteLine("                           │                                                     - LIVRO ATA -                                                  │");// 39
                Console.WriteLine("                           │                                                                                                                    |");// 40
                Console.WriteLine("                           │                                                   -FABRÍCIO CRUZ                              VOLTAR = PRESSIONE V │");// 41
                Console.WriteLine("                           |────────────────────────────────────────────────────────────────────────────────────────────────────────────────────|");// 42


                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(115, 29);
                Console.WriteLine("██████████████");
                Console.SetCursorPosition(111, 30);
                Console.WriteLine("██████████████████████ ");
                Console.SetCursorPosition(110, 31);
                Console.WriteLine("██         ███        ██");
                Console.SetCursorPosition(109, 32);
                Console.WriteLine("███         ███        ███");
                Console.SetCursorPosition(109, 33);
                Console.WriteLine("██████████████████████████");
                Console.SetCursorPosition(110, 34);
                Console.WriteLine("████████████████████████");
                Console.SetCursorPosition(112, 35);
                Console.WriteLine("████   █████   ████");
                Console.SetCursorPosition(109, 36);
                Console.WriteLine("███    ███     ███    ███");
                Console.SetCursorPosition(107, 37);
                Console.WriteLine("███      ███     ███      ███");

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(40, 12);
                Console.WriteLine("██             ██");
                Console.SetCursorPosition(42, 13);
                Console.WriteLine("██         ██");
                Console.SetCursorPosition(39, 14);
                Console.WriteLine("███████████████████");
                Console.SetCursorPosition(37, 15);
                Console.WriteLine("███████████████████████");
                Console.SetCursorPosition(35, 16);
                Console.WriteLine("████    ██████████    ████");
                Console.SetCursorPosition(33, 17);
                Console.WriteLine("██████████████████████████████");
                Console.SetCursorPosition(33, 18);
                Console.WriteLine("██   ████████████████████   ██");
                Console.SetCursorPosition(33, 19);
                Console.WriteLine("██   ██                ██   ██");
                Console.SetCursorPosition(40, 20);
                Console.WriteLine("████        ████");


                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(43, 2);
                Console.WriteLine("┌────────────────────────────────────────────────────────────────────────────────────┐");
                Console.SetCursorPosition(43, 3);
                Console.WriteLine("|   ██████   ███████     ████████  ████████    ██  ██████████   ███████    ████████  |");
                Console.SetCursorPosition(43, 4);
                Console.WriteLine("|  ██    ██  ██     ██  ██         ██      ██  ██      ██      ██     ██  ██         |");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(43, 5);
                Console.WriteLine("|  ██        ██     ██  ██████     ██      ██  ██      ██      ██     ██  █████████  |");
                Console.SetCursorPosition(43, 6);
                Console.WriteLine("|  ██    ██  ███████    ██         ██      ██  ██      ██      ██     ██         ██  |");
                Console.SetCursorPosition(43, 7);
                Console.WriteLine("|   ██████   ██     ██   ████████  ████████    ██      ██       ███████   ████████   |");
                Console.SetCursorPosition(43, 8);
                Console.WriteLine("└────────────────────────────────────────────────────────────────────────────────────┘");


                Console.SetCursorPosition(34, 41);
                tecla = Console.ReadKey();


            } while (tecla.Key != ConsoleKey.V);
            Console.Clear();




        }


        static public void telaPlay()

        {


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
            ConsoleKeyInfo tecla;



      

                Console.Clear();                                                                                           //  cada um dec cor diferente
                Console.WriteLine(" ESCOLHA SUA CATEGORIA     ┌──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");// 1
                Console.WriteLine(" PRESSIONANDO AS TECLAS    │                                                                                                                              │");// 2
                Console.WriteLine(" SOLICITADAS PARA O DEVIDO │ ───────────────────────                                                                                                      │");// 3
                Console.WriteLine(" DESAFIO.                  │ │                     │                                                                                                      │");// 4
                Console.WriteLine("     ESCOLHA SEU QUIZ      │ │        ████         │                                                                                                      │");// 5
                Console.WriteLine("                           │ │    ████████         │                                                                                                      │");// 6
                Console.WriteLine(" PARA BIOLOGIA,HITÓRIA E   │ │        ████         │                                                                                                      |");// 7
                Console.WriteLine(" PORTUGUES PRESSIONE- *A*  │ │        ████         │                                                                                                      │");// 8
                Console.WriteLine("                           │ │        ████         │                                                                                                      │");// 9
                Console.WriteLine(" PARA GEOGRAFIA,MATEMATICA │ │        ████         │                                                                                                      │");// 10
                Console.WriteLine(" E QUIMICA PRESSIONE- *B*  │ │        ████         │                                                                                                      │");// 11
                Console.WriteLine("                           │ │        ████         │                                                                                                      │");// 12
                Console.WriteLine(" PARA A PROGRAMAÇÃO PRESSI │ │   ███████████████   │                                                                                                      │");// 13
                Console.WriteLine(" ONE - *C*                 │ │                     │                                                                                                      │");// 14
                Console.WriteLine("                           │ ───────────────────────                                                                                                      │");// 15
                Console.WriteLine("                           │ ───────────────────────                                                                                                      │");// 16
                Console.WriteLine("                           │ │                     │                                                                                                      │");// 17
                Console.WriteLine("                           │ │   ███████████████   |                                                                                                      │");// 18
                Console.WriteLine("                           │ │  █████████████████  │                                                                                                      │");// 19
                Console.WriteLine("                           │ │              █████  │                                                                                                      │");// 20
                Console.WriteLine("                           │ │              █████  │                                                                                                      │");// 21
                Console.WriteLine("                           │ │              █████  │                                                                                                      │");// 22
                Console.WriteLine("                           │ │   ███████████████   │                                                                                                      │");// 23
                Console.WriteLine("                           │ │  █████              │                                                                                                      │");// 24
                Console.WriteLine("                           │ │  █████              │                                                                                                      │");// 25
                Console.WriteLine("                           │ │  █████████████████  │                                                                                                      │");// 26
                Console.WriteLine("                           │ │   ███████████████   │                                                                                                      │");// 27
                Console.WriteLine("                           │ ───────────────────────                                                                                                      |");// 28
                Console.WriteLine("                           │ ───────────────────────                                                                                                      │");// 29
                Console.WriteLine("                           │ │                     │                                                                                                      │");// 30
                Console.WriteLine("                           │ │  █████████████████  │                                                                                                      │");// 31
                Console.WriteLine("                           │ │ ███████████████████ │                                                                                                      │");// 32
                Console.WriteLine("                           │ │              ██████ │                                                                                                      │");// 33
                Console.WriteLine("                           │ │              ██████ │                                                                                                      │");// 34
                Console.WriteLine("                           │ │        ████████████ │                                                                                                      │");// 35
                Console.WriteLine("                           │ │        ████████████ │                                                                                                      │");// 36
                Console.WriteLine("                           │ │              ██████ │                                                                                                      │");// 37
                Console.WriteLine("                           │ │              ██████ |                                                                                                      │");// 38
                Console.WriteLine("                           │ │ ███████████████████ │                                                                                                      │");// 39
                Console.WriteLine("                           │ │  █████████████████  │                                                                                                      │");// 40
                Console.WriteLine("                           │ ───────────────────────                                                                                                      │");// 41
                Console.WriteLine("                           │                                                                                                                              │");// 42
                Console.WriteLine("                           |──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────|");// 43
                                                                                                                                                                                              
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(53, 29);
            Console.WriteLine("      ██████████        ████████████     █████████████       █████████████      █████████          ");
            Console.SetCursorPosition(53, 30);
            Console.WriteLine("      ▀▀        ██      ▀▀        ██     ▀▀         ██       ██         ██      ▀▀     ██          ");
            Console.SetCursorPosition(53, 31);
            Console.WriteLine("████████        ██   ██████       ██ ████████       ██ ██    ██    ██   ██ ████████    ██   ██████ ");
            Console.SetCursorPosition(53, 32);
            Console.WriteLine("██      ██      ██ ██      ██        ██      ██     ██ ████  ▀▀  ████   ██ ██   ▄▄     ██ ██      ██");
            Console.SetCursorPosition(53, 33);
            Console.WriteLine("██      ██      ██ ██      ██        ██      ██     ██ ██  ██  ██  ██   ██ ██   ██     ██ ██      ██");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(53, 34);
            Console.WriteLine("████████        ██ ██      ██        ██      ██ ██████ ██    ██    ██   ██ ██   ██     ██ ██      ██");
            Console.SetCursorPosition(53, 35);
            Console.WriteLine("██    ▄▄      ██   ██      ██        ████████       ██ ██    ▄▄    ██   ██ ██   █████████ ██      ██");
            Console.SetCursorPosition(53, 36);
            Console.WriteLine("██    ███████      ██      ██        ██  ▄▄  ██     ██ ██    █████ ██ ████ ██   ██     ██ ██      ██");
            Console.SetCursorPosition(53, 37);
            Console.WriteLine("██    ███████      ██      ██        ██  ██  ██     ██ ██    █████ ██ ████ ██   ██     ██ ██      ██");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(53, 38);
            Console.WriteLine("██    ██     ██    ██      ██   ████ ██  ██   ██    ██ ██    ██    ██   ██ ██   ██     ██ ██      ██");
            Console.SetCursorPosition(53, 39);
            Console.WriteLine("██    ██       ██  ██      ██     ██ ██  ██   ██    ██ ██    ██    ██   ██ ██   ▀▀     ██ ██      ██");
            Console.SetCursorPosition(53, 40);
            Console.WriteLine("██    ██       ██    ██████       ██ ██  ██    ██   ██ ██    ██    ██   ██ ████████    ██   ██████  ");
            Console.SetCursorPosition(53, 41);
            Console.WriteLine("                         ███████████                                                                ");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(53, 17);
            Console.WriteLine("████████████             ██████████");
            Console.SetCursorPosition(53, 18);
            Console.WriteLine("██        ██  ██████████ ██      ██");
            Console.SetCursorPosition(53, 19);
            Console.WriteLine("██            ██         ██      ██");
            Console.SetCursorPosition(53, 20);
            Console.WriteLine("██            ██         ██      ██");
            Console.SetCursorPosition(53, 21);
            Console.WriteLine("██            ██         ██      ██");
            Console.SetCursorPosition(53, 22);
            Console.WriteLine("██            ██████     ██      ██");
            Console.SetCursorPosition(53, 23);
            Console.WriteLine("██    ██████  ██         ██      ██");
            Console.SetCursorPosition(53, 24);
            Console.WriteLine("██        ██  ██         ██      ██");
            Console.SetCursorPosition(53, 25);
            Console.WriteLine("██        ██  ██         ██      ██");
            Console.SetCursorPosition(53, 26);
            Console.WriteLine("████████████  ██████████ ██████████");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(88, 16);
            Console.WriteLine("|");
            Console.SetCursorPosition(88, 17);
            Console.WriteLine("|");
            Console.SetCursorPosition(88, 18);
            Console.WriteLine("|");
            Console.SetCursorPosition(88, 19);
            Console.WriteLine("|");
            Console.SetCursorPosition(88, 20);
            Console.WriteLine("|");
            Console.SetCursorPosition(88, 21);
            Console.WriteLine("|");
            Console.SetCursorPosition(88, 22);
            Console.WriteLine("|");
            Console.SetCursorPosition(88, 23);
            Console.WriteLine("|");
            Console.SetCursorPosition(88, 24);
            Console.WriteLine("|");
            Console.SetCursorPosition(88, 25);
            Console.WriteLine("|");
            Console.SetCursorPosition(88, 26);
            Console.WriteLine("|");
            Console.SetCursorPosition(88, 27);
            Console.WriteLine("|");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(90, 16);
            Console.WriteLine("                     ████████████");
            Console.SetCursorPosition(90, 17);
            Console.WriteLine("                          ██     ");
            Console.SetCursorPosition(90, 18);
            Console.WriteLine("██          ██ ██████████ ██     ");
            Console.SetCursorPosition(90, 19);
            Console.WriteLine("████      ████ ██      ██ ██     ");
            Console.SetCursorPosition(90, 20);
            Console.WriteLine("██  ██  ██  ██ ██      ██ ██     ");
            Console.SetCursorPosition(90, 21);
            Console.WriteLine("██    ██    ██ ██      ██ ██     ");
            Console.SetCursorPosition(90, 22);
            Console.WriteLine("██          ██ ██      ██ ██     ");
            Console.SetCursorPosition(90, 23);
            Console.WriteLine("██          ██ ██████████ ██     ");
            Console.SetCursorPosition(90, 24);
            Console.WriteLine("██          ██ ██      ██ ██     ");
            Console.SetCursorPosition(90, 25);
            Console.WriteLine("██          ██ ██      ██ ██     ");
            Console.SetCursorPosition(90, 26);
            Console.WriteLine("██          ██ ██      ██ ██     ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(123, 16);
            Console.WriteLine("|");
            Console.SetCursorPosition(123, 17);
            Console.WriteLine("|");
            Console.SetCursorPosition(123, 18);
            Console.WriteLine("|");
            Console.SetCursorPosition(123, 19);
            Console.WriteLine("|");
            Console.SetCursorPosition(123, 20);
            Console.WriteLine("|");
            Console.SetCursorPosition(123, 21);
            Console.WriteLine("|");
            Console.SetCursorPosition(123, 22);
            Console.WriteLine("|");
            Console.SetCursorPosition(123, 23);
            Console.WriteLine("|");
            Console.SetCursorPosition(123, 24);
            Console.WriteLine("|");
            Console.SetCursorPosition(123, 25);
            Console.WriteLine("|");
            Console.SetCursorPosition(123, 26);
            Console.WriteLine("|");
            Console.SetCursorPosition(123, 27);
            Console.WriteLine("|");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(125, 17);
            Console.WriteLine("  ██████                     ");
            Console.SetCursorPosition(125, 18);
            Console.WriteLine("██      ██     ██      ██  ██");
            Console.SetCursorPosition(125, 19);
            Console.WriteLine("██      ██     ██      ██  ██");
            Console.SetCursorPosition(125, 20);
            Console.WriteLine("██      ██     ██      ██  ██");
            Console.SetCursorPosition(125, 21);
            Console.WriteLine("██      ██     ██      ██  ██");
            Console.SetCursorPosition(125, 22);
            Console.WriteLine("██      ██     ██      ██  ██");
            Console.SetCursorPosition(125, 23);
            Console.WriteLine("██      ██     ██      ██  ██");
            Console.SetCursorPosition(125, 24);
            Console.WriteLine("██      ██     ██      ██  ██");
            Console.SetCursorPosition(125, 25);
            Console.WriteLine("  ██████       ██      ██  ██");
            Console.SetCursorPosition(125, 26);
            Console.WriteLine("      ███████  ██████████  ██");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(53, 3);
            Console.WriteLine("                ██           ");
            Console.SetCursorPosition(53, 4);
            Console.WriteLine("███████████          ██████  ");
            Console.SetCursorPosition(53, 5);
            Console.WriteLine("████████████    ██ ██      ██");
            Console.SetCursorPosition(53, 6);
            Console.WriteLine("███         ███ ██ ██      ██");
            Console.SetCursorPosition(53, 7);
            Console.WriteLine("███         ███ ██ ██      ██");
            Console.SetCursorPosition(53, 8);
            Console.WriteLine("████████████    ██ ██      ██");
            Console.SetCursorPosition(53, 9);
            Console.WriteLine("████████████    ██ ██      ██");
            Console.SetCursorPosition(53, 10);
            Console.WriteLine("███         ███ ██ ██      ██");
            Console.SetCursorPosition(53, 11);
            Console.WriteLine("███         ███ ██ ██      ██");
            Console.SetCursorPosition(53, 12);
            Console.WriteLine("████████████    ██   ██████  ");
            Console.SetCursorPosition(53, 13);
            Console.WriteLine("██████████      ██           ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(82, 2);
            Console.WriteLine("|");
            Console.SetCursorPosition(82, 3);
            Console.WriteLine("|");
            Console.SetCursorPosition(82, 4);
            Console.WriteLine("|");
            Console.SetCursorPosition(82, 5);
            Console.WriteLine("|");
            Console.SetCursorPosition(82, 6);
            Console.WriteLine("|");
            Console.SetCursorPosition(82, 7);
            Console.WriteLine("|");
            Console.SetCursorPosition(82, 8);
            Console.WriteLine("|");
            Console.SetCursorPosition(82, 9);
            Console.WriteLine("|");
            Console.SetCursorPosition(82, 10);
            Console.WriteLine("|");
            Console.SetCursorPosition(82, 11);
            Console.WriteLine("|");
            Console.SetCursorPosition(82, 12);
            Console.WriteLine("|");
            Console.SetCursorPosition(82, 13);
            Console.WriteLine("|");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(83, 4);
            Console.WriteLine("██          ██  ██  ██████████");
            Console.SetCursorPosition(83, 5);
            Console.WriteLine("██          ██  ██  ███       ");
            Console.SetCursorPosition(83, 6);
            Console.WriteLine("██          ██  ██  ███       ");
            Console.SetCursorPosition(83, 7);
            Console.WriteLine("██          ██  ██  ███       ");
            Console.SetCursorPosition(83, 8);
            Console.WriteLine("██████████████  ██  ██████████");
            Console.SetCursorPosition(83, 9);
            Console.WriteLine("██          ██  ██         ███");
            Console.SetCursorPosition(83, 10);
            Console.WriteLine("██          ██  ██         ███");
            Console.SetCursorPosition(83, 11);
            Console.WriteLine("██          ██  ██         ███");
            Console.SetCursorPosition(83, 12);
            Console.WriteLine("██          ██  ██  ██████████");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(113, 2);
            Console.WriteLine("|");
            Console.SetCursorPosition(113, 3);
            Console.WriteLine("|");
            Console.SetCursorPosition(113, 4);
            Console.WriteLine("|");
            Console.SetCursorPosition(113, 5);
            Console.WriteLine("|");
            Console.SetCursorPosition(113, 6);
            Console.WriteLine("|");
            Console.SetCursorPosition(113, 7);
            Console.WriteLine("|");
            Console.SetCursorPosition(113, 8);
            Console.WriteLine("|");
            Console.SetCursorPosition(113, 9);
            Console.WriteLine("|");
            Console.SetCursorPosition(113, 10);
            Console.WriteLine("|");
            Console.SetCursorPosition(113, 11);
            Console.WriteLine("|");
            Console.SetCursorPosition(113, 12);
            Console.WriteLine("|");
            Console.SetCursorPosition(113, 13);
            Console.WriteLine("|");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(114, 2);
            Console.WriteLine("      ██████████        ███████████████ ");
            Console.SetCursorPosition(114, 3);
            Console.WriteLine("      ▀▀      ██              ███       ");
            Console.SetCursorPosition(114, 4);
            Console.WriteLine("████████      ██ ████████     ███       ");
            Console.SetCursorPosition(114, 5);
            Console.WriteLine("██      ██    ██ ██      ██   ███       ");
            Console.SetCursorPosition(114, 6);
            Console.WriteLine("██      ██    ██ ██      ██   ███       ");
            Console.SetCursorPosition(114, 7);
            Console.WriteLine("████████      ██ ██      ██   ███       ");
            Console.SetCursorPosition(114, 8);
            Console.WriteLine("██    ▄▄      ██ ████████     ███       ");
            Console.SetCursorPosition(114, 9);
            Console.WriteLine("██    ██      ██ ██      ██   ███       ");
            Console.SetCursorPosition(114, 10);
            Console.WriteLine("██    ██      ██ ██       ██  ███       ");
            Console.SetCursorPosition(114, 11);
            Console.WriteLine("██    ██      ██ ██       ██  ███       ");
            Console.SetCursorPosition(114, 12);
            Console.WriteLine("██    ██████████ ██        ██ ███       ");
            Console.SetCursorPosition(34, 13);
            tecla = Console.ReadKey();
            switch (tecla.Key)
                {
                    case ConsoleKey.A:
                        SegundoDesafio();
                        break;
                }

                switch (tecla.Key)
                {
                    case ConsoleKey.B:
                        PrimeiroDesafio();
                        break;
                }

                switch (tecla.Key)
                {
                    case ConsoleKey.C:
                        TerceiroDesafio();
                        break;
                }
            switch (tecla.Key)
            {
                case ConsoleKey.V:
                    telaMenu();
                    break;
            }



        }


        //______________________________________________________PRIMEIRA TELA PARA O PRIEMIRO QUIZ__________________________________________________________________________
        static public void PrimeiroDesafio()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.Black;
            ConsoleKeyInfo tecla;
               
                Console.Clear();                                                                              //degrade
                Console.WriteLine(" ESCOLHA SUA CATEGORIA     ┌────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");// 0
                Console.WriteLine(" PRESSIONANDO AS TECLAS    │                                                                                                                        │");// 1
                Console.WriteLine(" SOLICITADAS PARA O DEVIDO │  ───────────────────────                                                                                               │");// 2
                Console.WriteLine(" DESAFIO.                  │  │                     │                                                                                               │");// 3
                Console.WriteLine("     ESCOLHA SEU QUIZ      │  │      █████████      │                                                                                               │");// 4
                Console.WriteLine("                           │  │  ████         ████  │                                                                                               │");// 5
                Console.WriteLine(" PARA O QUIZ DE GEOGRAFIA  │  │  ████         ████  │                                                                                               │");// 6
                Console.WriteLine(" PRESSIONE - *A*           │  │  ████         ████  │                                                                                               │");// 7
                Console.WriteLine("                           │  │  ████         ████  │                                                                                               │");// 8
                Console.WriteLine(" PARA O QUIZ DE MATEMATICA │  │  █████████████████  │                                                                                               │");// 9
                Console.WriteLine(" PRESSIONE - *B*           │  │  █████████████████  │                                                                                               │");// 10
                Console.WriteLine("                           │  │  ████         ████  │                                                                                               │");// 11
                Console.WriteLine(" PARA O QUIZ DE QUIMICA    │  │  ████         ████  │                                                                                               │");// 12
                Console.WriteLine(" PRESSIONE - *C*           │  │                     │                                                                                               │");// 13
                Console.WriteLine("                           │  ───────────────────────                                                                                               │");// 14
                Console.WriteLine("                           │  ───────────────────────                                                                                               │");// 15
                Console.WriteLine("                           │  │                     │                                                                                               │");// 16
                Console.WriteLine("                           │  │ ████████████████    │                                                                                               │");// 17
                Console.WriteLine("                           │  │ ████████████████    │                                                                                               │");// 18
                Console.WriteLine("                           │  │ █████           ███ │                                                                                               │");// 19
                Console.WriteLine("                           │  │ █████           ███ │                                                                                               │");// 20
                Console.WriteLine("                           │  │ ████████████████    │                                                                                               │");// 21
                Console.WriteLine("                           │  │ ████████████████    │                                                                                               │");// 22
                Console.WriteLine("                           │  │ █████           ███ │                                                                                               │");// 23
                Console.WriteLine("                           │  │ █████           ███ │                                                                                               │");// 24
                Console.WriteLine("                           │  │ ████████████████    │                                                                                               │");// 25
                Console.WriteLine("                           │  │ ████████████████    │                                                                                               │");// 26
                Console.WriteLine("                           │  ───────────────────────                                                                                               │");// 27
                Console.WriteLine("                           │  ───────────────────────                                                                                               │");// 28
                Console.WriteLine("                           │  │                     │                                                                                               │");// 29
                Console.WriteLine("                           │  │    █████████████    │                                                                                               │");// 30
                Console.WriteLine("                           │  │ ███             ███ │                                                                                               │");// 31
                Console.WriteLine("                           │  │ ███             ███ │                                                                                               │");// 32
                Console.WriteLine("                           │  │ ███                 │                                                                                               |");// 33
                Console.WriteLine("                           │  │ ███                 │                                                                                               │");// 34
                Console.WriteLine("                           │  │ ███                 │                                                                                               │");// 35
                Console.WriteLine("                           │  │ ███             ███ │                                                                                               │");// 36
                Console.WriteLine("                           │  │ ███             ███ │                                                                                               │");// 37
                Console.WriteLine("                           │  │    █████████████    │                                                                                               │");// 38
                Console.WriteLine("                           │  │                     │                                                                                               │");// 39
                Console.WriteLine("                           │  ───────────────────────                                                                                               │");// 40
                Console.WriteLine("                           |────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────|");// 41
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(54, 3);
            Console.WriteLine("                                                                  ███████████  ██            "); 
            Console.SetCursorPosition(54, 4);
            Console.WriteLine("████████████             ██████████ ████████████                  ██                          ");
            Console.SetCursorPosition(54, 5);
            Console.WriteLine("██        ██  ██████████ ██      ██ ██        ██ ████████     ████████████     ██  ██████████ ");
            Console.SetCursorPosition(54, 6);
            Console.WriteLine("██            ██         ██      ██ ██           ██      ██   ██  ██    ██     ██  ██      ██");
            Console.SetCursorPosition(54, 7);
            Console.WriteLine("██            ██         ██      ██ ██           ██      ██   ██  ███████████  ██  ██      ██ ");
            Console.SetCursorPosition(54, 8);
            Console.WriteLine("██            ██         ██      ██ ██           ██      ██   ██  ██    ██     ██  ██      ██");
            Console.SetCursorPosition(54, 9);
            Console.WriteLine("██            ██████     ██      ██ ██           ████████     ██  ██    ██     ██  ██      ██");
            Console.SetCursorPosition(54, 10);
            Console.WriteLine("██    ██████  ██         ██      ██ ██    ██████ ██      ██   ████████████     ██  ██████████ ");
            Console.SetCursorPosition(54, 11);
            Console.WriteLine("██        ██  ██         ██      ██ ██        ██ ██       ██  ██  ██    ██     ██  ██      ██ ");
            Console.SetCursorPosition(54, 12);
            Console.WriteLine("██        ██  ██         ██      ██ ██        ██ ██       ██  ██  ██    ██     ██  ██      ██ ");
            Console.SetCursorPosition(54, 13);
            Console.WriteLine("████████████  ██████████ ██████████ ████████████ ██        ██ ██  ██    ██     ██  ██      ██ ");


            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(54, 15);    
            Console.WriteLine("                   ████████████████                        ████████████████                  ");
            Console.SetCursorPosition(54, 16);
            Console.WriteLine("                          ██                                      ██                         ");
            Console.SetCursorPosition(54, 17);
            Console.WriteLine("██          ██ ██████████ ██ ██████████ ██          ██ ██████████ ██  ██ ████████  ██████████");
            Console.SetCursorPosition(54, 18);
            Console.WriteLine("████      ████ ██      ██ ██ ██         ████      ████ ██      ██ ██  ██ ██        ██      ██");
            Console.SetCursorPosition(54, 19);
            Console.WriteLine("██  ██  ██  ██ ██      ██ ██ ██         ██  ██  ██  ██ ██      ██ ██  ██ ██        ██      ██");
            Console.SetCursorPosition(54, 20);
            Console.WriteLine("██    ██    ██ ██      ██ ██ ██         ██    ██    ██ ██      ██ ██  ██ ██        ██      ██");
            Console.SetCursorPosition(54, 21);
            Console.WriteLine("██          ██ ██      ██ ██ ██████     ██          ██ ██      ██ ██  ██ ██        ██      ██");
            Console.SetCursorPosition(54, 22);
            Console.WriteLine("██          ██ ██████████ ██ ██         ██          ██ ██████████ ██  ██ ██        ██████████");
            Console.SetCursorPosition(54, 23);
            Console.WriteLine("██          ██ ██      ██ ██ ██         ██          ██ ██      ██ ██  ██ ██        ██      ██");
            Console.SetCursorPosition(54, 24);
            Console.WriteLine("██          ██ ██      ██ ██ ██         ██          ██ ██      ██ ██  ██ ██        ██      ██");
            Console.SetCursorPosition(54, 25);
            Console.WriteLine("██          ██ ██      ██ ██ ██████████ ██          ██ ██      ██ ██  ██ ████████  ██      ██");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(54, 29);
            Console.WriteLine("  ██████                                                                         ");
            Console.SetCursorPosition(54, 30);
            Console.WriteLine("██      ██     ██      ██  ██  ██          ██  ██  ████████  ██████████                  ");
            Console.SetCursorPosition(54, 31);
            Console.WriteLine("██      ██     ██      ██  ██  ████      ████  ██  ██        ██      ██                ");
            Console.SetCursorPosition(54, 32);
            Console.WriteLine("██      ██     ██      ██  ██  ██  ██  ██  ██  ██  ██        ██      ██  ");
            Console.SetCursorPosition(54, 33);
            Console.WriteLine("██      ██     ██      ██  ██  ██    ██    ██  ██  ██        ██      ██   ");
            Console.SetCursorPosition(54, 34);
            Console.WriteLine("██      ██     ██      ██  ██  ██          ██  ██  ██        ██      ██      ");
            Console.SetCursorPosition(54, 35);
            Console.WriteLine("██      ██     ██      ██  ██  ██          ██  ██  ██        ██████████      ");
            Console.SetCursorPosition(54, 36);
            Console.WriteLine("██      ██     ██      ██  ██  ██          ██  ██  ██        ██      ██                 ");
            Console.SetCursorPosition(54, 37);
            Console.WriteLine("██      ██     ██      ██  ██  ██          ██  ██  ██        ██      ██    ");
            Console.SetCursorPosition(54, 38);
            Console.WriteLine("  ██████       ██      ██  ██  ██          ██  ██  ██        ██      ██     ");
            Console.SetCursorPosition(54, 39);
            Console.WriteLine("      ███████  ██████████  ██  ██          ██  ██  ████████  ██      ██      ");


            Console.SetCursorPosition(34, 41);
                tecla = Console.ReadKey();

                switch (tecla.Key)
                {
                    case ConsoleKey.A:
                        GeoFase();
                        break;
                }


                switch (tecla.Key)
                {
                    case ConsoleKey.B:
                        MatFase();
                        break;
                }


                switch (tecla.Key)
                {
                    case ConsoleKey.C:
                        QuiFase();
                        break;
                }



                switch (tecla.Key)
                {
                    case ConsoleKey.V:
                        telaPlay();
                        break;
                }


            }//______________________________________________________segundaa TELA PARA O segundo QUIZ__________________________________________________________________________
        static public void SegundoDesafio()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
            ConsoleKeyInfo tecla;

                Console.Clear();                                                                        //degrade
                Console.WriteLine(" ESCOLHA SUA CATEGORIA     ┌────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");// 1
                Console.WriteLine(" PRESSIONANDO AS TECLAS    │                                                                                                                    │");// 2
                Console.WriteLine(" SOLICITADAS PARA O DEVIDO │───────────────────────                                                                                             │");// 3
                Console.WriteLine(" DESAFIO.                  ││                     │                                                                                             │");// 4
                Console.WriteLine("     ESCOLHA SEU QUIZ      ││      █████████      │                                                                                             │");// 5
                Console.WriteLine("                           ││  ████         ████  │                                                                                             │");// 6
                Console.WriteLine(" PARA O QUIZ DE BIOLOGIA   ││  ████         ████  │                                                                                             │");// 7
                Console.WriteLine(" PRESSIONE - *A*           ││  ████         ████  │                                                                                             │");// 8
                Console.WriteLine("                           ││  ████         ████  │                                                                                             │");// 9
                Console.WriteLine(" PARA O QUIZ DE HISTORIA   ││  █████████████████  │                                                                                             │");// 10
                Console.WriteLine(" PRESSIONE - *B*           ││  █████████████████  │                                                                                             │");// 11
                Console.WriteLine("                           ││  ████         ████  │                                                                                             │");// 12
                Console.WriteLine(" PARA O QUIZ DE PORTUGUÊS  ││  ████         ████  │                                                                                             │");// 13
                Console.WriteLine(" PRESSIONE - *C*           ││                     │                                                                                             │");// 14
                Console.WriteLine("                           │───────────────────────                                                                                             │");// 15
                Console.WriteLine("                           │───────────────────────                                                                                             │");// 16
                Console.WriteLine("                           ││                     │                                                                                             │");// 17
                Console.WriteLine("                           ││ ████████████████    |                                                                                             │");// 18
                Console.WriteLine("                           ││ ████████████████    │                                                                                             │");// 19
                Console.WriteLine("                           ││ █████           ███ │                                                                                             │");// 20
                Console.WriteLine("                           ││ █████           ███ │                                                                                             │");// 21
                Console.WriteLine("                           ││ ████████████████    │                                                                                             │");// 22
                Console.WriteLine("                           ││ ████████████████    │                                                                                             │");// 23
                Console.WriteLine("                           ││ █████           ███ │                                                                                             │");// 24
                Console.WriteLine("                           ││ █████           ███ │                                                                                             │");// 26
                Console.WriteLine("                           ││ ████████████████    │                                                                                             │");// 27
                Console.WriteLine("                           ││ ████████████████    │                                                                                             │");// 28
                Console.WriteLine("                           │───────────────────────                                                                                             │");// 29
                Console.WriteLine("                           │───────────────────────                                                                                             │");// 30
                Console.WriteLine("                           ││                     │                                                                                             │");// 31
                Console.WriteLine("                           ││    █████████████    │                                                                                             │");// 32
                Console.WriteLine("                           ││ ███             ███ │                                                                                             │");// 33
                Console.WriteLine("                           ││ ███             ███ │                                                                                             │");// 34
                Console.WriteLine("                           ││ ███                 │                                                                                             |");// 35
                Console.WriteLine("                           ││ ███                 │                                                                                             │");// 36
                Console.WriteLine("                           ││ ███                 │                                                                                             │");// 37
                Console.WriteLine("                           ││ ███             ███ │                                                                                             │");// 38
                Console.WriteLine("                           ││ ███             ███ │                                                                                             │");// 39
                Console.WriteLine("                           ││    █████████████    │                                                                                             │");// 40
                Console.WriteLine("                           ││                     │                                                                                             │");// 41
                Console.WriteLine("                           │───────────────────────                                                                                             │");// 42
                Console.WriteLine("                           |────────────────────────────────────────────────────────────────────────────────────────────────────────────────────|");// 43
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.SetCursorPosition(53, 3);
                Console.WriteLine("                 ██                                                 ██              ");
                Console.SetCursorPosition(53, 4);
                Console.WriteLine("███████████          ██████████ ██         ██████████ ████████████      ████████████");
                Console.SetCursorPosition(53, 5);
                Console.WriteLine("████████████     ██  ██      ██ ██         ██      ██ ██        ██  ██  ██        ██");
                Console.SetCursorPosition(53, 6);
                Console.WriteLine("███         ███  ██  ██      ██ ██         ██      ██ ██            ██  ██        ██");
                Console.SetCursorPosition(53, 7);
                Console.WriteLine("███         ███  ██  ██      ██ ██         ██      ██ ██            ██  ██        ██");
                Console.SetCursorPosition(53, 8);
                Console.WriteLine("████████████     ██  ██      ██ ██         ██      ██ ██            ██  ██        ██");
                Console.SetCursorPosition(53, 9);
                Console.WriteLine("████████████     ██  ██      ██ ██         ██      ██ ██            ██  ████████████");
                Console.SetCursorPosition(53, 10);
                Console.WriteLine("███         ███  ██  ██      ██ ██         ██      ██ ██    ██████  ██  ██        ██");
                Console.SetCursorPosition(53, 11);
                Console.WriteLine("███         ███  ██  ██      ██ ██         ██      ██ ██        ██  ██  ██        ██");
                Console.SetCursorPosition(53, 12);
                Console.WriteLine("████████████     ██  ██      ██ ██         ██      ██ ██        ██  ██  ██        ██");
                Console.SetCursorPosition(53, 13);
                Console.WriteLine("██████████       ██  ██████████ ██████████ ██████████ ████████████  ██  ██        ██");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.SetCursorPosition(53, 16);
                Console.WriteLine("██          ██  ██  ██████████  ███████████████  ██████████  ████████      ██  ██████████");
                Console.SetCursorPosition(53, 17);
                Console.WriteLine("██          ██  ██  ███               ███        ██      ██  ██      ██    ██  ██      ██");
                Console.SetCursorPosition(53, 18);
                Console.WriteLine("██          ██  ██  ███               ███        ██      ██  ██      ██    ██  ██      ██");
                Console.SetCursorPosition(53, 19);
                Console.WriteLine("██          ██  ██  ███               ███        ██      ██  ██      ██    ██  ██      ██");
                Console.SetCursorPosition(53, 20);
                Console.WriteLine("██████████████  ██  ██████████        ███        ██      ██  ████████      ██  ██      ██");
                Console.SetCursorPosition(53, 21);
                Console.WriteLine("██          ██  ██         ███        ███        ██      ██  ██      ██    ██  ██████████");
                Console.SetCursorPosition(53, 22);
                Console.WriteLine("██          ██  ██         ███        ███        ██      ██  ██       ██   ██  ██      ██");
                Console.SetCursorPosition(53, 23);
                Console.WriteLine("██          ██  ██         ███        ███        ██      ██  ██       ██   ██  ██      ██");
                Console.SetCursorPosition(53, 24);
                Console.WriteLine("██          ██  ██  ██████████        ███        ██████████  ██        ██  ██  ██      ██");

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(52, 28);
                Console.WriteLine("      ██████████        ███████████████                              ███████               ");
                Console.SetCursorPosition(52, 29);
                Console.WriteLine("      ▀▀      ██              ███                                                          ");
                Console.SetCursorPosition(52, 30);
                Console.WriteLine("████████      ██ ████████     ███  ██      ██ ██████████ ██      ██ ██████████   █████████ ");
                Console.SetCursorPosition(52, 31);
                Console.WriteLine("██      ██    ██ ██      ██   ███  ██      ██ ██      ██ ██      ██ ██          ███        ");
                Console.SetCursorPosition(52, 32);
                Console.WriteLine("██      ██    ██ ██      ██   ███  ██      ██ ██         ██      ██ ██          ███        ");
                Console.SetCursorPosition(52, 33);
                Console.WriteLine("████████      ██ ██      ██   ███  ██      ██ ██         ██      ██ ██          ███        ");
                Console.SetCursorPosition(52, 34);
                Console.WriteLine("██    ▄▄      ██ ████████     ███  ██      ██ ██         ██      ██ ██████      ██████████ ");
                Console.SetCursorPosition(52, 35);
                Console.WriteLine("██    ██      ██ ██      ██   ███  ██      ██ ██         ██      ██ ██                 ███ ");
                Console.SetCursorPosition(52, 36);
                Console.WriteLine("██    ██      ██ ██       ██  ███  ██      ██ ██  ██████ ██      ██ ██                 ███ ");
                Console.SetCursorPosition(52, 37);
                Console.WriteLine("██    ██      ██ ██       ██  ███  ██      ██ ██      ██ ██      ██ ██                 ███ ");
                Console.SetCursorPosition(52, 38);
                Console.WriteLine("██    ██████████ ██        ██ ███  ██████████ ██████████ ██████████ ██████████  █████████  ");


                Console.SetCursorPosition(34, 41);
                tecla = Console.ReadKey();

                switch (tecla.Key)
                {
                    case ConsoleKey.A:
                        BioFase();
                        break;
                }


                switch (tecla.Key)
                {
                    case ConsoleKey.B:
                        HisFase();
                        break;
                }


                switch (tecla.Key)
                {
                    case ConsoleKey.C:
                        PortFase();
                        break;
                }


            switch (tecla.Key)
            {
                case ConsoleKey.V:
                    telaPlay();
                    break;
            }
        }
        //______________________________________________________terceira TELA PARA O terceira QUIZ__________________________________________________________________________
        static public void TerceiroDesafio()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
            ConsoleKeyInfo tecla;

                Console.Clear();
                Console.WriteLine(" ESCOLHA SUA CATEGORIA     ┌──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");// 1
                Console.WriteLine(" PRESSIONANDO AS TECLAS    │                                                                                                                      │");// 2
                Console.WriteLine(" SOLICITADAS PARA O DEVIDO │                                                                                                                      │");// 3
                Console.WriteLine(" DESAFIO.                  │                                                                                                                      │");// 4
                Console.WriteLine("     ESCOLHA SEU QUIZ      │                                                                                                                      │");// 5
                Console.WriteLine("                           │                                *                                                                                     │");// 6
                Console.WriteLine(" PARA O QUIZ DE GEOGRAFIA  │                                                                                                                      │");// 7
                Console.WriteLine(" PRESSIONE - *A*           │                                                                                                                      │");// 8
                Console.WriteLine("                           │                                                                                                                      │");// 9
                Console.WriteLine(" PARA O QUIZ DE MATEMATICA │                                                                                                 *                    │");// 10
                Console.WriteLine(" PRESSIONE - *B*           │                                          *                                                                           │");// 11
                Console.WriteLine("                           │                                                                                                                      │");// 12
                Console.WriteLine(" PARA O QUIZ DE PROGRAMAÇÃO│                                                                                                                      │");// 13
                Console.WriteLine(" PRESSIONE - *C*           │                                                                                                                      │");// 14
                Console.WriteLine("                           │                                                                                                                      │");// 15
                Console.WriteLine("                           │─────────────────                                                                                                     │");// 16
                Console.WriteLine("                           ││               │                                                                                                     │");// 17
                Console.WriteLine("                           ││    ███████    │                                                                                                     |");// 18
                Console.WriteLine("                           ││  ██       ██  │                                                                                                     │");// 19
                Console.WriteLine("                           ││  ██       ██  │                                                                                                     │");// 20
                Console.WriteLine("                           ││  ██       ██  │                                                                                                     │");// 21
                Console.WriteLine("                           ││  ██       ██  │                                                                                                     │");// 22
                Console.WriteLine("                           ││  ███████████  │                                                                                                     │");// 23
                Console.WriteLine("                           ││  ███████████  │                                                                                                     │");// 24
                Console.WriteLine("                           ││  ██       ██  │                                                                                                     │");// 26
                Console.WriteLine("                           ││  ██       ██  │                                                                                                     │");// 27
                Console.WriteLine("                           ││               │                                                                                                     │");// 28
                Console.WriteLine("                           │─────────────────                                                                                                     │");// 29
                Console.WriteLine("                           │                                                                                                                      │");// 30
                Console.WriteLine("                           │                                                                                                                      │");// 31
                Console.WriteLine("                           │                                                                                                                      │");// 32
                Console.WriteLine("                           │                                                                                                                      │");// 33
                Console.WriteLine("                           │                                                                                                                      │");// 34
                Console.WriteLine("                           │                                                                                                                      |");// 35
                Console.WriteLine("                           │                                                                                                                      │");// 36
                Console.WriteLine("                           │                                                                                                                      │");// 37
                Console.WriteLine("                           │                                                                                                                      │");// 38
                Console.WriteLine("                           │                                                                                                                      │");// 39
                Console.WriteLine("                           │                                           *                                                                          │");// 40
                Console.WriteLine("                           │                                                                                                      *               │");// 41
                Console.WriteLine("                           │                                                                                                                      │");// 42
                Console.WriteLine("                           |──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────|");// 43


                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.SetCursorPosition(46, 13);
                Console.WriteLine("                                                                              █████████████        ");
                Console.SetCursorPosition(46, 15);
                Console.WriteLine("      ██████████        ████████████     █████████████       █████████████      █████████          ");
                Console.SetCursorPosition(46, 16);
                Console.WriteLine("      ▀▀        ██      ▀▀        ██     ▀▀         ██       ██         ██      ▀▀     ██          ");
                Console.SetCursorPosition(46, 17);
                Console.WriteLine("████████        ██   ██████       ██ ████████       ██ ██    ██    ██   ██ ████████    ██   ██████ ");
                Console.SetCursorPosition(46, 18);
                Console.WriteLine("██      ██      ██ ██      ██        ██      ██     ██ ████  ▀▀  ████   ██ ██   ▄▄     ██ ██      ██");
                Console.SetCursorPosition(46, 19);
                Console.WriteLine("██      ██      ██ ██      ██        ██      ██     ██ ██  ██  ██  ██   ██ ██   ██     ██ ██      ██");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(46, 20);
                Console.WriteLine("████████        ██ ██      ██        ██      ██ ██████ ██    ██    ██   ██ ██   ██     ██ ██      ██");
                Console.SetCursorPosition(46, 21);
                Console.WriteLine("██    ▄▄      ██   ██      ██        ████████       ██ ██    ▄▄    ██   ██ ██   █████████ ██      ██");
                Console.SetCursorPosition(46, 22);
                Console.WriteLine("██    ███████      ██      ██        ██  ▄▄  ██     ██ ██    █████ ██ ████ ██   ██     ██ ██      ██");
                Console.SetCursorPosition(46, 23);
                Console.WriteLine("██    ███████      ██      ██        ██  ██  ██     ██ ██    █████ ██ ████ ██   ██     ██ ██      ██");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(46, 24);
                Console.WriteLine("██    ██     ██    ██      ██   ████ ██  ██   ██    ██ ██    ██    ██   ██ ██   ██     ██ ██      ██");
                Console.SetCursorPosition(46, 25);
                Console.WriteLine("██    ██       ██  ██      ██     ██ ██  ██   ██    ██ ██    ██    ██   ██ ██   ▀▀     ██ ██      ██");
                Console.SetCursorPosition(46, 26);
                Console.WriteLine("██    ██       ██    ██████       ██ ██  ██    ██   ██ ██    ██    ██   ██ ████████    ██   ██████  ");
                Console.SetCursorPosition(46, 27);
                Console.WriteLine("                         ███████████                                                                ");
                Console.SetCursorPosition(47, 28);
                tecla = Console.ReadKey();

                switch (tecla.Key)
                {
                    case ConsoleKey.A:
                        ProgFase();
                        break;
                }

                switch (tecla.Key)
                {
                    case ConsoleKey.V:
                        telaPlay();
                        break;
                }

            }
        static public void telaInstrucoes()

        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
            ConsoleKeyInfo tecla;

            do
            {
                Console.Clear();
                Console.WriteLine("                           ┌────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");// 1
                Console.WriteLine("                           │                                                                                                                    │");// 2
                Console.WriteLine("                           │                                                                                                                    │");// 3
                Console.WriteLine("                           │                                                                                                                    │");// 4
                Console.WriteLine("                           │                                                                                                                    │");// 5
                Console.WriteLine("                           │                                                                                                                    │");// 6
                Console.WriteLine("                           │                                                                                                                    │");// 7
                Console.WriteLine("                           │                                                                                                                    │");// 8
                Console.WriteLine("                           │                                                                                  *                                 │");// 9
                Console.WriteLine("                           │                                                 O QUE É SPACE WAR?                            *                    │");// 10
                Console.WriteLine("                           │                *                                                                                                   │");// 11
                Console.WriteLine("                           │                                                                                                                    │");// 12
                Console.WriteLine("                           │                      SPACE WARS É UM JOGO BASEADO NO FAMOSO JOGO 'GALAGA' PORÉM DIFERENCIADO EM                    │");// 13
                Console.WriteLine("                           │                      FORMATO DE QUIZ, COMO AS NAVES SENDO AS RESPOSTAS E OS ALIENS(INIMGOS) SENDO                  │");// 14
                Console.WriteLine("                           │                      AS PERGUNTAS, O JOGO É CONSTITUIDO POR 35 PERGUNTAS NO TOTAL SENDO ELAS DE                    │");// 15
                Console.WriteLine("                           │                      GEOGRAFIA, MATEMATICA, BIOLOGIA, PORTUGUES, HISTÓRIA, QUIMCA E PROGRAMAÇÃO,                   │");// 16
                Console.WriteLine("                           │                      TODAS EM PERGUNTAS GERAIS SEM ALGUM ASSUNTO ESPECÍFCO DA DISCIPLINA                           │");// 17
                Console.WriteLine("                           │                      ESCOLHIDA PELO JOGADOR, E PROGRAMÇÃO COM TEMA DO PROGRAMA 'VISUAL STUDIO'.                    │");// 18
                Console.WriteLine("                           │                                                                                                                    │");// 19
                Console.WriteLine("                           │                                                                                                                    │");// 20
                Console.WriteLine("                           │                                                                                                                    │");// 21
                Console.WriteLine("                           │                                                                                                                    │");// 22
                Console.WriteLine("                           │                                                 COMO JOGAR?                                                        │");// 23
                Console.WriteLine("                           │                                                                                                                    │");// 24
                Console.WriteLine("                           │                      SELECIONE AS ALTERNATIVA CORRETAS (A,B,C OU D) PARA RESPONDER AS PERGUNTAS                    │");// 25
                Console.WriteLine("                           │                      CORRETAS, SE O JOGADOR ERRAR ELE DEVE APERTAR A TECLA (V)PARA VOLTAR A TELA                   │");// 26
                Console.WriteLine("                           │                      INICIAL E COMECAR O JOGO NOVAMENTE , SEU OBJETIVO PRICINPAL SERIAL REESPONDER E               │");// 27
                Console.WriteLine("                           │                      ACERTAR TODAS ASS PERGUNTAS DADAS, OU SEJA, ACERTAR AS CATEGORIAS 1, 2 E 3. AO                │");// 28
                Console.WriteLine("                           │                      RESPONDER TODAS CORRETAS ELE ENTRARÁ EM UMA TELA PARABENIZANDO-O E                            │");// 29
                Console.WriteLine("                           │                      GANHARÁ O JOGO POR INTEIRO, PORÉM SE ERRAR ENTRARÁ EM UMA TELA COM A                          │");// 30
                Console.WriteLine("                           │                      SEGUINTE FRASE ' VOCÊ FALHOU ', PERDENDO O JOGO.                                              │");// 31
                Console.WriteLine("                           │                                                                                                                    │");// 32
                Console.WriteLine("                           │                                                                                                                    │");// 33
                Console.WriteLine("                           │                                                                                                                    │");// 34
                Console.WriteLine("                           │                                                                                                                    │");// 35
                Console.WriteLine("                           │      *                                                                       *                                     │");// 36
                Console.WriteLine("                           │                                                                                                                    │");// 37
                Console.WriteLine("                           │                        *                                                                                           │");// 38
                Console.WriteLine("                           │                                                                                                                    │");// 39
                Console.WriteLine("                           │                                                         *                                                          │");// 40
                Console.WriteLine("                           │      _                                                                                              *              │");// 41
                Console.WriteLine("                           │OPÇÃO|_|                                                                               VOLTAR = PRESSIONE V         │");// 42
                Console.WriteLine("                           |────────────────────────────────────────────────────────────────────────────────────────────────────────────────────|");// 43
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.SetCursorPosition(31, 2);
                Console.WriteLine(" ┌──────────────────────────────────────────────────────────────────────────────────────────────────────────┐ ");
                Console.SetCursorPosition(31, 3);
                Console.WriteLine(" |  ██   ███████    ████████  ██████████  ████████    ██    ██   ██████     ███████     ███████   ████████  | ");
                Console.SetCursorPosition(31, 4);
                Console.WriteLine(" |  ██   ██    ██  ██             ██      ██      ██  ██    ██  ██    ██   ██     ██  ██         ██         |  ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.SetCursorPosition(31, 5);
                Console.WriteLine(" |  ██   ██    ██  █████████      ██      ██      ██  ██    ██  ██         ██     ██  ███████    █████████  |  ");
                Console.SetCursorPosition(31, 6);
                Console.WriteLine(" |  ██   ██    ██         ██      ██      ████████    ██    ██  ██    ██   ██     ██  ██                ██  | ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(31, 7);
                Console.WriteLine(" |  ██   ██    ██  ████████       ██      ██      ██   ██████    ██████     ███████     ███████  ████████   | ");
                Console.SetCursorPosition(31, 8);
                Console.WriteLine(" └──────────────────────────────────────────────────────────────────────────────────────────────────────────┘ ");

                Console.SetCursorPosition(34, 41);
                tecla = Console.ReadKey();


            } while (tecla.Key != ConsoleKey.V);

            Console.Clear();
        }

        //static public void Tutorial()



            //Console.ForegroundColor = ConsoleColor.DarkGray;
           // Console.SetCursorPosition(50, 13);
            //Console.WriteLine("         ██████████████         ");
           //Console.SetCursorPosition(50, 14);
           // Console.WriteLine("     ██████████████████████    ");
          //  Console.SetCursorPosition(50, 15);
           // Console.WriteLine("    ██         ███        ██     ");
            //Console.SetCursorPosition(50, 16);
            //Console.WriteLine("   ███         ███        ███   ");
            //Console.SetCursorPosition(50, 17);
            //Console.WriteLine("   ██████████████████████████  ");
            //Console.SetCursorPosition(50, 18);
            //Console.WriteLine("    ████████████████████████   ");
            //Console.SetCursorPosition(50, 19);
            //Console.WriteLine("      ████   █████   ████      ");
            //Console.SetCursorPosition(50, 20);
           // Console.WriteLine("   ███    ███     ███    ███  ");
           // Console.SetCursorPosition(50, 21);
           // Console.WriteLine(" ███      ███     ███      ███ ");
           // Console.ReadKey();

           // Console.ForegroundColor = ConsoleColor.DarkGray;
          //  Console.SetCursorPosition(50, 23);
          //  Console.WriteLine("        ██             ██       ");
          //  Console.SetCursorPosition(50, 24);
          //  Console.WriteLine("          ██         ██         ");
           // Console.SetCursorPosition(50, 25);
           // Console.WriteLine("       ██████████████████        ");
           // Console.SetCursorPosition(50, 26);
           // Console.WriteLine("     ██████████████████████     ");
           // Console.SetCursorPosition(50, 27);
           // Console.WriteLine("   ████    ██████████    ████  ");
           // Console.SetCursorPosition(50, 28);
            //Console.WriteLine(" ██████████████████████████████ ");
            //Console.SetCursorPosition(50, 29);
            //Console.WriteLine(" ██   ████████████████████   ██");
            //Console.SetCursorPosition(50, 30);
            //Console.WriteLine(" ██   ██                ██   ██  ");
            //Console.SetCursorPosition(50, 31);
            //Console.WriteLine("        ████        ████        ");
            //Console.ReadKey();


        
        //tela de perdeu
        static public void Perdeu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
            ConsoleKeyInfo tecla;

       
                Console.Clear();
                Console.WriteLine(" ┌────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");// 1
                Console.WriteLine(" │                                                                                                                                                                    │");// 2
                Console.WriteLine(" │         ██      ██      ██████     ████████  ██████████          ███████████     ██████████    ██              ██          ██       ██████       ██      ██        │");// 3
                Console.WriteLine(" │         ██      ██    ██      ██   ██        ██                  ██              ██      ██    ██              ██          ██     ██      ██     ██      ██        │");// 4
                Console.WriteLine(" │         ██      ██    ██      ██   ██        ██                  ██              ██      ██    ██              ██          ██     ██      ██     ██      ██        │");// 5
                Console.WriteLine(" │          ██    ██     ██      ██   ██        ██                  ████████        ██      ██    ██              ██          ██     ██      ██     ██      ██        │");// 6
                Console.WriteLine(" │           ██  ██      ██      ██   ██        ██████              ██              ██      ██    ██              ██████████████     ██      ██     ██      ██        │");// 7
                Console.WriteLine(" │           ██  ██      ██      ██   ██        ██                  ██              ██████████    ██              ██          ██     ██      ██     ██      ██        │");// 8
                Console.WriteLine(" │            ████       ██      ██   ██        ██                  ██              ██      ██    ██              ██          ██     ██      ██     ██      ██        │");// 9
                Console.WriteLine(" │            ████       ██      ██   ██        ██                  ██              ██      ██    ██              ██          ██     ██      ██     ██      ██        │");// 10
                Console.WriteLine(" │             ██          ██████     ████████  ██████████          ██              ██      ██    ████████████    ██          ██       ██████         ██████          │");// 11
                Console.WriteLine(" │                                                                                                                                                                    │");// 12
                Console.WriteLine(" │                                                                                                                                                                    │");// 13
                Console.WriteLine(" │                                                                                                                                                                    │");// 14
                Console.WriteLine(" │                                                                          ██             ██                                                                         │");// 15
                Console.WriteLine(" │                                                                            ██         ██                                                                           │");// 16
                Console.WriteLine(" │                                                                          ██████████████████                                                                        │");// 17
                Console.WriteLine(" │                                                                        ██████████████████████                                                                      │");// 18
                Console.WriteLine(" │                                                                      ████    ██████████    ████                                                                    │");// 19
                Console.WriteLine(" │                                                                    ██████████████████████████████                                                                  │");// 20
                Console.WriteLine(" │                                                                    ██   ████████████████████   ██                                                                  │");// 21
                Console.WriteLine(" │                                                                    ██   ██                ██   ██                                                                  │");// 22
                Console.WriteLine(" │                                                                           ████    █    ████                                                                        │");// 23
                Console.WriteLine(" │                                                                                   █                                                                                │");// 24
                Console.WriteLine(" │                                                                                   █                                                                                │");// 25
                Console.WriteLine(" │                                                                                                                                                                    │");// 26
                Console.WriteLine(" │                                                                                                                                                                    │");// 27
                Console.WriteLine(" │                                                                                                                                                                    │");// 28
                Console.WriteLine(" │                                                                                   █                                                                                │");// 29
                Console.WriteLine(" │                                                                                   █                                                                                │");// 30
                Console.WriteLine(" │                                                                                   █                                                                                │");// 31
                Console.WriteLine(" │                                                                                                                                                                    │");// 32
                Console.WriteLine(" │                                                                           ██                    ██                                                                 │");// 33
                Console.WriteLine(" │                                                                                                                                                                    │");// 34
                Console.WriteLine(" │                                                                       ██         ██   █             █                                                              │");// 35
                Console.WriteLine(" │                                                                                █ ██      ██    █                                                                   │");// 36
                Console.WriteLine(" │                                                                               ████████                  ██                                                         │");// 37
                Console.WriteLine(" │                                                                 ██        █  █████  ███  █    ██                                                                   │");// 38
                Console.WriteLine(" │                                                                           █ ██  █████ ██ █                                                                         │");// 39
                Console.WriteLine(" │                                                                           ████████████████                                                                         │");// 40
                Console.WriteLine(" │                                                                            ██    ██                                                                                │");// 41
                Console.WriteLine(" │                                                                            ▀            ▀                                                                          │");// 42
                Console.WriteLine(" |────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────|");// 43
                Console.SetCursorPosition(34, 41);
                tecla = Console.ReadKey();
                switch (tecla.Key)
                {
                    case ConsoleKey.M:
                        telaPlay();
                        break;

                }

            }
        //tela de ganhou
        static public void Parabens()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
            ConsoleKeyInfo tecla;

         
                Console.Clear();
                Console.WriteLine(" ┌────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");// 1
                Console.WriteLine(" │                                                                                                                                                                    │");// 2
                Console.WriteLine(" │                                                                                                                                                                    │");// 3
                Console.WriteLine(" │                      ████████      ██████████    ████████       ██████████    ███████████     ██████████    ███           ██     █████████    ████████             │");// 4
                Console.WriteLine(" │                      ██      ██    ██      ██    ██      ██     ██      ██    ███        ██   ██            ████          ██    ███           ██    ██             │");// 5
                Console.WriteLine(" │                      ██      ██    ██      ██    ██      ██     ██      ██    ███        ███  ██            ██████        ██    ███           ██    ██             │");// 6
                Console.WriteLine(" │                      ████████      ██      ██    ██      ██     ██      ██    ███        ██   ██            ██    ██      ██    ███           ██    ██             │");// 7
                Console.WriteLine(" │                      ██            ██      ██    ████████       ██      ██    ███████████     ██████        ██      ██    ██    ██████████    ██    ██             │");// 8
                Console.WriteLine(" │                      ██            ██████████    ██      ██     ██████████    ███████████     ██            ██       ██   ██           ███     ██  ██              │");// 9
                Console.WriteLine(" │                      ██            ██      ██    ██       ██    ██      ██    ███        ██   ██            ██        ██████           ███      ████               │");// 10
                Console.WriteLine(" │                      ██            ██      ██    ██       ██    ██      ██    ███        ██   ██            ██          ████           ███                         │");// 11
                Console.WriteLine(" │                      ██            ██      ██    ██        ██   ██      ██    ███████████     ██████████    ██           ███    █████████       █▀▀▀█              │");// 12
                Console.WriteLine(" │                                                                                                                                                 █▄▄▄█              │");// 13
                Console.WriteLine(" │                                                                                                                                                                    │");// 14
                Console.WriteLine(" │                                                                          ██             ██                                                                         │");// 15
                Console.WriteLine(" │                                                                            ██         ██                                                                           │");// 16
                Console.WriteLine(" │                                                                         ██████████████████                                                                         │");// 17
                Console.WriteLine(" │                                                                       ██████████████████████                                                                       │");// 18
                Console.WriteLine(" │                                                                     ████    ██████████    ████                                                                     │");// 19
                Console.WriteLine(" │                                                                   ████████████████████████████     ██                                                              │");// 20
                Console.WriteLine(" │                                                                   ██   ████████████     ████   ██                                                                  │");// 21
                Console.WriteLine(" │                                                                    ██   ██                ██   ██                                                                  │");// 22
                Console.WriteLine(" │                                                                          ████        ██           ██                                                               │");// 23
                Console.WriteLine(" │                                                           ██                                 ██                ██                                                  │");// 24
                Console.WriteLine(" │                                                                   ██             █                                                                                 │");// 25
                Console.WriteLine(" │                                                                                  █      ██             ██                                                          │");// 26
                Console.WriteLine(" │                                                        ██                        █                                                                                 │");// 27
                Console.WriteLine(" │                                                                                                                                                                    │");// 28
                Console.WriteLine(" │                                                                                                                                                                    │");// 29
                Console.WriteLine(" │                                                                                  █                                                                                 │");// 30
                Console.WriteLine(" │                                                                                  █                                                                                 │");// 31
                Console.WriteLine(" │                                                                                  █                                                                                 │");// 32
                Console.WriteLine(" │                                                                                                                                                                    │");// 33
                Console.WriteLine(" │                                                                                                                                                                    │");// 34
                Console.WriteLine(" │                                                                                  ██                                                                                │");// 35
                Console.WriteLine(" │                                                                                ██████                                                                              │");// 36
                Console.WriteLine(" │                                                                               ████████                                                                             │");// 37
                Console.WriteLine(" │                                                                           █  ██████████  █                                                                         │");// 38
                Console.WriteLine(" │                                                                           █ ████████████ █                                                                         │");// 39
                Console.WriteLine(" │                                                                           ████████████████                                                                         │");// 40
                Console.WriteLine(" │                                                                            ██    ██    ██                                                                          │");// 41
                Console.WriteLine(" │                                                                            ▀            ▀                                                                          │");// 42
                Console.WriteLine(" |────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────|");// 43
                Console.SetCursorPosition(34, 41);
                tecla = Console.ReadKey();
                switch (tecla.Key)
                {
                    case ConsoleKey.M:
                        telaPlay();
                        break;

                }

           
        }



        // //programção da nave 
        // Console.ForegroundColor = ConsoleColor.DarkMagenta;
        // Console.Clear();
        // Console.SetCursorPosition(coluna, linha++);
        // Console.Write("           ");
        // Console.SetCursorPosition(coluna, linha++);
        // Console.Write("       ██");
        // Console.SetCursorPosition(coluna, linha++);
        // Console.Write("     ██████");
        // Console.SetCursorPosition(coluna, linha++);
        // Console.Write("    ████████    ");
        // Console.SetCursorPosition(coluna, linha++);
        // Console.Write("█  ██████████  █");
        // Console.SetCursorPosition(coluna, linha++);
        // Console.Write("█ ████████████ █");
        // Console.SetCursorPosition(coluna, linha++);
        // Console.Write("████████████████");
        // Console.SetCursorPosition(coluna, linha++);
        // Console.Write(" ██    ██    ██ ");
        // Console.SetCursorPosition(coluna, linha++);
        //    Console.Write(" ▀            ▀");


        // _______________________________________________QUIZ DE GEOGRAFIA______________________________________________________________________
        static public void GeoFase()
        {

            ConsoleKeyInfo tecla;

      
                Console.Clear();
                Console.WriteLine(" ┌────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");// 1
                Console.WriteLine(" │                                                                                                                                                                    │");// 2
                Console.WriteLine(" │                                                                                                                                                                    │");// 3
                Console.WriteLine(" │                                                                                                                                                                    │");// 4
                Console.WriteLine(" │                                                                                                                                                                    │");// 5
                Console.WriteLine(" │                                                                                                                                                                    │");// 6
                Console.WriteLine(" │                                                                                                                                                                    │");// 7
                Console.WriteLine(" │                                                                                                                                                                    │");// 8
                Console.WriteLine(" │                                                                                                                                                                    │");// 9
                Console.WriteLine(" │                                                                                                                                                                    │");// 10
                Console.WriteLine(" │                                                                                                                                                                    │");// 11
                Console.WriteLine(" │                                                                                                                                                                    │");// 12
                Console.WriteLine(" │                                                                                                                                                                    │");// 13
                Console.WriteLine(" │                                                                                                                                                                    │");// 14
                Console.WriteLine(" │                                                                                                                                                                    │");// 15
                Console.WriteLine(" │                                                                                                                                                                    │");// 16
                Console.WriteLine(" │                                                                                                                                                                    │");// 17
                Console.WriteLine(" │                                                                                                                                                                    │");// 18
                Console.WriteLine(" │                                                                                                                                                                    │");// 19
                Console.WriteLine(" │                                                                                                                                                                    │");// 20
                Console.WriteLine(" │                                                                                                                                                                    │");// 21
                Console.WriteLine(" │                                                                                                                                                                    │");// 22
                Console.WriteLine(" │                                                                                                                                                                    │");// 23
                Console.WriteLine(" │                                                                                                                                                                    │");// 24
                Console.WriteLine(" │                                                                                                                                                                    │");// 25
                Console.WriteLine(" │                                                                                                                                                                    │");// 26
                Console.WriteLine(" │                                                                                                                                                                    │");// 27
                Console.WriteLine(" │                                                                                                                                                                    │");// 28
                Console.WriteLine(" │                                                                                                                                                                    │");// 29
                Console.WriteLine(" │                                                                                                                                                                    │");// 30
                Console.WriteLine(" │                                                                                                                                                                    │");// 31
                Console.WriteLine(" │                                                                                                                                                                    │");// 32
                Console.WriteLine(" │                                                                                                                                                                    │");// 33
                Console.WriteLine(" │                                                                                                                                                                    │");// 34
                Console.WriteLine(" │                                                                                                                                                                    │");// 35
                Console.WriteLine(" │                                                                                                                                                                    │");// 36
                Console.WriteLine(" │                                                                                                                                                                    │");// 37
                Console.WriteLine(" │                                                                                                                                                                    │");// 38
                Console.WriteLine(" │                                                                                                                                                                    │");// 39
                Console.WriteLine(" │                                                                                                                                                                    │");// 40
                Console.WriteLine(" │                                                                                                                                                                    │");// 41
                Console.WriteLine(" │                                                                                                                                                                    │");// 42
                Console.WriteLine(" |────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────|");// 43


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(67, 3);
            Console.Write("      ██             ██        ");
            Console.SetCursorPosition(67, 4);
            Console.Write("        ██         ██          ");
            Console.SetCursorPosition(67, 5);
            Console.Write("      ██████████████████       ");
            Console.SetCursorPosition(67, 6);
            Console.Write("    ██████████████████████     ");
            Console.SetCursorPosition(67, 7);
            Console.Write("  ████    ██████████    ████   ");
            Console.SetCursorPosition(67, 8);
            Console.Write("██████████████████████████████ ");
            Console.SetCursorPosition(67, 9);
            Console.Write("██   ████████████████████   ██ ");
            Console.SetCursorPosition(67, 10);
            Console.Write("██   ██                ██   ██ ");
            Console.SetCursorPosition(67, 11);
            Console.Write("       ████        ████        ");


                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(42, 13);
                Console.Write("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
                Console.SetCursorPosition(42, 14);
                Console.Write("█      GEOGRAFIA : QUANTOS ESTADOS POSSUE O BRASIL?(EXCETO O DISTRITO FEDERAL)     █");
                Console.SetCursorPosition(42, 15);
                Console.Write("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");

            // opção A
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(12, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(12, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(12, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(12, 23);
            Console.Write("█  ██████████  █");  
            Console.SetCursorPosition(12, 24);
            Console.Write("█ ████████████ █");  
            Console.SetCursorPosition(12, 25);
            Console.Write("████████████████ "); 
            Console.SetCursorPosition(12, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(12, 27);
            Console.Write(" ▀            ▀ ");


            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(5, 29);
            Console.Write("——————————————————————————————");
            Console.SetCursorPosition(5, 30);
            Console.Write("|      POSSUE 21 ESTADOS     |");
            Console.SetCursorPosition(5, 31);
            Console.Write("——————————————————————————————");
            Console.SetCursorPosition(5, 32);
            Console.Write("              (A)             ");
            // opção B
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(45, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(45, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(45, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(45, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(45, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(45, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(45, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(45, 27);
            Console.Write(" ▀            ▀ ");

            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(38, 29);
                Console.Write("——————————————————————————————");
                Console.SetCursorPosition(38, 30);
                Console.Write("|      POSSUE 24 ESTADOS     |");
                Console.SetCursorPosition(38, 31);
                Console.Write("——————————————————————————————");
            Console.SetCursorPosition(38, 32);
            Console.Write("              (B)             ");
            // opção C
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(78, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(78, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(78, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(78, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(78, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(78, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(78, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(78, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(71, 29);
                Console.Write("——————————————————————————————");
                Console.SetCursorPosition(71, 30);
                Console.Write("|      POSSUE 27 ESTADOS     |");
                Console.SetCursorPosition(71, 31);
                Console.Write("——————————————————————————————");
            Console.SetCursorPosition(71, 32);
            Console.Write("              (C)             ");
            // opção D
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(109, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(109, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(109, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(109, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(109, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(109, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(109, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(109, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(102, 29);
                Console.Write("——————————————————————————————");
                Console.SetCursorPosition(102, 30);
                Console.Write("|      POSSUE 26 ESTADOS     |");
                Console.SetCursorPosition(102, 31);
                Console.Write("——————————————————————————————");
            Console.SetCursorPosition(102, 32);
            Console.Write("              (D)             ");
            // opção E
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(141, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(141, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(141, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(141, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(141, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(141, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(141, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(141, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(134, 29);
                Console.Write("——————————————————————————————");
                Console.SetCursorPosition(134, 30);
                Console.Write("|      POSSUE 30 ESTADOS     |");
                Console.SetCursorPosition(134, 31);
                Console.Write("——————————————————————————————");
                Console.SetCursorPosition(34, 41);
            Console.SetCursorPosition(134, 32);
            Console.Write("              (E)             ");
            tecla = Console.ReadKey();


                switch (tecla.Key)
                {
                    case ConsoleKey.A:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.B:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.C:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.D:
                        GeoFase2();
                        Console.Clear();

                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.E:
                        Perdeu();
                        break;

                }




        }

        // RESPOSTA É 26 OPCAO 4

        // SEGUNDA PERGUNTAAAA
        static public void GeoFase2()
        {


            ConsoleKeyInfo tecla;

                 Console.Clear();
                Console.WriteLine(" ┌────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");// 1
                Console.WriteLine(" │                                                                                                                                                                    │");// 2
                Console.WriteLine(" │                                                                                                                                                                    │");// 3
                Console.WriteLine(" │                                                                                                                                                                    │");// 4
                Console.WriteLine(" │                                                                                                                                                                    │");// 5
                Console.WriteLine(" │                                                                                                                                                                    │");// 6
                Console.WriteLine(" │                                                                                                                                                                    │");// 7
                Console.WriteLine(" │                                                                                                                                                                    │");// 8
                Console.WriteLine(" │                                                                                                                                                                    │");// 9
                Console.WriteLine(" │                                                                                                                                                                    │");// 10
                Console.WriteLine(" │                                                                                                                                                                    │");// 11
                Console.WriteLine(" │                                                                                                                                                                    │");// 12
                Console.WriteLine(" │                                                                                                                                                                    │");// 13
                Console.WriteLine(" │                                                                                                                                                                    │");// 14
                Console.WriteLine(" │                                                                                                                                                                    │");// 15
                Console.WriteLine(" │                                                                                                                                                                    │");// 16
                Console.WriteLine(" │                                                                                                                                                                    │");// 17
                Console.WriteLine(" │                                                                                                                                                                    │");// 18
                Console.WriteLine(" │                                                                                                                                                                    │");// 19
                Console.WriteLine(" │                                                                                                                                                                    │");// 20
                Console.WriteLine(" │                                                                                                                                                                    │");// 21
                Console.WriteLine(" │                                                                                                                                                                    │");// 22
                Console.WriteLine(" │                                                                                                                                                                    │");// 23
                Console.WriteLine(" │                                                                                                                                                                    │");// 24
                Console.WriteLine(" │                                                                                                                                                                    │");// 25
                Console.WriteLine(" │                                                                                                                                                                    │");// 26
                Console.WriteLine(" │                                                                                                                                                                    │");// 27
                Console.WriteLine(" │                                                                                                                                                                    │");// 28
                Console.WriteLine(" │                                                                                                                                                                    │");// 29
                Console.WriteLine(" │                                                                                                                                                                    │");// 30
                Console.WriteLine(" │                                                                                                                                                                    │");// 31
                Console.WriteLine(" │                                                                                                                                                                    │");// 32
                Console.WriteLine(" │                                                                                                                                                                    │");// 33
                Console.WriteLine(" │                                                                                                                                                                    │");// 34
                Console.WriteLine(" │                                                                                                                                                                    │");// 35
                Console.WriteLine(" │                                                                                                                                                                    │");// 36
                Console.WriteLine(" │                                                                                                                                                                    │");// 37
                Console.WriteLine(" │                                                                                                                                                                    │");// 38
                Console.WriteLine(" │                                                                                                                                                                    │");// 39
                Console.WriteLine(" │                                                                                                                                                                    │");// 40
                Console.WriteLine(" │                                                                                                                                                                    │");// 41
                Console.WriteLine(" │                                                                                                                                                                    │");// 42
                Console.WriteLine(" |────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────|");// 43
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(67, 3);
            Console.Write("      ██             ██        ");
            Console.SetCursorPosition(67, 4);
            Console.Write("        ██         ██          ");
            Console.SetCursorPosition(67, 5);
            Console.Write("      ██████████████████       ");
            Console.SetCursorPosition(67, 6);
            Console.Write("    ██████████████████████     ");
            Console.SetCursorPosition(67, 7);
            Console.Write("  ████    ██████████    ████   ");
            Console.SetCursorPosition(67, 8);
            Console.Write("██████████████████████████████ ");
            Console.SetCursorPosition(67, 9);
            Console.Write("██   ████████████████████   ██ ");
            Console.SetCursorPosition(67, 10);
            Console.Write("██   ██                ██   ██ ");
            Console.SetCursorPosition(67, 11);
            Console.Write("       ████        ████        ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(40, 13);
                Console.Write("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
                Console.SetCursorPosition(40, 14);
                Console.Write("█               QUAL DESSES PASÍSES MOSTRADO A BAIXO NÃO É EUROPEU?                █");
                Console.SetCursorPosition(40, 15);
                Console.Write("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(12, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(12, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(12, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(12, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(12, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(12, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(12, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(12, 27);
            Console.Write(" ▀            ▀ ");
            // opção A
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(5, 29);
                Console.Write("——————————————————————————————");
                Console.SetCursorPosition(5, 30);
                Console.Write("|         MACEDONIA          |");
                Console.SetCursorPosition(5, 31);
                Console.Write("——————————————————————————————");
            Console.SetCursorPosition(5, 32);
            Console.Write("              (A)             ");
            // opção B
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(45, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(45, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(45, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(45, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(45, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(45, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(45, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(45, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(38, 29);
                Console.Write("——————————————————————————————");
                Console.SetCursorPosition(38, 30);
                Console.Write("|           ESPANHA          |");
                Console.SetCursorPosition(38, 31);
                Console.Write("——————————————————————————————");
            Console.SetCursorPosition(38, 32);
            Console.Write("              (B)             ");
            // opção C
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(78, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(78, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(78, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(78, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(78, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(78, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(78, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(78, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(71, 29);
                Console.Write("——————————————————————————————");
                Console.SetCursorPosition(71, 30);
                Console.Write("|            GRÉCIA          |");
                Console.SetCursorPosition(71, 31);
                Console.Write("——————————————————————————————");
            Console.SetCursorPosition(71, 32);
            Console.Write("              (C)             ");
            // opção D
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(109, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(109, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(109, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(109, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(109, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(109, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(109, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(109, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(102, 29);
                Console.Write("——————————————————————————————");
                Console.SetCursorPosition(102, 30);
                Console.Write("|         CASAQUISTÃO        |");
                Console.SetCursorPosition(102, 31);
                Console.Write("——————————————————————————————");
            Console.SetCursorPosition(102, 32);
            Console.Write("              (D)             ");
            // opção E
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(141, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(141, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(141, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(141, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(141, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(141, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(141, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(141, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(134, 29);
                Console.Write("——————————————————————————————");
                Console.SetCursorPosition(134, 30);
                Console.Write("|          POLONIA           |");
                Console.SetCursorPosition(134, 31);
                Console.Write("——————————————————————————————");
                Console.SetCursorPosition(34, 41);
            Console.SetCursorPosition(134, 32);
            Console.Write("              (E)             ");
            tecla = Console.ReadKey();


                switch (tecla.Key)
                {
                    case ConsoleKey.A:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.B:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.C:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.D:
                        GeoFase3();

                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.E:
                        Perdeu();
                        break;

                }

       


        }
        // casaquistão

        // TERCEIRAAA PERGUNTAAAA
        static public void GeoFase3()
        {


            ConsoleKeyInfo tecla;


            Console.Clear();
            Console.WriteLine(" ┌────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");// 1
            Console.WriteLine(" │                                                                                                                                                                    │");// 2
            Console.WriteLine(" │                                                                                                                                                                    │");// 3
            Console.WriteLine(" │                                                                                                                                                                    │");// 4
            Console.WriteLine(" │                                                                                                                                                                    │");// 5
            Console.WriteLine(" │                                                                                                                                                                    │");// 6
            Console.WriteLine(" │                                                                                                                                                                    │");// 7
            Console.WriteLine(" │                                                                                                                                                                    │");// 8
            Console.WriteLine(" │                                                                                                                                                                    │");// 9
            Console.WriteLine(" │                                                                                                                                                                    │");// 10
            Console.WriteLine(" │                                                                                                                                                                    │");// 11
            Console.WriteLine(" │                                                                                                                                                                    │");// 12
            Console.WriteLine(" │                                                                                                                                                                    │");// 13
            Console.WriteLine(" │                                                                                                                                                                    │");// 14
            Console.WriteLine(" │                                                                                                                                                                    │");// 15
            Console.WriteLine(" │                                                                                                                                                                    │");// 16
            Console.WriteLine(" │                                                                                                                                                                    │");// 17
            Console.WriteLine(" │                                                                                                                                                                    │");// 18
            Console.WriteLine(" │                                                                                                                                                                    │");// 19
            Console.WriteLine(" │                                                                                                                                                                    │");// 20
            Console.WriteLine(" │                                                                                                                                                                    │");// 21
            Console.WriteLine(" │                                                                                                                                                                    │");// 22
            Console.WriteLine(" │                                                                                                                                                                    │");// 23
            Console.WriteLine(" │                                                                                                                                                                    │");// 24
            Console.WriteLine(" │                                                                                                                                                                    │");// 25
            Console.WriteLine(" │                                                                                                                                                                    │");// 26
            Console.WriteLine(" │                                                                                                                                                                    │");// 27
            Console.WriteLine(" │                                                                                                                                                                    │");// 28
            Console.WriteLine(" │                                                                                                                                                                    │");// 29
            Console.WriteLine(" │                                                                                                                                                                    │");// 30
            Console.WriteLine(" │                                                                                                                                                                    │");// 31
            Console.WriteLine(" │                                                                                                                                                                    │");// 32
            Console.WriteLine(" │                                                                                                                                                                    │");// 33
            Console.WriteLine(" │                                                                                                                                                                    │");// 34
            Console.WriteLine(" │                                                                                                                                                                    │");// 35
            Console.WriteLine(" │                                                                                                                                                                    │");// 36
            Console.WriteLine(" │                                                                                                                                                                    │");// 37
            Console.WriteLine(" │                                                                                                                                                                    │");// 38
            Console.WriteLine(" │                                                                                                                                                                    │");// 39
            Console.WriteLine(" │                                                                                                                                                                    │");// 40
            Console.WriteLine(" │                                                                                                                                                                    │");// 41
            Console.WriteLine(" │                                                                                                                                                                    │");// 42
            Console.WriteLine(" |────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────|");// 43


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(67, 3);
            Console.Write("      ██             ██        ");
            Console.SetCursorPosition(67, 4);
            Console.Write("        ██         ██          ");
            Console.SetCursorPosition(67, 5);
            Console.Write("      ██████████████████       ");
            Console.SetCursorPosition(67, 6);
            Console.Write("    ██████████████████████     ");
            Console.SetCursorPosition(67, 7);
            Console.Write("  ████    ██████████    ████   ");
            Console.SetCursorPosition(67, 8);
            Console.Write("██████████████████████████████ ");
            Console.SetCursorPosition(67, 9);
            Console.Write("██   ████████████████████   ██ ");
            Console.SetCursorPosition(67, 10);
            Console.Write("██   ██                ██   ██ ");
            Console.SetCursorPosition(67, 11);
            Console.Write("       ████        ████        ");


            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(40, 13);
                Console.Write("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
                Console.SetCursorPosition(40, 14);
                Console.Write("█                       QUAL SERIA A CAPITAL DO MÉXICO?                            █");
                Console.SetCursorPosition(40, 15);
                Console.Write("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(12, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(12, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(12, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(12, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(12, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(12, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(12, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(12, 27);
            Console.Write(" ▀            ▀ ");
            // opção A
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(5, 29);
                Console.Write("——————————————————————————————");
                Console.SetCursorPosition(5, 30);
                Console.Write("|      CIDADE DO MÉXICO     |");
                Console.SetCursorPosition(5, 31);
                Console.Write("—————————————————————————————");
            Console.SetCursorPosition(5, 32);
            Console.Write("              (A)             ");
            // opção B
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(45, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(45, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(45, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(45, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(45, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(45, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(45, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(45, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(38, 29);
                Console.Write("——————————————————————————————");
                Console.SetCursorPosition(38, 30);
                Console.Write("|           ESPNHO          |");
                Console.SetCursorPosition(38, 31);
                Console.Write("——————————————————————————————");
            Console.SetCursorPosition(38, 32);
            Console.Write("              (B)             ");
            // opção C
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(78, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(78, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(78, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(78, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(78, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(78, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(78, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(78, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(71, 29);
                Console.Write("——————————————————————————————");
                Console.SetCursorPosition(71, 30);
                Console.Write("|           DEL MÉXICO       |");
                Console.SetCursorPosition(71, 31);
                Console.Write("——————————————————————————————");
            Console.SetCursorPosition(71, 32);
            Console.Write("              (C)             ");
            // opção D
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(109, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(109, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(109, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(109, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(109, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(109, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(109, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(109, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(102, 29);
                Console.Write("——————————————————————————————");
                Console.SetCursorPosition(102, 30);
                Console.Write("|           MEXICALI         |");
                Console.SetCursorPosition(102, 31);
                Console.Write("——————————————————————————————");
            Console.SetCursorPosition(102, 32);
            Console.Write("              (D)             ");
            // opção E
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(141, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(141, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(141, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(141, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(141, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(141, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(141, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(141, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(134, 29);
                Console.Write("——————————————————————————————");
                Console.SetCursorPosition(134, 30);
                Console.Write("|          TIHUANA           |");
                Console.SetCursorPosition(134, 31);
                Console.Write("——————————————————————————————");
            Console.SetCursorPosition(134, 32);
            Console.Write("              (E)             ");
            // PRIMEIRA OPÇÃO CIDADE DO MEXICO
            Console.SetCursorPosition(34, 41);

                tecla = Console.ReadKey();


                switch (tecla.Key)
                {
                    case ConsoleKey.A:
                        GeoFase4();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.B:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.C:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.D:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.E:
                        Perdeu();
                        break;

                }

        


        }

        //QUARTAAA PERGUNTAA
        static public void GeoFase4()
        {


            ConsoleKeyInfo tecla;


            Console.Clear();
            Console.WriteLine(" ┌────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");// 1
            Console.WriteLine(" │                                                                                                                                                                    │");// 2
            Console.WriteLine(" │                                                                                                                                                                    │");// 3
            Console.WriteLine(" │                                                                                                                                                                    │");// 4
            Console.WriteLine(" │                                                                                                                                                                    │");// 5
            Console.WriteLine(" │                                                                                                                                                                    │");// 6
            Console.WriteLine(" │                                                                                                                                                                    │");// 7
            Console.WriteLine(" │                                                                                                                                                                    │");// 8
            Console.WriteLine(" │                                                                                                                                                                    │");// 9
            Console.WriteLine(" │                                                                                                                                                                    │");// 10
            Console.WriteLine(" │                                                                                                                                                                    │");// 11
            Console.WriteLine(" │                                                                                                                                                                    │");// 12
            Console.WriteLine(" │                                                                                                                                                                    │");// 13
            Console.WriteLine(" │                                                                                                                                                                    │");// 14
            Console.WriteLine(" │                                                                                                                                                                    │");// 15
            Console.WriteLine(" │                                                                                                                                                                    │");// 16
            Console.WriteLine(" │                                                                                                                                                                    │");// 17
            Console.WriteLine(" │                                                                                                                                                                    │");// 18
            Console.WriteLine(" │                                                                                                                                                                    │");// 19
            Console.WriteLine(" │                                                                                                                                                                    │");// 20
            Console.WriteLine(" │                                                                                                                                                                    │");// 21
            Console.WriteLine(" │                                                                                                                                                                    │");// 22
            Console.WriteLine(" │                                                                                                                                                                    │");// 23
            Console.WriteLine(" │                                                                                                                                                                    │");// 24
            Console.WriteLine(" │                                                                                                                                                                    │");// 25
            Console.WriteLine(" │                                                                                                                                                                    │");// 26
            Console.WriteLine(" │                                                                                                                                                                    │");// 27
            Console.WriteLine(" │                                                                                                                                                                    │");// 28
            Console.WriteLine(" │                                                                                                                                                                    │");// 29
            Console.WriteLine(" │                                                                                                                                                                    │");// 30
            Console.WriteLine(" │                                                                                                                                                                    │");// 31
            Console.WriteLine(" │                                                                                                                                                                    │");// 32
            Console.WriteLine(" │                                                                                                                                                                    │");// 33
            Console.WriteLine(" │                                                                                                                                                                    │");// 34
            Console.WriteLine(" │                                                                                                                                                                    │");// 35
            Console.WriteLine(" │                                                                                                                                                                    │");// 36
            Console.WriteLine(" │                                                                                                                                                                    │");// 37
            Console.WriteLine(" │                                                                                                                                                                    │");// 38
            Console.WriteLine(" │                                                                                                                                                                    │");// 39
            Console.WriteLine(" │                                                                                                                                                                    │");// 40
            Console.WriteLine(" │                                                                                                                                                                    │");// 41
            Console.WriteLine(" │                                                                                                                                                                    │");// 42
            Console.WriteLine(" |────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────|");// 43



            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(67, 3);
            Console.Write("      ██             ██        ");
            Console.SetCursorPosition(67, 4);
            Console.Write("        ██         ██          ");
            Console.SetCursorPosition(67, 5);
            Console.Write("      ██████████████████       ");
            Console.SetCursorPosition(67, 6);
            Console.Write("    ██████████████████████     ");
            Console.SetCursorPosition(67, 7);
            Console.Write("  ████    ██████████    ████   ");
            Console.SetCursorPosition(67, 8);
            Console.Write("██████████████████████████████ ");
            Console.SetCursorPosition(67, 9);
            Console.Write("██   ████████████████████   ██ ");
            Console.SetCursorPosition(67, 10);
            Console.Write("██   ██                ██   ██ ");
            Console.SetCursorPosition(67, 11);
            Console.Write("       ████        ████        ");


            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(40, 13);
                Console.Write("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
                Console.SetCursorPosition(40, 14);
                Console.Write("█      49 PAÍSES, 7 TERRITÓRIOS, MAIOR CONTINENTE DA TERRA. ESTAMOS FALANDO DA:    █");
                Console.SetCursorPosition(40, 15);
                Console.Write("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(12, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(12, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(12, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(12, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(12, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(12, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(12, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(12, 27);
            Console.Write(" ▀            ▀ ");
            // opção A
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(5, 29);
                Console.Write("——————————————————————————————");
                Console.SetCursorPosition(5, 30);
                Console.Write("|           ÁFRICA           |");
                Console.SetCursorPosition(5, 31);
                Console.Write("——————————————————————————————");
            Console.SetCursorPosition(5, 32);
            Console.Write("              (A)             ");
            // opção B
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(45, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(45, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(45, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(45, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(45, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(45, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(45, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(45, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(38, 29);
                Console.Write("——————————————————————————————");
                Console.SetCursorPosition(38, 30);
                Console.Write("|          ÁSIA              |");
                Console.SetCursorPosition(38, 31);
                Console.Write("——————————————————————————————");
            Console.SetCursorPosition(38, 32);
            Console.Write("              (B)             ");
            // opção C
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(78, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(78, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(78, 22);         
            Console.Write("    ████████    ");
            Console.SetCursorPosition(78, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(78, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(78, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(78, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(78, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(71, 29);
                Console.Write("——————————————————————————————");
                Console.SetCursorPosition(71, 30);
                Console.Write("|           AMÉRICA          |");
                Console.SetCursorPosition(71, 31);
                Console.Write("——————————————————————————————");
            Console.SetCursorPosition(71, 32);
            Console.Write("              (C)             ");
            // opção D
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(109, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(109, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(109, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(109, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(109, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(109, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(109, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(109, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(102, 29);
                Console.Write("——————————————————————————————");
                Console.SetCursorPosition(102, 30);
                Console.Write("|          EUROPA            |");
                Console.SetCursorPosition(102, 31);
                Console.Write("——————————————————————————————");
            Console.SetCursorPosition(102, 32);
            Console.Write("              (D)             ");
            // opção E
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(141, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(141, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(141, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(141, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(141, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(141, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(141, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(141, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(134, 29);
                Console.Write("——————————————————————————————");
                Console.SetCursorPosition(134, 30);
                Console.Write("|          OCEANIA           |");
                Console.SetCursorPosition(134, 31);
                Console.Write("——————————————————————————————");
            Console.SetCursorPosition(134, 32);
            Console.Write("              (E)             ");
            // OPCAO 2 ÁSIA
            Console.SetCursorPosition(34, 41);

                tecla = Console.ReadKey();


                switch (tecla.Key)
                {
                    case ConsoleKey.A:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.B:
                        GeoFase5();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.C:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.D:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.E:
                        Perdeu();
                        break;

                }



        }

        // QUINTA PERGUNTAAAAAA

        static public void GeoFase5()
        {


            ConsoleKeyInfo tecla;


            Console.Clear();
            Console.WriteLine(" ┌────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");// 1
            Console.WriteLine(" │                                                                                                                                                                    │");// 2
            Console.WriteLine(" │                                                                                                                                                                    │");// 3
            Console.WriteLine(" │                                                                                                                                                                    │");// 4
            Console.WriteLine(" │                                                                                                                                                                    │");// 5
            Console.WriteLine(" │                                                                                                                                                                    │");// 6
            Console.WriteLine(" │                                                                                                                                                                    │");// 7
            Console.WriteLine(" │                                                                                                                                                                    │");// 8
            Console.WriteLine(" │                                                                                                                                                                    │");// 9
            Console.WriteLine(" │                                                                                                                                                                    │");// 10
            Console.WriteLine(" │                                                                                                                                                                    │");// 11
            Console.WriteLine(" │                                                                                                                                                                    │");// 12
            Console.WriteLine(" │                                                                                                                                                                    │");// 13
            Console.WriteLine(" │                                                                                                                                                                    │");// 14
            Console.WriteLine(" │                                                                                                                                                                    │");// 15
            Console.WriteLine(" │                                                                                                                                                                    │");// 16
            Console.WriteLine(" │                                                                                                                                                                    │");// 17
            Console.WriteLine(" │                                                                                                                                                                    │");// 18
            Console.WriteLine(" │                                                                                                                                                                    │");// 19
            Console.WriteLine(" │                                                                                                                                                                    │");// 20
            Console.WriteLine(" │                                                                                                                                                                    │");// 21
            Console.WriteLine(" │                                                                                                                                                                    │");// 22
            Console.WriteLine(" │                                                                                                                                                                    │");// 23
            Console.WriteLine(" │                                                                                                                                                                    │");// 24
            Console.WriteLine(" │                                                                                                                                                                    │");// 25
            Console.WriteLine(" │                                                                                                                                                                    │");// 26
            Console.WriteLine(" │                                                                                                                                                                    │");// 27
            Console.WriteLine(" │                                                                                                                                                                    │");// 28
            Console.WriteLine(" │                                                                                                                                                                    │");// 29
            Console.WriteLine(" │                                                                                                                                                                    │");// 30
            Console.WriteLine(" │                                                                                                                                                                    │");// 31
            Console.WriteLine(" │                                                                                                                                                                    │");// 32
            Console.WriteLine(" │                                                                                                                                                                    │");// 33
            Console.WriteLine(" │                                                                                                                                                                    │");// 34
            Console.WriteLine(" │                                                                                                                                                                    │");// 35
            Console.WriteLine(" │                                                                                                                                                                    │");// 36
            Console.WriteLine(" │                                                                                                                                                                    │");// 37
            Console.WriteLine(" │                                                                                                                                                                    │");// 38
            Console.WriteLine(" │                                                                                                                                                                    │");// 39
            Console.WriteLine(" │                                                                                                                                                                    │");// 40
            Console.WriteLine(" │                                                                                                                                                                    │");// 41
            Console.WriteLine(" │                                                                                                                                                                    │");// 42
            Console.WriteLine(" |────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────|");// 43


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(67, 3);
            Console.Write("      ██             ██        ");
            Console.SetCursorPosition(67, 4);
            Console.Write("        ██         ██          ");
            Console.SetCursorPosition(67, 5);
            Console.Write("      ██████████████████       ");
            Console.SetCursorPosition(67, 6);
            Console.Write("    ██████████████████████     ");
            Console.SetCursorPosition(67, 7);
            Console.Write("  ████    ██████████    ████   ");
            Console.SetCursorPosition(67, 8);
            Console.Write("██████████████████████████████ ");
            Console.SetCursorPosition(67, 9);
            Console.Write("██   ████████████████████   ██ ");
            Console.SetCursorPosition(67, 10);
            Console.Write("██   ██                ██   ██ ");
            Console.SetCursorPosition(67, 11);
            Console.Write("       ████        ████        ");


            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(40, 13);
                Console.Write("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
                Console.SetCursorPosition(40, 14);
                Console.Write("█                 QUANTOS PAÍSES TEM A AMÉRICA? (TODAS JUNTAS)                     █");
                Console.SetCursorPosition(40, 15);
                Console.Write("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(12, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(12, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(12, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(12, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(12, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(12, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(12, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(12, 27);
            Console.Write(" ▀            ▀ ");
            // opção A
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(5, 29);
                Console.Write("——————————————————————————————");
                Console.SetCursorPosition(5, 30);
                Console.Write("|             40             |");
                Console.SetCursorPosition(5, 31);
                Console.Write("——————————————————————————————");
            Console.SetCursorPosition(5, 32);
            Console.Write("              (A)             ");
            // opção B
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(45, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(45, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(45, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(45, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(45, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(45, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(45, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(45, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(38, 29);
                Console.Write("——————————————————————————————");
                Console.SetCursorPosition(38, 30);
                Console.Write("|             96             |");
                Console.SetCursorPosition(38, 31);
                Console.Write("——————————————————————————————");
            Console.SetCursorPosition(38, 32);
            Console.Write("              (B)             ");
            // opção C
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(78, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(78, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(78, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(78, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(78, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(78, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(78, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(78, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(71, 29);
                Console.Write("——————————————————————————————");
                Console.SetCursorPosition(71, 30);
                Console.Write("|            37              |");
                Console.SetCursorPosition(71, 31);
                Console.Write("——————————————————————————————");
            Console.SetCursorPosition(71, 32);
            Console.Write("              (C)             ");
            // opção D
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(109, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(109, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(109, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(109, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(109, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(109, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(109, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(109, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(102, 29);
                Console.Write("——————————————————————————————");
                Console.SetCursorPosition(102, 30);
                Console.Write("|             75             |");
                Console.SetCursorPosition(102, 31);
                Console.Write("——————————————————————————————");
            Console.SetCursorPosition(102, 32);
            Console.Write("              (D)             ");
            // opção E
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(141, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(141, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(141, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(141, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(141, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(141, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(141, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(141, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(134, 29);
                Console.Write("——————————————————————————————");
                Console.SetCursorPosition(134, 30);
                Console.Write("|             23             |");
                Console.SetCursorPosition(134, 31);
                Console.Write("——————————————————————————————");
            Console.SetCursorPosition(134, 32);
            Console.Write("              (E)             ");
            // OPCAO 3 SERIA 37
            Console.SetCursorPosition(34, 41);

                tecla = Console.ReadKey();


                switch (tecla.Key)
                {
                    case ConsoleKey.A:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.B:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.C:
                        Parabens();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.D:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.E:
                        Perdeu();
                        break;

                }

         


        }

        //__________________________________________________________QUIZ MATEMATICA_______________________________________________________________
        static public void MatFase()
        {

            ConsoleKeyInfo tecla;


            Console.Clear();
            Console.WriteLine(" ┌────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");// 1
            Console.WriteLine(" │                                                                                                                                                                    │");// 2
            Console.WriteLine(" │                                                                                                                                                                    │");// 3
            Console.WriteLine(" │                                                                                                                                                                    │");// 4
            Console.WriteLine(" │                                                                                                                                                                    │");// 5
            Console.WriteLine(" │                                                                                                                                                                    │");// 6
            Console.WriteLine(" │                                                                                                                                                                    │");// 7
            Console.WriteLine(" │                                                                                                                                                                    │");// 8
            Console.WriteLine(" │                                                                                                                                                                    │");// 9
            Console.WriteLine(" │                                                                                                                                                                    │");// 10
            Console.WriteLine(" │                                                                                                                                                                    │");// 11
            Console.WriteLine(" │                                                                                                                                                                    │");// 12
            Console.WriteLine(" │                                                                                                                                                                    │");// 13
            Console.WriteLine(" │                                                                                                                                                                    │");// 14
            Console.WriteLine(" │                                                                                                                                                                    │");// 15
            Console.WriteLine(" │                                                                                                                                                                    │");// 16
            Console.WriteLine(" │                                                                                                                                                                    │");// 17
            Console.WriteLine(" │                                                                                                                                                                    │");// 18
            Console.WriteLine(" │                                                                                                                                                                    │");// 19
            Console.WriteLine(" │                                                                                                                                                                    │");// 20
            Console.WriteLine(" │                                                                                                                                                                    │");// 21
            Console.WriteLine(" │                                                                                                                                                                    │");// 22
            Console.WriteLine(" │                                                                                                                                                                    │");// 23
            Console.WriteLine(" │                                                                                                                                                                    │");// 24
            Console.WriteLine(" │                                                                                                                                                                    │");// 25
            Console.WriteLine(" │                                                                                                                                                                    │");// 26
            Console.WriteLine(" │                                                                                                                                                                    │");// 27
            Console.WriteLine(" │                                                                                                                                                                    │");// 28
            Console.WriteLine(" │                                                                                                                                                                    │");// 29
            Console.WriteLine(" │                                                                                                                                                                    │");// 30
            Console.WriteLine(" │                                                                                                                                                                    │");// 31
            Console.WriteLine(" │                                                                                                                                                                    │");// 32
            Console.WriteLine(" │                                                                                                                                                                    │");// 33
            Console.WriteLine(" │                                                                                                                                                                    │");// 34
            Console.WriteLine(" │                                                                                                                                                                    │");// 35
            Console.WriteLine(" │                                                                                                                                                                    │");// 36
            Console.WriteLine(" │                                                                                                                                                                    │");// 37
            Console.WriteLine(" │                                                                                                                                                                    │");// 38
            Console.WriteLine(" │                                                                                                                                                                    │");// 39
            Console.WriteLine(" │                                                                                                                                                                    │");// 40
            Console.WriteLine(" │                                                                                                                                                                    │");// 41
            Console.WriteLine(" │                                                                                                                                                                    │");// 42
            Console.WriteLine(" |────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────|");// 43



            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(68, 3);
            Console.Write("      ██             ██        ");
            Console.SetCursorPosition(68, 4);
            Console.Write("        ██         ██          ");
            Console.SetCursorPosition(68, 5);
            Console.Write("      ██████████████████       ");
            Console.SetCursorPosition(68, 6);
            Console.Write("    ██████████████████████     ");
            Console.SetCursorPosition(68, 7);
            Console.Write("  ████    ██████████    ████   ");
            Console.SetCursorPosition(68, 8);
            Console.Write("██████████████████████████████ ");
            Console.SetCursorPosition(68, 9);
            Console.Write("██   ████████████████████   ██ ");
            Console.SetCursorPosition(68, 10);
            Console.Write("██   ██                ██   ██ ");
            Console.SetCursorPosition(68, 11);
            Console.Write("       ████        ████        ");


            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(55, 13);
                Console.Write("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
                Console.SetCursorPosition(55, 14);
                Console.Write("█      (EQUAÇÃO DE 1º GRAU) QUANTO É 3x+100=2x+100+200?     █");
                Console.SetCursorPosition(55, 15);
                Console.Write("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(10, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(10, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(10, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(10, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(10, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(10, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(10, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(10, 27);
            Console.Write(" ▀            ▀ ");
            // opção A
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(10, 29);
                Console.Write("———————————————");
                Console.SetCursorPosition(10, 30);
                Console.Write("|      99     |");
                Console.SetCursorPosition(10, 31);
                Console.Write("———————————————");
                Console.SetCursorPosition(10, 32);
                Console.Write("      (A)      ");
            // opção B

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(48, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(48, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(48, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(48, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(48, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(48, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(48, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(48, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(48, 29);
                Console.Write("————————————————");
                Console.SetCursorPosition(48, 30);
                Console.Write("|      100     |");
                Console.SetCursorPosition(48, 31);
                Console.Write("————————————————");
            Console.SetCursorPosition(48, 32);
            Console.Write("      (B)      ");
            // opção
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(81, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(81, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(81, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(81, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(81, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(81, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(81, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(81, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(81, 29);
                Console.Write("————————————————");
                Console.SetCursorPosition(81, 30);
                Console.Write("|      200     |");
                Console.SetCursorPosition(81, 31);
                Console.Write("————————————————");
            Console.SetCursorPosition(81, 32);
            Console.Write("      (C)      ");
            // opção D
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(112, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(112, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(112, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(112, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(112, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(112, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(112, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(112, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(112, 29);
                Console.Write("————————————————");
                Console.SetCursorPosition(112, 30);
                Console.Write("|      320     |");
                Console.SetCursorPosition(112, 31);
                Console.Write("————————————————");
            Console.SetCursorPosition(112, 32);
            Console.Write("      (D)      ");
            // opção E
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(144, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(144, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(144, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(144, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(144, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(144, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(144, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(144, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(144, 29);
                Console.Write("————————————————");
                Console.SetCursorPosition(144, 30);
                Console.Write("|      810     |");
                Console.SetCursorPosition(144, 31);
                Console.Write("————————————————");
            Console.SetCursorPosition(10, 32);
            Console.Write("      (A)      ");

            Console.SetCursorPosition(48, 32);
            Console.Write("      (B)   ");

            Console.SetCursorPosition(81, 32);
            Console.Write("      (C)  ");

            Console.SetCursorPosition(112, 32);
            Console.Write("      (D)     ");

            Console.SetCursorPosition(144, 32);
            Console.Write("      (E)    ");
            Console.SetCursorPosition(34, 41);
            Console.SetCursorPosition(144, 32);
            Console.Write("      (E)      ");
            Console.SetCursorPosition(34, 41);

                tecla = Console.ReadKey();


                switch (tecla.Key)
                {
                    case ConsoleKey.A:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.B:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.C:
                        MatFase2();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.D:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.E:
                        Perdeu();
                        break;

                }



        }
        static public void MatFase2()
        {

            ConsoleKeyInfo tecla;


            Console.Clear();
            Console.WriteLine(" ┌────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");// 1
            Console.WriteLine(" │                                                                                                                                                                    │");// 2
            Console.WriteLine(" │                                                                                                                                                                    │");// 3
            Console.WriteLine(" │                                                                                                                                                                    │");// 4
            Console.WriteLine(" │                                                                                                                                                                    │");// 5
            Console.WriteLine(" │                                                                                                                                                                    │");// 6
            Console.WriteLine(" │                                                                                                                                                                    │");// 7
            Console.WriteLine(" │                                                                                                                                                                    │");// 8
            Console.WriteLine(" │                                                                                                                                                                    │");// 9
            Console.WriteLine(" │                                                                                                                                                                    │");// 10
            Console.WriteLine(" │                                                                                                                                                                    │");// 11
            Console.WriteLine(" │                                                                                                                                                                    │");// 12
            Console.WriteLine(" │                                                                                                                                                                    │");// 13
            Console.WriteLine(" │                                                                                                                                                                    │");// 14
            Console.WriteLine(" │                                                                                                                                                                    │");// 15
            Console.WriteLine(" │                                                                                                                                                                    │");// 16
            Console.WriteLine(" │                                                                                                                                                                    │");// 17
            Console.WriteLine(" │                                                                                                                                                                    │");// 18
            Console.WriteLine(" │                                                                                                                                                                    │");// 19
            Console.WriteLine(" │                                                                                                                                                                    │");// 20
            Console.WriteLine(" │                                                                                                                                                                    │");// 21
            Console.WriteLine(" │                                                                                                                                                                    │");// 22
            Console.WriteLine(" │                                                                                                                                                                    │");// 23
            Console.WriteLine(" │                                                                                                                                                                    │");// 24
            Console.WriteLine(" │                                                                                                                                                                    │");// 25
            Console.WriteLine(" │                                                                                                                                                                    │");// 26
            Console.WriteLine(" │                                                                                                                                                                    │");// 27
            Console.WriteLine(" │                                                                                                                                                                    │");// 28
            Console.WriteLine(" │                                                                                                                                                                    │");// 29
            Console.WriteLine(" │                                                                                                                                                                    │");// 30
            Console.WriteLine(" │                                                                                                                                                                    │");// 31
            Console.WriteLine(" │                                                                                                                                                                    │");// 32
            Console.WriteLine(" │                                                                                                                                                                    │");// 33
            Console.WriteLine(" │                                                                                                                                                                    │");// 34
            Console.WriteLine(" │                                                                                                                                                                    │");// 35
            Console.WriteLine(" │                                                                                                                                                                    │");// 36
            Console.WriteLine(" │                                                                                                                                                                    │");// 37
            Console.WriteLine(" │                                                                                                                                                                    │");// 38
            Console.WriteLine(" │                                                                                                                                                                    │");// 39
            Console.WriteLine(" │                                                                                                                                                                    │");// 40
            Console.WriteLine(" │                                                                                                                                                                    │");// 41
            Console.WriteLine(" │                                                                                                                                                                    │");// 42
            Console.WriteLine(" |────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────|");// 43

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(68, 3);
            Console.Write("      ██             ██        ");
            Console.SetCursorPosition(68, 4);
            Console.Write("        ██         ██          ");
            Console.SetCursorPosition(68, 5);
            Console.Write("      ██████████████████       ");
            Console.SetCursorPosition(68, 6);
            Console.Write("    ██████████████████████     ");
            Console.SetCursorPosition(68, 7);
            Console.Write("  ████    ██████████    ████   ");
            Console.SetCursorPosition(68, 8);
            Console.Write("██████████████████████████████ ");
            Console.SetCursorPosition(68, 9);
            Console.Write("██   ████████████████████   ██ ");
            Console.SetCursorPosition(68, 10);
            Console.Write("██   ██                ██   ██ ");
            Console.SetCursorPosition(68, 11);
            Console.Write("       ████        ████        ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(10, 13);
                Console.Write("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
                Console.SetCursorPosition(10, 14);
                Console.Write("█      PEDRO TEM 30 ANOS E TEM MAIS TRES IRMÃOS: BIANCA DE 27, VICTOR DE 23 E ALEX DE 18. QUAL A DIFERENÇA DE IDADE ENTRE PEDRO E IRMÃO CAÇULA?     █");
                Console.SetCursorPosition(10, 15);
                Console.Write("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(10, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(10, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(10, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(10, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(10, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(10, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(10, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(10, 27);
            Console.Write(" ▀            ▀ ");

            // opção A
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(10, 29);
                Console.Write("———————————————");
                Console.SetCursorPosition(10, 30);
                Console.Write("|      12     |");
                Console.SetCursorPosition(10, 31);
                Console.Write("———————————————");
            Console.SetCursorPosition(10, 32);
            Console.Write("      (A)      ");
            // opção B
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(48, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(48, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(48, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(48, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(48, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(48, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(48, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(48, 27);
            Console.Write(" ▀            ▀ ");
    
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(48, 29);
                Console.Write("————————————————");
                Console.SetCursorPosition(48, 30);
                Console.Write("|      15      |");
                Console.SetCursorPosition(48, 31);
                Console.Write("————————————————");
            Console.SetCursorPosition(48, 32);
            Console.Write("      (B)      ");
            // opção C
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(81, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(81, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(81, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(81, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(81, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(81, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(81, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(81, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(81, 29);
                Console.Write("————————————————");
                Console.SetCursorPosition(81, 30);
                Console.Write("|      10      |");
                Console.SetCursorPosition(81, 31);
                Console.Write("————————————————");
            Console.SetCursorPosition(81, 32);
            Console.Write("      (C)      ");
            // opção D


            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(112, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(112, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(112, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(112, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(112, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(112, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(112, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(112, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(112, 29);
                Console.Write("————————————————");
                Console.SetCursorPosition(112, 30);
                Console.Write("|      8       |");
                Console.SetCursorPosition(112, 31);
                Console.Write("————————————————");
            Console.SetCursorPosition(112, 32);
            Console.Write("      (D)      ");
            // opção E


            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(144, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(144, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(144, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(144, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(144, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(144, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(144, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(144, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(144, 29);
                Console.Write("————————————————");
                Console.SetCursorPosition(144, 30);
                Console.Write("|      20      |");
                Console.SetCursorPosition(144, 31);
                Console.Write("————————————————");
            Console.SetCursorPosition(10, 32);
            Console.Write("      (A)      ");

            Console.SetCursorPosition(48, 32);
            Console.Write("      (B)   ");

            Console.SetCursorPosition(81, 32);
            Console.Write("      (C)  ");

            Console.SetCursorPosition(112, 32);
            Console.Write("      (D)     ");

            Console.SetCursorPosition(144, 32);
            Console.Write("      (E)    ");
            Console.SetCursorPosition(34, 41);
            Console.SetCursorPosition(144, 32);
            Console.Write("      (E)      ");
            Console.SetCursorPosition(34, 41);

                tecla = Console.ReadKey();


                switch (tecla.Key)
                {
                    case ConsoleKey.A:
                        MatFase3();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.B:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.C:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.D:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.E:
                        Perdeu();
                        break;

                }


        }
        static public void MatFase3()
        {

            ConsoleKeyInfo tecla;


            Console.Clear();
            Console.WriteLine(" ┌────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");// 1
            Console.WriteLine(" │                                                                                                                                                                    │");// 2
            Console.WriteLine(" │                                                                                                                                                                    │");// 3
            Console.WriteLine(" │                                                                                                                                                                    │");// 4
            Console.WriteLine(" │                                                                                                                                                                    │");// 5
            Console.WriteLine(" │                                                                                                                                                                    │");// 6
            Console.WriteLine(" │                                                                                                                                                                    │");// 7
            Console.WriteLine(" │                                                                                                                                                                    │");// 8
            Console.WriteLine(" │                                                                                                                                                                    │");// 9
            Console.WriteLine(" │                                                                                                                                                                    │");// 10
            Console.WriteLine(" │                                                                                                                                                                    │");// 11
            Console.WriteLine(" │                                                                                                                                                                    │");// 12
            Console.WriteLine(" │                                                                                                                                                                    │");// 13
            Console.WriteLine(" │                                                                                                                                                                    │");// 14
            Console.WriteLine(" │                                                                                                                                                                    │");// 15
            Console.WriteLine(" │                                                                                                                                                                    │");// 16
            Console.WriteLine(" │                                                                                                                                                                    │");// 17
            Console.WriteLine(" │                                                                                                                                                                    │");// 18
            Console.WriteLine(" │                                                                                                                                                                    │");// 19
            Console.WriteLine(" │                                                                                                                                                                    │");// 20
            Console.WriteLine(" │                                                                                                                                                                    │");// 21
            Console.WriteLine(" │                                                                                                                                                                    │");// 22
            Console.WriteLine(" │                                                                                                                                                                    │");// 23
            Console.WriteLine(" │                                                                                                                                                                    │");// 24
            Console.WriteLine(" │                                                                                                                                                                    │");// 25
            Console.WriteLine(" │                                                                                                                                                                    │");// 26
            Console.WriteLine(" │                                                                                                                                                                    │");// 27
            Console.WriteLine(" │                                                                                                                                                                    │");// 28
            Console.WriteLine(" │                                                                                                                                                                    │");// 29
            Console.WriteLine(" │                                                                                                                                                                    │");// 30
            Console.WriteLine(" │                                                                                                                                                                    │");// 31
            Console.WriteLine(" │                                                                                                                                                                    │");// 32
            Console.WriteLine(" │                                                                                                                                                                    │");// 33
            Console.WriteLine(" │                                                                                                                                                                    │");// 34
            Console.WriteLine(" │                                                                                                                                                                    │");// 35
            Console.WriteLine(" │                                                                                                                                                                    │");// 36
            Console.WriteLine(" │                                                                                                                                                                    │");// 37
            Console.WriteLine(" │                                                                                                                                                                    │");// 38
            Console.WriteLine(" │                                                                                                                                                                    │");// 39
            Console.WriteLine(" │                                                                                                                                                                    │");// 40
            Console.WriteLine(" │                                                                                                                                                                    │");// 41
            Console.WriteLine(" │                                                                                                                                                                    │");// 42
            Console.WriteLine(" |────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────|");// 43
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(68, 3);
            Console.Write("      ██             ██        ");
            Console.SetCursorPosition(68, 4);
            Console.Write("        ██         ██          ");
            Console.SetCursorPosition(68, 5);
            Console.Write("      ██████████████████       ");
            Console.SetCursorPosition(68, 6);
            Console.Write("    ██████████████████████     ");
            Console.SetCursorPosition(68, 7);
            Console.Write("  ████    ██████████    ████   ");
            Console.SetCursorPosition(68, 8);
            Console.Write("██████████████████████████████ ");
            Console.SetCursorPosition(68, 9);
            Console.Write("██   ████████████████████   ██ ");
            Console.SetCursorPosition(68, 10);
            Console.Write("██   ██                ██   ██ ");
            Console.SetCursorPosition(68, 11);
            Console.Write("       ████        ████        ");

            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(37, 13);
                Console.Write("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
                Console.SetCursorPosition(37, 14);
                Console.Write("█      SEJA A FUNÇÃO f DEFINIDA POR f(x) = 3x – 2, DETERMINE O VALOR DE f(5) + f(0):     █");
                Console.SetCursorPosition(37, 15);
                Console.Write("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(10, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(10, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(10, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(10, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(10, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(10, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(10, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(10, 27);
            Console.Write(" ▀            ▀ ");
            // opção A
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(10, 29);
                Console.Write("———————————————");
                Console.SetCursorPosition(10, 30);
                Console.Write("|      10     |");
                Console.SetCursorPosition(10, 31);
                Console.Write("———————————————");
            // opção B
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(48, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(48, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(48, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(48, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(48, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(48, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(48, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(48, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(48, 29);
                Console.Write("————————————————");
                Console.SetCursorPosition(48, 30);
                Console.Write("|      11      |");
                Console.SetCursorPosition(48, 31);
                Console.Write("————————————————");
            // opção C
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(81, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(81, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(81, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(81, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(81, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(81, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(81, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(81, 27);
            Console.Write(" ▀            ▀ ");

            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(81, 29);
                Console.Write("————————————————");
                Console.SetCursorPosition(81, 30);
                Console.Write("|      12      |");
                Console.SetCursorPosition(81, 31);
                Console.Write("————————————————");
            // opção D
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(112, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(112, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(112, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(112, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(112, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(112, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(112, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(112, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(112, 29);
                Console.Write("————————————————");
                Console.SetCursorPosition(112, 30);
                Console.Write("|      13      |");
                Console.SetCursorPosition(112, 31);
                Console.Write("————————————————");
            // opção E


            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(144, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(144, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(144, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(144, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(144, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(144, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(144, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(144, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(144, 29);
                Console.Write("————————————————");
                Console.SetCursorPosition(144, 30);
                Console.Write("|      14      |");
                Console.SetCursorPosition(144, 31);
                Console.Write("————————————————");
            Console.SetCursorPosition(10, 32);
            Console.Write("      (A)      ");

            Console.SetCursorPosition(48, 32);
            Console.Write("      (B)   ");

            Console.SetCursorPosition(81, 32);
            Console.Write("      (C)  ");

            Console.SetCursorPosition(112, 32);
            Console.Write("      (D)     ");

            Console.SetCursorPosition(144, 32);
            Console.Write("      (E)    ");
            Console.SetCursorPosition(34, 41);
            Console.SetCursorPosition(34, 41);

                tecla = Console.ReadKey();


                switch (tecla.Key)
                {
                    case ConsoleKey.A:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.B:
                        MatFase4();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.C:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.D:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.E:
                        Perdeu();
                        break;

                }

    


        }
        static public void MatFase4()
        {

            ConsoleKeyInfo tecla;


            Console.Clear();
            Console.WriteLine(" ┌────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");// 1
            Console.WriteLine(" │                                                                                                                                                                    │");// 2
            Console.WriteLine(" │                                                                                                                                                                    │");// 3
            Console.WriteLine(" │                                                                                                                                                                    │");// 4
            Console.WriteLine(" │                                                                                                                                                                    │");// 5
            Console.WriteLine(" │                                                                                                                                                                    │");// 6
            Console.WriteLine(" │                                                                                                                                                                    │");// 7
            Console.WriteLine(" │                                                                                                                                                                    │");// 8
            Console.WriteLine(" │                                                                                                                                                                    │");// 9
            Console.WriteLine(" │                                                                                                                                                                    │");// 10
            Console.WriteLine(" │                                                                                                                                                                    │");// 11
            Console.WriteLine(" │                                                                                                                                                                    │");// 12
            Console.WriteLine(" │                                                                                                                                                                    │");// 13
            Console.WriteLine(" │                                                                                                                                                                    │");// 14
            Console.WriteLine(" │                                                                                                                                                                    │");// 15
            Console.WriteLine(" │                                                                                                                                                                    │");// 16
            Console.WriteLine(" │                                                                                                                                                                    │");// 17
            Console.WriteLine(" │                                                                                                                                                                    │");// 18
            Console.WriteLine(" │                                                                                                                                                                    │");// 19
            Console.WriteLine(" │                                                                                                                                                                    │");// 20
            Console.WriteLine(" │                                                                                                                                                                    │");// 21
            Console.WriteLine(" │                                                                                                                                                                    │");// 22
            Console.WriteLine(" │                                                                                                                                                                    │");// 23
            Console.WriteLine(" │                                                                                                                                                                    │");// 24
            Console.WriteLine(" │                                                                                                                                                                    │");// 25
            Console.WriteLine(" │                                                                                                                                                                    │");// 26
            Console.WriteLine(" │                                                                                                                                                                    │");// 27
            Console.WriteLine(" │                                                                                                                                                                    │");// 28
            Console.WriteLine(" │                                                                                                                                                                    │");// 29
            Console.WriteLine(" │                                                                                                                                                                    │");// 30
            Console.WriteLine(" │                                                                                                                                                                    │");// 31
            Console.WriteLine(" │                                                                                                                                                                    │");// 32
            Console.WriteLine(" │                                                                                                                                                                    │");// 33
            Console.WriteLine(" │                                                                                                                                                                    │");// 34
            Console.WriteLine(" │                                                                                                                                                                    │");// 35
            Console.WriteLine(" │                                                                                                                                                                    │");// 36
            Console.WriteLine(" │                                                                                                                                                                    │");// 37
            Console.WriteLine(" │                                                                                                                                                                    │");// 38
            Console.WriteLine(" │                                                                                                                                                                    │");// 39
            Console.WriteLine(" │                                                                                                                                                                    │");// 40
            Console.WriteLine(" │                                                                                                                                                                    │");// 41
            Console.WriteLine(" │                                                                                                                                                                    │");// 42
            Console.WriteLine(" |────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────|");// 43
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(68, 3);
            Console.Write("      ██             ██        ");
            Console.SetCursorPosition(68, 4);
            Console.Write("        ██         ██          ");
            Console.SetCursorPosition(68, 5);
            Console.Write("      ██████████████████       ");
            Console.SetCursorPosition(68, 6);
            Console.Write("    ██████████████████████     ");
            Console.SetCursorPosition(68, 7);
            Console.Write("  ████    ██████████    ████   ");
            Console.SetCursorPosition(68, 8);
            Console.Write("██████████████████████████████ ");
            Console.SetCursorPosition(68, 9);
            Console.Write("██   ████████████████████   ██ ");
            Console.SetCursorPosition(68, 10);
            Console.Write("██   ██                ██   ██ ");
            Console.SetCursorPosition(68, 11);
            Console.Write("       ████        ████        ");

            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(40, 13);
                Console.Write("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
                Console.SetCursorPosition(40, 14);
                Console.Write("█       A SOMA DE UM NUMERO COM O SEU ANTECESSOR É IGUAL A 49. QUAL É O MENOR DESSES NÚMEROS?     █");
                Console.SetCursorPosition(40, 15);
                Console.Write("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(10, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(10, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(10, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(10, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(10, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(10, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(10, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(10, 27);
            Console.Write(" ▀            ▀ ");
            // opção A
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(10, 29);
                Console.Write("———————————————");
                Console.SetCursorPosition(10, 30);
                Console.Write("|      25     |");
                Console.SetCursorPosition(10, 31);
                Console.Write("———————————————");
            // opção B
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(48, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(48, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(48, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(48, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(48, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(48, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(48, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(48, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(48, 29);
                Console.Write("————————————————");
                Console.SetCursorPosition(48, 30);
                Console.Write("|      24      |");
                Console.SetCursorPosition(48, 31);
                Console.Write("————————————————");
            // opção C
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(81, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(81, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(81, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(81, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(81, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(81, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(81, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(81, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(81, 29);
                Console.Write("————————————————");
                Console.SetCursorPosition(81, 30);
                Console.Write("|      23      |");
                Console.SetCursorPosition(81, 31);
                Console.Write("————————————————");
            // opção D
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(112, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(112, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(112, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(112, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(112, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(112, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(112, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(112, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(112, 29);
                Console.Write("————————————————");
                Console.SetCursorPosition(112, 30);
                Console.Write("|      22      |");
                Console.SetCursorPosition(112, 31);
                Console.Write("————————————————");
            // opção E

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(144, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(144, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(144, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(144, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(144, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(144, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(144, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(144, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(144, 29);
                Console.Write("————————————————");
                Console.SetCursorPosition(144, 30);
                Console.Write("|      21      |");
                Console.SetCursorPosition(144, 31);
                Console.Write("————————————————");
            Console.SetCursorPosition(10, 32);
            Console.Write("      (A)      ");

            Console.SetCursorPosition(48, 32);
            Console.Write("      (B)   ");

            Console.SetCursorPosition(81, 32);
            Console.Write("      (C)  ");

            Console.SetCursorPosition(112, 32);
            Console.Write("      (D)     ");

            Console.SetCursorPosition(144, 32);
            Console.Write("      (E)    ");
            Console.SetCursorPosition(34, 41);
            Console.SetCursorPosition(34, 41);

                tecla = Console.ReadKey();


                switch (tecla.Key)
                {
                    case ConsoleKey.A:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.B:
                        MatFase5();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.C:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.D:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.E:
                        Perdeu();
                        break;

                }



        }
        static public void MatFase5()
        {

            ConsoleKeyInfo tecla;


            Console.Clear();
            Console.WriteLine(" ┌────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");// 1
            Console.WriteLine(" │                                                                                                                                                                    │");// 2
            Console.WriteLine(" │                                                                                                                                                                    │");// 3
            Console.WriteLine(" │                                                                                                                                                                    │");// 4
            Console.WriteLine(" │                                                                                                                                                                    │");// 5
            Console.WriteLine(" │                                                                                                                                                                    │");// 6
            Console.WriteLine(" │                                                                                                                                                                    │");// 7
            Console.WriteLine(" │                                                                                                                                                                    │");// 8
            Console.WriteLine(" │                                                                                                                                                                    │");// 9
            Console.WriteLine(" │                                                                                                                                                                    │");// 10
            Console.WriteLine(" │                                                                                                                                                                    │");// 11
            Console.WriteLine(" │                                                                                                                                                                    │");// 12
            Console.WriteLine(" │                                                                                                                                                                    │");// 13
            Console.WriteLine(" │                                                                                                                                                                    │");// 14
            Console.WriteLine(" │                                                                                                                                                                    │");// 15
            Console.WriteLine(" │                                                                                                                                                                    │");// 16
            Console.WriteLine(" │                                                                                                                                                                    │");// 17
            Console.WriteLine(" │                                                                                                                                                                    │");// 18
            Console.WriteLine(" │                                                                                                                                                                    │");// 19
            Console.WriteLine(" │                                                                                                                                                                    │");// 20
            Console.WriteLine(" │                                                                                                                                                                    │");// 21
            Console.WriteLine(" │                                                                                                                                                                    │");// 22
            Console.WriteLine(" │                                                                                                                                                                    │");// 23
            Console.WriteLine(" │                                                                                                                                                                    │");// 24
            Console.WriteLine(" │                                                                                                                                                                    │");// 25
            Console.WriteLine(" │                                                                                                                                                                    │");// 26
            Console.WriteLine(" │                                                                                                                                                                    │");// 27
            Console.WriteLine(" │                                                                                                                                                                    │");// 28
            Console.WriteLine(" │                                                                                                                                                                    │");// 29
            Console.WriteLine(" │                                                                                                                                                                    │");// 30
            Console.WriteLine(" │                                                                                                                                                                    │");// 31
            Console.WriteLine(" │                                                                                                                                                                    │");// 32
            Console.WriteLine(" │                                                                                                                                                                    │");// 33
            Console.WriteLine(" │                                                                                                                                                                    │");// 34
            Console.WriteLine(" │                                                                                                                                                                    │");// 35
            Console.WriteLine(" │                                                                                                                                                                    │");// 36
            Console.WriteLine(" │                                                                                                                                                                    │");// 37
            Console.WriteLine(" │                                                                                                                                                                    │");// 38
            Console.WriteLine(" │                                                                                                                                                                    │");// 39
            Console.WriteLine(" │                                                                                                                                                                    │");// 40
            Console.WriteLine(" │                                                                                                                                                                    │");// 41
            Console.WriteLine(" │                                                                                                                                                                    │");// 42
            Console.WriteLine(" |────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────|");// 43
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(68, 3);
            Console.Write("      ██             ██        ");
            Console.SetCursorPosition(68, 4);
            Console.Write("        ██         ██          ");
            Console.SetCursorPosition(68, 5);
            Console.Write("      ██████████████████       ");
            Console.SetCursorPosition(68, 6);
            Console.Write("    ██████████████████████     ");
            Console.SetCursorPosition(68, 7);
            Console.Write("  ████    ██████████    ████   ");
            Console.SetCursorPosition(68, 8);
            Console.Write("██████████████████████████████ ");
            Console.SetCursorPosition(68, 9);
            Console.Write("██   ████████████████████   ██ ");
            Console.SetCursorPosition(68, 10);
            Console.Write("██   ██                ██   ██ ");
            Console.SetCursorPosition(68, 11);
            Console.Write("       ████        ████        ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(40, 13);
                Console.Write("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
                Console.SetCursorPosition(40, 14);
                Console.Write("█      LEANDRO TEM 40 BALAS, CHUPOU 12 E DEU 10 PARA SUA IRMÃ. COM QUANTAS BALAS ELE FICOU?     █");
                Console.SetCursorPosition(40, 15);
                Console.Write("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(10, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(10, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(10, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(10, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(10, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(10, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(10, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(10, 27);
            Console.Write(" ▀            ▀ ");
            // opção A
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(10, 29);
                Console.Write("———————————————");
                Console.SetCursorPosition(10, 30);
                Console.Write("|      15     |");
                Console.SetCursorPosition(10, 31);
                Console.Write("———————————————");
            // opção B
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(48, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(48, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(48, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(48, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(48, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(48, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(48, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(48, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(48, 29);
                Console.Write("————————————————");
                Console.SetCursorPosition(48, 30);
                Console.Write("|      18     |");
                Console.SetCursorPosition(48, 31);
                Console.Write("————————————————");
            // opção C
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(81, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(81, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(81, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(81, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(81, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(81, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(81, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(81, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(81, 29);
                Console.Write("————————————————");
                Console.SetCursorPosition(81, 30);
                Console.Write("|      14     |");
                Console.SetCursorPosition(81, 31);
                Console.Write("————————————————");
            // opção D
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(112, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(112, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(112, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(112, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(112, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(112, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(112, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(112, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(112, 29);
                Console.Write("————————————————");
                Console.SetCursorPosition(112, 30);
                Console.Write("|      16     |");
                Console.SetCursorPosition(112, 31);
                Console.Write("————————————————");
            // opção E
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(144, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(144, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(144, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(144, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(144, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(144, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(144, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(144, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(144, 29);
                Console.Write("————————————————");
                Console.SetCursorPosition(144, 30);
                Console.Write("|      13      |");
                Console.SetCursorPosition(144, 31);
                Console.Write("————————————————");
            Console.SetCursorPosition(10, 32);
            Console.Write("      (A)      ");

            Console.SetCursorPosition(48, 32);
            Console.Write("      (B)   ");

            Console.SetCursorPosition(81, 32);
            Console.Write("      (C)  ");

            Console.SetCursorPosition(112, 32);
            Console.Write("      (D)     ");

            Console.SetCursorPosition(144, 32);
            Console.Write("      (E)    ");
            Console.SetCursorPosition(34, 41);

                tecla = Console.ReadKey();


                switch (tecla.Key)
                {
                    case ConsoleKey.A:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.B:
                        Parabens();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.C:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.D:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.E:
                        Perdeu();
                        break;

                }

      


        }
        //_________________________________________________________________QUIZ DE QUIMICA________________________________________________________________________
        static public void QuiFase()
        {

            ConsoleKeyInfo tecla;


            Console.Clear();
            Console.WriteLine(" ┌────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");// 1
            Console.WriteLine(" │                                                                                                                                                                    │");// 2
            Console.WriteLine(" │                                                                                                                                                                    │");// 3
            Console.WriteLine(" │                                                                                                                                                                    │");// 4
            Console.WriteLine(" │                                                                                                                                                                    │");// 5
            Console.WriteLine(" │                                                                                                                                                                    │");// 6
            Console.WriteLine(" │                                                                                                                                                                    │");// 7
            Console.WriteLine(" │                                                                                                                                                                    │");// 8
            Console.WriteLine(" │                                                                                                                                                                    │");// 9
            Console.WriteLine(" │                                                                                                                                                                    │");// 10
            Console.WriteLine(" │                                                                                                                                                                    │");// 11
            Console.WriteLine(" │                                                                                                                                                                    │");// 12
            Console.WriteLine(" │                                                                                                                                                                    │");// 13
            Console.WriteLine(" │                                                                                                                                                                    │");// 14
            Console.WriteLine(" │                                                                                                                                                                    │");// 15
            Console.WriteLine(" │                                                                                                                                                                    │");// 16
            Console.WriteLine(" │                                                                                                                                                                    │");// 17
            Console.WriteLine(" │                                                                                                                                                                    │");// 18
            Console.WriteLine(" │                                                                                                                                                                    │");// 19
            Console.WriteLine(" │                                                                                                                                                                    │");// 20
            Console.WriteLine(" │                                                                                                                                                                    │");// 21
            Console.WriteLine(" │                                                                                                                                                                    │");// 22
            Console.WriteLine(" │                                                                                                                                                                    │");// 23
            Console.WriteLine(" │                                                                                                                                                                    │");// 24
            Console.WriteLine(" │                                                                                                                                                                    │");// 25
            Console.WriteLine(" │                                                                                                                                                                    │");// 26
            Console.WriteLine(" │                                                                                                                                                                    │");// 27
            Console.WriteLine(" │                                                                                                                                                                    │");// 28
            Console.WriteLine(" │                                                                                                                                                                    │");// 29
            Console.WriteLine(" │                                                                                                                                                                    │");// 30
            Console.WriteLine(" │                                                                                                                                                                    │");// 31
            Console.WriteLine(" │                                                                                                                                                                    │");// 32
            Console.WriteLine(" │                                                                                                                                                                    │");// 33
            Console.WriteLine(" │                                                                                                                                                                    │");// 34
            Console.WriteLine(" │                                                                                                                                                                    │");// 35
            Console.WriteLine(" │                                                                                                                                                                    │");// 36
            Console.WriteLine(" │                                                                                                                                                                    │");// 37
            Console.WriteLine(" │                                                                                                                                                                    │");// 38
            Console.WriteLine(" │                                                                                                                                                                    │");// 39
            Console.WriteLine(" │                                                                                                                                                                    │");// 40
            Console.WriteLine(" │                                                                                                                                                                    │");// 41
            Console.WriteLine(" │                                                                                                                                                                    │");// 42
            Console.WriteLine(" |────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────|");// 43


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(68, 3);
            Console.Write("      ██             ██        ");
            Console.SetCursorPosition(68, 4);
            Console.Write("        ██         ██          ");
            Console.SetCursorPosition(68, 5);
            Console.Write("      ██████████████████       ");
            Console.SetCursorPosition(68, 6);
            Console.Write("    ██████████████████████     ");
            Console.SetCursorPosition(68, 7);
            Console.Write("  ████    ██████████    ████   ");
            Console.SetCursorPosition(68, 8);
            Console.Write("██████████████████████████████ ");
            Console.SetCursorPosition(68, 9);
            Console.Write("██   ████████████████████   ██ ");
            Console.SetCursorPosition(68, 10);
            Console.Write("██   ██                ██   ██ ");
            Console.SetCursorPosition(68, 11);
            Console.Write("       ████        ████        ");

            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(65, 13);
                Console.Write("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
                Console.SetCursorPosition(65, 14);
                Console.Write("█      QUAL SÍMBOLO É O TITÂNIO?     █");
                Console.SetCursorPosition(65, 15);
                Console.Write("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(12, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(12, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(12, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(12, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(12, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(12, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(12, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(12, 27);
            Console.Write(" ▀            ▀ ");
            // opção A
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(12, 29);
                Console.Write("———————————————");
                Console.SetCursorPosition(12, 30);
                Console.Write("|      Ti     |");
                Console.SetCursorPosition(12, 31);
                Console.Write("———————————————");
            // opção B
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(45, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(45, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(45, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(45, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(45, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(45, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(45, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(45, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(45, 29);
                Console.Write("————————————————");
                Console.SetCursorPosition(45, 30);
                Console.Write("|      Tt      |");
                Console.SetCursorPosition(45, 31);
                Console.Write("————————————————");
            // opção C

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(77, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(77, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(77, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(77, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(77, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(77, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(77, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(77, 27);
            Console.Write(" ▀            ▀ ");

            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(77, 29);
                Console.Write("————————————————");
                Console.SetCursorPosition(77, 30);
                Console.Write("|      To      |");
                Console.SetCursorPosition(77, 31);
                Console.Write("————————————————");
            // opção D

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(109, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(109, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(109, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(109, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(109, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(109, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(109, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(109, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(109, 29);
                Console.Write("————————————————");
                Console.SetCursorPosition(109, 30);
                Console.Write("|      Tn      |");
                Console.SetCursorPosition(109, 31);
                Console.Write("————————————————");
            // opção E

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(141, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(141, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(141, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(141, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(141, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(141, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(141, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(141, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(141, 29);
                Console.Write("————————————————");
                Console.SetCursorPosition(141, 30);
                Console.Write("|      Ta      |");
                Console.SetCursorPosition(141, 31);
                Console.Write("————————————————");
            Console.SetCursorPosition(12, 32);
            Console.Write("      (A)      ");

            Console.SetCursorPosition(45, 32);
            Console.Write("      (B)   ");

            Console.SetCursorPosition(77, 32);
            Console.Write("      (C)  ");

            Console.SetCursorPosition(109, 32);
            Console.Write("      (D)     ");

            Console.SetCursorPosition(141, 32);
            Console.Write("      (E)    ");
            Console.SetCursorPosition(34, 41);

                tecla = Console.ReadKey();


                switch (tecla.Key)
                {
                    case ConsoleKey.A:
                        QuiFase2();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.B:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.C:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.D:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.E:
                        Perdeu();
                        break;

                }

       

        }
        static public void QuiFase2()
        {

            ConsoleKeyInfo tecla;


            Console.Clear();
            Console.WriteLine(" ┌────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");// 1
            Console.WriteLine(" │                                                                                                                                                                    │");// 2
            Console.WriteLine(" │                                                                                                                                                                    │");// 3
            Console.WriteLine(" │                                                                                                                                                                    │");// 4
            Console.WriteLine(" │                                                                                                                                                                    │");// 5
            Console.WriteLine(" │                                                                                                                                                                    │");// 6
            Console.WriteLine(" │                                                                                                                                                                    │");// 7
            Console.WriteLine(" │                                                                                                                                                                    │");// 8
            Console.WriteLine(" │                                                                                                                                                                    │");// 9
            Console.WriteLine(" │                                                                                                                                                                    │");// 10
            Console.WriteLine(" │                                                                                                                                                                    │");// 11
            Console.WriteLine(" │                                                                                                                                                                    │");// 12
            Console.WriteLine(" │                                                                                                                                                                    │");// 13
            Console.WriteLine(" │                                                                                                                                                                    │");// 14
            Console.WriteLine(" │                                                                                                                                                                    │");// 15
            Console.WriteLine(" │                                                                                                                                                                    │");// 16
            Console.WriteLine(" │                                                                                                                                                                    │");// 17
            Console.WriteLine(" │                                                                                                                                                                    │");// 18
            Console.WriteLine(" │                                                                                                                                                                    │");// 19
            Console.WriteLine(" │                                                                                                                                                                    │");// 20
            Console.WriteLine(" │                                                                                                                                                                    │");// 21
            Console.WriteLine(" │                                                                                                                                                                    │");// 22
            Console.WriteLine(" │                                                                                                                                                                    │");// 23
            Console.WriteLine(" │                                                                                                                                                                    │");// 24
            Console.WriteLine(" │                                                                                                                                                                    │");// 25
            Console.WriteLine(" │                                                                                                                                                                    │");// 26
            Console.WriteLine(" │                                                                                                                                                                    │");// 27
            Console.WriteLine(" │                                                                                                                                                                    │");// 28
            Console.WriteLine(" │                                                                                                                                                                    │");// 29
            Console.WriteLine(" │                                                                                                                                                                    │");// 30
            Console.WriteLine(" │                                                                                                                                                                    │");// 31
            Console.WriteLine(" │                                                                                                                                                                    │");// 32
            Console.WriteLine(" │                                                                                                                                                                    │");// 33
            Console.WriteLine(" │                                                                                                                                                                    │");// 34
            Console.WriteLine(" │                                                                                                                                                                    │");// 35
            Console.WriteLine(" │                                                                                                                                                                    │");// 36
            Console.WriteLine(" │                                                                                                                                                                    │");// 37
            Console.WriteLine(" │                                                                                                                                                                    │");// 38
            Console.WriteLine(" │                                                                                                                                                                    │");// 39
            Console.WriteLine(" │                                                                                                                                                                    │");// 40
            Console.WriteLine(" │                                                                                                                                                                    │");// 41
            Console.WriteLine(" │                                                                                                                                                                    │");// 42
            Console.WriteLine(" |────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────|");// 43
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(68, 3);
            Console.Write("      ██             ██        ");
            Console.SetCursorPosition(68, 4);
            Console.Write("        ██         ██          ");
            Console.SetCursorPosition(68, 5);
            Console.Write("      ██████████████████       ");
            Console.SetCursorPosition(68, 6);
            Console.Write("    ██████████████████████     ");
            Console.SetCursorPosition(68, 7);
            Console.Write("  ████    ██████████    ████   ");
            Console.SetCursorPosition(68, 8);
            Console.Write("██████████████████████████████ ");
            Console.SetCursorPosition(68, 9);
            Console.Write("██   ████████████████████   ██ ");
            Console.SetCursorPosition(68, 10);
            Console.Write("██   ██                ██   ██ ");
            Console.SetCursorPosition(68, 11);
            Console.Write("       ████        ████        ");

            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(65, 13);
                Console.Write("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
                Console.SetCursorPosition(65, 14);
                Console.Write("█      QUAL É A CLASSIFICAÇÃO DO HÉLIO?   █");
                Console.SetCursorPosition(65, 15);
                Console.Write("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(12, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(12, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(12, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(12, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(12, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(12, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(12, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(12, 27);
            Console.Write(" ▀            ▀ ");
            // opção A
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(12, 29);
                Console.Write("———————————————");
                Console.SetCursorPosition(12, 30);
                Console.Write("|  SEMI-METAL |");
                Console.SetCursorPosition(12, 31);
                Console.Write("———————————————");
            // opção B

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(45, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(45, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(45, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(45, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(45, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(45, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(45, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(45, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(45, 29);
                Console.Write("————————————————");
                Console.SetCursorPosition(45, 30);
                Console.Write("|METAL ALCALINO|");
                Console.SetCursorPosition(45, 31);
                Console.Write("————————————————");
            // opção C

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(77, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(77, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(77, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(77, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(77, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(77, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(77, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(77, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(77, 29);
                Console.Write("————————————————");
                Console.SetCursorPosition(77, 30);
                Console.Write("|   GÁS NOBRE  |");
                Console.SetCursorPosition(77, 31);
                Console.Write("————————————————");
            // opção D
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(109, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(109, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(109, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(109, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(109, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(109, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(109, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(109, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(109, 29);
                Console.Write("————————————————");
                Console.SetCursorPosition(109, 30);
                Console.Write("|   HALOGÊNIO  |");
                Console.SetCursorPosition(109, 31);
                Console.Write("————————————————");
            // opção E
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(141, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(141, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(141, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(141, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(141, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(141, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(141, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(141, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(141, 29);
                Console.Write("————————————————");
                Console.SetCursorPosition(141, 30);
                Console.Write("|  CALCOGÊNIO  |");
                Console.SetCursorPosition(141, 31);
                Console.Write("————————————————");
            Console.SetCursorPosition(12, 32);
            Console.Write("      (A)      ");

            Console.SetCursorPosition(45, 32);
            Console.Write("      (B)   ");

            Console.SetCursorPosition(77, 32);
            Console.Write("      (C)  ");

            Console.SetCursorPosition(109, 32);
            Console.Write("      (D)     ");

            Console.SetCursorPosition(141, 32);
            Console.Write("      (E)    ");
            Console.SetCursorPosition(34, 41);

                tecla = Console.ReadKey();


                switch (tecla.Key)
                {
                    case ConsoleKey.A:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.B:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.C:
                        QuiFase3();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.D:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.E:
                        Perdeu();
                        break;

                }

        

        }
        static public void QuiFase3()
        {

            ConsoleKeyInfo tecla;


            Console.Clear();
            Console.WriteLine(" ┌────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");// 1
            Console.WriteLine(" │                                                                                                                                                                    │");// 2
            Console.WriteLine(" │                                                                                                                                                                    │");// 3
            Console.WriteLine(" │                                                                                                                                                                    │");// 4
            Console.WriteLine(" │                                                                                                                                                                    │");// 5
            Console.WriteLine(" │                                                                                                                                                                    │");// 6
            Console.WriteLine(" │                                                                                                                                                                    │");// 7
            Console.WriteLine(" │                                                                                                                                                                    │");// 8
            Console.WriteLine(" │                                                                                                                                                                    │");// 9
            Console.WriteLine(" │                                                                                                                                                                    │");// 10
            Console.WriteLine(" │                                                                                                                                                                    │");// 11
            Console.WriteLine(" │                                                                                                                                                                    │");// 12
            Console.WriteLine(" │                                                                                                                                                                    │");// 13
            Console.WriteLine(" │                                                                                                                                                                    │");// 14
            Console.WriteLine(" │                                                                                                                                                                    │");// 15
            Console.WriteLine(" │                                                                                                                                                                    │");// 16
            Console.WriteLine(" │                                                                                                                                                                    │");// 17
            Console.WriteLine(" │                                                                                                                                                                    │");// 18
            Console.WriteLine(" │                                                                                                                                                                    │");// 19
            Console.WriteLine(" │                                                                                                                                                                    │");// 20
            Console.WriteLine(" │                                                                                                                                                                    │");// 21
            Console.WriteLine(" │                                                                                                                                                                    │");// 22
            Console.WriteLine(" │                                                                                                                                                                    │");// 23
            Console.WriteLine(" │                                                                                                                                                                    │");// 24
            Console.WriteLine(" │                                                                                                                                                                    │");// 25
            Console.WriteLine(" │                                                                                                                                                                    │");// 26
            Console.WriteLine(" │                                                                                                                                                                    │");// 27
            Console.WriteLine(" │                                                                                                                                                                    │");// 28
            Console.WriteLine(" │                                                                                                                                                                    │");// 29
            Console.WriteLine(" │                                                                                                                                                                    │");// 30
            Console.WriteLine(" │                                                                                                                                                                    │");// 31
            Console.WriteLine(" │                                                                                                                                                                    │");// 32
            Console.WriteLine(" │                                                                                                                                                                    │");// 33
            Console.WriteLine(" │                                                                                                                                                                    │");// 34
            Console.WriteLine(" │                                                                                                                                                                    │");// 35
            Console.WriteLine(" │                                                                                                                                                                    │");// 36
            Console.WriteLine(" │                                                                                                                                                                    │");// 37
            Console.WriteLine(" │                                                                                                                                                                    │");// 38
            Console.WriteLine(" │                                                                                                                                                                    │");// 39
            Console.WriteLine(" │                                                                                                                                                                    │");// 40
            Console.WriteLine(" │                                                                                                                                                                    │");// 41
            Console.WriteLine(" │                                                                                                                                                                    │");// 42
            Console.WriteLine(" |────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────|");// 43
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(73, 3);
            Console.Write("      ██             ██        ");
            Console.SetCursorPosition(73, 4);
            Console.Write("        ██         ██          ");
            Console.SetCursorPosition(73, 5);
            Console.Write("      ██████████████████       ");
            Console.SetCursorPosition(73, 6);
            Console.Write("    ██████████████████████     ");
            Console.SetCursorPosition(73, 7);
            Console.Write("  ████    ██████████    ████   ");
            Console.SetCursorPosition(73, 8);
            Console.Write("██████████████████████████████ ");
            Console.SetCursorPosition(73, 9);
            Console.Write("██   ████████████████████   ██ ");
            Console.SetCursorPosition(73, 10);
            Console.Write("██   ██                ██   ██ ");
            Console.SetCursorPosition(73, 11);
            Console.Write("       ████        ████        ");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(60, 13);
            Console.Write("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
            Console.SetCursorPosition(60, 14);
            Console.Write("█      COMPLETE: O MERCÚRIO É ___ EM TEMPERATURA AMBIENTE.   █");
            Console.SetCursorPosition(60, 15);
            Console.Write("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(12, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(12, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(12, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(12, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(12, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(12, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(12, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(12, 27);
            Console.Write(" ▀            ▀ ");
            // opção A
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(12, 29);
            Console.Write("———————————————");
            Console.SetCursorPosition(12, 30);
            Console.Write("|    LÍQUIDO | ");
            Console.SetCursorPosition(12, 31);
            Console.Write("———————————————");
            // opção B
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(45, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(45, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(45, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(45, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(45, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(45, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(45, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(45, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(45, 29);
            Console.Write("————————————————");
            Console.SetCursorPosition(45, 30);
            Console.Write("|     GASOSO   |");
            Console.SetCursorPosition(45, 31);
            Console.Write("————————————————");
            // opção C

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(77, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(77, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(77, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(77, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(77, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(77, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(77, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(77, 27);
            Console.Write(" ▀            ▀ ");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(77, 29);
            Console.Write("————————————————");
            Console.SetCursorPosition(77, 30);
            Console.Write("|    SÓLIDO    |");
            Console.SetCursorPosition(77, 31);
            Console.Write("————————————————");
            // opção D

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(109, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(109, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(109, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(109, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(109, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(109, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(109, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(109, 27);
            Console.Write(" ▀            ▀ ");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(109, 29);
            Console.Write("————————————————");
            Console.SetCursorPosition(109, 30);
            Console.Write("|   VAPOROSO   |");
            Console.SetCursorPosition(109, 31);
            Console.Write("————————————————");
            // opção E
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(141, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(141, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(141, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(141, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(141, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(141, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(141, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(141, 27);
            Console.Write(" ▀            ▀ ");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(142, 29);
            Console.Write("————————————————");
            Console.SetCursorPosition(141, 30);
            Console.Write("|  META-SÓLIDO |");
            Console.SetCursorPosition(141, 31);
            Console.Write("————————————————");
            Console.SetCursorPosition(12, 32);
            Console.Write("      (A)      ");

            Console.SetCursorPosition(45, 32);
            Console.Write("      (B)   ");

            Console.SetCursorPosition(77, 32);
            Console.Write("      (C)  ");

            Console.SetCursorPosition(109, 32);
            Console.Write("      (D)     ");

            Console.SetCursorPosition(141, 32);
            Console.Write("      (E)    ");
            Console.SetCursorPosition(34, 41);

            tecla = Console.ReadKey();


            switch (tecla.Key)
            {
                case ConsoleKey.A:
                    QuiFase4();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.B:
                    Perdeu();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.C:
                    Perdeu();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.D:
                    Perdeu();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.E:
                    Perdeu();
                    break;

            }



        }
        static public void QuiFase4()
        {

            ConsoleKeyInfo tecla;


            Console.Clear();
            Console.WriteLine(" ┌────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");// 1
            Console.WriteLine(" │                                                                                                                                                                    │");// 2
            Console.WriteLine(" │                                                                                                                                                                    │");// 3
            Console.WriteLine(" │                                                                                                                                                                    │");// 4
            Console.WriteLine(" │                                                                                                                                                                    │");// 5
            Console.WriteLine(" │                                                                                                                                                                    │");// 6
            Console.WriteLine(" │                                                                                                                                                                    │");// 7
            Console.WriteLine(" │                                                                                                                                                                    │");// 8
            Console.WriteLine(" │                                                                                                                                                                    │");// 9
            Console.WriteLine(" │                                                                                                                                                                    │");// 10
            Console.WriteLine(" │                                                                                                                                                                    │");// 11
            Console.WriteLine(" │                                                                                                                                                                    │");// 12
            Console.WriteLine(" │                                                                                                                                                                    │");// 13
            Console.WriteLine(" │                                                                                                                                                                    │");// 14
            Console.WriteLine(" │                                                                                                                                                                    │");// 15
            Console.WriteLine(" │                                                                                                                                                                    │");// 16
            Console.WriteLine(" │                                                                                                                                                                    │");// 17
            Console.WriteLine(" │                                                                                                                                                                    │");// 18
            Console.WriteLine(" │                                                                                                                                                                    │");// 19
            Console.WriteLine(" │                                                                                                                                                                    │");// 20
            Console.WriteLine(" │                                                                                                                                                                    │");// 21
            Console.WriteLine(" │                                                                                                                                                                    │");// 22
            Console.WriteLine(" │                                                                                                                                                                    │");// 23
            Console.WriteLine(" │                                                                                                                                                                    │");// 24
            Console.WriteLine(" │                                                                                                                                                                    │");// 25
            Console.WriteLine(" │                                                                                                                                                                    │");// 26
            Console.WriteLine(" │                                                                                                                                                                    │");// 27
            Console.WriteLine(" │                                                                                                                                                                    │");// 28
            Console.WriteLine(" │                                                                                                                                                                    │");// 29
            Console.WriteLine(" │                                                                                                                                                                    │");// 30
            Console.WriteLine(" │                                                                                                                                                                    │");// 31
            Console.WriteLine(" │                                                                                                                                                                    │");// 32
            Console.WriteLine(" │                                                                                                                                                                    │");// 33
            Console.WriteLine(" │                                                                                                                                                                    │");// 34
            Console.WriteLine(" │                                                                                                                                                                    │");// 35
            Console.WriteLine(" │                                                                                                                                                                    │");// 36
            Console.WriteLine(" │                                                                                                                                                                    │");// 37
            Console.WriteLine(" │                                                                                                                                                                    │");// 38
            Console.WriteLine(" │                                                                                                                                                                    │");// 39
            Console.WriteLine(" │                                                                                                                                                                    │");// 40
            Console.WriteLine(" │                                                                                                                                                                    │");// 41
            Console.WriteLine(" │                                                                                                                                                                    │");// 42
            Console.WriteLine(" |────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────|");// 43
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(75, 3);
            Console.Write("      ██             ██        ");
            Console.SetCursorPosition(75, 4);
            Console.Write("        ██         ██          ");
            Console.SetCursorPosition(75, 5);
            Console.Write("      ██████████████████       ");
            Console.SetCursorPosition(75, 6);
            Console.Write("    ██████████████████████     ");
            Console.SetCursorPosition(75, 7);
            Console.Write("  ████    ██████████    ████   ");
            Console.SetCursorPosition(75, 8);
            Console.Write("██████████████████████████████ ");
            Console.SetCursorPosition(75, 9);
            Console.Write("██   ████████████████████   ██ ");
            Console.SetCursorPosition(75, 10);
            Console.Write("██   ██                ██   ██ ");
            Console.SetCursorPosition(75, 11);
            Console.Write("       ████        ████        ");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(60, 13);
            Console.Write("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
            Console.SetCursorPosition(60, 14);
            Console.Write("█     QUAL DESSES MODELOS ATÔMICOS FOI CRIADO POR DALTON?   █");
            Console.SetCursorPosition(60, 15);
            Console.Write("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(12, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(12, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(12, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(12, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(12, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(12, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(12, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(12, 27);
            Console.Write(" ▀            ▀ ");
            // opção A
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(3, 29);
            Console.Write("————————————————————————————————————");
            Console.SetCursorPosition(3, 30);
            Console.Write("|          SISTEMA SOLAR           |");
            Console.SetCursorPosition(3, 31);
            Console.Write("————————————————————————————————————");
            // opção B
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(45, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(45, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(45, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(45, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(45, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(45, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(45, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(45, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(36, 29);
            Console.Write("————————————————————————————————————");
            Console.SetCursorPosition(36, 30);
            Console.Write("|          PUDIM DE PASSAS         |");
            Console.SetCursorPosition(36, 31);
            Console.Write("————————————————————————————————————");
            // opção C
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(77, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(77, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(77, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(77, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(77, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(77, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(77, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(77, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(69, 29);
            Console.Write("————————————————————————————————————");
            Console.SetCursorPosition(69, 30);
            Console.Write("|          BOLA DE BILHAR          |");
            Console.SetCursorPosition(69, 31);
            Console.Write("————————————————————————————————————");
            // opção D
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(109, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(109, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(109, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(109, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(109, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(109, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(109, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(109, 27);
            Console.Write(" ▀            ▀ ");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(100, 29);
            Console.Write("————————————————————————————————————");
            Console.SetCursorPosition(100, 30);
            Console.Write("|            ELETROSFERA           |");
            Console.SetCursorPosition(100, 31);
            Console.Write("————————————————————————————————————");
            // opção E

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(141, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(141, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(141, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(141, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(141, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(141, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(141, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(141, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(132, 29);
            Console.Write("—————————————————————————————————");
            Console.SetCursorPosition(132, 30);
            Console.Write("|           NENHUMA DELAS       |");
            Console.SetCursorPosition(132, 31);
            Console.Write("—————————————————————————————————");
            Console.SetCursorPosition(3, 32);
            Console.Write("              (A)             ");

            Console.SetCursorPosition(36, 32);
            Console.Write("              (B)             ");

            Console.SetCursorPosition(69, 32);
            Console.Write("              (C)             ");

            Console.SetCursorPosition(100, 32);
            Console.Write("              (D)             ");

            Console.SetCursorPosition(132, 32);
            Console.Write("              (E)             ");
            Console.SetCursorPosition(34, 41);

            tecla = Console.ReadKey();


            switch (tecla.Key)
            {
                case ConsoleKey.A:
                    Perdeu();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.B:
                    Perdeu();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.C:
                    QuiFase5();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.D:
                    Perdeu();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.E:
                    Perdeu();
                    break;

            }



        }
        static public void QuiFase5()
        {

            ConsoleKeyInfo tecla;


            Console.Clear();
            Console.WriteLine(" ┌────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");// 1
            Console.WriteLine(" │                                                                                                                                                                    │");// 2
            Console.WriteLine(" │                                                                                                                                                                    │");// 3
            Console.WriteLine(" │                                                                                                                                                                    │");// 4
            Console.WriteLine(" │                                                                                                                                                                    │");// 5
            Console.WriteLine(" │                                                                                                                                                                    │");// 6
            Console.WriteLine(" │                                                                                                                                                                    │");// 7
            Console.WriteLine(" │                                                                                                                                                                    │");// 8
            Console.WriteLine(" │                                                                                                                                                                    │");// 9
            Console.WriteLine(" │                                                                                                                                                                    │");// 10
            Console.WriteLine(" │                                                                                                                                                                    │");// 11
            Console.WriteLine(" │                                                                                                                                                                    │");// 12
            Console.WriteLine(" │                                                                                                                                                                    │");// 13
            Console.WriteLine(" │                                                                                                                                                                    │");// 14
            Console.WriteLine(" │                                                                                                                                                                    │");// 15
            Console.WriteLine(" │                                                                                                                                                                    │");// 16
            Console.WriteLine(" │                                                                                                                                                                    │");// 17
            Console.WriteLine(" │                                                                                                                                                                    │");// 18
            Console.WriteLine(" │                                                                                                                                                                    │");// 19
            Console.WriteLine(" │                                                                                                                                                                    │");// 20
            Console.WriteLine(" │                                                                                                                                                                    │");// 21
            Console.WriteLine(" │                                                                                                                                                                    │");// 22
            Console.WriteLine(" │                                                                                                                                                                    │");// 23
            Console.WriteLine(" │                                                                                                                                                                    │");// 24
            Console.WriteLine(" │                                                                                                                                                                    │");// 25
            Console.WriteLine(" │                                                                                                                                                                    │");// 26
            Console.WriteLine(" │                                                                                                                                                                    │");// 27
            Console.WriteLine(" │                                                                                                                                                                    │");// 28
            Console.WriteLine(" │                                                                                                                                                                    │");// 29
            Console.WriteLine(" │                                                                                                                                                                    │");// 30
            Console.WriteLine(" │                                                                                                                                                                    │");// 31
            Console.WriteLine(" │                                                                                                                                                                    │");// 32
            Console.WriteLine(" │                                                                                                                                                                    │");// 33
            Console.WriteLine(" │                                                                                                                                                                    │");// 34
            Console.WriteLine(" │                                                                                                                                                                    │");// 35
            Console.WriteLine(" │                                                                                                                                                                    │");// 36
            Console.WriteLine(" │                                                                                                                                                                    │");// 37
            Console.WriteLine(" │                                                                                                                                                                    │");// 38
            Console.WriteLine(" │                                                                                                                                                                    │");// 39
            Console.WriteLine(" │                                                                                                                                                                    │");// 40
            Console.WriteLine(" │                                                                                                                                                                    │");// 41
            Console.WriteLine(" │                                                                                                                                                                    │");// 42
            Console.WriteLine(" |────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────|");// 43

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(67, 3);
            Console.Write("      ██             ██        ");
            Console.SetCursorPosition(67, 4);
            Console.Write("        ██         ██          ");
            Console.SetCursorPosition(67, 5);
            Console.Write("      ██████████████████       ");
            Console.SetCursorPosition(67, 6);
            Console.Write("    ██████████████████████     ");
            Console.SetCursorPosition(67, 7);
            Console.Write("  ████    ██████████    ████   ");
            Console.SetCursorPosition(67, 8);
            Console.Write("██████████████████████████████ ");
            Console.SetCursorPosition(67, 9);
            Console.Write("██   ████████████████████   ██ ");
            Console.SetCursorPosition(67, 10);
            Console.Write("██   ██                ██   ██ ");
            Console.SetCursorPosition(67, 11);
            Console.Write("       ████        ████        ");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(28, 13);
            Console.Write("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
            Console.SetCursorPosition(28, 14);
            Console.Write("█    EM 1897  FOI CRIADO O MDOELO ATÔMICO QUE FICOU CONHECIDO COMO 'PUDIM DE PASSAS'.QUEM CRIOU ESSE MODELO?   █");
            Console.SetCursorPosition(28, 15);
            Console.Write("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(12, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(12, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(12, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(12, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(12, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(12, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(12, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(12, 27);
            Console.Write(" ▀            ▀ ");
            // opção A
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(3, 29);
            Console.Write("————————————————————————————————————");
            Console.SetCursorPosition(3, 30);
            Console.Write("|              DALTON              |");
            Console.SetCursorPosition(3, 31);
            Console.Write("————————————————————————————————————");
            // opção B

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(45, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(45, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(45, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(45, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(45, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(45, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(45, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(45, 27);
            Console.Write(" ▀            ▀ ");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(36, 29);
            Console.Write("————————————————————————————————————");
            Console.SetCursorPosition(36, 30);
            Console.Write("|                 BOHR             |");
            Console.SetCursorPosition(36, 31);
            Console.Write("————————————————————————————————————");
            // opção C
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(77, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(77, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(77, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(77, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(77, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(77, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(77, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(77, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(69, 29);
            Console.Write("————————————————————————————————————");
            Console.SetCursorPosition(69, 30);
            Console.Write("|               PROUST             |");
            Console.SetCursorPosition(69, 31);
            Console.Write("————————————————————————————————————");
            // opção D
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(109, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(109, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(109, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(109, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(109, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(109, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(109, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(109, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(100, 29);
            Console.Write("————————————————————————————————————");
            Console.SetCursorPosition(100, 30);
            Console.Write("|             THOMSON              |");
            Console.SetCursorPosition(100, 31);
            Console.Write("————————————————————————————————————");
            // opção E
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(141, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(141, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(141, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(141, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(141, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(141, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(141, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(141, 27);
            Console.Write(" ▀            ▀ ");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(132, 29);
            Console.Write("————————————————————————————————");
            Console.SetCursorPosition(132, 30);
            Console.Write("|          RUTHERFOFD          | ");
            Console.SetCursorPosition(132, 31);
            Console.Write("————————————————————————————————");
            Console.SetCursorPosition(3, 32);
            Console.Write("              (A)             ");

            Console.SetCursorPosition(36, 32);
            Console.Write("              (B)             ");

            Console.SetCursorPosition(69, 32);
            Console.Write("              (C)             ");

            Console.SetCursorPosition(100, 32);
            Console.Write("              (D)             ");

            Console.SetCursorPosition(132, 32);
            Console.Write("              (E)             ");
            Console.SetCursorPosition(34, 41);

            tecla = Console.ReadKey();


            switch (tecla.Key)
            {
                case ConsoleKey.A:
                    Perdeu();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.B:
                    Perdeu();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.C:
                    Perdeu();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.D:
                    Parabens();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.E:
                    Perdeu();
                    break;

            }

            

        }
        //__________________________________________QUIZ DE BIOLOGIA________________________________________________
        static public void BioFase()
        {

            ConsoleKeyInfo tecla;


            Console.Clear();
            Console.WriteLine(" ┌────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");// 1
            Console.WriteLine(" │                                                                                                                                                                    │");// 2
            Console.WriteLine(" │                                                                                                                                                                    │");// 3
            Console.WriteLine(" │                                                                                                                                                                    │");// 4
            Console.WriteLine(" │                                                                                                                                                                    │");// 5
            Console.WriteLine(" │                                                                                                                                                                    │");// 6
            Console.WriteLine(" │                                                                                                                                                                    │");// 7
            Console.WriteLine(" │                                                                                                                                                                    │");// 8
            Console.WriteLine(" │                                                                                                                                                                    │");// 9
            Console.WriteLine(" │                                                                                                                                                                    │");// 10
            Console.WriteLine(" │                                                                                                                                                                    │");// 11
            Console.WriteLine(" │                                                                                                                                                                    │");// 12
            Console.WriteLine(" │                                                                                                                                                                    │");// 13
            Console.WriteLine(" │                                                                                                                                                                    │");// 14
            Console.WriteLine(" │                                                                                                                                                                    │");// 15
            Console.WriteLine(" │                                                                                                                                                                    │");// 16
            Console.WriteLine(" │                                                                                                                                                                    │");// 17
            Console.WriteLine(" │                                                                                                                                                                    │");// 18
            Console.WriteLine(" │                                                                                                                                                                    │");// 19
            Console.WriteLine(" │                                                                                                                                                                    │");// 20
            Console.WriteLine(" │                                                                                                                                                                    │");// 21
            Console.WriteLine(" │                                                                                                                                                                    │");// 22
            Console.WriteLine(" │                                                                                                                                                                    │");// 23
            Console.WriteLine(" │                                                                                                                                                                    │");// 24
            Console.WriteLine(" │                                                                                                                                                                    │");// 25
            Console.WriteLine(" │                                                                                                                                                                    │");// 26
            Console.WriteLine(" │                                                                                                                                                                    │");// 27
            Console.WriteLine(" │                                                                                                                                                                    │");// 28
            Console.WriteLine(" │                                                                                                                                                                    │");// 29
            Console.WriteLine(" │                                                                                                                                                                    │");// 30
            Console.WriteLine(" │                                                                                                                                                                    │");// 31
            Console.WriteLine(" │                                                                                                                                                                    │");// 32
            Console.WriteLine(" │                                                                                                                                                                    │");// 33
            Console.WriteLine(" │                                                                                                                                                                    │");// 34
            Console.WriteLine(" │                                                                                                                                                                    │");// 35
            Console.WriteLine(" │                                                                                                                                                                    │");// 36
            Console.WriteLine(" │                                                                                                                                                                    │");// 37
            Console.WriteLine(" │                                                                                                                                                                    │");// 38
            Console.WriteLine(" │                                                                                                                                                                    │");// 39
            Console.WriteLine(" │                                                                                                                                                                    │");// 40
            Console.WriteLine(" │                                                                                                                                                                    │");// 41
            Console.WriteLine(" │                                                                                                                                                                    │");// 42
            Console.WriteLine(" |────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────|");// 43

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(70, 3);
            Console.Write("      ██             ██        ");
            Console.SetCursorPosition(70, 4);
            Console.Write("        ██         ██          ");
            Console.SetCursorPosition(70, 5);
            Console.Write("      ██████████████████       ");
            Console.SetCursorPosition(70, 6);
            Console.Write("    ██████████████████████     ");
            Console.SetCursorPosition(70, 7);
            Console.Write("  ████    ██████████    ████   ");
            Console.SetCursorPosition(70, 8);
            Console.Write("██████████████████████████████ ");
            Console.SetCursorPosition(70, 9);
            Console.Write("██   ████████████████████   ██ ");
            Console.SetCursorPosition(70, 10);
            Console.Write("██   ██                ██   ██ ");
            Console.SetCursorPosition(70, 11);
            Console.Write("       ████        ████        ");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(57, 13);
            Console.Write("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
            Console.SetCursorPosition(57, 14);
            Console.Write("█     (CITOLOGIA) O MATERIAL GENÉTICO DAS CÉLULAS É:    █");
            Console.SetCursorPosition(57, 15);
            Console.Write("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(12, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(12, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(12, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(12, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(12, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(12, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(12, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(12, 27);
            Console.Write(" ▀            ▀ ");
            // opção A
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(2, 29);
            Console.Write("—————————————————————————————————");
            Console.SetCursorPosition(2, 30);
            Console.Write("|          UMA PROTEÍNA         |");
            Console.SetCursorPosition(2, 31);
            Console.Write("—————————————————————————————————");
            // opção B
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(45, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(45, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(45, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(45, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(45, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(45, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(45, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(45, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(35, 29);
            Console.Write("—————————————————————————————————");
            Console.SetCursorPosition(35, 30);
            Console.Write("|            A GLICOSE          |");
            Console.SetCursorPosition(35, 31);
            Console.Write("—————————————————————————————————");
            // opção C
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(77, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(77, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(77, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(77, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(77, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(77, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(77, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(77, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(68, 29);
            Console.Write("———————————————————————————————————");
            Console.SetCursorPosition(68, 30);
            Console.Write("|   O ACIDD DESOXIRRIBONUCLEICO   |");
            Console.SetCursorPosition(68, 31);
            Console.Write("———————————————————————————————————");
            // opção D
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(109, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(109, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(109, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(109, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(109, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(109, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(109, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(109, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(103, 29);
            Console.Write("——————————————————————————————");
            Console.SetCursorPosition(103, 30);
            Console.Write("|             O RNA          |");
            Console.SetCursorPosition(103, 31);
            Console.Write("——————————————————————————————");
            // opção E

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(143, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(143, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(143, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(143, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(143, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(143, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(143, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(143, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(133, 29);
            Console.Write("—————————————————————————————————");
            Console.SetCursorPosition(133, 30);
            Console.Write("|        O ÁCIDO NUCLEICO       |");
            Console.SetCursorPosition(133, 31);
            Console.Write("—————————————————————————————————");
            Console.SetCursorPosition(2, 32);
            Console.Write("              (A)             ");

            Console.SetCursorPosition(38, 32);
            Console.Write("              (B)             ");

            Console.SetCursorPosition(71, 32);
            Console.Write("              (C)             ");

            Console.SetCursorPosition(102, 32);
            Console.Write("              (D)             ");

            Console.SetCursorPosition(134, 32);
            Console.Write("              (E)             ");
            Console.SetCursorPosition(34, 41);

            tecla = Console.ReadKey();


            switch (tecla.Key)
            {
                case ConsoleKey.A:
                    Perdeu();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.B:
                    Perdeu();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.C:
                    BioFase2();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.D:
                    Perdeu();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.E:
                    Perdeu();
                    break;

            }



        }
        static public void BioFase2()
        {

            ConsoleKeyInfo tecla;


            Console.Clear();
            Console.WriteLine(" ┌────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");// 1
            Console.WriteLine(" │                                                                                                                                                                    │");// 2
            Console.WriteLine(" │                                                                                                                                                                    │");// 3
            Console.WriteLine(" │                                                                                                                                                                    │");// 4
            Console.WriteLine(" │                                                                                                                                                                    │");// 5
            Console.WriteLine(" │                                                                                                                                                                    │");// 6
            Console.WriteLine(" │                                                                                                                                                                    │");// 7
            Console.WriteLine(" │                                                                                                                                                                    │");// 8
            Console.WriteLine(" │                                                                                                                                                                    │");// 9
            Console.WriteLine(" │                                                                                                                                                                    │");// 10
            Console.WriteLine(" │                                                                                                                                                                    │");// 11
            Console.WriteLine(" │                                                                                                                                                                    │");// 12
            Console.WriteLine(" │                                                                                                                                                                    │");// 13
            Console.WriteLine(" │                                                                                                                                                                    │");// 14
            Console.WriteLine(" │                                                                                                                                                                    │");// 15
            Console.WriteLine(" │                                                                                                                                                                    │");// 16
            Console.WriteLine(" │                                                                                                                                                                    │");// 17
            Console.WriteLine(" │                                                                                                                                                                    │");// 18
            Console.WriteLine(" │                                                                                                                                                                    │");// 19
            Console.WriteLine(" │                                                                                                                                                                    │");// 20
            Console.WriteLine(" │                                                                                                                                                                    │");// 21
            Console.WriteLine(" │                                                                                                                                                                    │");// 22
            Console.WriteLine(" │                                                                                                                                                                    │");// 23
            Console.WriteLine(" │                                                                                                                                                                    │");// 24
            Console.WriteLine(" │                                                                                                                                                                    │");// 25
            Console.WriteLine(" │                                                                                                                                                                    │");// 26
            Console.WriteLine(" │                                                                                                                                                                    │");// 27
            Console.WriteLine(" │                                                                                                                                                                    │");// 28
            Console.WriteLine(" │                                                                                                                                                                    │");// 29
            Console.WriteLine(" │                                                                                                                                                                    │");// 30
            Console.WriteLine(" │                                                                                                                                                                    │");// 31
            Console.WriteLine(" │                                                                                                                                                                    │");// 32
            Console.WriteLine(" │                                                                                                                                                                    │");// 33
            Console.WriteLine(" │                                                                                                                                                                    │");// 34
            Console.WriteLine(" │                                                                                                                                                                    │");// 35
            Console.WriteLine(" │                                                                                                                                                                    │");// 36
            Console.WriteLine(" │                                                                                                                                                                    │");// 37
            Console.WriteLine(" │                                                                                                                                                                    │");// 38
            Console.WriteLine(" │                                                                                                                                                                    │");// 39
            Console.WriteLine(" │                                                                                                                                                                    │");// 40
            Console.WriteLine(" │                                                                                                                                                                    │");// 41
            Console.WriteLine(" │                                                                                                                                                                    │");// 42
            Console.WriteLine(" |────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────|");// 43

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(70, 3);
            Console.Write("      ██             ██        ");
            Console.SetCursorPosition(70, 4);
            Console.Write("        ██         ██          ");
            Console.SetCursorPosition(70, 5);
            Console.Write("      ██████████████████       ");
            Console.SetCursorPosition(70, 6);
            Console.Write("    ██████████████████████     ");
            Console.SetCursorPosition(70, 7);
            Console.Write("  ████    ██████████    ████   ");
            Console.SetCursorPosition(70, 8);
            Console.Write("██████████████████████████████ ");
            Console.SetCursorPosition(70, 9);
            Console.Write("██   ████████████████████   ██ ");
            Console.SetCursorPosition(70, 10);
            Console.Write("██   ██                ██   ██ ");
            Console.SetCursorPosition(70, 11);
            Console.Write("       ████        ████        ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(50, 13);
            Console.Write("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
            Console.SetCursorPosition(50, 14);
            Console.Write("█      NA CÉLULA, A FUNÇÃO DA RESPIRAÇÃO CELULAR ESTA RESERVADA PARA:   █");
            Console.SetCursorPosition(50, 15);
            Console.Write("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(12, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(12, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(12, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(12, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(12, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(12, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(12, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(12, 27);
            Console.Write(" ▀            ▀ ");
            // opção A
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(2, 29);
            Console.Write("————————————————————————————————————");
            Console.SetCursorPosition(2, 30);
            Console.Write("|       O COMPLEXO DE GOLGI        |");
            Console.SetCursorPosition(2, 31);
            Console.Write("————————————————————————————————————");
            // opção B
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(45, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(45, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(45, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(45, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(45, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(45, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(45, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(45, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(38, 29);
            Console.Write("————————————————————————————————————");
            Console.SetCursorPosition(38, 30);
            Console.Write("|     O RETÍCULO ENDOPLASMÁTICO    |");
            Console.SetCursorPosition(38, 31);
            Console.Write("————————————————————————————————————");
            // opção C
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(77, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(77, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(77, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(77, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(77, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(77, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(77, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(77, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(71, 29);
            Console.Write("————————————————————————————————————");
            Console.SetCursorPosition(71, 30);
            Console.Write("|           O RIBOSSOMO             |");
            Console.SetCursorPosition(71, 31);
            Console.Write("————————————————————————————————————");
            // opção D
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(109, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(109, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(109, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(109, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(109, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(109, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(109, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(109, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(102, 29);
            Console.Write("————————————————————————————————————");
            Console.SetCursorPosition(102, 30);
            Console.Write("|           O LISOSSOMO            |");
            Console.SetCursorPosition(102, 31);
            Console.Write("————————————————————————————————————");
            // opção E

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(141, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(141, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(141, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(141, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(141, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(141, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(141, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(141, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(134, 29);
            Console.Write("——————————————————————————————");
            Console.SetCursorPosition(134, 30);
            Console.Write("|        AS MITÔCONDRIAS     |");
            Console.SetCursorPosition(134, 31);
            Console.Write("——————————————————————————————");
            Console.SetCursorPosition(2, 32);
            Console.Write("              (A)             ");

            Console.SetCursorPosition(38, 32);
            Console.Write("              (B)             ");

            Console.SetCursorPosition(71, 32);
            Console.Write("              (C)             ");

            Console.SetCursorPosition(102, 32);
            Console.Write("              (D)             ");

            Console.SetCursorPosition(134, 32);
            Console.Write("              (E)             ");
            Console.SetCursorPosition(34, 41);

            tecla = Console.ReadKey();


            switch (tecla.Key)
            {
                case ConsoleKey.A:
                    Perdeu();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.B:
                    Perdeu();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.C:
                    Perdeu();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.D:
                    Perdeu();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.E:
                    BioFase3();
                    break;

            }

        


        }
        static public void BioFase3()
        {

            ConsoleKeyInfo tecla;


            Console.Clear();
            Console.WriteLine(" ┌────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");// 1
            Console.WriteLine(" │                                                                                                                                                                    │");// 2
            Console.WriteLine(" │                                                                                                                                                                    │");// 3
            Console.WriteLine(" │                                                                                                                                                                    │");// 4
            Console.WriteLine(" │                                                                                                                                                                    │");// 5
            Console.WriteLine(" │                                                                                                                                                                    │");// 6
            Console.WriteLine(" │                                                                                                                                                                    │");// 7
            Console.WriteLine(" │                                                                                                                                                                    │");// 8
            Console.WriteLine(" │                                                                                                                                                                    │");// 9
            Console.WriteLine(" │                                                                                                                                                                    │");// 10
            Console.WriteLine(" │                                                                                                                                                                    │");// 11
            Console.WriteLine(" │                                                                                                                                                                    │");// 12
            Console.WriteLine(" │                                                                                                                                                                    │");// 13
            Console.WriteLine(" │                                                                                                                                                                    │");// 14
            Console.WriteLine(" │                                                                                                                                                                    │");// 15
            Console.WriteLine(" │                                                                                                                                                                    │");// 16
            Console.WriteLine(" │                                                                                                                                                                    │");// 17
            Console.WriteLine(" │                                                                                                                                                                    │");// 18
            Console.WriteLine(" │                                                                                                                                                                    │");// 19
            Console.WriteLine(" │                                                                                                                                                                    │");// 20
            Console.WriteLine(" │                                                                                                                                                                    │");// 21
            Console.WriteLine(" │                                                                                                                                                                    │");// 22
            Console.WriteLine(" │                                                                                                                                                                    │");// 23
            Console.WriteLine(" │                                                                                                                                                                    │");// 24
            Console.WriteLine(" │                                                                                                                                                                    │");// 25
            Console.WriteLine(" │                                                                                                                                                                    │");// 26
            Console.WriteLine(" │                                                                                                                                                                    │");// 27
            Console.WriteLine(" │                                                                                                                                                                    │");// 28
            Console.WriteLine(" │                                                                                                                                                                    │");// 29
            Console.WriteLine(" │                                                                                                                                                                    │");// 30
            Console.WriteLine(" │                                                                                                                                                                    │");// 31
            Console.WriteLine(" │                                                                                                                                                                    │");// 32
            Console.WriteLine(" │                                                                                                                                                                    │");// 33
            Console.WriteLine(" │                                                                                                                                                                    │");// 34
            Console.WriteLine(" │                                                                                                                                                                    │");// 35
            Console.WriteLine(" │                                                                                                                                                                    │");// 36
            Console.WriteLine(" │                                                                                                                                                                    │");// 37
            Console.WriteLine(" │                                                                                                                                                                    │");// 38
            Console.WriteLine(" │                                                                                                                                                                    │");// 39
            Console.WriteLine(" │                                                                                                                                                                    │");// 40
            Console.WriteLine(" │                                                                                                                                                                    │");// 41
            Console.WriteLine(" │                                                                                                                                                                    │");// 42
            Console.WriteLine(" |────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────|");// 43  do

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(69, 3);
            Console.Write("      ██             ██        ");
            Console.SetCursorPosition(69, 4);
            Console.Write("        ██         ██          ");
            Console.SetCursorPosition(69, 5);
            Console.Write("      ██████████████████       ");
            Console.SetCursorPosition(69, 6);
            Console.Write("    ██████████████████████     ");
            Console.SetCursorPosition(69, 7);
            Console.Write("  ████    ██████████    ████   ");
            Console.SetCursorPosition(69, 8);
            Console.Write("██████████████████████████████ ");
            Console.SetCursorPosition(69, 9);
            Console.Write("██   ████████████████████   ██ ");
            Console.SetCursorPosition(69, 10);
            Console.Write("██   ██                ██   ██ ");
            Console.SetCursorPosition(69, 11);
            Console.Write("       ████        ████        ");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(30, 13);
            Console.Write("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
            Console.SetCursorPosition(30, 14);
            Console.Write("█      EM UMA CÉLULA ESPECIALIZADA NA PRODUÇÃO DE ENERGIA, É POSSIVEL QUE SE ENCONTRE GRANDE NÚMEMRO DE:   █");
            Console.SetCursorPosition(30, 15);
            Console.Write("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(12, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(12, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(12, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(12, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(12, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(12, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(12, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(12, 27);
            Console.Write(" ▀            ▀ ");
            // opção A
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(2, 29);
            Console.Write("————————————————————————————————————");
            Console.SetCursorPosition(2, 30);
            Console.Write("|            RIBOSSOMO             |");
            Console.SetCursorPosition(2, 31);
            Console.Write("————————————————————————————————————");
            // opção B
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(45, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(45, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(45, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(45, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(45, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(45, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(45, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(45, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(38, 29);
            Console.Write("————————————————————————————————————");
            Console.SetCursorPosition(38, 30);
            Console.Write("|              LISOSSOMO           |");
            Console.SetCursorPosition(38, 31);
            Console.Write("————————————————————————————————————");
            // opção C
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(77, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(77, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(77, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(77, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(77, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(77, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(77, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(77, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(71, 29);
            Console.Write("————————————————————————————————————");
            Console.SetCursorPosition(71, 30);
            Console.Write("|       COMPLEXO DE GOLGIENSE      |");
            Console.SetCursorPosition(71, 31);
            Console.Write("————————————————————————————————————");
            // opção D
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(109, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(109, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(109, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(109, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(109, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(109, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(109, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(109, 27);
            Console.Write(" ▀            ▀ ");  
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(102, 29);
            Console.Write("————————————————————————————————————");
            Console.SetCursorPosition(102, 30);
            Console.Write("|             NUCLEOIDES           |");
            Console.SetCursorPosition(102, 31);
            Console.Write("————————————————————————————————————");
            // opção E

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(143, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(143, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(143, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(143, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(143, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(143, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(143, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(143, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(134, 29);
            Console.Write("————————————————————————————————");
            Console.SetCursorPosition(134, 30);
            Console.Write("|          MITOCÔNDRIAS        |");
            Console.SetCursorPosition(134, 31);
            Console.Write("————————————————————————————————");
            Console.SetCursorPosition(2, 32);
            Console.Write("              (A)             ");

            Console.SetCursorPosition(38, 32);
            Console.Write("              (B)             ");

            Console.SetCursorPosition(71, 32);
            Console.Write("              (C)             ");

            Console.SetCursorPosition(102, 32);
            Console.Write("              (D)             ");

            Console.SetCursorPosition(134, 32);
            Console.Write("              (E)             ");
            Console.SetCursorPosition(34, 41);

            tecla = Console.ReadKey();


            switch (tecla.Key)
            {
                case ConsoleKey.A:
                    Perdeu();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.B:
                    Perdeu();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.C:
                    Perdeu();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.D:
                    Perdeu();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.E:
                    BioFase4();
                    break;

            }

            

        }
        static public void BioFase4()
        {

            ConsoleKeyInfo tecla;


            Console.Clear();
            Console.WriteLine(" ┌────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");// 1
            Console.WriteLine(" │                                                                                                                                                                    │");// 2
            Console.WriteLine(" │                                                                                                                                                                    │");// 3
            Console.WriteLine(" │                                                                                                                                                                    │");// 4
            Console.WriteLine(" │                                                                                                                                                                    │");// 5
            Console.WriteLine(" │                                                                                                                                                                    │");// 6
            Console.WriteLine(" │                                                                                                                                                                    │");// 7
            Console.WriteLine(" │                                                                                                                                                                    │");// 8
            Console.WriteLine(" │                                                                                                                                                                    │");// 9
            Console.WriteLine(" │                                                                                                                                                                    │");// 10
            Console.WriteLine(" │                                                                                                                                                                    │");// 11
            Console.WriteLine(" │                                                                                                                                                                    │");// 12
            Console.WriteLine(" │                                                                                                                                                                    │");// 13
            Console.WriteLine(" │                                                                                                                                                                    │");// 14
            Console.WriteLine(" │                                                                                                                                                                    │");// 15
            Console.WriteLine(" │                                                                                                                                                                    │");// 16
            Console.WriteLine(" │                                                                                                                                                                    │");// 17
            Console.WriteLine(" │                                                                                                                                                                    │");// 18
            Console.WriteLine(" │                                                                                                                                                                    │");// 19
            Console.WriteLine(" │                                                                                                                                                                    │");// 20
            Console.WriteLine(" │                                                                                                                                                                    │");// 21
            Console.WriteLine(" │                                                                                                                                                                    │");// 22
            Console.WriteLine(" │                                                                                                                                                                    │");// 23
            Console.WriteLine(" │                                                                                                                                                                    │");// 24
            Console.WriteLine(" │                                                                                                                                                                    │");// 25
            Console.WriteLine(" │                                                                                                                                                                    │");// 26
            Console.WriteLine(" │                                                                                                                                                                    │");// 27
            Console.WriteLine(" │                                                                                                                                                                    │");// 28
            Console.WriteLine(" │                                                                                                                                                                    │");// 29
            Console.WriteLine(" │                                                                                                                                                                    │");// 30
            Console.WriteLine(" │                                                                                                                                                                    │");// 31
            Console.WriteLine(" │                                                                                                                                                                    │");// 32
            Console.WriteLine(" │                                                                                                                                                                    │");// 33
            Console.WriteLine(" │                                                                                                                                                                    │");// 34
            Console.WriteLine(" │                                                                                                                                                                    │");// 35
            Console.WriteLine(" │                                                                                                                                                                    │");// 36
            Console.WriteLine(" │                                                                                                                                                                    │");// 37
            Console.WriteLine(" │                                                                                                                                                                    │");// 38
            Console.WriteLine(" │                                                                                                                                                                    │");// 39
            Console.WriteLine(" │                                                                                                                                                                    │");// 40
            Console.WriteLine(" │                                                                                                                                                                    │");// 41
            Console.WriteLine(" │                                                                                                                                                                    │");// 42
            Console.WriteLine(" |────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────|");// 43
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(69, 3);
            Console.Write("      ██             ██        ");
            Console.SetCursorPosition(69, 4);
            Console.Write("        ██         ██          ");
            Console.SetCursorPosition(69, 5);
            Console.Write("      ██████████████████       ");
            Console.SetCursorPosition(69, 6);
            Console.Write("    ██████████████████████     ");
            Console.SetCursorPosition(69, 7);
            Console.Write("  ████    ██████████    ████   ");
            Console.SetCursorPosition(69, 8);
            Console.Write("██████████████████████████████ ");
            Console.SetCursorPosition(69, 9);
            Console.Write("██   ████████████████████   ██ ");
            Console.SetCursorPosition(69, 10);
            Console.Write("██   ██                ██   ██ ");
            Console.SetCursorPosition(69, 11);
            Console.Write("       ████        ████        ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(53, 13);
            Console.Write("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
            Console.SetCursorPosition(53, 14);
            Console.Write("█     OS CENTRÍOLOS EXERCEM FUNÇÕES IMPORTANTES NO PROCESSO DE:   █");
            Console.SetCursorPosition(53, 15);
            Console.Write("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");


            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(12, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(12, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(12, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(12, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(12, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(12, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(12, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(12, 27);
            Console.Write(" ▀            ▀ ");
            // opção A
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(2, 29);
            Console.Write("————————————————————————————————————");
            Console.SetCursorPosition(2, 30);
            Console.Write("|      DIGESTÃO INTRACELULAR       |");
            Console.SetCursorPosition(2, 31);
            Console.Write("————————————————————————————————————");
            // opção B

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(45, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(45, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(45, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(45, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(45, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(45, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(45, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(45, 27);
            Console.Write(" ▀            ▀ ");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(38, 29);
            Console.Write("————————————————————————————————————");
            Console.SetCursorPosition(38, 30);
            Console.Write("|     SECRECÃO DE SUBSTÂNCIAS      |");
            Console.SetCursorPosition(38, 31);
            Console.Write("————————————————————————————————————");
            // opção C
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.SetCursorPosition(77, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(77, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(77, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(77, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(77, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(77, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(77, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(77, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(71, 29);
            Console.Write("————————————————————————————————————");
            Console.SetCursorPosition(71, 30);
            Console.Write("|    TRANSPORTE INTRACELULAR       |");
            Console.SetCursorPosition(71, 31);
            Console.Write("————————————————————————————————————");
            // opção D
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(109, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(109, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(109, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(109, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(109, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(109, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(109, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(109, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(102, 29);
            Console.Write("————————————————————————————————————");
            Console.SetCursorPosition(102, 30);
            Console.Write("|         DIVISÃO CELULAR          |");
            Console.SetCursorPosition(102, 31);
            Console.Write("————————————————————————————————————");
            // opção E
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(143, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(143, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(143, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(143, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(143, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(143, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(143, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(143, 27);
            Console.Write(" ▀            ▀ ");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(134, 29);
            Console.Write("————————————————————————————————");
            Console.SetCursorPosition(134, 30);
            Console.Write("|       RESPIRAÇÃO CELULAR     |");
            Console.SetCursorPosition(134, 31);
            Console.Write("————————————————————————————————");
            Console.SetCursorPosition(2, 32);
            Console.Write("              (A)             ");

            Console.SetCursorPosition(38, 32);
            Console.Write("              (B)             ");

            Console.SetCursorPosition(71, 32);
            Console.Write("              (C)             ");

            Console.SetCursorPosition(102, 32);
            Console.Write("              (D)             ");

            Console.SetCursorPosition(134, 32);
            Console.Write("              (E)             ");
            Console.SetCursorPosition(34, 41);

            tecla = Console.ReadKey();


            switch (tecla.Key)
            {
                case ConsoleKey.A:
                    Perdeu();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.B:
                    Perdeu();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.C:
                    Perdeu();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.D:
                    BioFase5();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.E:
                    Perdeu();
                    break;

            }

           


        }
        static public void BioFase5()
        {

            ConsoleKeyInfo tecla;


            Console.Clear();
            Console.WriteLine(" ┌────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");// 1
            Console.WriteLine(" │                                                                                                                                                                    │");// 2
            Console.WriteLine(" │                                                                                                                                                                    │");// 3
            Console.WriteLine(" │                                                                                                                                                                    │");// 4
            Console.WriteLine(" │                                                                                                                                                                    │");// 5
            Console.WriteLine(" │                                                                                                                                                                    │");// 6
            Console.WriteLine(" │                                                                                                                                                                    │");// 7
            Console.WriteLine(" │                                                                                                                                                                    │");// 8
            Console.WriteLine(" │                                                                                                                                                                    │");// 9
            Console.WriteLine(" │                                                                                                                                                                    │");// 10
            Console.WriteLine(" │                                                                                                                                                                    │");// 11
            Console.WriteLine(" │                                                                                                                                                                    │");// 12
            Console.WriteLine(" │                                                                                                                                                                    │");// 13
            Console.WriteLine(" │                                                                                                                                                                    │");// 14
            Console.WriteLine(" │                                                                                                                                                                    │");// 15
            Console.WriteLine(" │                                                                                                                                                                    │");// 16
            Console.WriteLine(" │                                                                                                                                                                    │");// 17
            Console.WriteLine(" │                                                                                                                                                                    │");// 18
            Console.WriteLine(" │                                                                                                                                                                    │");// 19
            Console.WriteLine(" │                                                                                                                                                                    │");// 20
            Console.WriteLine(" │                                                                                                                                                                    │");// 21
            Console.WriteLine(" │                                                                                                                                                                    │");// 22
            Console.WriteLine(" │                                                                                                                                                                    │");// 23
            Console.WriteLine(" │                                                                                                                                                                    │");// 24
            Console.WriteLine(" │                                                                                                                                                                    │");// 25
            Console.WriteLine(" │                                                                                                                                                                    │");// 26
            Console.WriteLine(" │                                                                                                                                                                    │");// 27
            Console.WriteLine(" │                                                                                                                                                                    │");// 28
            Console.WriteLine(" │                                                                                                                                                                    │");// 29
            Console.WriteLine(" │                                                                                                                                                                    │");// 30
            Console.WriteLine(" │                                                                                                                                                                    │");// 31
            Console.WriteLine(" │                                                                                                                                                                    │");// 32
            Console.WriteLine(" │                                                                                                                                                                    │");// 33
            Console.WriteLine(" │                                                                                                                                                                    │");// 34
            Console.WriteLine(" │                                                                                                                                                                    │");// 35
            Console.WriteLine(" │                                                                                                                                                                    │");// 36
            Console.WriteLine(" │                                                                                                                                                                    │");// 37
            Console.WriteLine(" │                                                                                                                                                                    │");// 38
            Console.WriteLine(" │                                                                                                                                                                    │");// 39
            Console.WriteLine(" │                                                                                                                                                                    │");// 40
            Console.WriteLine(" │                                                                                                                                                                    │");// 41
            Console.WriteLine(" │                                                                                                                                                                    │");// 42
            Console.WriteLine(" |────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────|");// 43
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(69, 3);
            Console.Write("      ██             ██        ");
            Console.SetCursorPosition(69, 4);
            Console.Write("        ██         ██          ");
            Console.SetCursorPosition(69, 5);
            Console.Write("      ██████████████████       ");
            Console.SetCursorPosition(69, 6);
            Console.Write("    ██████████████████████     ");
            Console.SetCursorPosition(69, 7);
            Console.Write("  ████    ██████████    ████   ");
            Console.SetCursorPosition(69, 8);
            Console.Write("██████████████████████████████ ");
            Console.SetCursorPosition(69, 9);
            Console.Write("██   ████████████████████   ██ ");
            Console.SetCursorPosition(69, 10);
            Console.Write("██   ██                ██   ██ ");
            Console.SetCursorPosition(69, 11);
            Console.Write("       ████        ████        ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(45, 13);
            Console.Write("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
            Console.SetCursorPosition(45, 14);
            Console.Write("█   O DESCOBRIMENTO DA CÉLULA VEIO EM 1669 POR UM IMPORNTANTE CIENTISTA.QUAL?  █");
            Console.SetCursorPosition(45, 15);
            Console.Write("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(12, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(12, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(12, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(12, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(12, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(12, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(12, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(12, 27);
            Console.Write(" ▀            ▀ ");
            // opção A
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(2, 29);
            Console.Write("————————————————————————————————————");
            Console.SetCursorPosition(2, 30);
            Console.Write("|         Albert Einstein          |");
            Console.SetCursorPosition(2, 31);
            Console.Write("————————————————————————————————————");
            // opção B
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(45, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(45, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(45, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(45, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(45, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(45, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(45, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(45, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(38, 29);
            Console.Write("————————————————————————————————————");
            Console.SetCursorPosition(38, 30);
            Console.Write("|        Galileu Galilei           |");
            Console.SetCursorPosition(38, 31);
            Console.Write("————————————————————————————————————");
            // opção C

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.SetCursorPosition(77, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(77, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(77, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(77, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(77, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(77, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(77, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(77, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(71, 29);
            Console.Write("————————————————————————————————————");
            Console.SetCursorPosition(71, 30);
            Console.Write("|          Robert Hooke            |");
            Console.SetCursorPosition(71, 31);
            Console.Write("————————————————————————————————————");
            // opção D

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(109, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(109, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(109, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(109, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(109, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(109, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(109, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(109, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(102, 29);
            Console.Write("————————————————————————————————————");
            Console.SetCursorPosition(102, 30);
            Console.Write("|           Louis Pasteur          |");
            Console.SetCursorPosition(102, 31);
            Console.Write("————————————————————————————————————");
            // opção E
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(143, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(143, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(143, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(143, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(143, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(143, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(143, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(143, 27);
            Console.Write(" ▀            ▀ ");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(134, 29);
            Console.Write("————————————————————————————————");
            Console.SetCursorPosition(134, 30);
            Console.Write("|       Francesco Redi         |");
            Console.SetCursorPosition(134, 31);
            Console.Write("————————————————————————————————");
            Console.SetCursorPosition(2, 32);
            Console.Write("              (A)             ");

            Console.SetCursorPosition(38, 32);
            Console.Write("              (B)             ");

            Console.SetCursorPosition(71, 32);
            Console.Write("              (C)             ");

            Console.SetCursorPosition(102, 32);
            Console.Write("              (D)             ");

            Console.SetCursorPosition(134, 32);
            Console.Write("              (E)             ");
            Console.SetCursorPosition(34, 41);

            tecla = Console.ReadKey();


            switch (tecla.Key)
            {
                case ConsoleKey.A:
                    Perdeu();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.B:
                    Perdeu();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.C:
                    Parabens();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.D:
                    Perdeu();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.E:
                    Perdeu();
                    break;

            }

       
        }
        //____________________________________________________QUIZ DE HISTÓRIA__________________________________________________________
        static public void HisFase()
        {

            ConsoleKeyInfo tecla;


            Console.Clear();
            Console.WriteLine(" ┌────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");// 1
            Console.WriteLine(" │                                                                                                                                                                    │");// 2
            Console.WriteLine(" │                                                                                                                                                                    │");// 3
            Console.WriteLine(" │                                                                                                                                                                    │");// 4
            Console.WriteLine(" │                                                                                                                                                                    │");// 5
            Console.WriteLine(" │                                                                                                                                                                    │");// 6
            Console.WriteLine(" │                                                                                                                                                                    │");// 7
            Console.WriteLine(" │                                                                                                                                                                    │");// 8
            Console.WriteLine(" │                                                                                                                                                                    │");// 9
            Console.WriteLine(" │                                                                                                                                                                    │");// 10
            Console.WriteLine(" │                                                                                                                                                                    │");// 11
            Console.WriteLine(" │                                                                                                                                                                    │");// 12
            Console.WriteLine(" │                                                                                                                                                                    │");// 13
            Console.WriteLine(" │                                                                                                                                                                    │");// 14
            Console.WriteLine(" │                                                                                                                                                                    │");// 15
            Console.WriteLine(" │                                                                                                                                                                    │");// 16
            Console.WriteLine(" │                                                                                                                                                                    │");// 17
            Console.WriteLine(" │                                                                                                                                                                    │");// 18
            Console.WriteLine(" │                                                                                                                                                                    │");// 19
            Console.WriteLine(" │                                                                                                                                                                    │");// 20
            Console.WriteLine(" │                                                                                                                                                                    │");// 21
            Console.WriteLine(" │                                                                                                                                                                    │");// 22
            Console.WriteLine(" │                                                                                                                                                                    │");// 23
            Console.WriteLine(" │                                                                                                                                                                    │");// 24
            Console.WriteLine(" │                                                                                                                                                                    │");// 25
            Console.WriteLine(" │                                                                                                                                                                    │");// 26
            Console.WriteLine(" │                                                                                                                                                                    │");// 27
            Console.WriteLine(" │                                                                                                                                                                    │");// 28
            Console.WriteLine(" │                                                                                                                                                                    │");// 29
            Console.WriteLine(" │                                                                                                                                                                    │");// 30
            Console.WriteLine(" │                                                                                                                                                                    │");// 31
            Console.WriteLine(" │                                                                                                                                                                    │");// 32
            Console.WriteLine(" │                                                                                                                                                                    │");// 33
            Console.WriteLine(" │                                                                                                                                                                    │");// 34
            Console.WriteLine(" │                                                                                                                                                                    │");// 35
            Console.WriteLine(" │                                                                                                                                                                    │");// 36
            Console.WriteLine(" │                                                                                                                                                                    │");// 37
            Console.WriteLine(" │                                                                                                                                                                    │");// 38
            Console.WriteLine(" │                                                                                                                                                                    │");// 39
            Console.WriteLine(" │                                                                                                                                                                    │");// 40
            Console.WriteLine(" │                                                                                                                                                                    │");// 41
            Console.WriteLine(" │                                                                                                                                                                    │");// 42
            Console.WriteLine(" |────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────|");// 43
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(69, 3);
            Console.Write("      ██             ██        ");
            Console.SetCursorPosition(69, 4);
            Console.Write("        ██         ██          ");
            Console.SetCursorPosition(69, 5);
            Console.Write("      ██████████████████       ");
            Console.SetCursorPosition(69, 6);
            Console.Write("    ██████████████████████     ");
            Console.SetCursorPosition(69, 7);
            Console.Write("  ████    ██████████    ████   ");
            Console.SetCursorPosition(69, 8);
            Console.Write("██████████████████████████████ ");
            Console.SetCursorPosition(69, 9);
            Console.Write("██   ████████████████████   ██ ");
            Console.SetCursorPosition(69, 10);
            Console.Write("██   ██                ██   ██ ");
            Console.SetCursorPosition(69, 11);
            Console.Write("       ████        ████        ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.SetCursorPosition(57, 13);
        Console.Write("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
        Console.SetCursorPosition(57, 14);
        Console.Write("█     QUAL FOI O ESTOPIM DA PRIMEIRA GUERRA MUNDIAL?  █");
        Console.SetCursorPosition(57, 15);
        Console.Write("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(12, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(12, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(12, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(12, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(12, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(12, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(12, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(12, 27);
            Console.Write(" ▀            ▀ ");
            // opção A
            Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.SetCursorPosition(2, 29);
        Console.Write("——————————————————————————————————————————");
            Console.SetCursorPosition(2, 30);
        Console.Write("|   Assassinato de Francisco Ferdinando  |");
        Console.SetCursorPosition(2, 31);
        Console.Write("——————————————————————————————————————————");
            // opção B
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(45, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(45, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(45, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(45, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(45, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(45, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(45, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(45, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.SetCursorPosition(38, 29);
        Console.Write("——————————————————————————————————————————");
            Console.SetCursorPosition(38, 30);
        Console.Write("|           Revanchismo francês          |");
        Console.SetCursorPosition(38, 31);
        Console.Write("——————————————————————————————————————————");
            // opção C
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.SetCursorPosition(77, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(77, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(77, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(77, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(77, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(77, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(77, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(77, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(71, 29);
            Console.Write("——————————————————————————————————————————");
            Console.SetCursorPosition(71, 30);
            Console.Write("|         Questão balcânica              |");
            Console.SetCursorPosition(71, 31);
            Console.Write("——————————————————————————————————————————");
            // opção D
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(109, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(109, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(109, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(109, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(109, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(109, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(109, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(109, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(102, 29);
            Console.Write("——————————————————————————————————————————————————");
            Console.SetCursorPosition(102, 30);
            Console.Write("|Disputas comerciais entre Alemanha e Reino Unido|");
            Console.SetCursorPosition(102, 31);
            Console.Write("——————————————————————————————————————————————————");
            // opção E

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(143, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(143, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(143, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(143, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(143, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(143, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(143, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(143, 27);
            Console.Write(" ▀            ▀ ");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(134, 29);
            Console.Write("————————————————————————————————");
            Console.SetCursorPosition(134, 30);
            Console.Write("|          N.D.A               |");
            Console.SetCursorPosition(134, 31);
            Console.Write("————————————————————————————————");
            Console.SetCursorPosition(2, 32);
            Console.Write("              (A)             ");

            Console.SetCursorPosition(38, 32);
            Console.Write("              (B)             ");

            Console.SetCursorPosition(71, 32);
            Console.Write("              (C)             ");

            Console.SetCursorPosition(102, 32);
            Console.Write("              (D)             ");

            Console.SetCursorPosition(134, 32);
            Console.Write("              (E)             ");
            Console.SetCursorPosition(34, 41);

            tecla = Console.ReadKey();


            switch (tecla.Key)
            {
                case ConsoleKey.A:
                    HisFase2();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.B:
                    Perdeu();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.C:
                    Perdeu();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.D:
                    Perdeu();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.E:
                    Perdeu();
                    break;

            }



            }
            static public void HisFase2()
            {

                ConsoleKeyInfo tecla;


                Console.Clear();
                Console.WriteLine(" ┌────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");// 1
                Console.WriteLine(" │                                                                                                                                                                    │");// 2
                Console.WriteLine(" │                                                                                                                                                                    │");// 3
                Console.WriteLine(" │                                                                                                                                                                    │");// 4
                Console.WriteLine(" │                                                                                                                                                                    │");// 5
                Console.WriteLine(" │                                                                                                                                                                    │");// 6
                Console.WriteLine(" │                                                                                                                                                                    │");// 7
                Console.WriteLine(" │                                                                                                                                                                    │");// 8
                Console.WriteLine(" │                                                                                                                                                                    │");// 9
                Console.WriteLine(" │                                                                                                                                                                    │");// 10
                Console.WriteLine(" │                                                                                                                                                                    │");// 11
                Console.WriteLine(" │                                                                                                                                                                    │");// 12
                Console.WriteLine(" │                                                                                                                                                                    │");// 13
                Console.WriteLine(" │                                                                                                                                                                    │");// 14
                Console.WriteLine(" │                                                                                                                                                                    │");// 15
                Console.WriteLine(" │                                                                                                                                                                    │");// 16
                Console.WriteLine(" │                                                                                                                                                                    │");// 17
                Console.WriteLine(" │                                                                                                                                                                    │");// 18
                Console.WriteLine(" │                                                                                                                                                                    │");// 19
                Console.WriteLine(" │                                                                                                                                                                    │");// 20
                Console.WriteLine(" │                                                                                                                                                                    │");// 21
                Console.WriteLine(" │                                                                                                                                                                    │");// 22
                Console.WriteLine(" │                                                                                                                                                                    │");// 23
                Console.WriteLine(" │                                                                                                                                                                    │");// 24
                Console.WriteLine(" │                                                                                                                                                                    │");// 25
                Console.WriteLine(" │                                                                                                                                                                    │");// 26
                Console.WriteLine(" │                                                                                                                                                                    │");// 27
                Console.WriteLine(" │                                                                                                                                                                    │");// 28
                Console.WriteLine(" │                                                                                                                                                                    │");// 29
                Console.WriteLine(" │                                                                                                                                                                    │");// 30
                Console.WriteLine(" │                                                                                                                                                                    │");// 31
                Console.WriteLine(" │                                                                                                                                                                    │");// 32
                Console.WriteLine(" │                                                                                                                                                                    │");// 33
                Console.WriteLine(" │                                                                                                                                                                    │");// 34
                Console.WriteLine(" │                                                                                                                                                                    │");// 35
                Console.WriteLine(" │                                                                                                                                                                    │");// 36
                Console.WriteLine(" │                                                                                                                                                                    │");// 37
                Console.WriteLine(" │                                                                                                                                                                    │");// 38
                Console.WriteLine(" │                                                                                                                                                                    │");// 39
                Console.WriteLine(" │                                                                                                                                                                    │");// 40
                Console.WriteLine(" │                                                                                                                                                                    │");// 41
                Console.WriteLine(" │                                                                                                                                                                    │");// 42
                Console.WriteLine(" |────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────|");// 43
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(69, 3);
            Console.Write("      ██             ██        ");
            Console.SetCursorPosition(69, 4);
            Console.Write("        ██         ██          ");
            Console.SetCursorPosition(69, 5);
            Console.Write("      ██████████████████       ");
            Console.SetCursorPosition(69, 6);
            Console.Write("    ██████████████████████     ");
            Console.SetCursorPosition(69, 7);
            Console.Write("  ████    ██████████    ████   ");
            Console.SetCursorPosition(69, 8);
            Console.Write("██████████████████████████████ ");
            Console.SetCursorPosition(69, 9);
            Console.Write("██   ████████████████████   ██ ");
            Console.SetCursorPosition(69, 10);
            Console.Write("██   ██                ██   ██ ");
            Console.SetCursorPosition(69, 11);
            Console.Write("       ████        ████        ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(57, 13);
            Console.Write("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
            Console.SetCursorPosition(57, 14);
            Console.Write("█      ONDE O CORPO DOS FARAÓS ERAM COLOCADOS?   █");
            Console.SetCursorPosition(57, 15);
            Console.Write("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█ ");



            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(12, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(12, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(12, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(12, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(12, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(12, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(12, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(12, 27);
            Console.Write(" ▀            ▀ ");

            // opção A
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(2, 29);
            Console.Write("——————————————————————————————————————————");
            Console.SetCursorPosition(2, 30);
            Console.Write("|             Pirâmides                  |");
            Console.SetCursorPosition(2, 31);
            Console.Write("——————————————————————————————————————————");
            // opção B
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(45, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(45, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(45, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(45, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(45, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(45, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(45, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(45, 27);
            Console.Write(" ▀            ▀ ");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(38, 29);
            Console.Write("——————————————————————————————————————————");
            Console.SetCursorPosition(38, 30);
            Console.Write("|                Mastabas                |");
            Console.SetCursorPosition(38, 31);
            Console.Write("——————————————————————————————————————————");
            // opção C

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.SetCursorPosition(77, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(77, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(77, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(77, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(77, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(77, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(77, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(77, 27);
            Console.Write(" ▀            ▀ ");
    
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(71, 29);
            Console.Write("——————————————————————————————————————————");
            Console.SetCursorPosition(71, 30);
            Console.Write("|                 Sarcófago              |");
            Console.SetCursorPosition(71, 31);
            Console.Write("——————————————————————————————————————————");
            // opção D
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(109, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(109, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(109, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(109, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(109, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(109, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(109, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(109, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(102, 29);
            Console.Write("——————————————————————————————————————————");
            Console.SetCursorPosition(102, 30);
            Console.Write("|            Túneis subterrâneos         |");
            Console.SetCursorPosition(102, 31);
            Console.Write("——————————————————————————————————————————");
            // opção E


            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(143, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(143, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(143, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(143, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(143, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(143, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(143, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(143, 27);
            Console.Write(" ▀            ▀ ");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(134, 29);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(134, 30);
            Console.Write("|              Casas          | ");
            Console.SetCursorPosition(134, 31);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(2, 32);
            Console.Write("              (A)             ");

            Console.SetCursorPosition(38, 32);
            Console.Write("              (B)             ");

            Console.SetCursorPosition(71, 32);
            Console.Write("              (C)             ");

            Console.SetCursorPosition(102, 32);
            Console.Write("              (D)             ");

            Console.SetCursorPosition(134, 32);
            Console.Write("              (E)             ");
            Console.SetCursorPosition(34, 41);

            tecla = Console.ReadKey();


            switch (tecla.Key)
            {
                case ConsoleKey.A:
                    HisFase3();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.B:
                    Perdeu();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.C:
                    Perdeu();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.D:
                    Perdeu();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.E:
                    Perdeu();
                    break;

            }



            }
            static public void HisFase3()
            {

                ConsoleKeyInfo tecla;


                Console.Clear();
                Console.WriteLine(" ┌────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");// 1
                Console.WriteLine(" │                                                                                                                                                                    │");// 2
                Console.WriteLine(" │                                                                                                                                                                    │");// 3
                Console.WriteLine(" │                                                                                                                                                                    │");// 4
                Console.WriteLine(" │                                                                                                                                                                    │");// 5
                Console.WriteLine(" │                                                                                                                                                                    │");// 6
                Console.WriteLine(" │                                                                                                                                                                    │");// 7
                Console.WriteLine(" │                                                                                                                                                                    │");// 8
                Console.WriteLine(" │                                                                                                                                                                    │");// 9
                Console.WriteLine(" │                                                                                                                                                                    │");// 10
                Console.WriteLine(" │                                                                                                                                                                    │");// 11
                Console.WriteLine(" │                                                                                                                                                                    │");// 12
                Console.WriteLine(" │                                                                                                                                                                    │");// 13
                Console.WriteLine(" │                                                                                                                                                                    │");// 14
                Console.WriteLine(" │                                                                                                                                                                    │");// 15
                Console.WriteLine(" │                                                                                                                                                                    │");// 16
                Console.WriteLine(" │                                                                                                                                                                    │");// 17
                Console.WriteLine(" │                                                                                                                                                                    │");// 18
                Console.WriteLine(" │                                                                                                                                                                    │");// 19
                Console.WriteLine(" │                                                                                                                                                                    │");// 20
                Console.WriteLine(" │                                                                                                                                                                    │");// 21
                Console.WriteLine(" │                                                                                                                                                                    │");// 22
                Console.WriteLine(" │                                                                                                                                                                    │");// 23
                Console.WriteLine(" │                                                                                                                                                                    │");// 24
                Console.WriteLine(" │                                                                                                                                                                    │");// 25
                Console.WriteLine(" │                                                                                                                                                                    │");// 26
                Console.WriteLine(" │                                                                                                                                                                    │");// 27
                Console.WriteLine(" │                                                                                                                                                                    │");// 28
                Console.WriteLine(" │                                                                                                                                                                    │");// 29
                Console.WriteLine(" │                                                                                                                                                                    │");// 30
                Console.WriteLine(" │                                                                                                                                                                    │");// 31
                Console.WriteLine(" │                                                                                                                                                                    │");// 32
                Console.WriteLine(" │                                                                                                                                                                    │");// 33
                Console.WriteLine(" │                                                                                                                                                                    │");// 34
                Console.WriteLine(" │                                                                                                                                                                    │");// 35
                Console.WriteLine(" │                                                                                                                                                                    │");// 36
                Console.WriteLine(" │                                                                                                                                                                    │");// 37
                Console.WriteLine(" │                                                                                                                                                                    │");// 38
                Console.WriteLine(" │                                                                                                                                                                    │");// 39
                Console.WriteLine(" │                                                                                                                                                                    │");// 40
                Console.WriteLine(" │                                                                                                                                                                    │");// 41
                Console.WriteLine(" │                                                                                                                                                                    │");// 42
                Console.WriteLine(" |────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────|");// 43
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(69, 3);
            Console.Write("      ██             ██        ");
            Console.SetCursorPosition(69, 4);
            Console.Write("        ██         ██          ");
            Console.SetCursorPosition(69, 5);
            Console.Write("      ██████████████████       ");
            Console.SetCursorPosition(69, 6);
            Console.Write("    ██████████████████████     ");
            Console.SetCursorPosition(69, 7);
            Console.Write("  ████    ██████████    ████   ");
            Console.SetCursorPosition(69, 8);
            Console.Write("██████████████████████████████ ");
            Console.SetCursorPosition(69, 9);
            Console.Write("██   ████████████████████   ██ ");
            Console.SetCursorPosition(69, 10);
            Console.Write("██   ██                ██   ██ ");
            Console.SetCursorPosition(69, 11);
            Console.Write("       ████        ████        ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(57, 13);
            Console.Write("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
            Console.SetCursorPosition(57, 14);
            Console.Write("█      Qual região é conhecida como berço da escrita?  █");
            Console.SetCursorPosition(57, 15);
            Console.Write("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");



            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(12, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(12, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(12, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(12, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(12, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(12, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(12, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(12, 27);
            Console.Write(" ▀            ▀ ");

            // opção A
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(2, 29);
            Console.Write("——————————————————————————————————————————");
            Console.SetCursorPosition(2, 30);
            Console.Write("|                  Egito                 |");
            Console.SetCursorPosition(2, 31);
            Console.Write("——————————————————————————————————————————");
            // opção B
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(45, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(45, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(45, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(45, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(45, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(45, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(45, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(45, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(38, 29);
            Console.Write("——————————————————————————————————————————");
            Console.SetCursorPosition(38, 30);
            Console.Write("|              Babilônia                 |");
            Console.SetCursorPosition(38, 31);
            Console.Write("——————————————————————————————————————————");
            // opção C
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.SetCursorPosition(77, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(77, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(77, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(77, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(77, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(77, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(77, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(77, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(71, 29);
            Console.Write("——————————————————————————————————————————");
            Console.SetCursorPosition(71, 30);
            Console.Write("|             Extremo Oriente            |");
            Console.SetCursorPosition(71, 31);
            Console.Write("——————————————————————————————————————————");
            // opção D
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(109, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(109, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(109, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(109, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(109, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(109, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(109, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(109, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(102, 29);
            Console.Write("——————————————————————————————————————————");
            Console.SetCursorPosition(102, 30);
            Console.Write("|                  Índia                 |");
            Console.SetCursorPosition(102, 31);
            Console.Write("——————————————————————————————————————————");
            // opção E
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(143, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(143, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(143, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(143, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(143, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(143, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(143, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(143, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(134, 29);
            Console.Write("————————————————————————————————");
            Console.SetCursorPosition(134, 30);
            Console.Write("|   Planalto centro-africano   |");
            Console.SetCursorPosition(134, 31);
            Console.Write("————————————————————————————————");
            Console.SetCursorPosition(2, 32);
            Console.Write("              (A)             ");

            Console.SetCursorPosition(38, 32);
            Console.Write("              (B)             ");

            Console.SetCursorPosition(71, 32);
            Console.Write("              (C)             ");

            Console.SetCursorPosition(102, 32);
            Console.Write("              (D)             ");

            Console.SetCursorPosition(134, 32);
            Console.Write("              (E)             ");
            Console.SetCursorPosition(34, 41);

            tecla = Console.ReadKey();


            switch (tecla.Key)
            {
                case ConsoleKey.A:
                    Perdeu();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.B:
                    HisFase4();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.C:
                    Perdeu();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.D:
                    Perdeu();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.E:
                    Perdeu();
                    break;

            }



            }
            static public void HisFase4()
            {

                ConsoleKeyInfo tecla;


                Console.Clear();
                Console.WriteLine(" ┌────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");// 1
                Console.WriteLine(" │                                                                                                                                                                    │");// 2
                Console.WriteLine(" │                                                                                                                                                                    │");// 3
                Console.WriteLine(" │                                                                                                                                                                    │");// 4
                Console.WriteLine(" │                                                                                                                                                                    │");// 5
                Console.WriteLine(" │                                                                                                                                                                    │");// 6
                Console.WriteLine(" │                                                                                                                                                                    │");// 7
                Console.WriteLine(" │                                                                                                                                                                    │");// 8
                Console.WriteLine(" │                                                                                                                                                                    │");// 9
                Console.WriteLine(" │                                                                                                                                                                    │");// 10
                Console.WriteLine(" │                                                                                                                                                                    │");// 11
                Console.WriteLine(" │                                                                                                                                                                    │");// 12
                Console.WriteLine(" │                                                                                                                                                                    │");// 13
                Console.WriteLine(" │                                                                                                                                                                    │");// 14
                Console.WriteLine(" │                                                                                                                                                                    │");// 15
                Console.WriteLine(" │                                                                                                                                                                    │");// 16
                Console.WriteLine(" │                                                                                                                                                                    │");// 17
                Console.WriteLine(" │                                                                                                                                                                    │");// 18
                Console.WriteLine(" │                                                                                                                                                                    │");// 19
                Console.WriteLine(" │                                                                                                                                                                    │");// 20
                Console.WriteLine(" │                                                                                                                                                                    │");// 21
                Console.WriteLine(" │                                                                                                                                                                    │");// 22
                Console.WriteLine(" │                                                                                                                                                                    │");// 23
                Console.WriteLine(" │                                                                                                                                                                    │");// 24
                Console.WriteLine(" │                                                                                                                                                                    │");// 25
                Console.WriteLine(" │                                                                                                                                                                    │");// 26
                Console.WriteLine(" │                                                                                                                                                                    │");// 27
                Console.WriteLine(" │                                                                                                                                                                    │");// 28
                Console.WriteLine(" │                                                                                                                                                                    │");// 29
                Console.WriteLine(" │                                                                                                                                                                    │");// 30
                Console.WriteLine(" │                                                                                                                                                                    │");// 31
                Console.WriteLine(" │                                                                                                                                                                    │");// 32
                Console.WriteLine(" │                                                                                                                                                                    │");// 33
                Console.WriteLine(" │                                                                                                                                                                    │");// 34
                Console.WriteLine(" │                                                                                                                                                                    │");// 35
                Console.WriteLine(" │                                                                                                                                                                    │");// 36
                Console.WriteLine(" │                                                                                                                                                                    │");// 37
                Console.WriteLine(" │                                                                                                                                                                    │");// 38
                Console.WriteLine(" │                                                                                                                                                                    │");// 39
                Console.WriteLine(" │                                                                                                                                                                    │");// 40
                Console.WriteLine(" │                                                                                                                                                                    │");// 41
                Console.WriteLine(" │                                                                                                                                                                    │");// 42
                Console.WriteLine(" |────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────|");// 43
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(69, 3);
            Console.Write("      ██             ██        ");
            Console.SetCursorPosition(69, 4);
            Console.Write("        ██         ██          ");
            Console.SetCursorPosition(69, 5);
            Console.Write("      ██████████████████       ");
            Console.SetCursorPosition(69, 6);
            Console.Write("    ██████████████████████     ");
            Console.SetCursorPosition(69, 7);
            Console.Write("  ████    ██████████    ████   ");
            Console.SetCursorPosition(69, 8);
            Console.Write("██████████████████████████████ ");
            Console.SetCursorPosition(69, 9);
            Console.Write("██   ████████████████████   ██ ");
            Console.SetCursorPosition(69, 10);
            Console.Write("██   ██                ██   ██ ");
            Console.SetCursorPosition(69, 11);
            Console.Write("       ████        ████        ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(57, 13);
            Console.Write("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
            Console.SetCursorPosition(57, 14);
            Console.Write("█   Quem possuía mais poder durante a Alta Idade Média europeia?  █");
            Console.SetCursorPosition(57, 15);
            Console.Write("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");



            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(12, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(12, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(12, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(12, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(12, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(12, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(12, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(12, 27);
            Console.Write(" ▀            ▀ ");
            // opção A
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(2, 29);
            Console.Write("——————————————————————————————————————————");
            Console.SetCursorPosition(2, 30);
            Console.Write("|                 Os reis                |");
            Console.SetCursorPosition(2, 31);
            Console.Write("——————————————————————————————————————————");
            // opção B

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(45, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(45, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(45, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(45, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(45, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(45, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(45, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(45, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(38, 29);
            Console.Write("——————————————————————————————————————————");
            Console.SetCursorPosition(38, 30);
            Console.Write(" |              O clero                  | ");
            Console.SetCursorPosition(38, 31);
            Console.Write("——————————————————————————————————————————");
            // opção C
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.SetCursorPosition(77, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(77, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(77, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(77, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(77, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(77, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(77, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(77, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(71, 29);
            Console.Write("——————————————————————————————————————————");
            Console.SetCursorPosition(71, 30);
            Console.Write("|                Os vassalos             |");
            Console.SetCursorPosition(71, 31);
            Console.Write("——————————————————————————————————————————");
            // opção D
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(109, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(109, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(109, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(109, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(109, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(109, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(109, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(109, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(102, 29);
            Console.Write("——————————————————————————————————————————");
            Console.SetCursorPosition(102, 30);
            Console.Write("|              Os burgueses              |");
            Console.SetCursorPosition(102, 31);
            Console.Write("——————————————————————————————————————————");
            // opção E
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(143, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(143, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(143, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(143, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(143, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(143, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(143, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(143, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(134, 29);
            Console.Write("————————————————————————————————");
            Console.SetCursorPosition(134, 30);
            Console.Write("|          Os comerciantes     |");
            Console.SetCursorPosition(134, 31);
            Console.Write("————————————————————————————————");
            Console.SetCursorPosition(2, 32);
            Console.Write("              (A)             ");

            Console.SetCursorPosition(38, 32);
            Console.Write("              (B)             ");

            Console.SetCursorPosition(71, 32);
            Console.Write("              (C)             ");

            Console.SetCursorPosition(102, 32);
            Console.Write("              (D)             ");

            Console.SetCursorPosition(134, 32);
            Console.Write("              (E)             ");
            Console.SetCursorPosition(34, 41);

            tecla = Console.ReadKey();


            switch (tecla.Key)
            {
                case ConsoleKey.A:
                    Perdeu();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.B:
                    HisFase5();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.C:
                    Perdeu();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.D:
                    Perdeu();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.E:
                    Perdeu();
                    break;

            }

            


            }
            static public void HisFase5()
            {

                ConsoleKeyInfo tecla;


                Console.Clear();
                Console.WriteLine(" ┌────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");// 1
                Console.WriteLine(" │                                                                                                                                                                    │");// 2
                Console.WriteLine(" │                                                                                                                                                                    │");// 3
                Console.WriteLine(" │                                                                                                                                                                    │");// 4
                Console.WriteLine(" │                                                                                                                                                                    │");// 5
                Console.WriteLine(" │                                                                                                                                                                    │");// 6
                Console.WriteLine(" │                                                                                                                                                                    │");// 7
                Console.WriteLine(" │                                                                                                                                                                    │");// 8
                Console.WriteLine(" │                                                                                                                                                                    │");// 9
                Console.WriteLine(" │                                                                                                                                                                    │");// 10
                Console.WriteLine(" │                                                                                                                                                                    │");// 11
                Console.WriteLine(" │                                                                                                                                                                    │");// 12
                Console.WriteLine(" │                                                                                                                                                                    │");// 13
                Console.WriteLine(" │                                                                                                                                                                    │");// 14
                Console.WriteLine(" │                                                                                                                                                                    │");// 15
                Console.WriteLine(" │                                                                                                                                                                    │");// 16
                Console.WriteLine(" │                                                                                                                                                                    │");// 17
                Console.WriteLine(" │                                                                                                                                                                    │");// 18
                Console.WriteLine(" │                                                                                                                                                                    │");// 19
                Console.WriteLine(" │                                                                                                                                                                    │");// 20
                Console.WriteLine(" │                                                                                                                                                                    │");// 21
                Console.WriteLine(" │                                                                                                                                                                    │");// 22
                Console.WriteLine(" │                                                                                                                                                                    │");// 23
                Console.WriteLine(" │                                                                                                                                                                    │");// 24
                Console.WriteLine(" │                                                                                                                                                                    │");// 25
                Console.WriteLine(" │                                                                                                                                                                    │");// 26
                Console.WriteLine(" │                                                                                                                                                                    │");// 27
                Console.WriteLine(" │                                                                                                                                                                    │");// 28
                Console.WriteLine(" │                                                                                                                                                                    │");// 29
                Console.WriteLine(" │                                                                                                                                                                    │");// 30
                Console.WriteLine(" │                                                                                                                                                                    │");// 31
                Console.WriteLine(" │                                                                                                                                                                    │");// 32
                Console.WriteLine(" │                                                                                                                                                                    │");// 33
                Console.WriteLine(" │                                                                                                                                                                    │");// 34
                Console.WriteLine(" │                                                                                                                                                                    │");// 35
                Console.WriteLine(" │                                                                                                                                                                    │");// 36
                Console.WriteLine(" │                                                                                                                                                                    │");// 37
                Console.WriteLine(" │                                                                                                                                                                    │");// 38
                Console.WriteLine(" │                                                                                                                                                                    │");// 39
                Console.WriteLine(" │                                                                                                                                                                    │");// 40
                Console.WriteLine(" │                                                                                                                                                                    │");// 41
                Console.WriteLine(" │                                                                                                                                                                    │");// 42
                Console.WriteLine(" |────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────|");// 43
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(69, 3);
            Console.Write("      ██             ██        ");
            Console.SetCursorPosition(69, 4);
            Console.Write("        ██         ██          ");
            Console.SetCursorPosition(69, 5);
            Console.Write("      ██████████████████       ");
            Console.SetCursorPosition(69, 6);
            Console.Write("    ██████████████████████     ");
            Console.SetCursorPosition(69, 7);
            Console.Write("  ████    ██████████    ████   ");
            Console.SetCursorPosition(69, 8);
            Console.Write("██████████████████████████████ ");
            Console.SetCursorPosition(69, 9);
            Console.Write("██   ████████████████████   ██ ");
            Console.SetCursorPosition(69, 10);
            Console.Write("██   ██                ██   ██ ");
            Console.SetCursorPosition(69, 11);
            Console.Write("       ████        ████        ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(57, 13);
            Console.Write("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
            Console.SetCursorPosition(57, 14);
            Console.Write("█   QUAL SERIA UM DOS GÊNEROS CLASSICOS DO TEATRO GREGO?  █");
            Console.SetCursorPosition(57, 15);
            Console.Write("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");


            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(12, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(12, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(12, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(12, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(12, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(12, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(12, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(12, 27);
            Console.Write(" ▀            ▀ ");
            // opção A
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(2, 29);
            Console.Write("——————————————————————————————————————————");
            Console.SetCursorPosition(2, 30);
            Console.Write("|                  DRAMA                 |");
            Console.SetCursorPosition(2, 31);
            Console.Write("——————————————————————————————————————————");
            // opção B
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(45, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(45, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(45, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(45, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(45, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(45, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(45, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(45, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(38, 29);
            Console.Write("——————————————————————————————————————————");
            Console.SetCursorPosition(38, 30);
            Console.Write("|               PENTOMIMA                |");
            Console.SetCursorPosition(38, 31);
            Console.Write("——————————————————————————————————————————");
            // opção C
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.SetCursorPosition(77, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(77, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(77, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(77, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(77, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(77, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(77, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(77, 27);
            Console.Write(" ▀            ▀ ");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(71, 29);
            Console.Write("——————————————————————————————————————————");
            Console.SetCursorPosition(71, 30);
            Console.Write("|                TRAGÉDIA                |");
            Console.SetCursorPosition(71, 31);
            Console.Write("——————————————————————————————————————————");
            // opção D
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(109, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(109, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(109, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(109, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(109, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(109, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(109, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(109, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(102, 29);
            Console.Write("——————————————————————————————————————————");
            Console.SetCursorPosition(102, 30);
            Console.Write("|               MELODRAMA                |");
            Console.SetCursorPosition(102, 31);
            Console.Write("——————————————————————————————————————————");
            // opção E

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(143, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(143, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(143, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(143, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(143, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(143, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(143, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(143, 27);
            Console.Write(" ▀            ▀ ");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(134, 29);
            Console.Write("————————————————————————————————");
            Console.SetCursorPosition(134, 30);
            Console.Write("|            VAUDEVILLE        |");
            Console.SetCursorPosition(134, 31);
            Console.Write("————————————————————————————————");
            Console.SetCursorPosition(2, 32);
            Console.Write("              (A)             ");

            Console.SetCursorPosition(38, 32);
            Console.Write("              (B)             ");

            Console.SetCursorPosition(71, 32);
            Console.Write("              (C)             ");

            Console.SetCursorPosition(102, 32);
            Console.Write("              (D)             ");

            Console.SetCursorPosition(134, 32);
            Console.Write("              (E)             ");
            Console.SetCursorPosition(34, 41);

            tecla = Console.ReadKey();


            switch (tecla.Key)
            {
                case ConsoleKey.A:
                    Perdeu();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.B:
                    Perdeu();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.C:
                    Parabens();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.D:
                    Perdeu();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.E:
                    Perdeu();
                    break;

            }

      

            } 
        //_____________________________________________________________________QUIZ DE PORTUGUES_______________________________________________________________________
        static public void PortFase()
        {

            ConsoleKeyInfo tecla;


            Console.Clear();
            Console.WriteLine(" ┌────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");// 1
            Console.WriteLine(" │                                                                                                                                                                    │");// 2
            Console.WriteLine(" │                                                                                                                                                                    │");// 3
            Console.WriteLine(" │                                                                                                                                                                    │");// 4
            Console.WriteLine(" │                                                                                                                                                                    │");// 5
            Console.WriteLine(" │                                                                                                                                                                    │");// 6
            Console.WriteLine(" │                                                                                                                                                                    │");// 7
            Console.WriteLine(" │                                                                                                                                                                    │");// 8
            Console.WriteLine(" │                                                                                                                                                                    │");// 9
            Console.WriteLine(" │                                                                                                                                                                    │");// 10
            Console.WriteLine(" │                                                                                                                                                                    │");// 11
            Console.WriteLine(" │                                                                                                                                                                    │");// 12
            Console.WriteLine(" │                                                                                                                                                                    │");// 13
            Console.WriteLine(" │                                                                                                                                                                    │");// 14
            Console.WriteLine(" │                                                                                                                                                                    │");// 15
            Console.WriteLine(" │                                                                                                                                                                    │");// 16
            Console.WriteLine(" │                                                                                                                                                                    │");// 17
            Console.WriteLine(" │                                                                                                                                                                    │");// 18
            Console.WriteLine(" │                                                                                                                                                                    │");// 19
            Console.WriteLine(" │                                                                                                                                                                    │");// 20
            Console.WriteLine(" │                                                                                                                                                                    │");// 21
            Console.WriteLine(" │                                                                                                                                                                    │");// 22
            Console.WriteLine(" │                                                                                                                                                                    │");// 23
            Console.WriteLine(" │                                                                                                                                                                    │");// 24
            Console.WriteLine(" │                                                                                                                                                                    │");// 25
            Console.WriteLine(" │                                                                                                                                                                    │");// 26
            Console.WriteLine(" │                                                                                                                                                                    │");// 27
            Console.WriteLine(" │                                                                                                                                                                    │");// 28
            Console.WriteLine(" │                                                                                                                                                                    │");// 29
            Console.WriteLine(" │                                                                                                                                                                    │");// 30
            Console.WriteLine(" │                                                                                                                                                                    │");// 31
            Console.WriteLine(" │                                                                                                                                                                    │");// 32
            Console.WriteLine(" │                                                                                                                                                                    │");// 33
            Console.WriteLine(" │                                                                                                                                                                    │");// 34
            Console.WriteLine(" │                                                                                                                                                                    │");// 35
            Console.WriteLine(" │                                                                                                                                                                    │");// 36
            Console.WriteLine(" │                                                                                                                                                                    │");// 37
            Console.WriteLine(" │                                                                                                                                                                    │");// 38
            Console.WriteLine(" │                                                                                                                                                                    │");// 39
            Console.WriteLine(" │                                                                                                                                                                    │");// 40
            Console.WriteLine(" │                                                                                                                                                                    │");// 41
            Console.WriteLine(" │                                                                                                                                                                    │");// 42
            Console.WriteLine(" |────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────|");// 43
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(69, 3);
            Console.Write("      ██             ██        ");
            Console.SetCursorPosition(69, 4);
            Console.Write("        ██         ██          ");
            Console.SetCursorPosition(69, 5);
            Console.Write("      ██████████████████       ");
            Console.SetCursorPosition(69, 6);
            Console.Write("    ██████████████████████     ");
            Console.SetCursorPosition(69, 7);
            Console.Write("  ████    ██████████    ████   ");
            Console.SetCursorPosition(69, 8);
            Console.Write("██████████████████████████████ ");
            Console.SetCursorPosition(69, 9);
            Console.Write("██   ████████████████████   ██ ");
            Console.SetCursorPosition(69, 10);
            Console.Write("██   ██                ██   ██ ");
            Console.SetCursorPosition(69, 11);
            Console.Write("       ████        ████        ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(53, 13);
                Console.Write("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
                Console.SetCursorPosition(53, 14);
                Console.Write("█     QUal destas palavras não é sinônimo de 'Rubicundo'.    █");
                Console.SetCursorPosition(53, 15);
                Console.Write("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(12, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(12, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(12, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(12, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(12, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(12, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(12, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(12, 27);
            Console.Write(" ▀            ▀ ");
            // opção A
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(5, 29);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(5, 30);
            Console.Write("|          Corado.            |");
            Console.SetCursorPosition(5, 31);
            Console.Write("———————————————————————————————");
            // opção B
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(45, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(45, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(45, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(45, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(45, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(45, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(45, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(45, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(38, 29);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(38, 30);
            Console.Write("|       Avermelhado           |");
            Console.SetCursorPosition(38, 31);
            Console.Write("———————————————————————————————");
            // opção C
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(77, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(77, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(77, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(77, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(77, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(77, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(77, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(77, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(71, 29);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(71, 30);
            Console.Write("|           Grená             | ");
            Console.SetCursorPosition(71, 31);
            Console.Write("———————————————————————————————");
            // opção D
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(109, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(109, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(109, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(109, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(109, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(109, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(109, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(109, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(102, 29);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(102, 30);
            Console.Write("|           Brilhante         | ");
            Console.SetCursorPosition(102, 31);
            Console.Write("———————————————————————————————");
            // opção E


            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(143, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(143, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(143, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(143, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(143, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(143, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(143, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(143, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(134, 29);
                Console.Write("————————————————————————————");
                Console.SetCursorPosition(134, 30);
                Console.Write("|  Todas as alternativas      |");
                Console.SetCursorPosition(134, 31);
                Console.Write("————————————————————————————");
            Console.SetCursorPosition(5, 32);
            Console.Write("              (A)             ");

            Console.SetCursorPosition(38, 32);
            Console.Write("              (B)             ");

            Console.SetCursorPosition(71, 32);
            Console.Write("              (C)             ");

            Console.SetCursorPosition(102, 32);
            Console.Write("              (D)             ");

            Console.SetCursorPosition(134, 32);
            Console.Write("              (E)             ");
            Console.SetCursorPosition(34, 41);

                tecla = Console.ReadKey();


                switch (tecla.Key)
                {
                    case ConsoleKey.A:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.B:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.C:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.D:
                        PortFase2();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.E:
                        Perdeu();
                        break;

                }

       

        }
        static public void PortFase2()
        {

            ConsoleKeyInfo tecla;


            Console.Clear();
            Console.WriteLine(" ┌────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");// 1
            Console.WriteLine(" │                                                                                                                                                                    │");// 2
            Console.WriteLine(" │                                                                                                                                                                    │");// 3
            Console.WriteLine(" │                                                                                                                                                                    │");// 4
            Console.WriteLine(" │                                                                                                                                                                    │");// 5
            Console.WriteLine(" │                                                                                                                                                                    │");// 6
            Console.WriteLine(" │                                                                                                                                                                    │");// 7
            Console.WriteLine(" │                                                                                                                                                                    │");// 8
            Console.WriteLine(" │                                                                                                                                                                    │");// 9
            Console.WriteLine(" │                                                                                                                                                                    │");// 10
            Console.WriteLine(" │                                                                                                                                                                    │");// 11
            Console.WriteLine(" │                                                                                                                                                                    │");// 12
            Console.WriteLine(" │                                                                                                                                                                    │");// 13
            Console.WriteLine(" │                                                                                                                                                                    │");// 14
            Console.WriteLine(" │                                                                                                                                                                    │");// 15
            Console.WriteLine(" │                                                                                                                                                                    │");// 16
            Console.WriteLine(" │                                                                                                                                                                    │");// 17
            Console.WriteLine(" │                                                                                                                                                                    │");// 18
            Console.WriteLine(" │                                                                                                                                                                    │");// 19
            Console.WriteLine(" │                                                                                                                                                                    │");// 20
            Console.WriteLine(" │                                                                                                                                                                    │");// 21
            Console.WriteLine(" │                                                                                                                                                                    │");// 22
            Console.WriteLine(" │                                                                                                                                                                    │");// 23
            Console.WriteLine(" │                                                                                                                                                                    │");// 24
            Console.WriteLine(" │                                                                                                                                                                    │");// 25
            Console.WriteLine(" │                                                                                                                                                                    │");// 26
            Console.WriteLine(" │                                                                                                                                                                    │");// 27
            Console.WriteLine(" │                                                                                                                                                                    │");// 28
            Console.WriteLine(" │                                                                                                                                                                    │");// 29
            Console.WriteLine(" │                                                                                                                                                                    │");// 30
            Console.WriteLine(" │                                                                                                                                                                    │");// 31
            Console.WriteLine(" │                                                                                                                                                                    │");// 32
            Console.WriteLine(" │                                                                                                                                                                    │");// 33
            Console.WriteLine(" │                                                                                                                                                                    │");// 34
            Console.WriteLine(" │                                                                                                                                                                    │");// 35
            Console.WriteLine(" │                                                                                                                                                                    │");// 36
            Console.WriteLine(" │                                                                                                                                                                    │");// 37
            Console.WriteLine(" │                                                                                                                                                                    │");// 38
            Console.WriteLine(" │                                                                                                                                                                    │");// 39
            Console.WriteLine(" │                                                                                                                                                                    │");// 40
            Console.WriteLine(" │                                                                                                                                                                    │");// 41
            Console.WriteLine(" │                                                                                                                                                                    │");// 42
            Console.WriteLine(" |────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────|");// 43
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(69, 3);
            Console.Write("      ██             ██        ");
            Console.SetCursorPosition(69, 4);
            Console.Write("        ██         ██          ");
            Console.SetCursorPosition(69, 5);
            Console.Write("      ██████████████████       ");
            Console.SetCursorPosition(69, 6);
            Console.Write("    ██████████████████████     ");
            Console.SetCursorPosition(69, 7);
            Console.Write("  ████    ██████████    ████   ");
            Console.SetCursorPosition(69, 8);
            Console.Write("██████████████████████████████ ");
            Console.SetCursorPosition(69, 9);
            Console.Write("██   ████████████████████   ██ ");
            Console.SetCursorPosition(69, 10);
            Console.Write("██   ██                ██   ██ ");
            Console.SetCursorPosition(69, 11);
            Console.Write("       ████        ████        ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(19, 13);
                Console.Write("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
                Console.SetCursorPosition(19, 14);
                Console.Write("█     No hino nacional, há uma frase bastante interessante para classificarmos o sujeito dela: 'Ouviram do Ipiranga as margens plácidas' █");
                Console.SetCursorPosition(19, 15);
                Console.Write("█                                          Qual o tipo de sujeito presente nessa famosa frase?                                           █");
                Console.SetCursorPosition(19, 16);
                Console.Write("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(12, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(12, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(12, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(12, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(12, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(12, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(12, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(12, 27);
            Console.Write(" ▀            ▀ ");
            // opção A
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(5, 29);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(5, 30);
            Console.Write("|         Simples            |");
                Console.SetCursorPosition(5, 31);
            Console.Write("———————————————————————————————");
            // opção B

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(45, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(45, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(45, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(45, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(45, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(45, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(45, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(45, 27);
            Console.Write(" ▀            ▀ ");

            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(38, 29);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(38, 30);
            Console.Write("|           Composto          |");
                Console.SetCursorPosition(38, 31);
            Console.Write("———————————————————————————————");
            // opção C
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(77, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(77, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(77, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(77, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(77, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(77, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(77, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(77, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(71, 29);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(71, 30);
            Console.Write("|          Oculto             |");
                Console.SetCursorPosition(71, 31);
            Console.Write("———————————————————————————————");
            // opção D
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(109, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(109, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(109, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(109, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(109, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(109, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(109, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(109, 27);
            Console.Write(" ▀            ▀ ");

            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(102, 29);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(102, 30);
            Console.Write("|       Indeterminado         |");
                Console.SetCursorPosition(102, 31);
            Console.Write("———————————————————————————————");
            // opção E


            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(143, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(143, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(143, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(143, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(143, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(143, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(143, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(143, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(134, 29);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(134, 30);
            Console.Write("|        Inexistente          |");
                Console.SetCursorPosition(134, 31);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(5, 32);
            Console.Write("              (A)             ");

            Console.SetCursorPosition(38, 32);
            Console.Write("              (B)             ");

            Console.SetCursorPosition(71, 32);
            Console.Write("              (C)             ");

            Console.SetCursorPosition(102, 32);
            Console.Write("              (D)             ");

            Console.SetCursorPosition(134, 32);
            Console.Write("              (E)             ");
            Console.SetCursorPosition(34, 41);

                tecla = Console.ReadKey();


                switch (tecla.Key)
                {
                    case ConsoleKey.A:
                        PortFase3();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.B:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.C:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.D:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.E:
                        Perdeu();
                        break;

                }



        }
        static public void PortFase3()
        {

            ConsoleKeyInfo tecla;


            Console.Clear();
            Console.WriteLine(" ┌────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");// 1
            Console.WriteLine(" │                                                                                                                                                                    │");// 2
            Console.WriteLine(" │                                                                                                                                                                    │");// 3
            Console.WriteLine(" │                                                                                                                                                                    │");// 4
            Console.WriteLine(" │                                                                                                                                                                    │");// 5
            Console.WriteLine(" │                                                                                                                                                                    │");// 6
            Console.WriteLine(" │                                                                                                                                                                    │");// 7
            Console.WriteLine(" │                                                                                                                                                                    │");// 8
            Console.WriteLine(" │                                                                                                                                                                    │");// 9
            Console.WriteLine(" │                                                                                                                                                                    │");// 10
            Console.WriteLine(" │                                                                                                                                                                    │");// 11
            Console.WriteLine(" │                                                                                                                                                                    │");// 12
            Console.WriteLine(" │                                                                                                                                                                    │");// 13
            Console.WriteLine(" │                                                                                                                                                                    │");// 14
            Console.WriteLine(" │                                                                                                                                                                    │");// 15
            Console.WriteLine(" │                                                                                                                                                                    │");// 16
            Console.WriteLine(" │                                                                                                                                                                    │");// 17
            Console.WriteLine(" │                                                                                                                                                                    │");// 18
            Console.WriteLine(" │                                                                                                                                                                    │");// 19
            Console.WriteLine(" │                                                                                                                                                                    │");// 20
            Console.WriteLine(" │                                                                                                                                                                    │");// 21
            Console.WriteLine(" │                                                                                                                                                                    │");// 22
            Console.WriteLine(" │                                                                                                                                                                    │");// 23
            Console.WriteLine(" │                                                                                                                                                                    │");// 24
            Console.WriteLine(" │                                                                                                                                                                    │");// 25
            Console.WriteLine(" │                                                                                                                                                                    │");// 26
            Console.WriteLine(" │                                                                                                                                                                    │");// 27
            Console.WriteLine(" │                                                                                                                                                                    │");// 28
            Console.WriteLine(" │                                                                                                                                                                    │");// 29
            Console.WriteLine(" │                                                                                                                                                                    │");// 30
            Console.WriteLine(" │                                                                                                                                                                    │");// 31
            Console.WriteLine(" │                                                                                                                                                                    │");// 32
            Console.WriteLine(" │                                                                                                                                                                    │");// 33
            Console.WriteLine(" │                                                                                                                                                                    │");// 34
            Console.WriteLine(" │                                                                                                                                                                    │");// 35
            Console.WriteLine(" │                                                                                                                                                                    │");// 36
            Console.WriteLine(" │                                                                                                                                                                    │");// 37
            Console.WriteLine(" │                                                                                                                                                                    │");// 38
            Console.WriteLine(" │                                                                                                                                                                    │");// 39
            Console.WriteLine(" │                                                                                                                                                                    │");// 40
            Console.WriteLine(" │                                                                                                                                                                    │");// 41
            Console.WriteLine(" │                                                                                                                                                                    │");// 42
            Console.WriteLine(" |────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────|");// 43
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(69, 3);
            Console.Write("      ██             ██        ");
            Console.SetCursorPosition(69, 4);
            Console.Write("        ██         ██          ");
            Console.SetCursorPosition(69, 5);
            Console.Write("      ██████████████████       ");
            Console.SetCursorPosition(69, 6);
            Console.Write("    ██████████████████████     ");
            Console.SetCursorPosition(69, 7);
            Console.Write("  ████    ██████████    ████   ");
            Console.SetCursorPosition(69, 8);
            Console.Write("██████████████████████████████ ");
            Console.SetCursorPosition(69, 9);
            Console.Write("██   ████████████████████   ██ ");
            Console.SetCursorPosition(69, 10);
            Console.Write("██   ██                ██   ██ ");
            Console.SetCursorPosition(69, 11);
            Console.Write("       ████        ████        ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(43, 13);
                Console.Write("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
                Console.SetCursorPosition(43, 14);
                Console.Write("█      Conjugue os verbos no PRETÉRITO PERFEITO. Amar na 1° pessoa do singular:   █");
                Console.SetCursorPosition(43, 15);
                Console.Write("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(12, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(12, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(12, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(12, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(12, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(12, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(12, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(12, 27);
            Console.Write(" ▀            ▀ ");
            // opção A
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(5, 29);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(5, 30);
            Console.Write("|           Eu amei           |");
                Console.SetCursorPosition(5, 31);
            Console.Write("———————————————————————————————");
            // opção B

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(45, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(45, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(45, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(45, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(45, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(45, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(45, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(45, 27);
            Console.Write(" ▀            ▀ ");

            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(38, 29);
            Console.Write("———————————————————————————————");
                Console.SetCursorPosition(38, 30);
            Console.Write("|         Eu amava            | ");
                Console.SetCursorPosition(38, 31);
            Console.Write("———————————————————————————————");
            // opção C
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(77, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(77, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(77, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(77, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(77, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(77, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(77, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(77, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(71, 29);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(71, 30);
            Console.Write("|         Eu amara            |");
                Console.SetCursorPosition(71, 31);
            Console.Write("———————————————————————————————");
            // opção D
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(109, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(109, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(109, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(109, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(109, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(109, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(109, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(109, 27);
            Console.Write(" ▀            ▀ ");

            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(102, 29);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(102, 30);
            Console.Write("|           Eu amaria         | ");
                Console.SetCursorPosition(102, 31);
            Console.Write("———————————————————————————————");
            // opção E


            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(143, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(143, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(143, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(143, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(143, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(143, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(143, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(143, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(134, 29);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(134, 30);
            Console.Write("|             Eu amo          | ");
                Console.SetCursorPosition(134, 31);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(5, 32);
            Console.Write("              (A)             ");

            Console.SetCursorPosition(38, 32);
            Console.Write("              (B)             ");

            Console.SetCursorPosition(71, 32);
            Console.Write("              (C)             ");

            Console.SetCursorPosition(102, 32);
            Console.Write("              (D)             ");

            Console.SetCursorPosition(134, 32);
            Console.Write("              (E)             ");
            Console.SetCursorPosition(34, 41);

                tecla = Console.ReadKey();


                switch (tecla.Key)
                {
                    case ConsoleKey.A:
                        PortFase4();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.B:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.C:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.D:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.E:
                        Perdeu();
                        break;

                }

     


        }
        static public void PortFase4()
        {

            ConsoleKeyInfo tecla;


            Console.Clear();
            Console.WriteLine(" ┌────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");// 1
            Console.WriteLine(" │                                                                                                                                                                    │");// 2
            Console.WriteLine(" │                                                                                                                                                                    │");// 3
            Console.WriteLine(" │                                                                                                                                                                    │");// 4
            Console.WriteLine(" │                                                                                                                                                                    │");// 5
            Console.WriteLine(" │                                                                                                                                                                    │");// 6
            Console.WriteLine(" │                                                                                                                                                                    │");// 7
            Console.WriteLine(" │                                                                                                                                                                    │");// 8
            Console.WriteLine(" │                                                                                                                                                                    │");// 9
            Console.WriteLine(" │                                                                                                                                                                    │");// 10
            Console.WriteLine(" │                                                                                                                                                                    │");// 11
            Console.WriteLine(" │                                                                                                                                                                    │");// 12
            Console.WriteLine(" │                                                                                                                                                                    │");// 13
            Console.WriteLine(" │                                                                                                                                                                    │");// 14
            Console.WriteLine(" │                                                                                                                                                                    │");// 15
            Console.WriteLine(" │                                                                                                                                                                    │");// 16
            Console.WriteLine(" │                                                                                                                                                                    │");// 17
            Console.WriteLine(" │                                                                                                                                                                    │");// 18
            Console.WriteLine(" │                                                                                                                                                                    │");// 19
            Console.WriteLine(" │                                                                                                                                                                    │");// 20
            Console.WriteLine(" │                                                                                                                                                                    │");// 21
            Console.WriteLine(" │                                                                                                                                                                    │");// 22
            Console.WriteLine(" │                                                                                                                                                                    │");// 23
            Console.WriteLine(" │                                                                                                                                                                    │");// 24
            Console.WriteLine(" │                                                                                                                                                                    │");// 25
            Console.WriteLine(" │                                                                                                                                                                    │");// 26
            Console.WriteLine(" │                                                                                                                                                                    │");// 27
            Console.WriteLine(" │                                                                                                                                                                    │");// 28
            Console.WriteLine(" │                                                                                                                                                                    │");// 29
            Console.WriteLine(" │                                                                                                                                                                    │");// 30
            Console.WriteLine(" │                                                                                                                                                                    │");// 31
            Console.WriteLine(" │                                                                                                                                                                    │");// 32
            Console.WriteLine(" │                                                                                                                                                                    │");// 33
            Console.WriteLine(" │                                                                                                                                                                    │");// 34
            Console.WriteLine(" │                                                                                                                                                                    │");// 35
            Console.WriteLine(" │                                                                                                                                                                    │");// 36
            Console.WriteLine(" │                                                                                                                                                                    │");// 37
            Console.WriteLine(" │                                                                                                                                                                    │");// 38
            Console.WriteLine(" │                                                                                                                                                                    │");// 39
            Console.WriteLine(" │                                                                                                                                                                    │");// 40
            Console.WriteLine(" │                                                                                                                                                                    │");// 41
            Console.WriteLine(" │                                                                                                                                                                    │");// 42
            Console.WriteLine(" |────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────|");// 43
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(69, 3);
            Console.Write("      ██             ██        ");
            Console.SetCursorPosition(69, 4);
            Console.Write("        ██         ██          ");
            Console.SetCursorPosition(69, 5);
            Console.Write("      ██████████████████       ");
            Console.SetCursorPosition(69, 6);
            Console.Write("    ██████████████████████     ");
            Console.SetCursorPosition(69, 7);
            Console.Write("  ████    ██████████    ████   ");
            Console.SetCursorPosition(69, 8);
            Console.Write("██████████████████████████████ ");
            Console.SetCursorPosition(69, 9);
            Console.Write("██   ████████████████████   ██ ");
            Console.SetCursorPosition(69, 10);
            Console.Write("██   ██                ██   ██ ");
            Console.SetCursorPosition(69, 11);
            Console.Write("       ████        ████        ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(62, 13);
                Console.Write("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
                Console.SetCursorPosition(62, 14);
                Console.Write("█    Correr na 3° pessoa do singular:    █");
                Console.SetCursorPosition(62, 15);
                Console.Write("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(12, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(12, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(12, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(12, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(12, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(12, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(12, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(12, 27);
            Console.Write(" ▀            ▀ ");
            // opção A
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(5, 29);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(5, 30);
            Console.Write("|          Ele corre          |");
                Console.SetCursorPosition(5, 31);
            Console.Write("———————————————————————————————");
            // opção B

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(45, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(45, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(45, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(45, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(45, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(45, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(45, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(45, 27);
            Console.Write(" ▀            ▀ ");

            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(38, 29);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(38, 30);
            Console.Write("|         Ele corria          |");
                Console.SetCursorPosition(38, 31);
            Console.Write("———————————————————————————————");
            // opção C
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(77, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(77, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(77, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(77, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(77, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(77, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(77, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(77, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(71, 29);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(71, 30);
            Console.Write("|           Ele correras      |");
                Console.SetCursorPosition(71, 31);
            Console.Write("———————————————————————————————");
            // opção D
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(109, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(109, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(109, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(109, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(109, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(109, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(109, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(109, 27);
            Console.Write(" ▀            ▀ ");

            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(102, 29);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(102, 30);
            Console.Write("|        Ele correu           |");
                Console.SetCursorPosition(102, 31);
            Console.Write("———————————————————————————————");
            // opção E


            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(143, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(143, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(143, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(143, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(143, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(143, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(143, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(143, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(134, 29);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(134, 30);
            Console.Write("|        Ele correria         |");
                Console.SetCursorPosition(134, 31);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(5, 32);
            Console.Write("              (A)             ");

            Console.SetCursorPosition(38, 32);
            Console.Write("              (B)             ");

            Console.SetCursorPosition(71, 32);
            Console.Write("              (C)             ");

            Console.SetCursorPosition(102, 32);
            Console.Write("              (D)             ");

            Console.SetCursorPosition(134, 32);
            Console.Write("              (E)             ");
            Console.SetCursorPosition(34, 41);

                tecla = Console.ReadKey();


                switch (tecla.Key)
                {
                    case ConsoleKey.A:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.B:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.C:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.D:
                        PortFase5();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.E:
                        Perdeu();
                        break;

                }


        }
        static public void PortFase5()
        {

            ConsoleKeyInfo tecla;


            Console.Clear();
            Console.WriteLine(" ┌────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");// 1
            Console.WriteLine(" │                                                                                                                                                                    │");// 2
            Console.WriteLine(" │                                                                                                                                                                    │");// 3
            Console.WriteLine(" │                                                                                                                                                                    │");// 4
            Console.WriteLine(" │                                                                                                                                                                    │");// 5
            Console.WriteLine(" │                                                                                                                                                                    │");// 6
            Console.WriteLine(" │                                                                                                                                                                    │");// 7
            Console.WriteLine(" │                                                                                                                                                                    │");// 8
            Console.WriteLine(" │                                                                                                                                                                    │");// 9
            Console.WriteLine(" │                                                                                                                                                                    │");// 10
            Console.WriteLine(" │                                                                                                                                                                    │");// 11
            Console.WriteLine(" │                                                                                                                                                                    │");// 12
            Console.WriteLine(" │                                                                                                                                                                    │");// 13
            Console.WriteLine(" │                                                                                                                                                                    │");// 14
            Console.WriteLine(" │                                                                                                                                                                    │");// 15
            Console.WriteLine(" │                                                                                                                                                                    │");// 16
            Console.WriteLine(" │                                                                                                                                                                    │");// 17
            Console.WriteLine(" │                                                                                                                                                                    │");// 18
            Console.WriteLine(" │                                                                                                                                                                    │");// 19
            Console.WriteLine(" │                                                                                                                                                                    │");// 20
            Console.WriteLine(" │                                                                                                                                                                    │");// 21
            Console.WriteLine(" │                                                                                                                                                                    │");// 22
            Console.WriteLine(" │                                                                                                                                                                    │");// 23
            Console.WriteLine(" │                                                                                                                                                                    │");// 24
            Console.WriteLine(" │                                                                                                                                                                    │");// 25
            Console.WriteLine(" │                                                                                                                                                                    │");// 26
            Console.WriteLine(" │                                                                                                                                                                    │");// 27
            Console.WriteLine(" │                                                                                                                                                                    │");// 28
            Console.WriteLine(" │                                                                                                                                                                    │");// 29
            Console.WriteLine(" │                                                                                                                                                                    │");// 30
            Console.WriteLine(" │                                                                                                                                                                    │");// 31
            Console.WriteLine(" │                                                                                                                                                                    │");// 32
            Console.WriteLine(" │                                                                                                                                                                    │");// 33
            Console.WriteLine(" │                                                                                                                                                                    │");// 34
            Console.WriteLine(" │                                                                                                                                                                    │");// 35
            Console.WriteLine(" │                                                                                                                                                                    │");// 36
            Console.WriteLine(" │                                                                                                                                                                    │");// 37
            Console.WriteLine(" │                                                                                                                                                                    │");// 38
            Console.WriteLine(" │                                                                                                                                                                    │");// 39
            Console.WriteLine(" │                                                                                                                                                                    │");// 40
            Console.WriteLine(" │                                                                                                                                                                    │");// 41
            Console.WriteLine(" │                                                                                                                                                                    │");// 42
            Console.WriteLine(" |────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────|");// 43
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(69, 3);
            Console.Write("      ██             ██        ");
            Console.SetCursorPosition(69, 4);
            Console.Write("        ██         ██          ");
            Console.SetCursorPosition(69, 5);
            Console.Write("      ██████████████████       ");
            Console.SetCursorPosition(69, 6);
            Console.Write("    ██████████████████████     ");
            Console.SetCursorPosition(69, 7);
            Console.Write("  ████    ██████████    ████   ");
            Console.SetCursorPosition(69, 8);
            Console.Write("██████████████████████████████ ");
            Console.SetCursorPosition(69, 9);
            Console.Write("██   ████████████████████   ██ ");
            Console.SetCursorPosition(69, 10);
            Console.Write("██   ██                ██   ██ ");
            Console.SetCursorPosition(69, 11);
            Console.Write("       ████        ████        ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(47, 13);
                Console.Write("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
                Console.SetCursorPosition(47, 14);
                Console.Write("█    Identifique a classificação do verbo da seguinte frase: 'Ele morreu'.█ ");
                Console.SetCursorPosition(47, 15);
                Console.Write("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(12, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(12, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(12, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(12, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(12, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(12, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(12, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(12, 27);
            Console.Write(" ▀            ▀ ");
            // opção A
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(5, 29);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(5, 30);
            Console.Write("|     Verbo Inexistente       |");
                Console.SetCursorPosition(5, 31);
            Console.Write("———————————————————————————————");
            // opção B

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(45, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(45, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(45, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(45, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(45, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(45, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(45, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(45, 27);
            Console.Write(" ▀            ▀ ");

            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(38, 29);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(38, 30);
            Console.Write("|      Verbo transitivo       |");
                Console.SetCursorPosition(38, 31);
            Console.Write("———————————————————————————————");
            // opção C
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(77, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(77, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(77, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(77, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(77, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(77, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(77, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(77, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(71, 29);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(71, 30);
            Console.Write("|        Verbo simples        |");
                Console.SetCursorPosition(71, 31);
            Console.Write("———————————————————————————————");
            // opção D
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(109, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(109, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(109, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(109, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(109, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(109, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(109, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(109, 27);
            Console.Write(" ▀            ▀ ");

            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(102, 29);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(102, 30);
            Console.Write("|      Verbo de ligação       |");
                Console.SetCursorPosition(102, 31);
            Console.Write("———————————————————————————————");
            // opção E

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(143, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(143, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(143, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(143, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(143, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(143, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(143, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(143, 27);
            Console.Write(" ▀            ▀ ");

            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(134, 29);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(134, 30);
            Console.Write("|     Verbo intransitivo      |");
                Console.SetCursorPosition(134, 31);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(5, 32);
            Console.Write("              (A)             ");

            Console.SetCursorPosition(38, 32);
            Console.Write("              (B)             ");

            Console.SetCursorPosition(71, 32);
            Console.Write("              (C)             ");

            Console.SetCursorPosition(102, 32);
            Console.Write("              (D)             ");

            Console.SetCursorPosition(134, 32);
            Console.Write("              (E)             ");
            Console.SetCursorPosition(34, 41);

                tecla = Console.ReadKey();


                switch (tecla.Key)
                {
                    case ConsoleKey.A:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.B:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.C:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.D:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.E:
                        Parabens();
                        break;

                }


        }
        //____________________________________________________________QUIZ DE PROGRAMAÇÃO____________________________________________________________________________________
        static public void ProgFase()
        {

            ConsoleKeyInfo tecla;


            Console.Clear();
            Console.WriteLine(" ┌────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");// 1
            Console.WriteLine(" │                                                                                                                                                                    │");// 2
            Console.WriteLine(" │                                                                                                                                                                    │");// 3
            Console.WriteLine(" │                                                                                                                                                                    │");// 4
            Console.WriteLine(" │                                                                                                                                                                    │");// 5
            Console.WriteLine(" │                                                                                                                                                                    │");// 6
            Console.WriteLine(" │                                                                                                                                                                    │");// 7
            Console.WriteLine(" │                                                                                                                                                                    │");// 8
            Console.WriteLine(" │                                                                                                                                                                    │");// 9
            Console.WriteLine(" │                                                                                                                                                                    │");// 10
            Console.WriteLine(" │                                                                                                                                                                    │");// 11
            Console.WriteLine(" │                                                                                                                                                                    │");// 12
            Console.WriteLine(" │                                                                                                                                                                    │");// 13
            Console.WriteLine(" │                                                                                                                                                                    │");// 14
            Console.WriteLine(" │                                                                                                                                                                    │");// 15
            Console.WriteLine(" │                                                                                                                                                                    │");// 16
            Console.WriteLine(" │                                                                                                                                                                    │");// 17
            Console.WriteLine(" │                                                                                                                                                                    │");// 18
            Console.WriteLine(" │                                                                                                                                                                    │");// 19
            Console.WriteLine(" │                                                                                                                                                                    │");// 20
            Console.WriteLine(" │                                                                                                                                                                    │");// 21
            Console.WriteLine(" │                                                                                                                                                                    │");// 22
            Console.WriteLine(" │                                                                                                                                                                    │");// 23
            Console.WriteLine(" │                                                                                                                                                                    │");// 24
            Console.WriteLine(" │                                                                                                                                                                    │");// 25
            Console.WriteLine(" │                                                                                                                                                                    │");// 26
            Console.WriteLine(" │                                                                                                                                                                    │");// 27
            Console.WriteLine(" │                                                                                                                                                                    │");// 28
            Console.WriteLine(" │                                                                                                                                                                    │");// 29
            Console.WriteLine(" │                                                                                                                                                                    │");// 30
            Console.WriteLine(" │                                                                                                                                                                    │");// 31
            Console.WriteLine(" │                                                                                                                                                                    │");// 32
            Console.WriteLine(" │                                                                                                                                                                    │");// 33
            Console.WriteLine(" │                                                                                                                                                                    │");// 34
            Console.WriteLine(" │                                                                                                                                                                    │");// 35
            Console.WriteLine(" │                                                                                                                                                                    │");// 36
            Console.WriteLine(" │                                                                                                                                                                    │");// 37
            Console.WriteLine(" │                                                                                                                                                                    │");// 38
            Console.WriteLine(" │                                                                                                                                                                    │");// 39
            Console.WriteLine(" │                                                                                                                                                                    │");// 40
            Console.WriteLine(" │                                                                                                                                                                    │");// 41
            Console.WriteLine(" │                                                                                                                                                                    │");// 42
            Console.WriteLine(" |────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────|");// 43



            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(67, 3);
            Console.Write("      ██             ██        ");
            Console.SetCursorPosition(67, 4);
            Console.Write("        ██         ██          ");
            Console.SetCursorPosition(67, 5);
            Console.Write("      ██████████████████       ");
            Console.SetCursorPosition(67, 6);
            Console.Write("    ██████████████████████     ");
            Console.SetCursorPosition(67, 7);
            Console.Write("  ████    ██████████    ████   ");
            Console.SetCursorPosition(67, 8);
            Console.Write("██████████████████████████████ ");
            Console.SetCursorPosition(67, 9);
            Console.Write("██   ████████████████████   ██ ");
            Console.SetCursorPosition(67, 10);
            Console.Write("██   ██                ██   ██ ");
            Console.SetCursorPosition(67, 11);
            Console.Write("       ████        ████        ");

            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(40, 13);
                Console.Write("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
                Console.SetCursorPosition(40, 14);
                Console.Write("█                  QUAL É O CÓDIGO CORRETO PARA SE ESCREVER ALGO NA TELA                     █");
                Console.SetCursorPosition(40, 15);
                Console.Write("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(12, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(12, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(12, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(12, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(12, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(12, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(12, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(12, 27);
            Console.Write(" ▀            ▀ ");
            // opção A
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(5, 29);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(5, 30);
            Console.Write("|       Console.ReadLine      |");
            Console.SetCursorPosition(5, 31);
            Console.Write("———————————————————————————————");
            // opção B
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(45, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(45, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(45, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(45, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(45, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(45, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(45, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(45, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(38, 29);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(38, 30);
            Console.Write("|      Console.WriteLine      |");
                Console.SetCursorPosition(38, 31);
            Console.Write("———————————————————————————————");
            // opção C
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(77, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(77, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(77, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(77, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(77, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(77, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(77, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(77, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(70, 29);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(70, 30);
            Console.Write("|       Convert.WriteLine     |");
                Console.SetCursorPosition(70, 31);
            Console.Write("———————————————————————————————");
            // opção D
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(109, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(109, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(109, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(109, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(109, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(109, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(109, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(109, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(102, 29);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(102, 30);
            Console.Write("|       Conver.ReadLine       |");
                Console.SetCursorPosition(102, 31);
            Console.Write("———————————————————————————————");
            // opção E
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(141, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(141, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(141, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(141, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(141, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(141, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(141, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(141, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(134, 29);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(134, 30);
            Console.Write("|       Console.ReadKey       |");
                Console.SetCursorPosition(134, 31);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(5, 32);
            Console.Write("              (A)             ");

            Console.SetCursorPosition(38, 32);
            Console.Write("              (B)             ");

            Console.SetCursorPosition(70, 32);
            Console.Write("              (C)             ");

            Console.SetCursorPosition(102, 32);
            Console.Write("              (D)             ");

            Console.SetCursorPosition(134, 32);
            Console.Write("              (E)             ");
            Console.SetCursorPosition(34, 41);

                tecla = Console.ReadKey();


                switch (tecla.Key)
                {
                    case ConsoleKey.A:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.B:
                        ProgFase2();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.C:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.D:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.E:
                        Perdeu();
                        break;

                }

         


        }
        static public void ProgFase2()
        {

            ConsoleKeyInfo tecla;


            Console.Clear();
            Console.WriteLine(" ┌────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");// 1
            Console.WriteLine(" │                                                                                                                                                                    │");// 2
            Console.WriteLine(" │                                                                                                                                                                    │");// 3
            Console.WriteLine(" │                                                                                                                                                                    │");// 4
            Console.WriteLine(" │                                                                                                                                                                    │");// 5
            Console.WriteLine(" │                                                                                                                                                                    │");// 6
            Console.WriteLine(" │                                                                                                                                                                    │");// 7
            Console.WriteLine(" │                                                                                                                                                                    │");// 8
            Console.WriteLine(" │                                                                                                                                                                    │");// 9
            Console.WriteLine(" │                                                                                                                                                                    │");// 10
            Console.WriteLine(" │                                                                                                                                                                    │");// 11
            Console.WriteLine(" │                                                                                                                                                                    │");// 12
            Console.WriteLine(" │                                                                                                                                                                    │");// 13
            Console.WriteLine(" │                                                                                                                                                                    │");// 14
            Console.WriteLine(" │                                                                                                                                                                    │");// 15
            Console.WriteLine(" │                                                                                                                                                                    │");// 16
            Console.WriteLine(" │                                                                                                                                                                    │");// 17
            Console.WriteLine(" │                                                                                                                                                                    │");// 18
            Console.WriteLine(" │                                                                                                                                                                    │");// 19
            Console.WriteLine(" │                                                                                                                                                                    │");// 20
            Console.WriteLine(" │                                                                                                                                                                    │");// 21
            Console.WriteLine(" │                                                                                                                                                                    │");// 22
            Console.WriteLine(" │                                                                                                                                                                    │");// 23
            Console.WriteLine(" │                                                                                                                                                                    │");// 24
            Console.WriteLine(" │                                                                                                                                                                    │");// 25
            Console.WriteLine(" │                                                                                                                                                                    │");// 26
            Console.WriteLine(" │                                                                                                                                                                    │");// 27
            Console.WriteLine(" │                                                                                                                                                                    │");// 28
            Console.WriteLine(" │                                                                                                                                                                    │");// 29
            Console.WriteLine(" │                                                                                                                                                                    │");// 30
            Console.WriteLine(" │                                                                                                                                                                    │");// 31
            Console.WriteLine(" │                                                                                                                                                                    │");// 32
            Console.WriteLine(" │                                                                                                                                                                    │");// 33
            Console.WriteLine(" │                                                                                                                                                                    │");// 34
            Console.WriteLine(" │                                                                                                                                                                    │");// 35
            Console.WriteLine(" │                                                                                                                                                                    │");// 36
            Console.WriteLine(" │                                                                                                                                                                    │");// 37
            Console.WriteLine(" │                                                                                                                                                                    │");// 38
            Console.WriteLine(" │                                                                                                                                                                    │");// 39
            Console.WriteLine(" │                                                                                                                                                                    │");// 40
            Console.WriteLine(" │                                                                                                                                                                    │");// 41
            Console.WriteLine(" │                                                                                                                                                                    │");// 42
            Console.WriteLine(" |────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────|");// 43


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(67, 3);
            Console.Write("      ██             ██        ");
            Console.SetCursorPosition(67, 4);
            Console.Write("        ██         ██          ");
            Console.SetCursorPosition(67, 5);
            Console.Write("      ██████████████████       ");
            Console.SetCursorPosition(67, 6);
            Console.Write("    ██████████████████████     ");
            Console.SetCursorPosition(67, 7);
            Console.Write("  ████    ██████████    ████   ");
            Console.SetCursorPosition(67, 8);
            Console.Write("██████████████████████████████ ");
            Console.SetCursorPosition(67, 9);
            Console.Write("██   ████████████████████   ██ ");
            Console.SetCursorPosition(67, 10);
            Console.Write("██   ██                ██   ██ ");
            Console.SetCursorPosition(67, 11);
            Console.Write("       ████        ████        ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(40, 13);
                Console.Write("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
                Console.SetCursorPosition(40, 14);
                Console.Write("█                   PARA SE PROGRAMAR COM LÇO DE REPETIÇÃO USA-SE O:                         █");
                Console.SetCursorPosition(40, 15);
                Console.Write("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(12, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(12, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(12, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(12, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(12, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(12, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(12, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(12, 27);
            Console.Write(" ▀            ▀ ");
            // opção A
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(5, 29);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(5, 30);
            Console.Write("|              FOR            |");
                Console.SetCursorPosition(5, 31);
            Console.Write("———————————————————————————————");
            // opção B
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(45, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(45, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(45, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(45, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(45, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(45, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(45, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(45, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(38, 29);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(38, 30);
            Console.Write("|           REPETIR           |");
                Console.SetCursorPosition(38, 31);
            Console.Write("———————————————————————————————");
            // opção C
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(77, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(77, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(77, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(77, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(77, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(77, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(77, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(77, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(70, 29);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(70, 30);
            Console.Write("|          REPEAT             |");
                Console.SetCursorPosition(70, 31);
            Console.Write("———————————————————————————————");
            // opção D
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(109, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(109, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(109, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(109, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(109, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(109, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(109, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(109, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(102, 29);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(102, 30);
            Console.Write("|            IF               |");
                Console.SetCursorPosition(102, 31);
            Console.Write("———————————————————————————————");
            // opção E
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(141, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(141, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(141, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(141, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(141, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(141, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(141, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(141, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(134, 29);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(134, 30);
            Console.Write("|              WHITE          |");
                Console.SetCursorPosition(134, 31);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(34, 41);
            Console.SetCursorPosition(5, 32);
            Console.Write("              (A)             ");

            Console.SetCursorPosition(38, 32);
            Console.Write("              (B)             ");

            Console.SetCursorPosition(70, 32);
            Console.Write("              (C)             ");

            Console.SetCursorPosition(102, 32);
            Console.Write("              (D)             ");

            Console.SetCursorPosition(134, 32);
            Console.Write("              (E)             ");
            tecla = Console.ReadKey();


                switch (tecla.Key)
                {
                    case ConsoleKey.A:
                        ProgFase3();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.B:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.C:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.D:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.E:
                        Perdeu  ();
                        break;

                }

      


        }
        static public void ProgFase3()
        {

            ConsoleKeyInfo tecla;


            Console.Clear();
            Console.WriteLine(" ┌────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");// 1
            Console.WriteLine(" │                                                                                                                                                                    │");// 2
            Console.WriteLine(" │                                                                                                                                                                    │");// 3
            Console.WriteLine(" │                                                                                                                                                                    │");// 4
            Console.WriteLine(" │                                                                                                                                                                    │");// 5
            Console.WriteLine(" │                                                                                                                                                                    │");// 6
            Console.WriteLine(" │                                                                                                                                                                    │");// 7
            Console.WriteLine(" │                                                                                                                                                                    │");// 8
            Console.WriteLine(" │                                                                                                                                                                    │");// 9
            Console.WriteLine(" │                                                                                                                                                                    │");// 10
            Console.WriteLine(" │                                                                                                                                                                    │");// 11
            Console.WriteLine(" │                                                                                                                                                                    │");// 12
            Console.WriteLine(" │                                                                                                                                                                    │");// 13
            Console.WriteLine(" │                                                                                                                                                                    │");// 14
            Console.WriteLine(" │                                                                                                                                                                    │");// 15
            Console.WriteLine(" │                                                                                                                                                                    │");// 16
            Console.WriteLine(" │                                                                                                                                                                    │");// 17
            Console.WriteLine(" │                                                                                                                                                                    │");// 18
            Console.WriteLine(" │                                                                                                                                                                    │");// 19
            Console.WriteLine(" │                                                                                                                                                                    │");// 20
            Console.WriteLine(" │                                                                                                                                                                    │");// 21
            Console.WriteLine(" │                                                                                                                                                                    │");// 22
            Console.WriteLine(" │                                                                                                                                                                    │");// 23
            Console.WriteLine(" │                                                                                                                                                                    │");// 24
            Console.WriteLine(" │                                                                                                                                                                    │");// 25
            Console.WriteLine(" │                                                                                                                                                                    │");// 26
            Console.WriteLine(" │                                                                                                                                                                    │");// 27
            Console.WriteLine(" │                                                                                                                                                                    │");// 28
            Console.WriteLine(" │                                                                                                                                                                    │");// 29
            Console.WriteLine(" │                                                                                                                                                                    │");// 30
            Console.WriteLine(" │                                                                                                                                                                    │");// 31
            Console.WriteLine(" │                                                                                                                                                                    │");// 32
            Console.WriteLine(" │                                                                                                                                                                    │");// 33
            Console.WriteLine(" │                                                                                                                                                                    │");// 34
            Console.WriteLine(" │                                                                                                                                                                    │");// 35
            Console.WriteLine(" │                                                                                                                                                                    │");// 36
            Console.WriteLine(" │                                                                                                                                                                    │");// 37
            Console.WriteLine(" │                                                                                                                                                                    │");// 38
            Console.WriteLine(" │                                                                                                                                                                    │");// 39
            Console.WriteLine(" │                                                                                                                                                                    │");// 40
            Console.WriteLine(" │                                                                                                                                                                    │");// 41
            Console.WriteLine(" │                                                                                                                                                                    │");// 42
            Console.WriteLine(" |────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────|");// 43


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(67, 3);
            Console.Write("      ██             ██        ");
            Console.SetCursorPosition(67, 4);
            Console.Write("        ██         ██          ");
            Console.SetCursorPosition(67, 5);
            Console.Write("      ██████████████████       ");
            Console.SetCursorPosition(67, 6);
            Console.Write("    ██████████████████████     ");
            Console.SetCursorPosition(67, 7);
            Console.Write("  ████    ██████████    ████   ");
            Console.SetCursorPosition(67, 8);
            Console.Write("██████████████████████████████ ");
            Console.SetCursorPosition(67, 9);
            Console.Write("██   ████████████████████   ██ ");
            Console.SetCursorPosition(67, 10);
            Console.Write("██   ██                ██   ██ ");
            Console.SetCursorPosition(67, 11);
            Console.Write("       ████        ████        ");
            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.SetCursorPosition(40, 13);
                Console.Write("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
                Console.SetCursorPosition(40, 14);
                Console.Write("█      DAS OPÇÕES ABAIXO QUAL SERIA PARA VERIFICAR CASO O USUARIO PRESSIONASE ALGUMA TECLA?   █");
                Console.SetCursorPosition(40, 15);
                Console.Write("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(12, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(12, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(12, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(12, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(12, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(12, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(12, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(12, 27);
            Console.Write(" ▀            ▀ ");
            // opção A
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(5, 29);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(5, 30);
            Console.Write("|              CASE           |");
                Console.SetCursorPosition(5, 31);
            Console.Write("———————————————————————————————");
            // opção B
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(45, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(45, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(45, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(45, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(45, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(45, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(45, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(45, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(38, 29);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(38, 30);
            Console.Write("|       Console.WriteLine     |");
                Console.SetCursorPosition(38, 31);
            Console.Write("———————————————————————————————");
            // opção C
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(77, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(77, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(77, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(77, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(77, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(77, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(77, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(77, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(70, 29);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(70, 30);
            Console.Write("|        Console.ReadKey      |");
                Console.SetCursorPosition(70, 31);
            Console.Write("———————————————————————————————");
            // opção D
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(109, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(109, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(109, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(109, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(109, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(109, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(109, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(109, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(102, 29);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(102, 30);
            Console.Write("|         caso apertar        |");
                Console.SetCursorPosition(102, 31);
            Console.Write("———————————————————————————————");
            // opção E
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(141, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(141, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(141, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(141, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(141, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(141, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(141, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(141, 27);
            Console.Write(" ▀            ▀ ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(134, 29);
                Console.Write("———————————————————————————————");
                Console.SetCursorPosition(134, 30);
                Console.Write("|   Console.SetCursorPosition |");
                Console.SetCursorPosition(134, 31);
                Console.Write("———————————————————————————————");
            Console.SetCursorPosition(5, 32);
            Console.Write("              (A)             ");

            Console.SetCursorPosition(38, 32);
            Console.Write("              (B)             ");

            Console.SetCursorPosition(70, 32);
            Console.Write("              (C)             ");

            Console.SetCursorPosition(102, 32);
            Console.Write("              (D)             ");

            Console.SetCursorPosition(134, 32);
            Console.Write("              (E)             ");
            Console.SetCursorPosition(34, 41);

                tecla = Console.ReadKey();


                switch (tecla.Key)
                {
                    case ConsoleKey.A:
                        ProgFase4();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.B:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.C:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.D:
                        Perdeu();
                        break;

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.E:
                        Perdeu();
                        break;

                }

        }
        static public void ProgFase4()
        {

            ConsoleKeyInfo tecla;


            Console.Clear();
            Console.WriteLine(" ┌────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");// 1
            Console.WriteLine(" │                                                                                                                                                                    │");// 2
            Console.WriteLine(" │                                                                                                                                                                    │");// 3
            Console.WriteLine(" │                                                                                                                                                                    │");// 4
            Console.WriteLine(" │                                                                                                                                                                    │");// 5
            Console.WriteLine(" │                                                                                                                                                                    │");// 6
            Console.WriteLine(" │                                                                                                                                                                    │");// 7
            Console.WriteLine(" │                                                                                                                                                                    │");// 8
            Console.WriteLine(" │                                                                                                                                                                    │");// 9
            Console.WriteLine(" │                                                                                                                                                                    │");// 10
            Console.WriteLine(" │                                                                                                                                                                    │");// 11
            Console.WriteLine(" │                                                                                                                                                                    │");// 12
            Console.WriteLine(" │                                                                                                                                                                    │");// 13
            Console.WriteLine(" │                                                                                                                                                                    │");// 14
            Console.WriteLine(" │                                                                                                                                                                    │");// 15
            Console.WriteLine(" │                                                                                                                                                                    │");// 16
            Console.WriteLine(" │                                                                                                                                                                    │");// 17
            Console.WriteLine(" │                                                                                                                                                                    │");// 18
            Console.WriteLine(" │                                                                                                                                                                    │");// 19
            Console.WriteLine(" │                                                                                                                                                                    │");// 20
            Console.WriteLine(" │                                                                                                                                                                    │");// 21
            Console.WriteLine(" │                                                                                                                                                                    │");// 22
            Console.WriteLine(" │                                                                                                                                                                    │");// 23
            Console.WriteLine(" │                                                                                                                                                                    │");// 24
            Console.WriteLine(" │                                                                                                                                                                    │");// 25
            Console.WriteLine(" │                                                                                                                                                                    │");// 26
            Console.WriteLine(" │                                                                                                                                                                    │");// 27
            Console.WriteLine(" │                                                                                                                                                                    │");// 28
            Console.WriteLine(" │                                                                                                                                                                    │");// 29
            Console.WriteLine(" │                                                                                                                                                                    │");// 30
            Console.WriteLine(" │                                                                                                                                                                    │");// 31
            Console.WriteLine(" │                                                                                                                                                                    │");// 32
            Console.WriteLine(" │                                                                                                                                                                    │");// 33
            Console.WriteLine(" │                                                                                                                                                                    │");// 34
            Console.WriteLine(" │                                                                                                                                                                    │");// 35
            Console.WriteLine(" │                                                                                                                                                                    │");// 36
            Console.WriteLine(" │                                                                                                                                                                    │");// 37
            Console.WriteLine(" │                                                                                                                                                                    │");// 38
            Console.WriteLine(" │                                                                                                                                                                    │");// 39
            Console.WriteLine(" │                                                                                                                                                                    │");// 40
            Console.WriteLine(" │                                                                                                                                                                    │");// 41
            Console.WriteLine(" │                                                                                                                                                                    │");// 42
            Console.WriteLine(" |────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────|");// 43


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(67, 3);
            Console.Write("      ██             ██        ");
            Console.SetCursorPosition(67, 4);
            Console.Write("        ██         ██          ");
            Console.SetCursorPosition(67, 5);
            Console.Write("      ██████████████████       ");
            Console.SetCursorPosition(67, 6);
            Console.Write("    ██████████████████████     ");
            Console.SetCursorPosition(67, 7);
            Console.Write("  ████    ██████████    ████   ");
            Console.SetCursorPosition(67, 8);
            Console.Write("██████████████████████████████ ");
            Console.SetCursorPosition(67, 9);
            Console.Write("██   ████████████████████   ██ ");
            Console.SetCursorPosition(67, 10);
            Console.Write("██   ██                ██   ██ ");
            Console.SetCursorPosition(67, 11);
            Console.Write("       ████        ████        ");

            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(40, 13);
                Console.Write("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
                Console.SetCursorPosition(40, 14);
                Console.Write("█     PARA CRIAR UMA VARIAVEL DE VALOR REAL E INTEIRO QUAL DAS OPÇÕES ABAIXO DEVE SE USAR?   █");
                Console.SetCursorPosition(40, 15);
                Console.Write("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(12, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(12, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(12, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(12, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(12, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(12, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(12, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(12, 27);
            Console.Write(" ▀            ▀ ");
            // opção A
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(5, 29);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(5, 30);
            Console.Write("|         INT/STRING          |");
                Console.SetCursorPosition(5, 31);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(5, 32);
            Console.Write("              (A)             ");
            // opção B
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(45, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(45, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(45, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(45, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(45, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(45, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(45, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(45, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(38, 29);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(38, 30);
            Console.Write("|         STRING/DOUBLE       |");
            Console.SetCursorPosition(38, 31);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(38, 32);
            Console.Write("              (B)             ");
            // opção C
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(77, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(77, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(77, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(77, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(77, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(77, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(77, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(77, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(70, 29);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(70, 30);
            Console.Write("|          DOUBLE/INT         |");
            Console.SetCursorPosition(70, 31);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(70, 32);
            Console.Write("              (C)             ");

            // opção D
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(109, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(109, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(109, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(109, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(109, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(109, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(109, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(109, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(102, 29);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(102, 30);
            Console.Write("|         DOUBLE/DOUBLE       |");
            Console.SetCursorPosition(102, 31);
            Console.Write("———————————————————————————————");

            Console.SetCursorPosition(102, 32);
            Console.Write("              (D)             ");
            // opção E            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(141, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(141, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(141, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(141, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(141, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(141, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(141, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(141, 27);
            Console.Write(" ▀            ▀ ");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(134, 29);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(134, 30);
            Console.Write("|       TOSTRING/TOINT32      |");
            Console.SetCursorPosition(134, 31);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(134, 32);
            Console.Write("              (E)              ");
            Console.SetCursorPosition(34, 41);

            tecla = Console.ReadKey();


            switch (tecla.Key)
            {
                case ConsoleKey.A:
                    Perdeu();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.B:
                    Perdeu();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.C:
                    ProgFase5();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.D:
                    Perdeu();
                    break;

            }

            switch (tecla.Key)
            {
                case ConsoleKey.E:
                    Perdeu();
                    break;

            }


            }
        static public void ProgFase5()
        {

            ConsoleKeyInfo tecla;


            Console.Clear();
            Console.WriteLine(" ┌────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");// 1
            Console.WriteLine(" │                                                                                                                                                                    │");// 2
            Console.WriteLine(" │                                                                                                                                                                    │");// 3
            Console.WriteLine(" │                                                                                                                                                                    │");// 4
            Console.WriteLine(" │                                                                                                                                                                    │");// 5
            Console.WriteLine(" │                                                                                                                                                                    │");// 6
            Console.WriteLine(" │                                                                                                                                                                    │");// 7
            Console.WriteLine(" │                                                                                                                                                                    │");// 8
            Console.WriteLine(" │                                                                                                                                                                    │");// 9
            Console.WriteLine(" │                                                                                                                                                                    │");// 10
            Console.WriteLine(" │                                                                                                                                                                    │");// 11
            Console.WriteLine(" │                                                                                                                                                                    │");// 12
            Console.WriteLine(" │                                                                                                                                                                    │");// 13
            Console.WriteLine(" │                                                                                                                                                                    │");// 14
            Console.WriteLine(" │                                                                                                                                                                    │");// 15
            Console.WriteLine(" │                                                                                                                                                                    │");// 16
            Console.WriteLine(" │                                                                                                                                                                    │");// 17
            Console.WriteLine(" │                                                                                                                                                                    │");// 18
            Console.WriteLine(" │                                                                                                                                                                    │");// 19
            Console.WriteLine(" │                                                                                                                                                                    │");// 20
            Console.WriteLine(" │                                                                                                                                                                    │");// 21
            Console.WriteLine(" │                                                                                                                                                                    │");// 22
            Console.WriteLine(" │                                                                                                                                                                    │");// 23
            Console.WriteLine(" │                                                                                                                                                                    │");// 24
            Console.WriteLine(" │                                                                                                                                                                    │");// 25
            Console.WriteLine(" │                                                                                                                                                                    │");// 26
            Console.WriteLine(" │                                                                                                                                                                    │");// 27
            Console.WriteLine(" │                                                                                                                                                                    │");// 28
            Console.WriteLine(" │                                                                                                                                                                    │");// 29
            Console.WriteLine(" │                                                                                                                                                                    │");// 30
            Console.WriteLine(" │                                                                                                                                                                    │");// 31
            Console.WriteLine(" │                                                                                                                                                                    │");// 32
            Console.WriteLine(" │                                                                                                                                                                    │");// 33
            Console.WriteLine(" │                                                                                                                                                                    │");// 34
            Console.WriteLine(" │                                                                                                                                                                    │");// 35
            Console.WriteLine(" │                                                                                                                                                                    │");// 36
            Console.WriteLine(" │                                                                                                                                                                    │");// 37
            Console.WriteLine(" │                                                                                                                                                                    │");// 38
            Console.WriteLine(" │                                                                                                                                                                    │");// 39
            Console.WriteLine(" │                                                                                                                                                                    │");// 40
            Console.WriteLine(" │                                                                                                                                                                    │");// 41
            Console.WriteLine(" │                                                                                                                                                                    │");// 42
            Console.WriteLine(" |────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────|");// 43


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(67, 3);
            Console.Write("      ██             ██        ");
            Console.SetCursorPosition(67, 4);
            Console.Write("        ██         ██          ");
            Console.SetCursorPosition(67, 5);
            Console.Write("      ██████████████████       ");
            Console.SetCursorPosition(67, 6);
            Console.Write("    ██████████████████████     ");
            Console.SetCursorPosition(67, 7);
            Console.Write("  ████    ██████████    ████   ");
            Console.SetCursorPosition(67, 8);
            Console.Write("██████████████████████████████ ");
            Console.SetCursorPosition(67, 9);
            Console.Write("██   ████████████████████   ██ ");
            Console.SetCursorPosition(67, 10);
            Console.Write("██   ██                ██   ██ ");
            Console.SetCursorPosition(67, 11);
            Console.Write("       ████        ████        ");

            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(40, 13);
                Console.Write("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
                Console.SetCursorPosition(40, 14);
                Console.Write("█                     O QUE SERIA O DESVIO CONDICIONAL(CONDIÇÃO/DECISÃO)?                    █");
                Console.SetCursorPosition(40, 15);
                Console.Write("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(12, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(12, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(12, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(12, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(12, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(12, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(12, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(12, 27);
            Console.Write(" ▀            ▀ ");
            // opção A
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(5, 29);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(5, 30);
            Console.Write("|         CONSOLE/IFELSE      |");
            Console.SetCursorPosition(5, 31);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(5, 32);
            Console.Write("              (A)              ");
            // opção B
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(45, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(45, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(45, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(45, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(45, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(45, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(45, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(45, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(38, 29);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(38, 30);
            Console.Write("|          IF/WRITE           |");
            Console.SetCursorPosition(38, 31);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(38, 32);
            Console.Write("              (B)              ");
            // opção C
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(77, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(77, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(77, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(77, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(77, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(77, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(77, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(77, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(70, 29);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(70, 30);
            Console.Write("|         ELSE/SWICTH         |");
            Console.SetCursorPosition(70, 31);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(70, 32);
            Console.Write("              (C)              ");
            // opção D
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(109, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(109, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(109, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(109, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(109, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(109, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(109, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(109, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(102, 29);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(102, 30);
            Console.Write("|             SE/SIM          |");
            Console.SetCursorPosition(102, 31);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(102, 32);
            Console.Write("              (D)              ");
            // opção E  
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(141, 20);
            Console.Write("       ██");
            Console.SetCursorPosition(141, 21);
            Console.Write("     ██████");
            Console.SetCursorPosition(141, 22);
            Console.Write("    ████████    ");
            Console.SetCursorPosition(141, 23);
            Console.Write("█  ██████████  █");
            Console.SetCursorPosition(141, 24);
            Console.Write("█ ████████████ █");
            Console.SetCursorPosition(141, 25);
            Console.Write("████████████████ ");
            Console.SetCursorPosition(141, 26);
            Console.Write(" ██    ██    ██ ");
            Console.SetCursorPosition(141, 27);
            Console.Write(" ▀            ▀ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.SetCursorPosition(134, 29);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(134, 30);
            Console.Write("|           IF/ELSE           |");
        Console.SetCursorPosition(134, 31);
            Console.Write("———————————————————————————————");
            Console.SetCursorPosition(134, 32);
            Console.Write("              (E)              ");
            Console.SetCursorPosition(34, 41);

        tecla = Console.ReadKey();


        switch (tecla.Key)
        {
            case ConsoleKey.A:
                Perdeu();
                break;

        }

        switch (tecla.Key)
        {
            case ConsoleKey.B:
                Perdeu();
                break;

        }

        switch (tecla.Key)
        {
            case ConsoleKey.C:
                Perdeu();
                break;

        }
                        
        switch (tecla.Key)
        {
            case ConsoleKey.D:
                Perdeu();
                break;

        }

        switch (tecla.Key)
        {
            case ConsoleKey.E:
                Parabens();
                break;

        }


        }
    }
}
