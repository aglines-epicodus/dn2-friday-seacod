﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using PafoodicSeacod.Models;
using PafoodicSeacod.ViewModels;


namespace PafoodicSeacod.Controllers
{
    public class AccountController : Controller
    {

        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AccountController (UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, AppDbContext db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

   
        // REGISTER ///////////////////////////////
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register (RegisterViewModel model)
        {
            var user = new AppUser { UserName = model.Email };
            IdentityResult result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        // LOGIN ///////////////////////////////

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: true, lockoutOnFailure: false);
            if (result.Succeeded)
            {
                return RedirectToAction("Signup");
            }
            else
            {
                return View();
            }
        }

        // LOGOUT ///////////////////////////////

        [HttpPost]
        public async Task<IActionResult> LogOff()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index");
        }

        // SIGNUP ///////////////////////////////
        public IActionResult Signup()
        {
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> Signup(NewsletterViewModel model)
        {
            var user = new AppUser { UserName = model.Email, PhoneNumber = model.Phone };
            IdentityResult result = await _userManager.CreateAsync(user);
            if (result.Succeeded)
                {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }


        // SUBSCRIBERS ///////////////////////////////
        public IActionResult Subscribers()
        {
            return View(_db.Users);
        }
    }
}
