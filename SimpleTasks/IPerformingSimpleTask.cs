namespace SimpleTasks
{
    interface ISimpleTask
    {
        string Name { get; }
        void Execute();
    }
}
