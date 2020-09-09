abstract class Conta {

  private int numero;
  public int Numero {
    get { return numero; }
    set { numero = value; }
  }

  private string titular;
  public string Titular {
    get { return titular; }
    set { titular = value; }
  }

  protected double saldo;
  public double Saldo {
    get { return saldo; }
  }

  public void Depositar(double valor) {
    this.saldo += valor;
  }

  public abstract bool Sacar(double valor);

  public string Relatorio() {
    return "Número: " + this.numero + " / Titular: " + this.titular + " / Saldo: " + this.saldo;
  }

}