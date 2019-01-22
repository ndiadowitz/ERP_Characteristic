using Characteristics.CharactersiticWSDL;
using System.Collections.Generic;
using System.Linq;

namespace Characteristics.Erp.@object
{
    /// <summary>
    /// Characteristic class for simpler working with <see cref="Bapicharactlist"/>.
    /// </summary>
    public class Characteristic
    {
        /// <summary>
        /// Bapi object
        /// </summary>
        private Bapicharactlist Bapicharactlist { get; }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="bapicharactlist"><see cref="Bapicharactlist"/></param>
        public Characteristic(Bapicharactlist bapicharactlist)
        {
            Bapicharactlist = bapicharactlist;
        }

        public Characteristic(string name, string dataType, string length, string decimals, string description)
        {
            _name = name;
            _dataType = dataType;
            _length = length;
            _decimals = decimals;
            Description = description;
        }

        /// <summary>
        /// Name of Bapi object
        /// Used by <see cref="Name"/>
        /// </summary>
        private string _name;

        /// <summary>
        /// Name of Bapi object.
        /// Set <see cref="Name"/> will not effect Bapi object.
        /// </summary>
        public string Name
        {
            set { _name = value; }
            get {
                if (_name == null)
                    return Bapicharactlist.Charactname;
                return _name;
            }
        }

        /// <summary>
        /// Data Type of Bapi object
        /// Used by <see cref="DataType"/> 
        /// </summary>
        private string _dataType;

        /// <summary>
        /// Data Type of Bapi object
        /// Set <see cref="DataType"/> will not effect Bapi object.
        /// </summary>
        public string DataType
        {
            set{ _dataType = value;}
            get {
                if (_dataType == null)
                    return Bapicharactlist.Datatype;
                return _dataType;
            }
        }

        /// <summary>
        /// Length of Bapi object if it is numeric
        /// Used by <see cref="Length"/> 
        /// </summary>
        private string _length;

        /// <summary>
        /// Length of Bapi object if it is numeric
        /// Set <see cref="Length"/> will not effect Bapi object.
        /// </summary>
        public string Length
        {
            set { _length = value; }
            get {
                if (_length == null)
                    return Bapicharactlist.Charactlength;
                return _length;
                
            }
        }

        /// <summary>
        /// Length of Bapi object deicmals if it is a floating point number
        /// Used by <see cref="Decimals"/> 
        /// </summary>
        private string _decimals;

        /// <summary>
        /// Length of Bapi object deicmals if it is a floating point number
        /// Set <see cref="Decimals"/> will not effect Bapi object.
        /// </summary>
        public string Decimals
        {
            set { _decimals = value; }
            get
            {
                if (_decimals == null)
                    return Bapicharactlist.Charactdecimals;
                return _decimals;
            }
        }

        public string Description
        {
            set;get;
        }

        public static List<Characteristic> ConvertToList(CharacteristicGetListResponse data)
        {
            return data.CharactList.Select(bapicharactlist => new Characteristic(bapicharactlist)).ToList();
        }
    }
}