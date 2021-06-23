namespace VideoRental.API.ViewModels.Response
{
  public class Response<T>
  {
    public T Data { get; set; }
    public bool Succeeded { get; set; }
    public string Message { get; set; }

    public Response() { }

    public Response(T data)
    {
      Succeeded = true;
      Message = string.Empty;
      Data = data;
    }
  }
}
