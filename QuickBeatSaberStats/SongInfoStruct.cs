using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickBeatSaberStats
{
    /// <summary>
    /// Sructure of all the song's main information
    /// </summary>
    struct SongInfo
    {
        /// <summary>
        /// Song Name
        /// </summary>
        public string Name;

        /// <summary>
        /// Song Subname
        /// </summary>
        public string SubName;

        /// <summary>
        /// Song's Author
        /// </summary>
        public string Author;

        /// <summary>
        /// Maps's mappers
        /// </summary>
        public string Mapper;

        /// <summary>
        /// BPM of the song
        /// </summary>
        public int BPM;
    }
}
