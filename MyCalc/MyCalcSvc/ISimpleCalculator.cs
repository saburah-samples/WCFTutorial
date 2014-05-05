using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace MyCalcSvc
{
    [ServiceContract()]
    public interface ISimpleCalculator
    {
        [OperationContract()]
        int Add(int num1, int num2);
    }
}
