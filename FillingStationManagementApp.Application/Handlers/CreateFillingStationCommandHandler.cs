using FillingStationManagementApp.Application.Commands;
using FillingStationManagementApp.Application.Mappers;
using FillingStationManagementApp.Application.Responses;
using FillingStationManagementApp.Core.Entities;
using FillingStationManagementApp.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillingStationManagementApp.Application.Handlers
{
    public class CreateFillingStationCommandHandler : IRequestHandler<CreateFillingStationCommand, FillingStationResponse>
    {
        private readonly IFillingStationRepository _FillingStationRepository;

        public CreateFillingStationCommandHandler(IFillingStationRepository FillingStationRepository)
        {
            _FillingStationRepository = FillingStationRepository;
        }
        public async Task<FillingStationResponse> Handle(CreateFillingStationCommand request, CancellationToken cancellationToken)
        {
            FillingStation FillingStationEntity = FillingStationMapper.Mapper.Map<FillingStation>(request);
            if (FillingStationEntity is null)
            {
                throw new ApplicationException("There Is An Issue With Mapping...");
            }

            var newFillingStation = await _FillingStationRepository.AddAsync(FillingStationEntity);
            FillingStationResponse FillingStationResponse = FillingStationMapper.Mapper.Map<FillingStationResponse>(newFillingStation);
            return FillingStationResponse;
        }
    }
}
