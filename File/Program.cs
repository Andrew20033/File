using FastSearchLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

namespace File
{
    class Program
    {
        private void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                string[] files = Directory.GetFiles(path: @"C:\Windows\", searchPattern: "*.jpg", searchOption: SearchOption.AllDirectories);
                NewMethod(files: files);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message + "" + ex.Source);

            }

        }
    }
}