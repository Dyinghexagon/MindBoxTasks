namespace FigureCalculationTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Area_WhenRadius_1() 
        {
            Circle circle = new Circle(1);

            Double areaCircle = circle.Area();

            Assert.AreEqual(Math.PI, areaCircle, "Area not correctly");
        }
        [TestMethod]
        public void Area_WhenRadius_2_5()
        {
            Circle circle = new Circle(2.5);

            Double areaCircle = circle.Area();

            Assert.AreEqual(19.634954, areaCircle,0.000001, "Area not correctly");
        }
        [TestMethod]
        public void Area_WhenRadius_6()
        {
            Circle circle = new Circle(6);

            Double areaCircle = circle.Area();

            Assert.AreEqual(113.097336, areaCircle, 0.000001, "Area not correctly");
        }
        [TestMethod]
        public void Area_WhenEmptyConstructor()
        {
            Circle circle = new Circle();

            Double areaCircle = circle.Area();

            Assert.AreEqual(Math.PI, areaCircle, "Area not correctly");
        }
    }
}
