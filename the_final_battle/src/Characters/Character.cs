public abstract class Character
{
    public string Name { get; private set; }
    public List<ICharacterAction> Actions { get; private set; }


    public Character(string name)
    {
        Name = name;
        Actions = new List<ICharacterAction>();
    }

    public void PlayAction(int actionNumber)
    {
        Actions[actionNumber].Run(this);
    }
}

