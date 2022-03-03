using System;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Helper
{
    public class WaitCursorHandler : IDisposable
    {
        private Cursor _oldCursor;

        /// <summary>
        /// Ketika diinisialisai ambil cursor sekarang
        /// lalu buat cursor menjadi wait (lingkaran)
        /// </summary>
        public WaitCursorHandler()
        {
            _oldCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
        }

        public void Dispose()
        {
            if (_oldCursor != Cursor.Current)
            {
                // Kembalikan cursor menjadi sebelumnya
                Cursor.Current = _oldCursor;
            }
        }
    }
}
