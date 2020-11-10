﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FreeCycle.Models;
using System.Net.Mail;
using System.Security.Cryptography.Xml;
using System.Text;



namespace FreeCycle.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly DatabaseContext _context;
        public IActionResult Create()
        {
            return View();
        }

        public UsuariosController(DatabaseContext context)
        {
            _context = context;
        }

        //Flag 0 para email ya registrado
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Password,PhoneNumber,Email")] Usuario usuario)
        {
            int flag;
            String temp = usuario.Email;
            var Usuario = _context.Usuario.FirstOrDefault(user => user.Email == temp);
            if (Usuario == null)
            {
                if (ModelState.IsValid)
                {
                    _context.Add(usuario);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("GoToIndex", "Home", new { flag = 3 });
                }

            }
            flag = 0;
            ViewBag.flag = flag;
            return View(usuario);
        }

        public IActionResult RecuperarContraseña()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RecuperarContraseña(string Email)
        {
            var Usuario = _context.Usuario.FirstOrDefault(user => user.Email == Email);
            if (Usuario != null)
            {
                string strToken = Usuario.Email.ToString();
                //ACÁ SE DEBERÍA ENCRIPTAR EL EMAIL
                string strTokenAjax;
                //Acá se debería adquirir la dirección de una mejor forma
                var address = "https://localhost:44358/Usuarios/CambiarContraseña/?tkn=" + strToken;

                string to = Email;
                string subject = "PASSWORD RECOVERY";

                //Mejorar este mensaje y ponerlo con HTML
                string body = "Hello, in the following link you will be able to change your password to recover your account: " + address ;

                MailMessage mm = new MailMessage();
                mm.To.Add(to);
                mm.Subject = subject;
                mm.Body = body;
                mm.From = new MailAddress("freecycledonations@gmail.com");
                //Acá iría true cuando esté hecho con HTML
                mm.IsBodyHtml = false;


                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                //maybe true
                smtp.UseDefaultCredentials = false;
                smtp.EnableSsl = true;
                smtp.Credentials = new System.Net.NetworkCredential("freecycledonations@gmail.com", "freecycle123");
                smtp.Send(mm);

                //No es necesario se puede manejar con una flag tipica
                ViewBag.Email = Email;

            }
            else
            {
                //Enviar VB de usuario no registrado
            }
            return View();
        }

        public IActionResult CambiarContraseña(string tkn, int flag)
        {
            if (!string.IsNullOrEmpty(tkn))
            {
                ViewBag.tkn = tkn;
                ViewBag.flag = flag;
            }
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> CambiarContraseña(string Password, string Password2, string tkn)
        {
            int flag;
            if (Password == Password2)
            {

                var Usuario = _context.Usuario.FirstOrDefault(user => user.Email == tkn);

                if (Usuario != null)
                {
                    Usuario.Password = Password;
                    _context.Update(Usuario);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("GoToIndex", "Home", new { flag = 4 });
                }

            }
            else
            {
                return RedirectToAction("CambiarContraseña", "Usuarios", new { tkn = tkn, flag = 5 });
            }

            return View();

        }
    }
}
