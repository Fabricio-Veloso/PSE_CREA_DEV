// Copyright (c) Creape. All Rights Reserved.

using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PSE.Application.Services.EventosService.Queries.ListEventosRequest;


namespace PSE.Client.Controllers
{
    [Route("Eventos")]
    public class EventosController : Controller
    {
        private readonly IMapper mapper;
        private readonly IMediator mediator;
        public EventosController(
            IMapper mapper,
            IMediator mediator)
        {
            this.mapper = mapper;
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult> ListEvetosAsync()
        {
            try
            {
                var reponse = await this.mediator.Send(new ListEventosRequest());

                return Ok(reponse);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error:  {ex.Message}");
            }
        }
    }
}
