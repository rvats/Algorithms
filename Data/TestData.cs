namespace Algorithms.Data
{
    class TestData
    {
        Dept[] d = new Dept[5];
        //d.Add(new Dept(1,"Information Technology"));
    }
    class Dept
    {
        private int _DeptID;
        public int DeptID
        {
            get
            {
                return _DeptID;
            }

            set
            {
                _DeptID = value;
            }
        }

        private string _DeptName;
        public string DeptName
        {
            get
            {
                return _DeptName;
            }

            set
            {
                _DeptName = value;
            }
        }

        public Dept(int id, string Name)
        {
            this.DeptID = id;
            this.DeptName = Name;
        }
    }
}
