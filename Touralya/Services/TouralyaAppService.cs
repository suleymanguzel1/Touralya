using Volo.Abp.Application.Services;
using Touralya.Localization;

namespace Touralya.Services;

/* Inherit your application services from this class. */
public abstract class TouralyaAppService : ApplicationService
{
    protected TouralyaAppService()
    {
        LocalizationResource = typeof(TouralyaResource);
    }
}