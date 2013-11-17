using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Adagi.Models;

namespace Adagi.Tests
{
    [TestClass]
    public class ModelTest
    {
        [TestMethod]
        [TestCategory("Database Models")]
        public void TestModelType()
        {
            var feature = new Feature();
            var featureType = new FeatureType();
            var featureValue = new FeatureValue();
            var person = new Person();
            var property = new Property();
            var propertyType = new PropertyType();
            var user = new User();
            var organization = new Organization();

            Assert.AreEqual("Feature", feature.ModelType);
            Assert.AreEqual(feature.GetType().Name, feature.ModelType);

            Assert.AreEqual("FeatureType", featureType.ModelType);
            Assert.AreEqual(featureType.GetType().Name, featureType.ModelType);

            Assert.AreEqual("FeatureValue", featureValue.ModelType);
            Assert.AreEqual(featureValue.GetType().Name, featureValue.ModelType);

            Assert.AreEqual("Person", person.ModelType);
            Assert.AreEqual(person.GetType().Name, person.ModelType);

            Assert.AreEqual("Property", property.ModelType);
            Assert.AreEqual(property.GetType().Name, property.ModelType);

            Assert.AreEqual("PropertyType", propertyType.ModelType);
            Assert.AreEqual(propertyType.GetType().Name, propertyType.ModelType);

            Assert.AreEqual("User", user.ModelType);
            Assert.AreEqual(user.GetType().Name, user.ModelType);

            Assert.AreEqual("Organization", organization.ModelType);
            Assert.AreEqual(organization.GetType().Name, organization.ModelType);
        }
    }
}
