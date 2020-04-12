using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using session.Models;
using System.IO;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace session.Controllers
{
    public class HomeController : Controller
    {
        private IMongoCollection<Register> Collectionregis;
        private IMongoCollection<Jregister> CollectionJregis;
        private IMongoCollection<Confirmed> Collationconf;
        private IMongoCollection<HIRE> Collationhire;
        private IMongoCollection<Star> CollationStar;
        public HomeController()
        {
            var dbcilent = new MongoClient("mongodb://Beeradmin:beer8640@cluster0-shard-00-00-pqdfa.azure.mongodb.net:27017,cluster0-shard-00-01-pqdfa.azure.mongodb.net:27017,cluster0-shard-00-02-pqdfa.azure.mongodb.net:27017/test?replicaSet=Cluster0-shard-0&ssl=true&authSource=admin");
            var database = dbcilent.GetDatabase("DATAHUB");
            Collectionregis = database.GetCollection<Register>("REGISTER");
            CollectionJregis = database.GetCollection<Jregister>("JREGISTER");
            Collationconf = database.GetCollection<Confirmed>("Confirmed");
            Collationhire = database.GetCollection<HIRE>("HIRE");
            CollationStar = database.GetCollection<Star>("Star_Rating");
        }

        public IActionResult Index()
        {
            ViewBag.use = HttpContext.Session.GetString("use");
            ViewBag.status = HttpContext.Session.GetString("status");
            var result = CollectionJregis.Find(it => true).ToList();

            return View(result);
        }

        public IActionResult job1()
        {
            ViewBag.use = HttpContext.Session.GetString("use");
            ViewBag.status = HttpContext.Session.GetString("status");
            var item = CollectionJregis.Find(it => it.statusjob == "1").ToList();

            return View(item);
        }

        public IActionResult job2()
        {
            ViewBag.use = HttpContext.Session.GetString("use");
            ViewBag.status = HttpContext.Session.GetString("status");
            var item = CollectionJregis.Find(it => it.statusjob == "2").ToList();

            return View(item);
        }

        public IActionResult job3()
        {
            ViewBag.use = HttpContext.Session.GetString("use");
            ViewBag.status = HttpContext.Session.GetString("status");
            var item = CollectionJregis.Find(it => it.statusjob == "3").ToList();

            return View(item);
        }

        public IActionResult job4()
        {
            ViewBag.use = HttpContext.Session.GetString("use");
            ViewBag.status = HttpContext.Session.GetString("status");
            var item = CollectionJregis.Find(it => it.statusjob == "4").ToList();

            return View(item);
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
            var item = Collectionregis.Find(it => it.status == "3" && it.skill1 == "1").ToList();

            return View(item);
        }

        public IActionResult maid1()
        {
            ViewBag.use = HttpContext.Session.GetString("use");
            ViewBag.status = HttpContext.Session.GetString("status");
            var item = Collectionregis.Find(it => it.status == "3" && it.skill2 == "2").ToList();

            return View(item);
        }

        public IActionResult maid2()
        {
            ViewBag.use = HttpContext.Session.GetString("use");
            ViewBag.status = HttpContext.Session.GetString("status");
            var item = Collectionregis.Find(it => it.status == "3" && it.skill3 == "3").ToList();

            return View(item);
        }

        public IActionResult maid3()
        {
            ViewBag.use = HttpContext.Session.GetString("use");
            ViewBag.status = HttpContext.Session.GetString("status");
            var item = Collectionregis.Find(it => it.status == "3" && it.skill4 == "4").ToList();

            return View(item);
        }

        public IActionResult comment(string id)
        {
            ViewBag.use = HttpContext.Session.GetString("use");
            ViewBag.status = HttpContext.Session.GetString("status");
            var item = CollationStar.Find(it => it.Maidid == id).ToList();

            return View(item);
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
                Ses1id = ViewBag.id,
                Ses2id = dataregid._id,
                Ses2Nameid = dataregid.name,
                Ses2statusid = dataregid.status,
                jname = data.jname,
                jpictrue1 = data.jpictrue1,
                jpictrue2 = data.jpictrue2,
                jpictrue3 = data.jpictrue3,
                jdatail = data.jdatail,
                jaddress = data.jaddress,
                jprice = data.jprice,
                jline = data.jline,
                jphone = data.jphone,
                status = null

            };
            Collationhire.InsertOne(item);
            return RedirectToAction("jobme");
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
                Nsesid = ViewBag.name,
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
            return RedirectToAction("Index");
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
                phon = data.phon,
                Email = data.Email,
                line = data.line,
                facebook = data.facebook,
                pictrueP = data.pictrueP,
                status = "1",
                skill1 = data.skill1,
                skill2 = data.skill2,
                skill3 = data.skill3,
                skill4 = data.skill4
            };
            Collectionregis.InsertOne(item);

            return RedirectToAction("Login");
        }

        public IActionResult register2()
        {
            ViewBag.use = HttpContext.Session.GetString("use");

            return View();
        }

        [HttpPost]
        public IActionResult register2(Register data)
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
                phon = data.phon,
                Email = data.Email,
                line = data.line,
                facebook = data.facebook,
                pictrueP = data.pictrueP,
                status = "2"
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
                statusjob = data.statusjob,
                jname = data.jname,
                jpictrue1 = data.jpictrue1,
                jpictrue2 = data.jpictrue2,
                jpictrue3 = data.jpictrue3,
                jdatail = data.jdatail,
                jaddress = data.jaddress,
                jprice = data.jprice,
                jline = data.jline,
                jphone = data.jphone,
                date = data.date,
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
            if (data.username == "adminhub" && data.password == "admin1234")
            {
                return RedirectToAction("adminonly");
            }
            else if (user != null)
            {
                if (user.status == "3")
                {
                    HttpContext.Session.SetString("use", data.username);
                    HttpContext.Session.SetString("id", user._id);
                    HttpContext.Session.SetString("Uname", user.name);
                    HttpContext.Session.SetString("Pic", user.pictrueP);
                    HttpContext.Session.SetString("age", user.age);
                    HttpContext.Session.SetString("addr", user.address);
                    HttpContext.Session.SetString("pcc", user.pictrue);
                    HttpContext.Session.SetString("status", user.status);

                    return RedirectToAction("Index");
                }
                else if (user.status == "4")
                {
                    HttpContext.Session.SetString("use", data.username);
                    HttpContext.Session.SetString("id", user._id);
                    HttpContext.Session.SetString("Uname", user.name);
                    HttpContext.Session.SetString("Pic", user.pictrueP);
                    HttpContext.Session.SetString("age", user.age);
                    HttpContext.Session.SetString("addr", user.address);
                    HttpContext.Session.SetString("pcc", user.pictrue);
                    HttpContext.Session.SetString("status", user.status);
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("Login1");
                }
            }
            else
            {
                return RedirectToAction("Login1");
            }
        }

        public IActionResult Login1()
        {
            ViewBag.use = HttpContext.Session.GetString("use");

            return View();
        }

        [HttpPost]
        public IActionResult Login1(Login data)
        {
            var user = Collectionregis.Find(it => it.username == data.username && it.password == data.password).FirstOrDefault();

            if (data.username == "adminhub" && data.password == "admin1234")
            {
                return RedirectToAction("adminonly");
            }
            else if (user != null)
            {
                if (user.status == "3")
                {
                    HttpContext.Session.SetString("use", data.username);
                    HttpContext.Session.SetString("id", user._id);
                    HttpContext.Session.SetString("Uname", user.name);
                    HttpContext.Session.SetString("Pic", user.pictrueP);
                    HttpContext.Session.SetString("age", user.age);
                    HttpContext.Session.SetString("addr", user.address);
                    HttpContext.Session.SetString("phon", user.phon);
                    HttpContext.Session.SetString("email", user.Email);
                    HttpContext.Session.SetString("idline", user.line);
                    HttpContext.Session.SetString("facebook", user.facebook);
                    HttpContext.Session.SetString("pcc", user.pictrue);
                    HttpContext.Session.SetString("status", user.status);
                    return RedirectToAction("Index");
                }
                else if (user.status == "4")
                {
                    HttpContext.Session.SetString("use", data.username);
                    HttpContext.Session.SetString("id", user._id);
                    HttpContext.Session.SetString("Uname", user.name);
                    HttpContext.Session.SetString("Pic", user.pictrueP);
                    HttpContext.Session.SetString("age", user.age);
                    HttpContext.Session.SetString("addr", user.address);
                    HttpContext.Session.SetString("phon", user.phon);
                    HttpContext.Session.SetString("email", user.Email);
                    HttpContext.Session.SetString("idline", user.line);
                    HttpContext.Session.SetString("facebook", user.facebook);
                    HttpContext.Session.SetString("pcc", user.pictrue);
                    HttpContext.Session.SetString("status", user.status);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
            else
            {
                return View();
            }
        }

        public IActionResult adminonly()
        {
            var result = Collectionregis.Find(it => true).ToList();

            return View(result);
        }

        public IActionResult adminedit(string id)
        {
            var select = Collectionregis.Find(it => it._id == id).FirstOrDefault();

            return View(select);
        }

        [HttpGet]
        public IActionResult adtosys(string id)
        {
            //*add_user*//
            var adstt1 = Builders<Register>.Update.Set(it => it.status, "3");
            var adstt2 = Builders<Register>.Update.Set(it => it.status, "4");
            var item = Collectionregis.Find(it => it._id == id).FirstOrDefault();
            if (item.status == "1")
            {
                Collectionregis.UpdateOne(it => it._id == id, adstt1);
                return RedirectToAction("adminonly");
            }
            else if (item.status == "2")
            {
                Collectionregis.UpdateOne(it => it._id == id, adstt2);
                return RedirectToAction("adminonly");
            }
            return View();
        }

        [HttpGet]
        public IActionResult droptosys(string id)
        {
            //*drop_user*//
            Collectionregis.DeleteOne(it => it._id == id);
            return RedirectToAction("adminonly");
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

            var result = Collationconf.Find(it => it.Sesid == HttpContext.Session.GetString("id")).ToList();
            return View(result);
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
            var result = CollectionJregis.Find(it => it.Sesid == HttpContext.Session.GetString("id")).ToList();
            return View(result);
        }

        public IActionResult editprofile(string id)
        {
            ViewBag.use = HttpContext.Session.GetString("use");
            var item = Collectionregis.Find(it => it._id == id).FirstOrDefault();

            return View(item);
        }

        [HttpPost]
        public IActionResult editprofile(Register data)
        {
            var item = Builders<Register>.Update
                .Set(it => it.name, data.name)
                .Set(it => it.age, data.age)
                .Set(it => it.address, data.address)
                .Set(it => it.pictrueP, data.pictrueP);
            Collectionregis.UpdateOne(it => it._id == data._id, item);

            return RedirectToAction("");
        }

        public IActionResult pro1_2()
        {
            ViewBag.use = HttpContext.Session.GetString("use");
            ViewBag.id = HttpContext.Session.GetString("id");
            var result = Collationhire.Find(it => it.Ses2id == HttpContext.Session.GetString("id")).ToList();

            return View(result);
        }

        [HttpGet]
        public IActionResult select(string id)
        {
            var upstatus = Builders<HIRE>.Update.Set(it => it.status, "1");

            Collationhire.UpdateOne(it => it._id == id, upstatus);
            return RedirectToAction("pro1_2");
        }

        public IActionResult Detailsjob(string id)
        {
            ViewBag.use = HttpContext.Session.GetString("use");
            var select = Collationhire.Find(it => it._id == id).FirstOrDefault();

            return View(select);
        }

        public IActionResult conf(string id)
        {
            ViewBag.use = HttpContext.Session.GetString("use");

            var result = Collationconf.Find(it => it.Jid == id).ToList();
            return View(result);
        }

        [HttpGet]
        public IActionResult get(string id)
        {
            var def = Builders<Confirmed>.Update.Set(it => it.jstatus, "2");
            var upregis = Builders<Jregister>.Update.Set(it => it.jstatus, "1");

            Collationconf.UpdateOne(it => it.Jid == id, def);
            CollectionJregis.UpdateOne(it => it._id == id, upregis);
            return RedirectToAction("profile2");
        }

        public IActionResult Details(string id)
        {
            ViewBag.use = HttpContext.Session.GetString("use");
            var result = Collationconf.Find(it => it._id == id).FirstOrDefault();

            return View(result);
        }

        [HttpGet]
        public IActionResult OK(string id)
        {
            var def = Builders<Confirmed>.Update.Set(it => it.jstatus, "3");

            Collationconf.UpdateOne(it => it._id == id, def);

            return RedirectToAction("profile1");
        }

        [HttpGet]
        public IActionResult finish(string id, Register data)
        {
            var item = Collationconf.Find(it => it.Jid == id).FirstOrDefault();
            var def = Builders<Confirmed>.Update.Set(it => it.jstatus, "4");
            var upregis = Builders<Jregister>.Update.Set(it => it.jstatus, "2");

            Collationconf.UpdateOne(it => it._id == item._id, def);
            CollectionJregis.UpdateOne(it => it._id == id, upregis);
            return RedirectToAction("profile2");
        }

        public IActionResult finishtostar()
        {
            ViewBag.use = HttpContext.Session.GetString("use");
            ViewBag.id = HttpContext.Session.GetString("id");
            ViewBag.name = HttpContext.Session.GetString("Uname");

            return View();
        }

        [HttpPost]
        public IActionResult finishtostar(string id, Star data)
        {
            try
            {
                var select = Collationconf.Find(it => it.Jid == id).FirstOrDefault();
                var Jstatus = Builders<Jregister>.Update.Set(it => it.jstatus, "3");
                var item = new Star
                {
                    _id = Guid.NewGuid().ToString(),
                    Sesid = HttpContext.Session.GetString("id"),
                    Maidid = select.Sesid,
                    namejob = select.jname,
                    detailjob = select.jdatail,
                    namesesid = select.Nsesid,
                    star = data.star,
                    comment = data.comment
                };
                CollationStar.InsertOne(item);
                CollectionJregis.UpdateOne(it => it._id == id, Jstatus);
                return RedirectToAction("profile2");
            }
            catch
            {
                var selectname = CollectionJregis.Find(it => it._id == id).FirstOrDefault();
                var select = Collectionregis.Find(it => it._id == selectname.Sesid).FirstOrDefault();
                var upstatus = Builders<HIRE>.Update.Set(it => it.status, "3");
                var item = new Star
                {
                    _id = Guid.NewGuid().ToString(),
                    Sesid = HttpContext.Session.GetString("id"),
                    Maidid = id,
                    namejob = selectname.jname,
                    detailjob = selectname.jdatail,
                    namesesid = select.name,
                    star = data.star,
                    comment = data.comment  
                };
                CollationStar.InsertOne(item);
                Collationhire.UpdateOne(it => it.Ses2id == id, upstatus);
                return RedirectToAction("jobme");
            }
        }

        //**//

        public IActionResult jobme()
        {
            ViewBag.use = HttpContext.Session.GetString("use");
            ViewBag.id = HttpContext.Session.GetString("id");
            var select = Collationhire.Find(it => it.Ses1id == HttpContext.Session.GetString("id")).ToList();

            return View(select);
        }

        [HttpGet]
        public IActionResult jobmeOK(string id)
        {
            var upstatus = Builders<HIRE>.Update.Set(it => it.status, "2");

            Collationhire.UpdateOne(it => it._id == id, upstatus);
            return RedirectToAction("jobme");
        }

        public IActionResult Upload()
        {

            return View();
        }

        [HttpGet]
        public IActionResult del(string id)
        {

            Collationconf.DeleteOne(it => it.Sesid == id);
            return RedirectToAction("conf");
        }

        [HttpGet]
        public IActionResult Delete(string id)
        {

            Collationhire.DeleteOne(it => it._id == id);
            return RedirectToAction("pro1_2");
        }

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("use");
            return RedirectToAction("Index");
        }
    }
}
