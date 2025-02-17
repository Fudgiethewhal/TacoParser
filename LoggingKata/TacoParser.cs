﻿namespace LoggingKata
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

            // If your array's Length is less than 3, something went wrong
            if (cells.Length < 3)
            {
                logger.LogWarning("less than three items. Incomplete data.");
                // Log error message and return null
                return null; 
            }

            // Done: Grab the latitude from your array at index 0
            // You're going to need to parse your string as a `double`
            // which is similar to parsing a string as an `int`

            var latitude = double.Parse(cells[0]);
           
            // Done: Grab the longitude from your array at index 1
            // You're going to need to parse your string as a `double`
            // which is similar to parsing a string as an `int`
            var longitude = double.Parse(cells[1]);
            
            // Done: Grab the name from your array at index 2
            var name = cells[2];

            // Done: Create a TacoBell class
            // that conforms to ITrackable
            
            // Done: Create an instance of the Point Struct
            // Done: Set the values of the point correctly (Latitude and Longitude) 
            var point = new Point();
            point.Latitude = latitude;
            point.Longitude = longitude;

            // Done: Create an instance of the TacoBell class
            // Done: Set the values of the class correctly (Name and Location)
            var TacoBell = new TacoBell();
            TacoBell.Name = name;
            TacoBell.Location = point;

            // TODO: Then, return the instance of your TacoBell class,
            // since it conforms to ITrackable

            return TacoBell;
        }
    }
}
