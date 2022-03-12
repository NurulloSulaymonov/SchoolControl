using System.Net;
using System.Security.Principal;
namespace Domain
{
    public class GenericResponse<T> 
    {
        public int Code { get; set; }
        public string Version { get => "1.0.0"; set { } }
        public T Payload { get; set; }
        public string Message { get; set; }
        public GenericResponse(HttpStatusCode code, T content, string version = null)
        {
            Code = (int)code;
            Payload = content;
            Version = version;
        }

        public GenericResponse(HttpStatusCode code, string message = null)
        {
            Code = (int)code;
            Message = message;
        }
        public GenericResponse()
        {

        }
    }
}