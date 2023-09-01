using System.Net;

namespace SecondHandBass.BusinessLayer.CustomExceptions
{
    public class CustomAppException : Exception
    {
        public List<string> Messages { get; set; }
        public HttpStatusCode StatusCode { get; set; } = HttpStatusCode.BadRequest;
        public CustomAppException(string message) : base(message)
        {
            this.Messages = new List<string>()
           {
               message
           };
        }
        public CustomAppException(params string[] messages)
        {
            this.Messages = messages.ToList();

        }

    }
}
