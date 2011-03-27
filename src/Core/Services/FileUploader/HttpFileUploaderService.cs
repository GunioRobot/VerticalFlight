using System;
using System.Web;
using System.IO;


namespace VerticalFlight.Core.Services.FileUploader
{
    public class HttpFileUploaderService : FileUploaderService
    {
        public string UploadFile(HttpPostedFileBase file, string targetFolder)
        {
            string result = "";
            if (file.ContentLength > 0)
            {
                try
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var path = Path.Combine(targetFolder, fileName);
                    file.SaveAs(path);
                    result = "File Uploaded Successfully.";
                }
                catch (Exception ex)
                {
                    result = "Upload failed. " + ex.Message;
                }
            }
            else
            {
                result = "Empty file.  Upload failed.";
            }
            return result;

        }   
    }
}
