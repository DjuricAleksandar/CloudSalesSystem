using Application.Dto;
using MediatR;

namespace Application.Features.Services.GetServices;

public record GetServicesQuery : IRequest<IEnumerable<Service>>;