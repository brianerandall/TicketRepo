﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketTrackerEntityModel;
using TicketTrackerRepo.DTOs;
using TicketTrackerRepo.Interfaces;

namespace TicketTrackerRepo.Repo
{
    public class ShowTypeRepository : TicketTrackerRepo<ShowType, ShowTypeDto>, IShowTypeRepository
    {
    }
}
