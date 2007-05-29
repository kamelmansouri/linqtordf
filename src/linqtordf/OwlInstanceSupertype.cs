using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using SemWeb;

namespace LinqToRdf
{
    public class OwlInstanceSupertype : OwlClassSupertype
    {
        public string InstanceUri
        {
            get { return instanceUri; }
            set { instanceUri = value; }
        }

        private string instanceUri;
    }
}