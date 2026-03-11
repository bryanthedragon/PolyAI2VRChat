using PolyBuzzToVRChat.Accounting.Base;
using PolyBuzzToVRChat.Platform.Generics.Accounts;

namespace PolyBuzzToVRChat.Accounting.Steam
{
    public class SteamAccount : Account<SteamPlatform>
    {
        public new void DisplayInfo()
        {
            // Logic to display avatar information
            System.Console.WriteLine($"Name: {Name}, Bio: {Bio}, Id: {Id}, Customization: {Customization}, Tags: {string.Join(", ", Tags)}, FriendsList: {string.Join(", ", FriendsList)}");
        }

        public void LinkToSteam(SteamAccount steamAccount)
        {
            // Logic to link PolyBuzz account to PolyBuzz account
            this.Name = steamAccount.Name;
            this.Bio = steamAccount.Bio;
            this.Gender = steamAccount.Gender;
            this.Id = steamAccount.Id;
            this.Customization = steamAccount.Customization;
            this.Tags = steamAccount.Tags;
            this.FriendsList = steamAccount.FriendsList;
            this.AccountLink = steamAccount.AccountLink;
        }
    }
}
