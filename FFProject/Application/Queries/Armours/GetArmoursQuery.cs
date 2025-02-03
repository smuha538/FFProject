using Application.Models;
using MediatR;

namespace Application.Queries.Armours;

/// <summary>
/// Gets all armour
/// </summary>
public record GetArmoursQuery : IRequest<IEnumerable<ArmourModel>>;
