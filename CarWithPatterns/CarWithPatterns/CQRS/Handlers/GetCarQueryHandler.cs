using CarWithPatterns.CQRS.Results;
using CarWithPatterns.DAL;

namespace CarWithPatterns.CQRS.Handlers
{
    public class GetCarQueryHandler
    {
        private readonly Context _context;

        public GetCarQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetCarQueryResult> Handle()
        {
            var values = _context.Cars.Select(x => new GetCarQueryResult
            {
                CarID = x.CarID,
                CarBrand = x.CarBrand,
                CarModel = x.CarModel,
                MotorPower = x.MotorPower,
                ImageUrl = x.ImageUrl,
                Price = x.Price,
                IsAvailable=x.IsAvailable
            }).ToList();
            return values;
        }

        
    }
}
