class ContaPoupanca : Conta {

  private double rendimento;
  public double Rendimento {
    get { return rendimento; }
    set { rendimento = value; }
  }

  public override bool Sacar(double valor) {
    if (valor <= (this.saldo - valor)) {
      this.saldo -= valor;
      return true;
    }

    return false;
  }

}