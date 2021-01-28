using System;
using gameTOP.lib;

namespace gameTOP
{
    class program
    {
        static void Main(string[] args)
        {
            var jogo = new Games
            (
                new Jogador1(),
                new Jogador2()
                );

            jogo.novogame();
        }
    }

}