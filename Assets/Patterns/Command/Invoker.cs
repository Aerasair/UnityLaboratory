namespace Assets.Patterns.Command
{
    class Invoker
    {
        private ICommand command;

        public void RunCom(ICommand command)
        {
            this.command = command;
            this.command.Execute();
        }

        public void PressUndo()
        {
            command.Undo();
        }
    }
}
