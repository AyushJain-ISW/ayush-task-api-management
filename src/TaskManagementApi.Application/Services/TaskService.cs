using TaskManagementApi.Application.Interfaces;
using TaskManagementApi.Domain.Entities;

namespace TaskManagementApi.Application.Services;

/// <summary>
/// Service implementation for Task business logic
/// </summary>
public class TaskService : ITaskService
{
    private readonly ITaskRepository _taskRepository;

    public TaskService(ITaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }

    public async Task<TaskItem> CreateTaskAsync(string title, string? description, bool isCompleted)
    {
        var task = new TaskItem
        {
            Title = title,
            Description = description,
            IsCompleted = isCompleted,
            CreatedAt = DateTime.UtcNow
        };

        return await _taskRepository.CreateAsync(task);
    }
}
