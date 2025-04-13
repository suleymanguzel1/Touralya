using Touralya.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Touralya.Permissions;

public class TouralyaPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(TouralyaPermissions.GroupName);

        
        //Define your own permissions here. Example:
        //myGroup.AddPermission(TouralyaPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<TouralyaResource>(name);
    }
}
