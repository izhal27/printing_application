using PrintingApplication.CommonComponents;
using System;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Helper
{
    public class Messages
    {
        /// <summary>
        /// Menampilkan pesan error Exception
        /// </summary>
        /// <param name="ex">Exception object</param>
        public static void Error(Exception ex)
        {
            MessageBox.Show($"Message: {ex.Message}" +
                            $"Source: {ex.Source}",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Menampilkan pesan error Exception
        /// </summary>
        /// <param name="ex">Exception object</param>
        public static void Error(ArgumentException ex)
        {
            MessageBox.Show($"Message: {ex.Message}",
                            "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Menampilkan pesan error Exception
        /// </summary>
        /// <param name="ex">DataAccessException object</param>
        public static void Error(DataAccessException ex)
        {
            MessageBox.Show($"Message: {ex.DataAccessStatusInfo.CustomMessage}\n" +
                            $"Error code: {ex.DataAccessStatusInfo.ErrorCode}\n" +
                            $"Source: {ex.Source}\n",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Menampilkan pesan error
        /// </summary>
        /// <param name="message">Message</param>
        public static void Error(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Menampilkan pesan warning
        /// </summary>
        /// <param name="message">Message</param>
        public static void Warning(string message)
        {
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Menampilkan pesan konfirmasi
        /// </summary>
        /// <param name="message">Message confirmation</param>
        /// <param name="text">Text MessageBox</param>
        /// <returns>Mengembalikan nilai true jika user memilih yes</returns>
        public static bool Confirm(string message, string text = "Confirmation")
        {
            return MessageBox.Show(message, text,
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question) == DialogResult.Yes;
        }

        /// <summary>
        /// Menampilkan pesan konfirmasi dengan icon warning
        /// </summary>
        /// <param name="message">Message confirmation</param>
        /// <returns>Mengembalikan nilai true jika user memilih yes</returns>
        public static bool ConfirmWarning(string message)
        {
            return MessageBox.Show(message, "Confirmation",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Warning) == DialogResult.Yes;
        }

        /// <summary>
        /// Menampilkan pesan informasi
        /// </summary>
        /// <param name="message">Message information</param>
        public static void Info(string message)
        {
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Menampilkan pesan informasi berhasil menambahkan data
        /// </summary>
        /// <param name="type">Type data</param>
        public static void InfoSave(string type)
        {
            Info($"Data {type} berhasil ditambahkan.");
        }

        /// <summary>
        /// Menampilkan pesan informasi berhasil mengubah data
        /// </summary>
        /// <param name="type">Type data</param>
        public static void InfoUpdate(string type)
        {
            Info($"Data {type} berhasil disimpan.");
        }

        /// <summary>
        /// Menampilkan pesan informasi berhasil menghapus data
        /// </summary>
        /// <param name="type">Type data</param>
        public static void InfoDelete(string type)
        {
            Info($"Data {type} berhasil dihapus.");
        }

        /// <summary>
        /// Menampilkan pesan konfirmasi penambahan data
        /// </summary>
        /// <param name="type">Type data</param>
        /// <returns></returns>
        public static bool ConfirmSave(string type)
        {
            return Confirm($"Anda yakin ingin menambahkan data {type}?");
        }

        /// <summary>
        /// Menampilkan pesan konfirmasi pengubahan data
        /// </summary>
        /// <param name="type">Type data</param>
        /// <returns></returns>
        public static bool ConfirmUpdate(string type)
        {
            return Confirm($"Simpan perubahan data {type}?");
        }

        /// <summary>
        /// Menampilkan pesan konfirmasi penghapusan data
        /// </summary>
        /// <param name="type">Type data</param>
        /// <returns></returns>
        public static bool ConfirmDelete(string type)
        {
            return Confirm($"Anda yakin ingin menghapus data {type} terpilih?\n\n" +
                           $"Proses ini akan menghapus semua data yang berkaitan dengan data {type} yang ingin dihapus.\n\n" +
                           "Anda tidak dapat mengembalikan data tersebut setelah proses " +
                           "penghapusan berhasil.");
        }

        /// <summary>
        /// Menammpilkan pesan ketika belum ada data yang dipilih
        /// untuk diupdate / dihapus
        /// </summary>
        /// <param name="type">Type data</param>
        public static void NotSelected(string type)
        {
            Warning($"Maaf, Anda belum memilih data {type}.");
        }

        /// <summary>
        /// Menampilkan pesan error saat menghapus data
        /// </summary>
        /// <param name="type">Type data</param>
        /// <returns></returns>
        public static void ErrorHapus(string type)
        {
            Warning($"Terjadi kesalahaan saat Menghapus data {type}.\n" +
                    "Data terpilih kemungkinan sudah digunakan untuk proses yang lain.");
        }

        /// <summary>
        /// Menampilkan pesan warning ketika ingin menghapus data yang 
        /// tidak diijinkan
        /// </summary>
        /// <param name="type">Type data</param>
        /// <param name="data">data Penting</param>
        public static void NotDelete(string type, string data)
        {
            Warning($"Maaf, Anda tidak bisa Menghapus {type} '{data}'.");
        }

        /// <summary>
        /// Menampilkan pesan warning ketika ingin mengubah data yang 
        /// tidak diijinkan
        /// </summary>
        /// <param name="data">data name</param>
        public static void NotUpdate(string data)
        {
            Warning($"Maaf, Anda tidak bisa Mengubah data '{data}'.");
        }

        /// <summary>
        /// Menampilkan pesan sukses menyimpan data default
        /// </summary>
        public static void DefaultGenericSaveSuccess()
        {
            Info("Data berhasil disimpan.");
        }

        /// <summary>
        /// Menampilkan pesan error default
        /// </summary>
        public static void DefaultGenericError()
        {
            Error("Terjadi kesalahan saat melakukan operasi.\n" +
                  "Coba kembali beberapa saat lagi.");
        }

        /// <summary>
        /// Menampilkan pesan error default bersama Error message
        /// </summary>
        public static void DefaultGenericError(string message)
        {
            Error("Terjadi kesalahan saat melakukan operasi.\n" +
                  $"Coba kembali beberapa saat lagi.\n\nError message : {message}");
        }
    }
}
