using System;
using System.Collections.Generic;

//———————————— Entity: LandingPage ————————————
// كيمثل Landing Page / Template معروض للبيع فـLandKit.
namespace LandKit.Core.Entities
{
    public class LandingPage
    {
        //———————————— المعرف ————————————
        // معرف فريد لكل Landing Page.
        public Guid Id { get; set; }

        //———————————— العنوان ————————————
        // الاسم اللي غادي يبان للمستخدمين.
        public string Title { get; set; } = string.Empty;

        //———————————— الوصف ————————————
        // وصف مختصر للـLanding Page.
        public string Description { get; set; } = string.Empty;

        //———————————— السعر ————————————
        // ثمن الـLanding Page بالدولار.
        // الحد الأقصى غادي يكون $10.
        public decimal Price { get; set; }

        //———————————— الصور ————————————
        // روابط Screenshots ديال الـPreview.
        public List<string> PreviewImages { get; set; } = new();

        //———————————— المعاينة المباشرة ————————————
        // رابط Live Demo إلا كان متوفر.
        public string? LivePreviewUrl { get; set; }

        //———————————— ملف التحميل ————————————
        // الرابط ديال ملف الـLanding Page بعد الشراء.
        public string? DownloadUrl { get; set; }

        //———————————— المالك ————————————
        // معرف البائع اللي رفع الـLanding Page.
        public Guid SellerId { get; set; }

        //———————————— تاريخ الإنشاء ————————————
        // الوقت اللي ترفعات فيه الـLanding Page.
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        //———————————— حالة النشر ————————————
        // واش الـLanding Page منشورة ولا لا.
        public bool IsPublished { get; set; }
    }
}
