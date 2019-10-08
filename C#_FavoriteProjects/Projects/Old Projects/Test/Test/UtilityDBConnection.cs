using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class UtilityDBConnection
    {
        private string filePath;
        private string connectionString;
        private string commandText;

        public string FilePath
        {
            get
            {
                return this.filePath;
            }
            set
            {
                this.filePath = value;
            }
        }

        public string ConnectionString
        {
            get
            {
                return this.connectionString;
            }
            set
            {
                this.filePath = value;
            }
        }


        public string CommandText
        {
            get
            {
                return this.commandText;
            }
            set
            {
                this.commandText = value;
            }
        }

        //  Constructor
        public UtilityDBConnection()
        {

        }

        //  ToString() Method
        public string ToString()
        {
            string aString = "";
            aString = aString + "File Path = " + FilePath + "\n";
            aString = aString + "Connection String = " + ConnectionString + "\n";
            aString = aString + "Command Text = " + CommandText + "\n";

            return aString;
        }

    }
}
