using System.Globalization;
namespace notas;

public class Program
{
    static void Main(string[] args)
    {

        //Fazer um programa para ler as duas notas que um aluno obteve no primeiro e segundo semestre de uma diciplina anual.
        //Em seguida, mostrar a nota final que o aluno obteve, no ano juntamente com um texto explicativo.
        //Caso a nota final do alun o seja inferior a 60, mostrar a mensagem de "REPROVADO".

        double NotaA, NotaB, Notafinal;

        CultureInfo culture = CultureInfo.InvariantCulture;

        Console.WriteLine("Entre com a primeira nota do aluno por favor.");
        Console.Write("Nota = ");
        NotaA = double.Parse(Console.ReadLine());
        
        Console.WriteLine();

        Console.WriteLine("Entre com a segunda nota do aluno por favor.");
        Console.Write("Nota = ");
        NotaB = double.Parse(Console.ReadLine());

        Notafinal = NotaA + NotaB;

        if(Notafinal < 60)
        {
            Console.WriteLine("Sua media final é de = " + Notafinal.ToString("00.0", CultureInfo.InvariantCulture));
            Console.WriteLine("Olha, você não passou não.");
            Console.WriteLine("VOCÊ ESTA REPROVADO");
        }
        else
        {
            Console.WriteLine("Sua media final é de = " + Notafinal);
            Console.WriteLine("Fantatstico você passou uhuuuu lol");
            Console.WriteLine("VOCÊ ESTA APROVADO");
        }

    }
}