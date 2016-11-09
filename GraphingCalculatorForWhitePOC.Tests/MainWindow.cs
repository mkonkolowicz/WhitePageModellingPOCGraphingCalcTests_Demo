using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;

namespace GraphingCalculatorForWhitePOC.Tests
{
    [TestClass]
    public class MainWindowShould
    {
        //0. Nuget package "TestStack.White" added

        //1. First Add in paths to app under test and the setup to grab the window
        private const string LocalPathToTestApp = "C:\\Github\\WhitePageModellingPOCGraphingCalcTests_Demo\\GraphingCalculatorDemo\\bin\\Debug\\";
        private Application _app;
        private MainWindowModel _mainWindow;
        private Window _appWindow;

        //3. To test the appearance of the main window, we need to launch the app first. We need to do this everytime
        
        //2. Then we think of what we want to test (does the window appear?)
       
        //5. Now we write the test, plain English, we are testing that the main window of the app appears on launch, which is handled by the test initialize
        //Main Window Should Be Visible
        
        //7. Finally we run our test
        
        //9. Let's see what a failing test looks like
        
        //10. Now let's see what a test with searching for an element looks like, we need to ensure the input (immediate) for numbers is available!
        
       //13. Final Assertion
        
        //4. Then the cleanup   
    }

    //5. Now we have to write the model for the Main Window which we need to pass the main window to
    public class MainWindowModel : TestHelper
    {
        public MainWindowModel(Window mainWindow) : base(mainWindow)
        {

        }
        //7. Now we have to figure out how to get the element, including searching for the hook      
        
        //6. Now we have to expose the behaviour we need for the test
        
        //12. Now we have to add the NumberInputVisibleAndEnabled property to the model, while maintaining encapsulation of the model
    }
}