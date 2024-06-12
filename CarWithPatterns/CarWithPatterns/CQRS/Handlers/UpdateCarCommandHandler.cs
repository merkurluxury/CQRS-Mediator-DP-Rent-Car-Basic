using CarWithPatterns.CQRS.Commands;
using CarWithPatterns.DAL;

namespace CarWithPatterns.CQRS.Handlers
{
    public class UpdateCarCommandHandler
    {
        Context _context;

        public UpdateCarCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(UpdateCarCommand command)
        {
            var values = _context.Cars.Find(command.CarID);
            values.CarBrand = command.CarBrand;
            values.CarID = command.CarID;
            values.CarModel = command.CarModel;
            values.MotorPower = command.MotorPower;
            values.Price = command.Price;
            values.ImageUrl = command.ImageUrl;
            values.IsAvailable = command.IsAvailable;
            _context.SaveChanges();

        }
    }
}
