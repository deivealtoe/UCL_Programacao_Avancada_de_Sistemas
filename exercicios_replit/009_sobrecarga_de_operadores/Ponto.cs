class Ponto {
  private int x, y;
  
  public Ponto(int x, int y) {
    this.x = x;
    this.y = y;
  }
  
  public string getXY() {
    return "X = " + this.x + " || Y = " + this.y;
  }

  public static Ponto operator + (Ponto p1, Ponto p2) {
    int a, b;
    
    a = p1.x + p2.x;
    b = p1.y + p2.y;
    
    return new Ponto(a, b);
  }
  
  public static Ponto operator - (Ponto p1, Ponto p2) {
    int a, b;
    
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