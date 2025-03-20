public abstract class Character
{
    public string Name { get; protected set; }
    public int MaxHP { get; protected set; }
    public int CurrentHP { get; protected set; }

    public List<ICharacterAction> Actions { get; private set; }

    public void GetDamage(int dmg)
    {
        if (CurrentHP > 0)
        {
            CurrentHP -= dmg;
        }

        if (CurrentHP < 0) CurrentHP = 0;

    }
    public Character(string name)
    {
        Name = name;
        Actions = new List<ICharacterAction>();
    }

    public void PlayAction(int actionNumber, TheFinalBattleGame theFinalBattle)
    {

        switch (Actions[actionNumber])
        {
            case ICharacterAttackAction attack:
                Party enemyParty = theFinalBattle.partyToPlay == theFinalBattle.Heroes ? theFinalBattle.Monsters : theFinalBattle.Heroes;
                attack.Run(this, enemyParty.Members[0]);
                break;
            case ICharacterAction action:
                action.Run(this);
                break;
        }

    }
}

