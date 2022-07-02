namespace Yurei.Utility.DataLoaders
{
    [System.AttributeUsage(System.AttributeTargets.Property)]
    public class CSVPropertyAttribute : System.Attribute
    {
        private string propertyName;
        public string PropertyName
        {
            get => propertyName;
        }
        public CSVPropertyAttribute(string name)
        {
            propertyName = name;
        }
    }
}
