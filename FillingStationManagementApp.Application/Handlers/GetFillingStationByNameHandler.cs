using FillingStationManagementApp.Application.Mappers;
using FillingStationManagementApp.Application.Queries;
using FillingStationManagementApp.Application.Responses;
using FillingStationManagementApp.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillingStationManagementApp.Application.Handlers
{
    public class GetFillingStationByNameHandler : IRequestHandler<GetFillingStationByNameQuery, FillingStationResponse>
    {
        private readonly IFillingStationRepository _fillingStationRepository;

        public GetFillingStationByNameHandler(IFillingStationRepository fillingStationRepository)
        {
            _fillingStationRepository = fillingStationRepository;
        }

        public async Task<FillingStationResponse> Handle(GetFillingStationByNameQuery request, CancellationToken cancellationToken)
        {
            var fillingStation = await _fillingStationRepository.GetFillingStationByName(request.FillingStationName);
            var fillingStationResponse = FillingStationMapper.Mapper.Map<FillingStationResponse>(fillingStation);
            return fillingStationResponse;
        }
    }
}
