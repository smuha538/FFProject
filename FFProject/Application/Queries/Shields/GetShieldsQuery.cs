using Application.Models;
using MediatR;

namespace Application.Queries.Shields;

public record GetShieldsQuery : IRequest<List<ShieldModel>>;
