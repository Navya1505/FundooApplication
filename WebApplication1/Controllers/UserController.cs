using BusinessLayer.Interface;
using CommonLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FundooNoteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserBL userBL;
        public UserController(IUserBL userBL)
        {
            this.userBL = userBL;
        }
        [HttpPost("Register")]
        public IActionResult Registration(UserRegistrationModel userRegistrationModel)
        {
            try
            {
                var result=userBL.Registration(userRegistrationModel);
                if(result != null)
                {
                    return this.Ok(new {sucess=true,message="UserRegistration sucessfull",data=result});
                }
                else
                {
                    return this.BadRequest(new { success = false, message = "UserRegistration fail" });
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
