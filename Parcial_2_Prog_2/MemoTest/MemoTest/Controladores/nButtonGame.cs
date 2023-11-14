using MemoTest.Entidades;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoTest.Controladores
{
    public class nButtonGame
    {
        public static ButtonGame[,] CreateEasyLevel(int categoryId)     //el metodo devuelve una matriz de botones de 3x2 con los temas en un orden random
        {
            ButtonGame[,] easyLevel = CreateMatrix(new ButtonGame[4, 3]); //primero se crea la matriz a retornar con un metodo que la llena
            Palabra[] words = new Palabra[6]; //se crea un array de palabras que se van a a cargar en la matriz (se hace un random detro de la categoria para que no aparezcan siempre las mismas palabras)
            Random r = new Random();    //usamos una clase random que la vamos a usar para hacer nuestros numeros aleatorios

            int randomRow;  //esto lo vamos a usar mas adelante para tirar valores random en la matriz
            int randomCol;  //esto lo vamos a usar mas adelante para tirar valores random en la matriz
            List<Palabra> palabras = pPalabra.GetAllbyCategoria(categoryId);    //se traen todas las palabras de la categoria elegida

            palabras = palabras.OrderBy(_ => r.Next()).ToList();    //esto es una lamda function que me ordena las palabras que se trajeron por categoria en base al numero random r

            for (int x = 0; x < words.Length; x++)  //las primeras palabras ordenadas se cargan con un for a un array
            {
                words[x] = palabras[x];
            }

            foreach (Palabra p in words)        //por cada palabra en el array que tiene el mismo tamaño que los pares que tiene la matriz se saca cada palabra
            {
                for (int x = 0; x < 2; x++) //se repite 2 veces porque cada palabra es 1 par
                {
                    while (true)    //con un while true se repite la funcion que compara si alguna posicion es nulla y ahi se guarda el valor
                    {
                        randomRow = r.Next(4);
                        randomCol = r.Next(3);

                        if (easyLevel[randomRow, randomCol].Value == null)
                        {
                            easyLevel[randomRow, randomCol].Value = p.Texto;
                            break;  //si se encuentra un valor se termina el while y s sigue con la siguiente palabra hasta que se termine el foreach
                        }
                    }
                }
            }
            return easyLevel;      //sedevuelve el nivel facil
        }

        public static ButtonGame[,] CreateMatrix(ButtonGame[,] bt)  //esta funcion recorre el array y llena la funcion de bottones
        {
            ButtonGame[,] bttt = bt;    //se crea un nuevo buttonGame y se lo iguala al que se le esta pasando por parametros
            for (int row = 0; row < bt.GetLength(0); row++)
            {
                for (int column = 0; column < bt.GetLength(1); column++)    //se recorre la matriz
                {
                    bttt[row,column] = new ButtonGame();    //a acada una de las posiciones de la matriz se le agrega un boton con los atributos del constructor
                }
            }
            return bttt;    //se devuelve la matriz llena
        }

        public static ButtonGame[,] CreateHardLevel(int categoryId)
        {
            ButtonGame[,] hardLevel = CreateMatrix(new ButtonGame[6, 4]); //primero se crea la matriz a retornar con un metodo que la llena
            Palabra[] words = new Palabra[12]; //se crea un array de palabras que se van a a cargar en la matriz (se hace un random detro de la categoria para que no aparezcan siempre las mismas palabras)
            Random r = new Random();    //usamos una clase random que la vamos a usar para hacer nuestros numeros aleatorios

            int randomRow;  //esto lo vamos a usar mas adelante para tirar valores random en la matriz
            int randomCol;  //esto lo vamos a usar mas adelante para tirar valores random en la matriz
            List<Palabra> palabras = pPalabra.GetAllbyCategoria(categoryId);    //se traen todas las palabras de la categoria elegida

            palabras = palabras.OrderBy(_ => r.Next()).ToList();    //esto es una lamda function que me ordena las palabras que se trajeron por categoria en base al numero random r

            for (int x = 0; x < words.Length; x++)  //las primeras palabras ordenadas se cargan con un for a un array
            {
                words[x] = palabras[x];
            }

            foreach (Palabra p in words)        //por cada palabra en el array que tiene el mismo tamaño que los pares que tiene la matriz se saca cada palabra
            {
                for (int x = 0; x < 2; x++) //se repite 2 veces porque cada palabra es 1 par
                {
                    while (true)    //con un while true se repite la funcion que compara si alguna posicion es nulla y ahi se guarda el valor
                    {
                        randomRow = r.Next(6);
                        randomCol = r.Next(4);

                        if (hardLevel[randomRow, randomCol].Value == null)
                        {
                            hardLevel[randomRow, randomCol].Value = p.Texto;
                            break;  //si se encuentra un valor se termina el while y s sigue con la siguiente palabra hasta que se termine el foreach
                        }
                    }
                }
            }
            return hardLevel;   //se devuelve el nivel dificil
        }
    }
}