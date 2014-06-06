using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UQBuy.Data.Models;
using EntityFramework.Extensions;
namespace UQBuy.Controllers
{
    public class UserController : Controller
    {
        private readonly UQBuyContext context = new UQBuyContext();
        //
        // GET: /User/

        public ActionResult Index()
        {
            List<Userbasic> list = new List<Userbasic>();
            for (int i = 0; i < 100; i++)
            {
                Userbasic user = new Userbasic() { U_ID = Guid.NewGuid().ToString() };
                list.Add(user);
            }
            context.Userbasics.AddRange(list);
            context.SaveChanges();
            return View();
        }

        public ActionResult Query()
        {
            return View(context.Userbasics.ToList());
        }

        public ActionResult Delete(string id)
        {
            context.Userbasics.Where(p => p.U_ID == id).Delete();
            return View();
        }

    }
}
