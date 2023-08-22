using System.IO;

namespace ChopperChopper.Services
{
    public static class DataManager
    {
        public static DirectoryInfo DatabaseInfo { get; set; } = Directory.CreateDirectory("Data");
        public static string FileName { get; set; } = "HighScore.txt";

        public static string FilePath { get => $"{DatabaseInfo.Name}/{FileName}"; }

        public static void GenerateDatabase()
        {
            StreamWriter sr = File.CreateText(FilePath);
            sr.Close();
        }

        public static int GetHighScore()
        {
            try { return int.Parse(File.ReadAllText(FilePath)); }
            catch { GenerateDatabase(); }

            return 0;
        }

        public static void UpdateHighScore(int score)
        {
            File.WriteAllText(FilePath, score.ToString());
        }
    }
}
