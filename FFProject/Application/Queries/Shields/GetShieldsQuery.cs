using Application.Models;
using MediatR;

namespace Application.Queries.Shields;

/// <summary>
/// Gets all shields
/// </summary>
public record GetShieldsQuery : IRequest<IEnumerable<ShieldModel>>;
