using System;
using System.Text;
using System.Threading;

namespace PII_Game_Of_Life
{
    public class DibujarTableroo
    {
        public static void DibujarTablero(bool[,] tablero)
        {
            bool[,] tableroDeJuego = tablero;
            int ancho = tablero.GetLength(0);
            int altura = tablero.GetLength(0);

            while (true)
            {
                Console.Clear();
                StringBuilder s = new StringBuilder();
                for (int y = 0; y < altura; y++)
                {
                    for (int x = 0; x < ancho; x++)
                    {
                        if (tableroDeJuego[x, y])
                        {
                            s.Append("|X|");
                        }
                        else
                        {
                            s.Append("___");
                        }
                    }
                    s.Append("\n");
                }
                Console.WriteLine(s.ToString());
                tableroDeJuego = Logica.LogicaDeJuego(tableroDeJuego);
                Thread.Sleep(1000);
            }
        }
    }
}

// Unica responsalidad: Dibujar el tablero en consola
// Es experto en: Dibujar el tablero en consola