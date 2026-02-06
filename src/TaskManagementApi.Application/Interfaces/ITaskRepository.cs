using TaskManagementApi.Domain.Entities;

namespace TaskManagementApi.Application.Interfaces;

/// <summary>
/// Repository interface for Task operations
/// </summary>
public interface ITaskRepository
{
    Task<TaskItem> CreateAsync(TaskItem task);
}
