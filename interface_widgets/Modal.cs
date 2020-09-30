class Modal : Janela, IDimensionavel {

    private int maxAlt;
    private int maxLarg;
    private int atualAlt;
    private int atualLarg;

    public Modal(string titulo, int posX, int posY) : base (titulo, posX, posY) {}

    public void AlterarTitulo(string t) {
        this.Titulo = t;
    }

    public void FullScreen() {
        this.atualAlt = this.maxAlt;
        this.atualLarg = this.maxLarg;
    }

    public void SetLargura(int larg) {
        if (larg >= 1 && larg <= this.maxLarg) {
            this.atualLarg = larg;
        }
    }

    public void SetAltura(int alt) {
        if (alt >= 1 && alt <= this.maxAlt) {
            this.atualAlt = alt;
        }
    }

}