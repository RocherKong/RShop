//*******************************
// Create By Rocher Kong 
// Date 2016-04-20 00:26
//*******************************

using System; 

namespace RShop.TradingCenter.Entity{
		/// <summary>
 	///T_Country
 	/// </summary>	
		[Serializable]
	public class T_Country
	{
      	/// <summary>
		/// Id
        /// </summary>		
        public int Id { get; set; }
        
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