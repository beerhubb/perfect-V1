using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using session.Models;

namespace session.Controllers
{
    public class HomeController : Controller
    {
        private IMongoCollection<Register> Collectionregis;
        private IMongoCollection<Jregister> CollectionJregis;
        private IMongoCollection<Confirmed> Collationconf;
        private IMongoCollection<HIRE> Collationhire;
        public HomeController()
        {
            var dbcilent = new MongoClient("mongodb://Beeradmin:beer8640@cluster0-shard-00-00-pqdfa.azure.mongodb.net:27017,cluster0-shard-00-01-pqdfa.azure.mongodb.net:27017,cluster0-shard-00-02-pqdfa.azure.mongodb.net:27017/test?replicaSet=Cluster0-shard-0&ssl=true&authSource=admin");
            var database = dbcilent.GetDatabase("DATAHUB");
            Collectionregis = database.GetCollection<Register>("REGISTER");
            CollectionJregis = database.GetCollection<Jregister>("JREGISTER");
            Collationconf = database.GetCollection<Confirmed>("Confirmed");
            Collationhire = database.GetCollection<HIRE>("HIRE");
        }
        public IActionResult Index()
        {
            ViewBag.use = HttpContext.Session.GetString("use");
            ViewBag.status = HttpContext.Session.GetString("status");
            var result = CollectionJregis.Find(it => true).ToList();

            return View(result);
        }

        public IActionResult About()
        {
            ViewBag.use = HttpContext.Session.GetString("use");

            return View();
        }

        public IActionResult maid()
        {
            ViewBag.use = HttpContext.Session.GetString("use");
            ViewBag.status = HttpContext.Session.GetString("status");

            var result = Collectionregis.Find(it => it.status == "1").ToList();

            return View(result);
        }

        public IActionResult hire()
        {
            ViewBag.use = HttpContext.Session.GetString("use");

            return View();
        }

        [HttpPost]
        public IActionResult hire(string id, HIRE data)
        {
            ViewBag.use = HttpContext.Session.GetString("use");
            ViewBag.id = HttpContext.Session.GetString("id");
            var dataregid = Collectionregis.Find(it => it._id == id).FirstOrDefault();

            var item = new HIRE
            {
                _id = Guid.NewGuid().ToString(),
                Mid = dataregid._id,
                sesid = ViewBag.id,
                jname = data.jname,
                jpictrue1 = data.jpictrue1,
                jpictrue2 = data.jpictrue2,
                jpictrue3 = data.jpictrue3,
                jdatail = data.jdatail,
                jaddress = data.jaddress,
                jprice = data.jprice,
                jline = data.jline,
                jphone = data.jphone
            };
            Collationhire.InsertOne(item);
            return RedirectToAction("maid");
        }

        [HttpGet]
        public IActionResult Confirmed(string id, Confirmed data)
        {
            ViewBag.use = HttpContext.Session.GetString("use");
            ViewBag.name = HttpContext.Session.GetString("Uname");
            ViewBag.id = HttpContext.Session.GetString("id");
            var datainp = CollectionJregis.Find(it => it._id == id).FirstOrDefault();

            var item = new Confirmed
            {
                _id = Guid.NewGuid().ToString(),
                Sesid = ViewBag.id,
                Jid = datainp._id,
                Bossid = datainp.Sesid,
                jname = datainp.jname,
                jpictrue1 = datainp.jpictrue1,
                jpictrue2 = datainp.jpictrue2,
                jpictrue3 = datainp.jpictrue3,
                jdatail = datainp.jdatail,
                jaddress = datainp.jaddress,
                jprice = datainp.jprice,
                jline = datainp.jline,
                jphone = datainp.jphone,
                jstatus = "1"
            };
            Collationconf.InsertOne(item);
            return RedirectToAction("pro1_1");
        }

        public IActionResult register()
        {
            ViewBag.use = HttpContext.Session.GetString("use");

            return View();
        }

        [HttpPost]
        public IActionResult register(Register data)
        {
            var item = new Register
            {
                _id = Guid.NewGuid().ToString(),
                username = data.username,
                password = data.password,
                name = data.name,
                age = data.age,
                address = data.address,
                pictrue = data.pictrue,
                pictrueP = data.pictrueP,
                status = data.status
            };
            Collectionregis.InsertOne(item);

            return RedirectToAction("Login");
        }

        public IActionResult Jregis()
        {
            ViewBag.use = HttpContext.Session.GetString("use");

            return View();
        }

