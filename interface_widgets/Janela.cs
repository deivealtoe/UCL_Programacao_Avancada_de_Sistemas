class Janela {

    private bool botaoFechar;
    private bool botaoMax;
    private bool botaoMin;
    private string titulo;
    public string Titulo {
        get { return this.titulo; }
        set { this.titulo = value; }
    }
    private int posX;
    private int posY;

    public Janela(string titulo, int posX, int posY) {
        this.titulo = titulo;
        this.posX = posX;
        this.posY = posY;
    }

    public void MoverJanela(int x, int y) {
        this.posX = x;
        this.posY = y;
    }

}