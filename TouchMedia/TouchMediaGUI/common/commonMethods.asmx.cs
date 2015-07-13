using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using BLL;
using System.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Web.Security;
namespace TouchMediaGUI.common
{
    /// <summary>
    /// Summary description for commonMethods
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class commonMethods : System.Web.Services.WebService
    {

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        /// <summary>
        /// Get All Status
        /// </summary>
        /// <returns>object with List of all statuses</returns>
        public void GetJOStatuses()
        {
            JobOrderStatus statues = new JobOrderStatus();
            statues.LoadAll();

            List<Models.StatusModel> AllStatuses = statues.DefaultView.Table.AsEnumerable().Select(row =>
            {
                return new Models.StatusModel 
                {
                    StatusID = Convert.ToInt32(row[JobOrderStatus.ColumnNames.JobOrderStatusID].ToString()),
                    StatusName = row[JobOrderStatus.ColumnNames.JobOrderStatusName].ToString(),
                    StatusNameAr = row[JobOrderStatus.ColumnNames.JobOrderStatusNameAr].ToString(),
                    StatusClass = row[JobOrderStatus.ColumnNames.StatusClass].ToString()
                };
            }).ToList();

            SetContentResult(AllStatuses);
            //return _response;
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        /// <summary>
        /// Get All Designers
        /// </summary>
        /// <returns>object with List of all Designers</returns>
        public void GetJODesigners()
        {
            BLL.GeneralLookup Designers = new BLL.GeneralLookup();
            Designers.LoadByCategoryID(Category.Designers);

            List<Models.Designer> AllDesigers = Designers.DefaultView.Table.AsEnumerable().Select(row =>
            {
                return new Models.Designer
                {
                    DesignerID = Convert.ToInt32(row[BLL.GeneralLookup.ColumnNames.GeneralLookupID].ToString()),
                    CategoryID = Convert.ToInt32(row[BLL.GeneralLookup.ColumnNames.CategoryID].ToString()),
                    DesignerName = row[BLL.GeneralLookup.ColumnNames.Name].ToString(),
                    Address = row[BLL.GeneralLookup.ColumnNames.Address].ToString(),
                    Email = row[BLL.GeneralLookup.ColumnNames.Email].ToString(),
                    Telephone = row[BLL.GeneralLookup.ColumnNames.Telephone].ToString(),

                };
            }).ToList();

            SetContentResult(AllDesigers);
            //return _response;
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        /// <summary>
        /// Get All Designers
        /// </summary>
        /// <returns>object with List of all Designers</returns>
        public void GetDesignDetails(int ID)
        {
            DesignDetails details = new DesignDetails();
            details.GetDesignDetailsByJOID(ID);

            List<Models.DesignDetail> Alldetails = details.DefaultView.Table.AsEnumerable().Select(row =>
            {
                return new Models.DesignDetail
                {
                    DesignDetailsID = Convert.ToInt32(row[DesignDetails.ColumnNames.DesignDetailsID].ToString()),
                    DesignerID = Convert.ToInt32(row[DesignDetails.ColumnNames.DesignerID].ToString()),
                    StartDate = Convert.ToDateTime(row[DesignDetails.ColumnNames.StartDate].ToString()),
                    EndDate = Convert.ToDateTime(row[DesignDetails.ColumnNames.EndDate].ToString()),
                    JobOrderStatusID = Convert.ToInt32(row[DesignDetails.ColumnNames.JobOrderStatusID].ToString()),
                    StatusClass = row["StatusClass"].ToString(),
                    StatusName = row["StatusName"].ToString(),

                };
            }).ToList();

            SetContentResult(Alldetails);
            //return _response;
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void GetGiveAwayDetails(int ID)
        {
            
            //return _response;
        }

        // General Job Order Save
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void SaveJobOrder(Models.JobOrder JobOrderMaster)
        {
            Models.JOResponse response = new Models.JOResponse();

            try
            {
                JobOrder objData = new JobOrder();
                if (JobOrderMaster.JobOrderID == 0)
                {
                    objData.AddNew();
                    objData.CreatedBy = new Guid(Membership.GetUser(Context.User.Identity.Name).ProviderUserKey.ToString());
                    objData.CreatedDate = DateTime.Now;
                }
                else
                    objData.LoadByPrimaryKey(JobOrderMaster.JobOrderID);

                objData.JobOrderStatusID = JobOrderMaster.JobOrderStatusID;
                objData.JobOrderCode = JobOrderMaster.JobOrderCode;
                objData.JobOrderDescription = JobOrderMaster.JobOrderDescription;
                objData.UpdatedBy = JobOrderMaster.UpdatedBy;
                objData.LastUpdatedDate = DateTime.Now;
                objData.JobOrderName = JobOrderMaster.JobOrderName;
                objData.ClientID = JobOrderMaster.ClientID;
                objData.Save();
                response.Result = true;
                response.Message = "Job Order master data saved successfully";
                response.returnData = objData.JobOrderID;
            }
            catch (Exception)
            {
                response.Result = false;
                response.Message = "Error happened in saving Job Order master data";
            }
            SetContentResult(response);
        }

        // Design
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void SaveJobOrderDesign(List<Models.DesignDetail> DesignData, int JobOrderID)
        {
            foreach (Models.DesignDetail item in DesignData)
            {
                DesignDetails objData = new DesignDetails();
                if (item.DesignDetailsID == 0)
                {
                    objData.AddNew();
                    objData.CreatedBy = new Guid(Membership.GetUser(Context.User.Identity.Name).ProviderUserKey.ToString());
                    objData.CreatedDate = DateTime.Now;
                }
                else
                    objData.LoadByPrimaryKey(item.DesignDetailsID);

                objData.JobOrderID = JobOrderID;
                //objData.DesignerID = item.DesignerID;
                objData.JobOrderStatusID = item.JobOrderStatusID;
                objData.StartDate = item.StartDate;
                objData.EndDate = item.EndDate;
                objData.UpdatedBy = new Guid(Membership.GetUser(Context.User.Identity.Name).ProviderUserKey.ToString());
                objData.LastUpdatedDate = DateTime.Now;
                objData.Save();
            }
        }

        //Digital Print
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void SaveJobOrderDigitalPrint(List<Models.DigitalPrintDetail> DigitalPrintData, int JobOrderID)
        {
            foreach (Models.DigitalPrintDetail item in DigitalPrintData)
            {

            }
        }

        //Offset Print
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void SaveJobOrderOffsetPrint(List<Models.OffsetPrintDetail> OffsetPrintData, int JobOrderID)
        {
            foreach (Models.OffsetPrintDetail item in OffsetPrintData)
            {

            }
        }

        //InOutDoor Print
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void SaveJobOrderInOutDoorPrint(List<Models.InOutDoorPrintDetail> InOutDoorPrintData, int JobOrderID)
        {
            foreach (Models.InOutDoorPrintDetail item in InOutDoorPrintData)
            {

            }
        }

        //Production
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void SaveJobOrderProduction(List<Models.Production> ProductionData, int JobOrderID)
        {
            foreach (Models.Production item in ProductionData)
            {

            }
        }

        private void SetContentResult(dynamic data)
        {
            string result = JsonConvert.SerializeObject(data, Formatting.None, new IsoDateTimeConverter() { DateTimeFormat = "yyyy-MM-dd HH:mm:ss" });
            HttpContext.Current.Response.ContentType = "application/json; charset=utf-8";
            HttpContext.Current.Response.Write(result);
            HttpContext.Current.Response.Flush(); // Sends all currently buffered output to the client.
            HttpContext.Current.Response.SuppressContent = true;  // Gets or sets a value indicating whether to send HTTP content to the client.
            HttpContext.Current.ApplicationInstance.CompleteRequest(); // Causes ASP.NET to bypass all events and filtering in the HTTP pipeline chain of execution and directly execute the EndRequest event.
        }
    }
}
