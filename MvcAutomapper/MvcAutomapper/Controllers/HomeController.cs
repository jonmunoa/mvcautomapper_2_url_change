﻿using AutoMapper;
using MvcAutomapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAutomapper.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Load home page
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var usuario = new Usuario()
            {
                ID = 1,
                DNI = "11111111-A",
                Nombre = "John",
                Apellidos = "Doe",
                FechaNacimiento = new DateTime(1990, 1, 1)
            };

            var usuarioVM = Mapper.Map<Usuario, UsuarioViewModel>(usuario);

            return View(usuarioVM);
        }

        /// <summary>
        /// Loads about page
        /// </summary>
        /// <returns></returns>
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        /// <summary>
        /// Loads contact page
        /// </summary>
        /// <returns></returns>
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}