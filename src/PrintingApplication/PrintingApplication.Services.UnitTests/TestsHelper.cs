using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PrintingApplication.CommonComponents;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace PrintingApplication.Services.UnitTests.CommonTests
{
    public static class TestsHelper
    {
        public static void WriteExceptionTestResult(Exception exception, ITestOutputHelper testOutputHelper, object model)
        {
            if (exception != null)
            {
                testOutputHelper.WriteLine(exception.Message);
            }
            else
            {
                var strBuilder = new StringBuilder();
                var json = JObject.FromObject(model);
                strBuilder.Append("********** No exceptions occurred *********").AppendLine();

                foreach (var jProp in json.Properties())
                {
                    strBuilder.Append(jProp.Name).Append(" ---> ").Append(jProp.Value).AppendLine();
                }

                testOutputHelper.WriteLine(strBuilder.ToString());
            }
        }

        public static void WriteModel(ITestOutputHelper testOutputHelper, object model)
        {
            var strBuilder = new StringBuilder();
            strBuilder.Append("********** Data of Model *********").AppendLine();

            var modelJsonStr = JsonConvert.SerializeObject(model);
            var formattedJsonStr = JToken.Parse(modelJsonStr).ToString();

            strBuilder.Append(formattedJsonStr).AppendLine();

            testOutputHelper.WriteLine(strBuilder.ToString());
        }

        public static void WriteListModels<T>(ITestOutputHelper testOutputHelper, List<T> listModels)
        {
            var strBuilder = new StringBuilder();
            strBuilder.Append("********** List of Models *********");
            testOutputHelper.WriteLine(strBuilder.ToString());

            foreach (var model in listModels)
            {
                strBuilder = new StringBuilder();
                var json = JObject.FromObject(model);

                foreach (var jProp in json.Properties())
                {
                    strBuilder.Append(jProp.Name).Append(" ---> ").Append(jProp.Value).AppendLine();
                }

                testOutputHelper.WriteLine(strBuilder.ToString());
            }
        }

        public static string DataAccessStatusInfoToJson(DataAccessException ex)
        {
            var dataAccessJsonStr = string.Empty;
            var formattedJsonStr = string.Empty;

            dataAccessJsonStr = JsonConvert.SerializeObject(ex.DataAccessStatusInfo);
            formattedJsonStr = JToken.Parse(dataAccessJsonStr).ToString();

            return formattedJsonStr;
        }

        public static void IsError(DataAccessException ex)
        {
            Assert.True(ex?.DataAccessStatusInfo.Status == "Error");
        }
    }
}
