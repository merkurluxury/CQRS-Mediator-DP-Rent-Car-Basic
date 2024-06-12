using CarWithPatterns.Mediator.Result;
using MediatR;

namespace CarWithPatterns.Mediator.Queries
{
    public class GetAllCarQuery:  IRequest<List<GetAllCarQueryResult>>
    {
    }
}