        [HttpPost]
        public IActionResult Jregis(Jregister data)
        {
            ViewBag.id = HttpContext.Session.GetString("id");

            var item = new Jregister
            {
                _id = Guid.NewGuid().ToString(),
                Sesid = ViewBag.id,
                jname = data.jname,
                jpictrue1 = data.jpictrue1,
                jpictrue2 = data.jpictrue2,
                jpictrue3 = data.jpictrue3,
                jdatail = data.jdatail,
                jaddress = data.jaddress,
                jprice = data.jprice,
                jline = data.jline,
                jphone = data.jphone,
                jstatus = data.jstatus
            };
            CollectionJregis.InsertOne(item);
            return RedirectToAction("Index");
        }

        public IActionResult Login()
        {
            ViewBag.use = HttpContext.Session.GetString("use");

            return View();
        }
        [HttpPost]
        public IActionResult Login(Login data)
        {
            var user = Collectionregis.Find(it => it.username == data.username && it.password == data.password).FirstOrDefault();

            if (user != null)
            {
                if (user.status == "1")
                {
                    HttpContext.Session.SetString("use", data.username);
                    HttpContext.Session.SetString("id", user._id);
                    HttpContext.Session.SetString("Uname", user.name);
                    HttpContext.Session.SetString("Pic", user.pictrueP);
                    HttpContext.Session.SetString("age", user.age);
                    HttpContext.Session.SetString("addr", user.address);
                    HttpContext.Session.SetString("pcc", user.pictrue);
                    HttpContext.Session.SetString("status", user.status);
                    return RedirectToAction("profile1");
                }
                else
                {
                    HttpContext.Session.SetString("use", data.username);
                    HttpContext.Session.SetString("id", user._id);
                    HttpContext.Session.SetString("Uname", user.name);
                    HttpContext.Session.SetString("Pic", user.pictrueP);
                    HttpContext.Session.SetString("age", user.age);
                    HttpContext.Session.SetString("addr", user.address);
                    HttpContext.Session.SetString("pcc", user.pictrue);
                    HttpContext.Session.SetString("status", user.status);
                    return RedirectToAction("profile2");
                }
            }
            else
            {
                return RedirectToAction("Error");
            }
        }

        public IActionResult profile1()
        {
            ViewBag.use = HttpContext.Session.GetString("use");
            ViewBag.pictrue = HttpContext.Session.GetString("Pic");
            ViewBag.id = HttpContext.Session.GetString("id");
            ViewBag.name = HttpContext.Session.GetString("Uname");
            ViewBag.age = HttpContext.Session.GetString("age");
            ViewBag.add = HttpContext.Session.GetString("addr");
            ViewBag.status = HttpContext.Session.GetString("status");

            return View();
        }

        public IActionResult profile2()
        {
            ViewBag.use = HttpContext.Session.GetString("use");
            ViewBag.pictrue = HttpContext.Session.GetString("Pic");
            ViewBag.id = HttpContext.Session.GetString("id");
            ViewBag.name = HttpContext.Session.GetString("Uname");
            ViewBag.age = HttpContext.Session.GetString("age");
            ViewBag.add = HttpContext.Session.GetString("addr");
            ViewBag.status = HttpContext.Session.GetString("status");
            if (ViewBag.use != null)
            {
                var result = CollectionJregis.Find(it => it.Sesid == HttpContext.Session.GetString("id")).ToList();
                return View(result);
            }
            return RedirectToAction("Index");
        }

        public IActionResult pro1_1()
        {
            ViewBag.use = HttpContext.Session.GetString("use");
            ViewBag.id = HttpContext.Session.GetString("id");

            var result = Collationconf.Find(it => it.Sesid == HttpContext.Session.GetString("id")).ToList();

            return View(result);
        }

        public IActionResult pro1_2()
        {
            ViewBag.use = HttpContext.Session.GetString("use");
            ViewBag.id = HttpContext.Session.GetString("id");
            var result = Collationhire.Find(it => it.Mid == HttpContext.Session.GetString("id")).ToList();

            return View(result);
        }

        public IActionResult conf(string id)
        {
            ViewBag.use = HttpContext.Session.GetString("use");

            var result = Collationconf.Find(it => it.Jid == id).ToList();
            return View(result);
        }

        [HttpGet]
        public IActionResult get(string id) {
            var item = Collationconf.Find(it => it._id == id).FirstOrDefault();
            var def = Builders<Confirmed>.Update.Set(it => it.jstatus, "3");

            Collationconf.UpdateOne(it => it._id == id,def);
            return RedirectToAction("profile2");
        }

        public IActionResult Details(string id)
        {
            ViewBag.use = HttpContext.Session.GetString("use");
            var result = CollectionJregis.Find(it => it._id == id).ToList().FirstOrDefault();

            return View(result);
        }

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("use");
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
