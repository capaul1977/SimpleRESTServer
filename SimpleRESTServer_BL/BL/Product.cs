using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRESTServer_BL.BL
{

    public abstract class AbsctractProductFactory
    {
        public abstract AbstractHeadwear CreateHeadwear();
        public abstract AbstractNovelty CreateNovelty();
        public abstract AbstractApparel CreateApparel();
        public abstract AbstractService CreateService();
        public abstract AbstractAccessory CreateAccessory();
        public abstract AbstractStoreSupply CreateStoreSupply();

    }

    public abstract class AbstractProduct
    {
        public string SKU { get; set; }
        public string Description { get; set; }
        public ProductStatus Status { get; set; }
    }

    public enum ProductStatus
    {
        Active, Inactive
    }

    public class ConcreteProductFactory : AbsctractProductFactory
    {
        public override AbstractAccessory CreateAccessory()
        {
           return new Accessory();
        }

        public override AbstractApparel CreateApparel()
        {
            return new Apparel();
        }

        public override AbstractHeadwear CreateHeadwear()
        {
            return new Headwear();
        }

        public override AbstractNovelty CreateNovelty()
        {
            return new Novelty();
        }

        public override AbstractService CreateService()
        {
            return new Service();
        }

        public override AbstractStoreSupply CreateStoreSupply()
        {
            return new StoreSupply();
        }
    }

    public abstract class AbstractHeadwear : AbstractProduct
    {
        public string Size { get; set; }
    }
    public abstract class AbstractNovelty : AbstractProduct { }
    public abstract class AbstractApparel : AbstractProduct
    {
        public string Size { get; set; }
    }
    public abstract class AbstractService : AbstractProduct { }
    public abstract class AbstractAccessory : AbstractProduct { }
    public abstract class AbstractStoreSupply : AbstractProduct { }

    public class Headwear : AbstractHeadwear { }
    public class Novelty : AbstractNovelty { }
    public class Apparel : AbstractApparel { }
    public class Service : AbstractService { }
    public class Accessory : AbstractAccessory { }
    public class StoreSupply : AbstractStoreSupply { }



}
