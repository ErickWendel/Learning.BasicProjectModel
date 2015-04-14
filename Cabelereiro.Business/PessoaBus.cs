using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cabelereiro.Common;
using Cabelereiro.Model;
using Cabelereiro.Repository;

namespace Cabelereiro.Business
{
    public sealed class PessoaBus
    {
        //aqui nao é preciso colocar a implementacao padrao, pois ele virá da classe herdada
        //passando a classe de modelo, 
        public IEnumerable<PessoaMod> Listar()
        {
            var list =  new PessoaRep().Listar();
            return list.Select(pessoas => new PessoasDataMapper().ToModel(pessoas));
        }

        public PessoaMod PegarPorId(int id)
        {
            var pessoa = new PessoaRep().PegarPorId(id);
            return new PessoasDataMapper().ToModel(pessoa);
        }

        public bool Atualizar(PessoaMod dadosMod)
        {
            var pessoa = new PessoasDataMapper().FromModel(dadosMod);
            return new PessoaRep().Atualizar(pessoa);
        }

        
        public bool Deletar(int id)
        {
            var pessoa = new PessoaRep().PegarPorId(id);
            return new PessoaRep().Deletar(pessoa);
        }

        public bool Cadastrar(PessoaMod dadosMod)
        {
            var pessoa = new PessoasDataMapper().FromModel(dadosMod);
            return new PessoaRep().Cadastrar(pessoa);
        }
    }
}
