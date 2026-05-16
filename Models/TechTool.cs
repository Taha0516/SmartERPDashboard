namespace SmartERPDashboard.Models;

/// <summary>
/// Represents a technology card shown in the Tech Toolkit page.
/// </summary>
public class TechTool
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;       // Bootstrap icon class
    public string ShortDescription { get; set; } = string.Empty;
    public string DetailLine1 { get; set; } = string.Empty; // First sentence for modal
    public string DetailLine2 { get; set; } = string.Empty; // Second sentence for modal
    public string AccentColor { get; set; } = string.Empty; // CSS custom color variable
}
