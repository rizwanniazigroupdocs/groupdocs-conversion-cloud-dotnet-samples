﻿using System;
using GroupDocs.Conversion.Cloud.Sdk.Api;
using GroupDocs.Conversion.Cloud.Sdk.Client;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Conversion.Cloud.Examples.CSharp
{
    // Get All Supported Formats For Provided Extension
    class Get_All_Possible_Conversions_For_Extension
    {
        public static void Run()
        {
            var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);

            var apiInstance = new InfoApi(configuration);

            try
            {
                // Get supported file formats
                var response = apiInstance.GetSupportedConversionTypes(new GetSupportedConversionTypesRequest(null, null, "xlsx"));

                foreach (var entry in response)
                {
                    foreach (var formats in entry.TargetFormats)
                    {
                        Console.WriteLine(string.Format("{0} TO {1}", entry.SourceFormat, string.Join(",", formats)));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception while calling InfoApi: " + e.Message);
            }
        }
    }
}