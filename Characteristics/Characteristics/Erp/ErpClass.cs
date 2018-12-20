using System;
using Characteristics.Class;
using Characteristics.erp.Util;

namespace Characteristics.erp
{
    public class ErpClass : Erp
    {
        private readonly Z_HH_ClassClient _sapClass;

        public ErpClass(ErpConnection connection) : base(connection)
        {
            _sapClass = new Z_HH_ClassClient();
            SetCredentials(_sapClass.ClientCredentials);
        }

        public ClassGetListResponse GetList(string classTypeNumber, GetList.Sing sing, GetList.Options options, string low, string high = "_")
        {
            var getList = new ClassGetList()
            {
                ClassSelection = new[]
                {
                    new Bapiclasssel()
                    {
                        Sign = Util.GetList.ToValue(sing),
                        Option = Util.GetList.ToValue(options),
                        ClassLow = low,
                        ClassHigh = high
                    }
                },
                Classtype_Imp = classTypeNumber
            };

            try
            {
                return _sapClass.ClassGetList(getList);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}