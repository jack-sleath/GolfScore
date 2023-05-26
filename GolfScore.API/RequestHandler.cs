using Microsoft.AspNetCore.Mvc;
using GolfScore.Exceptions;

namespace GolfScore.API
{
    public abstract class BaseController : ControllerBase
    {
        protected IActionResult HandleRequest(Func<object> action)
        {
            try
            {
                var result = action.Invoke();
                return StatusCode(ResultStatus.Success, result);
            }
            catch (BadRequestException ex)
            {
                return StatusCode(ResultStatus.FailedValidation, ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(ResultStatus.UnexpectedError, ex.Message);
            }
        }
    }
}
