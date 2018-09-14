using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlertNameSpace
{
    class AlertClass
    {
        #region properties
        #endregion
        private IDictionary resultDictionary;

        public IDictionary GetResultDictionary()
        {
            return resultDictionary;
        }

        public void SetResultDictionary(IDictionary value)
        {
            resultDictionary = value;
        }
        #region class constructor
        public AlertClass()
        {   
        }
        #endregion
        #region object overrides
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
        #endregion
    }
}
