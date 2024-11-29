using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abax_Oppgave
{
    internal interface ITransport
    {
        protected string Registration { get; set; }
        protected int Effect { get; set; }

        void Go();
        void Show();

    }
}
