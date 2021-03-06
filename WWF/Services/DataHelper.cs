﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WWF.Models;
using Microsoft.EntityFrameworkCore;
using System.Net.Mail;
using Renci.SshNet;
using System.Drawing;
using System.Drawing.Imaging;

namespace WWF.Services
{
    public static class DataHelper
    {
        /// <summary>
        /// Creates a comma delimeted string of all the objects property values names.
        /// </summary>
        /// <param name="obj">object.</param>
        /// <returns>string.</returns>
        public static string EFListToCSV(List<FormData> list)
        {
            var sb = new StringBuilder();

            //sb.AppendFormat("{0},{1},{2},{3},{4},{5},{6},{7}", "Contact Number", "Title", "Forenames", "Initials", "Surname", "Honorifics", "Birthdate", "Signature", Environment.NewLine);

            FormData exampleForm = list[0];
            PropertyInfo[] properties = exampleForm.GetType().GetProperties();
            foreach (PropertyInfo prop in properties)
            {
                sb.Append(prop.Name);
                sb.Append(',');
            }
            sb.Append(Environment.NewLine);

            foreach (var form in list)
            {
                // for each attribute in form
                foreach(PropertyInfo prop in properties)
                {
                    sb.Append(prop.GetValue(form));
                    sb.Append(',');
                    
                }
                sb.Append(Environment.NewLine);
                //sb.AppendFormat("{0},{1},{2},{3},{4},{5},{6},{7}", item.ContactNumber, item.Title, item.Forenames, item.Initials, item.Surname, item.Honorifics, item.BirthDate.ToShortDateString(), item.Signature, Environment.NewLine);
            }

            return sb.ToString();
        }

        public static void UploadSFTPFile(string filePath)
        {
            FileInfo f = new FileInfo(filePath);
            string uploadFile = f.FullName;

            using (var sftp = new SftpClient("127.0.0.1", "jonny", "1Parallel!"))
            {
                sftp.Connect();
                if (sftp.IsConnected)
                {
                    var fileStream = new FileStream(uploadFile, FileMode.Open);
                    if (fileStream != null)
                    {
                        sftp.UploadFile(fileStream, "/for_import/" + f.Name, null);
                        sftp.Disconnect();
                        sftp.Dispose();
                    }
                }
            }
        }

        public static string SaveSignature(int id, string signatureBase64)
        {
            // save signature
            string filename = id + "_signature.png";
            string saveDir = "Storage\\csvFiles" + filename;
            string base64 = signatureBase64.Split(',')[1];
            byte[] bytes = Convert.FromBase64String(base64);
            using (Image image = Image.FromStream(new MemoryStream(bytes)))
            {
                image.Save(saveDir, ImageFormat.Jpeg);  // Or Png
            }
            return saveDir;
        }
    }
}
