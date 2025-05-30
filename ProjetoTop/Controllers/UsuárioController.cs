﻿using Microsoft.AspNetCore.Mvc;
using ProjetoTop.Repositorio;

namespace ProjetoTop.Controllers
{
    public class UsuarioController : Controller
    {

        private readonly LoginRepositorio _loginRepositorio;

        public UsuarioController(LoginRepositorio loginRepositorio)
        {
            _loginRepositorio = loginRepositorio;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Login(string email, string senha)
        {
            var usuario = _loginRepositorio.ObterUsuario(email);

            if (usuario != null && usuario.Senha == senha)
            {
                return RedirectToAction("Index", "Cliente");
            }


            ModelState.AddModelError("", "Email ou senha inválidos.");

            return View();
        }
    }
}
