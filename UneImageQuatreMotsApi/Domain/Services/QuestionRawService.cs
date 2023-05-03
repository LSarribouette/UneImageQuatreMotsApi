using System.Threading.Tasks;
using UneImageQuatreMotsApi.Domain.Entities;
using UneImageQuatreMotsApi.Domain.Interfaces;
using static System.Net.WebRequestMethods;

namespace UneImageQuatreMotsApi.Domain.Services
{
    public class QuestionRawService : IService<Question> //TODO changer pour BaseService -- a implementer
    {
        private static List<Word> _someWords { get; }

        private static List<Question> _someQuestions { get; }

        static QuestionRawService()
        {
            var baseUrl = "https://localhost:7086";


            // 4 mots
            _someWords = new List<Word>
            {
                new Word { Id = 1, Image = baseUrl + "chaise.webp", Libelle = "Chaise", category = Category.NOUN }, // ça s'affiche !!! https://localhost:7086/images/chaise.webp
                new Word { Id = 2, Image = baseUrl + "table.webp", Libelle = "Table", category = Category.NOUN },
                new Word { Id = 3, Image = "une image de voiture", Libelle = "Voiture", category = Category.NOUN },
                new Word { Id = 4, Image = "une image de canapé", Libelle = "Canapé", category = Category.NOUN },
            };

            // foreach someWords.... craft url --> Image = $"{ baseUrl } { Libelle}"


            // une liste de questions avec les 4 mots 
            _someQuestions = new List<Question>
            {
                new Question { Id = 1, RightAnswer = _someWords.Single(w => w.Id == 1), Answers = _someWords },
                new Question { Id = 2, RightAnswer = _someWords.Single(w => w.Id == 2), Answers = _someWords },
                new Question { Id = 3, RightAnswer = _someWords.Single(w => w.Id == 3), Answers = _someWords },
                new Question { Id = 4, RightAnswer = _someWords.Single(w => w.Id == 4), Answers = _someWords },

            };
        }

        public void Create(Question entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Question entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(Question entity)
        {
            throw new NotImplementedException();
        }

        public List<Question> FetchAll()
        {
            //Tasks.OrderByDescending(task => task.Created).ToList();
            return _someQuestions.ToList();
            // il faut un repo
        }

        public Question FindBy(int id)
        {
            return _someQuestions.Find(q => q.Id == id);
        }

    }
}
