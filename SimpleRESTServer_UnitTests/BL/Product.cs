using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleRESTServer_BL.BL;

namespace SimpleRESTServer_UnitTests.BL
{
    [TestClass]
    public class Product
    {
        
        

        [TestMethod]
        public void RequestForHeadwearObjectShouldReturnHeadwearObject()
        {

            //Arrange
            AbsctractProductFactory pf = new ConcreteProductFactory();

            //Act
            AbstractHeadwear h = pf.CreateHeadwear();
            h.Size = "1";

            //Assert
            Assert.AreEqual("SimpleRESTServer_BL.BL.Headwear", h.GetType().ToString());
        }

        [TestMethod]
        public void RequestForNoveltyObjectShouldReturnNoveltyObject()
        {
            //Arrange
            AbsctractProductFactory pf = new ConcreteProductFactory();

            //Act
            AbstractNovelty h = pf.CreateNovelty();
            h.SKU = "12345";

            //Assert
            Assert.AreEqual("SimpleRESTServer_BL.BL.Novelty", h.GetType().ToString());
        }

        [TestMethod]
        public void RequestForApparelObjectShouldReturnApparelObject()
        {
            //Arrange
            AbsctractProductFactory pf = new ConcreteProductFactory();

            //Act
            AbstractApparel h = pf.CreateApparel();
            h.SKU = "12345";

            //Assert
            Assert.AreEqual("SimpleRESTServer_BL.BL.Apparel", h.GetType().ToString());
        }

        [TestMethod]
        public void RequestForServiceObjectShouldReturnServiceObject()
        {
            //Arrange
            AbsctractProductFactory productfactory = new ConcreteProductFactory();

            //Act
            AbstractService service = productfactory.CreateService();

            //Assert
            Assert.AreEqual("SimpleRESTServer_BL.BL.Service", service.GetType().ToString());

        }

        [TestMethod]
        public void RequestForAccessoryObjectShouldReturnAccessoryObject()
        {
            //Arrange
            AbsctractProductFactory pf = new ConcreteProductFactory();

            //Act
            AbstractAccessory h = pf.CreateAccessory();
            h.SKU = "12345";

            //Assert
            Assert.AreEqual("SimpleRESTServer_BL.BL.Accessory", h.GetType().ToString());
        }

        [TestMethod]
        public void RequestForStoreSupplyObjectShouldReturnStoreSupplyObject()
        {
            //Arrange
            AbsctractProductFactory pf = new ConcreteProductFactory();

            //Act
            AbstractStoreSupply h = pf.CreateStoreSupply();
            h.SKU = "12345";

            //Assert
            Assert.AreEqual("SimpleRESTServer_BL.BL.StoreSupply", h.GetType().ToString());
        }

        [TestMethod]
        public void RequestForNoveltyObjectShouldReturnProductObject()
        {
            //Arrange
            AbsctractProductFactory ProductFactory = new ConcreteProductFactory();

            //Act
            AbstractProduct NoveltyItem = ProductFactory.CreateNovelty();
            NoveltyItem.SKU = "12345";

            //Assert
            Assert.AreEqual("SimpleRESTServer_BL.BL.Novelty", NoveltyItem.GetType().ToString());
        }

        [TestMethod]
        public void ShouldBeAbleToSetAndGetSizeForHeadwearProduct()
        {
            //Arrange
            AbsctractProductFactory productFactory = new ConcreteProductFactory();

            //Act
            AbstractProduct HeadwearItem = productFactory.CreateHeadwear();

            ((AbstractHeadwear)HeadwearItem).Size = "13";
            

            //Assert
            Assert.AreEqual("13", ((AbstractHeadwear)HeadwearItem).Size);
        }

        [TestMethod]
        public void ShouldBeAbleToSetAndGetSizeForApparelProduct()
        {
            //Arrange
            AbsctractProductFactory ProductFactory = new ConcreteProductFactory();

            //Act
            AbstractApparel ApparelItem = ProductFactory.CreateApparel();
            ApparelItem.Size = "1.5";

            //Assert
            Assert.AreEqual("1.5", ApparelItem.Size);
        }

        [TestMethod]
        public void ShouldBeAbleToSetAndGetSKUForAnyProduct()
        {
            //Arrange
            AbsctractProductFactory ProductFactory = new ConcreteProductFactory();
            string sku = "12345";

            //Act
            AbstractApparel Item = ProductFactory.CreateApparel();
            Item.SKU = sku;

            //Assert
            Assert.AreEqual(sku, Item.SKU);
        }


        [TestMethod]
        public void ShouldBeAbleToSetAndGetProductStatusForAnyProduct()
        {
            //Arrange
            AbsctractProductFactory ProductFactory = new ConcreteProductFactory();
            ProductStatus productstatus = ProductStatus.Active;

            //Act
            AbstractApparel Item = ProductFactory.CreateApparel();
            Item.Status = productstatus;

            //Assert
            Assert.AreEqual(productstatus, Item.Status);
        }

        [TestMethod]
        public void ShouldBeAbleToSetAndGetBasePropertiesForAnyProduct()
        {
            //Arrange
            AbsctractProductFactory ProductFactory = new ConcreteProductFactory();
            string description = "Test Description";

            //Act
            AbstractApparel Item = ProductFactory.CreateApparel();
            Item.Description = description;

            //Assert
            Assert.AreEqual(description, Item.Description);
        }
    }
}
