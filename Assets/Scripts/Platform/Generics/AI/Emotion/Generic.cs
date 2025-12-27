using PolyBuzzToVRChat.Platform.Generics.AI.Emotion.Type;

namespace PolyBuzzToVRChat.Platform.Generics.AI.Emotion
{
    public interface IAIEmotion
    {
        // Emotion execution logic goes here

        // Get emotion
        void GetEmotion();

        // Set emotion
        EmotionType SetEmotion();

        // Happiness
        bool isHappy { get; set; }

        // Sadness
        bool isSad { get; set; }
        
        // Anger
        bool isAngry { get; set; }

        // Fear
        bool isFear { get; set; }

        // Disgust
        bool isDisgust { get; set; }

        // Surprise
        bool isSurprise { get; set; }

        // Excitement
        bool isExcite { get; set; }

        // Annoyance
        bool isAnnoy { get; set; }
        
        // Boredom
        bool isBoredom { get; set; }

        // Neutral
        bool isNeutral { get; set; }

        // Motherly 
        bool isMotherly { get; set; }

        // Fatherly
        bool isFatherly { get; set; }

        // Childlike
        bool isChildlike { get; set; }

        // Admiration
        bool isAdmire { get; set; }

        // Appreciation
        bool isAppreciate { get; set; }

        // Respect
        bool isRespect { get; set; }

        // Love
        bool isLove { get; set; }

        // Trust
        bool isTrust { get; set; }

        // Anticipation
        bool isAnticipate { get; set; }

        // Disapproval
        bool isDisapprove { get; set; }

        // Awe
        bool isAwe { get; set; }
        
        // Pride
        bool isPride { get; set; }

        // Humility
        bool isHumility { get; set; }

        // Humor
        bool isHumorous { get; set; }

        // Confidence
        bool isConfident { get; set; }

        // Embarrassment
        bool isEmbarrass { get; set; }

        // Guilt
        bool isGuilt { get; set; }

        // Shame
        bool isShame { get; set; }

        // Regret
        bool isRegret { get; set; }

        // Gratitude
        bool isGrate { get; set; }

        // Sympathy
        bool isSympathetic { get; set; }

        // Empathy
        bool isEmpathetic { get; set; }

        // Compassion
        bool isCompassion { get; set; }

        // Contempt
        bool isContempt { get; set; }

        // Disdain
        bool isDisdain { get; set; }

        // Despair
        bool isDespair { get; set; }

        // Envy
        bool isEnvious { get; set; }

        // Jealousy
        bool isJealous { get; set; }

        // Frustration
        bool isFrustrate { get; set; }

        // Hope
        bool isHope { get; set; }

        // Hopeless
        bool isHopeless { get; set; }

        // Comfort
        bool isComfort { get; set; }

        // Goofy
        bool isGoofy { get; set; }

        // Disappointment
        bool isDisappoint { get; set; }

        // Mistrust
        bool isMistrust { get; set; }

        // Play
        bool isPlay { get; set; }

        // Relax
        bool isRelax { get; set; }

        // Relief
        bool isRelief { get; set; }

        // Grumpy
        bool isGrumpy { get; set; }

        // Envy
        bool isEnvy { get; set; }

        // Confusion
        bool isConfusion { get; set; }

        // Grief
        bool isGrief { get; set; }

        // Rage
        bool isRage { get; set; }

        // Panic
        bool isPanic { get; set; }

        // Sorrow
        bool isSorrow { get; set; }

        // Anger
        bool isAnger { get; set; }

        // Hate
        bool isHate { get; set; }

        // Joy
        bool isJoy { get; set; }

        // Cheerful
        bool isCheerful { get; set; }

        // Loyalty
        bool isLoyal { get; set; }

        // Sincere
        bool isSincere { get; set; }

        // Faith
        bool isFaith { get; set; }

        // Doubt
        bool isDoubt { get; set; }

        // Fearless
        bool isFearless { get; set; }

        // Interest
        bool isInterest { get; set; } 
        
        // Disinterest
        bool isDisinterest { get; set; }

        // Eager
        bool isEager { get; set; }

        // Professional
        bool isProfessional { get; set; }

        // Passion
        bool isPassionate { get; set; }

        /// <summary>
        /// Comfort execution logic goes here
        /// </summary>
        /// <remarks>
        /// If the AI is not already feeling Comfort, this will set isComfort to true and isNeutral to false.
        /// </remarks>
        public void Comfort()
        {
            // Comfort execution logic goes here
            if (isComfort != false)
            {
                isComfort = true;
                isNeutral = false;
            }
        }
        
