using System;

namespace DynamicProxy.BusinessLogic.Objects.Meta
{
    [AttributeUsage(validOn: AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class TransactionAttribute : Attribute
    {
    }
}
