class NavioDeGuerra : Navio {

  protected float blindagem;
  protected float ataque;

  public NavioDeGuerra (string nome, float blindagem, float ataque) : base (nome)  {
    this.blindagem = blindagem;
    this.ataque = ataque;
  }

  public NavioDeGuerra (string nome, int qtdTripulantes, float blindagem, float ataque) : base (nome, qtdTripulantes) {
    this.blindagem = blindagem;
    this.ataque = ataque;
  }

  private void AlterarEstado () {
    switch (this.estado) {
      case estadoEnum.Perfeito:
        estado = estadoEnum.Danificado;
        break;
      case estadoEnum.Danificado:
        estado = estadoEnum.MuitoDanificado;
        break;
      case estadoEnum.MuitoDanificado:
        estado = estadoEnum.Inoperante;
        break;
    }
  }

  private void ReceberDano (float ataque) {
    if (this.blindagem > 0) {
      this.blindagem -= ataque;
    } else {
      this.AlterarEstado();
    }
  }

  public float GetAtaque () {
    float ataqueAux = this.ataque;

    switch (this.estado) {
      case estadoEnum.Danificado:
        ataqueAux = this.ataque * (float) 0.4;
        break;
      case estadoEnum.MuitoDanificado:
        ataqueAux = this.ataque * (float) 0.2;
        break;
      case estadoEnum.Inoperante:
        ataqueAux = 0;
        break;
    }

    return ataqueAux;
  }

  public void Atacar (NavioDeGuerra n) {
    if (this.estado != estadoEnum.Inoperante) {
      n.ReceberDano(this.GetAtaque());
    }
  }

  public string EstadoDoNavio () {
    return "Nome: " + Nome + " / Blindagem: " + this.blindagem + " / Ataque: " + this.GetAtaque() + " / Estado: " + this.estado;
  }

  public static string operator > (NavioDeGuerra n1, NavioDeGuerra n2) {
    n1.Atacar(n2);

    return "O navio " + n1.Nome + " atacou o navio " + n2.Nome;
  }

  public static string operator < (NavioDeGuerra n1, NavioDeGuerra n2) {
    n2.Atacar(n1);

    return "O navio " + n2.Nome + " atacou o navio " + n1.Nome;
  }

}