using AIToVRChat.Platform.Generics.Persona;

namespace AIToVRChat.JsonLoader.Persona.Base
{
    public abstract class PersonaJsonLoader<TPersona> where TPersona : IPersona
    {
        public string Name { get; set; }
    }
}   