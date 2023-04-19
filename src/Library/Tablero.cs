using System;
using System.Text;

namespace PII_Game_Of_Life
{
    public class Tablero
    {

        public bool[,] tableroDeJuego { get; }
        public int alturaTablero { get; }
        public int anchoTablero { get; }

        public Tablero(bool[,] tablero)
        {
            this.tableroDeJuego = tablero;
            this.alturaTablero = tablero.GetLength(0);
            this.anchoTablero = tablero.GetLength(1);
        }



    }
}

// Unica responsalidad: armar el tablero
// Es experto en: armar el tablero