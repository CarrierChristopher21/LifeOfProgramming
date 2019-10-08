/* Christopher Carrier
 * HW 1
 * 1/30/14
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection
{
    public class Shipper
    {
        /*      Information about Shipper Class
            This class receives the Shippers's data and then assigns the Shipper's data to a the specific variable
            within the class. Also, this class will test if the data is blank or not available.
            It also sets up the .ToString() format for this file for when its called.
        */
        //Declaration
        private int shipperId = -1;
        private string companyName = "n/a";
        private string phone = "n/a";
        private static int numberOfShippers = 0;
        
        //GETS AND SETS
        public int ShipperId
        {
            get
            {
                return this.shipperId;
            }
        }

        public string CompanyName
        {
            get
            {
                return this.companyName;
            }
            set
            {
                if(value.Length > 0)
                {
                    this.companyName = value;
                }
                else
                {
                    this.companyName = "n/a";
                }
            }
        }

        public string Phone
        {
            get
            {
                return this.phone;
            }
            set
            {
                if(value.Length > 0)
                {
                    this.phone = value;
                }
                else
                {
                    this.phone = "n/a";
                }
            }
        }

        //Constructors
        public Shipper()
        {
            Shipper.numberOfShippers++;
        }

        public Shipper(int anId, string acompanyName, string aphone)
            : this()
        {
            this.shipperId = anId;              // Do Not Capatilize the variable for anID
            this.CompanyName = acompanyName;    // Capatilize the rest of the this.variable's
            this.Phone = aphone;
        }
        
        public Shipper(int anId, string acompanyName)
            : this(anId, acompanyName, "n/a")
        {
            
        }

        public Shipper(int anId)
            : this(anId, "n/a", "n/a")
        {

        }

        public static int GetNumberOfShippers()
        {
            return Shipper.numberOfShippers;
        }

        public override string ToString(){
            string aString = "";
            aString = aString + "Shipper ID = " + ShipperId + "\n";
            aString = aString + "Company Name = " + CompanyName + "\n";
            aString = aString + "Phone = " + Phone + "\n";
            aString = aString + "Number Of Shippers = " + numberOfShippers + "\n";

            return aString;
        }            
    }
}
