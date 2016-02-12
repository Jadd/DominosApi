namespace DominosApi.Wrapper {
    public static class Utility {

        private static readonly string[] _regionCodes = {
            "", "ACT", "NSW", "NT", "QLD", "SA", "TAS", "VIC", "WA"
        };

        public static string GetRegionCode(LocalRegion region) {
            return _regionCodes[(int) region];
        }

    }
}
