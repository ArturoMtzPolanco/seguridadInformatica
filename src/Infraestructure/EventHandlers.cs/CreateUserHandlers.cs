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

namespace Infraestructure.EventHandler.cs
{
    public class CreateUserHandlers : IRequestHandler<CreateUserCommand, Response<int>>
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public CreateUserHandlers(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<Response<int>> Handle(CreateUserCommand reques, CancellationToken cancellationToken)
        {
            var u = new CreateUserCommand();
            u.Nombre = reques.Nombre;
            u.Ap_paterno = reques.Ap_paterno;

            var us = _mapper.Map<Domain.Entities.users>(u);
            await _context.users.AddAsync(us);
            await _context.SaveChangesAsync();
            return new Response<int>(us.Id, "Registro Creado");
        }
    }
}
