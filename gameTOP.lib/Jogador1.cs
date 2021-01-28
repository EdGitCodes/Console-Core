using gameTOP.Interface;

namespace gameTOP.lib
{
    public class Jogador1 : IJogador
    {
        public readonly string _Nome;
        public Jogador1(string nome = "Ledat")
        {
            _Nome = nome;
        }

        public string Chutar()
        {
            return $"{_Nome} esta chutando \n";
        }

        public string Correr()
        {
            return $"{_Nome} esta correndo \n";
        }

        public string Passar()
        {
            return $"{_Nome} esta passando \n";
        }
    }
}