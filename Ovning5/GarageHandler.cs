using Ovning5.UserInterface;

namespace Ovning5
{
    internal class GarageHandler
    {
        private readonly IUI _ui;
        public GarageHandler(IUI ui)
        {
            _ui = ui;
        }

        public void Init()
        {
            _ui.ShowMainMenu();
        }

    }
}
