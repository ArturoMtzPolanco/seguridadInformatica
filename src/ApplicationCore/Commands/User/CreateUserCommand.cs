﻿using ApplicationCore.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.DTOs.User;

namespace ApplicationCore.Commands.Users
{
    public class CreateUsersCommand : UserDto, IRequest<Response<int>>
    {

    }
}
