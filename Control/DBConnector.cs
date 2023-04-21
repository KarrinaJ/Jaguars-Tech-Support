using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Policy;
using System.Configuration;
using System.ComponentModel;
using System.Data.Entity.ModelConfiguration.Configuration;
using Microsoft.SqlServer.Server;
using System.Data;
using GUIForJTS;

namespace Control
{
    internal class DBConnector:Controller
    {

        public static void IntializeDB()
        {
            string dbFile = @"Data source = Z:\JTS Project\JTSwGUI.db; Version=3;"; //data source will change when finalizing the project
            using (SQLiteConnection con = new SQLiteConnection(dbFile)) //checks out
            {
                con.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(con))
                {
                    // DROP TABLES IN BEGINNING, RECREATE, THEN REPOPULATE
                    string SQL_tables = @"DROP TABLE Account;
                                   DROP TABLE Tickets;
                                   DROP TABLE Event;";
                    cmd.CommandText = SQL_tables;
                    cmd.ExecuteNonQuery();

                    // RECREATE TABLES
                   SQL_tables = @"CREATE TABLE Account (Email varchar(30), Password varchar(30), UserType varchar(20), Name varchar(30), PRIMARY KEY(Email));
                            CREATE TABLE Tickets (Name varchar(30), Email varchar(30), TechName varchar(20) DEFAULT 'Unassigned', TicketNo int, Subject varchar(100), Description varchar(500), Status varchar(20) DEFAULT 'Open', FOREIGN KEY(Email) REFERENCES Account(Email), PRIMARY KEY(TicketNo));
                            CREATE TABLE Event (E_No int, Type varchar(20), Date varchar(20), Time varchar(20), PRIMARY KEY(E_No));";
                    cmd.CommandText = SQL_tables;
                    cmd.ExecuteNonQuery();

                    // REPOPULATE TABLES

                    //Account Table
                    SQL_tables = @"INSERT INTO Account (Email, Password, UserType, Name) VALUES ('tom@email.com', 'P@ssword12345', 'Customer', 'Tom Rivers');
                            INSERT INTO Account (Email, Password, UserType, Name) VALUES ('lisad@email.com', '@dminLisa6789', 'Technician', 'Lisa Dreymond');
                            INSERT INTO Account (Email, Password, UserType, Name) VALUES ('eric@email.com', 'iH@ckpe0ple4fun', 'Customer', 'Eric Liar');
                            INSERT INTO Account (Email, Password, UserType, Name) VALUES ('itsandy@email.com', 'andyth3@dmiN', 'Technician', 'Andy Greene');";
                    cmd.CommandText = SQL_tables;
                    cmd.ExecuteNonQuery();

                    //Ticket Table
                    SQL_tables = @"INSERT INTO Tickets (Name, Email, TechName, TicketNo, Subject, Description, Status) VALUES ('Tom Rivers','tom@email.com', 'Andy Greene', 1048, 'Password Reset Help', 'I forgot my password, help!', 'Closed');
                            INSERT INTO Tickets (Name, Email, TechName, TicketNo, Subject, Description, Status) VALUES ('Tom Rivers','tom@email.com', 'Eric Waters', 1103, 'No Audio Output', 'audio not working, at all. Suddenly stopped working.', 'In Progress');
                            INSERT INTO Tickets (Name, Email, TechName, TicketNo, Subject, Description, Status) VALUES ('Eric Liar','eric@email.com', 'Andrew Peterson', 1036, 'USB Ports not working', 'Windows wont detect any of my usb devices', 'In Progress');
                            INSERT INTO Tickets (Name, Email, TechName, TicketNo, Subject, Description, Status) VALUES ('Jane Sanders','janes@email.com', 'Lisa Dreymond', 1045, 'Intermittent Wifi', 'Wifi connection drops every couple of minutes, persists even after restarting computer', 'In Progress');
                            INSERT INTO Tickets (Name, Email, TechName, TicketNo, Subject, Description, Status) VALUES ('Helen Snitch','helen@email.com', 'Unassigned', 1124, 'Desktop keeps turning on and off', 'My computer powers on and off randomly without warning.', 'Open');";
                    cmd.CommandText = SQL_tables;
                    cmd.ExecuteNonQuery();

                    //Password hashing
                    string sqlHash;
                    string[] passwords = { "P@ssword12345", "@dminLisa6789", "iH@ckpe0ple4fun", "andyth3@dmiN" };
                    int[] hashes = new int [passwords.Length];
                    
                    for (int i = 0; i < passwords.Length; i++)
                    {
                        hashes[i] = passwords[i].GetHashCode();
                    }

                    sqlHash = $@"UPDATE Account SET Password = {hashes[0]} WHERE Email = 'tom@email.com';
                                UPDATE Account SET Password = {hashes[1]} WHERE Email = 'lisad@email.com';
                                UPDATE Account SET Password = {hashes[2]} WHERE Email = 'eric@email.com';
                                UPDATE Account SET Password = {hashes[3]} WHERE Email = 'itsandy@email.com';";
                    cmd.CommandText = sqlHash;
                    cmd.ExecuteNonQuery();
                    

                    //Event Table
                    //  SQL = "INSERT INTO Event () VALUES ()";
                    //   cmd.CommandText = SQL;
                    // cmd.ExecuteNonQuery();
                }
                con.Close();
            }
           
        }

