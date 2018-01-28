using Microsoft.Azure.Mobile.Server;
using System.ComponentModel.DataAnnotations.Schema;

namespace SurveyServiceApp.DataObjects
{
    [Table("questions")]
    public class SurveyQuestion : EntityData
    {

        public string Text { get; set; }

        public string Answers { get; set; }

    }
}