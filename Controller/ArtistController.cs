using KpopZtations.Handler;
using KpopZtations.Model;
using System;
using System.IO;
using System.Web;
using System.Web.UI.WebControls;

namespace KpopZtations.Controller
{
    public class ArtistController
    {
        private ArtistHandler ah = new ArtistHandler();

        public String checkArtist(String name)
        {
            String errorMsg = null;
            if (name.Length == 0)
            {
                errorMsg = "Artist name must be filled!";
            }
            if (ah.getUniqueName(name) != null)
            {
                errorMsg = "Artist already exist!";
            }
            return errorMsg;
        }

        public String checkImage(FileUpload image)
        {
            String errorMsg = null;
            if (image.HasFile)
            {
                string fileExtension = Path.GetExtension(image.FileName).ToLower();
                System.Diagnostics.Debug.WriteLine(fileExtension);

                if (fileExtension == ".png" || fileExtension == ".jpg" || fileExtension == ".jpeg" || fileExtension == ".jfif")
                {
                    if (!(image.FileBytes.Length < 2 * (1024 * 1024)))
                    {
                        errorMsg = "File size must be lower than 2MB!";
                    }
                }
                else
                {
                    errorMsg = "File type must be .png, .jpg, .jpeg, or .jfif!";
                }
            }
            else
            {
                errorMsg = "File must be uploaded!";
            }

            return errorMsg;
        }

        public String doInsert(String name, FileUpload image)
        {
            String errorMsg = checkArtist(name);

            if (errorMsg == null)
            {
                errorMsg = checkImage(image);
            }
            if (errorMsg == null)
            {
                errorMsg = null;
                String fileExtension = Path.GetExtension(image.FileName).ToLower();
                String fileImage = name + fileExtension;

                String filePath = HttpContext.Current.Server.MapPath("../Storage/Artists/") + fileImage;

                image.SaveAs(filePath);
                ah.addArtist(name, fileImage);
            }
            return errorMsg;
        }

        public String doUpdate(int artistId, String name, FileUpload image)
        {
            String errorMsg = checkArtist(name);

            if (errorMsg == null)
            {
                errorMsg = checkImage(image);
            }
            if (errorMsg == null)
            {
                errorMsg = null;

                Artist a = ah.getArtist(artistId);

                String oldFilePath = HttpContext.Current.Server.MapPath("../Storage/Artists/") + a.ArtistImage;

                File.Delete(oldFilePath);

                String fileExtension = Path.GetExtension(image.FileName).ToLower();
                String fileImage = name + fileExtension;

                String filePath = HttpContext.Current.Server.MapPath("../Storage/Artists/") + fileImage;

                image.SaveAs(filePath);
                ah.update(artistId, name, fileImage);
            }
            return errorMsg;
        }

        public void doDelete(int artistId)
        {
            Artist a = ah.getArtist(artistId);

            String oldFilePath = HttpContext.Current.Server.MapPath("../Storage/Artists/") + a.ArtistImage;

            File.Delete(oldFilePath);

            ah.delete(artistId);
        }
    }
}