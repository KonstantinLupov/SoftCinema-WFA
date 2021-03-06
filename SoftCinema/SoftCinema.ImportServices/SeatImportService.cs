﻿using System;
using System.Collections.Generic;
using SoftCinema.DTOs;
using SoftCinema.Services;
using SoftCinema.Services.Utilities;
using SoftCinema.Services.Utilities.Validators;

namespace ImportServices
{
    public static class SeatImportService
    {
        public static void ImportSeats(IEnumerable<SeatDto> seatsDtos)
        {
            foreach (var seatDto in seatsDtos)
            {
                try
                {
                    ImportSeat(seatDto);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    
                }
            }
        }

        private static void ImportSeat(SeatDto seatDto)
        {
            string cinemaTown = seatDto.CinemaTown;
            TownValidator.CheckTownExisting(cinemaTown);

            int townId = TownService.GetTownId(cinemaTown);
            string cinemaName = seatDto.CinemaName;
            CinemaValidator.CheckCinemaExisting(cinemaName,townId);

            int cinemaId = CinemaService.GetCinemaId(cinemaName, townId);
            byte auditoriumNumber = seatDto.AuditoriumNumber;
            AuditoriumValidator.CheckAuditoriumExists(auditoriumNumber,cinemaId,cinemaName);

            int auditoriumId = AuditoriumService.GetAuditoriumId(auditoriumNumber, cinemaId);
            int row = seatDto.Row;
            int number = seatDto.Number;
            SeatValidator.ValidateSeatDoesntExist(number,auditoriumId,auditoriumNumber);

            SeatService.AddSeat(number, row, auditoriumId);
            Console.WriteLine(string.Format(Constants.ImportSuccessMessages.SeatAddedSuccess,number,auditoriumNumber,cinemaName,cinemaTown));
        }
    }
}
