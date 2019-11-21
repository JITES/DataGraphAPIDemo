using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataGrapiApi.Common;
using DataGrapiApi.Common.Email;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DataGrapiApi.Controllers
{
    public class ValidateModelAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                context.Result = new BadRequestObjectResult(context.ModelState);
            }
        }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        [ValidateModel]
        [HttpPost]
        public IActionResult EmailService(EmailModel email)
        {
            ISendEmail objDefaultEmail = new SendEmail(new DefaultEmailProvider());
            var emailResponse = objDefaultEmail.Send(email);

            if (emailResponse == Constants.EmailSuccess)
            {
                return Ok(emailResponse);
            }
            return BadRequest();
        }
    }
}
