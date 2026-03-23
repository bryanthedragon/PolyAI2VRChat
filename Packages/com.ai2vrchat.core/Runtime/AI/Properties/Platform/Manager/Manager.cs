using System.Collections.Generic;
using AI2VRChat.AI.Platform;
using AIToVRChat.Platform.Generics.AI;
using UnityEngine;

namespace AIToVRChat.AI.Platform.Manager
{
    public class AIPlatformManager<TAIPlatform> where TAIPlatform : AIPlatform
    {

        private List<TAIPlatform> ais = new();
        
        public string GetName()
        {
            return typeof(TAIPlatform).Name;
        }

        public void AddAI(TAIPlatform ai) {
            ais.Add(ai);
        }
        
        public void RemoveAI(TAIPlatform ai) 
        {
            ais.Remove(ai);
        }
        
        public List<TAIPlatform> GetAIs() 
        {
            return ais;
        }

        public string GetAIName(TAIPlatform ai) 
        {
            return ai.GetName();
        }

        public string GetAllNames()
        {
            if (ais.Count == 0) 
            {
                return "No AIs";
            }
            
            var names = new List<string>();
            
            foreach (var ai in ais)
            {
                names.Add(ai.GetName());
            }
            
            return string.Join(", ", names);
        }

        public void PrintAll()
        {
            Debug.Log(GetAllNames());
        }

        internal void AddAI(IAIPlatform.CHAI_AI CHAI_AI)
        {
            GetName();
        }

        internal void AddAI(IAIPlatform.CharacterAI characterAI)
        {
            GetName();
        }

        internal void AddAI(IAIPlatform.PolyBuzzAI polyBuzzAI)
        {
            GetName();
        }

        internal void AddAI(IAIPlatform.LustAI lustAI)
        {
            GetName();
        }

        internal void AddAI(IAIPlatform.SparkAI sparkAI)
        {
            GetName();
        }

        internal void AddAI(IAIPlatform.SaylaAI saylaAI)
        {
            GetName();
        }

        internal void AddAI(IAIPlatform.ZetaAI zetaAI)
        {
            GetName();
        }

        internal void AddAI(IAIPlatform.SukaAI sukaAI)
        {
            GetName();
        }

        internal void AddAI(IAIPlatform.EvaAI evaAI)
        {
            GetName();
        }

        internal void AddAI(IAIPlatform.MateAI mateAI)
        {
            GetName();
        }

        internal void AddAI(IAIPlatform.MeMeAI meMeAI)
        {
            GetName();
        }

        internal void AddAI(IAIPlatform.HanaAI hanaAI)
        {
            GetName();
        }

        internal void AddAI(IAIPlatform.JupiAI jupiAI)
        {
            GetName();
        }

        internal void AddAI(IAIPlatform.AnnaAI annaAI)
        {
            GetName();
        }

        internal void AddAI(IAIPlatform.XMateAI xMateAI)
        {
            GetName();
        }

        internal void AddAI(IAIPlatform.RubiiAI rubiiAI)
        {
            GetName();
        }

        internal void AddAI(IAIPlatform.BlushAI blushAI)
        {
            GetName();
        }
    }
}