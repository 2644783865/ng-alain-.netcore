using System.ComponentModel.DataAnnotations;

namespace asdf.Models
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class LoginRequest
    {
        [Required(ErrorMessage = "���䲻��Ϊ��")]
        [EmailAddress(ErrorMessage = "�����ʽ����ȷ")]
        public string email { get; set; }

        [Required(ErrorMessage = "���벻��Ϊ��")]
        public string password { get; set; }
    }

    public class LoginResponse
    {
        public string token { get; set; }

        public string username { get; set; }

        public string email { get; set; }

        public string avatar { get; set; }
    }
}