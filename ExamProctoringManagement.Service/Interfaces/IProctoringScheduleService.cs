﻿using ExamProctoringManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProctoringManagement.Service.Interfaces
{
    public interface IProctoringScheduleService
    {
        Task<ProctoringSchedule> GetProctoringScheduleByIdAsync(string id);
        Task<IEnumerable<ProctoringSchedule>> GetAllProctoringSchedulesAsync();
        Task<ProctoringSchedule> CreateProctoringScheduleAsync(ProctoringSchedule ProctoringSchedule);
        Task UpdateProctoringScheduleAsync(ProctoringSchedule ProctoringSchedule);
        Task DeleteProctoringScheduleAsync(string id);
    }
}
