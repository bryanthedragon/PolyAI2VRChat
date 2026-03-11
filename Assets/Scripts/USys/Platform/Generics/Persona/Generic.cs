namespace PolyBuzzToVRChat.Platform.Generics.Persona
{
    public interface IPersona
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Occupation { get; set; }
        public string Background { get; set; }
        public int PersonaId { get; set; }

        public void DisplayInfo()
        {
            System.Console.WriteLine($"Name: {Name}");
            System.Console.WriteLine($"Age: {Age}");
            System.Console.WriteLine($"Gender: {Gender}");
            System.Console.WriteLine($"Occupation: {Occupation}");
            System.Console.WriteLine($"Background: {Background}");
            System.Console.WriteLine($"PersonaId: {PersonaId}");
        }
    }
    public sealed class VRChatPersona : IPersona
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Occupation { get; set; }
        public string Background { get; set; }
        public int PersonaId { get; set; }
    }
    public sealed class PolyBuzzPersona : IPersona
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Occupation { get; set; }
        public string Background { get; set; }
        public int PersonaId { get; set; }
    }
    public sealed class SteamPersona : IPersona
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Occupation { get; set; }
        public string Background { get; set; }
        public int PersonaId { get; set; }
    }
}