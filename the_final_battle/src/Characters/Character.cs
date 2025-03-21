public abstract class Character(string name)
{
    public string Name { get; protected set; } = name;
    public int MaxHP { get; protected set; }
    public int CurrentHP { get; protected set; }

    public bool isDead = false;

    public event Action<Character> OnDeath;

    public List<ICharacterAction> Actions { get; private set; } = new List<ICharacterAction>();

    public void TakeDamage(int dmg)
    {
        if (CurrentHP > 0)
        {
            CurrentHP = Math.Max(CurrentHP - dmg, 0);
            Console.WriteLine($"{Name} is now at {CurrentHP}/{MaxHP} HP.");
        }

        if (CurrentHP <= 0)
        {
            Die();
        }
    }

    public void PlayAction(int actionNumber, TheFinalBattleGameSingleBattle theFinalBattle)
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

    public void Die()
    {
        isDead = true;
        Console.WriteLine($"{Name} has been defeated!");
        OnDeath?.Invoke(this);
    }
}