        /// <summary>
        /// Surprise execution logic goes here
        /// </summary>
        /// <remarks>
        /// If the AI is not already feeling Surprise, this will set isSurprise to true and isNeutral to false.
        /// </remarks>
        public void Surprise()
        {
            // Surprise execution logic goes here
            if (isSurprise == false)
            {
                isSurprise = true;
                isNeutral = false;
            }
        }
        
        /// <summary>
        /// Annoyance execution logic goes here
        /// </summary>
        /// <remarks>
        /// If the AI is not already feeling Annoyance, this will set isAnnoyance to true and isNeutral to false.
        /// </remarks>
        public void Annoy()
        {
            // Annoyance execution logic goes here
            if (isAnnoy == false)
            {
                isAnnoy = true;
                isNeutral = false;
            }
        }
        
        /// <summary>
        /// Boredom execution logic goes here
        /// </summary>
        /// <remarks>
        /// If the AI is not already feeling Boredom, this will set isBoredom to true and isNeutral to false.
        /// </remarks>
        public void Boredom()
        {
            // Boredom execution logic goes here
            if (isBoredom == false)
            {
                isBoredom = true;
                isNeutral = false;
            }
        }
        
        /// <summary>
        /// Disgust execution logic goes here
        /// </summary>
        /// <remarks>
        /// If the AI is not already feeling Disgust, this will set isDisgust to true and isNeutral to false.
        /// </remarks>
        public void Disgust()
        {
            // Disgust execution logic goes here
            if (isDisgust == false)
            {
                isDisgust = true;
                isNeutral = false;
            }
        }
        
        /// <summary>
        /// Fear execution logic goes here
        /// </summary>
        /// <remarks>
        /// If the AI is not already feeling Disgust, this will set isDisgust to true and isNeutral to false.
        /// </remarks>
        public void Fear()
        {
            // Fear execution logic goes here
            if (isFear == false)
            {
                isFear = true;
                isNeutral = false;
            }
        }
        
        /// <summary>
        /// Anger execution logic goes here
        /// </summary>
        /// <remarks>
        /// If the AI is not already feeling Disgust, this will set isDisgust to true and isNeutral to false.
        /// </remarks>
        public void Angry()
        {
            // Anger execution logic goes here
            if (isAngry == false)
            {
                isAngry = true;
                isNeutral = false;
            }
        }
        
        /// <summary>
        /// Happiness execution logic goes here
        /// </summary>
        /// <remarks>
        /// If the AI is not already feeling Disgust, this will set isDisgust to true and isNeutral to false.
        /// </remarks>
        public void Happy()
        {
            // Happiness execution logic goes here
            if (isHappy == false)
            {
                isHappy = true;
                isNeutral = false;
            }
        }
        
        /// <summary>
        /// Sadness execution logic goes here
        /// </summary>
        /// <remarks>
        /// If the AI is not already feeling Disgust, this will set isDisgust to true and isNeutral to false.
        /// </remarks>
        public void Sad()
        {
            // Sadness execution logic goes here
            if (isSad == false)
            {
                isSad = true;
                isNeutral = false;
            }
        }
        
        /// <summary>
        /// Neutral execution logic goes here
        /// </summary>
        /// <remarks>
        /// If the AI is not already feeling Disgust, this will set isDisgust to true and isNeutral to false.
        /// </remarks>
        public void Neutral()
        {
            // Neutral execution logic goes here
            if (isNeutral == false)
            {
                isNeutral = true;
                isHappy = false;
                isSad = false;
                isAngry = false;
                isFear = false;
                isDisgust = false;
                isSurprise = false;
                isExcite = false;
                isAnnoy = false;
                isBoredom = false;
                isComfort = false;
                isMotherly = false;
                isFatherly = false;
                isChildlike = false;
                isAdmire = false;
                isAppreciate = false;
                isRespect = false;
                isLove = false;
                isTrust = false;
                isAnticipate = false;
                isDisapprove = false;
                isAwe = false;
                isPride = false;
                isHumility = false;
                isHumorous = false;
                isConfident = false;
                isEmbarrass = false;
                isGuilt = false;
                isShame = false;
                isRegret = false;
                isGrate = false;
                isSympathetic = false;
                isEmpathetic = false;
                isCompassion = false;
                isContempt = false;
                isDisdain = false;
                isDespair = false;            
                isEnvious = false;
                isJealous = false;
                isFrustrate = false;
                isHope = false;
                isHopeless = false;
                isDisappoint = false;
                isMistrust = false;
                isPlay = false;
                isRelax = false;
                isRelief = false;
                isGrumpy = false;
                isEnvy = false;
                isConfusion = false;
                isGrief = false;
                isRage = false;
                isPanic = false;
                isSorrow = false;
                isGuilt = false;
                isAnger = false;
                isHate = false;
                isJoy = false;
                isCheerful = false;
                isFearless = false;
                isFaith = false;
                isDoubt = false;
            }
        }
        
