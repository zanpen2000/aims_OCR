using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCRHelper
{
    public class OCRHelper
    {

        public event EventHandler<OCRProcessingEventArgs> OnOCRCompleted = delegate { };
        public event EventHandler<OCRProcessingEventArgs> OnOCRProcessing = delegate { };

        private string toolpath;

        public string ToolPath
        {
            get { return toolpath; }
            set { toolpath = value; }
        }


        public OCRHelper()
        {

        }

        public void Go(string imgid, string picpath)
        {
            string prompt = picpath;
            if (!System.IO.File.Exists(picpath))
            {
                prompt = "图片不存在";
                OnOCRProcessing(this, new OCRProcessingEventArgs(imgid, prompt));
                return;
            }

            if (string.IsNullOrEmpty(toolpath) || !System.IO.File.Exists(toolpath))
                toolpath = @"C:\Program Files (x86)\Tesseract-OCR\tesseract.exe";
            if (string.IsNullOrEmpty(toolpath) || !System.IO.File.Exists(toolpath))
                throw new InvalidOperationException("tesseract not found");

            string outfile = @"c:\ocresult"; // 路径中不要有空格

            //string outfile = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "ocr_result");

            if (System.IO.File.Exists(outfile + ".txt")) System.IO.File.Delete(outfile + ".txt");

            using (System.Diagnostics.Process proc = new System.Diagnostics.Process())
            {
                proc.StartInfo.FileName = toolpath;
                proc.StartInfo.Arguments = picpath + " " + outfile + " -l chi_sim";
                proc.StartInfo.WorkingDirectory = System.AppDomain.CurrentDomain.BaseDirectory;
                proc.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                proc.EnableRaisingEvents = true;
                proc.Start();
                proc.WaitForExit();
                proc.Close();
                proc.Dispose();

                if (System.IO.File.Exists(outfile + ".txt"))
                {
                    string text = System.IO.File.ReadAllText(outfile + ".txt");
                    if (OnOCRCompleted != null)
                    {
                        OnOCRCompleted(this, new OCRProcessingEventArgs(imgid, text));
                    }

                    prompt = string.IsNullOrEmpty(text) ? "识别结果为空" : picpath;
                }


                OnOCRProcessing(this, new OCRProcessingEventArgs(imgid, prompt));
            }
        }

        public static string Execute(string picpath, string toolpath = "")
        {
            if (!System.IO.File.Exists(picpath)) return string.Empty;
            else
            {
                if (string.IsNullOrEmpty(toolpath) || !System.IO.File.Exists(toolpath))
                    toolpath = @"C:\Program Files (x86)\Tesseract-OCR\tesseract.exe";

                if (string.IsNullOrEmpty(toolpath) || !System.IO.File.Exists(toolpath))
                    throw new InvalidOperationException("tesseract not found");

                string outfile = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "ocr_result.txt");

                using (System.Diagnostics.Process proc = new System.Diagnostics.Process())
                {
                    proc.StartInfo.FileName = toolpath;
                    proc.StartInfo.Arguments = picpath + " " + outfile + " -l chi_sim";
                    proc.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    proc.Start();
                    proc.WaitForExit();

                    if (System.IO.File.Exists(outfile + ".txt"))
                    {
                        return System.IO.File.ReadAllText(outfile + ".txt");
                    }

                }
            }
            return string.Empty;
        }
    }
}
