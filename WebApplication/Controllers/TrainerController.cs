using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Model;
using Test.Repository;


namespace WebApplication.Controllers
{
    public class TrainerController : Controller
    {
        private readonly ITrainerRepo _repo;
        public TrainerController()
        {
            _repo = new TrainerRepo();

        }
        // GET: Trainers
        public ActionResult Index()
        {
            
            return View(_repo.GetList());
        }

        // GET: Trainers/Details/5
        public ActionResult Details(int id)
        {
            var model = _repo.GetById(id);
            return View(model);
        }

        // GET: Trainers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Trainers/Create
        [HttpPost]
        public ActionResult Create(Trainer data)
        {
            try
            {
                _repo.Add(data);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Trainers/Edit/5
        public ActionResult Edit(int id)
        {
            var item = _repo.GetById(id);
            Trainer model = new Trainer
            {
                Name = item.Name,
                Address = item.Address,
                DateofBirth = item.DateofBirth,
                PhoneNumber = item.PhoneNumber

            };

            return View(model);
        }

        // POST: Trainers/Edit/5
        [HttpPost]
        public ActionResult Edit(Trainer data)
        {
            try
            {
                _repo.Update(data);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Trainers/Delete/5
        public ActionResult Delete(int id)
        {
            var entity = _repo.GetById(id);
            return View(entity);
        }

        // POST: Trainers/Delete/5
        [HttpPost]
        public ActionResult Delete(Trainer data)
        {
            try
            {
                _repo.Delete(data);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
