namespace FactoryMethodUI.Interfaces;

public abstract class IComponentsFactory
{
    public abstract IUIComponent CreateComponents();

    public void RenderComponent()
    {
        var component = CreateComponents();
        component.BuildComponent();
    }
}
