using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PSE.Application.Services.EventosService.Queries.ListEventosRequest;
using PSE.Client.Models;
using System.Diagnostics;

namespace PSE.Client.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMapper mapper;
        private readonly IMediator mediator;

        public HomeController(
            ILogger<HomeController> logger,
            IMapper mapper,
            IMediator mediator)
        {
            _logger = logger;
            this.mapper = mapper;
            this.mediator = mediator;
        }

        public  async Task<ActionResult> Index()
        {
            var reponse = await this.mediator.Send(new ListEventosRequest());

            return Ok(reponse);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
