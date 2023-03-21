using System.Windows.Input;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Profiler
{
    public class HotkeyInfo
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public Key Key { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public ModifierKeys Modifiers { get; set; }

        protected bool Equals(HotkeyInfo other)
        {
            return Key == other.Key && Modifiers == other.Modifiers;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((HotkeyInfo)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((int)Key * 397) ^ (int)Modifiers;
            }
        }
    }
}