﻿using AzureStorageAction.Extensions;
using AzureStorageAction.Test.Extensions.StringExtension.RemoveNullAndWhitespace.DataSources;

using NUnit.Framework;

using System.Linq;

namespace AzureStorageAction.Test.Extensions.StringExtension.RemoveNullAndWhitespace
{
    class RemoveNullAndWhitespaceTest
    {
        [TestCaseSource(typeof(RemoveNullAndWhitespaceTestDataSources))]
        public void RemoveNullAndWhitespace_Return_ArrayWithoutNullAndWhitespace(string[] array)
        {
            array = array.RemoveNullAndWhitespace();
            Assert.AreEqual(0, array.Count(x => string.IsNullOrWhiteSpace(x)));
        }
    }
}
