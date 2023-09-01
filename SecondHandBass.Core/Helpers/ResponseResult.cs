using System.Net;

namespace SecondHandBass.Core.Helpers
{
    public class ResponseResult<T> where T : class
    {
        public bool IsSuccess { get; set; } = true;
        public List<string> Errors { get; set; } = new List<string>();
        public T? Entity { get; set; } = null;
        public List<T> Entities { get; set; } = new List<T>();
        public HttpStatusCode StatusCode { get; set; } = HttpStatusCode.OK;
    }
}
