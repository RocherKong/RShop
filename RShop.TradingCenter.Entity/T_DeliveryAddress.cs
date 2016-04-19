//*******************************
// Create By Rocher Kong 
// Date 2016-04-20 00:26
//*******************************

using System; 

namespace RShop.TradingCenter.Entity{
		/// <summary>
 	///收货地址
 	/// </summary>	
		[Serializable]
	public class T_DeliveryAddress
	{
      	/// <summary>
		/// 订单编号
        /// </summary>		
        public long Id { get; set; }
        
		/// <summary>
		/// MemberId
        /// </summary>		
        public long MemberId { get; set; }
        
		/// <summary>
		/// Contact
        /// </summary>		
        public string Contact { get; set; }
        
		/// <summary>
		/// Phone
        /// </summary>		
        public string Phone { get; set; }
        
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
		/// DetailAddress
        /// </summary>		
        public string DetailAddress { get; set; }
        
		/// <summary>
		/// IsDefault
        /// </summary>		
        public bool IsDefault { get; set; }
        
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