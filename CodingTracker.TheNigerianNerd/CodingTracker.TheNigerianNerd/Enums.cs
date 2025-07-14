﻿using System.ComponentModel.DataAnnotations;

namespace CodingTracker.TheNigerianNerd
{
    internal class Enums
    {
        internal enum MainMenuChoices{
            [Display(Name = "Add Record")]
            AddRecord,

            [Display(Name = "View Records")]
            ViewRecords,

            [Display(Name = "Delete Record")]
            DeleteRecord,

            [Display(Name = "Update Record")]
            UpdateRecord,

            Quit
        }
    }
}
