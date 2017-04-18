﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftCinema.Client.Utilities.CustomTools;
using SoftCinema.Client.Utilities.CustomTools.Buttons.TeamButtons;

namespace SoftCinema.Client.Utilities.CustomSidebars
{
    class EmployeeSideBar : SideBar
    {
        public EmployeeSideBar() : base()
        {
            this.Buttons.AddRange(new List<TeamButton>()
            {
                new HomeTeamButton(),
                new ShowScreeningsTeamButton(),
                new RegisterMovieTeamButton(),
                new MoviesTeamButton()
            });

            this.VisualizeButtons();

        }
    }
}