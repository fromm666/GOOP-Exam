﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tennis_exam.Classes;

namespace Tennis_exam
{
    public partial class MainWindow : Form
    {
        private void DataGridAddElement(DataGridView dataGrid, Player newPlayer)
        {
            int n = dataGrid.Rows.Add();

            dataGrid.Rows[n].Cells[0].Value = newPlayer;
            dataGrid.Rows[n].Cells[1].Value = newPlayer.FristName;
            dataGrid.Rows[n].Cells[2].Value = newPlayer.MiddleName;
            dataGrid.Rows[n].Cells[3].Value = newPlayer.LastName;
            dataGrid.Rows[n].Cells[4].Value = newPlayer.DateOfBirth;
            dataGrid.Rows[n].Cells[5].Value = newPlayer.CalcAge(newPlayer.DateOfBirth);
            dataGrid.Rows[n].Cells[6].Value = newPlayer.Nationality;
            dataGrid.Rows[n].Cells[7].Value = newPlayer.Gender;

            dataGrid.Rows[n].Cells[0].ValueType = typeof(Player);
            dataGrid.Rows[n].Cells[1].ValueType = typeof(string);
            dataGrid.Rows[n].Cells[2].ValueType = typeof(string);
            dataGrid.Rows[n].Cells[3].ValueType = typeof(string);
            dataGrid.Rows[n].Cells[4].ValueType = typeof(DateTime);
            dataGrid.Rows[n].Cells[5].ValueType = typeof(int);
            dataGrid.Rows[n].Cells[6].ValueType = typeof(Nationalities);
            dataGrid.Rows[n].Cells[7].ValueType = typeof(Genders);
        }

        private void DataGridAddElement(DataGridView dataGrid, Referee newReferee)
        {
            int n = dataGrid.Rows.Add();

            dataGrid.Rows[n].Cells[0].Value = newReferee;
            dataGrid.Rows[n].Cells[1].Value = newReferee.FristName;
            dataGrid.Rows[n].Cells[2].Value = newReferee.MiddleName;
            dataGrid.Rows[n].Cells[3].Value = newReferee.LastName;
            dataGrid.Rows[n].Cells[4].Value = newReferee.DateOfBirth;
            dataGrid.Rows[n].Cells[5].Value = newReferee.CalcAge(newReferee.DateOfBirth);
            dataGrid.Rows[n].Cells[6].Value = newReferee.Nationality;
            dataGrid.Rows[n].Cells[7].Value = newReferee.Gender;
            dataGrid.Rows[n].Cells[8].Value = newReferee.LicenseAcquired;
            dataGrid.Rows[n].Cells[9].Value = newReferee.LicenseLastRenewed;

            dataGrid.Rows[n].Cells[0].ValueType = typeof(Referee);
            dataGrid.Rows[n].Cells[1].ValueType = typeof(string);
            dataGrid.Rows[n].Cells[2].ValueType = typeof(string);
            dataGrid.Rows[n].Cells[3].ValueType = typeof(string);
            dataGrid.Rows[n].Cells[4].ValueType = typeof(DateTime);
            dataGrid.Rows[n].Cells[5].ValueType = typeof(int);
            dataGrid.Rows[n].Cells[6].ValueType = typeof(Nationalities);
            dataGrid.Rows[n].Cells[7].ValueType = typeof(Genders);
            dataGrid.Rows[n].Cells[8].ValueType = typeof(DateTime);
            dataGrid.Rows[n].Cells[9].ValueType = typeof(DateTime?);
        }

