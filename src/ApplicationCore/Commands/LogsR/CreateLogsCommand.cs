using ApplicationCore.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.DTOs.logs;

namespace ApplicationCore.Commands.LogsR
{
    public class CreateLogsCommand :LogsDto, IRequest<Response<int>>
    {

    }
}
