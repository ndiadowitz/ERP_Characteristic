using Characteristics.CharactersiticWSDL;

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
                if(_name == null)
                    return Bapicharactlist.Charactname;
                return _name;
            }
        }
    }
}