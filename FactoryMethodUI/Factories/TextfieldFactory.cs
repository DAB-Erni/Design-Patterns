using FactoryMethodUI.Interfaces;
using FactoryMethodUI.Components;

namespace FactoryMethodUI.Factories
{
    public class TextFieldFactory : IComponentsFactory
    {
        public override IUIComponent CreateComponents()
        {
            return new Textfield();
        }
    }
}

