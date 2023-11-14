using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using MemoTest.Entidades;

namespace MemoTest.Controladores
{
    internal class pCategoria
    {
        public static List<Categoria> GetAll()
        {

            List<Categoria> categorias = new List<Categoria>();

            SQLiteCommand cmd = new SQLiteCommand("SELECT id, nombre FROM Categorias");
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();


            while (obdr.Read())
            {
                Categoria a = new Categoria();
                a.Id = obdr.GetInt32(0);
                a.Name = obdr.GetString(1);
                

                categorias.Add(a);
            }
            return categorias;
        }

        public static Categoria GetById(int id)
        {
            Categoria a = new Categoria();
            SQLiteCommand cmd = new SQLiteCommand("SELECT id, nombre FROM Categorias WHERE id = @id");
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();


            while (obdr.Read())
            {

                a.Id = obdr.GetInt32(0);
                a.Name = obdr.GetString(1);
                


            }
            return a;

        }

    }
}
