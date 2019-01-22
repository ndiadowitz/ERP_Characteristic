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
            var bstc = new BapiServiceTransactionCommit
            {
                WAIT = " "
            };
            return _sapCharacteristic.BapiServiceTransactionCommit(bstc);
        }

        public BapiServiceTransactionRollbackResponse RollbackChanges()
        {
            return _sapCharacteristic.BapiServiceTransactionRollback(new BapiServiceTransactionRollback());
        }

        /// <summary>
        /// Simple search for Characteristic objects
        /// </summary>
        /// <param name="sing"><see cref="Util.GetList.Sing"/></param>
        /// <param name="options"><see cref="Util.GetList.Options"/></param>
        /// <param name="low">Lower value</param>
        /// <param name="high">Upper value or '_' for empty</param>
        /// <returns>List of Characteristics or <code>null</code> on error</returns>
        public List<Characteristic> GetList(GetList.Sing sing, GetList.Options options, string low, string high = "_")
        {
            var getList = new CharacteristicGetList
            {
                CharactRange = new[]
                {
                    new Bapicharactrangetable
                    {
                        Sign = Util.GetList.ToValue(sing),
                        Option = Util.GetList.ToValue(options),
                        Low = low,
                        High = high
                    }
                }
            };

            try
            {
                var data = _sapCharacteristic.CharacteristicGetList(getList);

                return data.CharactList.Select(bapicharactlist => new Characteristic(bapicharactlist)).ToList();
            }
            catch (Exception)
            {
                return null;
            }
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

            try
            {
                return _sapCharacteristic.CharacteristicGetDetail(detail);
            }
            catch (Exception)
            {
                return null;
            }
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

            try
            {
                return _sapCharacteristic.CharacteristicGetLongText(longText);
            }
            catch (Exception)
            {
                return null;
            }
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
                    Decimals = characteristic.Decimals

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

            return _sapCharacteristic.CharacteristicCreate(toCreate);
        }

        public CharacteristicDeleteResponse DeleteCharacteristic(Characteristic characteristic)
        {
            var toDelete = new CharacteristicDelete();

            return _sapCharacteristic.CharacteristicDelete(toDelete);
        }
    }
}