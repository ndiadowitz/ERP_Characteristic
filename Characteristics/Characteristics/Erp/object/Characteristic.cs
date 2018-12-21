using Characteristics.CharactersiticWSDL;

namespace Characteristics.Erp.@object
{
    public class Characteristic
    {
        private Bapicharactlist Bapicharactlist { get; }
        
        public Characteristic(Bapicharactlist bapicharactlist)
        {
            Bapicharactlist = bapicharactlist;
        }

        private string _name;

        public string Name
        {
            set => _name = value;
            get => _name ?? Bapicharactlist.Charactname;
        }
    }
}