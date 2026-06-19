namespace PolyBuzzToVRChat.Platform.Generics.Models
{
    public interface IModels
    {

    }

    namespace Pokemon
    {
        public interface IPkModels : IModels
        {

        }
    }

    namespace HelluvaBoss
    {
        public interface IHelluvaBossModels : IModels
        {

        }
    }

    namespace Nintendo
    {
        public interface INintendoModels : IModels
        {

        }
    }

    namespace Sega
    {
        public interface ISegaModels : IModels
        {

        }
    }

    namespace Xbox
    {
        public interface IXboxModels : IModels
        {

        }
    }

    namespace Anime
    {
        public interface IAnimeModels : IModels
        {

        }

        namespace MHA
        {
            public interface IMHAModels : IAnimeModels
            {

            }
        }

        namespace JJK
        {
            public interface IJJKModels : IAnimeModels
            {

            }
        }
        namespace MLP
        {
            public interface IMLPModels : IModels
            {

            }
        }

        namespace PawPatrol
        {
            public interface IPawPatrolModels : IModels
            {

            }
        }

        namespace FNAF
        {
            public interface IFNAFModels : IModels
            {

            }
        }
    }
}