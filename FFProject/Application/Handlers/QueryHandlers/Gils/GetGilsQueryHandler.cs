using Application.Mappers.ModelMappers;
using Application.Models;
using Application.Queries.Gils;
using Infrastructure.Repositories.Interfaces;
using MediatR;

namespace Application.Handlers.QueryHandlers.Gils;

/// <summary>
/// Gets a user's gils
/// </summary>
/// <param name="gilsRepository"></param>
/// <param name="mapper"></param>
public class GetGilsQueryHandler(IGilsRepository gilsRepository, GilsModelMapper mapper): IRequestHandler<GetGilsQuery, GilsModel>
{
    public async Task<GilsModel> Handle(GetGilsQuery request, CancellationToken cancellationToken)
    {
        var gils = await gilsRepository.GetGilsByIdAsync(request.UserId);

        return mapper.Map(gils);
    }
}