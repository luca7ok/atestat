using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace basketball_tournament
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ComboBox[] combo_list = new ComboBox[12];
        PictureBox[] picturebox_list = new PictureBox[12];
        string[] picture_list = new string[12];
        string[] team_list = new string[12];
        Label[] team_list2 = new Label[12];
        PictureBox[] picturebox_list2 = new PictureBox[12];
        Label[] player_game_list = new Label[10];
        NumericUpDown[] score_list = new NumericUpDown[10];
        Label[] win_list = new Label[12];
        Label[] lost_list = new Label[12];
        Label[] points_list = new Label[12];
        Label[] stats = new Label[12];
        Label[] stats2 = new Label[12];
        TabPage last_page;
        int[] quarterfinal_winnners = new int[4];
        int[] seminfinal_winners = new int[2];
        int final_winner;
        string[] player_names = new string[60];
        int[] points = new int[60];

        struct GroupStats
        {

            public int won, lost, points;
        };

        GroupStats[] group_stats = new GroupStats[12];
        void initialize_boxes()
        {
            combo_list[0] = comboBox1;
            combo_list[1] = comboBox2;
            combo_list[2] = comboBox3;
            combo_list[3] = comboBox4;
            combo_list[4] = comboBox5;
            combo_list[5] = comboBox6;
            combo_list[6] = comboBox7;
            combo_list[7] = comboBox8;
            combo_list[8] = comboBox9;
            combo_list[9] = comboBox10;
            combo_list[10] = comboBox11;
            combo_list[11] = comboBox12;

            picturebox_list[0] = pictureBox7;
            picturebox_list[1] = pictureBox8;
            picturebox_list[2] = pictureBox9;
            picturebox_list[3] = pictureBox10;
            picturebox_list[4] = pictureBox11;
            picturebox_list[5] = pictureBox12;
            picturebox_list[6] = pictureBox13;
            picturebox_list[7] = pictureBox14;
            picturebox_list[8] = pictureBox15;
            picturebox_list[9] = pictureBox16;
            picturebox_list[10] = pictureBox17;
            picturebox_list[11] = pictureBox18;

            player_game_list[0] = player1_label;
            player_game_list[1] = player2_label;
            player_game_list[2] = player3_label;
            player_game_list[3] = player4_label;
            player_game_list[4] = player5_label;
            player_game_list[5] = player6_label;
            player_game_list[6] = player7_label;
            player_game_list[7] = player8_label;
            player_game_list[8] = player9_label;
            player_game_list[9] = player10_label;

            score_list[0] = score1;
            score_list[1] = score2;
            score_list[2] = score3;
            score_list[3] = score4;
            score_list[4] = score5;
            score_list[5] = score6;
            score_list[6] = score7;
            score_list[7] = score8;
            score_list[8] = score9;
            score_list[9] = score10;

            picturebox_list2[0] = picTeam1;
            picturebox_list2[1] = picTeam2;
            picturebox_list2[2] = picTeam3;
            picturebox_list2[3] = picTeam4;
            picturebox_list2[4] = picTeam5;
            picturebox_list2[5] = picTeam6;
            picturebox_list2[6] = picTeam7;
            picturebox_list2[7] = picTeam8;
            picturebox_list2[8] = picTeam9;
            picturebox_list2[9] = picTeam10;
            picturebox_list2[10] = picTeam11;
            picturebox_list2[11] = picTeam12;

            team_list2[0] = team1_mainlabel;
            team_list2[1] = team2_mainlabel;
            team_list2[2] = team3_mainlabel;
            team_list2[3] = team4_mainlabel;
            team_list2[4] = team5_mainlabel;
            team_list2[5] = team6_mainlabel;
            team_list2[6] = team7_mainlabel;
            team_list2[7] = team8_mainlabel;
            team_list2[8] = team9_mainlabel;
            team_list2[9] = team10_mainlabel;
            team_list2[10] = team11_mainlabel;
            team_list2[11] = team12_mainlabel;

            win_list[0] = win_label1;
            win_list[1] = win_label2;
            win_list[2] = win_label3;
            win_list[3] = win_label4;
            win_list[4] = win_label5;
            win_list[5] = win_label6;
            win_list[6] = win_label7;
            win_list[7] = win_label8;
            win_list[8] = win_label9;
            win_list[9] = win_label10;
            win_list[10] = win_label11;
            win_list[11] = win_label12;

            lost_list[0] = lost_label1;
            lost_list[1] = lost_label2;
            lost_list[2] = lost_label3;
            lost_list[3] = lost_label4;
            lost_list[4] = lost_label5;
            lost_list[5] = lost_label6;
            lost_list[6] = lost_label7;
            lost_list[7] = lost_label8;
            lost_list[8] = lost_label9;
            lost_list[9] = lost_label10;
            lost_list[10] = lost_label11;
            lost_list[11] = lost_label12;


            points_list[0] = points_label1;
            points_list[1] = points_label2;
            points_list[2] = points_label3;
            points_list[3] = points_label4;
            points_list[4] = points_label5;
            points_list[5] = points_label6;
            points_list[6] = points_label7;
            points_list[7] = points_label8;
            points_list[8] = points_label9;
            points_list[9] = points_label10;
            points_list[10] = points_label11;
            points_list[11] = points_label12;

            stats[0] = label13;
            stats[1] = label14;
            stats[2] = label15;
            stats[3] = label16;
            stats[4] = label17;
            stats[5] = label18;
            stats[6] = label19;
            stats[7] = label20;
            stats[8] = label21;
            stats[9] = label22;
            stats[10] = label23;
            stats[11] = label24;

            stats2[0] = stat2_label1;
            stats2[1] = stat2_label2;
            stats2[2] = stat2_label3;
            stats2[3] = stat2_label4;
            stats2[4] = stat2_label5;
            stats2[5] = stat2_label6;
            stats2[6] = stat2_label7;
            stats2[7] = stat2_label8;
            stats2[8] = stat2_label9;
            stats2[9] = stat2_label10;
            stats2[10] = stat2_label11;
            stats2[11] = stat2_label12;

        }


        private void tEAMSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tEAMSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tournamentDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.sTATISTICSTableAdapter.Fill(this.tournamentDataSet.STATISTICS);
            this.rEGISTERSTableAdapter.Fill(this.tournamentDataSet.REGISTERS);
            this.gAMESTableAdapter.Fill(this.tournamentDataSet.GAMES);
            this.pLAYERSTableAdapter.Fill(this.tournamentDataSet.PLAYERS);
            this.tEAMSTableAdapter.Fill(this.tournamentDataSet.TEAMS);

            tournamentDataSet.EnforceConstraints = false;

            DataTable dt = tournamentDataSet.TEAMS;

            initialize_boxes();
            foreach (ComboBox combo in combo_list)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    combo.Items.Add(dt.Rows[i]["name"].ToString().Trim());
                }
            }
            for (int i = 0; i < 12; i++)
            {
                group_stats[i].won = 0;
                group_stats[i].lost = 0;
                group_stats[i].points = 0;
                picture_list[i] = dt.Rows[i]["logo"].ToString().Trim();
                team_list[i] = dt.Rows[i]["name"].ToString().Trim();

            }

            gAMESTableAdapter.Fill(tournamentDataSet.GAMES);
            DataTable games = tournamentDataSet.GAMES;

            for (int i = 0; i < games.Rows.Count; i++)
            {
                rEGISTERSTableAdapter.delete_register(Convert.ToInt32(games.Rows[i]["id_game"]));
                sTATISTICSTableAdapter.delete_statistic(Convert.ToInt32(games.Rows[i]["id_game"]));
                gAMESTableAdapter.delete_game(Convert.ToInt32(games.Rows[i]["id_game"]));
            }
            tabControl1.SelectedTab = groupsPage;

        }

        private void groupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = groupsPage;
        }

        private void bracketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = bracketPage;
        }

        private void teamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = teamsPage;

            tEAMSTableAdapter.Fill(tournamentDataSet.TEAMS);
            DataTable team = tournamentDataSet.TEAMS;

            for (int i = 0; i < 12; i++)
            {
                picturebox_list2[i].Image = Image.FromFile(@"..\\..\\Resources\" + team.Rows[i]["logo"].ToString().Trim());
                team_list2[i].Text = team.Rows[i]["name"].ToString().Trim();
            }


        }

        private void reset_teams_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
            {
                combo_list[i].SelectedIndex = -1;
                picturebox_list[i].Image = null;
            }
            foreach (ComboBox combo in combo_list)
                combo.SelectedIndex = -1;

        }

        private void shuffle_teams_Click(object sender, EventArgs e)
        {
            // Fisher-Yates Shuffle Algorithm
            Random rng = new Random();
            for (int i = 11; i > 0; i--)
            {
                var k = rng.Next(i + 1);
                string value = team_list[k];
                team_list[k] = team_list[i];
                team_list[i] = value;

                value = picture_list[k];
                picture_list[k] = picture_list[i];
                picture_list[i] = value;
            }

            tEAMSTableAdapter.Fill(tournamentDataSet.TEAMS);
            DataTable dt = tournamentDataSet.TEAMS;

            int ind = 0;
            foreach (ComboBox combo in combo_list)
            {
                combo.Text = team_list[ind];
                picturebox_list[ind].Image = Image.FromFile(@"..\\..\\Resources\" + picture_list[ind].ToString().Trim());
                ind++;
            }
        }

        private void confirm_teams_Click(object sender, EventArgs e)
        {
            foreach (ComboBox combo in combo_list)
                if (combo.Text == "")
                {
                    MessageBox.Show("Please complete all teams!");
                    return;
                }

            for (int i = 0; i < 11; i++)
                for (int j = i + 1; j < 12; j++)
                {
                    if (combo_list[i].Text == combo_list[j].Text)
                    {
                        MessageBox.Show("Teams can't repeat");
                        return;
                    }
                }
            int ind = 0;
            foreach (ComboBox combo in combo_list)
            {
                team_list[ind] = combo.Text;
                picture_list[ind] = tEAMSTableAdapter.get_logo_by_name(combo.Text).ToString().Trim();
                picturebox_list[ind].Image = Image.FromFile(@"..\\..\\Resources\" + picture_list[ind].ToString().Trim());
                ind++;
            }
            reset_teams.Visible = false;
            shuffle_teams.Visible = false;
            confirm_teams.Visible = false;
            foreach (ComboBox combo in combo_list)
                combo.Enabled = false;

            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;

            for (int i = 0; i < 12; i++)
                if (i <= 2)
                    tEAMSTableAdapter.update_group_name("A", team_list[i]);
                else if (i <= 5)
                    tEAMSTableAdapter.update_group_name("B", team_list[i]);
                else if (i <= 8)
                    tEAMSTableAdapter.update_group_name("C", team_list[i]);
                else if (i <= 11)
                    tEAMSTableAdapter.update_group_name("D", team_list[i]);

            for (int i = 0; i < 12; i++)
            {
                picturebox_list[i].Image = Image.FromFile(@"..\\..\\Resources\" + tEAMSTableAdapter.get_logo_by_name(combo_list[i].Text.ToString().Trim()));
            }


            tEAMSTableAdapter.get_teams_by_group(tournamentDataSet.TEAMS, "A");
            gAMESTableAdapter.Fill(tournamentDataSet.GAMES);
            DataTable teams = tournamentDataSet.TEAMS;
            DataTable games = tournamentDataSet.GAMES;

            for (int i = 0; i < 2; i++)
            {
                for (int j = i + 1; j < 3; j++)
                {
                    gAMESTableAdapter.add_game("group", null);
                    gAMESTableAdapter.Update(tournamentDataSet);
                    gAMESTableAdapter.Fill(tournamentDataSet.GAMES);
                    rEGISTERSTableAdapter.add_register(Convert.ToInt32(teams.Rows[i]["id_team"]), Convert.ToInt32(games.Rows[games.Rows.Count - 1]["id_game"]));
                    rEGISTERSTableAdapter.add_register(Convert.ToInt32(teams.Rows[j]["id_team"]), Convert.ToInt32(games.Rows[games.Rows.Count - 1]["id_game"]));
                }
            }

            tEAMSTableAdapter.get_teams_by_group(tournamentDataSet.TEAMS, "B");
            teams = tournamentDataSet.TEAMS;
            for (int i = 0; i < 2; i++)
            {
                for (int j = i + 1; j < 3; j++)
                {
                    gAMESTableAdapter.add_game("group", null);
                    gAMESTableAdapter.Update(tournamentDataSet);
                    gAMESTableAdapter.Fill(tournamentDataSet.GAMES);
                    rEGISTERSTableAdapter.add_register(Convert.ToInt32(teams.Rows[i]["id_team"]), Convert.ToInt32(games.Rows[games.Rows.Count - 1]["id_game"]));
                    rEGISTERSTableAdapter.add_register(Convert.ToInt32(teams.Rows[j]["id_team"]), Convert.ToInt32(games.Rows[games.Rows.Count - 1]["id_game"]));
                }
            }

            tEAMSTableAdapter.get_teams_by_group(tournamentDataSet.TEAMS, "C");
            teams = tournamentDataSet.TEAMS;

            for (int i = 0; i < 2; i++)
            {
                for (int j = i + 1; j < 3; j++)
                {
                    gAMESTableAdapter.add_game("group", null);
                    gAMESTableAdapter.Update(tournamentDataSet);
                    gAMESTableAdapter.Fill(tournamentDataSet.GAMES);
                    rEGISTERSTableAdapter.add_register(Convert.ToInt32(teams.Rows[i]["id_team"]), Convert.ToInt32(games.Rows[games.Rows.Count - 1]["id_game"]));
                    rEGISTERSTableAdapter.add_register(Convert.ToInt32(teams.Rows[j]["id_team"]), Convert.ToInt32(games.Rows[games.Rows.Count - 1]["id_game"]));
                }
            }

            tEAMSTableAdapter.get_teams_by_group(tournamentDataSet.TEAMS, "D");
            teams = tournamentDataSet.TEAMS;

            for (int i = 0; i < 2; i++)
            {
                for (int j = i + 1; j < 3; j++)
                {
                    gAMESTableAdapter.add_game("group", null);
                    gAMESTableAdapter.Update(tournamentDataSet);
                    gAMESTableAdapter.Fill(tournamentDataSet.GAMES);
                    rEGISTERSTableAdapter.add_register(Convert.ToInt32(teams.Rows[i]["id_team"]), Convert.ToInt32(games.Rows[games.Rows.Count - 1]["id_game"]));
                    rEGISTERSTableAdapter.add_register(Convert.ToInt32(teams.Rows[j]["id_team"]), Convert.ToInt32(games.Rows[games.Rows.Count - 1]["id_game"]));
                }
            }
        }
        private void group_games_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = groupGamesPage;

            Button clicked_button = (Button)sender;

            tEAMSTableAdapter.get_teams_by_group(tournamentDataSet.TEAMS, clicked_button.Text.Split(' ')[1]);
            DataTable dt = tournamentDataSet.TEAMS;

            team1_label.Text = dt.Rows[0]["shortname"].ToString().Trim();
            team2_label.Text = dt.Rows[1]["shortname"].ToString().Trim();
            team3_label.Text = dt.Rows[0]["shortname"].ToString().Trim();
            team4_label.Text = dt.Rows[2]["shortname"].ToString().Trim();
            team5_label.Text = dt.Rows[1]["shortname"].ToString().Trim();
            team6_label.Text = dt.Rows[2]["shortname"].ToString().Trim();


            pictureBox1.Image = Image.FromFile(@"..\\..\\Resources\" + dt.Rows[0]["logo"].ToString().Trim());
            pictureBox2.Image = Image.FromFile(@"..\\..\\Resources\" + dt.Rows[1]["logo"].ToString().Trim());
            pictureBox3.Image = Image.FromFile(@"..\\..\\Resources\" + dt.Rows[0]["logo"].ToString().Trim());
            pictureBox4.Image = Image.FromFile(@"..\\..\\Resources\" + dt.Rows[2]["logo"].ToString().Trim());
            pictureBox5.Image = Image.FromFile(@"..\\..\\Resources\" + dt.Rows[1]["logo"].ToString().Trim());
            pictureBox6.Image = Image.FromFile(@"..\\..\\Resources\" + dt.Rows[2]["logo"].ToString().Trim());


        }
        private void back_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == groupGamesPage)
            {
                tabControl1.SelectedTab = groupsPage;
            }
            else if (tabControl1.SelectedTab == gamePage)
            {
                tabControl1.SelectedTab = last_page;
            }
            else if (tabControl1.SelectedTab == teamDetailsPage)
            {
                tabControl1.SelectedTab = teamsPage;
            }
            else if (tabControl1.SelectedTab == playerDetailsPage)
            {
                tabControl1.SelectedTab = teamDetailsPage;
            }
            else if (tabControl1.SelectedTab == winnerPage)
                tabControl1.SelectedTab = bracketPage;
        }

        int id_game = 0;
        private void game_details_click(object sender, EventArgs e)
        {
            last_page = tabControl1.SelectedTab;
            tabControl1.SelectedTab = gamePage;

            Button clicked_button = (Button)sender;

            string teamX = "", teamY = "";
            char game_type = clicked_button.Text.ToString()[0];

            // team names
            if (game_type == 'G')
            {

                if (clicked_button.Text.ToString().Split(' ')[1] == "1")
                {
                    teamX = team1_label.Text;
                    teamY = team2_label.Text;
                }
                else if (clicked_button.Text.ToString().Split(' ')[1] == "2")
                {
                    teamX = team3_label.Text;
                    teamY = team4_label.Text;
                }
                else if (clicked_button.Text.ToString().Split(' ')[1] == "3")
                {
                    teamX = team5_label.Text;
                    teamY = team6_label.Text;
                }
            }
            else if (game_type == 'Q')
            {
                if (clicked_button.Text.ToString().Split(' ')[2] == "1")
                {
                    teamX = tEAMSTableAdapter.get_shortname_by_logo(picture_list[0]).Trim();
                    teamY = tEAMSTableAdapter.get_shortname_by_logo(picture_list[10]).Trim();
                }
                else if (clicked_button.Text.ToString().Split(' ')[2] == "2")
                {
                    teamX = tEAMSTableAdapter.get_shortname_by_logo(picture_list[6]).Trim();
                    teamY = tEAMSTableAdapter.get_shortname_by_logo(picture_list[4]).Trim();
                }
                else if (clicked_button.Text.ToString().Split(' ')[2] == "3")
                {
                    teamX = tEAMSTableAdapter.get_shortname_by_logo(picture_list[9]).Trim();
                    teamY = tEAMSTableAdapter.get_shortname_by_logo(picture_list[1]).Trim();
                }
                else if (clicked_button.Text.ToString().Split(' ')[2] == "4")
                {
                    teamX = tEAMSTableAdapter.get_shortname_by_logo(picture_list[3]).Trim();
                    teamY = tEAMSTableAdapter.get_shortname_by_logo(picture_list[7]).Trim();
                }

            }
            else if (game_type == 'S')
            {
                if (clicked_button.Text.ToString().Split(' ')[1] == "1")
                {
                    teamX = tEAMSTableAdapter.get_shortname_by_logo(picture_list[quarterfinal_winnners[0]]).Trim();
                    teamY = tEAMSTableAdapter.get_shortname_by_logo(picture_list[quarterfinal_winnners[1]]).Trim();
                }
                else if (clicked_button.Text.ToString().Split(' ')[1] == "2")
                {
                    teamX = tEAMSTableAdapter.get_shortname_by_logo(picture_list[quarterfinal_winnners[2]]).Trim();
                    teamY = tEAMSTableAdapter.get_shortname_by_logo(picture_list[quarterfinal_winnners[3]]).Trim();
                }
            }
            else if (game_type == 'F')
            {
                teamX = tEAMSTableAdapter.get_shortname_by_logo(picture_list[seminfinal_winners[0]]).Trim();
                teamY = tEAMSTableAdapter.get_shortname_by_logo(picture_list[seminfinal_winners[1]]).Trim();
            }

            //team pictures
            tEAMSTableAdapter.get_team_players_by_shortname(tournamentDataSet.TEAMS, teamX);
            DataTable dt = tournamentDataSet.TEAMS;

            teamx_label.Text = dt.Rows[0]["name"].ToString().Trim();
            pictureBoxX.Image = Image.FromFile(@"..\\..\\Resources\" + dt.Rows[0]["logo"].ToString().Trim());
            for (int i = 0; i < 5; i++)
            {
                player_game_list[i].Text = dt.Rows[i]["last_name"].ToString().Trim() + " " + dt.Rows[i]["first_name"].ToString().Trim();
            }

            tEAMSTableAdapter.get_team_players_by_shortname(tournamentDataSet.TEAMS, teamY);
            dt = tournamentDataSet.TEAMS;

            teamy_label.Text = dt.Rows[0]["name"].ToString().Trim();
            pictureBoxY.Image = Image.FromFile(@"..\\..\\Resources\" + dt.Rows[0]["logo"].ToString().Trim());
            for (int i = 5; i < 10; i++)
            {
                player_game_list[i].Text = dt.Rows[i - 5]["last_name"].ToString().Trim() + " " + dt.Rows[i - 5]["first_name"].ToString().Trim();
            }

            //id game
            int[] team1_games = new int[10];
            int[] team2_games = new int[10];
            if (game_type == 'G')
            {
                rEGISTERSTableAdapter.get_game(tournamentDataSet.REGISTERS, teamx_label.Text, "group");
                DataTable games = tournamentDataSet.REGISTERS;


                for (int i = 0; i < 2; i++)
                {
                    team1_games[i] = Convert.ToInt32(games.Rows[i]["id_game"]);
                }
                rEGISTERSTableAdapter.get_game(tournamentDataSet.REGISTERS, teamy_label.Text, "group");
                for (int i = 0; i < 2; i++)
                {
                    team2_games[i] = Convert.ToInt32(games.Rows[i]["id_game"]);
                }
                bool ok = true;
                for (int i = 0; i < 2 && ok; i++)
                {
                    for (int j = 0; j < 2 && ok; j++)
                    {
                        if (team1_games[i] == team2_games[j])
                        {
                            id_game = team1_games[i];
                            ok = false;
                        }
                    }
                }
            }
            else if (game_type == 'Q')
            {
                if (clicked_button.Text.ToString().Split(' ')[2] == "1")
                    rEGISTERSTableAdapter.get_game(tournamentDataSet.REGISTERS, teamx_label.Text, "quarterfinal 1");
                else if (clicked_button.Text.ToString().Split(' ')[2] == "2")
                    rEGISTERSTableAdapter.get_game(tournamentDataSet.REGISTERS, teamx_label.Text, "quarterfinal 2");
                else if (clicked_button.Text.ToString().Split(' ')[2] == "3")
                    rEGISTERSTableAdapter.get_game(tournamentDataSet.REGISTERS, teamx_label.Text, "quarterfinal 3");
                else if (clicked_button.Text.ToString().Split(' ')[2] == "4")
                    rEGISTERSTableAdapter.get_game(tournamentDataSet.REGISTERS, teamx_label.Text, "quarterfinal 4");

                DataTable games = tournamentDataSet.REGISTERS;
                id_game = Convert.ToInt32(games.Rows[0]["id_game"]);

            }
            else if (game_type == 'S')
            {
                if (clicked_button.Text.ToString().Split(' ')[1] == "1")
                    rEGISTERSTableAdapter.get_game(tournamentDataSet.REGISTERS, teamx_label.Text, "semifinal 1");
                else if (clicked_button.Text.ToString().Split(' ')[1] == "2")
                    rEGISTERSTableAdapter.get_game(tournamentDataSet.REGISTERS, teamx_label.Text, "semifinal 2");

                DataTable games = tournamentDataSet.REGISTERS;
                id_game = Convert.ToInt32(games.Rows[0]["id_game"]);
            }

            else if (game_type == 'F')
            {
                rEGISTERSTableAdapter.get_game(tournamentDataSet.REGISTERS, teamx_label.Text, "final");
                DataTable games = tournamentDataSet.REGISTERS;
                id_game = Convert.ToInt32(games.Rows[0]["id_game"]);
            }



            int nr_points = Convert.ToInt32(sTATISTICSTableAdapter.count_points(id_game));
            if (nr_points == 0)
            {
                // games not played yet
                shuffle_stats.Visible = true;
                confirm_stats.Visible = true;
                for (int i = 0; i < 10; i++)
                {
                    score_list[i].Enabled = true;
                    score_list[i].Value = 0;
                }
                scoreX.Text = "0";
                scoreY.Text = "0";

            }
            else
            {
                // games played 
                shuffle_stats.Visible = false;
                confirm_stats.Visible = false;
                decimal sumX = 0, sumY = 0;
                for (int i = 0; i < 10; i++)
                {
                    int id_player = Convert.ToInt32(pLAYERSTableAdapter.get_player_id(player_game_list[i].Text.Split(' ')[0]));
                    score_list[i].Value = Convert.ToDecimal(sTATISTICSTableAdapter.get_points(id_game, id_player));
                    if (i < 5)
                        sumX += score_list[i].Value;
                    else
                        sumY += score_list[i].Value;

                }
                scoreX.Text = sumX.ToString();
                scoreY.Text = sumY.ToString();
            }



        }

        private void shuffle_stats_Click(object sender, EventArgs e)
        {
            //shuffle stats for a player
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                score_list[i].Value = rnd.Next(12, 36);
            }
        }

        private void confirm_stats_Click(object sender, EventArgs e)
        {
            shuffle_stats.Visible = false;
            confirm_stats.Visible = false;

            for (int i = 0; i < 10; i++)
            {
                score_list[i].Enabled = false;
            }
            decimal sumX = 0, sumY = 0;
            for (int i = 0; i < 5; i++)
            {
                sumX += score_list[i].Value;
            }
            for (int i = 5; i < 10; i++)
            {
                sumY += score_list[i].Value;
            }

            if (sumX == sumY)
            {
                sumX++;
                score_list[0].Value++;
            }

            string type = gAMESTableAdapter.get_type_by_id(id_game).ToString().Trim();
            int pozX = 0, pozY = 0;
            for (int i = 0; i < 12; i++)
            {
                if (teamx_label.Text == team_list[i])
                {
                    pozX = i;
                }
                if (teamy_label.Text == team_list[i])
                {
                    pozY = i;
                }
            }

            if(team_list[pozX] == "U-Banca Transilvania Cluj-Napoca")
            {
                score_list[0].Value+=5;
                score_list[1].Value += 5;
                score_list[2].Value += 5;
                sumX += 15;

            }
            else if (team_list[pozY] == "U-Banca Transilvania Cluj-Napoca")
            {
                score_list[5].Value += 5;
                score_list[6].Value += 5;
                score_list[7].Value += 5;
                sumY += 15;
            }
            for (int i = 0; i < 10; i++)
            {
                int id_player = Convert.ToInt32(pLAYERSTableAdapter.get_player_id(player_game_list[i].Text.Split(' ')[0]));
                sTATISTICSTableAdapter.add_statistic(Convert.ToInt32(score_list[i].Value), id_player, id_game);
            }
            sTATISTICSTableAdapter.Update(tournamentDataSet);
            sTATISTICSTableAdapter.Fill(tournamentDataSet.STATISTICS);
            scoreX.Text = sumX.ToString();
            scoreY.Text = sumY.ToString();


            

            if (type.Split(' ')[0] == "group")
            {
                group_stats[pozX].points += Convert.ToInt32(sumX);
                group_stats[pozY].points += Convert.ToInt32(sumY);
                if (sumX > sumY)
                {
                    group_stats[pozX].won++;
                    group_stats[pozY].lost++;
                }
                else
                {
                    group_stats[pozX].lost++;
                    group_stats[pozY].won++;
                }
                update_groups();
                get_group_winners();
            }
            else if (type.Split(' ')[0] == "quarterfinal")
            {
                group_stats[pozX].points += Convert.ToInt32(sumX);
                group_stats[pozY].points += Convert.ToInt32(sumY);
                if (type.Split(' ')[1] == "1")
                {
                    if (sumX > sumY)
                    {
                        quarterfinal_winnners[0] = pozX;
                        group_stats[pozX].won++;
                        group_stats[pozY].lost++;

                    }
                    else if (sumY > sumX)
                    {
                        quarterfinal_winnners[0] = pozY;
                        group_stats[pozX].lost++;
                        group_stats[pozY].won++;
                    }
                }
                else if (type.Split(' ')[1] == "2")
                {
                    if (sumX > sumY)
                    {
                        quarterfinal_winnners[1] = pozX;
                        group_stats[pozX].won++;
                        group_stats[pozY].lost++;
                    }
                    else if (sumY > sumX)
                    {
                        quarterfinal_winnners[1] = pozY;
                        group_stats[pozX].lost++;
                        group_stats[pozY].won++;
                    }
                }
                else if (type.Split(' ')[1] == "3")
                {
                    if (sumX > sumY)
                    {
                        quarterfinal_winnners[2] = pozX;
                        group_stats[pozX].won++;
                        group_stats[pozY].lost++;
                    }
                    else if (sumY > sumX)
                    {
                        quarterfinal_winnners[2] = pozY;
                        group_stats[pozX].lost++;
                        group_stats[pozY].won++;
                    }
                }
                else if (type.Split(' ')[1] == "4")
                {
                    if (sumX > sumY)
                    {
                        quarterfinal_winnners[3] = pozX;
                        group_stats[pozX].won++;
                        group_stats[pozY].lost++;
                    }
                    else if (sumY > sumX)
                    {
                        quarterfinal_winnners[3] = pozY;
                        group_stats[pozX].lost++;
                        group_stats[pozY].won++;
                    }
                }

                get_quarter_winners();
            }
            else if (type.Split(' ')[0] == "semifinal")
            {
                group_stats[pozX].points += Convert.ToInt32(sumX);
                group_stats[pozY].points += Convert.ToInt32(sumY);
                if (type.Split(' ')[1] == "1")
                {
                    if (sumX > sumY)
                    {
                        seminfinal_winners[0] = pozX;
                        group_stats[pozX].won++;
                        group_stats[pozY].lost++;
                    }
                    else if (sumX < sumY)
                    {
                        seminfinal_winners[0] = pozY;
                        group_stats[pozX].lost++;
                        group_stats[pozY].won++;
                    }
                }
                else if (type.Split(' ')[1] == "2")
                {
                    if (sumX > sumY)
                    {
                        seminfinal_winners[1] = pozX;
                        group_stats[pozX].won++;
                        group_stats[pozY].lost++;
                    }
                    else if (sumX < sumY)
                    {
                        seminfinal_winners[1] = pozY;
                        group_stats[pozX].lost++;
                        group_stats[pozY].won++;
                    }
                }
                get_semi_winners();

            }
            else if (type.Split(' ')[0] == "final")
            {
                group_stats[pozX].points += Convert.ToInt32(sumX);
                group_stats[pozY].points += Convert.ToInt32(sumY);
                if (sumX > sumY)
                {
                    final_winner = pozX;
                    group_stats[pozX].won++;
                    group_stats[pozY].lost++;
                    winner_label.Text = team_list[pozX];
                    winner_picturebox.Image = Image.FromFile(@"..\\..\\Resources\" + picture_list[pozX].ToString().Trim());
                }
                else
                {
                    final_winner = pozY;
                    group_stats[pozX].lost++;
                    group_stats[pozY].won++;
                    winner_label.Text = team_list[pozY];
                    winner_picturebox.Image = Image.FromFile(@"..\\..\\Resources\" + picture_list[pozY].ToString().Trim());
                }
                tabControl1.SelectedTab = winnerPage;
                winner_button.Visible = true;

            }
        }
        void update_groups()
        {
            for (int k = 0; k < 12; k += 3)
            {
                for (int i = 0; i < 2; i++)
                {
                    for (int j = i + 1; j < 3; j++)
                    {
                        if (group_stats[i + k].won < group_stats[j + k].won)
                        {
                            GroupStats auxG = group_stats[i + k];
                            group_stats[i + k] = group_stats[j + k];
                            group_stats[j + k] = auxG;

                            string auxS = team_list[i + k];
                            team_list[i + k] = team_list[j + k];
                            team_list[j + k] = auxS;

                            auxS = picture_list[i + k];
                            picture_list[i + k] = picture_list[j + k];
                            picture_list[j + k] = auxS;

                        }
                        else if (group_stats[i + k].won == group_stats[j + k].won && group_stats[i + k].points < group_stats[j + k].points)
                        {
                            GroupStats aux = group_stats[i + k];
                            group_stats[i + k] = group_stats[j + k];
                            group_stats[j + k] = aux;

                            string auxS = team_list[i + k];
                            team_list[i + k] = team_list[j + k];
                            team_list[j + k] = auxS;

                            auxS = picture_list[i + k];
                            picture_list[i + k] = picture_list[j + k];
                            picture_list[j + k] = auxS;
                        }
                    }
                }
            }
            for (int i = 0; i < 12; i++)
            {
                combo_list[i].Text = team_list[i];
                picturebox_list[i].Image = Image.FromFile(@"..\\..\\Resources\" + picture_list[i]);
                win_list[i].Text = group_stats[i].won.ToString();
                lost_list[i].Text = group_stats[i].lost.ToString();
                points_list[i].Text = group_stats[i].points.ToString();

            }
        }
        void get_group_winners()
        {
            int nr_grupa = Convert.ToInt32(sTATISTICSTableAdapter.get_statistics_number("A"));
            int s = 0;
            if (nr_grupa == 60)
            {
                bracket1.Image = Image.FromFile(@"..\\..\\Resources\" + picture_list[0]);
                bracket6.Image = Image.FromFile(@"..\\..\\Resources\" + picture_list[1]);
                s++;
            }
            nr_grupa = Convert.ToInt32(sTATISTICSTableAdapter.get_statistics_number("B"));
            if (nr_grupa == 60)
            {
                bracket7.Image = Image.FromFile(@"..\\..\\Resources\" + picture_list[3]);
                bracket4.Image = Image.FromFile(@"..\\..\\Resources\" + picture_list[4]);
                s++;
            }
            nr_grupa = Convert.ToInt32(sTATISTICSTableAdapter.get_statistics_number("C"));
            if (nr_grupa == 60)
            {
                bracket3.Image = Image.FromFile(@"..\\..\\Resources\" + picture_list[6]);
                bracket8.Image = Image.FromFile(@"..\\..\\Resources\" + picture_list[7]);
                s++;
            }
            nr_grupa = Convert.ToInt32(sTATISTICSTableAdapter.get_statistics_number("D"));
            if (nr_grupa == 60)
            {
                bracket5.Image = Image.FromFile(@"..\\..\\Resources\" + picture_list[9]);
                bracket2.Image = Image.FromFile(@"..\\..\\Resources\" + picture_list[10]);
                s++;
            }
            if (s == 4)
            {
                int id_team1, id_team2;
                gAMESTableAdapter.Fill(tournamentDataSet.GAMES);
                DataTable games = tournamentDataSet.GAMES;

                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;

                gAMESTableAdapter.add_game("quarterfinal 1", null);
                gAMESTableAdapter.Update(tournamentDataSet);
                gAMESTableAdapter.Fill(tournamentDataSet.GAMES);
                id_team1 = Convert.ToInt32(tEAMSTableAdapter.get_name_by_logo(picture_list[0]));
                id_team2 = Convert.ToInt32(tEAMSTableAdapter.get_name_by_logo(picture_list[10]));
                rEGISTERSTableAdapter.add_register(id_team1, Convert.ToInt32(games.Rows[games.Rows.Count - 1]["id_game"]));
                rEGISTERSTableAdapter.add_register(id_team2, Convert.ToInt32(games.Rows[games.Rows.Count - 1]["id_game"]));

                gAMESTableAdapter.add_game("quarterfinal 2", null);
                gAMESTableAdapter.Update(tournamentDataSet);
                gAMESTableAdapter.Fill(tournamentDataSet.GAMES);
                id_team1 = Convert.ToInt32(tEAMSTableAdapter.get_name_by_logo(picture_list[6]));
                id_team2 = Convert.ToInt32(tEAMSTableAdapter.get_name_by_logo(picture_list[4]));
                rEGISTERSTableAdapter.add_register(id_team1, Convert.ToInt32(games.Rows[games.Rows.Count - 1]["id_game"]));
                rEGISTERSTableAdapter.add_register(id_team2, Convert.ToInt32(games.Rows[games.Rows.Count - 1]["id_game"]));

                gAMESTableAdapter.add_game("quarterfinal 3", null);
                gAMESTableAdapter.Update(tournamentDataSet);
                gAMESTableAdapter.Fill(tournamentDataSet.GAMES);
                id_team1 = Convert.ToInt32(tEAMSTableAdapter.get_name_by_logo(picture_list[9]));
                id_team2 = Convert.ToInt32(tEAMSTableAdapter.get_name_by_logo(picture_list[1]));
                rEGISTERSTableAdapter.add_register(id_team1, Convert.ToInt32(games.Rows[games.Rows.Count - 1]["id_game"]));
                rEGISTERSTableAdapter.add_register(id_team2, Convert.ToInt32(games.Rows[games.Rows.Count - 1]["id_game"]));

                gAMESTableAdapter.add_game("quarterfinal 4", null);
                gAMESTableAdapter.Update(tournamentDataSet);
                gAMESTableAdapter.Fill(tournamentDataSet.GAMES);
                id_team1 = Convert.ToInt32(tEAMSTableAdapter.get_name_by_logo(picture_list[3]));
                id_team2 = Convert.ToInt32(tEAMSTableAdapter.get_name_by_logo(picture_list[7]));
                rEGISTERSTableAdapter.add_register(id_team1, Convert.ToInt32(games.Rows[games.Rows.Count - 1]["id_game"]));
                rEGISTERSTableAdapter.add_register(id_team2, Convert.ToInt32(games.Rows[games.Rows.Count - 1]["id_game"]));

            }

        }
        void get_quarter_winners()
        {
            int nr = Convert.ToInt32(sTATISTICSTableAdapter.get_statistic_number_bracket("quarterfinal 1"));
            int s = 0;
            if (nr == 10)
            {
                s++;
                bracket9.Image = Image.FromFile(@"..\\..\\Resources\" + picture_list[quarterfinal_winnners[0]]);
            }

            nr = Convert.ToInt32(sTATISTICSTableAdapter.get_statistic_number_bracket("quarterfinal 2"));
            if (nr == 10)
            {
                s++;
                bracket10.Image = Image.FromFile(@"..\\..\\Resources\" + picture_list[quarterfinal_winnners[1]]);
            }

            nr = Convert.ToInt32(sTATISTICSTableAdapter.get_statistic_number_bracket("quarterfinal 3"));
            if (nr == 10)
            {
                s++;
                bracket11.Image = Image.FromFile(@"..\\..\\Resources\" + picture_list[quarterfinal_winnners[2]]);
            }

            nr = Convert.ToInt32(sTATISTICSTableAdapter.get_statistic_number_bracket("quarterfinal 4"));
            if (nr == 10)
            {
                s++;
                bracket12.Image = Image.FromFile(@"..\\..\\Resources\" + picture_list[quarterfinal_winnners[3]]);
            }

            if (s == 4)
            {
                int id_team1, id_team2;
                gAMESTableAdapter.Fill(tournamentDataSet.GAMES);
                DataTable games = tournamentDataSet.GAMES;

                button13.Enabled = true;
                button14.Enabled = true;

                gAMESTableAdapter.add_game("semifinal 1", null);
                gAMESTableAdapter.Update(tournamentDataSet);
                gAMESTableAdapter.Fill(tournamentDataSet.GAMES);
                id_team1 = Convert.ToInt32(tEAMSTableAdapter.get_name_by_logo(picture_list[quarterfinal_winnners[0]]));
                id_team2 = Convert.ToInt32(tEAMSTableAdapter.get_name_by_logo(picture_list[quarterfinal_winnners[1]]));
                rEGISTERSTableAdapter.add_register(id_team1, Convert.ToInt32(games.Rows[games.Rows.Count - 1]["id_game"]));
                rEGISTERSTableAdapter.add_register(id_team2, Convert.ToInt32(games.Rows[games.Rows.Count - 1]["id_game"]));

                gAMESTableAdapter.add_game("semifinal 2", null);
                gAMESTableAdapter.Update(tournamentDataSet);
                gAMESTableAdapter.Fill(tournamentDataSet.GAMES);
                id_team1 = Convert.ToInt32(tEAMSTableAdapter.get_name_by_logo(picture_list[quarterfinal_winnners[2]]));
                id_team2 = Convert.ToInt32(tEAMSTableAdapter.get_name_by_logo(picture_list[quarterfinal_winnners[3]]));
                rEGISTERSTableAdapter.add_register(id_team1, Convert.ToInt32(games.Rows[games.Rows.Count - 1]["id_game"]));
                rEGISTERSTableAdapter.add_register(id_team2, Convert.ToInt32(games.Rows[games.Rows.Count - 1]["id_game"]));
            }

        }
        void get_semi_winners()
        {
            int nr = Convert.ToInt32(sTATISTICSTableAdapter.get_statistic_number_bracket("semifinal 1"));
            int s = 0;
            if (nr == 10)
            {
                s++;
                bracket13.Image = Image.FromFile(@"..\\..\\Resources\" + picture_list[seminfinal_winners[0]]);
            }

            nr = Convert.ToInt32(sTATISTICSTableAdapter.get_statistic_number_bracket("semifinal 2"));
            if (nr == 10)
            {
                s++;
                bracket14.Image = Image.FromFile(@"..\\..\\Resources\" + picture_list[seminfinal_winners[1]]);
            }

            if (s == 2)
            {
                int id_team1, id_team2;
                gAMESTableAdapter.Fill(tournamentDataSet.GAMES);
                DataTable games = tournamentDataSet.GAMES;

                button15.Enabled = true;

                gAMESTableAdapter.add_game("final", null);
                gAMESTableAdapter.Update(tournamentDataSet);
                gAMESTableAdapter.Fill(tournamentDataSet.GAMES);
                id_team1 = Convert.ToInt32(tEAMSTableAdapter.get_name_by_logo(picture_list[seminfinal_winners[0]]));
                id_team2 = Convert.ToInt32(tEAMSTableAdapter.get_name_by_logo(picture_list[seminfinal_winners[1]]));
                rEGISTERSTableAdapter.add_register(id_team1, Convert.ToInt32(games.Rows[games.Rows.Count - 1]["id_game"]));
                rEGISTERSTableAdapter.add_register(id_team2, Convert.ToInt32(games.Rows[games.Rows.Count - 1]["id_game"]));
            }
        }

        private void team_details_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = teamDetailsPage;
            Label x = (Label)sender;
            string name = x.Text;

            team_name.Text = name;

            tEAMSTableAdapter.get_year_by_name(tournamentDataSet.TEAMS, name);
            DataTable dt = tournamentDataSet.TEAMS;

            year_founded.Text = dt.Rows[0]["year_founded"].ToString().Trim();
            logo.Image = Image.FromFile(@"..\\..\\Resources\" + dt.Rows[0]["logo"].ToString().Trim());

            int poz = 0;
            for (int i = 0; i < 12; i++)
                if (team_list[i] == name)
                    poz = i;

            games_won.Text = group_stats[poz].won.ToString();
            games_lost.Text = group_stats[poz].lost.ToString();
            total_points_team.Text = group_stats[poz].points.ToString();

            int games_played = Convert.ToInt32(sTATISTICSTableAdapter.get_games_played(name) / 5);
            if (games_played == 0)
                games_played = 1;
            avg_points_team.Text = (group_stats[poz].points * 1.0 / games_played).ToString();

            tEAMSTableAdapter.get_players_by_name(tournamentDataSet.TEAMS, name);
            DataTable players = tournamentDataSet.TEAMS;

            player_name1.Text = players.Rows[0]["last_name"].ToString().Trim() + ' ' + players.Rows[0]["first_name"].ToString().Trim();
            player_name2.Text = players.Rows[1]["last_name"].ToString().Trim() + ' ' + players.Rows[1]["first_name"].ToString().Trim();
            player_name3.Text = players.Rows[2]["last_name"].ToString().Trim() + ' ' + players.Rows[2]["first_name"].ToString().Trim();
            player_name4.Text = players.Rows[3]["last_name"].ToString().Trim() + ' ' + players.Rows[3]["first_name"].ToString().Trim();
            player_name5.Text = players.Rows[4]["last_name"].ToString().Trim() + ' ' + players.Rows[4]["first_name"].ToString().Trim();

            player_pic1.Image = Image.FromFile(@"..\\..\\Resources\" + dt.Rows[0]["player_image"].ToString().Trim());
            player_pic2.Image = Image.FromFile(@"..\\..\\Resources\" + dt.Rows[1]["player_image"].ToString().Trim());
            player_pic3.Image = Image.FromFile(@"..\\..\\Resources\" + dt.Rows[2]["player_image"].ToString().Trim());
            player_pic4.Image = Image.FromFile(@"..\\..\\Resources\" + dt.Rows[3]["player_image"].ToString().Trim());
            player_pic5.Image = Image.FromFile(@"..\\..\\Resources\" + dt.Rows[4]["player_image"].ToString().Trim());

        }

        private void player_details_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = playerDetailsPage;
            Label x = (Label)sender;
            string name = x.Text.Split(' ')[0];

            pLAYERSTableAdapter.get_player_by_name(tournamentDataSet.PLAYERS, name);
            DataTable player = tournamentDataSet.PLAYERS;

            player_name.Text = name + ' ' + player.Rows[0]["first_name"].ToString().Trim();
            player_picture.Image = Image.FromFile(@"..\\..\\Resources\" + player.Rows[0]["player_image"].ToString().Trim());
            height_player.Text = player.Rows[0]["height"].ToString().Trim();
            country_player.Text = player.Rows[0]["country"].ToString().Trim();
            position_player.Text = player.Rows[0]["position"].ToString().Trim();

            var birth = player.Rows[0]["birth_date"].ToString().Trim();
            var date = Convert.ToDateTime(birth);
            birth_player.Text = date.ToString("dd MMMM yyyy");

            int total_points = Convert.ToInt32(pLAYERSTableAdapter.get_points_by_player(name));
            string team = pLAYERSTableAdapter.get_player_team(name);
            int games_played = Convert.ToInt32(sTATISTICSTableAdapter.get_games_played(team) / 5);
            if (games_played == 0)
                games_played++;
            total_points_player.Text = total_points.ToString();
            avg_points_player.Text = (1.0 * total_points / games_played).ToString();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            tabControl1.SelectedTab = teamStatsPage;
            tEAMSTableAdapter.sort_teams_alph(tournamentDataSet.TEAMS);
            DataTable teams = tournamentDataSet.TEAMS;
            richTextBox18.Text = "";
            stat1.Text = "";
            stat2.Text = "";
            for (int i = 0; i < 12; i++)
            {
                stats[i].Text = "";
                stats2[i].Text = "";
                if (i + 1 < 10)
                    richTextBox18.Text += (i + 1) + ".     ";
                else
                    richTextBox18.Text += (i + 1) + ".   ";

                richTextBox18.Text += teams.Rows[i]["name"].ToString().Trim() + "\n";

            }
        }

        private void sort_team_alph_Click(object sender, EventArgs e)
        {
            tEAMSTableAdapter.sort_teams_alph(tournamentDataSet.TEAMS);
            DataTable teams = tournamentDataSet.TEAMS;
            richTextBox18.Text = "";
            stat1.Text = "";
            stat2.Text = "";
            for (int i = 0; i < 12; i++)
            {
                stats[i].Text = "";
                stats2[i].Text = "";
                if (i + 1 < 10)
                    richTextBox18.Text += (i + 1) + ".     ";
                else
                    richTextBox18.Text += (i + 1) + ".   ";

                richTextBox18.Text += teams.Rows[i]["name"].ToString().Trim() + "\n";

            }
        }

        private void sort_team_wins_Click(object sender, EventArgs e)
        {
            richTextBox18.Text = "";
            int[] wins = new int[12];
            string[] teams = new string[12];
            stat1.Text = "Won";
            stat2.Text = "Lost";
            for (int i = 0; i < 12; i++)
            {
                wins[i] = group_stats[i].won;
                teams[i] = team_list[i];
            }
            for (int i = 0; i < 11; i++)
                for (int j = i + 1; j < 12; j++)
                    if (wins[i] < wins[j])
                    {
                        int aux = wins[i];
                        wins[i] = wins[j];
                        wins[j] = aux;

                        string aux2 = teams[i];
                        teams[i] = teams[j];
                        teams[j] = aux2;

                    }
            for (int i = 0; i < 12; i++)
            {
                if (i + 1 < 10)
                    richTextBox18.Text += (i + 1) + ".     ";
                else
                    richTextBox18.Text += (i + 1) + ".   ";

                richTextBox18.Text += teams[i] + "\n";
                stats[i].Text = wins[i].ToString();
                int games_played = Convert.ToInt32(sTATISTICSTableAdapter.get_games_played(teams[i]) / 5);
                stats2[i].Text = (games_played - wins[i]).ToString();
            }

        }

        private void sort_team_points_Click(object sender, EventArgs e)
        {
            richTextBox18.Text = "";
            int[] points = new int[12];
            string[] teams = new string[12];
            stat1.Text = "Points";
            stat2.Text = "";
            for (int i = 0; i < 12; i++)
            {
                stats2[i].Text = "";
                points[i] = group_stats[i].points;
                teams[i] = team_list[i];
            }
            for (int i = 0; i < 11; i++)
                for (int j = i + 1; j < 12; j++)
                    if (points[i] < points[j])
                    {
                        int aux = points[i];
                        points[i] = points[j];
                        points[j] = aux;

                        string aux2 = teams[i];
                        teams[i] = teams[j];
                        teams[j] = aux2;

                    }
            for (int i = 0; i < 12; i++)
            {
                if (i + 1 < 10)
                    richTextBox18.Text += (i + 1) + ".     ";
                else
                    richTextBox18.Text += (i + 1) + ".   ";

                richTextBox18.Text += teams[i] + "\n";
                stats[i].Text = points[i].ToString();
            }
        }

        private void sort_team_avgpoints_Click(object sender, EventArgs e)
        {
            richTextBox18.Text = "";
            int[] points = new int[12];
            string[] teams = new string[12];
            stat1.Text = "Average points";
            stat2.Text = "";
            for (int i = 0; i < 12; i++)
            {
                stats2[i].Text = "";
                points[i] = group_stats[i].points;
                teams[i] = team_list[i];
            }
            for (int i = 0; i < 11; i++)
                for (int j = i + 1; j < 12; j++)
                    if (points[i] < points[j])
                    {
                        int aux = points[i];
                        points[i] = points[j];
                        points[j] = aux;

                        string aux2 = teams[i];
                        teams[i] = teams[j];
                        teams[j] = aux2;

                    }
            for (int i = 0; i < 12; i++)
            {
                if (i + 1 < 10)
                    richTextBox18.Text += (i + 1) + ".     ";
                else
                    richTextBox18.Text += (i + 1) + ".   ";

                richTextBox18.Text += teams[i] + "\n";
                int games_played = Convert.ToInt32(sTATISTICSTableAdapter.get_games_played(teams[i]) / 5);
                if (games_played == 0)
                    games_played++;
                stats[i].Text = (points[i] * 1.0 / games_played).ToString();
            }
        }

        private void playerStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = playerStatsPage;
            pLAYERSTableAdapter.sort_players_alph(tournamentDataSet.PLAYERS);
            DataTable players = tournamentDataSet.PLAYERS;
            richTextBox19.Text = "";
            string space = String.Format("{0,10:D}", " ");
            for (int i = 0; i < 60; i++)
            {
                player_names[i] = players.Rows[i]["last_name"].ToString().Trim() + " " +
                            players.Rows[i]["first_name"].ToString().Trim() + " -- " +
                            players.Rows[i]["position"].ToString().Trim() + " -- " +
                            players.Rows[i]["shortname"].ToString().Trim();
                points[i] = Convert.ToInt32(pLAYERSTableAdapter.get_points_by_player(players.Rows[i]["last_name"].ToString().Trim()));
                if (points[i] == null)
                    points[i] = 0;
                if (i + 1 < 10)
                    richTextBox19.Text += (i + 1) + ".     ";
                else
                    richTextBox19.Text += (i + 1) + ".   ";

                richTextBox19.Text += players.Rows[i]["last_name"].ToString().Trim() + " " +
                            players.Rows[i]["first_name"].ToString().Trim() + " -- " +
                            players.Rows[i]["position"].ToString().Trim() + " -- " +
                            players.Rows[i]["shortname"].ToString().Trim() + "\n\n";
            }

            team_combo.Items.Clear();
            team_combo.Items.Add("Any");
            tEAMSTableAdapter.Fill(tournamentDataSet.TEAMS);
            DataTable teams = tournamentDataSet.TEAMS;
            for (int i = 0; i < 12; i++)
                team_combo.Items.Add(teams.Rows[i]["shortname"].ToString().Trim());

            position_combo.Text = "Any";
            team_combo.Text = "Any";
        }

        private void sort_players_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string type = button.Text.Split(' ')[1];
            if (type == "by")
            {
                type = button.Text.Split(' ')[2];
            }
            richTextBox19.Text = "";
            int cont = 0;

            if (type == "alphabetically")
            {
                pLAYERSTableAdapter.sort_players_alph(tournamentDataSet.PLAYERS);
                DataTable players = tournamentDataSet.PLAYERS;
                if (position_combo.Text == "Any")
                {
                    if (team_combo.Text == "Any")
                    {
                        for (int i = 0; i < players.Rows.Count; i++)
                        {
                            if (cont + 1 < 10)
                                richTextBox19.Text += (cont + 1) + ".     ";
                            else
                                richTextBox19.Text += (cont + 1) + ".   ";

                            richTextBox19.Text += players.Rows[i]["last_name"].ToString().Trim() + " " +
                                players.Rows[i]["first_name"].ToString().Trim() + " -- " +
                                players.Rows[i]["position"].ToString().Trim() + " -- " +
                                players.Rows[i]["shortname"].ToString().Trim() + "\n\n";
                            cont++;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < players.Rows.Count; i++)
                            if (players.Rows[i]["shortname"].ToString().Trim() == team_combo.Text)
                            {
                                if (cont + 1 < 10)
                                    richTextBox19.Text += (cont + 1) + ".     ";
                                else
                                    richTextBox19.Text += (cont + 1) + ".   ";

                                richTextBox19.Text += players.Rows[i]["last_name"].ToString().Trim() + " " +
                                players.Rows[i]["first_name"].ToString().Trim() + " -- " +
                                players.Rows[i]["position"].ToString().Trim() + " -- " +
                                players.Rows[i]["shortname"].ToString().Trim() + "\n\n";
                                cont++;
                            }
                    }
                }
                else
                {
                    if (team_combo.Text == "Any")
                    {
                        for (int i = 0; i < players.Rows.Count; i++)
                            if (players.Rows[i]["position"].ToString().Trim() == position_combo.Text)
                            {
                                if (cont + 1 < 10)
                                    richTextBox19.Text += (cont + 1) + ".     ";
                                else
                                    richTextBox19.Text += (cont + 1) + ".   ";

                                richTextBox19.Text += players.Rows[i]["last_name"].ToString().Trim() + " " +
                                players.Rows[i]["first_name"].ToString().Trim() + " -- " +
                                players.Rows[i]["position"].ToString().Trim() + " -- " +
                                players.Rows[i]["shortname"].ToString().Trim() + "\n\n";
                                cont++;

                            }
                    }
                    else
                    {
                        for (int i = 0; i < players.Rows.Count; i++)
                            if (players.Rows[i]["shortname"].ToString().Trim() == team_combo.Text && players.Rows[i]["position"].ToString().Trim() == position_combo.Text)
                            {
                                if (cont + 1 < 10)
                                    richTextBox19.Text += (cont + 1) + ".     ";
                                else
                                    richTextBox19.Text += (cont + 1) + ".   ";

                                richTextBox19.Text += players.Rows[i]["last_name"].ToString().Trim() + " " +
                                players.Rows[i]["first_name"].ToString().Trim() + " -- " +
                                players.Rows[i]["position"].ToString().Trim() + " -- " +
                                players.Rows[i]["shortname"].ToString().Trim() + "\n\n";
                                cont++;
                            }
                    }
                }
            }
            else if (type == "height")
            {
                pLAYERSTableAdapter.sort_players_height(tournamentDataSet.PLAYERS);
                DataTable players = tournamentDataSet.PLAYERS;
                if (position_combo.Text == "Any")
                {
                    if (team_combo.Text == "Any")
                    {
                        for (int i = 0; i < players.Rows.Count; i++)
                        {
                            if (cont + 1 < 10)
                                richTextBox19.Text += (cont + 1) + ".     ";
                            else
                                richTextBox19.Text += (cont + 1) + ".   ";

                            richTextBox19.Text += players.Rows[i]["last_name"].ToString().Trim() + " " +
                                players.Rows[i]["first_name"].ToString().Trim() + " -- " +
                                players.Rows[i]["position"].ToString().Trim() + " -- " +
                                players.Rows[i]["shortname"].ToString().Trim() + " -- " +
                                players.Rows[i]["height"].ToString().Trim() + " cm\n\n";
                            cont++;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < players.Rows.Count; i++)
                            if (players.Rows[i]["shortname"].ToString().Trim() == team_combo.Text)
                            {
                                if (cont + 1 < 10)
                                    richTextBox19.Text += (cont + 1) + ".     ";
                                else
                                    richTextBox19.Text += (cont + 1) + ".   ";

                                richTextBox19.Text += players.Rows[i]["last_name"].ToString().Trim() + " " +
                                players.Rows[i]["first_name"].ToString().Trim() + " -- " +
                                players.Rows[i]["position"].ToString().Trim() + " -- " +
                                players.Rows[i]["shortname"].ToString().Trim() + " -- " +
                                players.Rows[i]["height"].ToString().Trim() + " cm\n\n";
                                cont++;
                            }
                    }
                }
                else
                {
                    if (team_combo.Text == "Any")
                    {
                        for (int i = 0; i < players.Rows.Count; i++)
                            if (players.Rows[i]["position"].ToString().Trim() == position_combo.Text)
                            {
                                if (cont + 1 < 10)
                                    richTextBox19.Text += (cont + 1) + ".     ";
                                else
                                    richTextBox19.Text += (cont + 1) + ".   ";

                                richTextBox19.Text += players.Rows[i]["last_name"].ToString().Trim() + " " +
                                players.Rows[i]["first_name"].ToString().Trim() + " -- " +
                                players.Rows[i]["position"].ToString().Trim() + " -- " +
                                players.Rows[i]["shortname"].ToString().Trim() + " -- " +
                                players.Rows[i]["height"].ToString().Trim() + " cm\n\n";
                                cont++;

                            }
                    }
                    else
                    {
                        for (int i = 0; i < players.Rows.Count; i++)
                            if (players.Rows[i]["shortname"].ToString().Trim() == team_combo.Text && players.Rows[i]["position"].ToString().Trim() == position_combo.Text)
                            {
                                if (cont + 1 < 10)
                                    richTextBox19.Text += (cont + 1) + ".     ";
                                else
                                    richTextBox19.Text += (cont + 1) + ".   ";

                                richTextBox19.Text += players.Rows[i]["last_name"].ToString().Trim() + " " +
                                players.Rows[i]["first_name"].ToString().Trim() + " -- " +
                                players.Rows[i]["position"].ToString().Trim() + " -- " +
                                players.Rows[i]["shortname"].ToString().Trim() + " -- " +
                                players.Rows[i]["height"].ToString().Trim() + " cm\n\n";
                                cont++;
                            }
                    }
                }

            }
            else
            {
                for(int i=0;i<59;i++)
                    for (int j = i + 1; j < 60; j++)
                        if (points[i] < points[j])
                        {
                            int aux = points[i];
                            points[i] = points[j];
                            points[j] = aux;

                            string aux2 = player_names[i];
                            player_names[i] = player_names[j];
                            player_names[j] = aux2;
                        }
                if (position_combo.Text == "Any")
                {
                    if (team_combo.Text == "Any")
                    {
                        for (int i = 0; i < 60; i++)
                        {
                            if (cont + 1 < 10)
                                richTextBox19.Text += (cont + 1) + ".     ";
                            else
                                richTextBox19.Text += (cont + 1) + ".   ";

                            richTextBox19.Text += player_names[i] + " -- " + points[i] + " points\n\n";
                            cont++;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < 60; i++)
                            if (player_names[i].Split(' ')[5] == team_combo.Text)
                            {
                                if (cont + 1 < 10)
                                    richTextBox19.Text += (cont + 1) + ".     ";
                                else
                                    richTextBox19.Text += (cont + 1) + ".   ";

                                richTextBox19.Text += player_names[i] + " -- " + points[i] + " points\n\n"; ;
                                cont++;
                            }
                    }
                }
                else
                {
                    if (team_combo.Text == "Any")
                    {
                        for (int i = 0; i < 60; i++)
                            if (player_names[i].Split(' ')[3] == position_combo.Text)
                            {
                                if (cont + 1 < 10)
                                    richTextBox19.Text += (cont + 1) + ".     ";
                                else
                                    richTextBox19.Text += (cont + 1) + ".   ";

                                richTextBox19.Text += player_names[i] + " -- " + points[i] + " points\n\n";
                                cont++;

                            }
                    }
                    else
                    {
                        for (int i = 0; i < 60; i++)
                            if (player_names[i].Split(' ')[5] == team_combo.Text && player_names[i].Split(' ')[3] == position_combo.Text)
                            {
                                if (cont + 1 < 10)
                                    richTextBox19.Text += (cont + 1) + ".     ";
                                else
                                    richTextBox19.Text += (cont + 1) + ".   ";

                                richTextBox19.Text += player_names[i] + " -- " + points[i] + " points\n\n";
                                cont++;
                            }
                    }
                }

            }




        }

        private void winner_button_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = winnerPage;
        }


    }        
}
