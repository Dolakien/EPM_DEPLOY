﻿using ExamProctoringManagement.Data.Models;
using ExamProctoringManagement.Repository.Interfaces;
using ExamProctoringManagement.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProctoringManagement.Service.Usecases
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _RoomRepository;

        public RoomService(IRoomRepository RoomRepository)
        {
            _RoomRepository = RoomRepository;
        }

        public async Task<Room> GetRoomByIdAsync(string id)
        {
            return await _RoomRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Room>> GetAllRoomsAsync()
        {
            return await _RoomRepository.GetAllAsync();
        }

        public async Task<Room> CreateRoomAsync(Room Room)
        {
            await _RoomRepository.CreateAsync(Room);
            return Room;
        }

        public async Task UpdateRoomAsync(Room Room)
        {
            await _RoomRepository.UpdateAsync(Room);
        }

        public async Task DeleteRoomAsync(string id)
        {
            await _RoomRepository.DeleteAsync(id);
        }
    }

}