        /// <summary>
        /// Excitement execution logic goes here
        /// </summary>
        /// <remarks>
        /// If the AI is not already feeling Disgust, this will set isDisgust to true and isNeutral to false.
        /// </remarks>
        public void Excite()
        {
            // Excitement execution logic goes here
            if (isExcite == false)
            {
                isExcite = true;
                isNeutral = false;
            }
        }
        
        /// <summary>
        /// Admiration execution logic goes here
        /// </summary>
        /// <remarks>
        /// If the AI is not already feeling Disgust, this will set isDisgust to true and isNeutral to false.
        /// </remarks>
        public void Admire()
        {
            // Admiration execution logic goes here
            if (isAdmire == false)
            {
                isAdmire = true;
                isNeutral = false;
            }
        }
        
        /// <summary>
        /// Appreciation execution logic goes here
        /// </summary>
        /// <remarks>
        /// If the AI is not already feeling Disgust, this will set isDisgust to true and isNeutral to false.
        /// </remarks>
        public void Appreciate()
        {
            // Appreciation execution logic goes here
            if (isAppreciate == false)
            {
                isAppreciate = true;
                isNeutral = false;
            }
        }
        
        /// <summary>
        /// Respect execution logic goes here
        /// </summary>
        /// <remarks>
        /// If the AI is not already feeling Disgust, this will set isDisgust to true and isNeutral to false.
        /// </remarks>
        public void Respect()
        {
            // Respect execution logic goes here
            if (isRespect == false)
            {
                isRespect = true;
                isNeutral = false;
            }
        }
        
        /// <summary>
        /// Love execution logic goes here
        /// </summary>
        /// <remarks>
        /// If the AI is not already feeling Love, this will set isLove to true and isNeutral to false.
        /// </remarks>
        public void Love()
        {
            // Love execution logic goes here
            if (isLove == false)
            {
                isLove = true;
                isNeutral = false;
            }
        }
        
        /// <summary>
        /// Trust execution logic goes here
        /// </summary>
        /// <remarks>
        /// If the AI is not already feeling Trust, this will set isTrust to true and isNeutral to false.
        /// </remarks>
        public void Trust()
        {
            // Trust execution logic goes here
            if (isTrust == false)
            {
                isTrust = true;
                isNeutral = false;
            }
        }
        
        /// <summary>
        /// Anticipation execution logic goes here
        /// </summary>
        /// <remarks>
        /// If the AI is not already feeling Anticipation, this will set isAnticipate to true and isNeutral to false.
        /// </remarks>
        public void Anticipate()
        {
            // Anticipation execution logic goes here
            if (isAnticipate == false)
            {
                isAnticipate = true;
                isNeutral = false;
            }
        }
        
        /// <summary>
        /// Disapproval execution logic goes here
        /// </summary>
        /// <remarks>
        /// If the AI is not already feeling Disapproval, this will set isDisapproval to true and isNeutral to false.
        /// </remarks>
        public void Disapprove()
        {
            // Disapproval execution logic goes here
            if (isDisapprove == false)
            {
                isDisapprove = true;
                isNeutral = false;
            }
        }
        
        /// <summary>
        /// Awe execution logic goes here
        /// </summary>
        /// <remarks>
        /// If the AI is not already feeling Awe, this will set isAwe to true and isNeutral to false.
        /// </remarks>
        public void Awe()
        {
            // Awe execution logic goes here
            if (isAwe == false)
            {
                isAwe = true;
                isNeutral = false;
            }
        }
        
        /// <summary>
        /// Pride execution logic goes here
        /// </summary>
        /// <remarks>
        /// If the AI is not already feeling Pride, this will set isPride to true and isNeutral to false.
        /// </remarks>
        public void Pride()
        {
            // Pride execution logic goes here
            if (isPride == false)
            {
                isPride = true;
                isNeutral = false;
            }
        }
        
        /// <summary>
        /// Humility execution logic goes here
        /// </summary>
        /// <remarks>
        /// If the AI is not already feeling Humility, this will set isHumility to true and isNeutral to false.
        /// </remarks>
        public void Humility()
        {
            // Humility execution logic goes here
            if (isHumility == false)
            {
                isHumility = true;
                isNeutral = false;
            }
        }
        
