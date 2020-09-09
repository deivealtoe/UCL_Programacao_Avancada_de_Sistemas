using System;

class Veiculo {

  private string tipo;
  public string Tipo {
    get { return tipo; }
    set { tipo = value; }
  }

  public Veiculo (string tipoVeiculo) {
    this.tipo = tipoVeiculo;
  }

  public virtual string Mover() {
    return String.Empty;
  }

  public virtual string Parar() {
    return String.Empty;
  }

}