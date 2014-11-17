using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    //Accounts_Log
    public class Accounts_Log
    {

        /// <summary>
        /// ID
        /// </summary>		
        private int _id;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        /// <summary>
        /// UserID
        /// </summary>		
        private int _userid;
        public int UserID
        {
            get { return _userid; }
            set { _userid = value; }
        }
        /// <summary>
        /// OperModuel
        /// </summary>		
        private string _opermoduel;
        public string OperModuel
        {
            get { return _opermoduel; }
            set { _opermoduel = value; }
        }
        /// <summary>
        /// ChildModuel
        /// </summary>		
        private string _childmoduel;
        public string ChildModuel
        {
            get { return _childmoduel; }
            set { _childmoduel = value; }
        }
        /// <summary>
        /// IP
        /// </summary>		
        private string _ip;
        public string IP
        {
            get { return _ip; }
            set { _ip = value; }
        }
        /// <summary>
        /// OperResult
        /// </summary>		
        private string _operresult;
        public string OperResult
        {
            get { return _operresult; }
            set { _operresult = value; }
        }

        private DateTime _opertime;

        public DateTime OperTime
        {
            get { return _opertime; }
            set { _opertime = value; }
        }

        private string _username;
        public string UserName {
            get { return _username; }
            set { _username = value; }
        }
    }
}
