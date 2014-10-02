namespace MySolution.FirstDependency
{
    public class Class1
    {
        public Class1()
        {
            var foo = new MySolution.SecondDependency.Class1();
        }
    }
}
