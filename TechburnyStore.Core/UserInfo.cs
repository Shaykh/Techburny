namespace TechburnyStore.Core
{
    public class UserInfo : IUserInfo
    {
        public string UserName { get; set; }

        public string Email { get; set; }

        public string Role { get; set; }

        public string GivenName { get; set; }

        public string MiddleName { get; set; }

        public string FamilyName { get; set; }
        
        public UserInfo()
        {
        }

        public UserInfo(string userName)
        {
            UserName = userName;
        }

    }
}