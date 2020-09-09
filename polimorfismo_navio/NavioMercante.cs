using System;

class NavioMercante : Navio {

  private float carga;
  private float capacidadeCarga;

  public NavioMercante (string nome, float capacidadeCarga) : base (nome) {
    this.capacidadeCarga = capacidadeCarga;
  }

  public NavioMercante (string nome, int qtdTripulantes, float capacidadeCarga) : base (nome, qtdTripulantes) {
    this.capacidadeCarga = capacidadeCarga;
  }

  public NavioMercante (string nome, int qtdTripulantes, float capacidadeCarga, float carga) : base (nome, qtdTripulantes) {
    this.capacidadeCarga = capacidadeCarga;
    this.carga = this.cargaValidada(capacidadeCarga, carga);
  }

  public void Carregamento () {
    Console.WriteLine("O navio de nome " + Nome + " com " + this.qtdTripulantes + " tripulantes, possui volume de carga de " + (this.carga / this.capacidadeCarga));
  }

  public float cargaValidada (float capacidadeCarga, float carga) {
    return carga > capacidadeCarga ? 0 : carga;
  }

}