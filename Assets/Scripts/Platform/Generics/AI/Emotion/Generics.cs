namespace PolyBuzzToVRChat.Platform.Generics.AI.Emotion
{
    public interface IAIEmotion
    {
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

        public void Comfort()
        {
            // Comfort execution logic goes here
            if (isComfort != false)
            {
                isComfort = true;
                isNeutral = false;
            }
        }

        public void Surprise()
        {
            // Surprise execution logic goes here
            if (isSurprise == false)
            {
                isSurprise = true;
                isNeutral = false;
            }
        }

        public void Annoy()
        {
            // Annoyance execution logic goes here
            if (isAnnoy == false)
            {
                isAnnoy = true;
                isNeutral = false;
            }
        }

        public void Boredom()
        {
            // Boredom execution logic goes here
            if (isBoredom == false)
            {
                isBoredom = true;
                isNeutral = false;
            }
        }

        public void Disgust()
        {
            // Disgust execution logic goes here
            if (isDisgust == false)
            {
                isDisgust = true;
                isNeutral = false;
            }
        }

        public void Fear()
        {
            // Fear execution logic goes here
            if (isFear == false)
            {
                isFear = true;
                isNeutral = false;
            }
        }

        public void Angry()
        {
            // Anger execution logic goes here
            if (isAngry == false)
            {
                isAngry = true;
                isNeutral = false;
            }
        }

        public void Happy()
        {
            // Happiness execution logic goes here
            if (isHappy == false)
            {
                isHappy = true;
                isNeutral = false;
            }
        }
        public void Sad()
        {
            // Sadness execution logic goes here
            if (isSad == false)
            {
                isSad = true;
                isNeutral = false;
            }
        }
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
            }
        }
        public void Excite()
        {
            // Excitement execution logic goes here
            if (isExcite == false)
            {
                isExcite = true;
                isNeutral = false;
            }
        }
        public void Admire()
        {
            // Admiration execution logic goes here
            if (isAdmire == false)
            {
                isAdmire = true;
                isNeutral = false;
            }
        }
        public void Appreciate()
        {
            // Appreciation execution logic goes here
            if (isAppreciate == false)
            {
                isAppreciate = true;
                isNeutral = false;
            }
        }
        public void Respect()
        {
            // Respect execution logic goes here
            if (isRespect == false)
            {
                isRespect = true;
                isNeutral = false;
            }
        }
        public void Love()
        {
            // Love execution logic goes here
            if (isLove == false)
            {
                isLove = true;
                isNeutral = false;
            }
        }
        public void Trust()
        {
            // Trust execution logic goes here
            if (isTrust == false)
            {
                isTrust = true;
                isNeutral = false;
            }
        }
        public void Anticipate()
        {
            // Anticipation execution logic goes here
            if (isAnticipate == false)
            {
                isAnticipate = true;
                isNeutral = false;
            }
        }
        public void Disapprove()
        {
            // Disapproval execution logic goes here
            if (isDisapprove == false)
            {
                isDisapprove = true;
                isNeutral = false;
            }
        }
        public void Awe()
        {
            // Awe execution logic goes here
            if (isAwe == false)
            {
                isAwe = true;
                isNeutral = false;
            }
        }
        public void Pride()
        {
            // Pride execution logic goes here
            if (isPride == false)
            {
                isPride = true;
                isNeutral = false;
            }
        }
        public void Humility()
        {
            // Humility execution logic goes here
            if (isHumility == false)
            {
                isHumility = true;
                isNeutral = false;
            }
        }
        public void Humor()
        {
            // Humor execution logic goes here
            if (isHumorous == false)
            {
                isHumorous = true;
                isNeutral = false;
            }
        }
        public void Confidence()
        {
            // Confidence execution logic goes here
            if (isConfident == false)
            {
                isConfident = true;
                isNeutral = false;
            }
        }
        public void Embarrass()
        {
            // Embarrassment execution logic goes here
            if (isEmbarrass == false)
            {
                isEmbarrass = true;
                isNeutral = false;
            }
        }
        public void Guilt()
        {
            // Guilt execution logic goes here
            if (isGuilt == false)
            {
                isGuilt = true;
                isNeutral = false;
            }
        }
        public void Shame()
        {
            // Shame execution logic goes here
            if (isShame == false)
            {
                isShame = true;
                isNeutral = false;
            }
        }   
        public void Regret()
        {
            // Regret execution logic goes here
            if (isRegret == false)
            {
                isRegret = true;
                isNeutral = false;
            }
        }
        public void Gratitude()
        {
            // Gratitude execution logic goes here
            if (isGrate == false)
            {
                isGrate = true;
                isNeutral = false;
            }
        }
        public void Sympathy()
        {
            // Sympathy execution logic goes here
            if (isSympathetic == false)
            {
                isSympathetic = true;
                isNeutral = false;
            }
        }
        public void Empathy()
        {
            // Empathy execution logic goes here
            if (isEmpathetic == false)
            {
                isEmpathetic = true;
                isNeutral = false;
            }
        }
        public void Compassion()
        {
            // Compassion execution logic goes here
            if (isCompassion == false)
            {
                isCompassion = true;
                isNeutral = false;
            }
        }
        public void Contempt()
        {
            // Contempt execution logic goes here
            if (isContempt == false)
            {
                isContempt = true;
                isNeutral = false;
            }
        }
        public void Disdain()
        {
            // Disdain execution logic goes here
            if (isDisdain == false)
            {
                isDisdain = true;
                isNeutral = false;
            }
        }
        public void Despair()
        {
            // Despair execution logic goes here
            if (isDespair == false)
            {
                isDespair = true;
                isNeutral = false;
            }
        }
        public void Hope()
        {
            // Hope execution logic goes here
            if (isHope == false)
            {
                isHope = true;
                isNeutral = false;
            }
        }
        public void Hopeless()
        {
            // Hopeless execution logic goes here
            if (isHopeless == false)
            {
                isHopeless = true;
                isNeutral = false;
            }
        }
        public void Grief()
        {
            //  Grief execution logic goes here
            if (isGrief == false)
            {
                isGrief = true;
                isNeutral = false;
            }
        }
        public void Disappoint()
        {
            // Disappointment execution logic goes here
            if (isDisappoint == false)
            {
                isDisappoint = true;
                isNeutral = false;
            }
        }
    }
    
    public sealed class EmotionFatherly : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isNeutral { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }


    public sealed class EmotionMotherly : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isNeutral { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }


    public sealed class EmotionSurprise : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }


    public sealed class EmotionComfort : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }


    public sealed class EmotionAnnoyance : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }


    public sealed class EmotionBoredom : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }


    public sealed class EmotionDisgust : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }


    public sealed class EmotionFear : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }


    public sealed class EmotionAnger : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }


    public sealed class EmotionHappy : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }


    public sealed class EmotionNeutral : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }


    public sealed class EmotionExcitement : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }
    
    public sealed class EmotionSadness : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }
    
    public sealed class EmotionChildlike : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }
    
    public sealed class EmotionAdmire : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }
    
    public sealed class EmotionAppreciate : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }
    
    public sealed class EmotionRespect : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }
    
    public sealed class EmotionLove : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }
    
    public sealed class EmotionTrust : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }
    
    public sealed class EmotionAnticipation : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }
    
    public sealed class EmotionDisapproval : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }
    
    public sealed class EmotionAwe : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }
   
        public sealed class EmotionPride : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isNeutral { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }


    public sealed class EmotionJealousy : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isNeutral { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }


    public sealed class EmotionHope : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }


    public sealed class EmotionJoy : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }


    public sealed class EmotionLoneliness : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }


    public sealed class EmotionLonging : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }


    public sealed class EmotionRegret : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }


    public sealed class EmotionShame : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }


    public sealed class EmotionGrief : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }


    public sealed class EmotionAssurance : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }


    public sealed class EmotionCare : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }


    public sealed class EmotionDisappoint : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }
    
    public sealed class EmotionCurious : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }
    
    public sealed class EmotionContempt : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }
    
    public sealed class EmotionConfident : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }
    
    public sealed class EmotionConfusion : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }
        
    public sealed class EmotionCompassion : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }
    
    public sealed class EmotionSympathy : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }
    
    public sealed class EmotionShy : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }
    
    public sealed class EmotionHumility : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }
    
    public sealed class EmotionEnvy : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }
    public sealed class EmotionJealous : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }
    public sealed class EmotionWitty : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }
    
    public sealed class EmotionSincere : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }
    
    public sealed class EmotionHumorous : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }
    public sealed class EmotionSerious : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }
    public sealed class EmotionPlayful : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }
    
    public sealed class EmotionGoofy : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }
    
    public sealed class EmotionSatisfy : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }
    public sealed class EmotionSarcastic : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }
        public sealed class EmotionRelief : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }
    
    public sealed class EmotionSly : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }
    
    public sealed class EmotionSomber : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }
    public sealed class EmotionMelancholy : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }
    public sealed class EmotionNostalgia : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }
    
    public sealed class EmotionRelax : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }
    
    public sealed class EmotionSleepy : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }
    public sealed class EmotionRage : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }
    
    public sealed class EmotionDespair : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }
    
    public sealed class EmotionGrumpy : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFear { get; set; }
        public bool isDisgust { get; set; }
        public bool isSurprise { get; set; }
        public bool isNeutral { get; set; }
        public bool isExcite { get; set; }
        public bool isAnnoy { get; set; }
        public bool isBoredom { get; set; }
        public bool isComfort { get; set; }
        public bool isMotherly { get; set; }
        public bool isFatherly { get; set; }
        public bool isChildlike { get; set; }
        public bool isAdmire { get; set; }
        public bool isAppreciate { get; set; }
        public bool isRespect { get; set; }
        public bool isLove { get; set; }
        public bool isTrust { get; set; }
        public bool isAnticipate { get; set; }
        public bool isDisapprove { get; set; }
        public bool isAwe { get; set; }
        public bool isPride { get; set; }
        public bool isHumility { get; set; }
        public bool isHumorous { get; set; }
        public bool isConfident { get; set; }
        public bool isEmbarrass { get; set; }
        public bool isGuilt { get; set; }
        public bool isShame { get; set; }
        public bool isRegret { get; set; }
        public bool isGrate { get; set; }
        public bool isSympathetic { get; set; }
        public bool isEmpathetic { get; set; }
        public bool isCompassion { get; set; }
        public bool isContempt { get; set; }
        public bool isDisdain { get; set; }
        public bool isDespair { get; set; }
        public bool isEnvious { get; set; }
        public bool isJealous { get; set; }
        public bool isFrustrate { get; set; }
        public bool isHope { get; set; }
        public bool isHopeless { get; set; }
        public bool isGoofy { get; set; }
        public bool isDisappoint { get; set; }
        public bool isMistrust { get; set; }
        public bool isPlay { get; set; }
        public bool isRelax { get; set; }
        public bool isRelief { get; set; }
        public bool isGrumpy { get; set; }
        public bool isEnvy { get; set; }
        public bool isConfusion { get; set; }
        public bool isGrief { get; set; }
        public bool isRage { get; set; }
        public bool isPanic { get; set; }
        public bool isSorrow { get; set; }
        public bool isAnger { get; set; }
        public bool isHate { get; set; }
        public bool isJoy { get; set; }
    }
}