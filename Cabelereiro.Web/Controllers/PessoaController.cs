using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cabelereiro.Business;
using Cabelereiro.Model;

namespace Cabelereiro.Web.Controllers
{
    public class PessoaController : Controller
    {
        // GET: Pessoa
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(PessoaMod pessoa)
        {
            try
            {
                var resposta = new PessoaBus().Cadastrar(pessoa);
                if (resposta)
                    return RedirectToAction("Listar");

                return View("Index", pessoa);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public ActionResult Editar(int id)
        {
            try
            {
                var pessoa = new PessoaBus().PegarPorId(id);
                return View(pessoa);

            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPost]
        public ActionResult Editar(PessoaMod pessoa)
        {
            var resposta = new PessoaBus().Atualizar(pessoa);
            if (resposta) return RedirectToAction("Listar");


            return View("Editar", pessoa);
        }

        public ActionResult Deletar(int id)
        {
            try
            {
                var resposta = new PessoaBus().Deletar(id);
                return RedirectToAction("Listar");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ActionResult Listar()
        {
            try
            {
                var pessoa = new PessoaBus().Listar();

                return View(pessoa);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}