using ApplicationCore.Commands.LogsR;
using ApplicationCore.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Commands.LogsR;
using ApplicationCore.DTOs.User;
using Infraestructure.Persistence;
using AutoMapper;

namespace Infraestructure.EventHandlers.cs.LogsR
{
    public class CreateLogHandler : IRequestHandler<CreateLogsCommand, Response<int>>
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CreateLogHandler(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Response<int>> Handle(CreateLogsCommand command, CancellationToken cancellationToken)

        {
            var l =new CreateLogsCommand();
            l.ip = command.ip;
            l.fecha = command.fecha;
            l.datos = command.datos;
            l.response = command.response;
            l.nombreFuncion = command.nombreFuncion;

            var lo = _mapper.Map<Domain.Entities.logs>(l);

            await _context.SaveChangesAsync();

            return new Response<int>(lo.Id, "Registro creado");

        }




        }
    }

   

