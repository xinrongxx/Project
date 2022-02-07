using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grooviee.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string BusesEndpoint = $"{Prefix}/buses";
        public static readonly string FeedbacksEndpoint = $"{Prefix}/feedbacks";
        public static readonly string AccountsEndpoint = $"{Prefix}/accounts";
    }

}