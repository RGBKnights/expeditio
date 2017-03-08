using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace Expeditio.Web.Views
{
    public abstract class ExpeditioRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected ExpeditioRazorPage()
        {
            LocalizationSourceName = ExpeditioConsts.LocalizationSourceName;
        }
    }
}
