class Cruzador : NavioDeGuerra {

  protected int qtdCanhoes;

  public Cruzador (string nome, float blindagem, float ataque, int qtdCanhoes) : base (nome, blindagem, ataque) {
    this.ataque = ataque * qtdCanhoes / 2;
  }

  public Cruzador (string nome, int qtdTripulantes, float blindagem, float ataque, int qtdCanhoes) : base (nome, qtdTripulantes, blindagem, ataque) {
    this.ataque = ataque * qtdCanhoes / 2;
  }

}