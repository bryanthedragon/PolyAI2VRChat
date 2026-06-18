using PolyBuzzToVRChat.Platform.Generics.JsonLoader.Persona;

namespace PolyBuzzToVRChat.JsonLoader.Persona
{
    public abstract class PersonaJsonLoader<TPersonaJsonLoader> where TPersonaJsonLoader : IPersonaJsonLoader
    {
        public string Name { get; set; }
    }
}   