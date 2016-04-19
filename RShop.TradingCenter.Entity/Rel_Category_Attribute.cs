//*******************************
// Create By Rocher Kong 
// Date 2016-04-20 00:26
//*******************************

using System; 

namespace RShop.TradingCenter.Entity{
		/// <summary>
 	///商品分类_商品属性关联
 	/// </summary>	
		[Serializable]
	public class Rel_Category_Attribute
	{
      	/// <summary>
		/// 分类编号
        /// </summary>		
        public long CategoryId { get; set; }
        
		/// <summary>
		/// 属性编号
        /// </summary>		
        public long AttributeId { get; set; }
        
		   
	}
}