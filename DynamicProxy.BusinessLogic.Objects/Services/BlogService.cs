using DynamicProxy.BusinessLogic.Objects.Meta;
using DynamicProxy.BusinessLogic.Objects.Models;
using System;

namespace DynamicProxy.BusinessLogic.Objects.Services
{
    public class BlogService : IBlogService
    {
        public void Save(Blog blog)
        {
            Console.WriteLine($"Блог {blog.AuthorName} сохранен");
        }

        public void PublishPost(int blogId, Post post)
        {
            Console.WriteLine($"В блоге {blogId} опубликована запись {post.Id}[{post.Title}] {post.PublicationDate}");
        }
    }
}