class ItemCompra {
  
  // Atributos \o/
  private Produto produto;
  private int qtdCompra;
  
  // Construtor \o/
  public ItemCompra(Produto produto, int qtdCompra) {
    this.produto = produto;
    this.qtdCompra = qtdCompra;
  }
  
  // Métodos GET \o/
  public Produto getProduto() {
    return this.produto;
  }
  public int getQtdCompra() {
    return this.qtdCompra;
  }
  public double getVlrTotal() {
    return this.produto.getVlrUnitario() * this.qtdCompra;
  }
  
  // Métodos SET \o/
  public void setProduto(Produto produto) {
    this.produto = produto;
  }
  public void setQtdCompra(int qtdCompra) {
    this.qtdCompra = qtdCompra;
  }
  
}