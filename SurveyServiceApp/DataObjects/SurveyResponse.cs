using Microsoft.Azure.Mobile.Server;

namespace SurveyServiceApp.DataObjects
{
    public class SurveyResponse : EntityData
    {

        public string QuestionId { get; set; }

        public string Name { get; set; }

        public int AnswerIndex { get; set; }
        
    }
}