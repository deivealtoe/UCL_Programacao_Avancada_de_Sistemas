using System.Collections.Generic;

class CadastroProdutos {
  
  // Atributos \o/
  private List<Produto> produtosCadastrados = new List<Produto>();
  
  // Construtor \o/
  public CadastroProdutos() {
    
  }
  
  // Métodos GET \o/
  public Produto getProduto(int codProduto) {
    foreach (Produto produto in produtosCadastrados) {
      if (produto.getCodProduto() == codProduto) {
        return produto;
      }
    }
      
    return null;
  }
  
  // Métodos SET \o/
  public bool cadastrarProduto(int codProduto, string nomeProduto, double vlrUnitario) {
    if (produtoExiste(codProduto)) {
      return false;
    }
    
    produtosCadastrados.Add(new Produto(codProduto, nomeProduto, vlrUnitario));
    
    return true;
  }
  
  // Outros métodos \o/
  private bool produtoExiste(int codProduto) {
    foreach (Produto produto in this.produtosCadastrados) {
      if (produto.getCodProduto() == codProduto) {
        return true;
      }
    }
    
    return false;
  }
  public string mostrarProdutos() {
    string produtosString = "";
    
    foreach (Produto produto in produtosCadastrados) {
      produtosString += "Código: " + produto.getCodProduto() + ". Produto: " + produto.getNomeProduto() + ". Valor unitário: R$ " + produto.getVlrUnitario() + ".\n";
    }
    
    return produtosString;
  }
  
}