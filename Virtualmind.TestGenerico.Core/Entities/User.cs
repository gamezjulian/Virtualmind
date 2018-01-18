using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Virtualming.TestGenerico.Core.Helpers;

namespace Virtualmind.TestGenerico.Core.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public string Password
        {
            get { return this.password; }
            set
            {
                password = (!string.IsNullOrEmpty(value)) ? EncryptionHelper.GetPasswordHash(value) : string.Empty;
            }
        }

        [NotMapped]
        private string password { get; set; }
    }
}
