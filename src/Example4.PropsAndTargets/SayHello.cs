using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using System;

namespace Example4.PropsAndTargets
{
    public class SayHello : AppDomainIsolatedTask
    {
        public string PersonName { get; set; }

        public override bool Execute()
        {
            Log.LogMessage(MessageImportance.High, "Hello, {0}!!!!", PersonName ?? "world");
            return true;
        }
    }
}
