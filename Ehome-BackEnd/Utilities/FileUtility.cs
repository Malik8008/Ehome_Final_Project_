using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Ehome_BackEnd.Utilities
{
    public static class FileUtility
    {
        public static async Task<string> FileCreate(this IFormFile file,string root,string folder)
        {
            var filename = file.FileName;
            if (filename.Length>64)
            {
                filename=filename.Substring(filename.Length-64,64);
            }
            string FileName = Guid.NewGuid() + filename;
            string path = Path.Combine(root, folder);
            string FullPath = Path.Combine(path,FileName);

            using (FileStream stream = new FileStream(FullPath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            return FileName;
        }
        public static async void FileDelete(string root,string path,string ImageName)
        {
            string FullPath = Path.Combine(root, path,ImageName);
            if (File.Exists(FullPath))
            {
                File.Delete(FullPath);
            }
        }
    }
}
