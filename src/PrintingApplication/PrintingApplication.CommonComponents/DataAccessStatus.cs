using System.Text;

namespace PrintingApplication.CommonComponents
{
    public class DataAccessStatus
    {
        public string Status { get; set; }
        public bool OperationSucceeded { get; set; }
        public string ExceptionMessage { get; set; }
        public string CustomMessage { get; set; }
        public string HelpLink { get; set; }
        public int ErrorCode { get; set; }
        public string StackTrace { get; set; }

        public void SetValues(string status, bool operationSucceeded, string exceptionMessage,
           string customMessage, string helpLink, int errorCode, string stackTrace)
        {
            Status = status ?? string.Empty;
            OperationSucceeded = operationSucceeded;
            ExceptionMessage = exceptionMessage ?? string.Empty;
            CustomMessage = customMessage ?? string.Empty;
            HelpLink = helpLink ?? string.Empty;
            ErrorCode = errorCode;
            StackTrace = stackTrace ?? string.Empty;
        }

        public string GetFormatedValues()
        {
            var strBuilder = new StringBuilder();
            strBuilder.Append($"Status: {Status}").AppendLine();
            strBuilder.Append($"Operation Succeeded: {OperationSucceeded}").AppendLine();
            strBuilder.Append($"Exception Message: {ExceptionMessage}").AppendLine();
            strBuilder.Append($"Custom Message: {CustomMessage}").AppendLine();
            strBuilder.Append($"Help Link: {HelpLink}").AppendLine();
            strBuilder.Append($"Error Code: {ErrorCode}").AppendLine();
            strBuilder.Append($"Stack Trace: {StackTrace}").AppendLine();

            return strBuilder.ToString();
        }
    }
}
