﻿using ExamProctoringManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProctoringManagement.Repository.Interfaces
{
    public interface IRegistrationFormRepository
    {
        Task<RegistrationForm> GetByIdAsync(string id);
        Task<IEnumerable<RegistrationForm>> GetAllAsync();
        Task CreateAsync(RegistrationForm registrationForm);
        Task UpdateAsync(RegistrationForm registrationForm);
        Task DeleteAsync(string id);
    }
}
