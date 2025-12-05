namespace nutritionist
{
    public class RawMaterialOption
    {
        public RawMaterialOption(int rawId, string rawName, string purchaseUnit)
        {
            RawId = rawId;
            RawName = rawName;
            PurchaseUnit = purchaseUnit;
        }

        public int RawId { get; }
        public string RawName { get; }
        public string PurchaseUnit { get; }

        public override string ToString()
        {
            return string.IsNullOrWhiteSpace(PurchaseUnit)
                ? $"{RawName} (ID: {RawId})"
                : $"{RawName} - {PurchaseUnit}";
        }
    }
}
