using Microsoft.Azure.Mobile.Server;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace SurveyServiceApp.DataObjects
{
    [Table("responses")] // this maps the class to the responses table on db
    public class SurveyResponse : EntityData
    {
        [JsonProperty("quastionid")]
        public string QuestionId { get; set; }

        public string Name { get; set; }

        [JsonProperty("answer")]
        public int AnswerIndex { get; set; }
        
    }
}