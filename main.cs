using System;

class Program {
  public static void Main (string[] args, Console console) {

    string nome, entrada;
    Double n1, n2, media; 

    Console.WriteLine("Digite o nome do aluno");

    nome = Console.ReadLine();
    
    Console.WriteLine("Digite a primeira nota");

    entrada = Console.ReadLine();

    n1 = Double.Parse (entrada);
    

//REPETIÇÃO DO CODIGO!!!!!!!

    Console.WriteLine("Digite a segunda nota");

    entrada = Console.ReadLine();

    n2 = Double.Parse (entrada);
    
    media = (n1 +n2)/2;
        console.WriteLine("A media final do aluno(a) " + nome + " é " + media );
    
  }
}