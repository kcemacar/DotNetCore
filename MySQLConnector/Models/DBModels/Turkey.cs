using System;
using System.Collections.Generic;

namespace MySQLConnectionWithDotNetCore.Models.DBModels
{
    public partial class Turkey
    {
        public int Id { get; set; }
        public int Temp { get; set; }
        public int Rain { get; set; }
    }
}
