using DynamicProxy.BusinessLogic.Objects.Meta;
using DynamicProxy.BusinessLogic.Objects.Models;

namespace DynamicProxy.BusinessLogic.Objects.Services
{
    public interface IBlogService
    {
        [Transaction]
        void PublishPost(int blogId, Post post);

        [Transaction]
        void Save(Blog blog);
    }
}