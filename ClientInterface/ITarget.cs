using System;
using System.Collections.Generic;
using System.Text;

namespace AdaptorDesignPattern.ClientInterface
{
   public interface ITarget
    {
        List<string> GetListEmployees();
    }
}
