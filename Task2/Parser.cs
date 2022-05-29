namespace Task2
{
    internal abstract class Parser
    {
        protected string[] data;
        protected abstract void GetPage();
        protected abstract void ParsePage();
        protected virtual void FilterData() { }
        protected virtual void SortData() { }
        public string[] Parse()
        {
            GetPage();
            ParsePage();
            FilterData();
            SortData();
            return data;
        }
    }
}
