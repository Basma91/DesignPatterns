using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Paterns.DependencyInjection.InversionOfControl
{
  public  interface IEvents
    {
        void LoadEvent() { }
    }
    class TechEvents : IEvents
    {
        public void LoadEvent()
        {

        }
    }

    class FootballEvents : IEvents
    {
        public void LoadEvent()
        {

        }
    }
}
