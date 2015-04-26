using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Caliburn.Micro.SimpleMDI.Data
{
    public class EventAggregationProvider
    {
        static EventAggregator _eventAggregator = null;
        public static EventAggregator EventAggregator
        {
            get
            {
                if (_eventAggregator == null)
                    _eventAggregator = new EventAggregator();

                return _eventAggregator;
            }
        }
    }
}
