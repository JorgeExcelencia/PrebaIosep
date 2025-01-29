namespace ApiIosep.Models.DTOs
{
    public class Response<T>
    {
        public Response()
        {
            
        }

        public Response(T data, string message = null)
        {
            Error = false;
            Message = message;
            Data = data;
        }

        public Response(string message = null)
        {
            Error = true;
            Message = message;
        }
        public bool Error { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }
}
