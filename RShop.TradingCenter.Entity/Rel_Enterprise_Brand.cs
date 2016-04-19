//*******************************
// Create By Rocher Kong 
// Date 2016-04-20 00:26
//*******************************

using System; 

namespace RShop.TradingCenter.Entity{
		/// <summary>
 	///企业代理的品牌
 	/// </summary>	
		[Serializable]
	public class Rel_Enterprise_Brand
	{
      	/// <summary>
		/// 企业编号
        /// </summary>		
        public long EnterpriseId { get; set; }
        
		/// <summary>
		/// 品牌编号
        /// </summary>		
        public long BrandId { get; set; }
        
		   
	}
}