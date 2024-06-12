using CarWithPatterns.Mediator.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarWithPatterns.Controllers
{
    public class UIController : Controller

    {
        private readonly IMediator _mediator;
        
public UIController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async  Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetAllCarQuery());
            return View(values);
        }

        public async Task<IActionResult> ListCar(string selectedModel)
        {
            var query = new GetAllCarQuery();
            var result = await _mediator.Send(query);

            if (!string.IsNullOrEmpty(selectedModel))
            {
                result = result.Where(c => c.CarModel == selectedModel).ToList();
            }

            return View(result);
        }


    }
}
