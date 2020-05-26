namespace AulaPOOCelular
{
    public class Celular
    {
        public string cor;
        public string modelo;
        public int tamanho;
        public bool ligado;

        public string Ligar (string modelo) {
            if (!ligado) {
                 return "O "+modelo+" está sendo ligado.";
            }               
            else {
                return "O "+modelo+" modelo já está ligado.";
            }
        }

        public string Desligar (string modelo) {
            return "O "+modelo+" está sendo desligado.";
        }

        public string FazerLigacao (string modelo) {
            return "O "+modelo+" está fazendo uma ligação.";
        }

        public string EnviarMensagem (string modelo) {
            return "O "+modelo+" está enviando uma mensagem.";
        }
    }
}