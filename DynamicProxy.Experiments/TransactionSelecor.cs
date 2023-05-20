using Castle.DynamicProxy;
using DynamicProxy.BusinessLogic.Objects.Meta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProxy.Experiments
{
    public class TransactionSelecor : IProxyGenerationHook
    {
        public bool ShouldInterceptMethod(Type type, MethodInfo memberInfo)
        {
            var transactions = memberInfo.GetCustomAttribute<TransactionAttribute>();
            if (transactions == null)
            {
                Console.WriteLine($"Method {memberInfo.Name} has not {typeof(TransactionAttribute).Name}.");

                return false;
            }

            Console.WriteLine($"Method {memberInfo.Name} willl be intercepted.");

            return true;
        }

        public void NonVirtualMemberNotification(Type type, MemberInfo memberInfo)
        {
            Console.WriteLine($"Attempt to intercept nonvirtual member type of {memberInfo.Name}:{memberInfo.MemberType} that belong to {type.Name} was occured.");
        }

        public void MethodsInspected()
        {
        }

        public void NonProxyableMemberNotification(Type type, MemberInfo memberInfo)
        {
            Console.WriteLine($"Attempt to intercept nonproxyble member type of {memberInfo.Name}:{memberInfo.MemberType} that belong to {type.Name} was occured.");
        }
    }
}
