using System;
using System.Collections.Generic;
using System.Linq;
using Characteristics.CharactersiticWSDL;
using Characteristics.erp.Util;
using Characteristics.Erp.@object;

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
                var data =  _sapCharacteristic.CharacteristicGetList(getList);

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
    }
}