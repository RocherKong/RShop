﻿//*******************************
// Create By Rocher Kong 
// Date 2016-04-20 00:26
//*******************************

using System; 

namespace RShop.TradingCenter.Entity{
		/// <summary>
 	///产品属性选项
 	/// </summary>	
		[Serializable]
	public class T_ProductAttributeOption
	{
      	/// <summary>
		/// 选项编号
        /// </summary>		
        public long Id { get; set; }
        
		/// <summary>
		/// 属性编号
        /// </summary>		
        public long AttributeId { get; set; }
        
		/// <summary>
		/// 选项值
        /// </summary>		
        public string OptionValue { get; set; }
        
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