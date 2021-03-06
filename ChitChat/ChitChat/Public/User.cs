﻿namespace ChitChat.Public
{
    using System;
    using ChitChat.Private;

    public class User
    {
        //Variables
        private int id;

        private string username;

        private string email;

        private string joinDate;

        private string ip;

        private string info;

        private string city;

        private string nation;

        private string phone;

        private string sex;

        private string name;

        private int isDonator;

        private string onlineStance;

        //Constructor
        public User(int id, string username, string email, string joinDate, string info,
                  string city, string nation, string phone, string sex, string name, int isDonator, string onlineStance)
        {
            this.id = id;
            this.username = username;
            this.email = email;
            this.joinDate = joinDate;
            this.ip = Misc.GetCurrentIPAddr();
            this.info = info;
            this.city = city;
            this.nation = nation;
            this.phone = phone;
            this.sex = sex;
            this.name = name;
            this.isDonator = isDonator;
            this.onlineStance = onlineStance;
        }


        //Properties
        /** Not supposed to be changed, so only locally */
        public int Id
        {
            get { return this.id; }
           private set { this.id = value; }
        }

        /** Not supposed to be changed, so only locally */
        public string Username
        {
            get { return this.username; }
            private set { this.username = value; }
        }

        /** Should be updated from website only */
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        /** Not supposed to be changed, so only locally */
        public string JoinDate
        {
            get { return this.joinDate; }
            private set { this.joinDate = value; }
        }

        /** Should be updated everytime, when we start the app, to check if the user has logged from different pc */
        public string IP
        {
            get
            {
                return this.ip;
            }

            set 
            {
                //Set the new ip to the variable
                this.ip = Misc.GetCurrentIPAddr();
                //Update the database with new ips
                SendRequests.UpdateUser(this.ip, ToUpdate.IP, this.id);
            }
        }

        /** Should be updated when changed */
        public string Info
        {
            get { return this.info; }
            set 
            { 
                //Set local variable
                this.info = value; 
                //Update the database
                SendRequests.UpdateUser(this.info, ToUpdate.Info, this.id);
            }
        }

        /** Should be updated when changed */
        public string City
        {
            get { return this.city; }
            set 
            { 
                //Update local variable
                this.city = value; 
                //Update database
                SendRequests.UpdateUser(this.city, ToUpdate.City, this.id);
            }
        }

        /** Should be updated when changed */
        public string Nation
        {
            get { return this.nation; }
            set 
            { 
                //Update local variable
                this.nation = value;
                //Update database
                SendRequests.UpdateUser(this.nation, ToUpdate.Nation, this.id);
            }
        }

        /** Should be updated when changed */
        public string Phone
        {
            get { return this.phone; }
            set 
            { 
                this.phone = value;
                SendRequests.UpdateUser(this.phone, ToUpdate.Phone, this.id);
            }
        }

        /** Should be updated when changed */
        public string Gender
        {
            get { return this.sex; }
            set 
            { 
                this.sex = value;
                SendRequests.UpdateUser(this.sex, ToUpdate.Gender, this.id);
            }
        }

        /** Should be updated when changed */
        public string Name
        {
            get { return this.name; }
            set 
            { 
                this.name = value;
                SendRequests.UpdateUser(this.name, ToUpdate.Name, this.id);
            }
        }

        /** Should be updated from the website only */
        public int IsDonator
        {
            get { return this.isDonator; }
            set { this.isDonator = value; }
        }

        /** Should be updated when changed */
        public string OnlineStance
        {
            get { return this.onlineStance; }
            set 
            { 
                this.onlineStance = value;
                SendRequests.UpdateUser(this.onlineStance, ToUpdate.OnlineStance, this.id);
            }
        }

        //Methods

    }
}
