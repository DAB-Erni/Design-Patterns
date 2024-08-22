using System;
using FactoryMethodUI.Interfaces;

namespace FactoryMethodUI.Components
{
    public class Checkbox : IUIComponent
    {
        public void BuildComponent()
        {
            Console.WriteLine("Created a Checkbox");
        }
    }

}