        public static Account GetUser(string email, string password)
        {
            string dbFile = @"Data source = Z:\JTS Project\JTSwGUI.db; Version=3;";
            using (SQLiteConnection con = new SQLiteConnection(dbFile))
            {
                con.Open();

                string sql = $"SELECT * FROM Account where Email = '{email}' AND Password = '{password.GetHashCode()}';";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Account usr = new Account($"{reader["Email"]}", $"{password}", $"{reader["UserType"]}", $"{reader["Name"]}");
                           // SaveLogin(usr.Email);
                            
                            return usr;
                        }
                        
                        //If credentials do not match a known account, return an empty account with an error message.
                        Account emptyAccount = new Account();
                        MessageBox.Show("Credentials invalid.");
                        con.Close();
                        return emptyAccount;
                    }
                }
                
                
            }
        }

        public static TicketList<Ticket> GetTickets(Account usr)
        {
            TicketList<Ticket> txList = new TicketList<Ticket>();
            string dbFile = @"Data source = Z:\JTS Project\JTSwGUI.db; Version=3;";
            using (SQLiteConnection con = new SQLiteConnection(dbFile))
            {
                con.Open();
                //TicketList for technicians
                if (usr.UserType == "Technician")
                {
                    string sql = "SELECT * FROM Tickets;";
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Ticket ticket = new Ticket($"{reader["Name"]}", $"{reader["Email"]}", $"{reader["TechName"]}", reader.GetInt32("TicketNo"), $"{reader["Subject"]}", $"{reader["Description"]}", $"{reader["Status"]}");
                                txList.Add(ticket);
                            }
                        }
                       
                        con.Close();
                    }
                    return txList;
                }

                //TicketList for customers, should only see tickets they've created
                else if (usr.UserType == "Customer")
                {
                    string sql = $"SELECT * FROM Tickets WHERE Email = '{usr.Email}';";
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Ticket ticket = new Ticket($"{reader["Name"]}", $"{reader["Email"]}", $"{reader["TechName"]}", reader.GetInt32("TicketNo"), $"{reader["Subject"]}", $"{reader["Description"]}", $"{reader["Status"]}");
                                txList.Add(ticket);
                            }
                        }
                      
                        con.Close();
                    }
                    return txList;
                }
                else
                    return null;
            }
        }
            
        

        public static Ticket GetTicket(int ticketNo) //good to go i believe
        {
            string dbFile = @"Data source = Z:\JTS Project\JTSwGUI.db; Version=3;"; 
            using (SQLiteConnection con = new SQLiteConnection(dbFile))
            {
                con.Open();

                string sql = $"SELECT * FROM Tickets where TicketNo = {ticketNo};";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Ticket techTX = new Ticket($"{reader["Name"]}", $"{reader["Email"]}", $"{reader["TechName"]}", reader.GetInt32(3), $"{reader["Subject"]}", $"{reader["Description"]}", $"{reader["Status"]}");
                            con.Close();
                            return techTX;
                        }

                        Ticket emptyTX = null; 
                        return emptyTX;
                    }
                }

            }
        }

        public void Save(Ticket ticket)
        {

        }

        public void SaveLogin(Event type)
        {

        }

        public void SaveLogout(Event type)
        {

        }

    }
}
