using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cabelereiro.DataBase;
using Cabelereiro.Model;

namespace Cabelereiro.Common
{
    public class PessoasDataMapper
    {

        public PessoaMod ToModel(pessoas pessoas)
        {
            return new PessoaMod
            {
                Id = pessoas.Id,
                Nome = pessoas.nome
            };
        }

        public pessoas FromModel(PessoaMod pessoas)
        {
            return new pessoas
            {
                Id = pessoas.Id,
                nome = pessoas.Nome
            };
        }
    }
}
