using System;

class Program {

    static void Main(string[] args) {

        Modal minhaModal = new Modal("Browser LKX", 15, 25);

        minhaModal.AlterarTitulo("Browser KX");
        minhaModal.FullScreen();

        PopUp minhaPopUp = new PopUp("AD Propaganda", 10, 10);

        minhaPopUp.MoverJanela(15, 15);

    }

}