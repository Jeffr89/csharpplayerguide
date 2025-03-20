public interface ICharacterAttackAction : ICharacterAction
{
    public int Damage { get; protected set; }
    void Run(Character character, Character target);
    void ICharacterAction.Run(Character character)
    {
        throw new NotSupportedException("This action need a target.");
    }

}
