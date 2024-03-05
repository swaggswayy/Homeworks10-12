namespace Assets.Homework11.Scripts
{
    public interface IEnemyVisitor
    {
        void Visit(Ork ork);
        void Visit(Elf elf);
        void Visit(Human human);
    }
}
