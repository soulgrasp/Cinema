namespace Cinema.Helpers
{
    public static class MenuHelper
    {
        public const string Quit = "0";
        public const string AddVisitor = "1";
        public const string AddGroup = "2";
        public const string WordRepeater = "3";
        public const string ThirdWorder = "4";




        public static List<string> MenuCollection2Print()
        {
            //Todo byt till Enum
            List<string> menuTexts = new List<string>();
            menuTexts.Add("Quit");
            menuTexts.Add("AddVisitor");
            menuTexts.Add("AddGroup");
            menuTexts.Add("WordRepeater");
            menuTexts.Add("ThirdWorder");

            return menuTexts;
        }
    }
}
