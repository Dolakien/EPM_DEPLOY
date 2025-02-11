﻿using ExamProctoringManagement.Contract.Payloads.Request;
using ExamProctoringManagement.Data.Models;
using ExamProctoringManagement.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExamProctoringManagement.API.Controllers
{

    public class GroupController : BaseApiController
    {
        private readonly IGroupService _groupService;

        public GroupController(IGroupService groupService)
        {
            _groupService = groupService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Group>> GetGroup(string id)
        {
            var group = await _groupService.GetGroupByIdAsync(id);
            if (group == null)
            {
                return NotFound();
            }
            return group;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Group>>> GetAllGroups()
        {
            var groups = await _groupService.GetAllGroupsAsync();
            return Ok(groups);
        }

        [HttpPost("create")]
        public async Task<ActionResult<Group>> CreateGroup([FromBody] Group group)
        {
            var createdGroup = await _groupService.CreateGroupAsync(group);
            return CreatedAtAction(nameof(GetGroup), new { id = createdGroup.GroupId }, createdGroup);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateGroup(string id, [FromBody] Group group)
        {
            if (id != group.GroupId)
            {
                return BadRequest();
            }

            await _groupService.UpdateGroupAsync(group);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGroup(string id)
        {
            await _groupService.DeleteGroupAsync(id);
            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Group>> CreateGroupAndGroupRooms([FromBody] CreateGroupAndRoomsRequest createGroupAndRoomsRequest)
        {
            if (createGroupAndRoomsRequest.Rooms.Count() > 3 || createGroupAndRoomsRequest.Rooms.Count() == 0)
            {
                return BadRequest();
            }
            var createdGroup = await _groupService.CreateGroupAndGroupRoomAsync(createGroupAndRoomsRequest);
            return CreatedAtAction(nameof(GetGroup), new { id = createdGroup.GroupId }, createdGroup);
        }
    }
}
