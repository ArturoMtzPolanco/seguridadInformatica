using ApplicationCore.Commands.LogsR;
using ApplicationCore.Commands.Users;
using ApplicationCore.Wrappers;
using AutoMapper;
using Infraestructure.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.EventHandler
{
    public class CreateUserHandlers : IRequestHandler<CreateUsersCommand, Response<int>>
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public CreateUserHandlers(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<Response<int>> Handle(CreateUsersCommand request, CancellationToken cancellationToken)
        {
            var u = new CreateUsersCommand();
            u.Nombre = request.Nombre;
            u.Ap_paterno = request.Ap_paterno;

            var us = _mapper.Map<Domain.Entities.users>(u);
            await _context.users.AddAsync(us);
            await _context.SaveChangesAsync();
            return new Response<int>(us.Id, "Registro Creado");
        }
    }
}
