using Microsoft.AspNetCore.Http;

namespace Ehome_BackEnd.Extensions
{
    public static class FileExtensions
    {
        public static bool IsOkay(this IFormFile file, int mb)
        {
            return file.ContentType.Contains("image") && file.Length < mb * 1024 * 1024;
        }

    }
}
