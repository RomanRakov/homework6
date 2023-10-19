using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    abstract class war
    {
        private string name;
        private uint startyear;
        private uint endyear;
        private string losses;
        private uint participants;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public uint Startyear
        {
            get
            {
                return startyear;
            }
            set
            {
                startyear = value;
            }
        }
        public uint Endyear
        {
            get
            {
                return endyear;
            }
            set
            {
                endyear = value;
            }
        }
        public string Losses
        {
            get
            {
                return losses;
            }
            set
            {
                losses = value;
            }
        }
        public uint Participants
        {
            get
            {
                return participants;
            }
            set
            {
                participants = value;
            }
        }
    }
}
