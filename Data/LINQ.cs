//namespace Algorithms.Data
//{
//    [Table(Name = "Department")]
//    public class Department
//    {
//        private string _DepartmentID;
//        [Column(IsPrimaryKey = true, Storage = "_DepartmentID")]
//        public string DepartmentID
//        {
//            get
//            {
//                return this._DepartmentID;
//            }
//            set
//            {
//                this._DepartmentID = value;
//            }
//        }

//        private string _DepartmentName;
//        [Column(Storage = "_DepartmentName")]
//        public string DepartmentName
//        {
//            get
//            {
//                return this._DepartmentName;
//            }
//            set
//            {
//                this._DepartmentName = value;
//            }
//        }

//    }

//    [Table(Name = "Employee")]
//    public class Employee
//    {
//        private string _EmployeeID;
//        [Column(IsPrimaryKey = true, Storage = "_EmployeeID")]
//        public string EmployeeNameID
//        {
//            get
//            {
//                return this._EmployeeID;
//            }
//            set
//            {
//                this._EmployeeID = value;
//            }
//        }

//        private string _EmployeeName;
//        [Column(Storage = "_EmployeeName")]
//        public string EmployeeName
//        {
//            get
//            {
//                return this._EmployeeName;
//            }
//            set
//            {
//                this._EmployeeName = value;
//            }
//        }
//    }
//}

//namespace Algorithms
//{
//    partial class DataClasses1DataContext
//    {
//    }
//}