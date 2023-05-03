namespace UneImageQuatreMotsApi.Domain.Entities
{
    public class Question
    {
        public int Id { get; set; }

        public Word RightAnswer { get; set; }

        public List<Word> Answers { get; set; }
    }
}
