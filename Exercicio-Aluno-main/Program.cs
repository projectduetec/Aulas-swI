namespace ExerciciosAlunos;
class Program
{
    static void Main(string[] args)
   
    {
       Alunos aluno1 = new Alunos();

       Console.WriteLine("Digite seu nome");
       aluno1.nome = Console.ReadLine();

       Console.WriteLine("-------------------------------------------");

       Console.WriteLine("Digite a primeira nota ");
       aluno1.nota1 = double.Parse(Console.ReadLine());
       Console.WriteLine("A primeira nota é: " + aluno1.nota1);
       Console.WriteLine("Digite a segunda nota ");
       aluno1.nota2 = double.Parse(Console.ReadLine());
       Console.WriteLine("A segunda nota é: " + aluno1.nota2);
        aluno1.mensagem();

    }


    

}
