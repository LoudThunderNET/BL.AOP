using System.Collections.Generic;

namespace DynamicProxy.BusinessLogic.Objects.Models
{
    /// <summary>
    /// Представлет блог
    /// </summary>
    public class Blog
    {
        /// <summary>
        /// Идентификатор блога.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Наименование блога.
        /// </summary>
        public string AuthorName { get; set; }

        /// <summary>
        /// Посты в блоге.
        /// </summary>
        public ICollection<Post> Posts { get; set; }
    }
}
