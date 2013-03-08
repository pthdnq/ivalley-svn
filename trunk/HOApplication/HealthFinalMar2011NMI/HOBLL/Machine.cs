
// Generated by MyGeneration Version # (1.2.0.7)

using System;
using MHO.DAL;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;

namespace MHO.BLL
{
	public class Machine : _Machine
	{
		public Machine()
		{
		
		}
        public void DeleteMachine(Guid machineId)
        {
            LoadByPrimaryKey(machineId);
            this.DeleteAll();
            Save();
        }
        public DataTable GetMachineDetails(int locationType, int govId, int civilId, int healthOfficeId)
        {
            SqlDataReader searchResult = null;
            ListDictionary parm = new ListDictionary();
            parm.Add("@locationTypeId", locationType);
            if (govId!=-1)
            parm.Add("@GovId", govId);
            if (civilId!=-1)
            parm.Add("@CivilId", civilId);
            if(healthOfficeId!=-1)
            parm.Add("@HealthOfficeId", healthOfficeId);
            searchResult = LoadFromSqlReader("GetMachineDetails", parm) as SqlDataReader;
            DataTable ResultTable = new DataTable();
            newAdapter da = new newAdapter();
            if (searchResult != null && searchResult.HasRows)
            {
                da.FillFromReader(ResultTable, searchResult);
            }

            return ResultTable;
        }
        public void AddNewMachine(int locationType, int govId, int civilId, int healthOfficeId, string ip, bool status)
        {
            Where.LocationTypeId.Value = locationType;
            if(govId!=-1)
            Where.GovId.Value = govId;
            if (civilId != -1)
            Where.CivilId.Value = civilId;
            if (healthOfficeId != -1)
            Where.HealthOfficeId.Value = healthOfficeId;
            if (!Query.Load())
            {
                AddNew();
                MachineId = Guid.NewGuid();
                LocationTypeId = locationType;
                if (govId != -1)
                    GovId = govId;
                if (civilId != -1)
                    CivilId = (short)civilId;
                if (healthOfficeId != -1)
                    HealthOfficeId = healthOfficeId;
                Save();
            }
            OrganizationMachineIP orgMachineIp = new OrganizationMachineIP();
            orgMachineIp.AddNewMachineDeatils(MachineId, ip, status);
        }
        public void UpdateMachine(Guid machineId, Guid orgIpId, int locationType, int govId, int civilId, int healthOfficeId, string ip, bool status)
        {
            this.LoadByPrimaryKey(machineId);
            LocationTypeId = locationType;
            if (govId != -1)
                GovId = govId;
            else
                SetColumnNull("GovId");
            if (civilId != -1)
                CivilId = (short)civilId;
            else
                SetColumnNull("CivilId");
            if (healthOfficeId != -1)
                HealthOfficeId = healthOfficeId;
            else
                SetColumnNull("HealthOfficeId");
            Save();
            OrganizationMachineIP orgIp = new OrganizationMachineIP();
            orgIp.UpdateMachineDeatils(orgIpId, ip, status);
        }

	}
}
