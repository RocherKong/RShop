//*******************************
// Create By Rocher Kong 
// Date 2016-04-20 00:26
//*******************************

using System; 

namespace RShop.TradingCenter.Entity{
		/// <summary>
 	///产品报修
 	/// </summary>	
		[Serializable]
	public class T_ProductRepair
	{
      	/// <summary>
		/// 编号
        /// </summary>		
        public long Id { get; set; }
        
		/// <summary>
		/// 会员编号
        /// </summary>		
        public long MemberId { get; set; }
        
		/// <summary>
		/// 订单编号
        /// </summary>		
        public long OrderId { get; set; }
        
		/// <summary>
		/// 产品编号
        /// </summary>		
        public long ProductId { get; set; }
        
		/// <summary>
		/// 报修图片1
        /// </summary>		
        public string Image1 { get; set; }
        
		/// <summary>
		/// 报修图片2
        /// </summary>		
        public string Image2 { get; set; }
        
		/// <summary>
		/// 报修图片3
        /// </summary>		
        public string Image3 { get; set; }
        
		/// <summary>
		/// 报修图片4
        /// </summary>		
        public string Image4 { get; set; }
        
		/// <summary>
		/// 报修图片5
        /// </summary>		
        public string Image5 { get; set; }
        
		/// <summary>
		/// 备注
        /// </summary>		
        public string Remark { get; set; }
        
		/// <summary>
		/// 联系人
        /// </summary>		
        public string Contact { get; set; }
        
		/// <summary>
		/// 电话
        /// </summary>		
        public string Phone { get; set; }
        
		/// <summary>
		/// 状态
        /// </summary>		
        public int Status { get; set; }
        
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