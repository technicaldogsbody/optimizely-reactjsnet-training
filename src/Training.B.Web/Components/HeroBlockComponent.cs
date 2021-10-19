using System;
using EPiServer.Web.Mvc;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Training.B.Core.Constants;
using Training.B.Core.DomainModels.Blocks;
using Training.B.Requests.Blocks.Hero;
using Training.B.Web.ViewModels;

namespace Training.B.Web.Components
{
    public class HeroBlockComponent : BlockComponent<HeroBlock>
    {
        private readonly IMediator _mediator;

        public HeroBlockComponent(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        protected override IViewComponentResult InvokeComponent(HeroBlock currentContent)
        {
            return View("/Views/Shared/Components/Block.cshtml", new BlockViewModel
            {
                Block = _mediator.Send(new HeroRequest(currentContent)).Result,
                ComponentName = ReactComponentNames.Hero
            });
        }
    }
}
