using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CustomErrors
{
    [Serializable]
    public class CustomSqlErrors : Exception
    {
        public string ExceptionDescription { get; set; }

        public CustomSqlErrors(int sqlExceptionId)
        {
            SetExceptionDescription(sqlExceptionId);
        }

        public void SetExceptionDescription(int id)
        {
            switch (id)
            {
                case (-1):
                    this.ExceptionDescription =
                        "An error has occurred while establishing a connection to the server.";
                    break;
                case (233):
                    this.ExceptionDescription =
                        "A connection was successfully established with the server, but then an error occurred during the login process.";
                    break;
                case (511):
                    this.ExceptionDescription =
                        "Cannot create a row of a size which is greater than the allowable maximum row size.";
                    break;
                case (1204):
                    this.ExceptionDescription =
                        "The instance of the SQL Server Database Engine cannot obtain a LOCK resource at this time. " +
                        "Rerun your statement when there are fewer active users.";
                    break;
                default:
                    this.ExceptionDescription = "Unknown error";
                    break;
            }      
        }
    }
}
