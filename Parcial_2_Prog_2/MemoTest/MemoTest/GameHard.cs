using MemoTest.Controladores;
using MemoTest.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoTest
{
    public partial class GameHard : Form
    {
        public int FlippedPairs = 0; // Esto lo utilizamos para saber cuantos pares ya le pegaste y saber cuando terminar el el juego
        public static int fl = 1; // Metodo que se asegura que antes de comparar, halla 2 bottones dados vueltas. cuando es 1 sabemos que hay 2 bottones dados vueltas

        public GameHard() // Escondemos los paneles que no queremos que sean visibles y metemos los que si, que por alguna razon si no metes el show debes en cuando se bugeaba
        {
            InitializeComponent();
            panelEndGame.Hide();
            panelHardRight.Show();
            CreateGameHard();
        }

        private void GameHard_Load(object sender, EventArgs e) // Vacio pero si lo sacamos se bugea todo el codigo y no tenemos tiempo de arreglarlo
        {

        }

        public void CreateGameHard()
        {
            ButtonGame[,] buttonGames = nButtonGame.CreateHardLevel(Program.Category); // Este metodo le devuelve una matriz de ButtonGames con valores ya inicializados

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++) // Inserta cada una de las ButtonBox dentro de un TableLayoutPanel
                {
                    buttonGames[j, i].Text = buttonGames[j, i].Value; // El value es un valor hecho por nosotros que contiene el nombre del, por ejemplo animal
                    buttonGames[j, i].Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    buttonGames[j, i].Dock = DockStyle.Fill;
                    buttonGames[j, i].ForeColor = Color.Black;
                    buttonGames[j, i].Click += GameButtonClick;


                    GridHardRight.Controls.Add(buttonGames[j, i], j, i);// Agrega el buttonbox a la matriz
                }
            }
        }

        public void GameButtonClick(object sender, EventArgs e)
        {
            ButtonGame bt = (ButtonGame)sender;
            bt.BackColor = Color.PowderBlue; // Cambiamos el color del botton para que sebas cual tenes seleccionado
            bt.LastFlipped = true; // Esta variable se guarda dentro de ButtonBox y nos hace sabe cual fue el ultimo boton apretado que es necesario para la comparacion

            fl = fl * -1; // Se multiplica por -1 para que solo se ejecute 2 vez cada 2 veces

            bool equals = false; // Este bool se usa para saber si se acerto en los valores elejidos

            if (fl == 1)
            {
                foreach (ButtonGame b in GridHardRight.Controls)
                {
                    if (b.LastFlipped == true && b.Value == bt.Value && b != bt) // Si es acertado los dos botones que dio vuelta, mantiene los colores claros, no de deja modificar mas los botones,reinicia los last flipped, y le grega 1 valor a la variable LastFlipped para saber cuantos viene teniendo correctos
                    {
                        b.Flipped = true;
                        bt.Flipped = true;
                        b.ForeColor = Color.White;  //si el boton es correcto y tiene par se le pone la letra en blanco, mientras que si solo se lo da vuelta la letra esta en celeste.
                        bt.ForeColor = Color.White; 
                        b.Enabled = false;
                        bt.Enabled = false;
                        b.LastFlipped = false;
                        bt.LastFlipped = false;
                        FlippedPairs += 1;  //se le suma 1 a el int flipped pairs que basicamente hace que depues podamos saber si termino el juego o no
                        equals = true;
                        if (FlippedPairs == 12) panelEndGame.Show(); // Si es que ya adivino 12, significa que termino el Juego
                        break;
                    }
                }

                if (equals == false) // Si es que no le pego a la variable se ejecuta lo siguiente
                {
                    foreach (ButtonGame b in GridHardRight.Controls)
                    {
                        b.Enabled = false; // Esto es necesario para que mientras 2 cajas estan dadas vueltas, uno no pueda empezar a dar vuelta otras
                    }
                    System.Windows.Forms.Timer delayTimer = new System.Windows.Forms.Timer();
                    delayTimer.Interval = 1000;
                    delayTimer.Tick += (s, args) => // Esto ejecuta el codigo despues de cierto tiempo, asi podes ver el nombre del boton que diste vuelta, queriamos hacerlo con un thread.Sleep() pero eso rompe todo el programa.
                    {
                        foreach (ButtonGame b in GridHardRight.Controls) // Hace lo mismo que la funcion de arriba solo que al revez, esconde ambos botones, les pone el LastFlipped = false, etc
                        {
                            b.Enabled = true;
                            if (b.LastFlipped == true)
                            {
                                b.Flipped = false;
                                bt.Flipped = false;
                                b.BackColor = Color.Black;  //si el boton no era el correcto ponemos todo en negro para que no se vea que hay detras
                                bt.BackColor = Color.Black; //aca lo mismo, con el fondo del boton
                                b.ForeColor = Color.Black;  //aca lo mismo con la letra del boton
                                bt.ForeColor = Color.Black;
                                b.Enabled = true;
                                bt.Enabled = true;
                                b.LastFlipped = false;
                                bt.LastFlipped = false;
                                
                            }
                        }
                        delayTimer.Stop();
                        delayTimer.Dispose();
                    };

                    delayTimer.Start();
                }


            }

        }

        private void button1_Click(object sender, EventArgs e) // Cierra el programa una vez que cumple el objetivo
        {
            Close();
        }
    }
}

