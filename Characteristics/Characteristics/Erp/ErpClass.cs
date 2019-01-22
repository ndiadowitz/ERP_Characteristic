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

        public BapiServiceTransactionCommitResponse CommitChanges()
        {
            var bstc = new BapiServiceTransactionCommit
            {
                WAIT = " "
            };
            return _sapClass.BapiServiceTransactionCommit(bstc);
        }

        public BapiServiceTransactionRollbackResponse RollbackChanges()
        {
            return _sapClass.BapiServiceTransactionRollback(new BapiServiceTransactionRollback());
        }

        public void Close()
        {
            _sapClass.Close();
        }

        public ClassGetListResponse GetList(string classTypeNumber, GetList.Sign sign, GetList.Options options, string low, string high = "_")
        {
            var getList = new ClassGetList()
            {
                ClassSelection = new[]
                {
                    new Bapiclasssel()
                    {
                        Sign = Util.GetList.ToValue(sign),
                        Option = Util.GetList.ToValue(options),
                        ClassLow = low,
                        ClassHigh = high
                    }
                },
                Classtype_Imp = classTypeNumber
            };

                return _sapClass.ClassGetList(getList);
        }

        /// <summary>
        /// Create new class
        /// </summary>
        /// <param name="ClassType">Type of Class</param>
        /// <param name="ClassNum">Class name</param>
        /// <param name="LangiIso">Iso language representation</param>
        /// <param name="Description">Class description</param>
        /// <returns>Success message or <code>null</code> on error</returns>
        public ClassCreateResponse Create(string ClassType, string ClassNum, string LanguIso, string Description)
        {
            var NeueKlasse = new ClassCreate()
            {
                ClassTypeNew = ClassType,
                ClassNumNew = ClassNum,
                ClassDescriptions = new Bapi1003Catch[] { new Bapi1003Catch() {LanguIso = LanguIso, Catchword = Description} }
            };
                return _sapClass.ClassCreate(NeueKlasse);
        }

        /// <summary>
        /// Get detailed info of specified class
        /// </summary>
        /// <param name="ClassType">Type of Class</param>
        /// <param name="ClassNum">Class name</param>
        /// <returns>Detailed information of a specified Class or <code>null</code> on error</returns>
        public ClassGetDetailResponse GetDetail(string ClassType, string ClassNum)
        {
            var Detail = new ClassGetDetail()
            {
                ClassType = ClassType,
                ClassNum = ClassNum
            };

                return _sapClass.ClassGetDetail(Detail);

        }

        /// <summary>
        /// Get Class information about Characteristics
        /// </summary>
        /// <param name="ClassType">Type of Class</param>
        /// <param name="ClassNum">Class name</param>
        /// <returns>Characteristic of a specified Class or <code>null</code> on error</returns>
        public ClassGetCharacteristicsResponse GetCharacteristics(string ClassType, string ClassNum)
        {
            var Charact = new ClassGetCharacteristics()
            {
                ClassType = ClassType,
                ClassNum = ClassNum
            };
                return _sapClass.ClassGetCharacteristics(Charact);
        }

        /// <summary>
        /// Change class information(description only)
        /// </summary>
        /// <param name="ClassType">Type of Class</param>
        /// <param name="ClassNum">Class name</param>
        /// <param name="Description">Old description from Class</param>
        /// <param name="LanguIso">Old Iso language representation from Class</param>
        /// <param name="DescriptionNew">New description of Class</param>
        /// <param name="LanguIsoNew">New Iso language representation of Class</param>
        /// <returns>Success message or <code>null</code> on error</returns>
        public ClassChangeResponse Change(string ClassType, string ClassNum, string Description, string LanguIso, string DescriptionNew, string LanguIsoNew)
        {
            var Change = new ClassChange
            {
                ClassType = ClassType,
                ClassNum = ClassNum,
                ClassDescriptions = new Bapi1003Catch[] {new Bapi1003Catch { Catchword = Description, LanguIso = LanguIso} },
                ClassDescriptionsNew = new Bapi1003CatchNew[] {new Bapi1003CatchNew {Catchword = DescriptionNew, LanguIso = LanguIsoNew} },
            };

                return _sapClass.ClassChange(Change);
        }

        /// <summary>
        /// Delete specified Class
        /// </summary>
        /// <param name="ClassType">Type of Class</param>
        /// <param name="ClassNum">Class name</param>
        /// <returns>Success message or <code>null</code> on error</returns>
        public ClassDeleteResponse Delete(string ClassType, string ClassNum)
        {
            var Delete = new ClassDelete
            {
                ClassType = ClassType,
                ClassNum = ClassNum
            };
                return _sapClass.ClassDelete(Delete);
        }
    }
}