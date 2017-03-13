using System.Collections.Generic;

namespace WowPacketParser.Messages.Submessages
{
    public unsafe struct PetBattleRoundResult
    {
        public int CurRound;
        public sbyte NextPetBattleState;
        public List<PetBattleEffect> Effects;
        public List<sbyte> PetXDied;
        public List<PetBattleActiveAbility> Cooldowns;
        public fixed byte NextInputFlags[2];
        public fixed sbyte NextTrapStatus[2];
        public fixed ushort RoundTimeSecs[2];
    }
}