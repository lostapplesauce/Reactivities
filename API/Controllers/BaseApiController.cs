using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    //Shared controller amongst many API controllers
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {
        private IMediator _mediator; //This is now a mediator between the API and Application
            //This helps take a load off of API and has Application helping out.

        protected IMediator Mediator => _mediator ??= 
            HttpContext.RequestServices.GetService<IMediator>();
    }
}