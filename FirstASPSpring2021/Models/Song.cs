// Created by: Braxton Fair
// Created on: 01/26/2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstASPSpring2021.Models
{
    public class Song
    {
        // Our private variables
        private string title = "n/a";
        private string author = "n/a";
        private string recordingArtist = "n/a";
        private int seconds = -1;

        // Our getters and setters (properties)
        public string Title
        {
            get => this.title;
            set => this.title = value;
        }
        
        public string Author
        {
            get => this.author;
            set => this.author = value;
        }

        public string RecordingArtist
        {
            get => this.recordingArtist;
            set => this.recordingArtist = value;
        }

        public int Seconds
        {
            get => this.seconds;
            set => this.seconds = value;
        }

        public Song(string title, string author, string recordingArtist, int seconds)
        {
            this.Title = title;
            this.Author = author;
            this.RecordingArtist = recordingArtist;
            this.Seconds = seconds;
        }

        // Our other methods (ToString)
        public override string ToString()
        {
            string classString = 
                "Now playing: " + this.Title + "<br>" +
                "By: " + this.Author + "<br>" +
                "Recorded by: " + this.RecordingArtist + "<br>" +
                "With a runtime of: " + this.Seconds + " seconds<br><br>";

            return classString;
        }
    }
}
