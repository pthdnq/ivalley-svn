
// Generated by MyGeneration Version # (1.2.0.7)

using System;
using MHO.DAL;

namespace MHO.BLL
{
	public class OrganizationMachineIP : _OrganizationMachineIP
	{
		public OrganizationMachineIP()
		{
		
		}
        public void DeleteOrgIp(Guid orgIpID)
        {
            LoadByPrimaryKey(orgIpID);
            DeleteAll();
            Save();
        }
        public void AddNewMachineDeatils(Guid machineId,  string ip, bool status)
        {
            AddNew();
            MachineID = machineId;
            OrgIP = ip;
            Status = status;
            Save();
        }
        public void UpdateMachineDeatils(Guid orgIpId, string ip, bool status)
        {
            LoadByPrimaryKey(orgIpId);
            OrgIP = ip;
            Status = status;
            Save();
        }

	}
}
