using SecondHandBass.BusinessLayer.CustomExceptions;
using SecondHandBass.Core.Helpers;

namespace SecondHandBass.WebService.Middlewares
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ResponseResult<string> _responseResult;
        public ExceptionMiddleware(RequestDelegate _next)
        {
            this._next = _next;
            this._responseResult = new ResponseResult<string>();
        }
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await this._next(context);
            }
            catch (Exception ex)
            {
                var response = context.Response;
                response.ContentType = "application/json; charset=utf-8";
                this._responseResult.IsSuccess = false;

                if (ex is not null)
                {
                    switch (ex)
                    {
                        case CustomAppException:
                        default:
                            {
                                var newEx = (CustomAppException)ex;
                                this._responseResult.Errors = newEx.Messages;
                                this._responseResult.StatusCode = newEx.StatusCode;
                                break;
                            }
                        case NotFoundException:
                            {
                                var newEx = (NotFoundException)ex;
                                this._responseResult.Errors = newEx.Messages;
                                this._responseResult.StatusCode = newEx.StatusCode;
                                break;
                            }
                    }
                    response.StatusCode = (int)this._responseResult.StatusCode;
                    await response.WriteAsJsonAsync(this._responseResult);
                }
            }
        }
    }
}
