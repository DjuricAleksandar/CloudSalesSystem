using Application.Dto;
using Application.Enums;
using AutoMapper;
using Domain.Interfaces.Repositories;
using MediatR;

namespace Application.Features.Licenses.GetLicenses;

internal class GetLicensesQueryHandler(ILicensesRepository repository, IMapper mapper) : IRequestHandler<GetLicensesQuery, IEnumerable<License>>
{
    public async Task<IEnumerable<License>> Handle(GetLicensesQuery request, CancellationToken cancellationToken)
    {
        var licenses = await repository.GetAll();
        var dtoLicenses = mapper.Map<IEnumerable<License>>(licenses);
        return dtoLicenses;
    }
}