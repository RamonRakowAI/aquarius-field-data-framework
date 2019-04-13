﻿using System;
using System.Collections.Generic;

namespace FieldVisitHotFolderService
{
    public class Context
    {
        public string Server { get; set; }
        public string Username { get; set; } = "admin";
        public string Password { get; set; } = "admin";
        public string HotFolderPath { get; set; }
        public string FileMask { get; set; }
        public string ProcessingFolder { get; set; } = "Processing";
        public string UploadedFolder { get; set; } = "Uploaded";
        public string PartialFolder { get; set; } = "PartialUploads";
        public string FailedFolder { get; set; } = "Failed";
        public TimeSpan FileQuietDelay { get; set; } = TimeSpan.FromSeconds(5);
        public int MaximumConnectionAttempts { get; set; } = 3;
        public TimeSpan ConnectionRetryDelay { get; set; } = TimeSpan.FromMinutes(1);
        public List<string> Plugins { get; set; } = new List<string>();
    }
}
