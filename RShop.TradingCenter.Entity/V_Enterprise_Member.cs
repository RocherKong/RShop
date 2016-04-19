//*******************************
// Create By Rocher Kong 
// Date 2016-04-20 00:27
//*******************************

using System; 

namespace RShop.TradingCenter.Entity{
		/// <summary>
 	///V_Enterprise_Member
 	/// </summary>	
		[Serializable]
	public class V_Enterprise_Member
	{
      	/// <summary>
		/// Department
        /// </summary>		
        public string Department { get; set; }
        
		/// <summary>
		/// IsRoot
        /// </summary>		
        public bool IsRoot { get; set; }
        
		/// <summary>
		/// LoginName
        /// </summary>		
        public string LoginName { get; set; }
        
		/// <summary>
		/// NickName
        /// </summary>		
        public string NickName { get; set; }
        
		/// <summary>
		/// TrueName
        /// </summary>		
        public string TrueName { get; set; }
        
		/// <summary>
		/// Avatar
        /// </summary>		
        public string Avatar { get; set; }
        
		/// <summary>
		/// Password
        /// </summary>		
        public string Password { get; set; }
        
		/// <summary>
		/// EMail
        /// </summary>		
        public string EMail { get; set; }
        
		/// <summary>
		/// Sex
        /// </summary>		
        public bool Sex { get; set; }
        
		/// <summary>
		/// MobilePhone
        /// </summary>		
        public string MobilePhone { get; set; }
        
		/// <summary>
		/// MemberStatus
        /// </summary>		
        public int MemberStatus { get; set; }
        
		/// <summary>
		/// RegisterFrom
        /// </summary>		
        public string RegisterFrom { get; set; }
        
		/// <summary>
		/// LastLogOnTime
        /// </summary>		
        public DateTime LastLogOnTime { get; set; }
        
		/// <summary>
		/// MemberId
        /// </summary>		
        public long MemberId { get; set; }
        
		/// <summary>
		/// EnterpriseId
        /// </summary>		
        public long EnterpriseId { get; set; }
        
		/// <summary>
		/// EnterpriseType
        /// </summary>		
        public int EnterpriseType { get; set; }
        
		/// <summary>
		/// EnterpriseName
        /// </summary>		
        public string EnterpriseName { get; set; }
        
		/// <summary>
		/// DistrictId
        /// </summary>		
        public int DistrictId { get; set; }
        
		/// <summary>
		/// Address
        /// </summary>		
        public string Address { get; set; }
        
		/// <summary>
		/// Fax
        /// </summary>		
        public string Fax { get; set; }
        
		/// <summary>
		/// BusinessLicense
        /// </summary>		
        public string BusinessLicense { get; set; }
        
		/// <summary>
		/// Industry
        /// </summary>		
        public string Industry { get; set; }
        
		/// <summary>
		/// EnterpriseStatus
        /// </summary>		
        public int EnterpriseStatus { get; set; }
        
		/// <summary>
		/// IsDelete
        /// </summary>		
        public bool IsDelete { get; set; }
        
		/// <summary>
		/// ProvinceName
        /// </summary>		
        public string ProvinceName { get; set; }
        
		/// <summary>
		/// CityName
        /// </summary>		
        public string CityName { get; set; }
        
		/// <summary>
		/// DistricName
        /// </summary>		
        public string DistricName { get; set; }
        
		   
	}
}