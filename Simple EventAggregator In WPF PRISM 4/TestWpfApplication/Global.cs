using System;
using Microsoft.Practices.Prism.Events;

namespace TestWpfApplication
{
    //To be able to pass an event from a publisher to a subscriber using Prism’s event aggregator,
    //the first thing you need to do is to define the actual type of the event to be passed. 
    //An event object is a class that inherits from the abstract Microsoft.Practices.Prism.Events.EventBase class. 
    //Prism comes with a Microsoft.Practices.Prism.Events.CompositePresentationEvent<TPayload> 
    //class that inherits from this one, where the TPayload type parameter specifies the type of argument that will be passed to the subscribers.
    internal class FileSelectedGlobalEvent : CompositePresentationEvent<string>
    {
        private static readonly EventAggregator _eventAggregator;
        private static readonly FileSelectedGlobalEvent _event;

        static FileSelectedGlobalEvent()
        {
            _eventAggregator = new EventAggregator();
            _event = _eventAggregator.GetEvent<FileSelectedGlobalEvent>();
        }

        public static FileSelectedGlobalEvent Instance
        {
            get { return _event; }
        }
    }

    internal static class GlobalVariables
    {
        static GlobalVariables()
        {
            RootPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        public static string RootPath { get; private set; }
    }
}