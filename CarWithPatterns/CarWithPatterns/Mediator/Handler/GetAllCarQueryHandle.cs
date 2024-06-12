using CarWithPatterns.DAL;
using CarWithPatterns.Mediator.Queries;
using CarWithPatterns.Mediator.Result;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CarWithPatterns.Mediator.Handler
{
    public class GetAllCarQueryHandle : IRequestHandler<GetAllCarQuery, List<GetAllCarQueryResult>>
    {
        private readonly Context _context;
public GetAllCarQueryHandle(Context context)
        {
            _context = context;
        }

        public async Task<List<GetAllCarQueryResult>> Handle(GetAllCarQuery request, CancellationToken cancellationToken)
        {
            return await _context.Cars.Select(x => new GetAllCarQueryResult
            {
                CarID = x.CarID,
                CarBrand = x.CarBrand,
                CarModel = x.CarModel,
                MotorPower = x.MotorPower,
                ImageUrl = x.ImageUrl,
                Price = x.Price,
                IsAvailable = x.IsAvailable

            }).AsNoTracking().ToListAsync();
        }
    }
}
