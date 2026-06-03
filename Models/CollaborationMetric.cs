namespace SmartERPDashboard.Models;

/// <summary>
/// Represents a team collaboration metric.
/// </summary>
public class CollaborationMetric
{
    public string Title { get; set; } = string.Empty;
    public string Value { get; set; } = string.Empty;
    public string Unit { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
    public string Trend { get; set; } = string.Empty;
    public bool IsPositiveTrend { get; set; }
    public string ColorClass { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}

/// <summary>
/// Represents a collaboration tool showcase.
/// </summary>
public class CollaborationTool
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty; // Communication, Project Management, Documentation, etc.
    public string ShortDescription { get; set; } = string.Empty;
    public string BeforeScenario { get; set; } = string.Empty;
    public string AfterScenario { get; set; } = string.Empty;
    public int TimeSavedPercent { get; set; }
    public string AccentColor { get; set; } = string.Empty;
}

/// <summary>
/// Represents team productivity data for charts.
/// </summary>
public class TeamProductivityData
{
    public List<string> Labels { get; set; } = new();
    public List<double> RemoteProductivity { get; set; } = new();
    public List<double> OfficeProductivity { get; set; } = new();
    public List<double> HybridProductivity { get; set; } = new();
}
