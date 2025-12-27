using PolyBuzzToVRChat.Accounting.Base;
using PolyBuzzToVRChat.Platform.Generics.Accounts;

namespace PolyBuzzToVRChat.Accounting.VRChat
{
    public class VRChatAccount : Account<VRChatPlatform>
    {
        public void DisplayInfo()
        {
            // Logic to display avatar information
            System.Console.WriteLine($"Name: {Name}, Bio: {Bio}, Id: {Id}, Customization: {Customization}, Tags: {string.Join(", ", Tags)}, FriendsList: {string.Join(", ", FriendsList)}");
        }

        public void LinkToVRChat(VRChatAccount VRChatAccount)
        {
            // Logic to link VRChat account to VRChat account
            this.Name = VRChatAccount.Name;
            this.Bio = VRChatAccount.Bio;
            this.Gender = VRChatAccount.Gender;
            this.Id = VRChatAccount.Id;
            this.Customization = VRChatAccount.Customization;
            this.Tags = VRChatAccount.Tags;
            this.FriendsList = VRChatAccount.FriendsList;
            this.AccountLink = VRChatAccount.AccountLink;
        }
    }
}