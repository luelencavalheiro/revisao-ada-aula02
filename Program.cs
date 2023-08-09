
using aula_02_revisao_ada;

Console.WriteLine("Qual o nome do produto?");
string nome = Console.ReadLine();

Console.WriteLine("Qual o preço?");
double.TryParse(Console.ReadLine(), out double preco);

Console.WriteLine("Qual a quantidade?");
int.TryParse(Console.ReadLine(), out int quantidade);

Produto produto = new Produto (nome, preco, quantidade);

Console.WriteLine("Nome Produto:" + produto.nome);
Console.WriteLine("Preço:" + produto.preco);
Console.WriteLine("Quantidade:" + produto.quantidade);
Console.WriteLine("Valor Total:" + produto.ValorTotalEmEstoque());

Console.WriteLine("Qual quantidade você gostaria de adicionar?");
int.TryParse(Console.ReadLine(), out int quantidadeAdicional);
produto.AdicionarProdutos(quantidadeAdicional);

Console.WriteLine("Nome Produto:" + produto.nome);
Console.WriteLine("Preço:" + produto.preco);
Console.WriteLine("Quantidade:" + produto.quantidade);
Console.WriteLine("Valor Total:" + produto.ValorTotalEmEstoque());

Console.WriteLine("Qual quantidade você gostaria de remover?");
int.TryParse(Console.ReadLine(), out int quantidadeRemover);
produto.RemoverProdutos(quantidadeRemover);

Console.WriteLine("Nome Produto:" + produto.nome);
Console.WriteLine("Preço:" + produto.preco);
Console.WriteLine("Quantidade:" + produto.quantidade);
Console.WriteLine("Valor Total:" + produto.ValorTotalEmEstoque());













