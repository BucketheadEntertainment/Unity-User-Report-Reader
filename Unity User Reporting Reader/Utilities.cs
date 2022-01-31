namespace Unity_User_Reporting_Reader
{
    internal static class Utilities
    {
        /// <summary>
        /// Converts the base64 data to an image.
        /// </summary>
        /// <param name="data">The base64 data</param>
        internal static Image ConvertBase64ToImage(this string data)
        {
            // Convert base 64 string to byte[]
            byte[] imageBytes = Convert.FromBase64String(data);

            // Convert byte[] to Image
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                Image image = Image.FromStream(ms, true);
                return image;
            }
        }
    }
}
