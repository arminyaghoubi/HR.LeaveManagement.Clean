﻿using HR.LeaveManagement.Application.Features.LeaveRequest.Commands.Common;
using HR.LeaveManagement.Application.Features.LeaveType.Queries.GetAll;

namespace HR.LeaveManagement.Application.Features.LeaveRequest.Queries.GetAll;

public class GetLeaveRequestDto: BaseLeaveRequestDto
{
    public int Id { get; set; }
    public GetLeaveTypesDto LeaveType { get; set; }
    public DateTime RequestDate { get; set; }
    public bool? Approved { get; set; }
    public bool Cancelled { get; set; }
    public string EmployeeId { get; set; } = string.Empty;
}