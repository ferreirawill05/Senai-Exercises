﻿using System;

namespace Exercise_Cellphone
{
    class Program
    {
        static void Main(string[] args)
        {
            cellphone celular = new cellphone();
            int escolha;
            bool statusCelular;
            string ligacao, mensagem, enviada;
            statusCelular = false;

            do
            {

                if (statusCelular == false)
                {

                    Console.WriteLine($@"
 _________________________________________
/  _____________________________________  \
|  |               \_O_/               |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |            1 - Ligar              |  |
|  |       0 - Manter Desligado        |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |___________________________________|  |
\________________________________________/
");
                    escolha = int.Parse(Console.ReadLine());
                    if (escolha == 1)
                    {
                        celular.Ligar();
                        statusCelular = celular.Ligar();
                    }
                }
                else
                {
                    Console.WriteLine($@"
 _________________________________________
/  _____________________________________  \
|  |               \_O_/               |  |
|  |                                   |  | 
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |                       
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |        1 - Fazer Ligação          |  |
|  |        2 - Mandar mensagem        |  |
|  |        3 - Propriedades           |  |
|  |        4 - Desligar               |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |___________________________________|  |
\________________________________________/
");

                    escolha = int.Parse(Console.ReadLine());
                    switch (escolha)
                    {
                        case 1:
                            Console.WriteLine($@"
 _________________________________________
/  _____________________________________  \
|  |               \_O_/               |  |
|  |                                   |  | 
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |                       
|  |                                   |  |
|  |      Para quem deseja ligar?      |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |    _______   _______   _______    |  |
|  |   |   1   | |   2   | |   3   |   |  |
|  |    ¨¨¨¨¨¨¨   ¨¨¨¨¨¨¨   ¨¨¨¨¨¨¨    |  |
|  |    _______   _______   _______    |  |
|  |   |   4   | |   5   | |   6   |   |  |
|  |    ¨¨¨¨¨¨¨   ¨¨¨¨¨¨¨   ¨¨¨¨¨¨¨    |  |
|  |    _______   _______   _______    |  |
|  |   |   7   | |   8   | |   9   |   |  |
|  |    ¨¨¨¨¨¨¨   ¨¨¨¨¨¨¨   ¨¨¨¨¨¨¨    |  |
|  |              _______              |  |
|  |             |   0   |             |  |
|  |              ¨¨¨¨¨¨¨              |  |
|  |___________________________________|  |
\________________________________________/
");
                            ligacao = Console.ReadLine();
                            Console.WriteLine($@"
 _________________________________________
/  _____________________________________  \
|  |               \_O_/               |  |
|  |                                   |  | 
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |                       
|  |                                   |  |
|  |       Ligação para {ligacao}       
|  |       Caiu na caixa postal...     |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |    _______   _______   _______    |  |
|  |   |   1   | |   2   | |   3   |   |  |
|  |    ¨¨¨¨¨¨¨   ¨¨¨¨¨¨¨   ¨¨¨¨¨¨¨    |  |
|  |    _______   _______   _______    |  |
|  |   |   4   | |   5   | |   6   |   |  |
|  |    ¨¨¨¨¨¨¨   ¨¨¨¨¨¨¨   ¨¨¨¨¨¨¨    |  |
|  |    _______   _______   _______    |  |
|  |   |   7   | |   8   | |   9   |   |  |
|  |    ¨¨¨¨¨¨¨   ¨¨¨¨¨¨¨   ¨¨¨¨¨¨¨    |  |
|  |              _______              |  |
|  |             |   0   |             |  |
|  |              ¨¨¨¨¨¨¨              |  |
|  |___________________________________|  |
\________________________________________/
");
                            break;
                        case 2:
                        Console.WriteLine($@"
 _________________________________________
/  _____________________________________  \
|  |               \_O_/               |  |
|  |                                   |  | 
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |                       
|  |                                   |  |
|  |      Para quem você deseja        |  |
|  |        mandar mensagem?           |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  | Q | W | E | R | T | Y | U | I | O |  |
|  |                                   |  |
|  | P | A | S | D | F | G | H | J | K |  |
|  |                                   |  |
|  | | L | Z | X | C | V | B | N | M | |  |
|  |                                   |  |
|  |       ___________________         |  |
|  |      |                   |        |  |
|  |       ¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨         |  |
|  |___________________________________|  |
\________________________________________/
");

                            mensagem = Console.ReadLine();

                        Console.WriteLine($@"
 _________________________________________
/  _____________________________________  \
|  |               \_O_/               |  |
|  |                                   |  | 
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |                       
|  |                                   |  |
|  |      Que mensagem você deseja     |  |
|  |       mandar para {mensagem}?           
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  | Q | W | E | R | T | Y | U | I | O |  |
|  |                                   |  |
|  | P | A | S | D | F | G | H | J | K |  |
|  |                                   |  |
|  | | L | Z | X | C | V | B | N | M | |  |
|  |                                   |  |
|  |       ___________________         |  |
|  |      |                   |        |  |
|  |       ¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨         |  |
|  |___________________________________|  |
\________________________________________/
");
                            enviada = Console.ReadLine();
                        Console.WriteLine($@"
 _________________________________________
/  _____________________________________  \
|  |               \_O_/               |  |
|  |                                   |  | 
|  |                                   |  |
|  |           _____________           |  |
|  |          |\           /|          |  |                       
|  |          | \____O____/ |          |  |
|  |          |_____________|          |  |
|  |     Mensagem enviada com êxito    |  |      
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  | Q | W | E | R | T | Y | U | I | O |  |
|  |                                   |  |
|  | P | A | S | D | F | G | H | J | K |  |
|  |                                   |  |
|  | | L | Z | X | C | V | B | N | M | |  |
|  |                                   |  |
|  |       ___________________         |  |
|  |      |                   |        |  |
|  |       ¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨         |  |
|  |___________________________________|  |
\________________________________________/
");
                            break;
                        case 3:
                            Console.WriteLine($@"
 _________________________________________
/  _____________________________________  \
|  |               \_O_/               |  |
|  |                                   |  | 
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |     Especifícações do celular     |  |
|  |         Cor: { celular.cor}        |  |
|  |        Modelo: { celular.modelo}             |  |
|  |      Tamanho: { celular.Tamanho}      |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |___________________________________|  |
\________________________________________/
");

                            break;
                        case 4:
                            Console.WriteLine($@"
 _________________________________________
/  _____________________________________  \
|  |               \_O_/               |  |
|  |                                   |  | 
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |           Desligando...           |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |___________________________________|  |
\________________________________________/
");
                            celular.Desligar();
                            statusCelular = celular.Desligar();
                            break;
                    }

                }

            } while (statusCelular == true);
        }
    }
}