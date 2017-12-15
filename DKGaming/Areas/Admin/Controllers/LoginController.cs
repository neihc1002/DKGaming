using DKGaming.Areas.Admin.Models;
using DKGaming.Common;
using Model.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DKGaming.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        ContentConfig config = new ContentConfig();
        // GET: Admin/Login
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.footer = config.GetContent("Footer_Login_Page");
            return View();
        }
        [HttpPost]
        public ActionResult Index(User user)
        {
            ViewBag.footer = config.GetContent("Footer_Login_Page");
            if (ModelState.IsValid)
            {
                var us = new UserDao();
                var result = us.checkLogin(user.UserName, Encryptor.MD5Hash(user.Password));
                if (result == 1)
                {
                    var use = us.GetUser(user.UserName);
                    var userSession = new User();
                    userSession.UserName = use.UserName;
                    userSession.Password = use.Password;
                    Session.Add(CommonConstants.USER_SESSION, userSession);
                    return RedirectToAction("Index", "Home");
                }
                else if (result == 0)
                {
                    ModelState.AddModelError("", "Tài khoản không tồn tại");
                }
                else if (result == -1)
                {
                    ModelState.AddModelError("", "Tài khoản bị khóa");
                }
                else if (result == -2)
                {
                    ModelState.AddModelError("", "Mật khẩu không đúng");
                }
            }
            return View();
        }
    }
}