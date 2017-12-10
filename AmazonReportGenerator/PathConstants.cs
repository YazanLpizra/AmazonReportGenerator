using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonReportGenerator
{
    class PathConstants
    {
        #region Login paths
        public static readonly string URL = "https://www.amazon.com/gp/b2b/reports";
        public static readonly string Login_EmailField = "//*[@id=\"ap_email\"]";
        public static readonly string Login_PasswordField = "//*[@id=\"ap_password\"]";
        public static readonly string Login_submitButton = "//*[@id=\"signInSubmit\"]";
        #endregion

        #region 
        public static string Report_TypeDropDown = "//*[@id=\"a-autoid-0-announce\"]";
        public static string Report_TypeDropDown_OrdersOption = "Orders";

        public static string Report_TimePeriodDropDown = "//*[@id=\"a-autoid-1-announce\"]";
        public static string Report_TimePeriodDropDown_Past4WeeksOption = "Past 4 weeks";

        public static string Report_OrganizedByDropDown = "//*[@id=\"a-autoid-2-announce\"]";
        public static string Report_OrganizedByDropDown_AccountGroupsOption = "Account Groups";

        public static string Report_DownloadCsvButton = "/html/body/div[1]/div[1]/div[2]/div/div[1]/span[2]/span/span/input";
        #endregion

        /*
        #region Report paths
        public static readonly string Report_ReportType = "//*[@id=\"report-type\"]";
        public static readonly string Report_ReportType_OrdersOption = "Orders and shipments";
        public static readonly string Report_ReportType_ItemsOption = "Items";
        public static readonly string Report_ReportType_RefundsOption = "Refunds";
        public static readonly string Report_ReportType_ReturnsOption = "Returns";

        public static readonly string Report_StartDate_Year = "//*[@id=\"report-year-start\"]";
        public static readonly string Report_StartDate_Month = "//*[@id=\"report-month-start\"]";
        public static readonly string Report_StartDate_Day = "//*[@id=\"report-day-start\"]";

        public static readonly string Report_EndDate_Year = "//*[@id=\"report-year-end\"]";
        public static readonly string Report_EndDate_Month = "//*[@id=\"report-month-end\"]";
        public static readonly string Report_EndDate_Day = "//*[@id=\"report-day-end\"]";

        public static readonly string Report_ReportName = "//*[@id=\"report-name\"]";
        public static readonly string Report_SubmitButton = "//*[@id=\"report-confirm\"]";
        #endregion
    */
    }
}
