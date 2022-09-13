

// See https://aka.ms/new-console-template for more information


int estoqueQuantidade = 100;
int estoqueCompra = 0;
bool possivelVenda =  estoqueQuantidade >= estoqueCompra;

Console.WriteLine("Digite a quantidade a comprar: ");
estoqueCompra = int.Parse(Console.ReadLine());

if (estoqueQuantidade >= estoqueCompra)
{
    Console.WriteLine("Venda Realizada");
}
else
{
    Console.WriteLine("Desculpe, sem estoque");
}

