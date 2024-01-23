Console.WriteLine("Sistema de Amortização Constante (SAC)");

// Solicitar informações ao usuário
Console.Write("Informe o número de parcelas: ");
int numeroParcelas = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe o saldo devedor: ");
double saldoDevedor = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe a taxa de juros (em %): ");
double taxaJuros = Convert.ToDouble(Console.ReadLine());


double amortizacao = saldoDevedor / numeroParcelas;


double taxaJurosDecimal = taxaJuros / 100;
double valorParcela = amortizacao + (saldoDevedor * taxaJurosDecimal);

// Exibir os resultados
Console.WriteLine("\nTabela de Amortização:");
Console.WriteLine("Mês\tAmortização\tJuros\tSaldo Devedor\tParcela Mensal");

for (int i = 1; i <= numeroParcelas; i++)
{
    double juros = saldoDevedor * taxaJurosDecimal;
    saldoDevedor -= amortizacao;

    Console.WriteLine($"{i}\t{amortizacao:F2}\t\t{juros:F2}\t{saldoDevedor:F2}\t\t{valorParcela:F2}");
}

Console.ReadLine();