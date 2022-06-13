using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Paterns.DependencyInjection.InversionOfControl
{
    public class Collage
    {
        public IEvents events = null;

        public Collage( IEvents events)
        {
            this.events = events;
        }
    }

   
    }

