using System.Collections.Generic;
using Kalan.Module.Admin.Domain.Permission;

namespace Kalan.Module.Admin.Application.SystemService.ViewModels
{
    public class SystemInstallModel
    {
        public List<PermissionEntity> Permissions { get; set; }
    }
}
