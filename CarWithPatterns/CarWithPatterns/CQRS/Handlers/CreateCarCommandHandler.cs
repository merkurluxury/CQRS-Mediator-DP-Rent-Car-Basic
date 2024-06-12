using CarWithPatterns.CQRS.Commands;
using CarWithPatterns.DAL;

namespace CarWithPatterns.CQRS.Handlers
{

    
    public class CreateCarCommandHandler
    {
        private readonly Context _context;
public CreateCarCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(CreateCarCommand command)
        {
            _context.Cars.Add(new Car
            {
                CarBrand = command.CarBrand,
                CarModel = command.CarModel,
                MotorPower = command.MotorPower,
                ImageUrl = command.ImageUrl,
                Price = command.Price,
                IsAvailable =command.IsAvailable

            }); _context.SaveChanges();       }

    }
}
