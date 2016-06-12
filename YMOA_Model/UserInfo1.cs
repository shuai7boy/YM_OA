using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace YMOA_Model
{
    [MetadataType(typeof(UserInfoFriend))]
    public partial class UserInfo
    {

    }
    public class UserInfoFriend
    {
        [Required(ErrorMessage = "*必填内容")]
        public string UserName { get; set; }
        [StringLength(1, ErrorMessage = "*只能为一个字符")]
        public bool UserGender { get; set; }
        [Range(18, 25, ErrorMessage = "*必须是18到25之间的数")]
        public int UserAge { get; set; }
    }
}
