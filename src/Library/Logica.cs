namespace PII_Game_Of_Life
{
    public class Logica
    {
        public static bool[,] LogicaDeJuego(bool[,] tablero)
        {
            bool[,] tableroDeJuego = tablero;
            int alturaTablero = tablero.GetLength(0);
            int anchoTablero = tablero.GetLength(1);

            bool[,] clonarTablero = new bool[alturaTablero, anchoTablero];
            for (int x = 0; x < alturaTablero; x++)
            {
                for (int y = 0; y < anchoTablero; y++)
                {
                    int vecinosVivos = 0;
                    for (int i = x - 1; i <= x + 1; i++)
                    {
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            if (i >= 0 && i < alturaTablero && j >= 0 && j < anchoTablero && tableroDeJuego[i, j])
                            {
                                vecinosVivos++;
                            }
                        }
                    }
                    if (tableroDeJuego[x, y])
                    {
                        vecinosVivos--;
                    }
                    if (tableroDeJuego[x, y] && vecinosVivos < 2)
                    {
                        //Celula muere por baja población
                        clonarTablero[x, y] = false;
                    }
                    else if (tableroDeJuego[x, y] && vecinosVivos > 3)
                    {
                        //Celula muere por sobrepoblación
                        clonarTablero[x, y] = false;
                    }
                    else if (!tableroDeJuego[x, y] && vecinosVivos == 3)
                    {
                        //Celula nace por reproducción
                        clonarTablero[x, y] = true;
                    }
                    else
                    {
                        //Celula mantiene el estado que tenía
                        clonarTablero[x, y] = tableroDeJuego[x, y];
                    }
                }
            }
            tableroDeJuego = clonarTablero;
            return tableroDeJuego;

        }
    }
}
// Unica responsalidad: Aplicar las reglas del juego de la vida a un tablero