using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //  Estimate();

            AutoGen();
        }

        private static void AutoGen()
        {
            HashSet<string> controllers = new HashSet<string>();

            controllers.Add("BookManagement");
            controllers.Add("Admin");
            controllers.Add("CategoryManagement");
            controllers.Add("BookAuthorManagement");
            controllers.Add("PublishingHouseManagement");
            controllers.Add("ImageManagement");
            controllers.Add("BookStateManagement");
            controllers.Add("RoleManagement");
            controllers.Add("Account");
            controllers.Add("Book");
            controllers.Add("Cart");
            controllers.Add("Home");

            string[] lines = File.ReadAllLines("Controllers_Actions.txt", Encoding.UTF8);
            string controllerContent = File.ReadAllText("Controller.txt", Encoding.UTF8);
            string viewContent = File.ReadAllText("View.txt", Encoding.UTF8);

            string path = string.Empty;

            //Tạo Controller
            //path = @"D:\AspNetEbook\aspnet-ebooks\WebBanSach\Controllers\";
            //foreach (var controller in controllers)
            //{
            //    try
            //    {
            //        string newPath = $@"{path}\{controller}Controller.cs";
            //        string newContent = controllerContent.Replace("###Controller_Name###", controller);
            //        File.WriteAllText(newPath, newContent, Encoding.UTF8);
            //    }
            //    catch (Exception ex)
            //    {
            //        Debug.WriteLine(ex);
            //        //throw;
            //    }
            //}

            //Tạo View
            //path = @"D:\AspNetEbook\aspnet-ebooks\WebBanSach\Views\";
            //foreach (var controller in controllers)
            //{
            //    try
            //    {
            //        string newPath = $@"{path}\{controller}\";
            //        if (!Directory.Exists(newPath))
            //        {
            //            Directory.CreateDirectory(newPath);
            //        }

            //        foreach (var line in lines)
            //        {
            //            var contrl = line.Split(new char[] { '_' }, StringSplitOptions.None)[0];
            //            var view = line.Split(new char[] { '_' }, StringSplitOptions.None)[1];

            //            if (controller == contrl)
            //            {
            //                var filePath = $@"{newPath}\{view}.cshtml";
            //                if (!File.Exists(filePath))
            //                {
            //                    File.WriteAllText(filePath, viewContent, Encoding.UTF8);
            //                }
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Debug.WriteLine(ex);
            //        //throw;
            //    }
            //}

            //Gắn link vào layout
            string fileLayout = @"D:\AspNetEbook\aspnet-ebooks\WebBanSach\Views\Shared\_Layout.cshtml";

            string contentLayout = File.ReadAllText(fileLayout, Encoding.UTF8);
            string str = BuildLink(lines, controllers);
            string newContentLayout = contentLayout.Replace("###abc###", str);
            File.WriteAllText(fileLayout, newContentLayout, Encoding.UTF8);
        }

        private static string BuildLink(string[] lines, HashSet<string> controllers)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var controller in controllers)
            {
                try
                {
                    foreach (var line in lines)
                    {
                        var contrl = line.Split(new char[] { '_' }, StringSplitOptions.None)[0];
                        var view = line.Split(new char[] { '_' }, StringSplitOptions.None)[1];

                        sb.AppendLine($"<li>@Html.ActionLink(\"{view}\", \"{view}\", \"{contrl}\")</li>");
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                    //throw;
                }
            }

            return sb.ToString();
        }

        private static void Estimate()
        {
            var allLines = new List<string>();

            //Đường dẫn 1 folder
            string folder = @"D:\AspNetEbook\aspnet-ebooks\";

            //Lấy tất cả các tệp có đuôi .cshtml trong folder đấy
            List<string> files = (from x in new DirectoryInfo(folder).GetFiles("*.cshtml", SearchOption.AllDirectories) select x.FullName).ToList();

            //Duyệt từng file
            foreach (var file in files)
            {
                //Đọc tất cả dòng vào biến lines
                var lines = File.ReadAllLines(file, Encoding.UTF8).ToList();

                //Duyệt từng dòng
                foreach (var line in lines)
                {
                    //Nếu dòng có chứa từ href= thì lưu lại
                    if (line.Contains("href="))
                    {
                        //Lấy giá trị sau href= (chỉ lấy link)
                        var arr = line.Split(new string[] { "href=" }, StringSplitOptions.RemoveEmptyEntries);

                        //Đưa giá trị sau href= vào biến tổng allLines
                        allLines.Add(arr[1]);
                    }
                }
            }

            //Ghi ra tệp Output.txt để xem lại
            File.WriteAllLines("Output.txt", allLines, Encoding.UTF8);

            //Mở tệp Output.txt để xem kết quả
            Process.Start(@"C:\Program Files\Notepad++\notepad++.exe", "Output.txt");

            Console.Write("Done. Press any key to exit...");
            Console.ReadKey();
        }
    }
}