        private void DataGridAddElement(DataGridView dataGrid, GameMaster newGameMaster)
        {
            dataGrid.Rows[0].Cells[0].Value = newGameMaster;
            dataGrid.Rows[0].Cells[1].Value = newGameMaster.FristName;
            dataGrid.Rows[0].Cells[2].Value = newGameMaster.MiddleName;
            dataGrid.Rows[0].Cells[3].Value = newGameMaster.LastName;
            dataGrid.Rows[0].Cells[4].Value = newGameMaster.DateOfBirth;
            dataGrid.Rows[0].Cells[5].Value = newGameMaster.CalcAge(newGameMaster.DateOfBirth);
            dataGrid.Rows[0].Cells[6].Value = newGameMaster.Nationality;
            dataGrid.Rows[0].Cells[7].Value = newGameMaster.Gender;
            dataGrid.Rows[0].Cells[8].Value = newGameMaster.LicenseAcquired;
            dataGrid.Rows[0].Cells[9].Value = newGameMaster.LicenseLastRenewed;

            dataGrid.Rows[0].Cells[0].ValueType = typeof(GameMaster);
            dataGrid.Rows[0].Cells[1].ValueType = typeof(string);
            dataGrid.Rows[0].Cells[2].ValueType = typeof(string);
            dataGrid.Rows[0].Cells[3].ValueType = typeof(string);
            dataGrid.Rows[0].Cells[4].ValueType = typeof(DateTime);
            dataGrid.Rows[0].Cells[5].ValueType = typeof(int);
            dataGrid.Rows[0].Cells[6].ValueType = typeof(Nationalities);
            dataGrid.Rows[0].Cells[7].ValueType = typeof(Genders);
            dataGrid.Rows[0].Cells[8].ValueType = typeof(DateTime);
            dataGrid.Rows[0].Cells[9].ValueType = typeof(DateTime?);
        }

        private void DataGridAddElement(DataGridView dataGrid, Game newGame)
        {
            int n = dataGrid.Rows.Add();

            if (tournament.TournamentType == TournamentTypes.SingleMale || tournament.TournamentType == TournamentTypes.SingleFemale)
            {
                dataGrid.Rows[n].Cells[0].Value = newGame;
                dataGrid.Rows[n].Cells[1].Value = newGame.GameWinner[0].FullName;
                dataGrid.Rows[n].Cells[2].Value = newGame.GameLoser[0].FullName;
                dataGrid.Rows[n].Cells[3].Value = newGame.DisplayableResult;
                dataGrid.Rows[n].Cells[4].Value = tournament.Round;

                dataGrid.Rows[n].Cells[0].ValueType = typeof(Game);
                dataGrid.Rows[n].Cells[1].ValueType = typeof(string);
                dataGrid.Rows[n].Cells[2].ValueType = typeof(string);
                dataGrid.Rows[n].Cells[3].ValueType = typeof(string);
                dataGrid.Rows[n].Cells[3].ValueType = typeof(int);
            }
            else
            {
                dataGrid.Rows[n].Cells[0].Value = newGame;
                dataGrid.Rows[n].Cells[1].Value = newGame.GameWinner[0].FullName + " & " + newGame.GameWinner[1].FullName;
                dataGrid.Rows[n].Cells[2].Value = newGame.GameLoser[0].FullName + " & " + newGame.GameLoser[1].FullName;
                dataGrid.Rows[n].Cells[3].Value = newGame.DisplayableResult;
                dataGrid.Rows[n].Cells[4].Value = tournament.Round;

                dataGrid.Rows[n].Cells[0].ValueType = typeof(Game);
                dataGrid.Rows[n].Cells[1].ValueType = typeof(string);
                dataGrid.Rows[n].Cells[2].ValueType = typeof(string);
                dataGrid.Rows[n].Cells[3].ValueType = typeof(string);
                dataGrid.Rows[n].Cells[3].ValueType = typeof(int);
            }
        }

        private void PopulateDataGridView(DataGridView dataGrid, Player[] players)
        {
            foreach (Player player in players)
            {
                if (player != null)
                {
                    DataGridAddElement(dataGrid, player);
                }
            }
        }

        private void PopulateDataGridView(DataGridView dataGrid, Referee[] referees)
        {
            foreach (Referee referee in referees)
            {
                if (referee != null)
                {
                    DataGridAddElement(dataGrid, referee);
                }
            }
        }

        private void PopulateDataGridView(DataGridView dataGrid, Game[] games)
        {
            foreach (Game game in games)
            {
                if (game != null)
                {
                    DataGridAddElement(dataGrid, game);
                }
            }
        }

    }
}
