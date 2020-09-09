class Produto {
  
  // Atributos \o/
  private int codProduto;
  private string nomeProduto;
  private double vlrUnitario;
  
  // Construtor \o/
  public Produto(int codProduto, string nomeProduto, double vlrUnitario) {
    this.codProduto = codProduto;
    this.nomeProduto = nomeProduto;
    this.vlrUnitario = vlrUnitario;
  }
  
  // Métodos GET \o/
  public int getCodProduto() {
    return this.codProduto;
  }
  public string getNomeProduto() {
    return this.nomeProduto;
  }
  public double getVlrUnitario() {
    return this.vlrUnitario;
  }
  
  // Métodos SET \o/
  public void setNomeProduto(string nomeProduto) {
    this.nomeProduto = nomeProduto;
  }
  public void setVlrUnitario(double vlrUnitario) {
    this.vlrUnitario = vlrUnitario;
  }
  
}