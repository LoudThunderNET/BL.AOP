using System;

namespace DynamicProxy.BusinessLogic.Objects.Services
{
    public interface ITransactionManager
    {
        TResult Transaction<TRequest, TResult>(Func<TRequest, TResult> action);
        void Transaction(Action action);
    }
}
