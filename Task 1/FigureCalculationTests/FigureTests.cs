namespace FigureCalculationTests
{
    [TestClass]
    public class FigureTests
    {
        [TestMethod]
        public void CalculationAreaWithoutKnowledgetype() 
        {
            Figure figure;

            figure = new Triangle();

            Double triangleArea = figure.Area();

            Assert.AreEqual(typeof(Triangle), figure.GetType(), "Object type is not Triangle");
            Assert.AreEqual(7.483315, triangleArea, 0.000001, "Area not correctly");

            figure = new Circle();
            Double circleArea = figure.Area();

            Assert.AreEqual(typeof(Circle), figure.GetType(), "Object type is not Circle");
            Assert.AreEqual(Math.PI, circleArea, 0.000001, "Area not correctly");


        }
    }
}
