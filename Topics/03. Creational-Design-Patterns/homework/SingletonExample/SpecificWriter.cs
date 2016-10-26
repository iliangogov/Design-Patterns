using System;

namespace SingletonExample
{
    public class SpecificWriter
    {
        private static SpecificWriter instance;

        internal SpecificWriter()
        {
        }

        public static SpecificWriter Instance
        {
            get
            {
                if (SpecificWriter.instance == null)
                {
                    SpecificWriter.instance = new SpecificWriter();
                }

                return SpecificWriter.instance;
            }
        }

        public void WriteTextToConsole(string text)
        {
            Console.WriteLine(text);
        }
    }
}
