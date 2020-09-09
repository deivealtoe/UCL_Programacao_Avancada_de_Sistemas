class ContaCorrente : Conta {

  private double taxaAdministrativa = 0.30;
  public double TaxaManutencao {
    get { return taxaAdministrativa; }
    set { taxaAdministrativa = value; }
  }

  public override bool Sacar(double valor) {
    if (valor <= (this.saldo - (valor + this.taxaAdministrativa))) {
      this.saldo -= valor + this.taxaAdministrativa;
      return true;
    }

    return false;
  }

}