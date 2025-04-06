namespace SalárioDeVendedorConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                
                decimal salarioBase = 0;
                decimal totalDevendas = 0;
                decimal porcentagem = 0;
                decimal comissao = 0;                

                Console.Clear();
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine("Olá, aqui iremos calcular o seu salário total.");
                Console.WriteLine("------------------------------------------------------------------");


                Console.WriteLine("Para começar, irei precisar de alguns dados iniciais:");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Digite o seu salário base por favor.");

                salarioBase = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Agora digite o total de vendas por favor.");

                totalDevendas = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Digite a sua porcentagem de comissão de vendas");

                porcentagem = Convert.ToDecimal(Console.ReadLine());

                
                decimal porcentual = porcentagem / 100;

                
                comissao = totalDevendas * porcentual;
                decimal salario = comissao + salarioBase;
                Console.WriteLine($"O seu salário total é de {salario:0.##}.");
                Console.WriteLine("----------------------------------------");
                Console.ReadLine();
                Console.Write("Deseja continuar? (S/N): ");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S")
                    break;

            }
        }
    }
}
