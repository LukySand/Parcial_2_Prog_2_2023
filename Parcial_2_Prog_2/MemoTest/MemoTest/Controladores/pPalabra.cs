using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using MemoTest.Entidades;

namespace MemoTest.Controladores
{
    internal class pPalabra
    {
        public static List<Palabra> GetAll()
        {

            List<Palabra> palabras = new List<Palabra>();

            SQLiteCommand cmd = new SQLiteCommand("SELECT id, palabra, id_categoria FROM Palabras");
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();


            while (obdr.Read())
            {
                Palabra a = new Palabra();
                a.Id = obdr.GetInt32(0);
                a.Texto = obdr.GetString(1);
                a.Categoria = pCategoria.GetById(obdr.GetInt32(2));


                palabras.Add(a);
            }
            return palabras;
        }

        public static List<Palabra> GetAllbyCategoria(int id_categoria)
        {

            List<Palabra> palabras = new List<Palabra>();

            SQLiteCommand cmd = new SQLiteCommand("SELECT id, palabra, id_categoria FROM Palabras Where id_categoria = @id_categoria");
            cmd.Parameters.Add(new SQLiteParameter("@id_categoria", id_categoria));
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();


            while (obdr.Read())
            {
                Palabra a = new Palabra();
                a.Id = obdr.GetInt32(0);
                a.Texto = obdr.GetString(1);
                //MessageBox.Show(obdr.GetString(1));
                a.Categoria = pCategoria.GetById(obdr.GetInt32(2));


                palabras.Add(a);
            }
            return palabras;
        }

        public static Palabra GetById(int id)
        {
            Palabra a = new Palabra();
            SQLiteCommand cmd = new SQLiteCommand("SELECT id, palabra, id_categoria FROM Palabras WHERE id = @id");
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();


            while (obdr.Read())
            {

                a.Id = obdr.GetInt32(0);
                a.Texto = obdr.GetString(1);
                a.Categoria = pCategoria.GetById(obdr.GetInt32(2));



            }
            return a;

        }
    }
}
