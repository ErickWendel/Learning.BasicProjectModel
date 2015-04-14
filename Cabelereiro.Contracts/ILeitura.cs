using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cabelereiro.Contracts
{
    public interface ILeitura<T> where T : class
    {
        ICollection<T> Listar();
        T PegarPorId(int id);
    }
}
