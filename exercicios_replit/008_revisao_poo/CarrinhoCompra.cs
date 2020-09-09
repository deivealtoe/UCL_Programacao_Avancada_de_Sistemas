using System.Collections.Generic;

class CarrinhoCompra {
  
  // Atributos \o/
  private List<ItemCompra> item = new List<ItemCompra>();
  
  // Construtor \o/
  public CarrinhoCompra() {
    
  }
  
  // Métodos GET \o/
  public double getVlrTotalCarrinho() {
    double vlrTotalCarrinho = 0;
    
    foreach (ItemCompra item in this.item) {
      vlrTotalCarrinho += item.getVlrTotal();
    }
    
    return vlrTotalCarrinho;
  }
  public string getResumoCarrinho() {
    string resumoCarrinho = "";
    
    foreach (ItemCompra item in this.item) {
      resumoCarrinho += "Cód. " + item.getProduto().getCodProduto() + ". Produto: " + item.getProduto().getNomeProduto() + ". Qtd. no carrinho: " + item.getQtdCompra() + ". Vlr. Unitário: R$" + item.getProduto().getVlrUnitario() + ". Total: R$" + item.getProduto().getVlrUnitario() * item.getQtdCompra() + ".\n";
    }
    
    resumoCarrinho += "O valor total do carrinho é de R$" + this.getVlrTotalCarrinho() + "\n.";
    
    return resumoCarrinho;
  }
  
  // Métodos SET \o/
  public bool adicionarItem(ItemCompra item) {
    if (itemExiste(item.getProduto().getCodProduto())) {
      return false;
    }
    
    this.item.Add(item);
    
    return true;
  }
  public bool removerItem(int codProduto) {
    int contador = 0;
    
    foreach (ItemCompra item in this.item) {
      if (item.getProduto().getCodProduto() == codProduto) {
        this.item.RemoveAt(contador);
        
        return true;
      }
      
      contador++;
    }
    
    return false;
  }
  
  // Outros métodos \o/
  private bool itemExiste(int codProduto) {
    foreach (ItemCompra itemCompra in this.item) {
      if (itemCompra.getProduto().getCodProduto() == codProduto) {
        return true;
      }
    }
    
    return false;
  }
  
}