﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftCinema.Models;

namespace SoftCinema.Client.Utilities.CustomTools
{
    class AuditoriumSeatsSchema : GroupBox
    {
        private Auditorium _Auditorium { get; set; }
        private int _seatCount { get; set; }

        public AuditoriumSeatsSchema(Auditorium auditorium, Point startingCoords,int width, int seatCount)
        {
            this._Auditorium = auditorium;
            this._seatCount = seatCount;
            this.Location = startingCoords;
            this.Size = new Size(width,300);
            this.BackColor = Color.LightSkyBlue;
            

            VisualizeSeats();
        }

        private void VisualizeSeats()
        {
            var maxRow = this._Auditorium.Seats.Max(s => s.Row);

            var rowLabelCoordinates = this.Location;
            var seatCoordinates = this.Location;

            var maxSeatsPerRow = 0;

            for (int row = 1; row <= maxRow; row++)
            {
                var seatsPerRow = _Auditorium.Seats.Count(s => s.Row == row);
                if (seatsPerRow > maxSeatsPerRow)
                {
                    maxSeatsPerRow = seatsPerRow;
                }

                Label rowLabel = new Label();
                rowLabel.Size = new Size(20,20);
                rowLabel.Text = row.ToString();
                rowLabel.Location = rowLabelCoordinates;
                this.Controls.Add(rowLabel);

                for (int col = 1; col <= seatsPerRow; col++)
                {
                    if (col == 1)
                    {
                        seatCoordinates.X = rowLabelCoordinates.X;
                    }
                    seatCoordinates.X += 30;

                    SeatButton seatButton = new SeatButton();
                    seatButton.Location = seatCoordinates;
                    seatButton.Text = col.ToString();

                    this.Controls.Add(seatButton);
                }

                //find max middle and split seats into two groups by leaving a space (Location.x)

                rowLabelCoordinates.Y += 30;
                seatCoordinates.Y += 30;
            }
        }

        //if seatCount of clicked buttons is reached -> make all buttons unclickable

    }
}