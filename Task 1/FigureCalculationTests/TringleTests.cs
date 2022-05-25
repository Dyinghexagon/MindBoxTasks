namespace FigureCalculationTests
{
    [TestClass]
    public class TringleTests
    {
        [TestMethod]
        public void TriangleNotExist()
        {
            try
            {
                Triangle triangle = new Triangle(1, 2, 3);
                Assert.Fail("An exception should have been thrown.");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("A triangle with such sides cannot exist.", ex.Message);
            }
            catch (Exception e)
            {
                Assert.Fail(
                     String.Format("Unexpected exception of type {0} caught: {1}.",
                                    e.GetType(), e.Message)
                );
            }
        }
        [TestMethod]
        public void Area_WhenEmptyConstructor()
        {
            Triangle triangle = new Triangle();

            Double triangleArea = triangle.Area();

            Assert.AreEqual(7.483315, triangleArea, 0.000001, "Area not correctly");
        }
        [TestMethod]
        public void Area_WhenSideA_5_SideB_12_SideC_10()
        {
            Triangle triangle = new Triangle(5, 12, 10);

            Double triangleArea = triangle.Area();

            Assert.AreEqual(24.544602, triangleArea, 0.000001, "Area not correctly");
        }
        [TestMethod]
        public void Area_WhenSideA_4_SideB_5_SideC_6()
        {
            Triangle triangle = new Triangle(4, 5, 6);

            Double triangleArea = triangle.Area();

            Assert.AreEqual(9.921567, triangleArea, 0.000001, "Area not correctly");
        }
        [TestMethod]
        public void Area_WhenSideA_3_5_SideB_6_3_SideC_3()
        {
            Triangle triangle = new Triangle(3.5, 6.3, 3);

            Double triangleArea = triangle.Area();

            Assert.AreEqual(2.512051, triangleArea, 0.000001, "Area not correctly");
        }
        [TestMethod]
        public void TriangleIsRectangular()
        {
            Triangle triangle = new Triangle(4, 3, 5);

            Boolean isRectangular = triangle.IsRectangular;

            Assert.AreEqual(true, isRectangular, "Triangle is rectangular");
        }
        [TestMethod]
        public void TriangleNotRectangular()
        {
            Triangle triangle = new Triangle();

            Boolean isRectangular = triangle.IsRectangular;

            Assert.AreEqual(false, isRectangular, "Triangle not rectangular");
        }
        [TestMethod]
        public void Perimetr_WhenEmptyConstructor()
        {
            Triangle triangle = new Triangle();

            Double tringlePerimetr = triangle.Perimetr();

            Assert.AreEqual(14, tringlePerimetr, 0.000001, "Perimetr not correctly");
        }
    }
}