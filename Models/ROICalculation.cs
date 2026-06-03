namespace SmartERPDashboard.Models;

/// <summary>
/// Represents an ROI calculation input and result.
/// </summary>
public class ROICalculation
{
    public int EmployeeCount { get; set; } = 100;
    public decimal AnnualRevenue { get; set; } = 1000000;
    public string Industry { get; set; } = "Technology";
    public decimal CurrentTechSpend { get; set; } = 50000;
    
    // Calculated results
    public decimal ProjectedSavings { get; set; }
    public decimal EfficiencyGain { get; set; }
    public decimal PaybackMonths { get; set; }
    public decimal ThreeYearROI { get; set; }
}

/// <summary>
/// Industry benchmark data for ROI calculations.
/// </summary>
public class IndustryBenchmark
{
    public string Industry { get; set; } = string.Empty;
    public decimal AvgEfficiencyGain { get; set; }
    public decimal AvgCostReduction { get; set; }
    public string Description { get; set; } = string.Empty;
}
