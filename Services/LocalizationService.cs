using System;
using System.Collections.Generic;

namespace SmartERPDashboard.Services;

public class LocalizationService
{
    public bool IsArabic { get; private set; } = true;
    public event Action? OnLanguageChanged;

    public void ToggleLanguage()
    {
        IsArabic = !IsArabic;
        OnLanguageChanged?.Invoke();
    }

    public string Dir => IsArabic ? "rtl" : "ltr";

    private readonly Dictionary<string, string> _ar = new()
    {
        {"SmartERP", "الموارد الذكية (ERP)"},
        {"Academic Demo", "مشروع التخرج"},
        {"Research Dashboard", "لوحة القياس التفاعلية"},
        {"Overview", "نظرة عامة"},
        {"Tech Toolkit", "التقنيات الحديثة"},
        {"Customer Experience", "تجربة العملاء"},
        {"Academic Research Dashboard", "لوحة معلومات بحثية تفاعلية"},
        {"The Role of Modern Technology<br />in Organizational Competitiveness", "دور التكنولوجيا الحديثة<br />في التنافسية المؤسسية"},
        {"Toggle between states to visualize the measurable impact of digital transformation on key business metrics.", "قم بالتبديل لرؤية الأثر المباشر للتحول الرقمي على مؤشرات الأداء الرئيسية."},
        {"Before Tech", "الطرق التقليدية"},
        {"After Tech", "التحول الرقمي"},
        {"Currently viewing:", "أنت تشاهد الآن:"},
        {"✅ Post-Digital Transformation", "✅ بعد التحول الرقمي"},
        {"⚠️ Pre-Digital Transformation", "⚠️ قبل التحول الرقمي"},
        {"Key Performance Indicators", "مؤشرات الأداء الرئيسية (KPIs)"},
        {"Revenue Growth vs. Market Competitors", "نمو الإيرادات مقابل المنافسين"},
        {"Quarterly revenue index — Organization vs. Industry Average", "مؤشر الإيرادات الربع سنوي — مؤسستنا مقابل متوسط السوق"},
        {"Our Organization", "مؤسستنا"},
        {"Competitors", "المنافسين"},
        
        // Tech Toolkit
        {"Core Technologies Driving Competitiveness", "التقنيات الأساسية الدافعة للتنافسية"},
        {"Strategic Tech Stack", "حزمة التقنيات الاستراتيجية"},
        {"Explore how specific digital tools transform operations and create sustainable competitive advantages.", "استكشف كيف تقوم الأدوات الرقمية بتحويل العمليات وخلق مزايا تنافسية مستدامة."},
        {"System Components", "مكونات النظام الأساسية"},
        
        {"Digital Infrastructure", "البنية التحتية الرقمية"},
        {"Technology Toolkit", "أدوات التكنولوجيا"},
        {"Explore the four pillars of modern technology that drive organizational competitiveness and sustainable growth.", "استكشف الركائز الأربع للتكنولوجيا الحديثة التي تدفع التنافسية المؤسسية والنمو المستدام."},
        {"Proven Competitive Advantage", "ميزة تنافسية مثبتة"},
        
        // Customer Experience
        {"Customer-Centric Automation", "أتمتة تركز على العميل"},
        {"Customer Experience Simulation", "محاكاة تجربة العملاء"},
        {"Witness how automation and AI deliver lightning-fast service and around-the-clock intelligent support.", "شاهد كيف توفر الأتمتة والذكاء الاصطناعي خدمة سريعة ودعم ذكي على مدار الساعة."},
        {"Smart Order Tracker", "المتتبع الذكي للطلبات"},
        {"Automated fulfillment pipeline in real-time", "تتبع حي للطلبات بشكل آلي بالكامل"},
        {"Simulate Order", "محاكاة طلب جديد"},
        {"Simulating…", "جاري المحاكاة..."},
        {"Simulate Again", "محاكاة مرة أخرى"},
        {"Automation running…", "عمليات الأتمتة قيد التنفيذ..."},
        {"Order Delivered! ✅ Customer satisfaction secured.", "تم تسليم الطلب بنجاح! ✅"},
        {"24/7 AI Support Bot", "روبوت الدعم الذكي 24/7"},
        {"Click a question to see instant AI-powered responses", "اضغط على سؤال لرؤية الرد الفوري المدعوم بالذكاء الاصطناعي"},
        
        {"Order Placed", "تم تأكيد الطلب"},
        {"Received & validated instantly", "تم الاستلام والتحقق فوراً"},
        {"Processing", "قيد المعالجة"},
        {"AI picks the optimal warehouse route", "الذكاء الاصطناعي يختار أفضل مسار"},
        {"Shipped", "تم الشحن"},
        {"Out for delivery via smart logistics", "في الطريق إليك عبر لوجستيات ذكية"},
        {"Delivered", "تم التوصيل"},
        {"Confirmed at destination ✔", "تم تأكيد الوصول ✔"},
        
        // Chatbot UI
        {"ERP Smart Assistant", "مساعد ذكي للنظام"},
        {"Always online · AI-powered", "متصل دائماً · مدعوم بالذكاء الاصطناعي"},
        {"Suggested questions:", "أسئلة مقترحة:"},
        {"👋 Hello! I'm your 24/7 AI assistant. How can I help you today?", "👋 أهلاً بك! أنا المساعد الذكي. كيف يمكنني مساعدتك اليوم؟"},
        
        // Mock Data
        {"Sales Growth", "نمو المبيعات"},
        {"Operational Costs", "التكاليف التشغيلية"},
        {"Customer Satisfaction", "رضا العملاء"},
        {"Avg Response Time", "متوسط وقت الاستجابة"},
        {"min", "دقيقة"},
        {"hrs", "ساعة"},
        {"High", "مرتفع"},
        {"Slow", "بطيء"},
        {"Our Organization (Post-Tech)", "مؤسستنا (بعد التكنولوجيا)"},
        {"Our Organization (Pre-Tech)", "مؤسستنا (قبل التكنولوجيا)"},
        {"📦  Where is my order?", "📦 أين طلبي؟"},
        {"Your order #ORD-8821 is currently **Out for Delivery** and is expected at your door within 2 hours. You can track it live on our map. 🚚", "طلبك رقم #ORD-8821 حالياً **في الطريق إليك** ومن المتوقع وصوله خلال ساعتين. يمكنك تتبعه مباشرة على الخريطة. 🚚"},
        {"💳  How do I get a refund?", "💳 كيف أسترد أموالي؟"},
        {"Refunds are processed instantly to your original payment method. Simply go to **My Orders → Request Refund** and we will credit you within 24 hours. ✅", "تتم معالجة المبالغ المستردة فوراً إلى طريقة الدفع الأصلية. فقط اذهب إلى **طلباتي → طلب استرجاع** وسنقوم بتحويل المبلغ خلال 24 ساعة. ✅"},
        {"🕐  What are your support hours?", "🕐 ما هي ساعات العمل للدعم الفني؟"},
        {"Our AI support is available **24 hours a day, 7 days a week, 365 days a year** — no waiting, no queues. Human agents are on call Mon–Fri 9 AM–6 PM for escalations. 🤖", "دعم الذكاء الاصطناعي متوفر **24 ساعة في اليوم، 7 أيام في الأسبوع، 365 يوماً في السنة** — بدون انتظار أو طوابير. ويتوفر عملاء بشريون من الاثنين للجمعة من 9 صباحاً لـ 6 مساءً. 🤖"},

        // Tech Tools
        {"Cloud Computing", "الحوسبة السحابية"},
        {"Scalable, on-demand infrastructure.", "بنية تحتية مرنة وقابلة للتوسع."},
        {"Cloud computing eliminated costly on-premise servers, reducing IT infrastructure spend by 45% and enabling instant global scalability.", "ألغت الحوسبة السحابية الحاجة للسيرفرات المحلية المكلفة، مما قلل من نفقات البنية التحتية بنسبة 45% ومكّن من التوسع العالمي الفوري."},
        {"Real-time data access from any location accelerated decision-making cycles by 60%, giving the organization a decisive edge over slower, legacy-bound competitors.", "الوصول الفوري للبيانات من أي مكان سرّع من دورات اتخاذ القرار بنسبة 60%، مما أعطى المنظمة ميزة حاسمة على المنافسين."},
        {"Artificial Intelligence", "الذكاء الاصطناعي"},
        {"Predictive analytics & smart automation.", "التحليلات التنبؤية والأتمتة الذكية."},
        {"AI-powered demand forecasting reduced inventory waste by 38% and boosted on-time deliveries to 97%, directly improving the bottom line.", "قلل التنبؤ بالطلب المدعوم بالذكاء الاصطناعي من هدر المخزون بنسبة 38% ورفع نسبة التسليم في الوقت المحدد إلى 97%."},
        {"Machine-learning recommendation engines increased average order value by 27% by surfacing hyper-personalized product suggestions at the right moment.", "زادت محركات التوصية المعتمدة على تعلم الآلة من متوسط قيمة الطلب بنسبة 27% عبر تقديم اقتراحات مخصصة في الوقت المناسب."},
        {"Robotic Process Automation", "أتمتة العمليات الروبوتية (RPA)"},
        {"End-to-end workflow automation.", "أتمتة سير العمل بالكامل."},
        {"RPA bots handle 85% of repetitive back-office tasks — invoice processing, data entry, and reconciliation — without a single human touch.", "تتولى روبوتات RPA ما يصل إلى 85% من المهام المكتبية المتكررة — كمعالجة الفواتير وإدخال البيانات — بدون أي تدخل بشري."},
        {"This freed 1,200+ employee-hours per month, which were reallocated to high-value strategic work, compressing quarterly close cycles from 10 days to 2.", "هذا وفر أكثر من 1200 ساعة عمل شهرياً، وتم إعادة توجيهها للأعمال الاستراتيجية الهامة."},
        {"Smart Payment Systems", "أنظمة الدفع الذكية"},
        {"Frictionless, secure digital transactions.", "معاملات رقمية آمنة وسلسة."},
        {"Integrating AI-fraud-detection into the payment gateway reduced chargebacks by 92% and cut false-positive declines, recovering an estimated $2.1 M annually.", "دمج كشف الاحتيال بالذكاء الاصطناعي في بوابة الدفع قلل من المرتجعات بنسبة 92% واسترد ما يقدر بـ 2.1 مليون دولار سنوياً."},
        {"One-click checkout and multi-wallet support (Apple Pay, Google Pay, BNPL) lifted cart conversion rates by 33%, directly boosting quarterly revenue.", "دعم الدفع بنقرة واحدة والمحافظ المتعددة رفع من معدلات تحويل السلة بنسبة 33% مما زاد من الإيرادات مباشرة."}
    };

    public string T(string englishText)
    {
        if (!IsArabic) return englishText;
        return _ar.TryGetValue(englishText, out var arText) ? arText : englishText;
    }
}
