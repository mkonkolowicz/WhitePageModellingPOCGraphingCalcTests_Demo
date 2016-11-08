using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;

namespace GraphingCalculatorForWhitePOC.Tests
{
    [TestClass]
    public class MainWindowShould
    {
        //1. First Add in paths to app under test and the setup to grab the window
        private const string LocalPathToTestApp = "C:\\Github\\WhitePageModellingPOCGraphingCalcTests\\GraphingCalculatorDemo\\bin\\Debug\\";
        private static Window _appWindow;
        private Application _app;

        //3. To test the appearance of the main window, we need to launch the app first. We need to do this everytime
        [TestInitialize]
        public void LaunchApp()
        {
            _app = Application.Launch(LocalPathToTestApp + "GraphingCalculatorForWhitePOC.exe");
            _appWindow = _app.GetWindow("MainWindow");
            //_mainWindow = new MainWindowModel(_appWindow);
        }

        //2. Then we think of what we want to test
        [TestMethod]
        public void Appear()
        {
            //5. Now we write the test, plain English, we are testing that the main window of the app appears on launch, which is handled by the test initialize
            //Main Window Should Appear


        }

        //4. Then the cleanup
        [TestCleanup]
        public void ExitApp()
        {
            _app.Kill();
        }

    }

    //5. Now we
}
