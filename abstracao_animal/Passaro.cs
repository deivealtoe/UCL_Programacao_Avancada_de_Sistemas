abstract class Passaro : Animal {

    private float velocidadeVoo;
    public float VelocidadeVoo {
        get { return velocidadeVoo; }
        set { velocidadeVoo = value; }
    }

    public string Voar() {
        return "Batendo as asas!";
    }

}