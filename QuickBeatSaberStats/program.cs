using System.IO;
using System.Linq;
using System.Runtime.Remoting.Lifetime;

namespace QuickBeatSaberStats
{
    internal class program
    {
        public static AllSongs loadAllSongs(string filePath)
        {
            int directoryCount = Directory.GetDirectories(filePath).Length;
            SongInfo[] songInfoArray = new SongInfo[directoryCount];
            AllSongs allSongs;

            for (int i = 0; i < directoryCount; i++)
            {
                string[] subDirectories = Directory.GetDirectories(filePath);
                if (subDirectories.Length > 0)
                {
                    string songFolder = subDirectories[i];
                    songInfoArray[i] = GetSingleSongInfo(songFolder);
                }
            }
            allSongs.directoryCount = directoryCount;
            allSongs.Info = songInfoArray;
            return allSongs;
        }

        public static SongInfo GetSingleSongInfo(string songPath)
        {
            StreamReader readFile = new StreamReader(songPath + "\\info.dat");
            string fileContent = readFile.ReadToEnd();
            fileContent = fileContent.Replace("\n", string.Empty);
            fileContent = fileContent.Replace("\r", string.Empty);
            fileContent = fileContent.Replace("\t", string.Empty);

            SongInfo data;
            data.Name = SmallFunctionLibrary.SongName(fileContent);
            data.SubName = SmallFunctionLibrary.SongSubName(fileContent);
            data.Author = SmallFunctionLibrary.SongAuthor(fileContent);
            data.Mapper = SmallFunctionLibrary.SongMapper(fileContent);
            data.BPM = SmallFunctionLibrary.SongBPM(fileContent);

            return data;
        }
    }
}
