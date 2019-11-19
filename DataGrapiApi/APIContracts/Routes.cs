using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataGrapiApi.APIContracts
{
    public static class Routes
    {
        public const string Root = "api";
        public const string Version = "v1";
        public static readonly string Base = $"{Root}/{Version}";

        public static class Sales
        {
            public static readonly string GetAll = $"{Base}/Sales";
        }
    }
}
