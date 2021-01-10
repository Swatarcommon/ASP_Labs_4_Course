using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace laba8.Models
{
    public class JsonRPCError
    {
        public string Jsonrpc { get; set; }
        public ErrorJson Error { get; set; }
        public string Id { get; set; }
    }
}