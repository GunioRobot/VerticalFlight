using System.Web;

namespace VerticalFlight.Core.Services.FileUploader
{
    public interface FileUploaderService 
    {
        string UploadFile(HttpPostedFileBase file, string targetFolder);
    }
}
