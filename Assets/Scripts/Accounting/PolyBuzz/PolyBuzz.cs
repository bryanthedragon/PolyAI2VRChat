using PolyBuzzToVRChat.Accounting.Base;
using PolyBuzzToVRChat.Platform.Generics.Accounts;

namespace PolyBuzzToVRChat.Accounting.PolyBuzz
{
    public class PolybuzzAccount : Account<PolyBuzzPlatform>
    {
        public void DisplayInfo()
        {
            // Logic to display avatar information
            System.Console.WriteLine($"Name: {Name}, Bio: {Bio}, Id: {Id}, Customization: {Customization}, Tags: {string.Join(", ", Tags)}, FriendsList: {string.Join(", ", FriendsList)}");
        }

        public void LinkToPolyBuzz(PolybuzzAccount polybuzzAccount)
        {
            // Logic to link PolyBuzz account to PolyBuzz account
            this.Name = polybuzzAccount.Name;
            this.Bio = polybuzzAccount.Bio;
            this.Gender = polybuzzAccount.Gender;
            this.Id = polybuzzAccount.Id;
            this.Customization = polybuzzAccount.Customization;
            this.Tags = polybuzzAccount.Tags;
            this.FriendsList = polybuzzAccount.FriendsList;
            this.AccountLink = polybuzzAccount.AccountLink;
        }
    }
}
