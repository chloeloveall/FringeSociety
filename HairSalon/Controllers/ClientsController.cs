using HairSalon.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {
    private readonly HairSalonContext _db;

    public ClientsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Client> model = _db.Clients.Include(client => client.Stylist).ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "StylistName");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Client client)
    {
      if (ModelState.IsValid)
      {
        string savedType = Enum.GetName(typeof(ClientState),client.ClientState);
        _db.Clients.Add(client);
        _db.SaveChanges();
        return RedirectToAction("Index");
      }
      else if (!ModelState.IsValid)
      {
        string savedType = Enum.GetName(typeof(ClientState),client.ClientState);
        ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "StylistName");
        return View();
      }
      return View(client);
    }

    public ActionResult Details(int id)
    {
      Client thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
      return View(thisClient);
    }

    public ActionResult Edit(int id)
    {
      var thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "StylistName");
      return View(thisClient);
    }

    [HttpPost]
    public ActionResult Edit(Client client)
    {
      if (ModelState.IsValid)
      {
        _db.Entry(client).State = EntityState.Modified;
        _db.SaveChanges();
        return RedirectToAction("Index");
      }
      else if (!ModelState.IsValid)
      {
        ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "StylistName");
        return View();
      }
      return View(client);
    }

    public ActionResult Delete(int id)
    {
      var thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
      return View(thisClient);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
      _db.Clients.Remove(thisClient);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

  }
}