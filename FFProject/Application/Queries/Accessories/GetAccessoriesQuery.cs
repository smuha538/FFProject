using Application.Models;
using MediatR;

namespace Application.Queries.Accessories;

/// <summary>
/// Gets all accessories
/// </summary>
public record GetAccessoriesQuery : IRequest<IEnumerable<AccessoryModel>>;
