using TestStack.White.UIItems.WindowItems;

namespace GraphingCalculatorForWhitePOC.Tests
{
    public class TestHelper
    {
        protected internal Window ParentWindow { get; }

        public TestHelper(Window parentWindow)
        {
            ParentWindow = parentWindow;
        }
    }
}
