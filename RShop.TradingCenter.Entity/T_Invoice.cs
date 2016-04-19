//*******************************
// Create By Rocher Kong 
// Date 2016-04-20 00:26
//*******************************

using System; 

namespace RShop.TradingCenter.Entity{
		/// <summary>
 	///T_Invoice
 	/// </summary>	
		[Serializable]
	public class T_Invoice
	{
      	/// <summary>
		/// Id
        /// </summary>		
        public long Id { get; set; }
        
		/// <summary>
		/// MemberId
        /// </summary>		
        public long MemberId { get; set; }
        
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
		/// TaxpayerNo
        /// </summary>		
        public string TaxpayerNo { get; set; }
        
		/// <summary>
		/// Telephone
        /// </summary>		
        public string Telephone { get; set; }
        
		/// <summary>
		/// BankName
        /// </summary>		
        public string BankName { get; set; }
        
		/// <summary>
		/// BankAccount
        /// </summary>		
        public string BankAccount { get; set; }
        
		/// <summary>
		/// IsDefault
        /// </summary>		
        public bool IsDefault { get; set; }
        
		/// <summary>
		/// 序号
        /// </summary>		
        public long SortId { get; set; }
        
		/// <summary>
		/// 逻辑删除位
        /// </summary>		
        public bool IsDelete { get; set; }
        
		/// <summary>
		/// 创建时间
        /// </summary>		
        public DateTime CreateTime { get; set; }
        
		/// <summary>
		/// 创建者
        /// </summary>		
        public long Creator { get; set; }
        
		   
	}
}