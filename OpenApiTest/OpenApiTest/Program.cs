using Microsoft.OpenApi;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenApiTest
{
    class Program
    {
        static void Main(string[] args)
        {
            OpenApiDocument document = new OpenApiDocument
            {
                SpecVersion = new Version(3, 0, 0)
            };
            Console.WriteLine(document.SerializeAsJson(OpenApiSpecVersion.OpenApi3_0_0));
        }
    }
}
