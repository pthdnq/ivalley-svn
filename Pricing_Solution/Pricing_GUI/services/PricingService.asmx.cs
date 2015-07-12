using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Web.Script.Services;
using PricingBLL;
using System.Data;
namespace Pricing_GUI.services
{
    /// <summary>
    /// Summary description for PricingService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class PricingService : System.Web.Services.WebService
    {
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]        
        public void GetTradeDrugs(string name, string generics, decimal strength, string company, string regNo )
        {
            v_EDDB_TradeDrugDetails details = new v_EDDB_TradeDrugDetails();
            details.SearchDrugs(name, generics, strength, company, regNo);

            List<Models.TradeDrugModel> Alldetails = details.DefaultView.Table.AsEnumerable().Select(row =>
            {
                return new Models.TradeDrugModel
                {
                    TradeCode = Convert.ToInt32(row[v_EDDB_TradeDrugDetails.ColumnNames.TradeCode].ToString()),
                    Strength_value = Convert.ToDecimal(row[v_EDDB_TradeDrugDetails.ColumnNames.Strength_value].ToString()),
                    CompanyDetID = Convert.ToInt32(row[v_EDDB_TradeDrugDetails.ColumnNames.CompanyDetID].ToString()),
                    Drug_license_number = row["Drug_license_number"].ToString(),
                    Trade_name = row["Trade_name"].ToString(),
                    Type_of_license = row["Type_of_license"].ToString(),
                    Strength_unit = row["Strength_unit"].ToString(),
                    Dosage_form = row["Dosage_form"].ToString(),
                    Generics = row["Generics"].ToString(),
                    LicHold = row["LicHold"].ToString(),
                    Manufacturer = row["Manufacturer"].ToString(),
                    Packager = row["Packager"].ToString(),
                    BatchReleaser = row["BatchReleaser"].ToString(),
                    APISupplier = row["APISupplier"].ToString(),
                    StorageSite = row["StorageSite"].ToString(),
                    Type = row["Type"].ToString(),
                    Applicant = row["Applicant"].ToString(),

                };
            }).ToList();

            SetContentResult(Alldetails);
            //return _response;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void SearchDrugs(string name)
        {
            v_EDDB_TradeDrugDetails details = new v_EDDB_TradeDrugDetails();
            details.SearchDrugs(name, "", 0, "", "");

            List<Models.TradeDrugModel> Alldetails = details.DefaultView.Table.AsEnumerable().Select(row =>
            {
                return new Models.TradeDrugModel
                {
                    TradeCode = Convert.ToInt32(row[v_EDDB_TradeDrugDetails.ColumnNames.TradeCode].ToString()),
                    Strength_value = Convert.ToDecimal(row[v_EDDB_TradeDrugDetails.ColumnNames.Strength_value].ToString()),
                    CompanyDetID = Convert.ToInt32(row[v_EDDB_TradeDrugDetails.ColumnNames.CompanyDetID].ToString()),
                    Drug_license_number = row["Drug_license_number"].ToString(),
                    Trade_name = row["Trade_name"].ToString(),
                    Type_of_license = row["Type_of_license"].ToString(),
                    Strength_unit = row["Strength_unit"].ToString(),
                    Dosage_form = row["Dosage_form"].ToString(),
                    Generics = row["Generics"].ToString(),
                    LicHold = row["LicHold"].ToString(),
                    Manufacturer = row["Manufacturer"].ToString(),
                    Packager = row["Packager"].ToString(),
                    BatchReleaser = row["BatchReleaser"].ToString(),
                    APISupplier = row["APISupplier"].ToString(),
                    StorageSite = row["StorageSite"].ToString(),
                    Type = row["Type"].ToString(),
                    Applicant = row["Applicant"].ToString(),

                };
            }).ToList();

            SetContentResult(Alldetails);
            //return _response;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void GetTradeDrugById(int id)
        {
            System.Threading.Thread.Sleep(1500);
            v_EDDB_TradeDrugDetails details = new v_EDDB_TradeDrugDetails();
            details.GetDrugById(id);

            Models.TradeDrugModel Alldetails = new Models.TradeDrugModel();
            
            Alldetails.TradeCode = Convert.ToInt32(details.TradeCode.ToString());
            Alldetails.Strength_value = Convert.ToDecimal(details.Strength_value.ToString());
            Alldetails.CompanyDetID = Convert.ToInt32(details.CompanyDetID.ToString());
            Alldetails.Drug_license_number = details.Drug_license_number.ToString();
            Alldetails.Trade_name = details.Trade_name.ToString();
            Alldetails.Type_of_license = details.Type_of_license.ToString();
            Alldetails.Strength_unit = details.Strength_unit.ToString();
            Alldetails.Dosage_form = details.Dosage_form.ToString();
            Alldetails.Generics = details.Generics.ToString();
            Alldetails.LicHold = details.LicHold.ToString();
            Alldetails.Manufacturer = details.Manufacturer.ToString();
            Alldetails.Packager = details.Packager.ToString();
            Alldetails.BatchReleaser = details.BatchReleaser.ToString();
            Alldetails.APISupplier = details.APISupplier.ToString();
            Alldetails.StorageSite = details.StorageSite.ToString();
            Alldetails.Type = details.Type.ToString();
            Alldetails.Applicant = details.Applicant.ToString();
                
            SetContentResult(Alldetails);
            //return _response;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void GetTradeGenericsById(int id)
        {
            System.Threading.Thread.Sleep(1500);
            V_EDDB_DrugGenerics details = new V_EDDB_DrugGenerics();
            details.GetDrugById(id);

            List<Models.GenericModel> Alldetails = details.DefaultView.Table.AsEnumerable().Select(row =>
            {
                return new Models.GenericModel
                {

                    TradeName_ID = Convert.ToInt32(row["TradeName_ID"].ToString()),
                    GenericName = row["GenericName"].ToString(),
                    Indications = row["Indications"].ToString(),
                    Cautions = row["Cautions"].ToString(),
                    Contra_indications = row["Contra_indications"].ToString(),
                    Side_effects = row["Side_effects"].ToString(),
                    Dose = row["Dose"].ToString(),
                    InterActionLevelCode = row["InterActionLevelCode"].ToString(),
                    Interaction = row["Interaction"].ToString(),
                    General = row["General"].ToString(),
                    HDL = row["HDL"].ToString(),
                    STORE = row["STORE"].ToString(),
                    CPNUM = Convert.IsDBNull(row["CPNUM"]) ? 0 : Convert.ToInt32(row["CPNUM"].ToString()),
                    Dilution = Convert.IsDBNull(row["Dilution"]) ? 0 : Convert.ToInt32(row["Dilution"].ToString()),
                    MaxChemoDose = Convert.IsDBNull(row["MaxChemoDose"]) ? 0 : Convert.ToInt32(row["MaxChemoDose"].ToString()),
                    TPNIngredient = Convert.IsDBNull(row["TPNIngredient"]) ? 0 : Convert.ToInt32(row["TPNIngredient"].ToString()),
                    ChemoCalcType = Convert.IsDBNull(row["ChemoCalcType"]) ? 0 : Convert.ToInt32(row["ChemoCalcType"].ToString()),
                    IsVaccine = Convert.IsDBNull(row["IsVaccine"]) ? 0 : Convert.ToInt32(row["IsVaccine"].ToString()),
                    strengthunit = Convert.IsDBNull(row["strengthunit"]) ? 0 : Convert.ToInt32(row["strengthunit"].ToString()),
                    strengthunitstr = row["strengthunitstr"].ToString(),
                    StrengthValue = Convert.IsDBNull(row["StrengthValue"]) ? 0 : Convert.ToDecimal(row["StrengthValue"].ToString()),
                };
            }).ToList();
            SetContentResult(Alldetails);
            //return _response;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void GetTradePackgesById(int id)
        {
            System.Threading.Thread.Sleep(1500);
            v_EDDB_PackDetailes details = new v_EDDB_PackDetailes();
            details.GetDrugById(id);

            List<Models.PackageModel> Alldetails = details.DefaultView.Table.AsEnumerable().Select(row =>
            {
                return new Models.PackageModel
                {
                    Pack_unit = row["Pack_unit"].ToString(),
                    Pack_Unit_Name = row["Pack_Unit_Name"].ToString(),
                    conver_sub = Convert.IsDBNull(row["conver_sub"]) ? 0 : Convert.ToDecimal(row["conver_sub"].ToString()),
                    unit_price = Convert.IsDBNull(row["unit_price"]) ? 0 : Convert.ToDecimal(row["unit_price"].ToString()),
                };
            }).ToList();
            SetContentResult(Alldetails);
            //return _response;
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
