using GolfScore.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace GolfScore.API
{
    public abstract class BaseController : ControllerBase
    {
        private readonly int _success = 200;
        private readonly int _created = 201;
        private readonly int _updated = 204;
        private readonly int _failedValidation = 400;
        private readonly int _forbidden = 403;
        private readonly int _unexpectedError = 500;

        protected IActionResult HandleRequest(Func<object> action)
        {
            return HandleAction(() => StatusCode(_success, action.Invoke()));
        }

        protected IActionResult HandleCreate(Func<object> action)
        {
            return HandleAction(() => StatusCode(_created, action.Invoke()));
        }

        protected IActionResult HandleUpdate(Func<object> action)
        {
            return HandleAction(() => StatusCode(_updated, action.Invoke()));
        }
        protected IActionResult HandleDelete(Action action)
        {
            return HandleAction(() =>
            {
                action.Invoke();
                return StatusCode(_success);
            });
        }

        private IActionResult HandleAction(Func<IActionResult> action)
        {
            try
            {
                return action.Invoke();
            }
            catch (BadRequestException ex)
            {
                return StatusCode(_failedValidation, ex.Message);
            }
            catch (ForbiddenException ex)
            {
                return StatusCode(_forbidden, ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(_unexpectedError, ex.Message);
            }
        }
    }
}
