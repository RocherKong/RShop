//*******************************
// Create By Rocher Kong 
// Date 2016-04-20 00:26
//*******************************

using System; 

namespace RShop.TradingCenter.Entity{
		/// <summary>
 	///产品
 	/// </summary>	
		[Serializable]
	public class T_Product
	{
      	/// <summary>
		/// Id
        /// </summary>		
        public long Id { get; set; }
        
		/// <summary>
		/// 产品名称
        /// </summary>		
        public string ProductName { get; set; }
        
		/// <summary>
		/// 产品型号
        /// </summary>		
        public string ProductModel { get; set; }
        
		/// <summary>
		/// 产品类型
        /// </summary>		
        public int ProductType { get; set; }
        
		/// <summary>
		/// 分类
        /// </summary>		
        public long CategoryId { get; set; }
        
		/// <summary>
		/// 品牌
        /// </summary>		
        public long BrandId { get; set; }
        
		/// <summary>
		/// 市场价
        /// </summary>		
        public decimal MarketPrice { get; set; }
        
		/// <summary>
		/// 封面图
        /// </summary>		
        public string CoverImage { get; set; }
        
		/// <summary>
		/// 产品详情
        /// </summary>		
        public string Description { get; set; }
        
		/// <summary>
		/// 产品状态
        /// </summary>		
        public int ProductStatus { get; set; }
        
		/// <summary>
		/// 备注
        /// </summary>		
        public string Remark { get; set; }
        
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