        /// <summary>
        /// Humor execution logic goes here
        /// </summary>
        /// <remarks>
        /// If the AI is not already feeling Humor, this will set isHumorous to true and isNeutral to false.
        /// </remarks>
        public void Humor()
        {
            // Humor execution logic goes here
            if (isHumorous == false)
            {
                isHumorous = true;
                isNeutral = false;
            }
        }
        
        /// <summary>
        /// Confidence execution logic goes here
        /// </summary>
        /// <remarks>
        /// If the AI is not already feeling Confidence, this will set isConfident to true and isNeutral to false.
        /// </remarks>
        public void Confidence()
        {
            // Confidence execution logic goes here
            if (isConfident == false)
            {
                isConfident = true;
                isNeutral = false;
            }
        }
        
        /// <summary>
        /// Embarrassment execution logic goes here
        /// </summary>
        /// <remarks>
        /// If the AI is not already feeling Embarrassment, this will set isEmbarrass to true and isNeutral to false.
        /// </remarks>
        public void Embarrass()
        {
            // Embarrassment execution logic goes here
            if (isEmbarrass == false)
            {
                isEmbarrass = true;
                isNeutral = false;
            }
        }
        
        /// <summary>
        /// Guilt execution logic goes here
        /// </summary>
        /// <remarks>
        /// If the AI is not already feeling Guilt, this will set isGuilt to true and isNeutral to false.
        /// </remarks>
        public void Guilt()
        {
            // Guilt execution logic goes here
            if (isGuilt == false)
            {
                isGuilt = true;
                isNeutral = false;
            }
        }
        
        /// <summary>
        /// Shame execution logic goes here
        /// </summary>
        /// <remarks>
        /// If the AI is not already feeling Shame, this will set isShame to true and isNeutral to false.
        /// </remarks>
        public void Shame()
        {
            // Shame execution logic goes here
            if (isShame == false)
            {
                isShame = true;
                isNeutral = false;
            }
        }   
        
        /// <summary>
        /// Regret execution logic goes here
        /// </summary>
        /// <remarks>
        /// If the AI is not already feeling Regret, this will set isRegret to true and isNeutral to false.
        /// </remarks>
        public void Regret()
        {
            // Regret execution logic goes here
            if (isRegret == false)
            {
                isRegret = true;
                isNeutral = false;
            }
        }
        
        /// <summary>
        /// Gratitude execution logic goes here
        /// </summary>
        /// <remarks>
        /// If the AI is not already feeling Gratitude, this will set isGrate to true and isNeutral to false.
        /// </remarks>
        public void Gratitude()
        {
            // Gratitude execution logic goes here
            if (isGrate == false)
            {
                isGrate = true;
                isNeutral = false;
            }
        }
        
        /// <summary>
        /// Sympathy execution logic goes here
        /// </summary>
        /// <remarks>
        /// If the AI is not already feeling Sympathy, this will set isSympathetic to true and isNeutral to false.
        /// </remarks>
        public void Sympathy()
        {
            // Sympathy execution logic goes here
            if (isSympathetic == false)
            {
                isSympathetic = true;
                isNeutral = false;
            }
        }
        
        /// <summary>
        /// Empathy execution logic goes here
        /// </summary>
        /// <remarks>
        /// If the AI is not already feeling Empathy, this will set isEmpathetic to true and isNeutral to false.
        /// </remarks>
        public void Empathy()
        {
            // Empathy execution logic goes here
            if (isEmpathetic == false)
            {
                isEmpathetic = true;
                isNeutral = false;
            }
        }
        
        /// <summary>
        /// Compassion execution logic goes here
        /// </summary>
        /// <remarks>
        /// If the AI is not already feeling Compassion, this will set isCompassion to true and isNeutral to false.
        /// </remarks>
        public void Compassion()
        {
            // Compassion execution logic goes here
            if (isCompassion == false)
            {
                isCompassion = true;
                isNeutral = false;
            }
        }
        
        /// <summary>
        /// Contempt execution logic goes here
        /// </summary>
        /// <remarks>
        /// If the AI is not already feeling Contempt, this will set isContempt to true and isNeutral to false.
        /// </remarks>
        public void Contempt()
        {
            // Contempt execution logic goes here
            if (isContempt == false)
            {
                isContempt = true;
                isNeutral = false;
            }
        }
        
        /// <summary>
        /// Disdain execution logic goes here
        /// </summary>
        /// <remarks>
        /// If the AI is not already feeling Disdain, this will set isDisdain to true and isNeutral to false.
        /// </remarks>
        public void Disdain()
        {
            // Disdain execution logic goes here
            if (isDisdain == false)
            {
                isDisdain = true;
                isNeutral = false;
            }
        }
        
