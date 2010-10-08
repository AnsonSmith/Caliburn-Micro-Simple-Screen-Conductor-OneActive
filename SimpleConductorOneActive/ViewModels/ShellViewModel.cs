namespace SimpleConductorOneActive.ViewModels
{
    using Caliburn.Micro;

    public class ShellViewModel : Conductor<Screen>.Collection.OneActive
    {

        public int ScreenCount
        {
            get { return this.Items.Count; }
        }
        
        public ShellViewModel()
        {
        
        }

        public void NewScreen()
        {
            ActivateItem(new RandomScreenViewModel());
        }

        public override void ActivateItem(Screen item)
        {
            base.ActivateItem(item);
            NotifyOfPropertyChange(() => ScreenCount);
        }
    }
}
