using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cabelereiro.Contracts
{
    public interface IEscrita<T> where T : class
    {
        bool Atualizar(T dadosMod);
        bool Deletar(T dadosMod);
        bool Cadastrar(T dadosMod);
    }
}
