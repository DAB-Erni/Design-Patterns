using System;
using FactoryMethodUI.Interfaces;

namespace FactoryMethodUI.Components
{
    public class Textfield : IUIComponent
    {
        public void BuildComponent()
        {
            Console.WriteLine("Created a Textfield");
        }
    }

}