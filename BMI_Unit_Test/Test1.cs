using BMICalculator;

namespace BMI_Unit_Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            BMI bmi = new BMI() { WeightStones = 12, WeightPounds = 0, HeightFeet = 5, HeightInches = 10 };
            Assert.AreEqual(BMICategory.Normal, bmi.BMICategory);
        }

        [TestMethod]
        public void TestMethod2()
        {
            BMI bmi = new BMI() { WeightStones = 30, WeightPounds = 0, HeightFeet = 5, HeightInches = 10 };
            Assert.AreNotEqual(BMICategory.Normal, bmi.BMICategory);
        }

        //[DataTestMethod]
        [TestMethod]
        // 4 rows of data for testing different BMI categories.
        // what is naming convention for test methods?
        [DataRow(7, 8, 5, 5, BMICategory.Underweight)]
        [DataRow(12, 0, 5, 10, BMICategory.Normal)]
        [DataRow(12, 8, 5, 5, BMICategory.Overweight)]
        [DataRow(15, 0, 5, 10, BMICategory.Obese)]
        public void TestAllCategories(int ws, int wp, int hf, int hi, BMICategory cat)
        {
            BMI bmi = new BMI() { WeightStones = ws, WeightPounds = wp, HeightFeet = hf, HeightInches = hi };
            Assert.AreEqual(bmi.BMICategory, cat);
        }

        // put in another method to test invalid inputs????
        [TestMethod]
        // 4 rows of data for testing different BMI categories.
        [DataRow(2, 8, 5, 5, BMICategory.Underweight)]
        public void AssertInvalidInputs(int ws, int wp, int hf, int hi, BMICategory cat)
        {
            BMI bmi = new () { WeightStones = ws, WeightPounds = wp, HeightFeet = hf, HeightInches = hi };
            Assert.AreEqual(bmi.BMICategory, cat);
        }
    }
}
