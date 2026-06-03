namespace SmartERPDashboard.Models;

/// <summary>
/// Represents a stage in an operational workflow.
/// </summary>
public class OperationStage
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
    public int DurationMinutes { get; set; }
    public int DurationMinutesBeforeTech { get; set; }
    public string Status { get; set; } = "pending"; // pending, active, completed
    public string ColorClass { get; set; } = string.Empty;
    public List<string> Tasks { get; set; } = new();
}

/// <summary>
/// Represents a complete operational workflow.
/// </summary>
public class OperationWorkflow
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
    public List<OperationStage> Stages { get; set; } = new();
    public int TotalTimeSaved { get; set; }
    public int EfficiencyImprovement { get; set; }
}
