using System.Threading.Tasks;
using Kalan.Lib.Utils.Core.Result;
using Kalan.Module.Admin.Domain.Button;
using Kalan.Module.Admin.Domain.Button.Models;

namespace Kalan.Module.Admin.Application.ButtonService
{
    public class ButtonService : IButtonService
    {
        private readonly IButtonRepository _buttonRepository;

        public ButtonService(IButtonRepository buttonRepository)
        {
            _buttonRepository = buttonRepository;
        }

        public async Task<IResultModel> Query(ButtonQueryModel model)
        {
            var result = new QueryResultModel<ButtonEntity>
            {
                Rows = await _buttonRepository.Query(model),
                Total = model.TotalCount
            };

            return ResultModel.Success(result);
        }
    }
}
