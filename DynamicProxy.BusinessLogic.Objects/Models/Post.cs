using System;

namespace DynamicProxy.BusinessLogic.Objects.Models
{
    /// <summary>
    /// Представляет отдельный пост в блоге.
    /// </summary>
    public class Post
    {
        /// <summary>
        /// Идентификатор поста.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Ссылка на блог.
        /// </summary>
        public Blog Blog { get; set; }

        /// <summary>
        /// Дата публикации.
        /// </summary>
        public DateTime PublicationDate { get; set; }

        /// <summary>
        /// Заголовок публикации.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Текст публикации.
        /// </summary>
        public string Text { get; set; }
    }
}
