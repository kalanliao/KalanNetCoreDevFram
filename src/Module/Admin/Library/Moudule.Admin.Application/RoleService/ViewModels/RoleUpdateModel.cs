using System;
using System.ComponentModel.DataAnnotations;

namespace Kalan.Module.Admin.Application.RoleService.ViewModels
{
    public class RoleUpdateModel : RoleAddModel
    {
        [Required(ErrorMessage = "请选择角色")]
        public Guid Id { get; set; }
    }
}
