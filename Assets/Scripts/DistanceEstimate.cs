using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets
{
    class DistanceEstimate
    {
        public float getDistanceEstimate (string phoneType, float imgHeight, float objHeight) {
            // float focalLength = getPhoneFocalLength(phoneType);
            float focalLength = getPhoneFocalLength("6");
            float sensorHeight = 4.8F; // mm
            float realHeight = 890; // mm; about 35 in

            float distancemm = (focalLength * realHeight * imgHeight) / (objHeight * sensorHeight);
            return distancemm;
        }

        private float getBoxHeight(float y1, float y2) {
            return Math.Abs(y1 - y2);
        }

        private float getPhoneFocalLength(string phoneType) {
            // Returns focal length for camera of given type
            Dictionary<string, float> focalLengthDict = new Dictionary<string, float>
            // Apple iPhone
                { {"2G", 37F},
                { "3GS", 37F },
                { "4", 30F },
                { "4S", 35F},
                { "5", 33F},
                { "5S", 29F },
                { "5C", 33F },
                { "6", 29F},
                { "6S", 29F},
                { "6+", 29F},
                { "6S+", 29F},
                { "7", 28F},
                { "7+", 28F},
                // Android- Vars
                // Samsung
                { "Note 3", 31F},
                { "Note 5", 28F},
                { "S5", 31F},
                { "S6", 27F },
                { "S7 Edge", 26F},
                { "S7", 26.6F},
                // Google
                { "Pixel", 28F},
                //Motorola
                { "Nexus", 28F}
            };
            return focalLengthDict[phoneType];
        }
    }
}