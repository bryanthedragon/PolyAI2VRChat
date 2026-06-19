namespace PolyBuzzToVRChat.Platform.Generics.JsonLoader.Models
{
    public interface IModelsJsonLoader
    {
        
    }

    namespace Pokemon
    {
        public class PokemonModelJsonLoader : IModelsJsonLoader
        {
            
        }
    }

    namespace MLP
    {
        public class MLPModelJsonLoader : IModelsJsonLoader
        {
            
        }
    }

    namespace PawPatrol
    {
        public class PawPatrolModelJsonLoader : IModelsJsonLoader
        {
            
        }   
    }

    namespace FNAF
    {
        public class FNAFModelJsonLoader : IModelsJsonLoader
        {
            
        }        
    }

    namespace HelluvaBoss
    {
        public interface IHelluvaBossModelsJsonLoader : IModelsJsonLoader
        {
            
        }
    }

    namespace Nintendo
    {
        public interface INintendoModelsJsonLoader : IModelsJsonLoader
        {
            
        }
    }
    
    namespace Sega
    {
        public interface ISegaModelsJsonLoader : IModelsJsonLoader
        {
            
        }
    }

    namespace Xbox
    {
        public interface IXboxModelsJsonLoader : IModelsJsonLoader
        {
            
        }
    }

    namespace Anime
    {
        public interface IAnimeModelsJsonLoader : IModelsJsonLoader
        {
            
        }

        namespace MHA
        {
            public interface IMHAModelsJsonLoader : IAnimeModelsJsonLoader
            {
                
            }
        }

        namespace JJK
        {
            public interface IJJKModelsJsonLoader : IAnimeModelsJsonLoader
            {
                
            }
        }
    }
}