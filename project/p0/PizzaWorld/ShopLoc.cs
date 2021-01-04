using System;
using System.Device.Location;

namespace com.pizzaworld.Orders
{
 public class ShopLoc {
   
private static  const ShopLoc[] shops=new ShopLoc[] {{GeoCoordinate(30.44808173169618, -97.7775907537468), "13201 Pond Springs Rd, Austin,TX,"},
{GeoCoordinate(30.462835741074713, -97.79431521407562),  "13764 Research Blvd.,Austin, TX"},
{GeoCoordinate(30.478370819308882, -97.84066378310206), "2051 Cypress Creek Rd, Austin,TX"},
{GeoCoordinate(30.410865065440422, -97.74794697964288), "13201 Pond Springs Rd.,Austin,TX"},
{GeoCoordinate(30.374587595444964, -97.75539279191915), "13764 Research Blvd.,Austin, TX"},
{GeoCoordinate(30.374402471776506, -97.75569319931098), "8321 Mesa Drive, Austin,Tx"},
{GeoCoordinate(30.3925288,-97.7096198), "1910 W Braker Lane, Austin,TX"},
{GeoCoordinate(30.417793309676785, -97.8494359283286), "7900 N. FM 620 Austin, TX 78726"}
   };
  
      private GeoCoordinate latlong;
      private string streetAddr;
   }



}
