using gameTOP.Interface;

namespace gameTOP.lib
{
    public class Jogador2 : IJogador
    {
        public readonly string _Nome;

        public Jogador2(string nome = "")
        {
            _Nome = nome;
        }
        public string Chutar()
        {
            return "Luis esta Chutando\n";
        }

        public string Correr()
        {
            return "Luis esta Correndo\n";
        }

        public string Passar()
        {
            return "Luis esta Passando\n";
        }
    }
}