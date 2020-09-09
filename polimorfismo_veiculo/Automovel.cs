class Automovel : Veiculo {

  public Automovel (string tipoVeiculo) : base (tipoVeiculo) {}

  public override string Mover () {
    return "Acelerando o veículo";
  }

  public override string Parar() {
    return "Parando o veículo";
  }

}