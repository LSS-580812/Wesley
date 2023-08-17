using Microsoft.AspNetCore.Mvc;
using WesleyBaseEx.Models;

namespace WesleyBaseEx.Controllers
{
    public class WesleyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



        /* ASP.NET Core MVC 使用模型繫結建立資料模型的編輯表單與基架產生器的操作
         * https://www.youtube.com/watch?v=azAyvWveRhA&list=PLzs78Vw3QIyB9VkqihaB6XkcDbg8Zd5G5&index=23&ab_channel=%E8%A1%9B%E6%96%AF%E7%90%86%E9%A0%BB%E9%81%93%28wesley09171%29
         * 
        */
        public IActionResult Ex023()
        {
            //https://localhost:7162/Wesley/Ex023
            return View();
        }

        [HttpPost] //只允許 HTTP 的 POST 方法動作
        [ValidateAntiForgeryToken] //用於防範偽造要求 CSRF 的屬性
        public IActionResult Ex023(MessageModel_Cs obj_Val)
        {
            if (ModelState.IsValid)
            { /*表單資料驗證通過
               * 一般來說我們都會用 ModelState.IsValid 來檢查在「模型繫結」的過程中所做的 輸入驗證 (Input Validation) 與 模型驗證 (Model Validation) 是否成功。
               * 注意：模型內資料全部要成功，若模型內表單無用到時，亦會發生錯誤情形(注意)
               */
                TempData["Title"] = obj_Val.Title_P;
                TempData["Content"] = obj_Val.Content_P;
                TempData["Email"] = obj_Val.Email_P;
                return RedirectToAction("DisplayFormDate"); //將網頁移轉到 DisplayFormDate 位置
                //return View("DisplayFormDate");
            }
            //return Content("驗證失敗=" + ModelState.IsValid.ToString());
            return View(); //否則驗證失敗時-> 再回到檢視輸入頁面 Ex023.cshtml           
        }


        public IActionResult DisplayFormDate()
        {
            if(TempData.Count == 0)
            { //當 TempData 字典物件鍵值為0(即無資料)
                return Content("無任何資料內容");
            }
            return View();
        }
    }
}
