using System.Data;


namespace ABCCoffee.DTO
{
    public class AccountDTO
    {
        public string AccountName { get; set;  }
        public string DisplayName { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string ImagePath { get; set; }

        public AccountDTO() { }
        public AccountDTO(string accountName, string displayName, string role, string password, 
            string phone, string dob, string gender, string img)
        {
            AccountName = accountName;
            DisplayName = displayName;
            Role = role;
            Password = password;
            Phone = phone;
            DateOfBirth = dob;
            Gender = gender;
            ImagePath = img;
        }


        public AccountDTO(string accountName, string password) 
        {
            AccountName = accountName;
            Password = password;
        }
        public AccountDTO(DataRow row)
        {
            AccountName = row["AccountName"].ToString();
            DisplayName = row["DisplayName"].ToString();
            Password = row["AccountPassword"].ToString();
            Phone = row["Phone"].ToString();
            DateOfBirth = row["DateOfBirth"].ToString();
            Gender = row["Gender"].ToString();
            ImagePath = row["ImagePath"].ToString();
            Role = row["AccountRole"].ToString();
        }
    }
}
