using System.Collections.Generic;

class CarrinhoCompra {
  
  // Atributos \o/
  private List<ItemCompra> item = new List<ItemCompra>();
  
  // Construtor \o/
  public CarrinhoCompra() {
    
  }
  
  public CarrinhoCompra(List<ItemCompra> item) {
    this.item = item;
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
    
    resumoCarrinho += "O valor total do carrinho é de R$" + this.getVlrTotalCarrinho();
    
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
  
  // Sobrecarga de operadores - CARRINHO + CARRINHO
  public static CarrinhoCompra operator + (CarrinhoCompra cc1, CarrinhoCompra cc2) {
    CarrinhoCompra novoCarrinho = new CarrinhoCompra(cc1.item);
    
    foreach (ItemCompra itemCarrinho2 in cc2.item) {
      bool naoExiste = true;
      
      foreach (ItemCompra itemCarrinho1 in novoCarrinho.item) {
        if (itemCarrinho2.getProduto().getCodProduto() == itemCarrinho1.getProduto().getCodProduto()) {
          itemCarrinho1.setQtdCompra(itemCarrinho2.getQtdCompra() + itemCarrinho1.getQtdCompra());
          
          naoExiste = false;
        }
      }
      
      if (naoExiste) {
        novoCarrinho.adicionarItem(itemCarrinho2);
      }
    }
    
    return novoCarrinho;
  }
  
}