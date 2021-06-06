using NSubstitute;
using NSubstitute.ReceivedExtensions;
using NUnit.Framework;

namespace Bilka.Test.Unit
{
    public class ProductCategoryTest
    {
        private ProductCategory _uut;
        private ProductCategory _helperProductCategory;
        private ProductCategory _helperProductCategory2;
        private IProductComponent _productComponent1;
        private IProductComponent _productComponent2;
        private IProductComponent _refproductComponent;
        [SetUp]
        public void Setup()
        {
            _uut = new ProductCategory() { Description = "Full inventory of Bilka", Name = "Full Inventory"};
            _helperProductCategory2 = new ProductCategory() { Description = "All Clothing", Name = "Clothing" };
            _helperProductCategory = new ProductCategory() { Description = "All Colonial", Name = "Colonial" };
            _productComponent1 = Substitute.For<IProductComponent>();
            _productComponent2 = Substitute.For<IProductComponent>();
        }

        [Test]
        public void Constructor_ProductCategoryType_ProductCategoryIsCorrect()
        {
            Assert.That(_uut.Type, Is.EqualTo(IProductComponent.ComponentType.productCategory));
        }

        [Test]
        public void FindComponent_1item_ReturnsTrueAndItemIsInList()
        {
            //Arrange
            _uut.ProductComponents.Add(_helperProductCategory);

            //Assert + act
            Assert.Multiple((() =>
            {
                Assert.That(_uut.FindComponent(_helperProductCategory.Name, ref _refproductComponent));
                Assert.That(_refproductComponent.Name, Is.EqualTo(_helperProductCategory.Name));
            }));

        }

        [Test]
        public void FindComponent_2items_ReturnsTrueAndItemIsInList()
        {
            //Arrange
            _uut.ProductComponents.Add(_helperProductCategory);
            _uut.ProductComponents.Add(_helperProductCategory2);

            //Assert + act
            Assert.Multiple((() =>
            {
                Assert.That(_uut.FindComponent(_helperProductCategory.Name, ref _refproductComponent));
                Assert.That(_refproductComponent.Name, Is.EqualTo(_helperProductCategory.Name));
            }));

        }

        [Test]
        public void FindComponent_NestedItems_ReturnsTrueAndItemIsReturned()
        {
            //Arrange
            _uut.ProductComponents.Add(_helperProductCategory);
            _helperProductCategory.ProductComponents.Add(_helperProductCategory2);

            //Assert + act
            Assert.Multiple((() =>
            {
                Assert.That(_uut.FindComponent(_helperProductCategory2.Name, ref _refproductComponent));
                Assert.That(_refproductComponent.Name, Is.EqualTo(_helperProductCategory2.Name));
            }));

        }

        [Test]
        public void FindComponent_NestedItems_ReturnsFalse()
        {
            //Arrange
            _uut.ProductComponents.Add(_helperProductCategory);
            _helperProductCategory.ProductComponents.Add(_helperProductCategory2);

            //Assert + act
            Assert.Multiple((() =>
            {
                Assert.That(_uut.FindComponent("wrong name", ref _refproductComponent),Is.EqualTo(false));
            }));

        }


        [Test]
        public void FindComponent_0item_ItemNotFound()
        {

            //Assert
 
            Assert.That(_uut.FindComponent(_helperProductCategory.Name, ref _refproductComponent),Is.EqualTo(false));


        }

        [Test]
        public void AddComponent_1item_ItemIsInserted()
        {
            _uut.AddComponent(_uut, _helperProductCategory);

            Assert.That(_uut.ProductComponents.Contains(_helperProductCategory));
        }

        [Test]
        public void AddComponent_2IdenticalItems_1ItemInserted()
        {
            _uut.AddComponent(_uut, _helperProductCategory);
            _uut.AddComponent(_uut, _helperProductCategory);

            Assert.Multiple((() =>
            {
                Assert.That(_uut.ProductComponents.Contains(_helperProductCategory));
                Assert.That(_uut.ProductComponents.Count, Is.EqualTo(1));
            }));

        }
    }
}