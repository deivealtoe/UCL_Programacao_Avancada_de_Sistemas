class PortaAvioes : NavioDeGuerra {

  protected int qtdAvioes;

  public PortaAvioes (string nome, float blindagem, float ataque, int qtdAvioes) : base (nome, blindagem, ataque) {
    this.ataque = ataque * qtdAvioes;
  }

  public PortaAvioes (string nome, int qtdTripulantes, float blindagem, float ataque, int qtdAvioes) : base (nome, qtdTripulantes, blindagem, ataque) {
    this.ataque = ataque * qtdAvioes;
  }

}