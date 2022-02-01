namespace cSharpYoloLibrary
{
    public static class Invert
    {
        //to test invert method change the text to toher plain text you wish
        public static string textToInvert = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

        public static async Task<string> invertPlainText()
        {
            await Task.Delay(1000);

            char[] array = textToInvert.ToCharArray();
            Array.Reverse(array);
            return new String(array);
        }
        public static async Task<string> invertPlainText(string text)
        {
            await Task.Delay(1000);

            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return new String(array);
        }
    }

}