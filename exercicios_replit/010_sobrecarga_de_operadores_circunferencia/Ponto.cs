class Ponto {
  private float x, y;
  
  public Ponto(float x, float y) {
    this.x = x;
    this.y = y;
  }
  
  public float getX() {
    return this.x;
  }
  
  public float getY() {
    return this.y;
  }
  
  public string getXY() {
    return "{X = " + this.x + ", Y = " + this.y + "}";
  }

  public static Ponto operator + (Ponto p1, Ponto p2) {
    float a, b;
    
    a = p1.x + p2.x;
    b = p1.y + p2.y;
    
    return new Ponto(a, b);
  }
  
  public static Ponto operator - (Ponto p1, Ponto p2) {
    float a, b;
    
    a = p1.x - p2.x;
    b = p1.y - p2.y;
    
    return new Ponto(a, b);
  }
  
  public static Ponto operator ++ (Ponto p) {
    p.x++;
    p.y++;
    
    return p;
  }
  
  public static Ponto operator -- (Ponto p) {
    p.x--;
    p.y--;
    
    return p;
  }
}