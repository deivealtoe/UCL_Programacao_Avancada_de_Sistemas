class Navio {

  private string nome;
  protected int qtdTripulantes;
  protected enum estadoEnum {
    Inoperante,
    MuitoDanificado,
    Danificado,
    Perfeito
  }
  protected estadoEnum estado = estadoEnum.Perfeito;

  public Navio (string nome) {
    this.nome = nome;
  }
  
  public Navio (string nome, int qtdTripulantes) {
    this.nome = nome;
    this.qtdTripulantes = qtdTripulantes;
  }

  public string Nome {
    get { return nome; }
    set { nome = value; }
  }

}