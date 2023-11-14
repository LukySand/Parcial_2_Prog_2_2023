using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoTest.Entidades
{
    public class ButtonGame : Button    //hacemos una calse que hereda de boton para agregarle mas atributos
    {
        public bool Flipped { get; set; }   //el flipped nos sirve para saber si esta dado vuelta
        public string Value { get; set; }   // el value nos dice que palabra tiene el boton
        public bool LastFlipped { get; set; }   //este booleano nos dice si fue el ultimo boton en darse vuelta

        public ButtonGame() //hacemos un contrucctor para poder crear muchos y que no esten vacios
        {
            Flipped = false;
            Value = null;
            LastFlipped = false;
        }
    }
}