namespace UneImageQuatreMotsApi.Domain.Entities
{
    public class Word
    {
        public int Id { get; set; }

        public string Libelle { get; set; }

        public string Image { get; set; }

        public Category category { get; set; }
    }
}
