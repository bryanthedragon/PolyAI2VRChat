using PolyBuzzToVRChat.Platform.Generics.JsonLoader.Models;

namespace PolyBuzzToVRChat.JsonLoader.Models
{
    public abstract class ModelsJsonLoader<TModelsJsonLoader> where TModelsJsonLoader : IModelsJsonLoader
    {
        public string Name { get; set; }
    }
}   