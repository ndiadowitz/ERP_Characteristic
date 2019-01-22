using System;
using System.Collections.Generic;
using System.Linq;
using Characteristics.CharactersiticWSDL;
using Characteristics.erp.Util;
using Characteristics.Erp.@object;
using Characteristics.Erp.Util;

namespace Characteristics.erp
{
    public class ErpCharacteristics : Erp
    {
        private readonly Z_HH_MT_CharacteristicClient _sapCharacteristic;

        public ErpCharacteristics(ErpConnection connection) : base(connection)
        {
            _sapCharacteristic = new Z_HH_MT_CharacteristicClient();
            SetCredentials(_sapCharacteristic.ClientCredentials);
        }

        public BapiServiceTransactionCommitResponse CommitChanges()
        {
            BapiServiceTransactionCommit bstc = new BapiServiceTransactionCommit();
            bstc.WAIT = " ";
            return _sapCharacteristic.BapiServiceTransactionCommit(bstc);
        }

        public BapiServiceTransactionRollbackResponse RollbackChanges()
        {
            return _sapCharacteristic.BapiServiceTransactionRollback(new BapiServiceTransactionRollback());
        }

        public void Close()
        {
            _sapCharacteristic.Close();
        }

        /// <summary>
        /// Simple search for Characteristic objects
        /// </summary>
        /// <param name="sign"><see cref="Util.GetList.Sign"/></param>
        /// <param name="options"><see cref="Util.GetList.Options"/></param>
        /// <param name="low">Lower value</param>
        /// <param name="high">Upper value or '_' for empty</param>
        /// <returns>List of Characteristics or <code>null</code> on error</returns>
        public CharacteristicGetListResponse GetList(GetList.Sign sign, GetList.Options options, string low, string high = "_")
        {
            var getList = new CharacteristicGetList
            {
                CharactRange = new[]
                {
                    new Bapicharactrangetable
                    {
                        Sign = Util.GetList.ToValue(sign),
                        Option = Util.GetList.ToValue(options),
                        Low = low,
                        High = high
                    }
                }
            };
            
                return _sapCharacteristic.CharacteristicGetList(getList);
        }

        /// <summary>
        /// Get detail of <see cref="Characteristic"/>
        /// </summary>
        /// <param name="characteristic"><see cref="Characteristic"/></param>
        /// <returns><see cref="CharacteristicGetDetailResponse"/></returns>
        public CharacteristicGetDetailResponse GetDetail(Characteristic characteristic)
        {
            var detail = new CharacteristicGetDetail()
            {
                CharactName = characteristic.Name
            };

            return _sapCharacteristic.CharacteristicGetDetail(detail);
        }

        /// <summary>
        /// Get longtext of Characteristic object
        /// </summary>
        /// <param name="characteristic"></param>
        /// <returns></returns>
        public CharacteristicGetLongTextResponse GetLongText(Characteristic characteristic)
        {
            var longText = new CharacteristicGetLongText()
            {
                CharactName = characteristic.Name
            };

            return _sapCharacteristic.CharacteristicGetLongText(longText);
        }

        public CharacteristicAddLongTextResponse AddLongText(Characteristic characteristic, LongTextHelper.Format format, string text)
        {
            Bapitline[] bapitline = new Bapitline[] {
            new Bapitline() {
                Tdline = text,
                Tdformat = LongTextHelper.ToValue(format)}
            };

            var longText = new CharacteristicAddLongText()
            {
                CharactName = characteristic.Name,
                LongText = bapitline
            };
            return _sapCharacteristic.CharacteristicAddLongText(longText);
        }

        public CharacteristicRemoveLongTextResponse RemoveLongText(Characteristic characteristic)
        {
            var longtext = new CharacteristicRemoveLongText()
            {
                CharactName = characteristic.Name
            };
            return _sapCharacteristic.CharacteristicRemoveLongText(longtext);
        }

        public CharacteristicCreateResponse CreateCharacteristic(Characteristic characteristic)
        {
            var toCreate = new CharacteristicCreate()
            {
                CharactDetail = new Bapicharactdetail()
                {
                    CharactName = characteristic.Name,
                    DataType = characteristic.DataType,
                    Length = characteristic.Length,
                    Decimals = characteristic.Decimals,
                    Status = characteristic.Status.ToString()

                },
                CharactDescr = new Bapicharactdescr[]
                {
                    new Bapicharactdescr()
                    {
                        Description = characteristic.Description,
                        LanguageIso = "DE"
                    }
                }
            };

            if (characteristic.DataType.Equals("CHAR"))
            {
                toCreate.CharactValuesChar = new Bapicharactvalueschar[]
                {
                    new Bapicharactvalueschar()
                    {
                        ValueChar = characteristic.Value,
                        DefaultValue = ""
                    }
                };
            }

                return _sapCharacteristic.CharacteristicCreate(toCreate);
            

        }

        public CharacteristicDeleteResponse DeleteCharacteristic(Characteristic characteristic)
        {
            var toDelete = new CharacteristicDelete()
            {
                CharactName = characteristic.Name
            };

            return _sapCharacteristic.CharacteristicDelete(toDelete);
        }
    }
}