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

    // ─────────────────────────────────────────────────────────────
    //  ROI Calculator
    // ─────────────────────────────────────────────────────────────
    public List<IndustryBenchmark> GetIndustryBenchmarks() => new()
    {
        new()
        {
            Industry = _loc.T("Technology"),
            AvgEfficiencyGain = 42,
            AvgCostReduction = 35,
            Description = _loc.T("SaaS and software companies see high automation gains")
        },
        new()
        {
            Industry = _loc.T("Manufacturing"),
            AvgEfficiencyGain = 38,
            AvgCostReduction = 28,
            Description = _loc.T("Smart factories and IoT integration drive major improvements")
        },
        new()
        {
            Industry = _loc.T("Retail"),
            AvgEfficiencyGain = 45,
            AvgCostReduction = 32,
            Description = _loc.T("Inventory automation and AI forecasting transform operations")
        },
        new()
        {
            Industry = _loc.T("Healthcare"),
            AvgEfficiencyGain = 33,
            AvgCostReduction = 25,
            Description = _loc.T("Digital patient records and automated scheduling save time")
        },
        new()
        {
            Industry = _loc.T("Finance"),
            AvgEfficiencyGain = 40,
            AvgCostReduction = 30,
            Description = _loc.T("RPA in compliance and trading delivers strong ROI")
        },
        new()
        {
            Industry = _loc.T("Logistics"),
            AvgEfficiencyGain = 48,
            AvgCostReduction = 38,
            Description = _loc.T("Route optimization and warehouse automation are game-changers")
        },
    };

    // ─────────────────────────────────────────────────────────────
    //  Operations Center
    // ─────────────────────────────────────────────────────────────
    public List<OperationWorkflow> GetOperationWorkflows() => new()
    {
        new()
        {
            Id = "inventory",
            Name = _loc.T("Smart Inventory Management"),
            Description = _loc.T("AI-powered demand forecasting and automated reordering"),
            Icon = "bi-box-seam",
            TotalTimeSaved = 28,
            EfficiencyImprovement = 67,
            Stages = new()
            {
                new()
                {
                    Id = "demand",
                    Name = _loc.T("AI Demand Forecasting"),
                    Description = _loc.T("Machine learning predicts stock needs 30 days ahead"),
                    Icon = "bi-graph-up-arrow",
                    DurationMinutes = 5,
                    DurationMinutesBeforeTech = 120,
                    ColorClass = "stage-blue",
                    Tasks = new() { _loc.T("Analyze historical data"), _loc.T("Predict seasonal trends"), _loc.T("Generate forecast reports") }
                },
                new()
                {
                    Id = "auto-reorder",
                    Name = _loc.T("Automated Reordering"),
                    Description = _loc.T("System places orders when stock hits threshold"),
                    Icon = "bi-arrow-repeat",
                    DurationMinutes = 2,
                    DurationMinutesBeforeTech = 45,
                    ColorClass = "stage-green",
                    Tasks = new() { _loc.T("Check stock levels"), _loc.T("Calculate optimal order qty"), _loc.T("Send PO to suppliers") }
                },
                new()
                {
                    Id = "track",
                    Name = _loc.T("Real-Time Tracking"),
                    Description = _loc.T("Live visibility of shipments and delivery status"),
                    Icon = "bi-geo-alt",
                    DurationMinutes = 0,
                    DurationMinutesBeforeTech = 30,
                    ColorClass = "stage-teal",
                    Tasks = new() { _loc.T("Monitor shipments"), _loc.T("Update inventory"), _loc.T("Notify stakeholders") }
                }
            }
        },
        new()
        {
            Id = "production",
            Name = _loc.T("Production Line Optimization"),
            Description = _loc.T("IoT sensors and predictive maintenance scheduling"),
            Icon = "bi-gear",
            TotalTimeSaved = 45,
            EfficiencyImprovement = 82,
            Stages = new()
            {
                new()
                {
                    Id = "monitor",
                    Name = _loc.T("IoT Monitoring"),
                    Description = _loc.T("Sensors track equipment health in real-time"),
                    Icon = "bi-activity",
                    DurationMinutes = 0,
                    DurationMinutesBeforeTech = 60,
                    ColorClass = "stage-purple",
                    Tasks = new() { _loc.T("Collect sensor data"), _loc.T("Detect anomalies"), _loc.T("Alert maintenance team") }
                },
                new()
                {
                    Id = "predict",
                    Name = _loc.T("Predictive Maintenance"),
                    Description = _loc.T("AI predicts failures before they happen"),
                    Icon = "bi-cpu",
                    DurationMinutes = 10,
                    DurationMinutesBeforeTech = 180,
                    ColorClass = "stage-orange",
                    Tasks = new() { _loc.T("Analyze wear patterns"), _loc.T("Schedule maintenance"), _loc.T("Order replacement parts") }
                },
                new()
                {
                    Id = "optimize",
                    Name = _loc.T("Auto-Optimization"),
                    Description = _loc.T("System adjusts parameters for peak efficiency"),
                    Icon = "bi-sliders",
                    DurationMinutes = 0,
                    DurationMinutesBeforeTech = 90,
                    ColorClass = "stage-cyan",
                    Tasks = new() { _loc.T("Adjust line speed"), _loc.T("Optimize energy use"), _loc.T("Balance workloads") }
                }
            }
        },
        new()
        {
            Id = "quality",
            Name = _loc.T("Quality Assurance Automation"),
            Description = _loc.T("Computer vision and automated defect detection"),
            Icon = "bi-check2-square",
            TotalTimeSaved = 35,
            EfficiencyImprovement = 94,
            Stages = new()
            {
                new()
                {
                    Id = "scan",
                    Name = _loc.T("Automated Scanning"),
                    Description = _loc.T("Computer vision inspects every unit"),
                    Icon = "bi-camera",
                    DurationMinutes = 0,
                    DurationMinutesBeforeTech = 300,
                    ColorClass = "stage-pink",
                    Tasks = new() { _loc.T("Capture product images"), _loc.T("Detect defects"), _loc.T("Flag issues instantly") }
                },
                new()
                {
                    Id = "report",
                    Name = _loc.T("Instant Reporting"),
                    Description = _loc.T("Quality dashboards update in real-time"),
                    Icon = "bi-clipboard-data",
                    DurationMinutes = 2,
                    DurationMinutesBeforeTech = 60,
                    ColorClass = "stage-yellow",
                    Tasks = new() { _loc.T("Generate QC reports"), _loc.T("Alert supervisors"), _loc.T("Update compliance logs") }
                }
            }
        }
    };

    // ─────────────────────────────────────────────────────────────
    //  Team Collaboration
    // ─────────────────────────────────────────────────────────────
    public List<CollaborationMetric> GetCollaborationMetrics() => new()
    {
        new()
        {
            Title = _loc.T("Response Time"),
            Value = "8",
            Unit = _loc.T("min"),
            Icon = "bi-lightning-charge",
            Trend = "-73%",
            IsPositiveTrend = true,
            ColorClass = "metric-blue",
            Description = _loc.T("Average time to respond to team messages")
        },
        new()
        {
            Title = _loc.T("Meeting Efficiency"),
            Value = "35",
            Unit = "%",
            Icon = "bi-calendar-check",
            Trend = "+35%",
            IsPositiveTrend = true,
            ColorClass = "metric-green",
            Description = _loc.T("Reduction in unnecessary meeting time")
        },
        new()
        {
            Title = _loc.T("Document Access"),
            Value = "99.9",
            Unit = "%",
            Icon = "bi-cloud-check",
            Trend = "+24%",
            IsPositiveTrend = true,
            ColorClass = "metric-teal",
            Description = _loc.T("Uptime for cloud document storage")
        },
        new()
        {
            Title = _loc.T("Cross-Team Projects"),
            Value = "156",
            Unit = "",
            Icon = "bi-people",
            Trend = "+42",
            IsPositiveTrend = true,
            ColorClass = "metric-purple",
            Description = _loc.T("Active collaborative projects this quarter")
        }
    };

    public List<CollaborationTool> GetCollaborationTools() => new()
    {
        new()
        {
            Id = "messaging",
            Name = _loc.T("Unified Messaging"),
            Icon = "bi-chat-dots",
            Category = _loc.T("Communication"),
            ShortDescription = _loc.T("Instant team communication across departments"),
            BeforeScenario = _loc.T("Email chains with 24hr response delays"),
            AfterScenario = _loc.T("Instant replies and threaded conversations"),
            TimeSavedPercent = 65,
            AccentColor = "#38bdf8"
        },
        new()
        {
            Id = "video",
            Name = _loc.T("Smart Video Conferencing"),
            Icon = "bi-camera-video",
            Category = _loc.T("Meetings"),
            ShortDescription = _loc.T("AI-powered meetings with transcription"),
            BeforeScenario = _loc.T("In-person meetings, travel time, no records"),
            AfterScenario = _loc.T("Remote attendance, auto-transcription, action items"),
            TimeSavedPercent = 45,
            AccentColor = "#a78bfa"
        },
        new()
        {
            Id = "docs",
            Name = _loc.T("Cloud Documents"),
            Icon = "bi-file-earmark-text",
            Category = _loc.T("Documentation"),
            ShortDescription = _loc.T("Real-time collaborative editing"),
            BeforeScenario = _loc.T("Version chaos, email attachments, conflicts"),
            AfterScenario = _loc.T("Single source of truth, simultaneous editing"),
            TimeSavedPercent = 55,
            AccentColor = "#34d399"
        },
        new()
        {
            Id = "project",
            Name = _loc.T("Project Management"),
            Icon = "bi-kanban",
            Category = _loc.T("Planning"),
            ShortDescription = _loc.T("Visual task tracking and automation"),
            BeforeScenario = _loc.T("Spreadsheets, status meetings, manual updates"),
            AfterScenario = _loc.T("Real-time boards, automated workflows, alerts"),
            TimeSavedPercent = 50,
            AccentColor = "#fb923c"
        },
        new()
        {
            Id = "whiteboard",
            Name = _loc.T("Digital Whiteboard"),
            Icon = "bi-easel",
            Category = _loc.T("Ideation"),
            ShortDescription = _loc.T("Infinite canvas for team brainstorming"),
            BeforeScenario = _loc.T("Physical whiteboards, photo snapshots, no access"),
            AfterScenario = _loc.T("Persistent boards, async contribution, templates"),
            TimeSavedPercent = 40,
            AccentColor = "#f472b6"
        },
        new()
        {
            Id = "knowledge",
            Name = _loc.T("Knowledge Base"),
            Icon = "bi-journal-bookmark",
            Category = _loc.T("Information"),
            ShortDescription = _loc.T("Searchable company wiki and FAQs"),
            BeforeScenario = _loc.T("Tribal knowledge, repeated questions, silos"),
            AfterScenario = _loc.T("Self-service answers, onboarding docs, search"),
            TimeSavedPercent = 70,
            AccentColor = "#22d3ee"
        }
    };

    public TeamProductivityData GetTeamProductivityData() => new()
    {
        Labels = new() { _loc.T("Mon"), _loc.T("Tue"), _loc.T("Wed"), _loc.T("Thu"), _loc.T("Fri") },
        RemoteProductivity = new() { 92, 94, 91, 95, 89 },
        OfficeProductivity = new() { 85, 87, 84, 86, 82 },
        HybridProductivity = new() { 95, 96, 94, 97, 93 }
    };
}
