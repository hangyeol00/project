namespace nutritionist
{
    public class FinalMenuOption
    {
        public FinalMenuOption(int finalMenuId, string menuCode, string menuName, string menuType)
        {
            FinalMenuId = finalMenuId;
            MenuCode = menuCode;
            MenuName = menuName;
            MenuType = menuType;
        }

        public int FinalMenuId { get; }
        public string MenuCode { get; }
        public string MenuName { get; }
        public string MenuType { get; }

        public string DisplayName
        {
            get
            {
                var typeSegment = string.IsNullOrWhiteSpace(MenuType)
                    ? string.Empty
                    : $" - {MenuType}";
                return $"{MenuName}{typeSegment}";
            }
        }

        public override string ToString()
        {
            return DisplayName;
        }
    }
}
