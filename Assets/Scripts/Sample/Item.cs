namespace Yurei.Sample
{
    public class Item
    {
        private string _uid;
        public string uid
        {
            get => _uid;
            set => _uid = value;
        }
        private string _name;
        public string name
        {
            get => _name;
            set => _name = value;
        }
        private string _description;
        public string description
        {
            get => _description;
            set => _description = value;
        }

        public override string ToString()
        {
            return $"[{_uid}] {_name}: {_description}";
        }
    }
}
