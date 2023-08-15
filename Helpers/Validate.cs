namespace BookShop.helper
{
    internal static class Constants
    {   
        // validate empty stings and nulls
        public static bool validatestring(List<string> inputs){
            bool valid = false;

            foreach (var input in inputs)
            {
                if (string.IsNullOrWhiteSpace(input))
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        public static bool validateOptions(string? input, int start, int end){
            if (int.Parse(input) >= start && int.Parse(input) <= end)
            {
                return true;
            }
            else{
                Console.WriteLine("Invalid option, please try again.");
                return false;
            }
        }
    }
}