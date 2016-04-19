//*******************************
// Create By Rocher Kong 
// Date 2016-04-20 00:26
//*******************************

using System; 

namespace RShop.TradingCenter.Entity{
		/// <summary>
 	///T_District
 	/// </summary>	
		[Serializable]
	public class T_District
	{
      	/// <summary>
		/// Id
        /// </summary>		
        public int Id { get; set; }
        
		/// <summary>
		/// DistricName
        /// </summary>		
        public string DistricName { get; set; }
        
		/// <summary>
		/// DistrictCode
        /// </summary>		
        public string DistrictCode { get; set; }
        
		/// <summary>
		/// CityId
        /// </summary>		
        public int CityId { get; set; }
        
		/// <summary>
		/// 名称
        /// </summary>		
        public string CityName { get; set; }
        
		/// <summary>
		/// CityCode
        /// </summary>		
        public string CityCode { get; set; }
        
		/// <summary>
		/// 邮编
        /// </summary>		
        public string ZipCode { get; set; }
        
		/// <summary>
		/// 所属省份
        /// </summary>		
        public int ProvinceId { get; set; }
        
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