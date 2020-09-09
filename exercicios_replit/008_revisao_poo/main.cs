using System;

class MainClass {
  public static void Main (string[] args) {
    
    CadastroProdutos produtos = new CadastroProdutos();
    CarrinhoCompra carrinho = new CarrinhoCompra();
    
    int escolha = 0;
    do {
      Console.WriteLine("1 - Cadastrar novo produto");
      Console.WriteLine("2 - Inserir produto no carrinho");
      Console.WriteLine("3 - Mostrar resumo da compra");
      Console.WriteLine("4 - Remover item do carrinho");
      Console.WriteLine("9 - Sair");
      Console.Write("Escolha uma das opções: ");
      escolha = int.Parse(Console.ReadLine());
      
      switch (escolha) {
        case 1:
          Console.Write("Digite o código do produto: ");
          int codProduto = int.Parse(Console.ReadLine());
          
          Console.Write("Digite o nome do produto: ");
          string nomeProduto = Console.ReadLine();
          
          Console.Write("Digite o valor unitário do produto: ");
          double vlrUnitario = Convert.ToDouble(Console.ReadLine());
          
          if (produtos.cadastrarProduto(codProduto, nomeProduto, vlrUnitario)) {
            Console.WriteLine("Produto cadastrado com sucesso!");
          } else {
            Console.WriteLine("Código do produto já existe!");
          };
        break;
        case 2:
          Console.WriteLine(produtos.mostrarProdutos());
          
          Console.Write("Digite o código do produto escolhido: ");
          int escolhaProduto = int.Parse(Console.ReadLine());
          
          Console.Write("Quantas unidades deseja comprar: ");
          int qtdCompra = int.Parse(Console.ReadLine());
          
          if (carrinho.adicionarItem(new ItemCompra(produtos.getProduto(escolhaProduto), qtdCompra))) {
            Console.WriteLine("Produto adicionado ao carrinho com sucesso!");
          } else {
            Console.WriteLine("Produto já existe no carrinho!");
          };
        break;
        case 3:
          Console.WriteLine(carrinho.getResumoCarrinho());
        break;
        case 4:
          Console.WriteLine("Resumo do seu carrinho:");
          Console.WriteLine(carrinho.getResumoCarrinho());
          
          Console.Write("Digite o código do produto a ser removido do carrinho: ");
          int codProdutoRemover = int.Parse(Console.ReadLine());
          
          if (carrinho.removerItem(codProdutoRemover)) {
            Console.WriteLine("Item removido com sucesso!");
          } else {
            Console.WriteLine("Item não foi removido!");
          };
        break;
      }
      
    } while (escolha != 9);
    
  }
  
}