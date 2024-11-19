using System;


namespace RoomateFinderEngne
{
    /// <summary>
    /// used to send an array of User Info string during an event.
    /// </summary>
    public class UserInfoEventArgs : EventArgs
    {
        private string[] userInfo;

        public UserInfoEventArgs(string username, string password, string bio)
        {
            this.userInfo = new string[] { username, password, bio };
        }

        public string[] UserInfo
        { get { return userInfo; } }
    }
}
