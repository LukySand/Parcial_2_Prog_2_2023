using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoTest.Entidades
{
    public class Palabra
    {
        public int Id { get; set; }
        public string? Texto { get; set; }
        public Categoria? Categoria { get; set; }
    }
}
