using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCmappimgTest.Models
{
    public class MainModel
    {
        public class SubModel
        {
            public int No { set; get; }
            public string Name { set; get; }
            public string Check { set; get; }
        }

        public List<SubModel> subModels { set; get; }

        public List<bool> checks { set; get; }
    }
}