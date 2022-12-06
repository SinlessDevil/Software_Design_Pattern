using System.Collections.Generic;
using UnityEngine;
namespace Command
{
    public class User
    {
        // Initializers
        Calculator calculator = new Calculator();
        List<Command> commands = new List<Command>();
        int current = 0;
        public void Redo(int levels)
        {
            Debug.Log($"\n---- Redo {levels} levels ");
            // Perform redo operations
            for (int i = 0; i < levels; i++)
            {
                if (current < commands.Count - 1)
                {
                    Command command = commands[current++];
                    command.Execute();
                }
            }
        }
        public void Undo(int levels)
        {
            Debug.Log("\n---- Undo {levels} levels ");

            // Perform undo operations
            for (int i = 0; i < levels; i++)
            {
                if (current > 0)
                {
                    Command command = commands[--current] as Command;
                    command.UnExecute();
                }
            }
        }
        public void Compute(char @operator, int operand)
        {
            // Create command operation and execute it
            Command command = new CalculatorCommand(calculator, @operator, operand);
            command.Execute();
            // Add command to undo list
            commands.Add(command);
            current++;
        }
    }
}