using FillingStationManagementApp.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillingStationManagementApp.Application.Queries
{
    public class GetFillingStationByNameQuery : IRequest<FillingStationResponse>
        
    {
        public GetFillingStationByNameQuery(string fillingStationName)
        {
            FillingStationName = fillingStationName;
        }

        public string FillingStationName { get; set; }


    }
}
