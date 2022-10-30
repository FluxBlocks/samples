using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginHRServices
{
    public interface ITest
    {
        public string TestTest();
    }

    public class Test : ITest
    {
        public string TestTest()
        {
            return "test";
        }
    }
}
