namespace ConductorTest.ViewModels
{
    using Caliburn.Micro;

    public class ShellViewModel : Conductor<Screen>
    {
        public ShellViewModel()
        {
            
        }

        public void ScreenA()
        {
            ActivateItem(new ScreenAViewModel());
        }

        public void ScreenB()
        {
            ActivateItem(new ScreenBViewModel());
        }
    }
}
