using AIToVRChat.Platform.Generics.Persona;

namespace AIToVRChat.Persona.Base
{
    public abstract class Persona<TPersona> where TPersona : IPersona
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int PersonaId { get; set; }

        public string DisplayInfo()
        {
            return $"Name: {Name}, Description: {Description}, PersonaId: {PersonaId}";
        }
    }
}