using PolyBuzzToVRChat.Platform.Generics.Persona;

namespace PolyBuzzToVRChat.JsonLoader.Persona.Base
{
    public abstract class PersonaJsonLoader<TPersona> where TPersona : IPersona
    {
        public string Name { get; set; }
    }
}   