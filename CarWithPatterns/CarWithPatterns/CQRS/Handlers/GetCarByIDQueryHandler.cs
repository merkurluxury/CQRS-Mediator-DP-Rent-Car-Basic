using CarWithPatterns.CQRS.Queries;
using CarWithPatterns.CQRS.Results;
using CarWithPatterns.DAL;

namespace CarWithPatterns.CQRS.Handlers
{
    public class GetCarByIDQueryHandler
    {
        private readonly Context _context;
public GetCarByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public GetCarByIDQueryResult Handle(GetCarByIDQuery query)
        {
            var values = _context.Set<Car>().Find(query.CarID);
            return new GetCarByIDQueryResult
            {
                CarID = values.CarID,
                CarBrand = values.CarBrand,
                CarModel = values.CarModel,
                MotorPower = values.MotorPower,
                Price = values.Price
            };
        }
    }
}
