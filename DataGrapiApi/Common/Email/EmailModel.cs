using System.ComponentModel.DataAnnotations;

namespace DataGrapiApi.Common.Email
{
    public class EmailModel
    {
        [DataType(DataType.EmailAddress)]
        public string To { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Cc { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
