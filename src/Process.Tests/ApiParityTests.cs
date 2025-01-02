using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Agilent.Ace.Testables.Process.Wrappers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Snapshooter;
using Snapshooter.MSTest;
using static System.Reflection.BindingFlags;

namespace Agilent.Ace.Testables.Process.Tests
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class ApiParityTests
    {

        [TestMethod]
        public void ProcessWrapper_And_ProcessFactory()
        {
            AssertParity(
                referenceType: typeof(System.Diagnostics.Process),
                abstractionTypes: new List<Type>
                {
                    typeof(ProcessFactory),
                    typeof(ProcessWrapper)
                }
            );
        }

        private static void AssertParity(Type referenceType, List<Type> abstractionTypes)
        {
            IEnumerable<string> GetMembers(Type type)
            {
                return type
                .GetMembers(bindingAttr: Instance | Static | Public | FlattenHierarchy)
                .Select(x => x.ToString())
                .OrderBy(x => x, StringComparer.Ordinal);
            }

            var referenceMembers = GetMembers(referenceType)
                .Select(x => x.Replace(
                    "System.Diagnostics.Process ", "Agilent.Ace.Testables.Process.Abstractions.IProcess "))
                .Select(x => x.Replace(
                    "System.Diagnostics.Process[] ", "Agilent.Ace.Testables.Process.Abstractions.IProcess[] "));
            List<string> abstractionMembers = new List<string>();
            foreach (Type type in abstractionTypes)
            {
                abstractionMembers.AddRange(GetMembers(type));
            }

            var diff = new ApiDiff(
                extraMembers: abstractionMembers.Except(referenceMembers),
                missingMembers: referenceMembers.Except(abstractionMembers)
            );
            Snapshot.Match(diff, SnapshotNameExtension.Create(SnapshotSuffix));
        }


#if NET48
        private const string SnapshotSuffix = ".NET Framework 4.8";
#elif NET481
        private const string SnapshotSuffix = ".NET Framework 4.8.1";
#elif NET8_0
        private const string SnapshotSuffix = ".NET 8.0";
#elif NET9_0
        private const string SnapshotSuffix = ".NET 9.0";
#else
#error Unknown target framework.
#endif

        private readonly struct ApiDiff
        {
            public ApiDiff(IEnumerable<string> extraMembers, IEnumerable<string> missingMembers)
            {
                ExtraMembers = extraMembers.ToArray();
                MissingMembers = missingMembers.ToArray();

            }

            public string[] ExtraMembers { get; }
            public string[] MissingMembers { get; }
        }
    }
}
