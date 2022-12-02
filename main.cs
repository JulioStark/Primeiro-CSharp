using System;

class Program {
  public static void Main (string[] args) {
  
    
    string nome, entrada;
    Double n1,n2, media;


    Console.WriteLine("Digite nome do aluno");
   
    nome = Console.ReadLine();

    Console.WriteLine("Digite a nota 1");

    entrada = Console.ReadLine();

    n1 = Double.Parse(entrada);

      // repetindo codigo para nota 2 

    Console.WriteLine("Digite a nota 2");

    entrada = Console.ReadLine();

    n2 = Double.Parse(entrada);

    media = (n1 +n2)/2;

    Console.WriteLine("A nota final do aluno(a) " +nome +" é "  +media);


    //Console.WriteLine("Hello " + nome )
  }
}