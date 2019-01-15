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

        /// <summary>
        /// Create new class ###NICHT FERTIG???
        /// </summary>
        public ClassCreateResponse ClassCreate(string ClassType, string ClassNum, string LanguIso)
        {
            var NeueKlasse = new ClassCreate()
            {
                ClassTypeNew = ClassType,
                ClassNumNew = ClassNum,
                ClassDescriptions = new Bapi1003Catch[] { new Bapi1003Catch() {LanguIso = LanguIso} }
            };

            try
            {
                return _sapClass.ClassCreate(NeueKlasse);
            }
            catch(Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Get detailed info of specified class ###NICHT FERTIG???
        /// </summary>
        public ClassGetDetailResponse ClassGetDetail(string ClassType, string ClassNum)
        {
            var Detail = new ClassGetDetail()
            {
                ClassType = ClassType,
                ClassNum = ClassNum
            };

            try
            {
                return _sapClass.ClassGetDetail(Detail);
            }
            catch(Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// ??? ###NICHT FERTIG!!!
        /// </summary>
        public ClassGetCharacteristicsResponse ClassGetCharacteristics(string ClassType)
        {
            var Charact = new ClassGetCharacteristics()
            {
                ClassType = ClassType
            };

            try
            {
                return _sapClass.ClassGetCharacteristics(Charact);
            }
            catch(Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Change class information ###NICHT FERTIG!!!
        /// </summary>
        public ClassChangeResponse ClassChange()
        {
            var Change = new ClassChange
            {
                
            };

            try
            {
                return _sapClass.ClassChange(Change);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}