﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftCinema.Models;
using SoftCinema.Services;
using SoftCinema.Services.Utilities;

namespace SoftCinema.Client.Forms.AdminForms.UserForms
{
    public partial class EditUserTicketsForm : Form
    {
        private User user;

        public EditUserTicketsForm(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        
        private void EditUserTicketsForm_Load(object sender, EventArgs e)
        {
            var tickets = TicketService.GetTicketsInfo(user.Username);
            TicketsList.DefaultCellStyle.Font = new Font("Tahoma", 12);


            if (tickets.Count == 0)
            {
                TicketsList.RowHeadersVisible = false;
                for (int i = 0; i < TicketsList.ColumnCount; i++)
                {

                    TicketsList.Columns[i].Visible = false;
                }
            }

            else
            {
                foreach (var ticket in tickets)
                {
                    System.Drawing.Image image = ImageProcessor.byteArrayToImage(ticket.Screening.Movie.Image.Content);
                    System.Drawing.Image resizedImage = (System.Drawing.Image) (new Bitmap(image, new Size(100, 120)));
                    string cinema = ticket.Screening.Auditorium.Cinema.Name + " " +
                                    ticket.Screening.Auditorium.Cinema.Town.Name;
                    string auditorium = ticket.Screening.Auditorium.Number.ToString();
                    string movie = ticket.Screening.Movie.Name + " - " + ticket.Screening.Movie.ReleaseYear;
                    string start = ticket.Screening.Start.ToString();
                    string seat = ticket.Seat.Number.ToString();
                    int seatId = ticket.SeatId;
                    int screeningId = ticket.ScreeningId;
                    this.TicketsList.Rows.Add(resizedImage, movie, cinema, auditorium, start, seat, seatId, screeningId);

                }
            }

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            UserDetailsForm userForm = new UserDetailsForm(user);
            userForm.TopLevel = false;
            userForm.AutoScroll = true;
            this.Hide();
            ((Button)sender).Parent.Parent.Controls.Add(userForm);
            userForm.Show();
        }

        private void TicketsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TicketsList.SelectedCells[0].RowIndex < 0)
            {
                return;
            }
            int selectedRow = TicketsList.SelectedCells[0].RowIndex;
            int holderId = user.Id;
            int seatId =int.Parse( TicketsList.Rows[selectedRow].Cells["SeatId"].Value.ToString());
            int screeningId = int.Parse(TicketsList.Rows[selectedRow].Cells["ScreeningId"].Value.ToString());
            Ticket ticket = TicketService.GetTicket(holderId,seatId,screeningId);
            EditTicketForm ticketForm = new EditTicketForm(user,ticket);
            ticketForm.TopLevel = false;
            ticketForm.AutoScroll = true;
            this.Hide();
            ((DataGridView)sender).Parent.Parent.Controls.Add(ticketForm);
            ticketForm.Show();
        }
    }
}
