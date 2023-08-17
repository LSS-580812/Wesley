using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WesleyBaseEx.Models
{
    //宣告公開類別(訊息資料模型)
    public class MessageModel_Cs
    {
        [DisplayName("標題")]
        //[StringLength(30, MinimumLength =4)] //驗證失敗-> The field 標題 must be a string with a minimum length of 4 and a maximum length of 30.
        [Required(ErrorMessage = "請輸入登入帳號")] //必填資料-> 驗證失敗時-> 請輸入登入帳號
        //[MinLength(6, ErrorMessage = "{0}不得低於{1}個字元")]
        //[RegularExpression("[@]+", ErrorMessage = "{0}必須包含@字元")]
        public string? Title_P { get; set; } //宣告公開字串屬性(標題)

        [DisplayName("內容")]
        public string? Content_P { get; set; } //宣告公開字串屬性(內容)

        [Display(Name ="顧客e-Mail")] //欄位別名
        [DataType(DataType.EmailAddress)] //電子郵件格式
        [Required] //必填資料
        [StringLength(50, MinimumLength =10)] //輸入字元最少要10字元，最大可輸入50字元
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please enter a valid e-mail adress")]
        //[EmailAddress(ErrorMessage = "Invalid Email Address")]
        //[RegularExpression(@"^[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2.}$")] //資料正則化，必須為列舉中字元
        public string? Email_P { get; set; } //套用以上規則

        /*
        [DisplayName("顧客意見")]
        [Required]
        [StringLength(255)]
        public string? Message_P { get; set; }
        */
    }
}
