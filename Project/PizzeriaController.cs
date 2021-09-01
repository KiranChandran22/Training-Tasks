using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_A.Models;

namespace Project_A.Controllers
{
    public class PizzeriaController : Controller
    {
        // GET: Project
        public ActionResult Index()
        {
            return View("Home");
        }
        public ActionResult VegPizza(string action)
        {
            if (action == "VEG")
            {
                projector pobj = new projector();
                DataTable dt = pobj.GetVegpizza();
                return View("VegPizza", dt);
            }
            if (action == "NON VEG")
            {
                projector pobj = new projector();
                DataTable dt = pobj.GetNoNveg();
                return View("VegPizza", dt);
            }
            return View("Index");
        }
        public ActionResult order()
        {
            projector pobj = new projector();
           DataTable dt= pobj.getfullpizza();
            return View("order",dt);
        }
        public ActionResult Crate(string Pizza_name)
        {
            projector pobj = new projector();
            DataTable dt = new DataTable(); 
            dt=pobj.PizzabyName(Pizza_name);
            return View("Crate",dt);
        }
        public ActionResult Add_to_crate(FormCollection frm, string action)
        {
            if (action == "Check Crate")
            {
                string Pizza_name = frm["Pizza_name"];
                int Pizza_id = Convert.ToInt32(frm["Pizza_id"]);
                int quantity = Convert.ToInt32(frm["Quantity"]);
                string crust = frm["crust"];
                string toppings = frm["Toppings"];
                string size = frm["size"];
                int price = Convert.ToInt32(frm["price"]);
                projector pobj = new projector();
                pobj.insert_into_order(Pizza_name, Pizza_id, quantity, crust, toppings,size,price);
                DataTable dt = new DataTable();
                dt = pobj.Getorder();
                return View("Cratefinal",dt);
            }
            if (action == "Cancel")
            {
                return View("Home");
            }
            return View();
        }
        //public ActionResult Add_to_crate(FormCollection frm,string action)
        //{

        //    return View();
        //}
        public ActionResult Cratefinal()
        {
            projector pobj = new projector();
            DataTable dt = new DataTable();
           dt = pobj.Getorder();
           return View("Cratefinal", dt);
        }
        public ActionResult delete(int Pizza_id)
        {
            projector dmoj = new projector();
            dmoj.delete(Pizza_id);
            return RedirectToAction("Cratefinal");
            
        }
        public ActionResult Login(string Action)
        {
            projector pobj = new projector();
            DataTable dt = new DataTable();
            dt = pobj.gettable();
            if (Action== "Order Now")
            {
                RedirectToAction("Login");
            }
            if (Action== "Continue Shopping")
            {
                return View("Home");
            }
            return View(dt);
        }
        public ActionResult UpdateRecord(FormCollection frm, string action)
        {
            if (action == "Log In")
            {
                int order_id = Convert.ToInt32(frm["txtid"]);
                string name = frm["txtmname"];
                string address = frm["txtaddress"];
                string phno = frm["txtphno"];
                projector pobj = new projector();
                pobj.update(order_id, name, address, phno);
                DataTable dt = new DataTable();
                dt = pobj.Getorderwithquanprice();
                ViewData["tot"] = Convert.ToInt32(dt.Compute("SUM(price)", string.Empty));
                return View("ordersummary",dt);
            }
            else
            {
                return View("Home");
            }
        }
        public ActionResult ordersummary()
        {
            return View();
        }
        public ActionResult addtocratetab(string action)
        {
            ViewBag.Message = "Once paid money isn't refundable";
            if (action == "Order Now")
            {
                projector pobj = new projector();
                ViewBag.Message = "Once paid money isn't refundable";
                pobj.addtocrate();
                pobj.gettablecrate();
                DataTable dt = new DataTable();
                dt = pobj.Getorderwithquanprice();
                ViewData["tot"] = Convert.ToInt32(dt.Compute("SUM(price)", string.Empty));
                return View("Creditcard",dt);
            }
            else
            {
                return View("Home");
            }
        }
        public ActionResult Creditcard(string action)
        {
            if(action== "Pay")
            { 
                projector pobj = new projector();
                DataTable dt = new DataTable();
                pobj.addtocrate();
                dt = pobj.gettablecrate();
                pobj.truncate();
                return View("orderstatus",dt);
            }
            return View("Home");
        }
        public ActionResult orderhistory()
        {
            
            return View();
        }
        public ActionResult orderhistable(FormCollection frm,string action)
        {
            if (action == "Search")
            {
                projector pobj = new projector();
                DataTable dt = new DataTable();
                string name = frm["txtmname"];
                dt = pobj.getorderhistory(name);
                return View("orderhistable", dt);
            }
            return View();
        }
       public ActionResult about()
        {
            return View();
        }
    }
}