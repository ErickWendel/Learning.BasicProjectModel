using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cabelereiro.DataBase;
using Cabelereiro.Model;

namespace Cabelereiro.Repository.Base
{
    public abstract class Base<T> : Contracts.IEscrita<T>, Contracts.ILeitura<T> where T : class
    {
        public ICollection<T> Listar()
        {
            using (var conexao = new BancoContext())
            {
                var lista = conexao.Set<T>().ToList();
                return lista;
            }
        }

        public T PegarPorId(int id)
        {
            using (var conexao = new BancoContext())
            {
                var obj = conexao.Set<T>().Find(id);
                return obj;
            }
        }

        public bool Cadastrar(T item)
        {
            using (var conexao = new BancoContext())
            {
                conexao.Set<T>().Add(item);
                return conexao.SaveChanges() > 0 ? true : false;
            }

        }
        public bool Atualizar(T item)
        {
            using (var conexao = new BancoContext())
            {
                conexao.Entry(item).State = EntityState.Modified;
                return conexao.SaveChanges() > 0 ? true : false;
            }

        }

        public bool Deletar(T item)
        {
            using (var conexao = new BancoContext())
            {
                
                conexao.Entry(item).State = EntityState.Deleted;
                return conexao.SaveChanges() > 0 ? true : false;

            }

        }
    }
}
