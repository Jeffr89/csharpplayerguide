public class Party
{
    public List<Character> Members { get; private set; }
    public int NextMemberToPlay { get; private set; } = 0;

    public int MemberCount { get; private set; }
    public PlayerType ControlledBy { get; private set; }


    public Party(List<Character> members, PlayerType controlledBy)
    {
        Members = members;
        MemberCount = Members.Count;
        ControlledBy = controlledBy;
    }

    public Character GetNextMemberToPlay()
    {
        if (NextMemberToPlay == MemberCount) NextMemberToPlay = 0;
        if (NextMemberToPlay == 0) return Members[NextMemberToPlay];
        else
        {
            NextMemberToPlay++;
            return Members[NextMemberToPlay];
        }
    }

    public enum PlayerType
    {
        Human,
        Computer
    }
}



