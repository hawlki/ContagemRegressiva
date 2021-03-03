using System;

namespace contagem_regressiva
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Clear();
           Console.Beep();
           Console.WriteLine("-------------------------------------");
           Console.WriteLine("Etec Adolpho Berezin");
           Console.WriteLine("Feito por Israel Camilo Lopes");
           Console.WriteLine("1I3");
           Console.WriteLine("-------------------------------------");
           Console.WriteLine();
           Console.BackgroundColor = ConsoleColor.White;
           Console.ForegroundColor = ConsoleColor.Black;
           Console.Write("Digita o nome de um país com o artigo antes: ");
           String país = Console.ReadLine();
           Console.WriteLine();
           Console.Write("Pressione qualquer tecla para começar a contagem regressiva para atacar ");
           Console.Write(país);
           Console.ReadKey();    
           Console.WriteLine();
           Console.BackgroundColor = ConsoleColor.Black;
           Console.ForegroundColor = ConsoleColor.Red;
           Console.WriteLine();
           Console.WriteLine("Preparar...");
           Console.WriteLine();
           Console.BackgroundColor = ConsoleColor.White;
           Console.ForegroundColor = ConsoleColor.Black;
           Console.WriteLine("Pressione qualquer tecla para continuar a contagem");
           Console.ReadKey();
           Console.WriteLine();
           Console.BackgroundColor = ConsoleColor.Black;
           Console.ForegroundColor = ConsoleColor.Yellow;
           Console.WriteLine("Apontar...");
           Console.WriteLine();
           Console.BackgroundColor = ConsoleColor.White;
           Console.ForegroundColor = ConsoleColor.Black;
           Console.WriteLine("Pressione qualquer tecla para atacar");
           Console.ReadKey();
           Console.WriteLine();
           Console.BackgroundColor = ConsoleColor.Black;
           Console.ForegroundColor = ConsoleColor.Green;
           Console.WriteLine("Fogo!");
           Console.WriteLine();
           Console.ForegroundColor = ConsoleColor.White;
           Console.WriteLine("-------------------------------------");
           Console.WriteLine("Você venceu!");
           Console.WriteLine("Parabéns!");
           Console.WriteLine("-------------------------------------");
           Console.WriteLine();
           Console.WriteLine("Pressione um botão para limpar a tela");
           Console.ReadKey();
           Console.ResetColor();
           Console.Clear();



           




           

           
           



        }
    }  
}