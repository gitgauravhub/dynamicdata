using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ItemsControlDemo
{
    public class PersonDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate UnderThirtyTemplate { get; set; }
        public DataTemplate ThirtyOrOlderTemplate { get; set; }

        public override DataTemplate
            SelectTemplate(object item, System.Windows.DependencyObject container)
        {
            var person = (Person)item;
            if (person.Age < 30) return UnderThirtyTemplate;
            return ThirtyOrOlderTemplate;
        }
    }
}
