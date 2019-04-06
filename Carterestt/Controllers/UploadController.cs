using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Carterestt.Controllers
{   /// <summary>
    /// Този клас добавлява картинки към постове
    /// </summary>
    /// <remarks>
    ///     Автор: Кирилл Алексеев
    /// </remarks>
    public class UploadController : Controller
    {
        [HttpGet]
        public string Index()
        {
            this.HttpContext.Response.StatusCode = 418; // I'm a teapot
            return "I'm a teapot";
        }

        private static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        [HttpPost]
        public string Index(HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {
                //todo: validate if the file is image
                try
                {
                    var originalFileName = file.FileName;
                    var extension = file.FileName.Substring(file.FileName.LastIndexOf(".") + 1); //get extension
                    var newFileName = CreateMD5(file.FileName) + "." + extension;
                    string path = Path.Combine(
                        Server.MapPath("~/Images"),
                        newFileName
                    );
                    file.SaveAs(path);

                    return "{\"status\":\"Success\", \"fileName\": \"" + newFileName + "\"}";
                }
                catch (Exception ex)
                {
                    return "{\"status\":\"Error: " + ex.Message + "\"}";
                }
            }
            else
            {
                return "{\"status\":\"Error\", \"message\": Please provide files.\"}";
            }
        }
    }
}