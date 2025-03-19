public interface ICharacterAction
{
    string Name { get; set; }
    void Run(Character character);

}
