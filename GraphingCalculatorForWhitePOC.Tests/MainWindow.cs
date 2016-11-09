using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;

namespace GraphingCalculatorForWhitePOC.Tests
{
    [TestClass]
    public class MainWindowShould
    {
        //1. First Add in paths to app under test and the setup to grab the window
        private const string LocalPathToTestApp = "C:\\Github\\WhitePageModellingPOCGraphingCalcTests_Demo\\GraphingCalculatorDemo\\bin\\Debug\\";
        private Application _app;
        private MainWindowModel _mainWindow;
        private Window _appWindow;

        //3. To test the appearance of the main window, we need to launch the app first. We need to do this everytime
        [TestInitialize]
        public void LaunchApp()
        {
            _app = Application.Launch(LocalPathToTestApp + "GraphingCalculatorForWhitePOC.exe");
            _appWindow = _app.GetWindow("MainWindow");
            _mainWindow = new MainWindowModel(_appWindow);
        }

        //2. Then we think of what we want to test
        [TestMethod]
        public void Appear()
        {
            //5. Now we write the test, plain English, we are testing that the main window of the app appears on launch, which is handled by the test initialize
            //Main Window Should Be Visible
            Assert.IsTrue(_mainWindow.WindowVisible);
            //7. Finally we run our test
        }
        
        //9. Let's see what a failing test looks like
        [TestMethod]
        public void NotAppear()
        {
            //Arrange
            bool IsVisible;
            //Act
            IsVisible =_mainWindow.WindowVisible;
            //Assert
            Assert.IsFalse(IsVisible, $"We expected the window's visibility to be false but it was {IsVisible}");
        }

        //10. Now let's see what a test with searching for an element looks like, we need to ensure the input for numbers is available!
        [TestMethod]
        public void HaveNumberInputFieldAvailableForInput()
        {
            //Arrange
            bool NumberInputAvailable;
            
            //Act
            //11. Now we have to modify the model to expose the number input
            NumberInputAvailable = _mainWindow.NumberInputVisibleAndEnabled;

            //Assert
            //13. Final Assertion
            Assert.IsTrue(NumberInputAvailable, "The input to the caclulator's main screen is not available");
        }

        //4. Then the cleanup
        [TestCleanup]
        public void ExitApp()
        {
            _app.Kill();
        }

    }

    //5. Now we have to write the model for the Main Window which we need to pass the main window to
    public class MainWindowModel : TestHelper
    {
        public MainWindowModel(Window mainWindow) : base(mainWindow)
        {
        }
        //7. Now we have to figure out how to get the element, including searching for the hook      
        private TextBox NumberInput => ParentWindow.Get<TextBox>("UIImmediate"); 
        
        //6. Now we have to expose the behaviour we need for the test
        public bool WindowVisible => ParentWindow.Visible;

        //12. Now we have to add the NumberInputVisibleAndEnabled property to the model, while maintaining encapsulation of the model
        public bool NumberInputVisibleAndEnabled => NumberInput.Visible && NumberInput.Enabled; 
    }
}