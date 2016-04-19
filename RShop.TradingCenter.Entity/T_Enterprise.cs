//*******************************
// Create By Rocher Kong 
// Date 2016-04-20 00:26
//*******************************

using System; 

namespace RShop.TradingCenter.Entity{
		/// <summary>
 	///企业
 	/// </summary>	
		[Serializable]
	public class T_Enterprise
	{
      	/// <summary>
		/// 编号
        /// </summary>		
        public long Id { get; set; }
        
		/// <summary>
		/// 企业类型
        /// </summary>		
        public int EnterpriseType { get; set; }
        
		/// <summary>
		/// 企业名称
        /// </summary>		
        public string EnterpriseName { get; set; }
        
		/// <summary>
		/// 省
        /// </summary>		
        public int ProvinceId { get; set; }
        
		/// <summary>
		/// 市
        /// </summary>		
        public int CityId { get; set; }
        
		/// <summary>
		/// 区
        /// </summary>		
        public int DistrictId { get; set; }
        
		/// <summary>
		/// 企业地址
        /// </summary>		
        public string Address { get; set; }
        
		/// <summary>
		/// 传真
        /// </summary>		
        public string Fax { get; set; }
        
		/// <summary>
		/// 法人代表
        /// </summary>		
        public string LegalPerson { get; set; }
        
		/// <summary>
		/// 注册资本
        /// </summary>		
        public decimal RegisteredCapital { get; set; }
        
		/// <summary>
		/// 营业执照
        /// </summary>		
        public string BusinessLicense { get; set; }
        
		/// <summary>
		/// 组织机构代码证
        /// </summary>		
        public string OrgCodeCer { get; set; }
        
		/// <summary>
		/// 税务登记证
        /// </summary>		
        public string TaxRegCer { get; set; }
        
		/// <summary>
		/// 行业
        /// </summary>		
        public string Industry { get; set; }
        
		/// <summary>
		/// 状态
        /// </summary>		
        public int Status { get; set; }
        
		/// <summary>
		/// IsDelete
        /// </summary>		
        public bool IsDelete { get; set; }
        
		/// <summary>
		/// CreateTime
        /// </summary>		
        public DateTime CreateTime { get; set; }
        
		/// <summary>
		/// Creator
        /// </summary>		
        public long Creator { get; set; }
        
		   
	}
}