// <copyright file="BusinessMetaLayerTest.cs">Copyright ©  2018</copyright>
using System;
using System.Collections.Generic;
using FindANameFarm;
using FindANameFarm.MetaLayer;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FindANameFarm.MetaLayer.Tests
{
    /// <summary>This class contains parameterized unit tests for BusinessMetaLayer</summary>
    [PexClass(typeof(BusinessMetaLayer))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class BusinessMetaLayerTest
    {
        /// <summary>Test stub for GetStaff()</summary>
        [PexMethod]
        internal List<Staff> GetStaffTest([PexAssumeUnderTest]BusinessMetaLayer target)
        {
            List<Staff> result = target.GetStaff();
            return result;
            // TODO: add assertions to method BusinessMetaLayerTest.GetStaffTest(BusinessMetaLayer)
        }
    }
}
