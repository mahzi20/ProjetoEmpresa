using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Windows;
using ProjEmpresa.Dao;
using ProjEmpresa.Models;
using RestSharp;

namespace ProjEmpresa.Controllers
{
    public class EmpresasController : Controller
    {
        private EFContext db = new EFContext();

        // GET: Empresas
        public ActionResult Index(string searchString)
        {
            var empresa = from s in db.Empresas
                          select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                empresa = empresa.Where(s => s.nome.Contains(searchString)
                                       || s.cnpj == (searchString));

                return View(empresa.ToList());
            }
                return View(db.Empresas.ToList());

        }


        // GET: Empresas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empresa empresa = db.Empresas.Find(id);
            if (empresa == null)
            {
                return HttpNotFound();
            }
            return View(empresa);
        }

        // GET: Empresas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Empresas/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(string cnpj, [Bind(Include = "idEmpresa,cnpj,nome,dataAbertura,atividade")] Empresa empresa)
        {
            if (ModelState.IsValid)
            {
                var consempresa = from s in db.Empresas
                              select s;
                if (!String.IsNullOrEmpty(cnpj))
                {
                    consempresa = consempresa.Where(s => s.cnpj == (cnpj));
                    if (consempresa.Count() == 0)
                    {
                        db.Empresas.Add(empresa);
                        db.SaveChanges();
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        MessageBox.Show("Empresa já cadastrada");
                    }

                }
            }

            /* TESTAR CONSULTA ANTES DE INCLUIR OS DADOS
             * Empresa empresa2 = db.Empresas.Find(empresa.cnpj);
                if (empresa2 == null)
                {
                    db.Empresas.Add(empresa);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                    Console.Write("Epresa já cadastrada");
             */

            return View(empresa);
        }

        // GET: Empresas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empresa empresa = db.Empresas.Find(id);
            if (empresa == null)
            {
                return HttpNotFound();
            }
            return View(empresa);
        }

        // POST: Empresas/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idEmpresa,cnpj,nome,dataAbertura,atividade")] Empresa empresa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(empresa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(empresa);
        }

        // GET: Empresas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empresa empresa = db.Empresas.Find(id);
            if (empresa == null)
            {
                return HttpNotFound();
            }
            return View(empresa);
        }

        // POST: Empresas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Empresa empresa = db.Empresas.Find(id);
            db.Empresas.Remove(empresa);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
