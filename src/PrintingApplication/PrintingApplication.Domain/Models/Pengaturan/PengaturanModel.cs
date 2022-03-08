﻿using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace PrintingApplication.Domain.Models.Pengaturan
{
    public class PengaturanModel : IPengaturanModel
    {
        public uint id { get; set; }

        public string nama { get; set; }

        public string alamat_1 { get; set; }

        public string alamat_2 { get; set; }

        public string contact { get; set; }

        public TipePrinter tipe_printer { get; set; }

        public string printer_tipe { get; set; }

        public string printer_name { get; set; }

        public string path_background { get; set; }
    }

    public class FileNameImagesEditor : FileNameEditor
    {
        protected override void InitializeDialog(OpenFileDialog openFileDialog)
        {
            base.InitializeDialog(openFileDialog);
            openFileDialog.Filter = "JPG Files (*.jpg)|*.jpg|JPEG Files (*.jpeg)|*.jpeg|" +
                                    "PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All Files (*.*)|*.*";
        }
    }
}
