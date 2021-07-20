using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementer
{
    class Worker: BaseFactory<Worker>
    {
        public void Write()
        {
            Console.WriteLine(text);
        }
        string text;
        public Worker(string text)
        {
            this.text = text;
        }
    }
}
