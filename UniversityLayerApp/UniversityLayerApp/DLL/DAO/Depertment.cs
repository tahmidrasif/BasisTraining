namespace UniversityLayerApp.DLL.DAO
{
    class Depertment
    {
        public int DepertmentID { get; set; }
        public string DepertmentName { get; set; }
        public string DepertmentCode { get; set; }

        public Depertment(string depertmentName, string depertmentCode):this()
        {
            
            DepertmentName = depertmentName;
            DepertmentCode = depertmentCode;
        }

        public Depertment()
        {
            
        }
    }
}
