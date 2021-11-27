using QLGiaoVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLGiaoVien.Controllers
{
    public class GiaoVienController : Controller
    {

        // GET: GiaoVien
        public ActionResult Index()
        {
            var listGiaoVien = new DBGiaoVienContext().GiaoViens.ToList();
            return View(listGiaoVien);
          
        }

        // GET: GiaoVien/Details/5
        public ActionResult Details(int id)
        {

            return View();
        }

        // GET: GiaoVien/Create
        public ActionResult Create()
        {
            var context = new DBGiaoVienContext();
            var ChucVuSelect = new SelectList(context.ChucVus, "Id", "TenChucVu");
            ViewBag.IdChucVu = ChucVuSelect;
            return View();
        }

        // POST: GiaoVien/Create
        [HttpPost]
        public ActionResult Create(GiaoVien model)
        {
            try
            {
                // TODO: Add insert logic here
                var context = new DBGiaoVienContext();
                context.GiaoViens.Add(model);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: GiaoVien/Edit/5
        public ActionResult Edit(int id)
        {
            var context = new DBGiaoVienContext();
            var editing = context.GiaoViens.Find(id);
            var ChucVuSelect = new SelectList(context.ChucVus, "Id", "TenChucVu",editing.IdChucVu);
            ViewBag.IdChucVu = ChucVuSelect;
            return View(editing);
        }

   

        // POST: GiaoVien/Edit/5
        [HttpPost]
        public ActionResult Edit(GiaoVien model)
        {
            try
            {
                // TODO: Add update logic here
                var context = new DBGiaoVienContext();
                var oldItem = context.GiaoViens.Find(model.Id);
                oldItem.HovaTen = model.HovaTen;
                oldItem.GioiTinh = model.GioiTinh;
                oldItem.Email = model.Email;
                oldItem.IdChucVu = model.IdChucVu;
                oldItem.SoCanCuoc = model.SoCanCuoc;
                oldItem.SoDienThoai = model.SoDienThoai;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: GiaoVien/Delete/5
        public ActionResult Delete(int id)
        {
            var context = new DBGiaoVienContext();
            var deleting = context.GiaoViens.Find(id);
            return View(deleting);
        }

        // POST: GiaoVien/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var context = new DBGiaoVienContext();
                var deleting = context.GiaoViens.Find(id);
                context.GiaoViens.Remove(deleting);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
