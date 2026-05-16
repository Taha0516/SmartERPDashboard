using SmartERPDashboard.Models;

namespace SmartERPDashboard.Services;

/// <summary>
/// Concrete implementation of IMockDataService.
/// All data is hard-coded to simulate realistic ERP metrics.
/// </summary>
public class MockDataService : IMockDataService
{
    private readonly LocalizationService _loc;

    public MockDataService(LocalizationService loc)
    {
        _loc = loc;
    }

    // ─────────────────────────────────────────────────────────────
    //  KPI Cards
    // ─────────────────────────────────────────────────────────────
    public List<KpiMetric> GetKpiMetrics(bool afterTech) => afterTech
        ? new()
        {
            new() { Title = _loc.T("Sales Growth"),          Value = "34",  Unit = "%",  Icon = "bi-graph-up-arrow",     Trend = "+22%",  IsPositiveTrend = true,  ColorClass = "kpi-blue"   },
            new() { Title = _loc.T("Operational Costs"),     Value = "18",  Unit = "%",  Icon = "bi-currency-dollar",    Trend = "-40%",  IsPositiveTrend = true,  ColorClass = "kpi-green"  },
            new() { Title = _loc.T("Customer Satisfaction"), Value = "94",  Unit = "/100", Icon = "bi-emoji-smile",      Trend = "+31 pts", IsPositiveTrend = true, ColorClass = "kpi-teal"  },
            new() { Title = _loc.T("Avg Response Time"),     Value = "3",   Unit = _loc.T("min"),  Icon = "bi-lightning-charge", Trend = "-87%",  IsPositiveTrend = true,  ColorClass = "kpi-purple" },
        }
        : new()
        {
            new() { Title = _loc.T("Sales Growth"),          Value = "12",  Unit = "%",  Icon = "bi-graph-up-arrow",     Trend = "+12%",  IsPositiveTrend = false, ColorClass = "kpi-blue"   },
            new() { Title = _loc.T("Operational Costs"),     Value = "58",  Unit = "%",  Icon = "bi-currency-dollar",    Trend = _loc.T("High"),  IsPositiveTrend = false, ColorClass = "kpi-green"  },
            new() { Title = _loc.T("Customer Satisfaction"), Value = "63",  Unit = "/100", Icon = "bi-emoji-neutral",    Trend = "63 pts",IsPositiveTrend = false, ColorClass = "kpi-teal"  },
            new() { Title = _loc.T("Avg Response Time"),     Value = "24",  Unit = _loc.T("hrs"),  Icon = "bi-clock-history",    Trend = _loc.T("Slow"),  IsPositiveTrend = false, ColorClass = "kpi-purple" },
        };

    // ─────────────────────────────────────────────────────────────
    //  Chart Data
    // ─────────────────────────────────────────────────────────────
    public ChartData GetGrowthChartData(bool afterTech)
    {
        var labels = new List<string> { "Q1 2021", "Q2 2021", "Q3 2021", "Q4 2021",
                                        "Q1 2022", "Q2 2022", "Q3 2022", "Q4 2022",
                                        "Q1 2023", "Q2 2023" };
        if (afterTech)
        {
            return new ChartData
            {
                Labels = labels,
                Datasets = new()
                {
                    new()
                    {
                        Label           = _loc.T("Our Organization (Post-Tech)"),
                        Data            = new() { 12, 16, 20, 26, 31, 37, 45, 54, 63, 72 },
                        BorderColor     = "rgba(56, 189, 248, 1)",
                        BackgroundColor = "rgba(56, 189, 248, 0.15)",
                        Fill            = true,
                        Tension         = 4
                    },
                    new()
                    {
                        Label           = _loc.T("Market Competitors"),
                        Data            = new() { 11, 12, 13, 14, 14, 15, 17, 18, 19, 21 },
                        BorderColor     = "rgba(251, 146, 60, 1)",
                        BackgroundColor = "rgba(251, 146, 60, 0.1)",
                        Fill            = false,
                        Tension         = 2
                    }
                }
            };
        }
        return new ChartData
        {
            Labels = labels,
            Datasets = new()
            {
                new()
                {
                    Label           = _loc.T("Our Organization (Pre-Tech)"),
                    Data            = new() { 10, 10, 11, 12, 12, 13, 13, 14, 14, 15 },
                    BorderColor     = "rgba(148, 163, 184, 1)",
                    BackgroundColor = "rgba(148, 163, 184, 0.15)",
                    Fill            = true,
                    Tension         = 2
                },
                new()
                {
                    Label           = _loc.T("Market Competitors"),
                    Data            = new() { 11, 12, 13, 14, 14, 15, 17, 18, 19, 21 },
                    BorderColor     = "rgba(251, 146, 60, 1)",
                    BackgroundColor = "rgba(251, 146, 60, 0.1)",
                    Fill            = false,
                    Tension         = 2
                }
            }
        };
    }

