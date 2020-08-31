using System;
using System.Collections.Generic;
using System.Text;

namespace Estimationtool.Services
{
   public interface IEventAggregator
    {
        bool HandlerExistsFor(Type messageType);
        void Subscribe(object subscriber);
        void Unsubscribe(object subscriber);
        void Publish(object message, Action<Action> marshal);

    }
}
