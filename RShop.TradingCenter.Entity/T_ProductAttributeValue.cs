//*******************************
// Create By Rocher Kong 
// Date 2016-04-20 00:26
//*******************************

using System; 

namespace RShop.TradingCenter.Entity{
		/// <summary>
 	///产品属性值
 	/// </summary>	
		[Serializable]
	public class T_ProductAttributeValue
	{
      	/// <summary>
		/// ProductId
        /// </summary>		
        public long ProductId { get; set; }
        
		/// <summary>
		/// AttributeId
        /// </summary>		
        public long AttributeId { get; set; }
        
		/// <summary>
		/// OptionId
        /// </summary>		
        public long OptionId { get; set; }
        
		/// <summary>
		/// 属性值
        /// </summary>		
        public string AttributeValue { get; set; }
        
		/// <summary>
		/// 单位
        /// </summary>		
        public string Unit { get; set; }
        
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