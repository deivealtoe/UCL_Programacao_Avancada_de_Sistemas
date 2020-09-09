using System;

class Circunferencia {
  private Ponto ponto;
  private float raio;
  
  public Circunferencia(Ponto ponto, float raio) {
    this.ponto = ponto;
    this.raio = raio;
  }
  
  public string getCircunferenciaString() {
    return "O ponto é " + this.ponto.getXY() + " e seu raio é de " + this.raio;
  }
  
  public float getArea() {
    return ((float) 3.1415) * (this.raio * this.raio);
  }
  
  public static Circunferencia operator + (Circunferencia c1, Circunferencia c2) {
    float a = (c1.ponto.getX() + c2.ponto.getX()) / 2;
    float b = (c1.ponto.getY() + c2.ponto.getY()) / 2;
    
    float raio = c1.raio + c2.raio;
    
    return new Circunferencia(new Ponto(a, b), raio);
  }
  
  public static bool operator > (Circunferencia c1, Circunferencia c2) {
    return c1.getArea() > c2.getArea() ? true : false;
  }
  
  public static bool operator < (Circunferencia c1, Circunferencia c2) {
    return c1.getArea() < c2.getArea() ? true : false;
  }
  
  public static bool operator >= (Circunferencia c1, Circunferencia c2) {
    return c1.getArea() >= c2.getArea() ? true : false;
  }
  
  public static bool operator <= (Circunferencia c1, Circunferencia c2) {
    return c1.getArea() <= c2.getArea() ? true : false;
  }
}