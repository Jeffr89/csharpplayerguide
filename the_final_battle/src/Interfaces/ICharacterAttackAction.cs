public interface ICharacterAttackAction : ICharacterAction
{
    void Run(Character character, Character target);
    void ICharacterAction.Run(Character character)
    {
        throw new NotSupportedException("This action need a target.");
    }

}
