using FactoryMethodUI.Interfaces;
using FactoryMethodUI.Components;

namespace FactoryMethodUI.Factories
{
    public class CheckboxFactory : IComponentsFactory
    {
        public override IUIComponent CreateComponents()
        {
            return new Checkbox();
        }
    }
}

