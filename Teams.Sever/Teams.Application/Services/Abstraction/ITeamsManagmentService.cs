﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teams.Application.Responses;

namespace Teams.Application.Services.Abstraction
{
   public interface ITeamsManagmentService
    {
        Task<IEnumerable<TeamResponse>> GetAllTeam(string token);
        Task<UserData> GetUserData(string token);
    }
}
