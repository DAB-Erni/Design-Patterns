using FactoryMethodUI.Interfaces;
using FactoryMethodUI.Components;

namespace FactoryMethodUI.Factories
{
    public class ButtonFactory : IComponentsFactory
    {
        public override IUIComponent CreateComponents()
        {
            return new Button();
        }
    }
}

