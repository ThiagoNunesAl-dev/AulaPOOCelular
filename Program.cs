using System;

namespace AulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular xiaomi = new Celular();
            Console.WriteLine (xiaomi.cor = "Preto");
            Console.WriteLine (xiaomi.modelo = "Redmi 6A");
            Console.WriteLine (xiaomi.tamanho = 7);

            Console.WriteLine ("O celular está ligado? (false para desligado e true para ligado)");
            bool status = bool.Parse(Console.ReadLine());
            xiaomi.ligado = status;
            Console.WriteLine (xiaomi.Ligar(xiaomi.modelo));

            desligamento:
            Console.WriteLine ("Você deseja desligar o celular? (sim ou não)");
            string r1 = Console.ReadLine ();
            if (r1 == "sim") {
                Console.WriteLine (xiaomi.Desligar(xiaomi.modelo));
                goto final;
            }
            if (r1 == "não") {
                Console.WriteLine ("O celular não será desligado.");
            }
            else {
                goto desligamento;
            }

            ligação:
            Console.WriteLine ("Você deseja fazer uma ligação? (sim ou não)");
            string r2 = Console.ReadLine ();
            if (r2 == "sim") {
                Console.WriteLine (xiaomi.FazerLigacao(xiaomi.modelo));
                goto mensagem;
            }
            if (r2 == "não") {
                Console.WriteLine ("O celular não fará nenhuma ligação.");
            }
            else {
                goto ligação;
            }

            mensagem:
            Console.WriteLine ("Você deseja enviar uma mensagem? (sim ou não)");
            string r3 = Console.ReadLine ();
            if (r3 == "sim") {
                Console.WriteLine (xiaomi.EnviarMensagem(xiaomi.modelo));
                goto final;
            }
            if (r2 == "não") {
                Console.WriteLine ("O celular não enviará nenhuma mensagem.");
                goto final;
            }
            else {
                goto mensagem;
            }

            final:
            Console.WriteLine("Fim das operações");
        }
    }
}
