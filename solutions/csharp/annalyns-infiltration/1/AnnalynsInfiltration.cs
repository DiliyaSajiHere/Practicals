static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        if ( knightIsAwake == false ){
            return true;
        }
        else{
            return false;
        }
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanFastAttack() method");
        
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        if( knightIsAwake == true || archerIsAwake == true || prisonerIsAwake == true ){
            return true;
        }
        else{
            return false;
        }
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanSpy() method");
        
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        if ( prisonerIsAwake == true && archerIsAwake == false){
            return true;
        }
        else{
            return false;
        }
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanSignalPrisoner() method");
        
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if( petDogIsPresent == true){
            if( archerIsAwake == false)
                return true;
            else
                return false;
        }
        else{
            if(prisonerIsAwake == true && knightIsAwake == false && archerIsAwake == false){
                return true;
            }
             else if (prisonerIsAwake == false && knightIsAwake == false && archerIsAwake == false) {
                return false;
                }
        
            else {
                return false;
            }
        }
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanFreePrisoner() method");
        
    }
}
