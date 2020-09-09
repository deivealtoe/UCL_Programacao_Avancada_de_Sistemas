class Aeronave : Veiculo {

  public Aeronave (string tipoVeiculo) : base (tipoVeiculo) {}

  public override string Mover () {
    return "Movendo a aeronave";
  }

  public override string Parar() {
    return "Aterrissando a aeronave";
  }

}