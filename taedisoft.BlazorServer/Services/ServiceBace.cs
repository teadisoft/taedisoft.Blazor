namespace taedisoft.BlazorServer.Services
{
    public class ServiceBace
    {
        public HttpClient httpClient;

        public ServiceBace()
        {
            if(httpClient == null)
                httpClient = new HttpClient();

            httpClient.BaseAddress = new Uri("http://localhost:5001");

            // https://stackoverflow.com/questions/64610237/net-5-0-cannot-determine-the-frame-size-or-a-corrupted-frame-was-received
        }

        public enum DefaultRoute
        { 
            Api,
            ProductApi
        }
    }
}
