//*******************************
// Create By Rocher Kong 
// Date 2016-04-20 00:26
//*******************************

using System; 

namespace RShop.TradingCenter.Entity{
		/// <summary>
 	///T_Province
 	/// </summary>	
		[Serializable]
	public class T_Province
	{
      	/// <summary>
		/// Id
        /// </summary>		
        public int Id { get; set; }
        
		/// <summary>
		/// ProvinceName
        /// </summary>		
        public string ProvinceName { get; set; }
        
		/// <summary>
		/// ProvinceCode
        /// </summary>		
        public string ProvinceCode { get; set; }
        
		/// <summary>
		/// CountryId
        /// </summary>		
        public int CountryId { get; set; }
        
		/// <summary>
		/// CountryName
        /// </summary>		
        public string CountryName { get; set; }
        
		/// <summary>
		/// CountryCode
        /// </summary>		
        public string CountryCode { get; set; }
        
		   
	}
}