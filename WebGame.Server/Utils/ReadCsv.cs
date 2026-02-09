namespace WebGame.Server.Utils
{
    public static class ReadCsv
    {
        public delegate void ValueAction(string value, int x, int y);   
        public static void RunForEachValue(string path, ValueAction action)
        {
            string[] csvLines = System.IO.File.ReadAllLines(path);

            for (int y = 0; y < csvLines.Length; y++)
            {
                string[] values = csvLines[y].Split(',');
                for (int x = 0; x < values.Length; x++)
                {
                    action(values[x], x, y);
                }
            }
        }
    }
}