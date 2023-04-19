using System;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] archivoDeTablero = ImportadorDeArchivo.LeerArchivo();
        
            Tablero tablero = new Tablero(archivoDeTablero);
         
            DibujarTableroo.DibujarTablero(tablero.tableroDeJuego);
        }
    }
}