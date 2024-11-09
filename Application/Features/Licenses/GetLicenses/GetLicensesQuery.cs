using Application.Dto;
using MediatR;

namespace Application.Features.Licenses.GetLicenses;

public record GetLicensesQuery : IRequest<IEnumerable<License>>;