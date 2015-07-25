using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleManagementSystem.Controllers
{
    public class EmployeeController : Controller
    {
        /// <summary>
        /// 員工列表
        /// </summary>
        /// <returns></returns>
        public ActionResult List()
        {
            return View();
        }

        /// <summary>
        /// 員工資料暨請假紀錄明細
        /// </summary>
        /// <returns></returns>
        public ActionResult Detail()
        {
            return View();
        }

        /// <summary>
        /// 員工資料變更
        /// </summary>
        /// <returns></returns>
        public ActionResult Modify()
        {
            return View();
        }

        /// <summary>
        /// 請假申請
        /// </summary>
        /// <returns></returns>
        public ActionResult LeaveApply()
        {
            return View();
        }

        /// <summary>
        /// 本月薪資計算
        /// </summary>
        /// <returns></returns>
        public ActionResult CalculateMonthlySalary()
        {
            return View();
        }
    }
}