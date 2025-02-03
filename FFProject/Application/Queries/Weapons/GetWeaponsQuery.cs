using Application.Models;
using MediatR;

namespace Application.Queries.Weapons;

/// <summary>
/// Gets all weapons
/// </summary>
public record GetWeaponsQuery : IRequest<IEnumerable<WeaponModel>>;
