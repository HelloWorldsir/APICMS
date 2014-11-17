using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Employee
    {

        /// <summary>
        /// EmployeeID
        /// </summary>		
        private int _employeeid;
        public int EmployeeID
        {
            get { return _employeeid; }
            set { _employeeid = value; }
        }
        /// <summary>
        /// EmployeeName
        /// </summary>		
        private string _employeename;
        public string EmployeeName
        {
            get { return _employeename; }
            set { _employeename = value; }
        }
        /// <summary>
        /// EmployeeMark
        /// </summary>		
        private string _employeemark;
        public string EmployeeMark
        {
            get { return _employeemark; }
            set { _employeemark = value; }
        }

    }
}
