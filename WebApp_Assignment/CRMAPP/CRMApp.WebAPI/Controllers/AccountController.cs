using CRMApp.Core.Contract.Service;
using CRMApp.Core.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRMApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountServiceAsync accountServiceAsync;
        public AccountController(IAccountServiceAsync accountService)
        {
            accountServiceAsync = accountService;
        }

        [HttpPost]
        [Route("signup")]
        public async Task<IActionResult> SignUp([FromBody]SignUpModel model)
        {
            var result = await accountServiceAsync.SignUpAsync(model);
            if (result.Succeeded)
            {
                return Ok(result.Succeeded);
            }
            return Unauthorized();
        }
    
    }

}
