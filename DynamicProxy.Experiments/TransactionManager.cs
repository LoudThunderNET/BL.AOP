using Castle.DynamicProxy;
using DynamicProxy.BusinessLogic.Objects.Services;
using System.Collections.Concurrent;
using System.Data.Common;

namespace DynamicProxy.Experiments
{
    internal class TransactionManager : ITransactionManager, IInterceptor
    {

        public TransactionManager()
        {
        }

        public  void Intercept(IInvocation invocation)
        {
            Transaction(() => invocation.Proceed());
        }

        public TResult Transaction<TRequest, TResult>(Func<TRequest, TResult> action)
        {
            throw new NotImplementedException();
        }

        public void Transaction(Action action)
        {
            Console.WriteLine("Transaction has begun");
            action();
            Console.WriteLine("Transaction has completed");

        }
    }
}
