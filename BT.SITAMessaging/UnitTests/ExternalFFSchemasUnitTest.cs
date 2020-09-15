using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BT.SITAMessaging.ExternalSchemas;

namespace ExternalFFSchemaUnitTests
{
    [TestClass]
    public class ExternalFFSchemasUnitTest
    {
        [TestMethod]
        public void TestUC_MVT001()
        {
            AircraftMovementMessageTypeBFF movement = new AircraftMovementMessageTypeBFF();

            //path to FF instances to test - relative to the test dir
            string validFF = @"..\..\TestData\External\TypeBMsg\UC_MVT001.RCV";

            //Validating the valid instance against the schema
            Assert.IsTrue(movement.ValidateInstance(validFF, Microsoft.BizTalk.TestTools.Schema.OutputInstanceType.Native));
        }
        [TestMethod]
        public void TestUC_MVT002()
        {
            AircraftMovementMessageTypeBFF movement = new AircraftMovementMessageTypeBFF();

            //path to FF instances to test - relative to the test dir
            string validFF = @"..\..\TestData\External\TypeBMsg\UC_MVT002.RCV";

            //Validating the valid instance against the schema
            Assert.IsTrue(movement.ValidateInstance(validFF, Microsoft.BizTalk.TestTools.Schema.OutputInstanceType.Native));
        }
        [TestMethod]
        public void TestUC_MVT003()
        {
            AircraftMovementMessageTypeBFF movement = new AircraftMovementMessageTypeBFF();

            //path to FF instances to test - relative to the test dir
            string validFF = @"..\..\TestData\External\TypeBMsg\UC_MVT003.RCV";

            //Validating the valid instance against the schema
            Assert.IsTrue(movement.ValidateInstance(validFF, Microsoft.BizTalk.TestTools.Schema.OutputInstanceType.Native));
        }
        [TestMethod]
        public void TestUC_MVT004()
        {
            AircraftMovementMessageTypeBFF movement = new AircraftMovementMessageTypeBFF();

            //path to FF instances to test - relative to the test dir
            string validFF = @"..\..\TestData\External\TypeBMsg\UC_MVT004.RCV";

            //Validating the valid instance against the schema
            Assert.IsTrue(movement.ValidateInstance(validFF, Microsoft.BizTalk.TestTools.Schema.OutputInstanceType.Native));
        }
        [TestMethod]
        public void TestUC_MVT005()
        {
            AircraftMovementMessageTypeBFF movement = new AircraftMovementMessageTypeBFF();

            //path to FF instances to test - relative to the test dir
            string validFF = @"..\..\TestData\External\TypeBMsg\UC_MVT005.RCV";

            //Validating the valid instance against the schema
            Assert.IsTrue(movement.ValidateInstance(validFF, Microsoft.BizTalk.TestTools.Schema.OutputInstanceType.Native));
        }
        [TestMethod]
        public void TestUC_MVT006()
        {
            AircraftMovementMessageTypeBFF movement = new AircraftMovementMessageTypeBFF();

            //path to FF instances to test - relative to the test dir
            string validFF = @"..\..\TestData\External\TypeBMsg\UC_MVT006.RCV";

            //Validating the valid instance against the schema
            Assert.IsTrue(movement.ValidateInstance(validFF, Microsoft.BizTalk.TestTools.Schema.OutputInstanceType.Native));
        }
        [TestMethod]
        public void TestUC_MVT007()
        {
            AircraftMovementMessageTypeBFF movement = new AircraftMovementMessageTypeBFF();

            //path to FF instances to test - relative to the test dir
            string validFF = @"..\..\TestData\External\TypeBMsg\UC_MVT007.RCV";

            //Validating the valid instance against the schema
            Assert.IsTrue(movement.ValidateInstance(validFF, Microsoft.BizTalk.TestTools.Schema.OutputInstanceType.Native));
        }
        [TestMethod]
        public void TestUC_MVT008()
        {
            AircraftMovementMessageTypeBFF movement = new AircraftMovementMessageTypeBFF();

            //path to FF instances to test - relative to the test dir
            string validFF = @"..\..\TestData\External\TypeBMsg\UC_MVT008.RCV";

            //Validating the valid instance against the schema
            Assert.IsTrue(movement.ValidateInstance(validFF, Microsoft.BizTalk.TestTools.Schema.OutputInstanceType.Native));
        }
        [TestMethod]
        public void TestUC_MVT009()
        {
            AircraftMovementMessageTypeBFF movement = new AircraftMovementMessageTypeBFF();

            //path to FF instances to test - relative to the test dir
            string validFF = @"..\..\TestData\External\TypeBMsg\UC_MVT009.RCV";

            //Validating the valid instance against the schema
            Assert.IsTrue(movement.ValidateInstance(validFF, Microsoft.BizTalk.TestTools.Schema.OutputInstanceType.Native));
        }
        [TestMethod]
        public void TestUC_MVT010()
        {
            AircraftMovementMessageTypeBFF movement = new AircraftMovementMessageTypeBFF();

            //path to FF instances to test - relative to the test dir
            string validFF = @"..\..\TestData\External\TypeBMsg\UC_MVT010.RCV";

            //Validating the valid instance against the schema
            Assert.IsTrue(movement.ValidateInstance(validFF, Microsoft.BizTalk.TestTools.Schema.OutputInstanceType.Native));
        }
        [TestMethod]
        public void TestUC_MVT011()
        {
            AircraftMovementMessageTypeBFF movement = new AircraftMovementMessageTypeBFF();

            //path to FF instances to test - relative to the test dir
            string validFF = @"..\..\TestData\External\TypeBMsg\UC_MVT011.RCV";

            //Validating the valid instance against the schema
            Assert.IsTrue(movement.ValidateInstance(validFF, Microsoft.BizTalk.TestTools.Schema.OutputInstanceType.Native));
        }
        [TestMethod]
        public void TestUC_MVT012()
        {
            AircraftMovementMessageTypeBFF movement = new AircraftMovementMessageTypeBFF();

            //path to FF instances to test - relative to the test dir
            string validFF = @"..\..\TestData\External\TypeBMsg\UC_MVT012.RCV";

            //Validating the valid instance against the schema
            Assert.IsTrue(movement.ValidateInstance(validFF, Microsoft.BizTalk.TestTools.Schema.OutputInstanceType.Native));
        }
        [TestMethod]
        public void TestUC_MVT013()
        {
            AircraftMovementMessageTypeBFF movement = new AircraftMovementMessageTypeBFF();

            //path to FF instances to test - relative to the test dir
            string validFF = @"..\..\TestData\External\TypeBMsg\UC_MVT013.RCV";

            //Validating the valid instance against the schema
            Assert.IsTrue(movement.ValidateInstance(validFF, Microsoft.BizTalk.TestTools.Schema.OutputInstanceType.Native));
        }
        [TestMethod]
        public void TestUC_MVT014()
        {
            AircraftMovementMessageTypeBFF movement = new AircraftMovementMessageTypeBFF();

            //path to FF instances to test - relative to the test dir
            string validFF = @"..\..\TestData\External\TypeBMsg\UC_MVT014.RCV";

            //Validating the valid instance against the schema
            Assert.IsTrue(movement.ValidateInstance(validFF, Microsoft.BizTalk.TestTools.Schema.OutputInstanceType.Native));
        }
        [TestMethod]
        public void TestUC_MVT015()
        {
            AircraftMovementMessageTypeBFF movement = new AircraftMovementMessageTypeBFF();

            //path to FF instances to test - relative to the test dir
            string validFF = @"..\..\TestData\External\TypeBMsg\UC_MVT015.RCV";

            //Validating the valid instance against the schema
            Assert.IsTrue(movement.ValidateInstance(validFF, Microsoft.BizTalk.TestTools.Schema.OutputInstanceType.Native));
        }
    }
}
