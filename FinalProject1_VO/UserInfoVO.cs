using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject1_VO
{
    public class UserInfoVO
    {
        [Required(ErrorMessage ="사용자 아이디를 입력하세요")]
        public string user_id { get; set; }
        [Required(ErrorMessage ="사용자 비밀번호를 입력하세요")]
        public string  user_pwd { get; set; }
        public string user_name { get; set; }
        public string user_Category { get; set; }
        public string user_birthday { get; set; }
        public string user_depart_id { get; set; }
        public string user_pic { get; set; }
        public string user_email { get; set; }
        public int? authID { get; set; }
    }
}
