using System.Collections.Generic;
using System.Linq;
using Characteristics.Class;
using Bapiclasslist = Characteristics.Class.Bapiclasslist;

namespace Characteristics.Erp.@object
{
    /// <summary>
    /// Characteristic class for simpler working with <see cref="Bapiclasslist"/>.
    /// </summary>
    public class ClassMitK
    {
        /// <summary>
        /// Bapi object
        /// </summary>
        private Bapiclasslist Bapiclasslist { get; }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="bapiclasslist"><see cref="Bapiclasslist"/></param>
        public ClassMitK(Bapiclasslist bapiclasslist)
        {
            Bapiclasslist = bapiclasslist;
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
                    return Bapiclasslist.Classname;
                return _name;
            }
        }


        public static List<ClassMitK> ConvertToList(ClassGetListResponse data)
        {
            return data.ClassList.Select(t => new ClassMitK(t)).ToList();
        }

        public static string ConvertToString(ClassGetDetailResponse data)
        {
            var s = data.ClassStandard.StandardName;
            s += "\r\n" + data.ClassStandard.StandardNo;
            s += "\r\n" + data.ClassBasicData.Classgroup;

            return s;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}