using Prism.Interactivity.InteractionRequest;
using Prism.Mvvm;
using System;
using System.Windows.Input;

namespace EasyPrism
{
    public abstract class InteractionRequestBindableBase : BindableBase, IConfirmation, IInteractionRequestAware
    {
        public bool Confirmed { get; set; }

        public string Title { get; set; }

        public object Content { get; set; }

        public double Width { get; set; }

        public double Height { get; set; }

        /// <summary>
        /// This or self
        /// </summary>
        public INotification Notification { get; set; }

        /// <summary>
        /// Close View Window
        /// </summary>
        public Action FinishInteraction { get; set; }


        public abstract ICommand WiewLoadedCommand { get; set; }


        public void Finish(bool confirmed)
        {
            this.Confirmed = confirmed;
            FinishInteraction?.Invoke();
        }
    }
}
