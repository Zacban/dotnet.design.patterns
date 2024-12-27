using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype.Basic;
public interface IPrototype<T>
{
    T DeepCopy();
}
