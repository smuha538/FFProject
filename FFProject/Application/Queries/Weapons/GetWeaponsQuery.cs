using Application.Models;
using MediatR;

namespace Application.Queries.Weapons;

public record GetWeaponsQuery : IRequest<List<WeaponModel>>;
