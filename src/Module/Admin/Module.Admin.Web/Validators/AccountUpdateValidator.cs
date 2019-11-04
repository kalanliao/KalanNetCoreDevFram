using FluentValidation;
using Kalan.Lib.Utils.Core.Extensions;
using Kalan.Module.Admin.Application.AccountService.ViewModels;

namespace Kalan.Module.Admin.Web.Validators
{
    public class AccountUpdateValidator : AbstractValidator<AccountUpdateModel>
    {
        public AccountUpdateValidator()
        {
            RuleFor(x => x.Email).EmailAddress().When(x => x.Email.NotNull()).WithMessage("请输入正确的邮箱地址");
        }
    }
}
