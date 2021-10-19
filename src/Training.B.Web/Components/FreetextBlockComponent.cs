using System;
using EPiServer.Web.Mvc;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Training.B.Core.Constants;
using Training.B.Core.DomainModels.Blocks;
using Training.B.Requests.Blocks.Freetext;
using Training.B.Web.ViewModels;

namespace Training.B.Web.Components
{
    public class FreetextBlockComponent : BlockComponent<FreetextBlock>
    {
        private readonly IMediator _mediator;

        public FreetextBlockComponent(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        protected override IViewComponentResult InvokeComponent(FreetextBlock currentContent)
        {
            return View("/Views/Shared/Components/Block.cshtml", new BlockViewModel
            {
                Block = _mediator.Send(new FreetextRequest(currentContent)).Result,
                ComponentName = ReactComponentNames.Freetext
            });
        }
    }
}
