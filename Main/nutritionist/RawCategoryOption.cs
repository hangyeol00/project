namespace nutritionist
{
    public class RawCategoryOption
    {
        public RawCategoryOption(int categoryId, string categoryName)
        {
            CategoryId = categoryId;
            CategoryName = categoryName;
        }

        public int CategoryId { get; }
        public string CategoryName { get; }

        public override string ToString()
        {
            return string.IsNullOrWhiteSpace(CategoryName)
                ? $"분류 #{CategoryId}"
                : CategoryName;
        }
    }
}
