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

namespace HW1
{
    public class Shipper
    {
        //Declaration
        private int shipperId = -1;
        private string companyName = "n/a";
        private string phone = "n/a";

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

        public override string ToString(){
            string aString = "";
            aString = aString + "Shipper ID = " + ShipperId + "\n";
            aString = aString + "Company Name = " + CompanyName + "\n";
            aString = aString + "Phone = " + Phone + "\n";
            
            return aString;
        }
            
    }
}
