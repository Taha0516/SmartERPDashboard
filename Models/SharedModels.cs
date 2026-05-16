namespace SmartERPDashboard.Models;

/// <summary>
/// Represents a single dataset for Chart.js charts.
/// </summary>
public class ChartDataset
{
    public string Label { get; set; } = string.Empty;
    public List<double> Data { get; set; } = new();
    public string BorderColor { get; set; } = string.Empty;
    public string BackgroundColor { get; set; } = string.Empty;
    public bool Fill { get; set; } = false;
    public int Tension { get; set; } = 0;
}

/// <summary>
/// Full data payload passed to Chart.js via IJSRuntime.
/// </summary>
public class ChartData
{
    public List<string> Labels { get; set; } = new();
    public List<ChartDataset> Datasets { get; set; } = new();
}

/// <summary>
/// A predefined chatbot Q&amp;A pair.
/// </summary>
public class ChatbotEntry
{
    public string Query { get; set; } = string.Empty;
    public string Reply { get; set; } = string.Empty;
}

/// <summary>
/// A single message in the chat window.
/// </summary>
public class ChatMessage
{
    public string Text { get; set; } = string.Empty;
    public bool IsBot { get; set; }
    public DateTime Timestamp { get; set; } = DateTime.Now;
}
