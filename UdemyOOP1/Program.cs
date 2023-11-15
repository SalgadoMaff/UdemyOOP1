using System.Globalization;
using UdemyOOP1;

static int menu() {
    Console.WriteLine("1 : Pessoa mais velha");
    Console.WriteLine("2 : Média de salário de Funcionario");
    Console.Write("\nOpção: ");
    int op = int.Parse(Console.ReadLine());
    Console.Clear();
    return op;
}



int op = menu();
switch (op) {
    case 1:
        Pessoa p1 = new Pessoa();
        Pessoa p2 = new Pessoa();
        Console.WriteLine("Dados da primeira pessoa:");
        Console.Write("Nome: ");
        p1.Nome = Console.ReadLine();
        Console.Write("Idade: ");
        p1.Idade = int.Parse(Console.ReadLine());
        Console.WriteLine("\nDados da segunda pessoa:");
        Console.Write("Nome: ");
        p2.Nome = Console.ReadLine();
        Console.Write("Idade: ");
        p2.Idade = int.Parse(Console.ReadLine());
        Console.Write("\nPessoa mais velha: ");
        if (p1.Idade > p2.Idade) {
            Console.Write(p1.Nome);
        }
        else {
            Console.Write(p2.Nome);
        }
        break;
    case 2:
        Funcionario f1 = new Funcionario();
        Funcionario f2 = new Funcionario();
        Console.WriteLine("Dados do primeiro funcionário:");
        Console.Write("Nome: ");
        f1.Nome = Console.ReadLine();
        Console.Write("Salario: ");
        f1.Salario = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        Console.WriteLine("\nDados do segundo funcionário:");
        Console.Write("Nome: ");
        f2.Nome = Console.ReadLine();
        Console.Write("Salario: ");
        f2.Salario= float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write($"\nSalario médio: {((f1.Salario+f2.Salario)/2).ToString("F2", CultureInfo.InvariantCulture)}");
        break;
    default:
        break;
}