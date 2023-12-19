using ConsoleTestApp.Models.Interfaces;

namespace ConsoleTestApp.Models.Implementations
{
    internal class StringValue : IStringValue
    {
        public StringValue(string key, int value)
        {
            Key = key;
            Value = value;
        }

        public string Key { get; set; }
        public int Value { get; set; }
    }
}
