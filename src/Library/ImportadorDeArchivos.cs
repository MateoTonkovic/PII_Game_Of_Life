using System;
using System.IO;

namespace PII_Game_Of_Life
{
    public class ImportadorDeArchivo
    {

        public static bool[,] LeerArchivo()
        {
            string url = "../../assets/board.txt";
            string contenido = File.ReadAllText(url);
            string[] lineasDeContenido = contenido.Split('\n');
            bool[,] tablero = new bool[lineasDeContenido.Length, lineasDeContenido[0].Length];
            for (int y = 0; y < lineasDeContenido.Length; y++)
            {
                for (int x = 0; x < lineasDeContenido[y].Length; x++)
                {
                    if (lineasDeContenido[y][x] == '1')
                    {
                        tablero[x, y] = true;
                    }
                }
            }
            return tablero;
        }
    }
}
// SRP responsabilidad: lee el archivo de configuración del tablero y lo convierte en una matriz de booleanos
// Expert:  Experta en la lectura de archivos y la conversión de su contenido en una matriz de booleanos