using System;
namespace URLShortnerMicroservice.Services
{
    public class URLShortenerServie: IUrlShortenerMicroservice
    {
        public Task<string> ShortenURL(string url)
        {
            throw new NotImplementedException();
        }
    }

    public interface IUrlShortenerMicroservice
    {
    }
}
