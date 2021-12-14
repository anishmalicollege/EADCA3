using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EADCA3
{
        public class Result
        {
            public string id { get; set; }
            public string title { get; set; }
            public int year { get; set; }
            public List<Result> results { get; set; }
        }

        public class Root
        {
            public string Type { get; set; }
            public string query { get; set; }
            public List<Result> results { get; set; }
        }
    }
