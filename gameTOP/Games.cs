using gameTOP.Interface;

namespace gameTOP
{
     public class Games
    {
        private readonly IJogador _jogadorA;
        private readonly IJogador _jogadorB;

        public Games(IJogador jogadorA, IJogador jogadorB)
        {
            _jogadorA = jogadorA;
            _jogadorB = jogadorB;
        }
        public void novogame()
        {
            System.Console.Write(_jogadorA.Correr());
            System.Console.Write(_jogadorA.Chutar());
            System.Console.Write(_jogadorA.Passar());

            System.Console.Write("\n PROXIMO JOGADOR\n");

            System.Console.Write(_jogadorB.Correr());
            System.Console.Write(_jogadorB.Chutar());
            System.Console.Write(_jogadorB.Passar());
        }
    }
}