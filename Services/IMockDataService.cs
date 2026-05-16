using SmartERPDashboard.Models;

namespace SmartERPDashboard.Services;

/// <summary>
/// Contract for supplying all mock data to the dashboard components.
/// </summary>
public interface IMockDataService
{
    /// <summary>Returns KPI cards for the given state (before/after tech adoption).</summary>
    List<KpiMetric> GetKpiMetrics(bool afterTech);

    /// <summary>Returns chart data comparing the organization vs. competitors.</summary>
    ChartData GetGrowthChartData(bool afterTech);

    /// <summary>Returns all technology tool cards.</summary>
    List<TechTool> GetTechTools();

    /// <summary>Returns predefined chatbot Q&amp;A pairs.</summary>
    List<ChatbotEntry> GetChatbotEntries();
}