        /// <summary>
        /// Despair execution logic goes here
        /// </summary>
        /// <remarks>
        /// If the AI is not already feeling Despair, this will set isDespair to true and isNeutral to false.
        /// </remarks>
        public void Despair()
        {
            // Despair execution logic goes here
            if (isDespair == false)
            {
                isDespair = true;
                isNeutral = false;
            }
        }
        
        /// <summary>
        /// Hope execution logic goes here
        /// </summary>
        /// <remarks>
        /// If the AI is not already feeling Hope, this will set isHope to true and isNeutral to false.
        /// </remarks>
        public void Hope()
        {
            // Hope execution logic goes here
            if (isHope == false)
            {
                isHope = true;
                isNeutral = false;
            }
        }
        
        /// <summary>
        /// Hopeless execution logic goes here
        /// </summary>
        /// <remarks>
        /// If the AI is not already feeling Hopeless, this will set isHopeless to true and isNeutral to false.
        /// </remarks>
        public void Hopeless()
        {
            // Hopeless execution logic goes here
            if (isHopeless == false)
            {
                isHopeless = true;
                isNeutral = false;
            }
        }
        
        /// <summary>
        /// Grief execution logic goes here
        /// </summary>
        /// <remarks>
        /// If the AI is not already feeling Grief, this will set isGrief to true and isNeutral to false.
        /// </remarks>
        public void Grief()
        {
            //  Grief execution logic goes here
            if (isGrief == false)
            {
                isGrief = true;
                isNeutral = false;
            }
        }
        
        /// <summary>
        /// Disappointment execution logic goes here
        /// </summary>
        /// <remarks>
        /// If the AI is not already feeling Disappointment, this will set isDisappointment to true and isNeutral to false.
        /// </remarks>
        public void Disappoint()
        {
            // Disappointment execution logic goes here
            if (isDisappoint == false)
            {
                isDisappoint = true;
                isNeutral = false;
            }
        }
        
        /// <summary>
        /// Envy execution logic goes here
        /// </summary>
        /// <remarks>
        /// If the AI is not already feeling Envy, this will set isEnvy to true and isNeutral to false.
        /// </remarks>
        public void Envy()
        {
            // Envy execution logic goes here
            if (isEnvy == false)
            {
                isEnvy = true;
                isNeutral = false;
            }
        }
        
        /// <summary>
        /// Loyalty execution logic goes here
        /// </summary>
        /// <remarks>
        /// If the AI is not already feeling Loyalty, this will set isLoyal to true and isNeutral to false.
        /// </remarks>
        public void Loyalty()
        {
            // Loyalty execution logic goes here
            if (isLoyal == false)
            {
                isLoyal = true;
                isNeutral = false;
            }
        }
        
        /// <summary>
        /// Faith execution logic goes here
        /// </summary>
        /// <remarks>
        /// If the AI is not already feeling Faith, this will set isFaith to true and isNeutral to false.
        /// </remarks>
        public void Faith()
        {
            // Faith execution logic goes here
            if (isFaith == false)
            {
                isFaith = true;
                isNeutral = false;
            }
        }
        
        /// <summary>
        /// Doubt execution logic goes here
        /// </summary>
        /// <remarks>
        /// If the AI is not already feeling Doubt, this will set isDoubt to true and isNeutral to false.
        /// </remarks>
        public void Doubt()
        {
            // Doubt execution logic goes here
            if (isDoubt == false)
            {
                isDoubt = true;
                isNeutral = false;
            }
        }

        /// <summary>
        /// Eager execution logic goes here
        /// </summary>
        /// <remarks>
        /// If the AI is not already feeling Eager, this will set isEager to true and isNeutral to false.
        /// </remarks>
        public void Eager() 
        {
            // Enthusiasm execution logic goes here
            if (isEager == false)
            {
                isEager = true;
                isNeutral = false;
            }
        }
        
        /// <summary>
        /// Interest execution logic goes here
        /// </summary>
        /// <remarks>
        /// If the AI is not already feeling Interest, this will set isInterest to true and isNeutral to false.
        /// </remarks>
        public void Interest()
        {
            // Interest execution logic goes here
            if (isInterest == false)
            {
                isInterest = true;
                isNeutral = false;
            }
        }
        
        /// <summary>
        /// Disinterest execution logic goes here
        /// </summary>
        /// <remarks>
        /// If the AI is not already feeling Disinterest, this will set isDisinterest to true and isNeutral to false.
        /// </remarks>
        public void Disinterest()
        {
            // Disinterest execution logic goes here
            if (isDisinterest == false)
            {
                isDisinterest = true;
                isNeutral = false;
            }
        }
    }
}