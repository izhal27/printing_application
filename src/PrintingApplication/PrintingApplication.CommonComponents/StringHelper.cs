using System.Text;

namespace PrintingApplication.CommonComponents
{
    public static class StringHelper
    {
        public static string DuplicateEntry(string key, string modelName)
        {
            return $"{key.FirstToUpper()} {modelName} sudah ada, " +
                   $"silahkan ganti dengan {key} {modelName} yang lain.";
        }

        public static string ErrorDeleteForeignKey(string modelName)
        {
            return $"Terjadi kesalahan saat menghapus data {modelName.FirstToUpper()}. " +
                    "Kemungkinan data sedang digunakan oleh data yang lain";
        }

        public static string GetStringByLength(int length)
        {
            var strBuild = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                strBuild.Append("a");
            }

            return strBuild.ToString();
        }

        public static string QueryStringByDate(string table, string column = "tanggal", string paramName = "date")
        {
            return $"SELECT * FROM {table} WHERE DATE({column}) = @{paramName}";
        }

        public static string QueryStringByBetweenDate(string table, string column = "tanggal",
                                                      string startParamName = "startDate", string endParamName = "endDate")
        {
            return $"SELECT * FROM {table} WHERE DATE({column}) >= @{startParamName} AND DATE({column}) <= @{endParamName}";
        }
    }
}
