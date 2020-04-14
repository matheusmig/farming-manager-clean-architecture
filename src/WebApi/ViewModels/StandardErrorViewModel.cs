namespace WebApi.ViewModels
{
    public class StandardErrorViewModel
    {
        public string Message { get; set; }
        public int Code { get; set; } = 0;
        public object Data { get; set; } = null;
    }
}
