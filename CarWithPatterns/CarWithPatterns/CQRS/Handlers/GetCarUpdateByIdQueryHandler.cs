using CarWithPatterns.CQRS.Queries;
using CarWithPatterns.CQRS.Results;
using CarWithPatterns.DAL;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CarWithPatterns.CQRS.Handlers
{
    public class GetCarUpdateByIdQueryHandler
    {
        private readonly Context _context;

        public GetCarUpdateByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public GetCarUpdateQueryResult Handle(GetCarUpdateByIdQuery query)
        {
            var values = _context.Cars.Find(query.CarID);
            return new GetCarUpdateQueryResult
            {
                CarBrand = values.CarBrand,
                CarID = values.CarID,
                CarModel = values.CarModel,
                MotorPower = values.MotorPower,
                Price = values.Price,
                ImageUrl = values.ImageUrl,
                IsAvailable= values.IsAvailable


            };
        }
        
    }
}
