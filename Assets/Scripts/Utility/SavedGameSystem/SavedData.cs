namespace Yurei.Utility.SavedGameSystem
{
    [System.Serializable]
    public class SavedData
    {
        private string _userName;
        public string UserName
        {
            get => _userName;
        }

        public SavedData(string userName)
        {
            _userName = userName;
        }
    }
}
