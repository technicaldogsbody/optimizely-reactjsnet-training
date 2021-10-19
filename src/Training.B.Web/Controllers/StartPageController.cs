using System;
using System.Threading.Tasks;
using EPiServer.Web.Mvc;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Training.B.Core.DomainModels.Pages;
using Training.B.Requests.Pages.StartPage;

namespace Training.B.Web.Controllers
{
    public class StartPageController : PageController<StartPage>
    {
        private readonly IMediator _mediator;

        public StartPageController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        public async Task<ActionResult<StartPageResponse>> Index(StartPage currentPage)
        {
            return View(await _mediator.Send(new StartPageRequest(currentPage)));
        }
    }
}
