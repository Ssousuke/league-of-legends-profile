namespace LOLProfile.API.ZED.HttpService
{
    public interface IRiotHttpService
    {
        Task<HttpResponseMessage> SendAsync(HttpRequestMessage request);
    }
}
