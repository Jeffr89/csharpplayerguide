public interface ICharacterAction
{
    string Name { get; protected set; }
    void Run(Character character);

}
