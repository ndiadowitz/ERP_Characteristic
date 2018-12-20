using System;
using Characteristics.CharactersiticWSDL;
using Characteristics.erp.Util;

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

        public CharacteristicGetListResponse GetList(GetList.Sing sing, GetList.Options options, string low, string high = "_")
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
                return _sapCharacteristic.CharacteristicGetList(getList);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}