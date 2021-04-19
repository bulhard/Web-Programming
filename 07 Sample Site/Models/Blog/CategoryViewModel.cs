namespace MyBlog.Models.Blog
{
    public class CategoryViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string CategorySlug
        {
            get
            {
                return $"_{Id}";
            }
        }
    }
}