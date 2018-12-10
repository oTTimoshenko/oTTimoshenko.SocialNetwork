using AutoMapper;
using oTTimoshenko.SocialNetwork.ApplicationLogic.Interfaces;
using oTTimoshenko.SocialNetwork.ApplicationLogic.UsersManagement.DTO;
using oTTimoshenko.SocialNetwork.Presentation.Web.Models.UsersModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace oTTimoshenko.SocialNetwork.Presentation.Web.Controllers
{
    public class UserController : Controller
    {
        private IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registration(RegistrateModel model)
        {
            Mapper.Initialize(cfg=>cfg.CreateMap<RegistrateModel, RegistrateDTO>().ReverseMap());
            var registrateDTO = Mapper.Map<RegistrateModel, RegistrateDTO>(model);

            userService.Registrate(registrateDTO);

            return View(model);
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<LoginModel, LogInDTO>().ReverseMap());
            var loginDTO = Mapper.Map<LoginModel, LogInDTO>(model);

            userService.LogIn(loginDTO);

            return View(model);
        }


    }
}