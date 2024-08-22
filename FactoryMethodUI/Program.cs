using FactoryMethodUI.Interfaces;
using FactoryMethodUI.Factories;
using FactoryMethodUI.Components;

namespace FactoryMethodUI;

class Program
{
    static void Main(string[] args)
    {
        // IComponentsFactory buttonFactory = new ButtonFactory();
        // IUIComponent button = buttonFactory.CreateComponents();
        // button.BuildComponent();

        // IComponentsFactory checkboxFactory = new CheckboxFactory();
        // IUIComponent checkbox = checkboxFactory.CreateComponents();
        // checkbox.BuildComponent();

        // IComponentsFactory textfieldFactory = new TextFieldFactory();
        // IUIComponent textfield = textfieldFactory.CreateComponents();
        // textfield.BuildComponent();

        Console.WriteLine("App: Launched with the ButtonFactory.");
        ClientCode(new ButtonFactory());

        Console.WriteLine("");

        Console.WriteLine("App: Launched with the TextFieldFactory.");
        ClientCode(new TextFieldFactory());

        Console.WriteLine("");

        Console.WriteLine("App: Launched with the CheckboxFactory.");
        ClientCode(new CheckboxFactory());
    }

    public static void ClientCode(IComponentsFactory factory)
    {
        // The client code works with an instance of a concrete factory, albeit through its base interface.
        Console.WriteLine("Client: I'm not aware of the factory's class, but it still works.");
        factory.RenderComponent();
    }

}

// Product - UIComponent.cs
// Concrete Products - Button.cs, Checkbox.cs, Textfield.cs
// Creator - IUIComponentsFactory
// Concrete Creators - ButtonFactory, CheckboxFactory, TextfieldFactory

