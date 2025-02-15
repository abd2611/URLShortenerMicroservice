using Microsoft.AspNetCore.Routing.Constraints;
using System;
using System.Data;
using URLShortenerMicroservice.Model;
namespace URLShortnerMicroservice.Services
{
    public class URLShortenerServie : IUrlShortenerMicroservice
    {
        private const string Alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        private Random _random=new Random();
        private string shortcode= string.Empty;

        public Task<string> ShortenURL(string url)
        {
            throw new NotImplementedException();
        }
  
        public Task<string> ShortenerUrlAsync(string originalurl)
        {
            //validate
            var shortCode = GenerateShortCode();

            //generate short code
            var shortUrl = "newgen.ly" + shortcode;

            var mapping=new UrlMapping();
            mapping.shortUrl = shortUrl;
            mapping.longUrl = originalurl;
            

            throw new NotImplementedException();
        }

        private string GenerateShortCode(int length=6)
        {
            return new string(Enumerable.Repeat(Alphabet, length).Select(s => s[_random.Next(s.Length)]).ToArray());
               

            // throw new NotImplementedException();
        }
    }
}
