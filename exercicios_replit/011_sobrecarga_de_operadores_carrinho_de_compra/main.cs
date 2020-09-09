using System;

class MainClass {
  public static void Main (string[] args) {
    
    CadastroProdutos produtos = new CadastroProdutos();
    CarrinhoCompra carrinho = new CarrinhoCompra();
    
    produtos.cadastrarProduto(0, "Maçã Vermelha", 7.77);
    produtos.cadastrarProduto(1, "Maçã Azul", 6.66);
    produtos.cadastrarProduto(2, "Maçã Laranja", 5.55);
    produtos.cadastrarProduto(3, "Maçã Abóbora", 4.44);
    
    CarrinhoCompra outroCarrinho = new CarrinhoCompra();
    
    carrinho.adicionarItem(new ItemCompra(produtos.getProduto(1), 2));
    carrinho.adicionarItem(new ItemCompra(produtos.getProduto(0), 3));
    carrinho.adicionarItem(new ItemCompra(produtos.getProduto(2), 4));
    outroCarrinho.adicionarItem(new ItemCompra(produtos.getProduto(0), 2));
    outroCarrinho.adicionarItem(new ItemCompra(produtos.getProduto(1), 3));
    
    CarrinhoCompra novoCarrinho = carrinho + outroCarrinho;
    //CarrinhoCompra novoCarrinho = outroCarrinho + carrinho;
    
    Console.WriteLine(novoCarrinho.getResumoCarrinho());
    
    // faltou fazer somar carrinho com produto
    
  }
}