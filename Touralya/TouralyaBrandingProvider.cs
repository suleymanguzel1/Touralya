using Microsoft.Extensions.Localization;
using Touralya.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Touralya;

[Dependency(ReplaceServices = true)]
public class TouralyaBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<TouralyaResource> _localizer;

    public TouralyaBrandingProvider(IStringLocalizer<TouralyaResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}