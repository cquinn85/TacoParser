namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();
        
        public ITrackable Parse(string line)
        {
            logger.LogInfo("Begin parsing");

            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
            var cells = line.Split(',');

            // If your array.Length is less than 3, something went wrong
            if (cells.Length < 3)
            {
                logger.LogError("Not enough info in this line.");
                return null; // TODO Implement
            }

            // grab the latitude from your array at index 0
            var lat = double.Parse(cells[0]);
            if(double.TryParse(cells[0], out lat) == false)
            {
                logger.LogError("Line doesn't have enough info");
                return null;
            }
            // Your going to need to parse your string as a `double`
            // which is similar to parsing a string as an `int`
            // grab the longitude from your array at index 1
            var longitude = double.Parse(cells[1]);
            if (double.TryParse(cells[1], out longitude) == false)
            {
                logger.LogError("Bad data. ");
            }
            // grab the name from your array at index 2
            var name = cells[2];
            if (cells[2] == null || cells[2].Length == 0)
            {
                logger.LogError("No location name found while parsing");
            }



            // DONE- You'll need to create a TacoBell class
            // that conforms to ITrackable



            // Then, you'll need an instance of the TacoBell class
            // With the name and point set correctly
            
            var point = new Point();
            point.Latitude = lat;
            point.Longitude = longitude;

            var tacoBell = new TacoBell();
            tacoBell.Name = name;
            tacoBell.Location = point;

            // Then, return the instance of your TacoBell class
            // Since it conforms to ITrackable


            return tacoBell;
        }
    }
}