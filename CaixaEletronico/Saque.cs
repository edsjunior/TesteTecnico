using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    public class Saque
    {
        public DBNotas db { get; set; }

        public Saque()
        {
            db = new DBNotas();
        }

        public IList<Nota> NotasParaSaque()
        {
            return db.Notas.ToList();

        }
    }
}
