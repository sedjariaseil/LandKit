using Microsoft.AspNetCore.Identity;

//———————————— Entity: User ————————————
// كيمثل المستخدم فـLandKit، ويمكن يكون Seller أو Buyer أو Admin.
namespace LandKit.Core.Entities
{
    public class User : IdentityUser<Guid>
    {
        //———————————— اسم العرض ————————————
        // الاسم اللي غادي يبان فـProfile ديال المستخدم.
        public string DisplayName { get; set; } = string.Empty;

        //———————————— Landing Pages ————————————
        // User واحد يقدر يكون عندو بزاف ديال Landing Pages.
        public ICollection<LandingPage> LandingPages { get; set; } = new List<LandingPage>();
    }
}
