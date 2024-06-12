using CarWithPatterns.CQRS.Commands;
using CarWithPatterns.CQRS.Handlers;
using CarWithPatterns.CQRS.Queries;
using Microsoft.AspNetCore.Mvc;

namespace CarWithPatterns.Controllers
{
    public class CarController : Controller
    {
        private readonly GetCarQueryHandler _getCarQueryHandler;
        private readonly CreateCarCommandHandler _createCarCommandHandler;
        private readonly RemoveCarCommandHandler _removeCarCommandHandler;
        private readonly GetCarUpdateByIdQueryHandler _getCarUpdateByIdQueryHandler;
        private readonly UpdateCarCommandHandler _updateCarCommandHandler;


        public CarController(GetCarQueryHandler getCarQueryHandler, CreateCarCommandHandler createCarCommandHandler = null, RemoveCarCommandHandler removeCarCommandHandler = null, GetCarUpdateByIdQueryHandler getCarUpdateByIdQueryHandler = null, UpdateCarCommandHandler updateCarCommandHandler = null)
        {
            _getCarQueryHandler = getCarQueryHandler;
            _createCarCommandHandler = createCarCommandHandler;
            _removeCarCommandHandler = removeCarCommandHandler;
            _getCarUpdateByIdQueryHandler = getCarUpdateByIdQueryHandler;
            _updateCarCommandHandler = updateCarCommandHandler;
        }



        public IActionResult Index()
        {

            var values = _getCarQueryHandler.Handle();
            return View(values);
            
        }

        [HttpGet]
        public IActionResult CreateCar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCar(CreateCarCommand command)
        {
            _createCarCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }

        public IActionResult RemoveCar(int id)
        {
            _removeCarCommandHandler.Handle(new RemoveCarCommand(id));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateCar(int id)
        {
            var values = _getCarUpdateByIdQueryHandler.Handle(new GetCarUpdateByIdQuery(id));
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateCar(UpdateCarCommand command)
        {
            _updateCarCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
    }
}
