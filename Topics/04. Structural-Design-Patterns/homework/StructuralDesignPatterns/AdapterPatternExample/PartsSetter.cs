namespace AdapterPatternExample
{
    /// <summary>
    /// The class that will be converted to another class using a so-called adapter class.
    /// </summary>
    internal class PartsSetter
    {
        public int GetWheelsCount(string vehicleName)
        {
            switch (vehicleName.ToLower())
            {
                case "car":
                    return 4;
                case "truck":
                    return 8;
                case "motorcycle":
                    return 2;
                default:
                    return 0;
            }
        }

        public string GetRequiredLicense(string vehicleName)
        {
            switch (vehicleName.ToLower())
            {
                case "car":
                    return "B";
                case "motorcycle":
                    return "A";
                case "truck":
                    return "D";
                default:
                    return string.Empty;
            }
        }
    }
}
