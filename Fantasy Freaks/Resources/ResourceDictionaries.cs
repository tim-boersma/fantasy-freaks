using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataAccess.GlobalConstants;

namespace Fantasy_Freaks
{
    class ResourceDictionaries
    {
        public static Dictionary<string, Bitmap> bannerSeason = new Dictionary<string, Bitmap>()
        {
            {"Arizona Cardinals", Properties.Resources.Cardinals },
            {"Atlanta Falcons", Properties.Resources.Falcons },
            {"Baltimore Ravens", Properties.Resources.Ravens },
            {"Buffalo Bills", Properties.Resources.Bills },
            {"Carolina Panthers", Properties.Resources.Panthers },
            {"Chicago Bears", Properties.Resources.Bears},
            {"Cincinnati Bengals", Properties.Resources.Bengals},
            {"Cleveland Browns", Properties.Resources.Browns },
            {"Dallas Cowboys", Properties.Resources.Cowboys },
            {"Denver Broncos", Properties.Resources.Broncos },
            {"Detroit Lions", Properties.Resources.Lions },
            {"Green Bay Packers", Properties.Resources.Packers },
            {"Houston Texans", Properties.Resources.Texans },
            {"Indianapolis Colts", Properties.Resources.Colts },
            {"Jacksonville Jaguars", Properties.Resources.Jaguars },
            {"Kansas City Chiefs", Properties.Resources.Chiefs },
            {"Oakland Raiders", Properties.Resources.Raiders },
            {"Los Angeles Chargers", Properties.Resources.Chargers },
            {"Los Angeles Rams", Properties.Resources.Rams },
            {"Miami Dolphins", Properties.Resources.Dolphins },
            {"Minnesota Vikings", Properties.Resources.Vikings },
            {"New England Patriots", Properties.Resources.Patriots },
            {"New Orleans Saints", Properties.Resources.Saints },
            {"New York Giants", Properties.Resources.Giants },
            {"New York Jets", Properties.Resources.Jets },
            {"Philadelphia Eagles", Properties.Resources.Eagles },
            {"Pittsburgh Steelers", Properties.Resources.Steelers },
            {"San Francisco 49ers", Properties.Resources.fourtyniners },
            {"Seattle Seahawks", Properties.Resources.Seahawks },
            {"Tampa Bay Buccaneers", Properties.Resources.Bucceneers },
            {"Tennessee Titans", Properties.Resources.Titans },
            {"Washington Redskins", Properties.Resources.Commanders }
        }; //sets the string of the team, and the string (image?) in the recourse folder equal to each other

        public static Dictionary<string, Color> labelSeason = new Dictionary<string, Color>()
        {
            {"Arizona Cardinals", Color.FromArgb(177,30,62)},
            {"Atlanta Falcons", Color.FromArgb(0,0,0) },
            {"Baltimore Ravens", Color.FromArgb(29,18,92) },
            {"Buffalo Bills", Color.FromArgb(0,52,141) },
            {"Carolina Panthers", Color.FromArgb(0,0,0) },
            {"Chicago Bears", Color.FromArgb(2,24,46) },
            {"Cincinnati Bengals", Color.FromArgb(251,79,20) },
            {"Cleveland Browns", Color.FromArgb(255,60,0) },
            {"Dallas Cowboys", Color.FromArgb(156,156,156) },
            {"Denver Broncos", Color.FromArgb(0,34,68) },
            {"Detroit Lions", Color.FromArgb(0,118,182) },
            {"Green Bay Packers", Color.FromArgb(32,55,49) },
            {"Houston Texans", Color.FromArgb(3,31,47) },
            {"Indianapolis Colts", Color.FromArgb(1,51,105) },
            {"Jacksonville Jaguars", Color.FromArgb(0,103,121) },
            {"Kansas City Chiefs", Color.FromArgb(227,24,55) }, 
            {"Oakland Raiders", Color.FromArgb(169,169,169) },
            {"Los Angeles Chargers", Color.FromArgb(0,128,198) },
            {"Los Angeles Rams", Color.FromArgb(0,53,148) },
            {"Miami Dolphins", Color.FromArgb(1,144,158) },
            {"Minnesota Vikings", Color.FromArgb(79,38,131) },
            {"New England Patriots", Color.FromArgb(122,122,122) },
            {"New Orleans Saints", Color.FromArgb(37,37,37) },
            {"New York Giants", Color.FromArgb(9,32,103) },
            {"New York Jets", Color.FromArgb(17,87,64) },
            {"Philadelphia Eagles", Color.FromArgb(3,75,77) },
            {"Pittsburgh Steelers", Color.FromArgb(0,0,0) },
            {"San Francisco 49ers", Color.FromArgb(170,0,0) },
            {"Seattle Seahawks", Color.FromArgb(84,185,87) },
            {"Tampa Bay Buccaneers", Color.FromArgb(31,31,31) },
            {"Tennessee Titans", Color.FromArgb(0,41,91) },
            {"Washington Redskins", Color.FromArgb(90,20,20) }
        }; //takes in location of label in season then sets it equal to that rgb value
    }
}
