using ChainOfResponsibilityPattern.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Abstracts
{
    internal abstract class BaseChecker : IChecker
    {
        public IChecker? Next { get; set; }

        public abstract void Check(object request);
    }
}
