Console.Write("Digite a quantidade de moedas:");
int moedas = int.Parse(Console.ReadLine()?? "0");

Console.Write("Digite a quantidade de porçoes:");
int porçoes = int.Parse(Console.ReadLine()?? "0");

int precoPorcao = 15;
int total = porçoes * precoPorcao;

Console.WriteLine($"Total da compra: {total} moedas.");


if(moedas >= total)
{
    int saldorestante = moedas - total;
    Console.WriteLine($"Compra realizada! Saldo restante:{saldoRestante}");
}
else
{
    Console.WriteLine("Saldo insuficiente para realizar a compra.");
}



