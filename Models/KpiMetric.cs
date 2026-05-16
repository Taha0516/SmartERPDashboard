namespace SmartERPDashboard.Models;

/// <summary>
/// Represents a single Key Performance Indicator shown on the dashboard.
/// </summary>
public class KpiMetric
{
    public string Title { get; set; } = string.Empty;
    public string Value { get; set; } = string.Empty;
    public string Unit { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;       // Bootstrap icon class, e.g. "bi-graph-up-arrow"
    public string Trend { get; set; } = string.Empty;      // e.g. "+12%" or "-8%"
    public bool IsPositiveTrend { get; set; }
    public string ColorClass { get; set; } = string.Empty; // CSS class for accent color
}
