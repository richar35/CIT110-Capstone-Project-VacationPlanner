using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacationPlanner
{
    public class Expense
    {


        #region FIELDS

        
        private double _cost;
        private string _name;

        #endregion

        #region PROPERTIES

        public string Name
        {
           get { return _name; }
           set { _name = value; }
        }

       

        public double Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        #endregion

        #region CONSTRUCTORS

        public Expense()
        {

        }

        #endregion








    }
}
