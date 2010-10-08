using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Caliburn.Micro;

namespace SimpleConductorOneActive.ViewModels
{
    public class RandomScreenViewModel:Screen
    {
        public RandomScreenViewModel()
        {
            Guid id = Guid.NewGuid();
            DisplayName = id.ToString();

        }

        private int onInitializeCalls = 0;
        private int onActivateCalls = 0;
        private int onDeactivateCalls = 0;

        public int OnInitializeCalls
        {
            get
            {
                return onInitializeCalls;
            }
            set
            {
                onInitializeCalls = value;
                NotifyOfPropertyChange(() => OnInitializeCalls);
            }
        }

        public int OnActivateCalls
        {
            get
            {
                return onActivateCalls;
            }
            set
            {
                onActivateCalls = value;
                NotifyOfPropertyChange(() => OnActivateCalls);
            }
        }

        public int OnDeactivateCalls
        {
            get
            {
                return onDeactivateCalls;
            }
            set
            {
                onDeactivateCalls = value;
                NotifyOfPropertyChange(() => OnDeactivateCalls);
            }
        }
        


        protected override void OnInitialize()
        {
            OnInitializeCalls++;
            base.OnInitialize();
        }

        protected override void OnActivate()
        {
            OnActivateCalls++;
            base.OnActivate();
        }

        protected override void OnDeactivate(bool close)
        {
            OnDeactivateCalls++;
            base.OnDeactivate(close);
        }

        public void CloseScreen()
        {
            base.TryClose();
        }

    }
}
