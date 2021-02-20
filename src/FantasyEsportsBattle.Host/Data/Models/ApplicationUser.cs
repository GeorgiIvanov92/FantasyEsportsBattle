﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FantasyEsportsBattle.Host.Data.Models.Tournament;
using Microsoft.AspNetCore.Identity;

namespace FantasyEsportsBattle.Host.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<ApplicationUserTournament> ApplicationUserTournaments { get; set; }
    }
}