    // ─────────────────────────────────────────────────────────────
    //  Tech Tools
    // ─────────────────────────────────────────────────────────────
    public List<TechTool> GetTechTools() => new()
    {
        new()
        {
            Id           = "cloud",
            Name         = _loc.T("Cloud Computing"),
            Icon         = "bi-cloud-arrow-up-fill",
            ShortDescription = _loc.T("Scalable, on-demand infrastructure."),
            DetailLine1  = _loc.T("Cloud computing eliminated costly on-premise servers, reducing IT infrastructure spend by 45% and enabling instant global scalability."),
            DetailLine2  = _loc.T("Real-time data access from any location accelerated decision-making cycles by 60%, giving the organization a decisive edge over slower, legacy-bound competitors."),
            AccentColor  = "#38bdf8"
        },
        new()
        {
            Id           = "ai",
            Name         = _loc.T("Artificial Intelligence"),
            Icon         = "bi-robot",
            ShortDescription = _loc.T("Predictive analytics & smart automation."),
            DetailLine1  = _loc.T("AI-powered demand forecasting reduced inventory waste by 38% and boosted on-time deliveries to 97%, directly improving the bottom line."),
            DetailLine2  = _loc.T("Machine-learning recommendation engines increased average order value by 27% by surfacing hyper-personalized product suggestions at the right moment."),
            AccentColor  = "#a78bfa"
        },
        new()
        {
            Id           = "rpa",
            Name         = _loc.T("Robotic Process Automation"),
            Icon         = "bi-gear-wide-connected",
            ShortDescription = _loc.T("End-to-end workflow automation."),
            DetailLine1  = _loc.T("RPA bots handle 85% of repetitive back-office tasks — invoice processing, data entry, and reconciliation — without a single human touch."),
            DetailLine2  = _loc.T("This freed 1,200+ employee-hours per month, which were reallocated to high-value strategic work, compressing quarterly close cycles from 10 days to 2."),
            AccentColor  = "#34d399"
        },
        new()
        {
            Id           = "payment",
            Name         = _loc.T("Smart Payment Systems"),
            Icon         = "bi-credit-card-2-front-fill",
            ShortDescription = _loc.T("Frictionless, secure digital transactions."),
            DetailLine1  = _loc.T("Integrating AI-fraud-detection into the payment gateway reduced chargebacks by 92% and cut false-positive declines, recovering an estimated $2.1 M annually."),
            DetailLine2  = _loc.T("One-click checkout and multi-wallet support (Apple Pay, Google Pay, BNPL) lifted cart conversion rates by 33%, directly boosting quarterly revenue."),
            AccentColor  = "#fb923c"
        },
    };

    // ─────────────────────────────────────────────────────────────
    //  Chatbot
    // ─────────────────────────────────────────────────────────────
    public List<ChatbotEntry> GetChatbotEntries() => new()
    {
        new()
        {
            Query = _loc.T("📦  Where is my order?"),
            Reply = _loc.T("Your order #ORD-8821 is currently **Out for Delivery** and is expected at your door within 2 hours. You can track it live on our map. 🚚")
        },
        new()
        {
            Query = _loc.T("💳  How do I get a refund?"),
            Reply = _loc.T("Refunds are processed instantly to your original payment method. Simply go to **My Orders → Request Refund** and we will credit you within 24 hours. ✅")
        },
        new()
        {
            Query = _loc.T("🕐  What are your support hours?"),
            Reply = _loc.T("Our AI support is available **24 hours a day, 7 days a week, 365 days a year** — no waiting, no queues. Human agents are on call Mon–Fri 9 AM–6 PM for escalations. 🤖")
        },
    };
}
