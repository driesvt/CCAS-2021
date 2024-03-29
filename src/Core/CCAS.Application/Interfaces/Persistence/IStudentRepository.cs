﻿using CCAS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCAS.Application.Interfaces.Persistence
{
    public interface IStudentRepository : IGenericRepository<Student>
    {
    }
}
