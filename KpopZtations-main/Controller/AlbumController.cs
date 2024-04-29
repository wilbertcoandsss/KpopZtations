using KpopZtations.Model;
using KpopZtations.Handler;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace KpopZtations.Controller
{
    public class AlbumController
    {
        AlbumHandler ah = new AlbumHandler();

        public String checkName(String name)
        {
            String errorMsg = null;
            if (name.Length == 0)
            {
                errorMsg = "Album Name must be filled!";
            }
            else if (name.Length > 50)
            {
                errorMsg = "Album Name length must be less than 50 characters!";
            }
            return errorMsg;
        }

        public String checkDesc(String desc)
        {
            String errorMsg = null;

            if (desc.Length == 0)
            {
                errorMsg = "Album Description must be filled!";
            }
            else if (desc.Length > 255)
            {
                errorMsg = "Album Description must be less than 255 characters";
            }
            return errorMsg;
        }

        public String checkPrice(int price)
        {
            String errorMsg = null;
            if (price == -1)
            {
                errorMsg = "Album Price must be filled!";
            }
            else if (price < 100000 || price > 1000000)
            {
                errorMsg = "Album Price must be between 100000 and 1000000";
            }
            return errorMsg;
        }
        public String checkStock(int stock)
        {
            String errorMsg = null;
            String stockStart = stock.ToString();
            if (stockStart == null)
            {
                errorMsg = "Album Stock must be filled!";
            }
            else if (stock < 0)
            {
                errorMsg = "Album Stock must be more than 0";
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

        public String doInsert(String name, String description, int price, int stock, FileUpload image, int artistId)
        {
            String errorMsg = checkName(name);
            if (errorMsg == null)
            {
                errorMsg = checkDesc(description);
            }
            if (errorMsg == null)
            {
                errorMsg = checkPrice(price);
            }
            if (errorMsg == null)
            {
                errorMsg = checkStock(stock);
            }
            if (errorMsg == null)
            {
                errorMsg = checkImage(image);
            }
            if (errorMsg == null)
            {
                errorMsg = null;
                String fileExtension = Path.GetExtension(image.FileName).ToLower();
                String fileImage = name + fileExtension;

                String filePath = HttpContext.Current.Server.MapPath("../Storage/Albums/") + fileImage;

                image.SaveAs(filePath);

                ah.addAlbum(artistId, name, fileImage, price, stock, description);
            }
            return errorMsg;
        }

        public String doUpdate(String name, String description, int price, int stock, FileUpload image, int artistId, int albumId)
        {
            String errorMsg = checkName(name);
            if (errorMsg == null)
            {
                errorMsg = checkDesc(description);
            }
            if (errorMsg == null)
            {
                errorMsg = checkPrice(price);
            }
            if (errorMsg == null)
            {
                errorMsg = checkStock(stock);
            }
            if (errorMsg == null)
            {
                errorMsg = checkImage(image);
            }
            if (errorMsg == null)
            {
                errorMsg = null;

                Album a = ah.searchAlbum(albumId);

                String oldFilePath = HttpContext.Current.Server.MapPath("../Storage/Albums/") + a.AlbumImage;

                File.Delete(oldFilePath);

                String fileExtension = Path.GetExtension(image.FileName).ToLower();
                String fileImage = name + fileExtension;

                String filePath = HttpContext.Current.Server.MapPath("../Storage/Albums/") + fileImage;

                image.SaveAs(filePath);

                ah.updateAlbum(artistId, name, fileImage, price, stock, description, albumId);
            }
            return errorMsg;
        }

        public void doDelete(int albumId)
        {
            Album a = ah.searchAlbum(albumId);

            String oldFilePath = HttpContext.Current.Server.MapPath("../Storage/Albums/") + a.AlbumImage;

            File.Delete(oldFilePath);

            ah.deleteAlbum(albumId);
        }

    }
}