using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Accounts_Users
    {

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
        /// UserName
        /// </summary>		
        private string _username;
        public string UserName
        {
            get { return _username; }
            set { _username = value; }
        }
        /// <summary>
        /// Password
        /// </summary>		
        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        /// <summary>
        /// NickName
        /// </summary>		
        private string _nickname;
        public string NickName
        {
            get { return _nickname; }
            set { _nickname = value; }
        }
        /// <summary>
        /// TrueName
        /// </summary>		
        private string _truename;
        public string TrueName
        {
            get { return _truename; }
            set { _truename = value; }
        }
        /// <summary>
        /// Sex
        /// </summary>		
        private string _sex;
        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }
        /// <summary>
        /// Phone
        /// </summary>		
        private string _phone;
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        /// <summary>
        /// Email
        /// </summary>		
        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
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
        /// DepartmentID
        /// </summary>		
        private string _departmentid;
        public string DepartmentID
        {
            get { return _departmentid; }
            set { _departmentid = value; }
        }
        /// <summary>
        /// Activity
        /// </summary>		
        private bool _activity;
        public bool Activity
        {
            get { return _activity; }
            set { _activity = value; }
        }
        /// <summary>
        /// UserType
        /// </summary>		
        private string _usertype;
        public string UserType
        {
            get { return _usertype; }
            set { _usertype = value; }
        }
        /// <summary>
        /// Style
        /// </summary>		
        private int _style;
        public int Style
        {
            get { return _style; }
            set { _style = value; }
        }
        /// <summary>
        /// User_iCreator
        /// </summary>		
        private int _user_icreator;
        public int User_iCreator
        {
            get { return _user_icreator; }
            set { _user_icreator = value; }
        }
        /// <summary>
        /// User_dateCreate
        /// </summary>		
        private DateTime _user_datecreate;
        public DateTime User_dateCreate
        {
            get { return _user_datecreate; }
            set { _user_datecreate = value; }
        }
        /// <summary>
        /// User_dateValid
        /// </summary>		
        private DateTime _user_datevalid;
        public DateTime User_dateValid
        {
            get { return _user_datevalid; }
            set { _user_datevalid = value; }
        }
        /// <summary>
        /// User_dateExpire
        /// </summary>		
        private DateTime _user_dateexpire;
        public DateTime User_dateExpire
        {
            get { return _user_dateexpire; }
            set { _user_dateexpire = value; }
        }
        /// <summary>
        /// User_iApprover
        /// </summary>		
        private int _user_iapprover;
        public int User_iApprover
        {
            get { return _user_iapprover; }
            set { _user_iapprover = value; }
        }
        /// <summary>
        /// User_dateApprove
        /// </summary>		
        private DateTime _user_dateapprove;
        public DateTime User_dateApprove
        {
            get { return _user_dateapprove; }
            set { _user_dateapprove = value; }
        }
        /// <summary>
        /// User_iApproveState
        /// </summary>		
        private int _user_iapprovestate;
        public int User_iApproveState
        {
            get { return _user_iapprovestate; }
            set { _user_iapprovestate = value; }
        }
        /// <summary>
        /// User_cLang
        /// </summary>		
        private string _user_clang;
        public string User_cLang
        {
            get { return _user_clang; }
            set { _user_clang = value; }
        }        
    }
}
