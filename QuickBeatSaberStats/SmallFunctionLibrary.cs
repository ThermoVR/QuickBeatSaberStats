using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickBeatSaberStats
{
    internal class SmallFunctionLibrary
    {
        public static string SongName(string fileContent)
        {
            string[] byLines = fileContent.Split('"');
            string name = "";
            int i = 0;
            while (byLines[i] != "_songSubName")
            {
                if (byLines[i] == "_songName")
                {
                    name = byLines[i + 2];
                }
                i++;
            }
            return name;
        }

        public static string SongSubName(string fileContent)
        {
            string[] byLines = fileContent.Split('"');
            string subName = "";
            int i = 0;
            while (byLines[i] != "_songAuthorName")
            {
                if (byLines[i] == "_songSubName")
                {
                    subName = byLines[i + 2];
                }
                i++;
            }
            return subName;
        }
        public static string SongAuthor(string fileContent)
        {
            string[] byLines = fileContent.Split('"');
            string author = "";
            int i = 0;
            while (byLines[i] != "_levelAuthorName")
            {
                if (byLines[i] == "_songAuthorName")
                {
                    author = byLines[i + 2];
                }
                i++;
            }
            return author;
        }
        public static string SongMapper(string fileContent)
        {
            string[] byLines = fileContent.Split('"');
            string mapper = "";
            int i = 0;
            while (byLines[i] != "_beatsPerMinute")
            {
                if (byLines[i] == "_levelAuthorName")
                {
                    mapper = byLines[i + 2];
                }
                i++;
            }
            return mapper;
        }

        public static int SongBPM(string fileContent)
        {
            string[] byLines = fileContent.Split('"');
            int bpm = 0;
            int i = 0;
            string bpmString = "";
            while (byLines[i] != "_shuffle")
            {
                if (byLines[i] == "_beatsPerMinute")
                {
                    bpmString = byLines[i + 1].Replace(',', ' ');
                    bpmString = bpmString.Replace(':', ' ');
                    bpmString = bpmString.Trim();
                    bpm = Convert.ToInt32(Convert.ToDouble(bpmString));
                }
                i++;
            }
            return bpm;
        }
    }
}
