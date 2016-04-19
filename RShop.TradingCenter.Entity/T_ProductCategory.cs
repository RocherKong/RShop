//*******************************
// Create By Rocher Kong 
// Date 2016-04-20 00:26
//*******************************

using System; 

namespace RShop.TradingCenter.Entity{
		/// <summary>
 	///T_ProductCategory
 	/// </summary>	
		[Serializable]
	public class T_ProductCategory
	{
      	/// <summary>
		/// Id
        /// </summary>		
        public long Id { get; set; }
        
		/// <summary>
		/// CategoryName
        /// </summary>		
        public string CategoryName { get; set; }
        
		/// <summary>
		/// CategoryLevel
        /// </summary>		
        public int CategoryLevel { get; set; }
        
		/// <summary>
		/// ParentId
        /// </summary>		
        public long ParentId { get; set; }
        
		/// <summary>
		/// CategoryCode
        /// </summary>		
        public string CategoryCode { get; set; }
        
		/// <summary>
		/// SortId
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