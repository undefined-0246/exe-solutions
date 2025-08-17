static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake) => !knightIsAwake;


    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake) => knightIsAwake || archerIsAwake || prisonerIsAwake;


    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake) => prisonerIsAwake && !archerIsAwake;

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if (prisonerIsAwake)
        {
            if (petDogIsPresent)
            {
                if (archerIsAwake)
                    return false;

                return true;
            }
            else
            {
                if (!archerIsAwake && !knightIsAwake)
                    return true;

                return false;
            }
        }
        else
        {
            return (petDogIsPresent && !archerIsAwake && knightIsAwake) || (petDogIsPresent && !archerIsAwake && !knightIsAwake && !prisonerIsAwake);
        }
    }
}
