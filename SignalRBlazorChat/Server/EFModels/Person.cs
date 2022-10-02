using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SignalRBlazorChat.Server.EFModels
{
    public partial class Person
    {
        [Key] public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
