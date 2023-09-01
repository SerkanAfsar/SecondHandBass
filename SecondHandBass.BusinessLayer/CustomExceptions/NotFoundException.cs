using System.Net;

namespace SecondHandBass.BusinessLayer.CustomExceptions
{
    public class NotFoundException : Exception
    {
        public List<string> Messages { get; set; }
        public HttpStatusCode StatusCode { get; set; } = HttpStatusCode.NotFound;
        public NotFoundException(string message) : base(message)
        {

            this.Messages = new List<string>()
            {
                message
            };
        }
        public NotFoundException(params string[] messages)
        {
            this.Messages = messages.ToList();
        }
    }
}
