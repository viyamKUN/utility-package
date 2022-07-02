namespace Yurei.Sample
{
    using Utility.DataLoaders;

    public class CsvItem
    {
        private int _uid;
        [CSVProperty("uid")]
        public int Uid
        {
            get => _uid;
            set => _uid = value;
        }
        private string _name;
        [CSVProperty("name")]
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        private string _description;
        [CSVProperty("description")]
        public string Description
        {
            get => _description;
            set => _description = value;
        }

        public override string ToString()
        {
            return $"[{_uid}] {_name}: {_description}";
        }
    }

    [System.Serializable]
    public class JsonItem
    {
        [UnityEngine.SerializeField]
        private int uid;
        [UnityEngine.SerializeField]
        private string name;
        [UnityEngine.SerializeField]
        private string description;

        public override string ToString()
        {
            return $"[{uid}] {name}: {description}";
        }
    }
}
