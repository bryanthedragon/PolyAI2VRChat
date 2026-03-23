using AIToVRChat.AI.Platform.Manager;
using AIToVRChat.Platform.Generics.AI;
using UnityEngine;

namespace AI2VRChat.AI 
{
    public class AILink : MonoBehaviour
    {
        private AIPlatformManager<Platform.AIPlatform> allAIs;


        void Start()
        {
            allAIs = new AIPlatformManager<Platform.AIPlatform>();

            // Add all AI types dynamically
            allAIs.AddAI(new IAIPlatform.PolyBuzzAI());
            allAIs.AddAI(new IAIPlatform.CharacterAI());
            allAIs.AddAI(new IAIPlatform.CHAI_AI());
            allAIs.AddAI(new IAIPlatform.BlushAI());
            allAIs.AddAI(new IAIPlatform.LustAI());
            allAIs.AddAI(new IAIPlatform.SparkAI());
            allAIs.AddAI(new IAIPlatform.SaylaAI());
            allAIs.AddAI(new IAIPlatform.ZetaAI());
            allAIs.AddAI(new IAIPlatform.SukaAI());
            allAIs.AddAI(new IAIPlatform.EvaAI());
            allAIs.AddAI(new IAIPlatform.MateAI());
            allAIs.AddAI(new IAIPlatform.MeMeAI());
            allAIs.AddAI(new IAIPlatform.HanaAI());
            allAIs.AddAI(new IAIPlatform.JupiAI());
            allAIs.AddAI(new IAIPlatform.AnnaAI());
            allAIs.AddAI(new IAIPlatform.XMateAI());
            allAIs.AddAI(new IAIPlatform.RubiiAI());
            
        }
    }
}