using System;
/* 
    Primeiro projeto feito por mim em C#, 
    esse projeto foi feito assistindo até a aula 22 do curso do CFBCursos
*/

namespace Pratica1
{
    class ExcelConsole
    {
        static void Main()
        {
            int Password = 1234;
            int attempts = 1;
            int passwordInsered;
            do
            {
                Console.WriteLine("Insira sua senha? Tentativa: {0}", attempts);
                passwordInsered = int.Parse(Console.ReadLine());
                attempts++;
            } while (Password != passwordInsered & attempts < 5);
            if (attempts == 5)
            {
                Console.WriteLine("Muitas tentativas, encerrado console!!!");
                Console.ReadLine();
                return;
            }
            int[,] excel = new int[4, 5]{
                {10,20,30,40,50},
                {50,30,20,5,10},
                {20,50,20,10,2},
                {90,20,45,180,2}
                }; //4 linhas e 5 colunas
                Back:
            Console.Clear();
            Console.WriteLine("Excel");
            Console.WriteLine("");
            for (int i = 0; i < 4; i++)
            {
                Console.Write("{0}\t {1}\t {2} \t {3} \t {4} \n",
                            excel[i, 0], excel[i, 1], excel[i, 2], excel[i, 3], excel[i, 4]
                            );
            }
            Console.WriteLine("");
            Console.WriteLine("Quer editar alguma celula?[S,n]");
            Console.WriteLine("");
            string confirm = Console.ReadLine();
            if (confirm == "S" || confirm == "s")
            {
                Console.Clear();
                
                Console.WriteLine("Qual Linha?");
                Console.WriteLine("");
                int line = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("Qual Coluna?");
                Console.WriteLine("");
                int column = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("Qual valor?");
                Console.WriteLine("");
                int value = int.Parse(Console.ReadLine());
                if(line != 0 | column !=0){
                    line-=1; column -=1;
                }
                excel[line,column] = value;
                
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Encerrado console!!!");
                Console.ReadLine();
                return;
            }
            goto Back;
        }
    }
}