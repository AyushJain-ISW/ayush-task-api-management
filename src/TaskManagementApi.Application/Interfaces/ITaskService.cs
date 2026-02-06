using TaskManagementApi.Domain.Entities;

namespace TaskManagementApi.Application.Interfaces;

/// <summary>
/// Service interface for Task business logic
/// </summary>
public interface ITaskService
{
    Task<TaskItem> CreateTaskAsync(string title, string? description, bool isCompleted);
}
