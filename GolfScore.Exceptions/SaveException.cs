namespace GolfScore.Exceptions
{
    public class SaveException : BadRequestException
    {
        public SaveException(Dictionary<string, string> propertiesWithError)
       : base($"{BeautifyPropertyErrors(propertiesWithError)}") { }
        public SaveException(KeyValuePair<string, string> propertyError)
       : base($"{BeautifyPropertyError(propertyError)}") { }

        private static string BeautifyPropertyError(KeyValuePair<string, string> propertyError)
        {
            return $"{propertyError.Key} - {propertyError.Value}.";
        }

        private static string BeautifyPropertyErrors(Dictionary<string, string> propertiesWithError)
        {
            var returnString = string.Empty;
            foreach (var propertyError in propertiesWithError)
            {
                returnString.Concat($"{BeautifyPropertyError(propertyError)}, ");
            }
            returnString.Remove(returnString.Length - 2);
            returnString.Concat(".");
            return returnString;
        }
    }
}