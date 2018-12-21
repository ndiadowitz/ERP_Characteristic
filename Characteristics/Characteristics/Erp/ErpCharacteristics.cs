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