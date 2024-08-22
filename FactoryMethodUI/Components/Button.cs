using System;
using FactoryMethodUI.Interfaces;

namespace FactoryMethodUI.Components
{
    public class Button : IUIComponent
    {
        public void BuildComponent()
        {
            Console.WriteLine("Created Button");
        }
    }

}