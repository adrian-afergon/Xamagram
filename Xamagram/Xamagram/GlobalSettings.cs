using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamagram
{
    class GlobalSettings
    {
        //public const string AzureUrl = "http://xamagramnode02-afergon.azurewebsites.net";
        public const string AzureUrl = "http://xamagramazurebackend02afergon.azurewebsites.net";
        public const string Database = "xamagram.db";
        public static string BlobSharedKey = "DefaultEndpointsProtocol=https;AccountName=xamagramstorageafergon;AccountKey=gTlUT7Em21IvyWP3t7Hu8fomQ9WNP8jOXRuHEP0lQP7b26o0lVc9L7Fd5lgwPcE04ZTNM1j2xhoRoNSD9PhM/g==;EndpointSuffix=core.windows.net";
        public static string BlobContainerName = "images";
    }
}
