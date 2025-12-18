namespace nutritionist
{
    public sealed class MenuAssignmentTarget
    {
        public MenuAssignmentTarget(int menuId, string displayName, string menuType)
        {
            MenuId = menuId;
            DisplayName = displayName ?? string.Empty;
            MenuType = menuType ?? string.Empty;
        }

        public int MenuId { get; }
        public string DisplayName { get; }
        public string MenuType { get; }

        public override string ToString()
        {
            return DisplayName;
        }
    }
}
